var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/business", {
        templateUrl : "views/pages/business.html",
        controller: 'business'
    })
    .when("/job", {
        templateUrl : "views/pages/job.html",
        controller: 'job'
    })
    .when("/freelance", {
        templateUrl : "views/pages/freelance.html",
        controller: 'freelance'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
