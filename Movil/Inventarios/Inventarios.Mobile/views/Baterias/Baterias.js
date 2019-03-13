Inventarios.Baterias = function (params) {
    "use strict";
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
    var viewModel = {
//  Put the binding properties here
        Bateria: ko.observable(),
        Titulo: ko.observable(),
        Comentario: ko.observable(),
        BateriasPopUp: ko.observable(false),
        Unidades: ko.observableArray(),
        viewShowing: function () {
            var id = window.atob(localStorage.getItem(localStorage.key(0)));
            if (isNaN(id)) {
                Inventarios.app.navigate({ view: "Login" }, { target: "back" });
            }

        },
        viewShown: function () {
            var grid = $("#gridContainer").dxDataGrid("instance");
            grid.refresh();
            Unidades.load().done(function (data) {
                viewModel.Unidades(data);
            });
        },
        Columnas: [
            {
                dataField: "Verificado",
                caption: "Verificado",
                width: 90
            },
            {
                dataField: "Nombre",
                caption: "Unidad",
                width: 100,
                alignment: "center"
            },
            {
                dataField: "Bateria",
                caption: "Baterias"
            }
        ],
        OnSeleccion: function (selectedItems) {
            if (selectedItems.values.length > 0) {
                if (selectedItems.values[0] == false || selectedItems.values[0] == undefined) {
                    viewModel.Titulo('Baterias de la unidad ' + selectedItems.data.Nombre);
                    if (selectedItems.data.Bateria != '') {
                        viewModel.Bateria(selectedItems.data.Bateria.split(','));
                    }
                    viewModel.BateriasPopUp(true);
                }
            }
        },
        OnOption(e) {
            if ((e.name == "opened") && (e.value === true) ) {
                e.component.close();
            }
        },
        OnClickGuardar: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {
                var grd = $("#gridContainer").dxDataGrid("instance");
                var Unidad = grd._options.selectedRowKeys[0]["ID"];
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/GuardarInventarioBateria",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{IDUnidad:' + Unidad + ', Baterias:"' + viewModel.Bateria().toString() +
                        '", Comentario:"' + viewModel.Comentario() + '"}',
                    success: function (result) {
                        Unidades.load().done(function (data) {
                            viewModel.Unidades(data);
                        });
                        viewModel.BateriasPopUp(false);
                        grd.refresh();
                        viewModel.Bateria(null);
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
            viewModel.BateriasPopUp(false);
            viewModel.Bateria(null);
            viewModel.Comentario('');
            e.validationGroup.reset();
        }
    };

    return viewModel;
};