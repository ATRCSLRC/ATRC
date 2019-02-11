
Diesel.Main = function (params) {
    "use strict";
    var TanquesDiesel = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/TanquesDiesel",//"http://192.168.0.123:7777/WS/WS-Diesel.asmx",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    deferred.resolve(result.d);
                },
                error: function (jqXhr, textStatus, errorThrown) {
                    DevExpress.ui.notify(errorThrown, 'error', 4000);
                }
            });
            return deferred.promise();
        }
    });

    //TanquesDiesel.load().done(function (data) {
    //    viewModel.TanquesDiesel(data);
    //});
    var viewModel = {
        DetellePopUp: ko.observable(false),
        CandadoPopUp: ko.observable(false),
        DetalleCandado: ko.observable(),
        Millas: ko.observable(),
        Titulo: ko.observable('Detalle del llenado diesel'),
        CandadoAnterior: ko.observable(),
        CandadoActual: ko.observable(),
        Litros: ko.observable(),
        TanqueSeleccionado: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                SigobAC.app.navigate({ view: "Login" }, { target: "back" });
            }
            
        },
        viewShown: function () {
            var grid = $("#gridContainer").dxDataGrid("instance");
            grid.refresh();
            TanquesDiesel.load().done(function (data) {
                viewModel.TanquesDiesel(data);
            });
        },
        PedidosDiesel: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/PedidosDiesel",//"http://192.168.0.123:7777/WS/WS-Diesel.asmx",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (result) {
                        deferred.resolve(result.d);

                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
                return deferred.promise();
            }
        }),
        TanquesDiesel: ko.observableArray(),
        Tanques: new DevExpress.data.DataSource({
           store: new DevExpress.data.CustomStore({
                load: function (loadOptions) {

                    var deferred = $.Deferred();
                    // return s;
                    $.ajax({
                        type: "POST",
                        url: ObtenerUrl() + "/TanquesActuales",//"http://192.168.0.123:7777/WS/WS-Diesel.asmx",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (result) {
                            deferred.resolve(result.d);

                        },
                        error: function (jqXhr, textStatus, errorThrown) {
                            DevExpress.ui.notify(errorThrown, 'error', 4000);
                        }
                    });
                    return deferred.promise();
                }
            })
        }),
        OnSeleccion: function (selectedItems) {
            if (selectedItems.values.length > 0) {
                if (selectedItems.values[0] == false) {
                    viewModel.Titulo('Detalle del llenado diesel del ' + selectedItems.data.Unidad);
                    viewModel.DetellePopUp(true);
                }
            }
        },
        InicializarDetalle: function () {
            viewModel.Tanques.load();
            if (viewModel.Tanques._items.length > 0) {
                viewModel.TanqueSeleccionado(viewModel.Tanques._items[0]['ID']);
            }
        },
        OnClickGuardar: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var grd = $("#gridContainer").dxDataGrid("instance");
                var Diesel = grd._options.selectedRowKeys[0]["ID"];
                var Tanque = $("#rgTanques").dxRadioGroup("instance").option("value");
                //alert(Usuario);
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/DetalleDieselUnidad",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDDiesel:' + Diesel + ', Millas:' + viewModel.Millas() + ', CandadoAnterior:'
                        + viewModel.CandadoAnterior() + ', CandadoActual:' + viewModel.CandadoActual() + ', Litros:' +
                        viewModel.Litros() + ', IDTanque: ' + Tanque + '}',
                    success: function (result) {
                        TanquesDiesel.load().done(function (data) {
                            viewModel.TanquesDiesel(data);
                        }); 
                        viewModel.DetellePopUp(false);
                        grd.refresh();
                        viewModel.Millas('');
                        viewModel.CandadoAnterior('');
                        viewModel.CandadoActual('');
                        viewModel.Litros('');
                        e.validationGroup.reset();
                        DevExpress.ui.notify('Datos guardados', 'success', 4000);
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        },
        OnClickCancelar: function (e) {
            viewModel.DetellePopUp(false);
            var grid = $("#gridContainer").dxDataGrid("instance");
            viewModel.Millas('');
            viewModel.CandadoAnterior('');
            viewModel.CandadoActual('');
            viewModel.Litros('');
            grid.refresh();
            e.validationGroup.reset();
            
        },
        Columnas: [
            {
                dataField: "Llenado",
                caption: "",
                width: 50
            },
            {
                dataField: "Unidad",
                caption: "Unidad",
                width: 80
            },
            {
                dataField: "Empleado",
                caption: "Empleado",
            }
            ,
            {
                dataField: "Litros",
                caption: "Litros",
                summaryType: 'sum'
            }
        ],
        Total: {
            totalItems: [ {
                column: "Litros",
                summaryType: "sum",
                customizeText: function (data) {
                    return "Total: " + data.value;
                }
            }]
        },
        OnValidarCandado: function (e) {
            var grd = $("#gridContainer").dxDataGrid("instance");
            var Diesel = grd._options.selectedRowKeys[0]["ID"];
            if (e.component.option("value") != undefined) {
                //alert(e.component.option("value"));
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/MismoCandado",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDDiesel:' + Diesel + ',Candado:' + e.component.option("value") + '}',
                    success: function (result) {
                        if (!result.d) {
                            viewModel.CandadoPopUp(true);
                        }
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        },
        OnGuardarCandado: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var grd = $("#gridContainer").dxDataGrid("instance");
                var Diesel = grd._options.selectedRowKeys[0]["ID"];
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarProblemaCandado",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDDiesel:' + Diesel + ',Problema:"' + viewModel.DetalleCandado() + '"}',
                    success: function (result) {
                        viewModel.CandadoPopUp(false);
                        viewModel.DetalleCandado(null);
                        e.validationGroup.reset();
                        DevExpress.ui.notify('Datos guardados', 'success', 2000);
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        }
    }
    return viewModel;
    
};