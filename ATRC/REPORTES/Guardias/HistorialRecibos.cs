using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Guardias
{
    public partial class HistorialRecibos : DevExpress.XtraReports.UI.XtraReport
    {
        public HistorialRecibos(DateTime FechaDel, DateTime FechaAl, XPView Cambios)
        {
            InitializeComponent();
            lblDetalles.Text = "Del: " + FechaDel.ToLongDateString() + " Al: " + FechaAl.ToLongDateString();
            this.DataSource = Cambios;
        }

    }
}
