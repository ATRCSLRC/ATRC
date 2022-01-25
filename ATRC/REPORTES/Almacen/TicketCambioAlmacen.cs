using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ALMACEN.BL;

namespace REPORTES.Almacen
{
    public partial class TicketCambioAlmacen : DevExpress.XtraReports.UI.XtraReport
    {
        public TicketCambioAlmacen(Factura factura, string NombreEmpleado)
        {
            InitializeComponent();

            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblDescripcion.Text = factura.Articulo.Nombre;
            lblEmpleado.Text = NombreEmpleado;
            lblFooter.Text += "al almacen " + factura.Almacen + ".";
        }

    }
}
