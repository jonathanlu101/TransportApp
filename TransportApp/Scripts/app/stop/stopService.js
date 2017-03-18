(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('stopService', stopService);

    stopService.$inject = ['$http'];

    function stopService($http) {
        var service = {
            getNearbyStops: getNearbyStops
        };

        return service;

        function getNearbyStops(latitude, longitude) {
            return $http.get(`api/stops/nearby?latitude=${latitude}&longitude=${longitude}`);
        }
    }
})();