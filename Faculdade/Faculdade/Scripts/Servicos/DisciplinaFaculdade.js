(function () {

    var app = angular.module('MyApp');

    app.controller('DisciplinaController', ['$scope', '$http', '$window', '$location', function ($scope, $http, $window, $location) {

        $scope.pesquisarCursoClick = function () {
            $scope.pesquisarCurso = [];
            //window.location.href = '/Curso/Pesquisar';

            $http({
                url: '/Curso/Pesquisar',
                method: 'GET',
                dataType: 'json'
            }).then(function (data, status, headers, config) {
                
                $scope.pesquisarCurso = data.data;
            });

        };

        $scope.pesquisarButton = function () {

            $scope.pesquisarCurso = [];

            $http({
                url: '/Disciplina/Pesquisar',
                method: 'GET',
                dataType: 'json'
            }).then(function (data, status, headers, config) { 

                for (var i = 0; i < data.data.length; i++) {

                    $scope.pesquisarCurso.push(data.data[i].CursoFaculdade);
                }
                
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
            var selectCurso = angular.element(document.getElementById('selectCurso' + id));

            if (txtNome[0].disabled === true && selectCurso[0].disabled === true) {

                txtNome[0].disabled = false;
                selectCurso[0].disabled = false;
                return;
            }

            if (txtNome[0].disabled === false && selectCurso[0].disabled === false) {

                txtNome[0].disabled = true;
                selectCurso[0].disabled = true;
                return;
            }

        };

        $scope.GotoAdicionar = function () {

            window.location.href = '/Disciplina/Adicionar';
        };

        $scope.Adicionar = function (disciplina) {

            $http.post('/Disciplina/AdicionarDisciplina', disciplina).then(
                function (successResponse) {

                    window.location.href = '/Disciplina/Index';
                },
                function (errorResponse) {
                    // handle errors here
                });
        };

        $scope.Atualizar = function (curso) {

            curso.Nome = angular.element(document.getElementById('txtNome' + curso.Id)).val();

            $http.post('/Disciplina/Atualizar', curso).then(

                function (successResponse) {

                    window.location.href = '/Disciplina/Index';
                },
                function (errorResponse) {
                    // handle errors here
                });
        };

        $scope.Excluir = function (curso) {

            if ($window.confirm("Tem certeza que deseja excluir este Disciplina?")) {

                $http({
                    method: "POST",
                    url: "/Disciplina/Excluir",
                    data: curso,
                    dataType: 'json',
                    headers: { "Content-Type": "application/json" }
                }).then(function successCallback(response) {

                    window.location.href = '/Disciplina/Index';
                }, function errorCallback(response) {

                });
            }
        };
        
    }]);
})();