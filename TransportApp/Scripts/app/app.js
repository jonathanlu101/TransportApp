(function () {
    'use strict';

    var myApp = angular.module('TransportApp', ['ui.router', 'ngAnimate', 'ngMessages', 'ngMaterial', 'smart-table', 'LocalStorageModule', 'ui.bootstrap', 'angular-loading-bar']);

   
    myApp.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider', 'cfpLoadingBarProvider',
        function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider, cfpLoadingBarProvider) {

            $locationProvider.html5Mode(true);

            cfpLoadingBarProvider.includeBar = true;

            $httpProvider.interceptors.push('authInterceptorService');

            $stateProvider.state('home', {
                url: '/',
                views: {
                    '': {
                        templateUrl: 'angularviews/home/_home.html',
                        controller: 'homeController',
                        controllerAs: 'vm'
                    },
                    'favouriteRoutes@home': {
                        templateUrl: 'angularviews/home/favouriteRoutes/_favouriteRoutes.html',
                        controller: 'favouriteRoutesController',
                        controllerAs: 'vm'
                    }, 
                    'nearbyStops@home': {
                        templateUrl: 'angularviews/home/nearbyStops/_nearbyStops.html',
                        controller: 'nearbyStopsController',
                        controllerAs: 'vm'
                    }
                }
            });

            $stateProvider.state('login', {
                url: '/login',
                templateUrl: 'angularviews/login/_login.html',
                controller: 'loginController',
                controllerAs: 'vm'
            });

            $urlRouterProvider.otherwise('/');
    }]);

    myApp.run(['authService', '$rootScope', function (authService, $rootScope) {
        authService.fillAuthData();

        $rootScope.$on('unauthorized', () => {
            $state.go('login');
        });

    }]);

})();