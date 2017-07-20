app.controller('CategoriaController', function ($scope, CategoriaService) {
    getAll();

    function getAll() {
        var servCall = CategoriaService.getCategorias();
        servCall.then(function (d) {
            $scope.categorias = d.data;
        }, function (error) {
            console.log('Oops! Something went wrong while fetching the data.')
        })
    };

    $scope.saveCategoria = function () {
        //alert("test")
        var categoria = {
            // atributos (JSON)
        };
        
        var saveCategoria = CategoriaService.saveCategoria(categoria);
        saveCategoria.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.')
        })
    };

    $scope.updateCategoria = function (categoria, eve) {
        
        var upd = CategoriaService.updateCategoria(categoria);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while updating the data.')
        })
    };

    $scope.deleteCategoria = function (id) {
        var dlt = CategoriaService.deleteCategoria(id);
        dlt.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Oops! Something went wrong while deleting the data.')
        })
    };

})