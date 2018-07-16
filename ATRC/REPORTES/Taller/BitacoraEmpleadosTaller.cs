using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using System.Collections.Generic;

namespace REPORTES.Taller
{
    public partial class BitacoraEmpleadosTaller : DevExpress.XtraReports.UI.XtraReport
    {
        public BitacoraEmpleadosTaller(ArrayList Usuarios)
        {
            InitializeComponent();
            lblDetalles.Text = DateTime.Now.ToLongDateString();
            this.DataSource = Usuarios;
        }

    }
}
