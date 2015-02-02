(function(){var app = angular.module('testApp', []);

    app.controller('TestController', function($scope, $http){
        
        $scope.orders = [];
        $scope.message = 'Hello';
        var responsePromise = $http.get("http://localhost:2326/api/Orders");

        responsePromise.success(function (data, status, headers, config) {
            console.log('Data retrieved with ' + data.length + ' records');
            $scope.orders = data;
            console.log('data:' + $scope.orders.length)

        });
        responsePromise.error(function (data, status, headers, config) {
            alert("AJAX failed!");
        });
    });

})();
