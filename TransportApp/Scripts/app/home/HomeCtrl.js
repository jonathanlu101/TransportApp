(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('HomeCtrl', HomeCtrl);

    HomeCtrl.$inject = ['$location', 'stopService', 'departureService'];

    function HomeCtrl($location, stopService, departureService) {
        var vm = this;

        vm.getNearbyStops = function () {
            navigator.geolocation.getCurrentPosition(function (position) {

                let latitude = position.coords.latitude;
                let longitude = position.coords.longitude;

                stopService.getNearbyStops(latitude, longitude).then(function (response) {
                        vm.nearbyStops = response.data;
                    });
            }, function () {
                alert("Couldn't grab your location");
            });
        };

        vm.toogleStopDepartures = function (stop) {
            if (!stop.departures || stop.departures.length == 0) {
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
    }
})();
