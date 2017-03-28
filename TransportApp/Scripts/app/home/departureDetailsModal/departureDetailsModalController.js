(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('departureDetailsModalController', departureDetailsModalController);

    departureDetailsModalController.$inject = ['$uibModalInstance', 'departure'];

    function departureDetailsModalController($uibModalInstance, departure) {

        var vm = this;
        console.log(departure);
        vm.departure = departure;

        vm.ok = function () {
            $uibModalInstance.close("asdf");
        };

        vm.cancel = function () {
            $uibModalInstance.dismiss('cancel');
        };

    }
})();
