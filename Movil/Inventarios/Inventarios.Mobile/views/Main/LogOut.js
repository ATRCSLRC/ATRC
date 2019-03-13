Inventarios.LogOut = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        viewShowing: function () {
            Inventarios.app.navigate({ view: "Login" }, { target: "back" });
        }
    };

    return viewModel;
};