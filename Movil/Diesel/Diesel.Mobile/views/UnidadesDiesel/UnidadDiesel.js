Diesel.UnidadDiesel = function (params) {
    "use strict";

    var viewModel = {
        //  Put the binding properties here
        Empleado: ko.observable(),
        Unidad: ko.observable(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Diesel.app.navigate({ view: "Login" }, { target: "back" });
            }
        },
        ListaEmpleados: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/ObternerEmpleados",
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
        OnGuardar: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var Load = $("#loadPanel").dxLoadPanel("instance");
                Load.show();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarUnidadDiesel",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDUnidad:' + viewModel.Unidad() + ', IDEmpleado:' + viewModel.Empleado() + '}',
                    success: function (result) {
                        Diesel.app.navigate({ view: "Main" }, { target: "back" });
                        viewModel.Empleado(null);
                        viewModel.Unidad(null);
                        e.validationGroup.reset();
                        Load.hide();
                        DevExpress.ui.notify(result.d , 'success', 4000);
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        Load.hide();
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
            }
        },
        OnCancelar: function (e) {
            Diesel.app.navigate({ view: "Main" }, { target: "back" });
            viewModel.Unidad(null);
            viewModel.Empleado(null);
            e.validationGroup.reset();
        },
        
        Unidades: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/ObternerUnidadesDiesel",
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
    };

    return viewModel;
};