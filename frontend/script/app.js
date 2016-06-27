'use strict';


// Declare app level module which depends on filters, and services
angular.module('myApp', ['myApp.services', 'myApp.controllers', 'ngRoute']).
  config(['$routeProvider', function($routeProvider) {
    $routeProvider.when('/view/:param1', { templateUrl: 'partials/partial2.html', controller: 'HomeController' });
    $routeProvider.otherwise({redirectTo: '/view/hus1'});
  }]);
