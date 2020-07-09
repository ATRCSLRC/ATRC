using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Almacen
{
    public partial class HerramientaPrestada : DevExpress.XtraReports.UI.XtraReport
    {
        public HerramientaPrestada(DateTime De, DateTime Al, XPView Prestamos)
        {
            InitializeComponent();
            this.DataSource = Prestamos;
            lblFecha.Text = "Del: " + De.ToLongDateString() + " a " + Al.ToLongDateString();
        }

    }
}
