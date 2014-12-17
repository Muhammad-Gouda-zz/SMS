(function(){
    var app = angular.module("smsApp", []);
    app.controller("studentController", function ($http) {
        var self = this;
        self.helper = { message: "Loading...", error: "Error" };
        //self.students = [{ "firstName": "A" }, { "firstName": "B" }];

        self.getAllStudents = function () {
            
            $http.get("/api/StudentApi").
                success(function (data, status, headers, config) {
                    self.students = data;
                    self.helper.message = success;
            }).error(function (data, status, headers, config) {
                self.helper.message = "عذرا .. تعذر الاتصال ، رجاء حاول مرة أخرى أو اتصل بالدعم الفني";                
            });
        };

    });
})();