

$(document).ready(function () {
    setInterval(UpdateTime, 1000);
});

var dia_semana = [
    "Domingo",
    "Lunes",
    "Martes",
    "Miércoles",
    "Jueves",
    "Viernes",
    "Sábado"
];

var mes = [
    "Enero",
    "Febrero",
    "Marzo",
    "Abril",
    "Mayo",
    "Junio",
    "Julio",
    "Agosto",
    "Septiembre",
    "Octubre",
    "Noviembre",
    "Diciembre"
];
function PrepareTimeValue(value) {
    if (value < 10)
        value = "0" + value;
    return value;
}

function UpdateTime(s, e) {
    var fecha = new Date();
    var timeString = PrepareTimeValue(fecha.getHours()) + ":" + PrepareTimeValue(fecha.getMinutes()) + ":" +
        PrepareTimeValue(fecha.getSeconds());
    var Hoy = dia_semana[fecha.getDay()] + ", " + fecha.getDate() + " de " + mes[fecha.getMonth()] + " del " + fecha.getFullYear();
    document.getElementById("hora").innerHTML = timeString;
    document.getElementById("fecha").innerHTML = Hoy;
    }