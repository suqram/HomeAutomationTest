/**
 * Created by marcus_s on 2016-06-25.
 */

'use strict';

angular.module('myApp.controllers', [])

    // Fetches data from service/factory
    .controller('HomeController', ['$scope', 'HomeDataOp', '$routeParams', function ($scope, HomeDataOp, $routeParams) {

        $scope.homeData;
        var param1 = $routeParams.param1;

        $scope.getCurrentHome = function (id) {
            HomeDataOp.getHome({ id: id }, function (data) {
                $scope.homeData = data;
            });
        };
        
        $scope.getCurrentHome(param1);

        $scope.$on('updateEvent', function (event, args) {
            $scope.getCurrentHome(args)
        });
    }])

    // Provides timer-method for refreshing contents. 
    .controller('RefreshController', function ($scope, $interval, $routeParams) {

        var c = 0;
        var args = $routeParams.param1

        $interval(function () {
            $scope.$emit('updateEvent', args);
        }, 1000);
    });