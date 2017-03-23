(function () {
    'use strict';

    angular.module('TransportApp').filter('dateFilter', function () {
        return function (input) {
            var date = new Date(input);
            return date.getMonth();
        }
    });

})();