using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace REPORTES.Unidades
{
    public partial class Radios : DevExpress.XtraReports.UI.XtraReport
    {
        public Radios()
        {
            InitializeComponent();
            XPCollection Radios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(UNIDADES.BL.Radios));
            this.DataSource = Radios;
        }

    }
}
