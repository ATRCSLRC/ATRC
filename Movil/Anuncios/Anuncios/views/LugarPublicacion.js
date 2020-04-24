Anuncios.LugarPublicacion = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        OnComedor: function()
        {
            Anuncios.app.navigate({ view: "home", id:0 }, { target: "back" });
        },
        OnCaseta: function () {
            Anuncios.app.navigate({ view: "home", id: 1 }, { target: "back" });
        },
        OnRecepcion: function () {
            Anuncios.app.navigate({ view: "home", id: 2 }, { target: "back" });
        }
    };

    return viewModel;
};