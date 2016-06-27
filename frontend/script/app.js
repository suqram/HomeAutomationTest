'use strict';


// Declare app level module which depends on filters, and services
angular.module('myApp', ['myApp.services', 'myApp.controllers', 'ngRoute']).
  config(['$routeProvider', function($routeProvider) {
    $routeProvider.when('/view1', {templateUrl: 'partials/partial1.html', controller: 'MyCtrl1'});
    $routeProvider.when('/view2', {templateUrl: 'partials/partial2.html', controller: 'HomeController'});
    $routeProvider.otherwise({redirectTo: '/view2'});
  }]);
