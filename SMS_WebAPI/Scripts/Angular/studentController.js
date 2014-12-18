(function(){
    var app = angular.module("smsApp", []);
    app.controller("studentController", function ($http) {
        var self = this;
        self.helper = { message: "Loading...", error: "error" };
        //self.students = [{ "firstName": "A" }, { "firstName": "B" }];
        //var localize = function (key, culture) {
        //    var localizedText = "hello from localizer";
        //    if (culture.toLowerCase() === 'en')
        //        localizedText = resource_En[key];
        //    if (culture.toLowerCase() === 'ar')
        //        localizedText = resource_Ar[key];
        //    return localizedText;
        //}
        self.helper.message = localize("success", "AR");// success;
        self.getAllStudents = function () {
            
            $http.get("/api/StudentApi").
                success(function (data, status, headers, config) {
                    self.students = data;
                    self.helper.message = localize("success", "AR");// success;
            }).error(function (data, status, headers, config) {
                self.helper.message = "عذرا .. تعذر الاتصال ، رجاء حاول مرة أخرى أو اتصل بالدعم الفني";                
            });
        };

    });
})();