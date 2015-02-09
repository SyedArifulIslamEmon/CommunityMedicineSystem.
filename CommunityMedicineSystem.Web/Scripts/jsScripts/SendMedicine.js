var myApplication = angular.module("myApp", []);
var myArray = [];
myApplication.controller("myController", function ($scope) {
    $scope.medicines = [];
    $scope.AddMedicine = function (name, quantity) {
        if (name != String.empty && quantity != String.empty) {
            $scope.medicines.push({ Name: name, Quantity: quantity });
            var nameWithoutPower = name.split(",");
            document.getElementById("medicineNames").value += nameWithoutPower[0] + ",";
            document.getElementById("medicineQuantities").value += quantity + ",";
        }
    };

});