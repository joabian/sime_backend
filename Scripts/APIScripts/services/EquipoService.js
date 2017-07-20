app.service("EquipoService", function ($http) {

    

    this.getEquipos = function () {
        return $http.get("api/Equipo/SelectAll")
    }

    this.getEquipoByID = function (id) {
        var url = 'api/Equipo/SelectByID/' + id;
        return $http(
        {
            method: 'get',
            data: id,
            url: url
        });
    }

    this.saveEquipo = function (equipo) {
        return $http(
        {
            method: 'post',
            data: equipo,
            url: 'api/Equipo/Add'
        });
    }

    this.updateEquipo = function (equipo) {
        return $http(
        {
            method: 'put',
            data: equipo,
            url: 'api/Equipo/Modify'
        });
    }


    this.deleteEquipo = function (id) {
        var url = 'api/Equipo/Remove/' + id;
        return $http(
        {
            method: 'delete',
            data: id,
            url: url
        });
    }

    

});