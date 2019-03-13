Gasolina.Medidores = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Gasolina.app.navigate({ view: "Login" }, { target: "back" });
            }

        },
        viewShown: function () {
            var grid = $("#gridContainer").dxDataGrid("instance");
            grid.refresh();
        },
        Medidores: new DevExpress.data.CustomStore({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/MedidoresGasolina",
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
        Columnas: [
            {
                dataField: "Nombre",
                caption: "Tanque"
            },
            {
                dataField: "Fecha",
                caption: "Fecha"
            },
            {
                dataField: "Inicial",
                caption: "Inicial"
            },
            {
                dataField: "Final",
                caption: "Final"
            },
            {
                dataField: "TotalMedidor",
                caption: "Total medidor",
                hidingPriority: 0
            }
            ,
            {
                dataField: "TotalTanque",
                caption: "Total tanque",
                hidingPriority: 1
            }
            ,
            {
                dataField: "Diferencia",
                caption: "Diferencia",
                hidingPriority: 2
            }
        ]
    };

    return viewModel;
};