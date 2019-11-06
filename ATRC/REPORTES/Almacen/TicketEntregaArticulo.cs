using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ALMACEN.BL;

namespace REPORTES.Almacen
{
    public partial class TicketEntregaArticulo : DevExpress.XtraReports.UI.XtraReport
    {
        public TicketEntregaArticulo(SalidaArticulo Salida)
        {
            InitializeComponent();

            lblFecha.Text = Salida.Fecha.ToLongDateString();
            lblCantidad.Text = Salida.Cantidad.ToString();
            lblDescripcion.Text = Salida.Articulo.Nombre;
            lblEmpleado.Text = Salida.TipoRecibo == ATRCBASE.BL.Enums.Recibo.Usuario ? Salida.UsuarioRecibo.NumEmpleado + " - " + Salida.UsuarioRecibo.Nombre : Salida.OtroRecibo;
            lblFooter.Text += Salida.TipoDestino == ATRCBASE.BL.Enums.Destino.Unidad ? "la unidad " + ((UNIDADES.BL.Unidad)Salida.GetMemberValue("Unidad")).Nombre + "." : Salida.OtroDestino + ".";
        }

    }
}
