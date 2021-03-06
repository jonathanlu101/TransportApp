﻿(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('nearbyStopsController', nearbyStopsController);

    nearbyStopsController.$inject = ['$location', 'departureService', 'stopService', 'favouriteService', '$uibModal'];

    function nearbyStopsController($location, departureService, stopService, favouriteService, $uibModal) {

        var vm = this;
        vm.alerts = [];

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
                    stop.showDepartures = true;
                }, function () {
                    alert("Couldn't get departures for Stop " + stop.stopName);
                });
            } else if (!stop.showDepartures) {
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
            favouriteService.createRoute(newRouteData).then(function () {
                vm.alerts.push({ type: 'success', msg: "You have favourited (" + stop.stopName + "/" + departure.routeNumber + " " + departure.directionName + ")" });
            });
        }

        vm.closeAlert = function (index) {
            vm.alerts.splice(index, 1);
        };

    }
})();
