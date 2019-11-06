Gasolina.RecargaGasolina = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
       
        Precio: ko.observable(),
        Cantidad: ko.observable(),
        Factura: ko.observable(),
        Proveedor: ko.observable(),
        Lectura: ko.observable(),
        SeleccionTanque: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Gasolina.app.navigate({ view: "Login" }, { target: "back" });
            }
        },
        TanquesGasolina: new DevExpress.data.CustomStore({
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
        }),
        OnGuardarRecarga: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarRecarga",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDTanque:' + viewModel.SeleccionTanque() + ', Precio:' + viewModel.Precio() + ', Cantidad:' + viewModel.Cantidad() + ', Factura:"' + viewModel.Factura() + '", Proveedor:"' + viewModel.Proveedor() + '", Lectura:"' + viewModel.Lectura() + '"}',
                    success: function (result) {
                        Gasolina.app.navigate({ view: "Main" }, { target: "back" });
                        viewModel.Precio(null);
                        viewModel.Cantidad(null);
                        viewModel.Factura(null);
                        viewModel.Proveedor(null);
                        viewModel.SeleccionTanque(null);
                        e.validationGroup.reset();
                        DevExpress.ui.notify('Recarga guardada', 'success', 4000);
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        },
        OnTanqueSeleccion: function (e) {
            viewModel.Precio(null);
            viewModel.Cantidad(null);
        },
        OnCancelar: function (e) {
            Gasolina.app.navigate({ view: "Main" }, { target: "back" });
            viewModel.Precio(null);
            viewModel.Cantidad(null);
            viewModel.SeleccionTanque(null);
            e.validationGroup.reset();
        }
    };

    return viewModel;
};