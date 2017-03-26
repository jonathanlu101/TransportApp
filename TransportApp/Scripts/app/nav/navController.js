(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('navController', navController);

    navController.$inject = ['$state', 'authService'];

    function navController($state, authService) {

        var vm = this;

        vm.authentication = authService.authentication;

        vm.logOut = function () {
            authService.logOut();
            $state.go('home');
        }
    }
})();
