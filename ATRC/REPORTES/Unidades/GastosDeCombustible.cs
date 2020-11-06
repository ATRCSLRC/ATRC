using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Unidades
{
    public partial class GastosDeCombustible : DevExpress.XtraReports.UI.XtraReport
    {
        public GastosDeCombustible(XPView Salidas, double Total)
        {
            InitializeComponent();
            drCombustible.DataSource = Salidas;
            lblTotal.Text = Total.ToString("c");
            lblUnidad.Text = Salidas[0]["Unidad.Nombre"].ToString();
        }

    }
}
