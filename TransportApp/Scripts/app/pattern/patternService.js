(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('patternService', patternService);

    patternService.$inject = ['$http'];

    function patternService($http) {
        var service = {
            getRunPattern: getRunPattern
        };

        return service;

        function getRunPattern(runId, routeType) {
            var queryString = `api/patterns/run/${runId}/route_type/${routeType}`; 
            return $http.get(queryString);
        }
    }

})();