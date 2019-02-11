using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Unidades
{
    public partial class ProximosCambiosAceite : DevExpress.XtraReports.UI.XtraReport
    {
        public ProximosCambiosAceite(XPView Cambios)
        {
            InitializeComponent();
            this.DataSource = Cambios;
        }

    }
}
