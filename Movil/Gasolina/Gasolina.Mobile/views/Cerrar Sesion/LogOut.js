Gasolina.LogOut = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        viewShowing: function () {
            Gasolina.app.navigate({ view: "Login" }, { target: "back" });
        }
    };

    return viewModel;
};