Diesel.Tanques = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        /*viewShowing: function (e) {
            viewModel.Inicial(null);
            viewModel.Final(null);
            viewModel.SeleccionTanque(null);
        },
        viewShown: function (e) {
            DevExpress.validationEngine.resetGroup($("#vgValidacion").dxValidationGroup("instance"));
        },*/
        Inicial: ko.observable(),
        Final: ko.observable(),
        SeleccionTanque: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                SigobAC.app.navigate({ view: "Login" }, { target: "back" });
            }
        },
        TanquesDiesel: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/TanquesDiesel",
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
        CapacidadTanque: function (e) {
            
            var rangesx = [];
            if (e.selectedItem != null) {
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/RangosTanque",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDTanque:' + e.selectedItem["ID"] + '}',
                    success: function (result) {
                        rangesx.push(result.d[1]);
                        rangesx.push(result.d[2]);
                        rangesx.push(result.d[3]);
                        $("#cgGrafica").dxCircularGauge({
                            value: result.d[0]["startValue"],
                            endValue: result.d[0]["endValue"],
                            rangeContainer:
                                {
                                    ranges: rangesx
                                },
                            tooltip: { enabled: true },
                        })
                        if (result.d.length > 4) {
                            viewModel.Inicial(result.d[4]["startValue"]);
                            $("#txtInicial").dxTextBox("instance").option("readOnly", true);
                        } else {
                            viewModel.Inicial('');
                            $("#txtInicial").dxTextBox("instance").option("readOnly", false);
                        }
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            } else {
                $("#txtInicial").dxTextBox("instance").option("readOnly", false);
                $("#cgGrafica").dxCircularGauge({
                    value: null,
                    endValue: null,
                    tickInterval: null,
                    rangeContainer:
                        {
                            ranges: rangesx
                        },
                    tooltip: { enabled: true },
                })
            }
        },
        OnGuardar: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                //var ID = $("#sbTanques").dxSelectBox("instance").option("selectedItem")["ID"];
                var numFinal = 0;
                if (viewModel.Final() != undefined) {
                    numFinal = viewModel.Final();
                }
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarTanques",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDTanque:' + viewModel.SeleccionTanque() + ',Inicial:' + viewModel.Inicial() + ',Final:' + numFinal + '}',
                    success: function (result) {
                        Diesel.app.navigate({ view: "Main" }, { target: "back" });
                        viewModel.Inicial(null);
                        viewModel.Final(null);
                        viewModel.SeleccionTanque(null);
                        e.validationGroup.reset();
                        DevExpress.ui.notify('Datos guardados', 'success', 4000);
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        },
        OnCancelar: function (e) {
            Diesel.app.navigate({ view: "Main" }, { target: "back" });
            viewModel.Inicial(null);
            viewModel.Final(null);
            viewModel.SeleccionTanque(null);
            e.validationGroup.reset();
        }


    };

    return viewModel;
};