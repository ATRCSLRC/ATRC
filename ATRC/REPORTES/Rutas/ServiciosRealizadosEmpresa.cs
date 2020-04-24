using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Rutas
{
    public partial class ServiciosRealizadosEmpresa : DevExpress.XtraReports.UI.XtraReport
    {
        public ServiciosRealizadosEmpresa(XPCollection Rutas, DateTime De, DateTime Al, bool PorTurno = false)
        {
            InitializeComponent();

            this.DataSource = Rutas;
            lblDel.Text = De.ToString("dd-MMMM-yyy");
            lblAl.Text = Al.ToString("dd-MMMM-yyy");
            lblTurno.Visible = PorTurno;
        }

    }
}
