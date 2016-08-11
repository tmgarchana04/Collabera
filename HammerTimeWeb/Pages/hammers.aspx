<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hammers.aspx.cs" Inherits="HammerTimeWeb.Pages.manage_hammer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HammerTime :: Hammer Products</title>

    <link rel="stylesheet" href="/bundle/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/bundle/css/font-awesome.min.css" />
    <link rel="stylesheet" href="/bundle/css/custom.css" />
</head>
<body ng-app="myapp">
    <form id="form1" runat="server">
        <div>

            <section ng-controller="hammerProductCtrl">
                <div>
                    <ul class="breadcrumb">
                        <li><a href="#/">Home</a> </li>
                        <li class="active">Hammer Products</li>
                    </ul>
                </div>
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="col-md-8 col-xs-6">
                                <input type="text" ng-model="search.$" class="form-control" placeholder="search hammer products..." />
                            </div>
                            <div class="col-md-4 col-xs-6">
                                <span class="pull-right">Item Per Page:&nbsp;<select ng-model="pageSize" style="min-width: 48px;">
                                    <option>25</option>
                                    <option>50</option>
                                    <option>75</option>
                                    <option>100</option>
                                </select>&nbsp;
                            <a href="javascript:void(0)" ng-click="search.name='';search.brand='';search.material='';search.setSize='';search.color='';search.weight='';search.dimensions='';search.packcontent='';search.sku='';search.description='';search.stockunit='';search.minstockalertunit='';search.status='';" class="btn btn-sm btn-primary">Clear Filter
                            </a>
                                    <a href="javascript:void(0)" ng-click="bu.get()" class="btn btn-sm btn-success">
                                        <i class="fa fa-refresh"></i>
                                    </a>
                                </span>
                            </div>
                            <p class="clearfix"></p>
                            <p class="text-center">
                                <span ng-show="bu.obj.showerrormessage" class="center block red">{{bu.obj.errormessage}}</span>
                            </p>
                            <table class="table table-striped table-bordered table-hover">
                                <thead>
                                    <tr>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('name',reverse)">Name</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('brand',reverse)">Brand</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('material',reverse)">Material</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('setSize',reverse)">Set Size</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('color',reverse)">Color</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('weight',reverse)">Weight</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('dimensions',reverse)">Dimensions</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('packcontent',reverse)">Pack Content</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('sku',reverse)">SKU</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('description',reverse)">Description</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('stockunit',reverse)">Stock Unit</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('minstockalertunit',reverse)">Min Stock Alert</a></th>
                                        <th><a href="javascript:void(0)" ng-click="reverse=!reverse;order('status',reverse)">Active</a></th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody ng-show="bu.items.length > 0">
                                    <tr>
                                        <td>
                                            <input type="text" ng-model="search.name" placeholder="filter by name" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.brand" placeholder="filter by brand" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.material" placeholder="filter by material" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="number" ng-model="search.setSize" placeholder="filter by set size" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.color" placeholder="filter by color" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.weight" placeholder="filter by weight" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.dimensions" placeholder="filter by dimensions" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.packcontent" placeholder="filter by packcontent" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.sku" placeholder="filter by sku" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="search.description" placeholder="filter by description" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="number" ng-model="search.stockunit" placeholder="filter by stock unit" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="number" ng-model="search.minstockalertunit" placeholder="filter by min stock purchase request" class="form-control" />
                                        </td>
                                        <td>

                                            <div class="switch demo4">
                                                <input type="checkbox" ng-model="search.status" />
                                                <label><i></i></label>
                                            </div>
                                        </td>
                                        <th></th>
                                    </tr>
                                    <!--ng-repeat="item in bu.items | filter : search | limitTo:limitentity"-->
                                    <tr dir-paginate="item in bu.items | filter:search | itemsPerPage: pageSize" current-page="currentPage">

                                        <td>
                                            <span ng-show="!item.isedit">{{item.name}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.name" placeholder="enter name" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.brand}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.brand" placeholder="enter brand" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.material}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.material" placeholder="enter material" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.setSize}}</span>
                                            <input ng-show="item.isedit" type="number" ng-model="item.setSize" placeholder="enter set size" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.color}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.color" placeholder="enter color" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.weight}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.weight" placeholder="enter weight" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.dimensions}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.dimensions" placeholder="enter dimensions" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.packcontent}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.packcontent" placeholder="enter packcontent" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.sku}}</span>
                                            <input ng-show="item.isedit" type="text" ng-model="item.sku" placeholder="enter sku" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.description}}</span>
                                            <textarea ng-show="item.isedit" ng-model="itemN.description" placeholder="enter description" class="form-control"></textarea>
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.stockunit}}</span>
                                            <input ng-show="item.isedit" type="number" ng-model="item.stockunit" placeholder="enter stock unit" class="form-control" />
                                        </td>
                                        <td>
                                            <span ng-show="!item.isedit">{{item.minstockalertunit}}</span>
                                            <input ng-show="item.isedit" type="number" ng-model="item.minstockalertunit" placeholder="enter min stock purchase request" class="form-control" />
                                        </td>
                                        <td>
                                            <div ng-show="!item.isedit">
                                                <div class="switch demo4">
                                                    <input type="checkbox" disabled ng-model="item.status" />
                                                    <label><i></i></label>
                                                </div>
                                            </div>
                                            <div ng-show="item.isedit">

                                                <div class="switch demo4">
                                                    <input type="checkbox" ng-model="item.status" />
                                                    <label><i></i></label>
                                                </div>

                                            </div>


                                        </td>
                                        <td>
                                            <div style="min-width: 75px;">
                                                <div class="btn-group" ng-show="!item.isedit">
                                                    <a class="btn btn-sm btn-default" href="javascript:void(0)" ng-click="bu.update(item)">
                                                        <i class="fa fa-pencil"></i>
                                                    </a>
                                                    <a class="btn btn-sm btn-default" href="javascript:void(0)" ng-click="bu.delete(item)">
                                                        <i class="fa fa-trash"></i>
                                                    </a>
                                                </div>
                                            </div>
                                            <div style="min-width: 75px;">
                                                <div class="btn-group" ng-show="item.isedit">

                                                    <a href="javascript:void(0)" ng-click="bu.save(item)" class="btn btn-sm btn-default">
                                                        <i class="fa fa-save"></i>
                                                    </a>
                                                    <a href="javascript:void(0)" ng-click="bu.cancel(item)" class="btn btn-sm btn-default">
                                                        <i class="fa fa-remove"></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td>
                                            <input type="text" ng-model="itemN.name" placeholder="enter name" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.brand" placeholder="enter brand" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.material" placeholder="enter material" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="number" ng-model="itemN.setSize" placeholder="enter set size" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.color" placeholder="enter color" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.weight" placeholder="enter weight" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.dimensions" placeholder="enter dimensions" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.packcontent" placeholder="enter packcontent" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="text" ng-model="itemN.sku" placeholder="enter sku" class="form-control" />
                                        </td>
                                        <td>
                                            <textarea ng-model="itemN.description" placeholder="enter description" class="form-control"></textarea>
                                        </td>
                                        <td>
                                            <input type="number" ng-model="itemN.stockunit" placeholder="enter stock unit" class="form-control" />
                                        </td>
                                        <td>
                                            <input type="number" ng-model="itemN.minstockalertunit" placeholder="enter min stock purchase request" class="form-control" />
                                        </td>
                                        <td>

                                            <div class="switch demo4">
                                                <input type="checkbox" ng-model="itemN.status" />
                                                <label><i></i></label>
                                            </div>

                                        </td>
                                        <td>
                                            <div class="hidden-sm hidden-xs btn-group">
                                                <a href="javascript:void(0)" ng-click="bu.add()" class="btn btn-sm btn-warning">
                                                    <i class="fa fa-check"></i>Add
                                                </a>
                                            </div>
                                        </td>
                                    </tr>
                                </tfoot>
                            </table>
                            <dir-pagination-controls boundary-links="true" on-page-change="pageChangeHandler(newPageNumber)" template-url="pagination.tpl.html"></dir-pagination-controls>
                            <!--<pagination total-items="bigTotalItems" ng-model="bigCurrentPage" max-size="maxSize" class="pagination-sm" boundary-links="true" rotate="false" num-pages="numPages"></pagination>-->
                        </div>
                    </div>
                </div>

            </section>


            <script src="/bundle/scripts/jquery.js"></script>
            <script src="/bundle/scripts/bootstrap.min.js"></script>
            <script src="/bundle/scripts/angular.min.js"></script>
            <script src="pagination.js"></script>
            <script src="/pages/js/app.js"></script>


        </div>
    </form>
</body>
</html>
