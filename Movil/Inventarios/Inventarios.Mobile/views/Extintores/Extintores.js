Inventarios.Extintores = function (params) {
    "use strict";
    var Extintores = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/Extintores",
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

    var Ubicaciones = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/UbicacionesExtintor",
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

    var Estados = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/EstadosExtintor",
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

    var Unidades = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/ObternerUnidades",
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

    function ToJavaScriptDate(value) {
        var pattern = /Date\(([^)]+)\)/;
        var results = pattern.exec(value);
        var dt = new Date(parseFloat(results[1]));
        return dt;// (dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear();
    }

    var viewModel = {
//  Put the binding properties here
        ExtintorPopUp: ko.observable(false),
        Titulo: ko.observable(),
        Extintores: ko.observableArray(),
        Ubicaciones: ko.observableArray(),
        Estados: ko.observableArray(),
        Unidades: ko.observableArray(),
        SeleccionUbicacion: ko.observable(),
        SeleccionEstado: ko.observable(),
        SeleccionUnidad: ko.observable(),
        Peso: ko.observable(),
        Comentario: ko.observable(),
        FechaRecarga: ko.observable(),
        FechaVencimiento: ko.observable(),
        Unidad: ko.observable(),
        Oficina: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Inventarios.app.navigate({ view: "Login" }, { target: "back" });
            }

        },
        viewShown: function () {
            var grid = $("#gridContainer").dxDataGrid("instance");
            grid.refresh();
            Extintores.load().done(function (data) {
                viewModel.Extintores(data);
            });
            Ubicaciones.load().done(function (data) {
                viewModel.Ubicaciones(data);
            });
            Estados.load().done(function (data) {
                viewModel.Estados(data);
            });
            Unidades.load().done(function (data) {
                viewModel.Unidades(data);
            });
        },
        Columnas: [
            {
                dataField: "Revisado",
                caption: "Revisado",
                width: 90
            },
            {
                dataField: "NumExtintor",
                caption: "# Extintor",
                width: 100,
                alignment: "center"
            },
            {
                dataField: "UbicacionExtintor",
                caption: "Ubicacion"
            }
        ],
        OnUbicacion: function (e) {
            var grd = $("#gridContainer").dxDataGrid("instance");
            var Destino = grd._options.selectedRowKeys[0]["Destino"];
            var text = $('#txtOficina').dxTextBox("instance");
            var combo = $('#comboUnidad').dxSelectBox("instance");
            switch (e.value) {
                case 0:
                    combo.option('visible', true);
                    text.option('visible', false);
                    combo.option('value', parseInt(Destino));
                    $('#divDestino').css('display', 'block');
                    break;
                case 1:
                    combo.option('visible', false);
                    text.option('visible', true);
                    text.option('value',Destino);
                    $('#divDestino').css('display', 'block');
                    break;
                case 2:
                    $('#divDestino').css('display', 'none');
                    break;
            }
        },
        OnSeleccion: function (selectedItems) {
            if (selectedItems.values.length > 0) {
                if (selectedItems.values[0] == false) {
                    viewModel.Titulo('Detalle del extintor ' + selectedItems.data.NumExtintor);
                    viewModel.SeleccionUbicacion(selectedItems.data.Ubicacion);
                    switch (selectedItems.data.Ubicacion) {
                        case 0:
                            viewModel.Unidad(parseInt(selectedItems.data.Destino));
                            break;
                        case 1:
                            viewModel.Oficina(selectedItems.data.Destino);
                            break;
                    }
                    viewModel.SeleccionEstado(selectedItems.data.EstadoExtintor);
                    viewModel.Peso(selectedItems.data.Peso);
                    viewModel.FechaRecarga(ToJavaScriptDate(selectedItems.data.FechaRecarga));
                    viewModel.FechaVencimiento(ToJavaScriptDate(selectedItems.data.FechaVencimiento));

                    viewModel.ExtintorPopUp(true);
                }
            }
        },
        OnClickGuardar: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var grd = $("#gridContainer").dxDataGrid("instance");
                var Extintor = grd._options.selectedRowKeys[0]["ID"];
                var Unidad = 0;
                if (viewModel.Unidad() != undefined) {
                    Unidad = viewModel.Unidad();
                }
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarInventarioExtintor",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDExtintor:' + Extintor + ', FechaRecarga:"' + viewModel.FechaRecarga().toISOString() + '", FechaVencimiento:"'
                        + viewModel.FechaVencimiento().toISOString() + '", Ubicacion:' + viewModel.SeleccionUbicacion() + ', oficina:"' +
                        viewModel.Oficina() + '", IDUnidad:' + Unidad + ', Peso:' + viewModel.Peso().toString() + ', Estado:' + viewModel.SeleccionEstado() +
                        ', Comentario:"' + viewModel.Comentario() + '"}',
                    success: function (result) {
                        Extintores.load().done(function (data) {
                            viewModel.Extintores(data);
                        });
                        viewModel.ExtintorPopUp(false);
                        grd.refresh();
                        viewModel.FechaRecarga(Date.now());
                        viewModel.FechaVencimiento(Date.now());
                        viewModel.SeleccionUbicacion(null);
                        viewModel.Oficina('');
                        viewModel.Unidad(null);
                        viewModel.Peso(null);
                        viewModel.SeleccionEstado(null);
                        viewModel.Comentario('');
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
            viewModel.ExtintorPopUp(false);
            viewModel.FechaRecarga(Date.now());
            viewModel.FechaVencimiento(Date.now());
            viewModel.SeleccionUbicacion(null);
            viewModel.Oficina('');
            viewModel.Unidad(null);
            viewModel.Peso(null);
            viewModel.SeleccionEstado(null);
            viewModel.Comentario('');
            e.validationGroup.reset();
        }
        

    };

    return viewModel;
};