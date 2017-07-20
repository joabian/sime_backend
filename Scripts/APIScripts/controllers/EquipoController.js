app.controller('EquipoController', function ($scope, EquipoService) {
    getAll();

    $scope.resultado = $scope.codigo + 10;

    function getAll() {
        var servCall = EquipoService.getEquipos();
        servCall.then(function (d) {
            $scope.equipos = d.data;
        }, function (error) {
            console.log('Oops! Something went wrong while fetching the data.')
        })
    };

    $scope.saveEquipo = function () {
        
        var equipo = {
            codigo: $scope.codigo,
            descripcion: $scope.descripcion,
            fechaIngreso: new Date(),
            activo: true
        };
        
        var saveEquipo = EquipoService.saveEquipo(equipo);
        saveEquipo.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.')
        })
    };

    $scope.makeEditable = function (obj) {
        obj.target.setAttribute("contenteditable", true);
        obj.target.focus();
    };

    $scope.updEquipo = function (equipo, eve) {
        equipo.descripcion = eve.currentTarget.innerText;
        var upd = EquipoService.updateEquipo(equipo);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while updating the data.')
        })
    };

    $scope.dltEquipo = function (id) {
        var dlt = EquipoService.deleteEquipo(id);
        dlt.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while deleting the data.')
        })
    };

})