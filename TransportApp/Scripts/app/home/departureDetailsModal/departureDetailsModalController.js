(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('departureDetailsModalController', departureDetailsModalController);

    departureDetailsModalController.$inject = ['$scope', '$uibModalInstance', 'departure'];

    function departureDetailsModalController($scope, $uibModalInstance, departure) {

        var vm = this;
        vm.departure = departure;

        for (var i = 0; i < departure.runPattern.length; i++) {
            var currentDeparture = departure.runPattern[i];
            if (currentDeparture.stop.stopId == departure.stopId) {
                currentDeparture.selectedDeparture = true;
            };
        }
    }
})();
