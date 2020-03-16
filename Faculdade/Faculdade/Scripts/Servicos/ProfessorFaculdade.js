(function () {

    var app = angular.module('MyApp');

    app.controller('ProfessorController', ['$scope', '$http', '$window', '$location', function ($scope, $http, $window, $location) {
        
        $scope.pesquisarButton = function () {

            //window.location.href = '/Curso/Pesquisar';
            
            $http({
                url: '/Professor/Pesquisar',
                method: 'GET',
                dataType: 'json'
            }).then(function (data, status, headers, config) {                 
                $scope.pesquisar = data.data;
            });
                        
        };

        $scope.HiddenBtn = function (event, id) {

            var btnPlus = angular.element(document.getElementById('btnPlus' + id));

            if (btnPlus[0].hidden === true) {
                btnPlus[0].hidden = false;
                return;
            }

            if (btnPlus[0].hidden === false) {
                btnPlus[0].hidden = true;
                return;
            }
        };

        $scope.EnableDisableTxt = function (event, id) {

            var txtNome = angular.element(document.getElementById('txtNome' + id));

            if (txtNome[0].disabled === true) {
                txtNome[0].disabled = false;
                return;
            }

            if (txtNome[0].disabled === false) {
                txtNome[0].disabled = true;
                return;
            }

        };

        $scope.GotoAdicionar = function () {

            window.location.href = '/Professor/Adicionar';
        };

        $scope.Adicionar = function (curso) {

            $http.post('/Professor/AdicionarProfessor', curso).then(
                function (successResponse) {

                    window.location.href = '/Professor/Index';
                },
                function (errorResponse) {
                    // handle errors here
                });
        };

        $scope.Atualizar = function (curso) {

            curso.Nome = angular.element(document.getElementById('txtNome' + curso.Id)).val();

            $http.post('/Professor/Atualizar', curso).then(

                function (successResponse) {

                    window.location.href = '/Professor/Index';
                },
                function (errorResponse) {
                    // handle errors here
                });
        };

        $scope.Excluir = function (curso) {

            if ($window.confirm("Tem certeza que deseja excluir este Professor?")) {

                $http({
                    method: "POST",
                    url: "/Professor/Excluir",
                    data: curso,
                    dataType: 'json',
                    headers: { "Content-Type": "application/json" }
                }).then(function successCallback(response) {

                    window.location.href = '/Professor/Index';
                }, function errorCallback(response) {

                });
            }
        };
        
    }]);
})();