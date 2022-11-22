(() => {
    const app = angular.module("etickets", []);

    const MoviesController = function ($scope, $http) {
        $scope.name = "Hello";
        $scope.submit = () => {
            alert('hello!');
        }
    };

    app.controller("MoviesController", MoviesController);
})();
