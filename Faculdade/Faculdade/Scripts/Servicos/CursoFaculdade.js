(function () {

    var app = angular.module('MyApp', []);

    
    app.controller('CursoController', ['$scope', '$http', function ($scope, $http) {
        
        $scope.Mensagem = "TESTE ENTROU NO JS";

        $scope.pesquisarButton = function () {
            
            $http({
                url: '/Curso/Pesquisar',
                method: 'GET',
                dataType: 'json'
            }).then(function (data, status, headers, config) {
                
                $scope.pesquisar = data.data;
            });
        };
        
    }]);
})();