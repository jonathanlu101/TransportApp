(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('HomeCtrl', HomeCtrl);

    HomeCtrl.$inject = ['$location', 'stopService'];

    function HomeCtrl($location, stopService) {
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
            console.log(stop);
            alert("asdf");
        }
    }
})();
