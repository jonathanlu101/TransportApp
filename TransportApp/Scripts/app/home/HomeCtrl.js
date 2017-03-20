(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('HomeCtrl', HomeCtrl);

    HomeCtrl.$inject = ['$location', 'stopService'];

    function HomeCtrl($location, stopService) {
        var vm = this;

        vm.getNearbyStops = function () {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {

                    let latitude = position.coords.latitude;
                    let longitude = position.coords.longitude;

                    stopService.getNearbyStops(latitude, longitude).then(function (response) {
                            vm.nearbyStops = response.data;
                        });
                });
            } else {
                alert("Geolocation is not supported by this browser.");
            }
        };
    }
})();
