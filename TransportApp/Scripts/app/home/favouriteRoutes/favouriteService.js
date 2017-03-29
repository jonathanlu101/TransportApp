(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('favouriteService', favouriteService);

    favouriteService.$inject = ['$http'];

    function favouriteService($http) {
        var service = {
            getRoutes: getRoutes,
            createRoute: createRoute
        };

        function getRoutes() {
            var queryString = 'api/favourites/routes';
            return $http.get(queryString);
        }

        function createRoute(data) {
            var queryString = 'api/favourites/routes';
            return $http.post(queryString, data);
        }

        return service;
    }
})();