(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('favouriteService', favouriteService);

    favouriteService.$inject = ['$http','$q'];

    function favouriteService($http, $q) {

        var favouriteRoutes = [];

        var service = {
            getRoutes: getRoutes,
            createRoute: createRoute,
            getFavouriteRoutes: getFavouriteRoutes,
            deleteRoute: deleteRoute
        };

        function getFavouriteRoutes() {
            return favouriteRoutes;
        }

        function getRoutes() {
            var deferred = $q.defer();

            var queryString = 'api/favourites/routes';

            $http.get(queryString).then(function (response) {
                favouriteRoutes = response.data;
                deferred.resolve(response);
            },function (response) {
                deferred.reject(response);
            });

            return deferred.promise;
        }

        function createRoute(data) {
            var deferred = $q.defer();

            var queryString = 'api/favourites/routes';
            $http.post(queryString, data).then(function (response) {
                favouriteRoutes.push(data);
                deferred.resolve(response);
            });

            return deferred.promise;
        }

        function deleteRoute(id) {
            var queryString = 'api/favourites/routes/' + id;
            return $http.delete(queryString);
        }

        return service;
    }
})();