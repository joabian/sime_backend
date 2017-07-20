app.service("SubcategoriaService", function ($http) {

    
    this.getSubcatetgorias = function () {
        return $http.get("api/subcategoria/SelectAll")
    }

    this.getSubcatetgoriaByID = function (id) {
        var url = 'api/Subcategoria/SelectByID/' + id;
        return $http(
        {
            method: 'get',
            data: id,
            url: url
        });
    }

    this.getSubcatetgoriasByCategoryID = function (id) {
        var url = 'api/Subcategoria/SelectByCategoryID/' + id;
        return $http(
        {
            method: 'get',
            data: id,
            url: url
        });
    }

    this.saveSubcategoria = function (subcategoria) {
        return $http(
        {
            method: 'post',
            data: subcategoria,
            url: 'api/subcategoria/Add'
        });
    }

    this.updateSubcategoria = function (subcategoria) {
        return $http(
        {
            method: 'put',
            data: subcategoria,
            url: 'api/subcategoria/Modify'
        });
    }


    this.deleteSubcategoria = function (id) {
        var url = 'api/subcategoria/Remove/' + id;
        return $http(
        {
            method: 'delete',
            data: id,
            url: url
        });
    }

    


});