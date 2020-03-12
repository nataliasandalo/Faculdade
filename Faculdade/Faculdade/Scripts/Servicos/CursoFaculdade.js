(function () {

    var app = angular.module('MyApp', []);

    app.controller('CursoController', ['$scope', '$http', '$window', '$location', function ($scope, $http, $window, $location) {
        
        $scope.pesquisarButton = function () {

            //window.location.href = '/Curso/Pesquisar';
            
            $http({
                url: '/Curso/Pesquisar',
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

        $scope.Adicionar = function (curso) {

            $http.post('/Curso/AdicionarCurso', curso).then(
                function (successResponse) {

                    window.location.href = '/Curso/Index';
                },
                function (errorResponse) {
                    // handle errors here
                });
        };

        $scope.GotoAdicionar = function () {

            window.location.href = '/Curso/Adicionar';
        };

    }]);
})();