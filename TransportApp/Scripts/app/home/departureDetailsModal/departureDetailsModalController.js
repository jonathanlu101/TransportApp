(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('departureDetailsModalController', departureDetailsModalController);

    departureDetailsModalController.$inject = ['$uibModalInstance', 'departure'];

    function departureDetailsModalController($uibModalInstance, departure) {

        var vm = this;
        vm.departure = departure;

    }
})();
