
Gasolina.Main = function (params) {
    "use strict";
    var TanquesGasolina = new DevExpress.data.CustomStore({
        load: function (loadOptions) {

            var deferred = $.Deferred();
            $.ajax({
                type: "POST",
                url: ObtenerUrl() + "/TanquesGasolina",
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

    var viewModel = {
        DetellePopUp: ko.observable(false),
        CandadoPopUp: ko.observable(false),
        DetalleCandado: ko.observable(),
        Millas: ko.observable(),
        Titulo: ko.observable('Detalle del llenado gasolina'),
        CandadoAnterior: ko.observable(),
        CandadoActual: ko.observable(),
        Litros: ko.observable(),
        TanqueSeleccionado: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Gasolina.app.navigate({ view: "Login" }, { target: "back" });
            }

        },
        viewShown: function () {
            var grid = $("#gridContainer").dxDataGrid("instance");
            grid.refresh();
            TanquesGasolina.load().done(function (data) {
                viewModel.TanquesGasolina(data);
            });
        },
        PedidosGasolina: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/PedidosGasolina",
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
        TanquesGasolina: ko.observableArray(),
        Tanques: new DevExpress.data.DataSource({
            store: new DevExpress.data.CustomStore({
                load: function (loadOptions) {

                    var deferred = $.Deferred();
                    $.ajax({
                        type: "POST",
                        url: ObtenerUrl() + "/TanquesActualesGasolina",
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
                    viewModel.Titulo('Detalle del llenado gasolina del ' + selectedItems.data.Unidad);
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
                var Gasolina = grd._options.selectedRowKeys[0]["ID"];
                var Tanque = $("#rgTanques").dxRadioGroup("instance").option("value");
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/DetalleGasolinaUnidad",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDGasolina:' + Gasolina + ', Millas:' + viewModel.Millas() + ', CandadoAnterior:'
                        + viewModel.CandadoAnterior() + ', CandadoActual:' + viewModel.CandadoActual() + ', Litros:' +
                        viewModel.Litros() + ', IDTanque: ' + Tanque + '}',
                    success: function (result) {
                        TanquesGasolina.load().done(function (data) {
                            viewModel.TanquesGasolina(data);
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
                caption: "Empleado"
            }
            ,
            {
                dataField: "Litros",
                caption: "Litros",
                summaryType: 'sum'
            }
        ],
        Total: {
            totalItems: [{
                column: "Litros",
                summaryType: "sum",
                customizeText: function (data) {
                    return data.value;
                }
            }]
        },
        OnValidarCandado: function (e) {
            var grd = $("#gridContainer").dxDataGrid("instance");
            var Gasolina = grd._options.selectedRowKeys[0]["ID"];
            if (e.component.option("value") != undefined) {
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/MismoCandadoGasolina",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDGasolina:' + Gasolina + ',Candado:' + e.component.option("value") + '}',
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
        OnScanCandadoAnterior: function (e) {

            var grd = $("#gridContainer").dxDataGrid("instance");
            var Gasolina = grd._options.selectedRowKeys[0]["ID"];
            cordova.plugins.barcodeScanner.scan(
                function (result) {
                    viewModel.CandadoAnterior(parseInt(result.text));

                    if (viewModel.CandadoAnterior() != undefined) {
                        $.ajax({
                            type: "POST",
                            url: ObtenerUrl() + "/MismoCandadoGasolina",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            data: '{IDGasolina:' + Gasolina + ',Candado:' + viewModel.CandadoAnterior() + '}',
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
                function (error) {
                    //viewModel.DetellePopUp(true);
                },
                {
                    preferFrontCamera: true, // iOS and Android
                    showFlipCameraButton: true, // iOS and Android
                    showTorchButton: true, // iOS and Android
                    torchOn: true, // Android, launch with the torch switched on (if available)
                    saveHistory: true, // Android, save scan history (default false)
                    prompt: "Place a barcode inside the scan area", // Android
                    resultDisplayDuration: 500, // Android, display scanned text for X ms. 0 suppresses it entirely, default 1500
                    formats: "QR_CODE,PDF_417", // default: all but PDF_417 and RSS_EXPANDED
                    orientation: "portrait", // Android only (portrait|landscape), default unset so it rotates with the device
                    disableAnimations: true, // iOS
                    disableSuccessBeep: false // iOS and Android
                }
            );
        },
        OnScanCandadoActual: function (e) {
            if (viewModel.CandadoAnterior() != undefined || viewModel.CandadoAnterior() != '') {
                cordova.plugins.barcodeScanner.scan(
                    function (result) {
                        viewModel.CandadoActual(parseInt(result.text));
                    },
                    function (error) {
                        viewModel.DetellePopUp(true);
                    },
                    {
                        preferFrontCamera: true, // iOS and Android
                        showFlipCameraButton: true, // iOS and Android
                        showTorchButton: true, // iOS and Android
                        torchOn: true, // Android, launch with the torch switched on (if available)
                        saveHistory: true, // Android, save scan history (default false)
                        prompt: "Place a barcode inside the scan area", // Android
                        resultDisplayDuration: 500, // Android, display scanned text for X ms. 0 suppresses it entirely, default 1500
                        formats: "QR_CODE,PDF_417", // default: all but PDF_417 and RSS_EXPANDED
                        orientation: "portrait", // Android only (portrait|landscape), default unset so it rotates with the device
                        disableAnimations: true, // iOS
                        disableSuccessBeep: false // iOS and Android
                    }
                );
            }
            else {
                DevExpress.ui.notify('Debe agregar el candado anterior.', 'error', 4000);
            }
        },
        OnGuardarCandado: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var grd = $("#gridContainer").dxDataGrid("instance");
                var Gasolina = grd._options.selectedRowKeys[0]["ID"];
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarProblemaCandadoGasolina",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDGasolina:' + Gasolina + ',Problema:"' + viewModel.DetalleCandado() + '"}',
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