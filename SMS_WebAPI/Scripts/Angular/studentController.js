(function(){
    var app = angular.module("smsApp", []);
    app.controller("studentController", function ($http) {
        var self = this;
        Globalize.culture("ar-EG");
        self.helper = { message: "", error: "" };
        //JQuery Globalize Library sample
        // self.helper.message = Globalize.format(2312312, "c");//Globalize.parseFloat("234.66").toString()
        self.helper.message = Globalize.cultures["ar-EG"].messages.loading;

        self.getAllStudents = function () {
            $http.get("/api/StudentApi").
                success(function (data, status, headers, config) {
                    self.students = data;
                    self.helper.message = "";
            }).error(function (data, status, headers, config) {
                self.helper.message = Globalize.cultures["ar-EG"].messages.error;
            });
        };

    });
})();