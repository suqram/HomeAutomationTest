/**
 * Created by marcus_s on 2016-06-25.
 */

'use strict';

// Declare app level module which depends on filters, and services
angular.module('myApp', ['myApp.services', 'myApp.controllers', 'ngRoute']).

    // Defines templates and controllers for routes (only one route in this project)
    config(['$routeProvider', function($routeProvider) {
        $routeProvider.when('/view/:param1', { templateUrl: 'partials/partial.html', controller: 'HomeController' });
        $routeProvider.otherwise({redirectTo: '/view/hus1'});
    }]);
