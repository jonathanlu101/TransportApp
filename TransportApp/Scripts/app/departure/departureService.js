(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('departureService', departureService);

    departureService.$inject = ['$http'];

    function departureService($http) {
        var service = {
            getStopDepartures: getStopDepartures
        };

        return service;

        function getStopDepartures(stopId, routeType) {
            let queryString = `api/departures/${routeType}/2/stop/${stopId}`;
            return $http.get(queryString);
        }
    }
})();