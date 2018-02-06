var app = angular.module('MyApp', []);

/// Creating the controller which will refer to the view where we need to call the angular method
app.controller('LoginDetailValue', function($scope, $http) {

    $scope.Message = '';
    $scope.IsLogin = false;
    $scope.Submitted = false;

    // Creation of object which need to pass for login method
    $scope.LoginData = {
        UserName: '',
        Password: ''
    };

    $scope.Login = function() {
        $scope.Submitted = true;

        /// Calling the controller by Ajax method
        $http({
            url: "/UserAccount/Login",
            method: "POST",
            data: JSON.stringify($scope.LoginData),
            headers: { "Content-type": "application/json" }
        }).then(function(d) {
            if (d.data.UserName != null) {
                $scope.IsLogin = true;
                $scope.Message = 'Login Success';
            } else {
                $scope.Message = 'wrong User';
            }
        });
    };
});
