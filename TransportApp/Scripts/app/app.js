(function () {
    'use strict';

    var myApp = angular.module('TransportApp', ['ui.router', 'ngAnimate', 'ngMessages', 'ngMaterial', 'smart-table', 'LocalStorageModule']);

   
    myApp.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider', function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider) {

        $locationProvider.html5Mode(true);

        $httpProvider.interceptors.push('authInterceptorService');

        $stateProvider.state('home', {
            url: '/home',
            templateUrl: 'angularviews/_home.html',
            controller: 'homeController',
            controllerAs: 'vm'
        });

        $stateProvider.state('login', {
            url: '/login',
            templateUrl: 'angularviews/_login.html',
            controller: 'loginController',
            controllerAs: 'vm'
        });

        $urlRouterProvider.otherwise('home');
    }]);

    myApp.run(['authService', '$rootScope', function (authService, $rootScope) {
        authService.fillAuthData();

        $rootScope.$on('unauthorized', () => {
            $state.go('login');
        });

    }]);

})();