﻿(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('favouriteRoutesController', favouriteRoutesController);

    favouriteRoutesController.$inject = ['$scope', '$log', 'favouriteService', 'departureService', '$uibModal', 'patternService' ];

    function favouriteRoutesController($scope, $log, favouriteService, departureService, $uibModal, patternService) {

        var vm = this;
        vm.alerts = [];

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
                var newMaxResults = favRoute.visibleDeparturesCount + 5 || 10;
                console.log(newMaxResults);
                if (newMaxResults > favRoute.departures.length) {
                    var options = {
                        routeId: favRoute.routeId,
                        directionId: favRoute.directionId,
                        maxResults: newMaxResults
                    };
                    departureService.getDepartures(favRoute.routeType, favRoute.stopId, options).then(function (response) {
                        favRoute.departures = response.data;
                        favRoute.visibleDeparturesCount = favRoute.departures.length;
                    }, function () {
                        alert("Couldn't get departures for Route " + favRoute.stopName);
                    });
                } else {
                    favRoute.visibleDeparturesCount = favRoute.visibleDeparturesCount + 5;
                }
            }
        }

        vm.showLessFavouriteDepartures = function (favRoute) {
            if (favRoute.visibleDeparturesCount > 5) {
                favRoute.visibleDeparturesCount = favRoute.visibleDeparturesCount - 5;
            }
        }

        vm.openFavouriteRouteDepartureModal = function (favRoute, departure) {

            departure.directionName = favRoute.directionName;
            departure.routeName = favRoute.routeName;
            departure.routeNumber = favRoute.routeNumber;
            departure.stopId = favRoute.stopId;
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

            modalInstance.result.catch(function () {
                $log.info("dismissed");
            });
        }

        vm.deleteFavouriteRoute = function (favRoute) {
            favouriteService.deleteRoute(favRoute.id).then(function (response) {
                var index = vm.favouriteRoutes.indexOf(favRoute);
                vm.favouriteRoutes.splice(index, 1);
                vm.alerts.push({ type: 'info', msg: "You have removed (" + favRoute.stopName + "/" + favRoute.routeNumber + " " + favRoute.directionName + ") from your Favourite List." });
            });
        }

        vm.closeAlert = function (index) {
            vm.alerts.splice(index, 1);
        };

        vm.getFavouriteRoutes();

    }
})();
