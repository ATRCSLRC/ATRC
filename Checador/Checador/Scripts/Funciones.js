$(document).ready(function () {
    $("#Detalles").dblclick(function (event) {
        popupDetalle.Show();
    });

});

function ChecaGafete() {

    //var fecha = new Date();
    //var Hora = '';
    //var Hora = PrepareTimeValue(fecha.getHours()) + ":" + PrepareTimeValue(fecha.getMinutes()) + ":" +
    //    PrepareTimeValue(fecha.getSeconds());
        $.ajax({
            type: "POST",
            url: "Consultas.asmx/Checa",
            //async: true,
            data: '{Parameter: "' + bteNumEmpleado.GetText() + '|' + timeString +  '|gafete"}',
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
                document.getElementById('mensaje').innerHTML = response;
            },
            error: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
                document.getElementById('mensaje').innerHTML = response;
            }
    });
    setTimeout(function () { bteNumEmpleado.SetVisible(true); bteNumEmpleado.SetFocus(); $(".Footer").text(''); }, 2500);
    }

function ChecaManual() {
    //var fecha = new Date();
    //var Hora = PrepareTimeValue(fecha.getHours()) + ":" + PrepareTimeValue(fecha.getMinutes()) + ":" +
    //    PrepareTimeValue(fecha.getSeconds());
   // var str = '';
    //var value = str.concat('{ Parameter: ', bteManual.GetText(), '|manual|', Hora.toString(), '}'); 
        $.ajax({
            type: "POST",
            url: "Consultas.asmx/Checa",
            //async: true,
            data: '{ Parameter: "' + bteManual.GetText() + '|' + timeString + '|manual"}',
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
            },
            error: function (response) {
                //bteNumEmpleado.SetVisible(true);
                //bteNumEmpleado.SetFocus();
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
