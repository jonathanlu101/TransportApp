(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('departureService', departureService);

    departureService.$inject = ['$http'];

    function departureService($http) {
        var service = {
            getDepartures: getDepartures
        };

        return service;

        function getDepartures(routeType, stopId, options = {}) {

            var queryString = `api/departures/route_type/${routeType}/stop/${stopId}`;

            if (options.routeId)
                queryString = queryString + `/route/${options.routeId}`;
            queryString = queryString + '?'

            if (options.directionId)
                queryString = queryString + `direction_id=${options.directionId}&`;
            if (options.maxResults)
                queryString = queryString + `max_results=${options.maxResults}&`;
              
            return $http.get(queryString);
        }
    }

})();