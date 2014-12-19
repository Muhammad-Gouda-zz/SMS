(function(){
    var app = angular.module("smsApp", []);
    app.controller("studentController", function ($http) {
        var self = this;
        self.helper = { message: "", error: "" };
        
        Globalize.culture("ar-EG");
       
        //JQuery Globalize Library sample
        // self.helper.message = Globalize.format(2312312, "c");//Globalize.parseFloat("234.66").toString()
        self.helper.message = Globalize.cultures["ar-EG"].messages.success;
        self.method = function (s) {
            alert(s.FirstName);
        }
        self.getAllStudents = function () {            
            $http.get("/api/StudentApi").
                success(function (data, status, headers, config) {
                    self.students = data;
                    //self.helper.message = localize("success", "AR");
            }).error(function (data, status, headers, config) {
                //self.helper.message = localize("error", "AR");
            });
        };

    });
})();