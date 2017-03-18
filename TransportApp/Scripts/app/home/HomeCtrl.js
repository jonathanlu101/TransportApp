(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('HomeCtrl', HomeCtrl);

    HomeCtrl.$inject = ['$location', 'stopService'];

    function HomeCtrl($location, stopService) {
        var vm = this;

        vm.title = 'HomeCtrl';

        vm.getGPSCordinates = function () {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    vm.latitude = position.coords.latitude;
                    vm.longitude = position.coords.longitude;
                    stopService.getNearbyStops(vm.latitude, vm.longitude).then(function (response) {
                        console.log(response);
                    });
                });
            } else {
                alert("Geolocation is not supported by this browser.");
            }
        };
    }
})();
