/**
 * Created by marcus_s on 2016-06-25.
 */

function GetHomeData($scope, $http) {
    $http.get('http://10.211.55.3:63761/home/data').
    success(function(data) {
        $scope.home = data;
    });
}