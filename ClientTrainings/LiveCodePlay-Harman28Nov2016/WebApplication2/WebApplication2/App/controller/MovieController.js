
app.controller('MovieController', ['$scope', '$http', function ($scope, $http) {

    var onSuccess = function (response) {
        $scope.movies = response.data.Search;
        console.log(response.data.Search);
    }


    var onFailure = function (error) {
        $scope.error = "could not connect" + error;
    }


    $http.get("http://www.omdbapi.com/?s=batman&r=json").then(onSuccess, onFailure);

}]);