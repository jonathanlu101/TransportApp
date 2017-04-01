(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('departureDetailsModalController', departureDetailsModalController);

    departureDetailsModalController.$inject = ['$uibModalInstance', 'departure'];

    function departureDetailsModalController($uibModalInstance, departure) {

        var vm = this;
        vm.departure = departure;

        for (var i = 0; i < departure.runPattern.length; i++) {
            var currentDeparture = departure.runPattern[i];
            if (currentDeparture.stop.stopId == departure.stopId) {
                currentDeparture.selectedDeparture = true;
            };
        }

        console.log(departure);
    }
})();
