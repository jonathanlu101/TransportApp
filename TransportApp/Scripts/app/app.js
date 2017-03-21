(function () {
    'use strict';

    angular.module('TransportApp', ['ui.router', 'ngAnimate', 'ngMessages', 'ngMaterial'])
        .config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function ($stateProvider, $urlRouterProvider, $locationProvider) {

            $locationProvider.html5Mode(true);

            $stateProvider.state('home', {
                url: '/home',
                templateUrl: 'angularviews/_home.html',
                controller: 'HomeCtrl',
                controllerAs: 'homeVm'
            });

            $urlRouterProvider.otherwise('home');
        }]);
})();