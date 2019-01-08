$(document).ready(function () {
    $("#Detalles").dblclick(function (event) {
        popupDetalle.Show();
    });

});

function ChecaGafete() {
        $.ajax({
            type: "POST",
            url: "Consultas.asmx/Checa",
            //async: true,
            data: '{Parameter: "' + bteNumEmpleado.GetText() + '|gafete' + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var x = response.d.split("|");
                $(".Footer").text(x[0]);
                
                if (x[1].includes("Entrada")) {
                    lstEntradas.InsertItem(0, x[1]);
                } else {
                    lstSalida.InsertItem(0, x[1]);
                }
            },
            failure: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
                //document.getElementById('mensaje').innerHTML = '';
            },
            error: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
                //document.getElementById('mensaje').innerHTML = '';
            }
    });
    setTimeout(function () { bteNumEmpleado.SetVisible(true); bteNumEmpleado.SetFocus(); $(".Footer").text(''); }, 2500);
    }

    function ChecaManual() {
        $.ajax({
            type: "POST",
            url: "Consultas.asmx/Checa",
            //async: true,
            data: '{Parameter: "' + bteManual.GetText() + '|manual' + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var x = response.d.split("|");
                $(".Footer").text(x[0]);
                
                if (x[1].includes("Entrada")) {
                    lstEntradas.InsertItem(0, x[1]);
                } else {
                    lstSalida.InsertItem(0, x[1]);
                }
            },
            failure: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
                //document.getElementById('mensaje').innerHTML = '';
            },
            error: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
                //document.getElementById('mensaje').innerHTML = '';
            }
        });
        setTimeout(function () { bteNumEmpleado.SetVisible(true); bteNumEmpleado.SetFocus(); $(".Footer").text(''); }, 2500);
    }

    var Numero = "";
    function Concatenar(Num) {
        if (Numero.length > 6) {
            return;
        }
        Numero += "" + Num;
        bteManual.SetText(Numero);
    }

    function Delete() {
        Numero = Numero.slice(0, Numero.length - 1);
        bteManual.SetText(Numero);
}

function Manual() {
    ChecaGafete();
    bteNumEmpleado.SetVisible(false);
    bteNumEmpleado.SetText('');
}
