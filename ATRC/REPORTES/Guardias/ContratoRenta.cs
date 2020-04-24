using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace REPORTES.Guardias
{
    public partial class ContratoRenta : DevExpress.XtraReports.UI.XtraReport
    {
        public ContratoRenta( int IDContrato)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView ViewContrato = new XPView(Unidad, typeof(GUARDIAS.BL.ContratoRenta), "Oid;NumContrato;Responsable;Domicilio;Colonia;CP;Ciudad;Estado;" +
                "Tel;ADondeSeDirige;LugarOrigenLugarDestino;HoraSalida;HoraRegreso;DiaSalida;DiaRegreso;Costo;Iva;Total;Anticipo;Unidad.TipoUnidad;Cliente;" +
                "Unidad.Nombre;Cliente.Nombre;Cliente.Domicilio;Cliente.Colonia;Cliente.CP;Cliente.Ciudad;Cliente.Estado;Cliente.Tel;Unidad.Pasajeros;Subtotal", new BinaryOperator("Oid", IDContrato));
            this.DataSource = ViewContrato;
            var dateTimeRegreso = new DateTime(((TimeSpan)ViewContrato[0]["HoraRegreso"]).Ticks);
            var dateTimeSalida = new DateTime(((TimeSpan)ViewContrato[0]["HoraSalida"]).Ticks);
            lblHoraRegreso.Text = dateTimeRegreso.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            lblHoraSalida.Text = dateTimeSalida.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            //lblArrendador.Text = ATRCBASE.BL.Utilerias.UsuarioActual.Nombre;
            RichPrincipio.Html = "<div text-align:justify><FONT size='2' FACE='tahoma'><b>AUTO TRANSPORTES DEL RIO COLORADO, S.A. DE C.V.</b>, conviene en proporcionar este servicio especial reconociendo y" +
                " aceptando el interesado que el mismo es por "+ ViewContrato[0]["Unidad.Pasajeros"] + " personas y se estima como tales a los niños que sepan andar. Advirtiéndose " + 
                "que cualquier exceso de pasaje, así como consumir bebidas embriagantes o envases de cualquier especie será motivo para la cancelación de este " +
                "servicio el que será totalmente liquidado al iniciarse.</FONT></div>";
            lblFecha.Text = "Leído que fue el presente Contrato y enteradas ambas partes de su contenido y fuerza, lo ratifican y firman, en la Ciudad de San Luis Río Colorado" +
                ", Sonora a los " + DateTime.Now.Day + " días del Mes de " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " del año " + DateTime.Now.Year + ".";
        }

    }
}
