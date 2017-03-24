(function () {
    'use strict';

    angular.module('TransportApp').filter('timeFromNow', function () {
        return function (input) {
            var date = new Date(input);
            var now = new Date();

            var differenceMs = date.getTime() - now.getTime();
            var differenceMinutes = Math.floor(differenceMs / (1000 * 60)); 

            if (differenceMinutes < 60) {
                var differenceString = differenceMinutes + "m";
            } else {
                var hours = Math.floor(differenceMinutes / 60);
                var minutes = differenceMinutes % 60;
                var differenceString = `${hours}h ${minutes}m`;
            }
             
            return differenceString;
        }
    });

})();