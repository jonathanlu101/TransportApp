(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('departureDetailsModalController', departureDetailsModalController);

    departureDetailsModalController.$inject = ['$uibModalInstance'];

    function departureDetailsModalController($uibModalInstance, departure) {

        var vm = this;

        vm.ok = function () {
            $uibModalInstance.close("asdf");
        };

        vm.cancel = function () {
            $uibModalInstance.dismiss('cancel');
        };

    }
})();
