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

        vm.showStopDepatures = function (stop) {
            departureService.getStopDepartures(function () {

            }, function () {
                alert("Couldn't get departures for Stop " + stop.stop_name);
            });
        }
    }
})();
