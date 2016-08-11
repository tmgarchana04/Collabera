var _myapp = angular.module('myapp', ['angularUtils.directives.dirPagination']);

// service related to hammer product
var _appHammerProductServices = function ($http) {

    //all
    var _allobject = function () {
        var _request = {
            method: 'POST',
            url: '/Pages/hammers.aspx/GetHammerProducts',
            data: {}
        }
        return $http(_request).then(function (response) {
            return response.data;
        });
    }
    //add / update / delete
    var _cudobject = function (entity, url) {
        var _request = {
            method: 'POST',
            url: url,
            data: { entity: entity }
        }
        return $http(_request).then(function (response) {
            return response.data;
        });
    }

    return {
        getProducts: _allobject,
        manageProduct: _cudobject
    };
}
_myapp.factory("_appHammerProductServices", _appHammerProductServices);

//hammer product controller
_myapp.controller("hammerProductCtrl", function ($scope, $filter, _appHammerProductServices) {

    $scope.bu = {};
    $scope.bu.items = [];
    $scope.bu.obj = {
        showerrormessage: false, errormessage: "", editItemIndex: null
    };

    $scope.itemN = {
        id: 0,
        name: "",
        brand: "",
        material: "",
        setSize: "",
        color: "",
        weight: "",
        dimensions: "",
        packcontent: "",
        sku: "",
        description: "",
        stockunit: 0,
        minstockalertunit: 0,
        status: false
    };

    //error generic
    var onError = function (response) {
        try {
            $scope.bu.obj.showerrormessage = true;
            $scope.bu.obj.errormessage = response.data.Message;
        } catch (e) {
            console.log(e); $scope.bu.obj.errormessage = e;
        }
    }

    //get all
    $scope.bu.get = function () {

        $scope.bu.obj.showerrormessage = false;

        var onSuccess = function (data) {
            if (data.d == null) {
                $scope.bu.obj.showerrormessage = true;
                $scope.bu.obj.errormessage = "No product record found";
                return;
            }
            for (var i = 0; i < data.d.length; i++) {
                //data.d[i]._activatedon = moment(data.d[i]._activatedon).toDate();
                //data.d[i]._createdon = moment(data.d[i]._createdon).toDate();
                //data.d[i]._modifiedon = moment(data.d[i]._modifiedon).toDate();
            }

            $scope.bu.items = data.d;
        }

        _appHammerProductServices.getProducts().then(onSuccess, onError);
    };
    $scope.bu.get();

    //add new
    $scope.bu.add = function () {

        $scope.bu.obj.showerrormessage = false;

        var onSuccess = function (data) {
            if (data.d != null) {
                $scope.bu.obj.showerrormessage = true;
                $scope.bu.obj.errormessage = "New product added successfully, product id is " + data.d.id;
                $scope.itemN.id = data.d.id;

                $scope.bu.items.push(data.d);

                $scope.itemN = {
                    id: 0,
                    name: "",
                    brand: "",
                    material: "",
                    setSize: "",
                    color: "",
                    weight: "",
                    dimensions: "",
                    packcontent: "",
                    sku: "",
                    description: "",
                    stockunit: 0,
                    minstockalertunit: 0,
                    status: false
                };

            }
        }

        var _addProductWebServiceUrl = "/Pages/hammers.aspx/AddHammerProduct";
        _appHammerProductServices.manageProduct($scope.itemN, _addProductWebServiceUrl).then(onSuccess, onError);

    };

    //enable product to update
    $scope.bu.update = function (item) {

        $scope.bu.obj.showerrormessage = false;

        if ($scope.bu.items.indexOf(item) >= 0) {
            var _index = $scope.bu.items.indexOf(item);
            $scope.bu.items[_index].isedit = true;
        }
        else {
            onError({ data: { Message: "Invalid Product record selected for editing" } });
        }
    };

    //disable product to update
    $scope.bu.cancel = function (item) {

        $scope.bu.obj.showerrormessage = false;

        if ($scope.bu.items.indexOf(item) >= 0) {
            var _index = $scope.bu.items.indexOf(item);
            $scope.bu.items[_index].isedit = false;
        }
        else {
            onError({ data: { Message: "Invalid Product record selected for cancelling edit option" } });
        }
    };

    //updating product
    $scope.bu.save = function (item) {

        $scope.bu.obj.showerrormessage = false;

        if ($scope.bu.items.indexOf(item) >= 0) {
            var _index = $scope.bu.items.indexOf(item);

            var onSuccess = function (data) {
                if (data.d != null) {
                    $scope.bu.obj.showerrormessage = true;
                    $scope.bu.obj.errormessage = "Hammer Product properties updated successfully, product id is " + data.d.id;

                    $scope.bu.items[_index] = data.d;
                }
            }

            var _updateProductWebServiceUrl = "/Pages/hammers.aspx/UpdateHammerProduct";
            _appHammerProductServices.manageProduct(item, _updateProductWebServiceUrl).then(onSuccess, onError);

        }
        else {
            onError({ data: { Message: "Invalid Hammer Product record selected for cancelling edit" } });
        }
    }

    //delete
    $scope.bu.delete = function (item) {

        var _rConfirmBox = confirm("Are you sure you want to delete this record!");
        if (_rConfirmBox != true) { return; }

        $scope.bu.obj.showerrormessage = false;


        if ($scope.bu.items.indexOf(item) >= 0) {
            var _index = $scope.bu.items.indexOf(item);

            var onSuccess = function (data) {
                if (data.d == true) {
                    $scope.bu.obj.showerrormessage = true;
                    $scope.bu.obj.errormessage = "Deleted hammer product successfully";
                    $scope.bu.items.splice(_index, 1);
                }
                else {
                    $scope.bu.obj.showerrormessage = true;
                    $scope.bu.obj.errormessage = "Error in deleting product";
                }
            }

            var _deleteProductWebServiceUrl = "/Pages/hammers.aspx/DeleteHammerProduct";
            _appHammerProductServices.manageProduct(item, _deleteProductWebServiceUrl).then(onSuccess, onError);

        }
        else {
            onError({ data: { Message: "Invalid Hammer Product record selected for deleting" } });
        }
    };

    var orderBy = $filter('orderBy');
    $scope.order = function (predicate, reverse) {
        $scope.bu.items = orderBy($scope.bu.items, predicate, reverse);
    };

    $scope.currentPage = 1;
    $scope.pageSize = 25;

    $scope.pageChangeHandler = function (num) {
        console.log('Hammer Product page changed to ' + num);
    };


});

