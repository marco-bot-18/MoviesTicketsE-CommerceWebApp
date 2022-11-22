(() => {
    const app = angular.module("etickets", ["ngRoute", "ngAnimate"]);

    app.config(($routeProvider) => {
        $routeProvider
            .when("/", {
                controller: "moviesController",
                templateUrl: "index.cshtml",
            })
            .otherwise({ redirectTo: "/" });
    });
})();
