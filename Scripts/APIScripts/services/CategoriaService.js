app.service("CatetgoriaService", function ($http) {

    this.getCategorias = function () {
        return $http.get("api/categoria/SelectAll")
    }

    this.getCategoriaByID = function (id) {
        var url = 'api/Categoria/SelectByID/' + id;
        return $http(
        {
            method: 'get',
            data: id,
            url: url
        });
    }

    this.saveCategoria = function (categoria) {
        return $http(
        {
            method: 'post',
            data: categoria,
            url: 'api/categoria/Add'
        });
    }

    this.updateCategoria = function (categoria) {
        return $http(
        {
            method: 'put',
            data: categoria,
            url: 'api/categoria/Modify'
        });
    }


    this.deleteCategoria = function (id) {
        var url = 'api/categoria/Remove/' + id;
        return $http(
        {
            method: 'delete',
            data: id,
            url: url
        });
    }

   
});