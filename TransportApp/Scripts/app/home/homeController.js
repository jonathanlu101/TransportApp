(function () {
    'use strict';

    angular
        .module('TransportApp')
        .controller('homeController', homeController);

    homeController.$inject = ['$location', 'stopService', 'departureService'];

    function homeController($location, stopService, departureService, $uibModal) {
        var vm = this;
    }
})();
