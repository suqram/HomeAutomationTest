/**
 * Created by marcus_s on 2016-06-25.
 */

'use strict';

angular.module('myApp.services', ['ngResource'])

    // Provides access to REST target
    .factory('HomeDataOp', function ($resource) {
        return $resource('http://localhost:63761/home/:id/data',
            { id: '@id' },
            { getHome: { method: 'GET', params: { id: 0 } } }
        )
    });