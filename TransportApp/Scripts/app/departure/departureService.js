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

        function getStopDepartures(routeType, stopId) {
            var queryString = `api/departures/route_type/${routeType}/stop/${stopId}`;
            return $http.get(queryString);
        }
    }

})();