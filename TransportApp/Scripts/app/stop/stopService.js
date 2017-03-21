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

            let queryString = `api/stops/nearby?latitude=${latitude}&longitude=${longitude}`;

            return $http.get(queryString);
        }
    }
})();