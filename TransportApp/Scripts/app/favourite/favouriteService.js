(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('favouriteService', favouriteService);

    favouriteService.$inject = ['$http'];

    function favouriteService($http) {
        var service = {
            getRoutes: getRoutes
        };

        function getRoutes() {
            var queryString = 'api/favourites/routes';
            return $http.get(queryString);
        }

        return service;
    }
})();