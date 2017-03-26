(function () {
    'use strict';

    var myApp = angular.module('TransportApp', ['ui.router', 'ngAnimate', 'ngMessages', 'ngMaterial', 'smart-table', 'LocalStorageModule']);

   
    myApp.config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider) {

            $locationProvider.html5Mode(true);

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

    myApp.run(['authService', function (authService) {
        authService.fillAuthData();
    }]);

})();