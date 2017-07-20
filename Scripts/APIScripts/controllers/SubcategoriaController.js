app.controller('SubcategoriaServiceController', function ($scope, SubcategoriaService) {
    getAll();

    function getAll() {
        var servCall = SubcategoriaService.getSubcatetgorias();
        servCall.then(function (d) {
            $scope.subcategorias = d.data;
        }, function (error) {
            console.log('Oops! Something went wrong while fetching the data.')
        })
    };

    $scope.saveSubcategoria = function () {
        //alert("test")
        var subcategoria = {
            // atributos (JSON)
        };
        console.log(subcategoria)
        var saveSubcategoria = SubcategoriaService.saveSubcategoria(subcategoria);
        saveSubcategoria.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.')
        })
    };

    $scope.updateSubcategoria = function (subcategoria, eve) {
        //subcategoria.descripcion = eve.currentTarget.innerText;
        var upd = SubcategoriaService.updateSubcategoria(subcategoria);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while updating the data.')
        })
    };

    $scope.deleteSubcategoria = function (id) {
        var dlt = SubcategoriaService.deleteSubcategoria(id);
        dlt.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while deleting the data.')
        })
    };

})