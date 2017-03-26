(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('loginController', loginController);

    loginController.$inject = ['$state','authService'];

    function loginController($state, authService) {

        var vm = this;

        vm.login = function () {
            authService.login(vm.loginData).then(function (response) {
                $state.go('home');
            }, function (response) {
                vm.message = response.data.error_description;
            });
        };
    }
})();
