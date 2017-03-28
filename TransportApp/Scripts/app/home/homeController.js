﻿(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('homeController', homeController);

    homeController.$inject = ['$location', 'stopService', 'departureService', 'favouriteService','$uibModal'];

    function homeController($location, stopService, departureService, favouriteService, $uibModal) {
        var vm = this;

        function addDetailsToStopCollection(stopCollections) {
            var nameByRouteTypeId = {
                0: "Train",
                1: "Tram",
                2: "Bus"
            }

            for (var i = 0; i < stopCollections.length; i++) {
                let stopCollection = stopCollections[i];
                stopCollection.routeTypeName = nameByRouteTypeId[stopCollection.routeType];
            }
        }

        vm.getNearbyStops = function () {
            navigator.geolocation.getCurrentPosition(function (position) {

                let latitude = position.coords.latitude;
                let longitude = position.coords.longitude;

                stopService.getNearbyStops(latitude, longitude).then(function (response) {
                    vm.nearbyStopCollections = response.data;
                    addDetailsToStopCollection(vm.nearbyStopCollections);
                });
            }, function () {
                alert("Couldn't grab your location");
            });
        };

        vm.toogleStopDepartures = function (stop) {
            if (!stop.departures) {
                departureService.getDepartures(stop.routeType, stop.stopId).then(function (response) {
                    stop.departures = response.data;
                }, function () {
                    alert("Couldn't get departures for Stop " + stop.stopName);
                });
            }

            if (!stop.showDepartures) {
                stop.showDepartures = true;
            } else {
                stop.showDepartures = false;
            }
        }

        vm.favouriteNearbyDeparture = function (stop, departure) {
            var newRouteData = {
                stopId: stop.stopId,
                stopName: stop.stopName,
                routeId: departure.routeId,
                routeName: departure.routeName,
                routeNumber: departure.routeNumber,
                routeType: departure.routeType,
                directionId: departure.directionId,
                directionName: departure.directionName
            };
            favouriteService.createRoute(newRouteData).then(function (response) {
                vm.favouriteRoutes.push(response.data);
            });
        }

        vm.getFavouriteRoutes = function() {

            favouriteService.getRoutes().then(function (response) {
                vm.favouriteRoutes = response.data;
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
                }, function () {
                    alert("Couldn't get departures for Route " + favRoute.stopName);
                });
            }

            if (!favRoute.showDepartures) {
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

        var modalInstance = $uibModal.open({
            animation: true,
            ariaLabelledBy: 'modal-title',
            ariaDescribedBy: 'modal-body',
            templateUrl: 'angularviews/home/_departureDetailsModal.html',
            controller: 'departureDetailsModalController',
            controllerAs: 'modalVm'
        });

        vm.getFavouriteRoutes();
    }
})();
