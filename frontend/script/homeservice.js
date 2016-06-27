/**
 * Created by marcus_s on 2016-06-25.
 */
// var HomeService = angular.module('HomeService', [])
// HomeService.factory('HomeDataOp', ['$http', function ($http) {
//
//     var urlBase = 'http://10.211.55.3:63761';
//     var HomeDataOp = {};
//
//     HomeDataOp.getHome = function () {
//         return $http.get(urlBase+'/home/data');
//     };
//
//     return HomeDataOp;
//
// }]);

angular.module('myApp.services', ['ngResource'])
    .factory('HomeDataOp', function ($resource) {
        return $resource('http://localhost:63761/home/:id',
            { id: '@id' },
            { getHome: { method: 'GET', params: { id: 0 } } }
        )
    });