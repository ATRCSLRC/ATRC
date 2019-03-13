Gasolina.Login = function (params) {
    "use strict";
    document.addEventListener("deviceready", onDeviceReady, false);
    function onDeviceReady() {
        console.log(starprnt);
    }
    var viewModel = {
//  Put the binding properties here
        Password: ko.observable(),
        Empleado: ko.observable(),
        loader: ko.observable(),
        galleryData: [
            "img/ATRC-LOGO.png"
        ],
        viewShown: function () {
            Gasolina.app.viewCache.clear();
        },
        iniciarsesion: function (e) {
            var result = e.validationGroup.validate();
            if (result.isValid) {

                viewModel.loader(true);
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/InicioDeSesion",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{Usuario:' + viewModel.Empleado() + ', Contrasena:"' + viewModel.Password().toString() + '"}',
                    success: function (data) {
                        if (data.d == 1) {
                            localStorage.setItem(window.btoa("Session"), window.btoa(viewModel.Empleado()));
                            Gasolina.app.navigate({ view: "Main" }, { target: "back" });
                            viewModel.loader(false);
                        } else {
                            viewModel.loader(false);
                            DevExpress.ui.notify('Datos incorrectos', 'error', 4000);
                        }
                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        viewModel.loader(false);
                        DevExpress.ui.dialog.alert(errorThrown, 'Error');
                    }
                });
            }
        }
    };

    return viewModel;
};