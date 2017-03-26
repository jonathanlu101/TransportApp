(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('homeController', homeController);

    homeController.$inject = ['$location', 'stopService', 'departureService', 'favouriteService'];

    function homeController($location, stopService, departureService, favouriteService) {
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
                departureService.getStopDepartures(stop.routeType, stop.stopId).then(function (response) {
                    stop.departures = response.data;
                }, function () {
                    alert("Couldn't get departures for Stop " + stop.stop_name);
                });
            }

            if (!stop.showDepartures) {
                stop.showDepartures = true;
            } else {
                stop.showDepartures = false;
            }
        }

        vm.getFavouriteRoutes = function() {

            favouriteService.getRoutes().then(function (response) {
                console.log(response.data);
                vm.favouriteRoutes = response.data;
            }, function (response) {
                alert("Couldn't get your favourite routes");
            });
        }

        vm.getFavouriteRoutes();
    }
})();
