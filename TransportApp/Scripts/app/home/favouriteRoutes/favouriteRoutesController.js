(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('favouriteRoutesController', favouriteRoutesController);

    favouriteRoutesController.$inject = ['$scope', 'favouriteService', 'departureService', '$uibModal', 'patternService' ];

    function favouriteRoutesController($scope, favouriteService, departureService, $uibModal, patternService) {

        var vm = this;

        vm.getFavouriteRoutes = function () {
            favouriteService.getRoutes().then(function (response) {
                vm.favouriteRoutes = response.data;
                $scope.$watch(favouriteService.getFavouriteRoutes, function (favouriteRoutes) {
                    vm.favouriteRoutes = favouriteRoutes;
                }.bind(vm));
            }, function (response) {
                alert("Couldn't get your favourite routes");
            });
        }

        vm.toogleFavouriteRouteDepartures = function (favRoute) {
            if (!favRoute.departures) {
                var options = {
                    routeId: favRoute.routeId,
                    directionId: favRoute.directionId,
                    maxResults: 5
                };
                departureService.getDepartures(favRoute.routeType, favRoute.stopId, options).then(function (response) {
                    favRoute.departures = response.data;
                    favRoute.showDepartures = true;
                }, function () {
                    alert("Couldn't get departures for Route " + favRoute.stopName);
                });
            } else if (!favRoute.showDepartures) {
                favRoute.showDepartures = true;
            } else {
                favRoute.showDepartures = false;
            }
        }

        vm.showMoreFavouriteDepartures = function (favRoute) {
            if (favRoute.departures) {
                var newMaxResults = favRoute.departures.length + 5;
                var options = {
                    routeId: favRoute.routeId,
                    directionId: favRoute.directionId,
                    maxResults: newMaxResults
                };
                departureService.getDepartures(favRoute.routeType, favRoute.stopId, options).then(function (response) {
                    favRoute.departures = response.data;
                }, function () {
                    alert("Couldn't get departures for Route " + favRoute.stopName);
                });
            }
        }

        vm.openFavouriteRouteDepartureModal = function (favRoute, departure) {

            departure.directionName = favRoute.directionName;
            departure.routeName = favRoute.routeName;
            departure.routeNumber = favRoute.routeNumber;
            departure.stopName = favRoute.stopName;

            var modalInstance = $uibModal.open({
                animation: true,
                ariaLabelledBy: 'modal-title',
                ariaDescribedBy: 'modal-body',
                templateUrl: 'angularviews/home/departureDetailsModal/_departureDetailsModal.html',
                controller: 'departureDetailsModalController',
                controllerAs: 'modalVm',
                resolve: {
                    departure: function () {
                        if (!departure.runPattern) {
                            return patternService.getRunPattern(departure.runId, favRoute.routeType).then(function (response) {
                                departure.runPattern = response.data;
                                return departure;
                            });
                        } else {
                            return departure;
                        }
                    }
                }
            });
        }

        vm.getFavouriteRoutes();

    }
})();
