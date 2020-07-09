using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace REPORTES.Rutas
{
    public partial class RutasDePedido : DevExpress.XtraReports.UI.XtraReport
    {
        public RutasDePedido(RUTAS.BL.PedidoRutas Pedido)
        {
            InitializeComponent();
            lblSubtitulo.Text = "Listado de rutas del pedido " + Pedido.Nombre;
            this.DataSource = Pedido.Rutas;
        }

    }
}
