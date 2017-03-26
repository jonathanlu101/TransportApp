﻿(function () {
    'use strict';

    angular
        .module('TransportApp')
        .factory('authInterceptorService', authInterceptorService);

    authInterceptorService.$inject = ['$q', '$rootScope', 'localStorageService'];

    function authInterceptorService($q, $rootScope, localStorageService) {

        var authInterceptorServiceFactory = {};

        var _request = function (config) {

            config.headers = config.headers || {};

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                config.headers.Authorization = 'Bearer ' + authData.token;
            }

            return config;
        }

        var _responseError = function (rejection) {
            if (rejection.status === 401) {
                $rootScope.$emit("unauthorized");
            }
            return $q.reject(rejection);
        }

        authInterceptorServiceFactory.request = _request;
        authInterceptorServiceFactory.responseError = _responseError;

        return authInterceptorServiceFactory;
    }
})();