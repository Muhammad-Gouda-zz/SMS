(function(){
    var app = angular.module('smsApp', []);
    app.controller('studentController', function () {
        var self = this;
        self.helper = { message: "Loading...", error: "Error" };
        alert('gouda');
    });
})();