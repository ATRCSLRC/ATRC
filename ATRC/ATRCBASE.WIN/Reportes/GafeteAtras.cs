using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using System.IO;

namespace ATRCBASE.WIN.Reportes
{
    public partial class GafeteAtras : DevExpress.XtraReports.UI.XtraReport
    {
        public GafeteAtras(Usuario Usuario)
        {
            InitializeComponent();
            lblPatron.Text = Usuario.Patron;
            lblAvisar.Text = Usuario.AvisarA;
            lblTipoSangre.Text = Usuario.TipoSangre;
            lblRFC.Text = Usuario.RFC;
            lblIMSS.Text = Usuario.IMSS;
            lblFecha.Text = Usuario.FechaIngreso.ToShortDateString();
            lblDepartamento.Text = Usuario.Departamento == null ? "" : Usuario.Departamento.Descripcion.ToUpper();
            lblRFC.ForeColor = lblIMSS.ForeColor = lblFecha.ForeColor = lblDepartamento.ForeColor = lblPatron.ForeColor = Color.FromArgb(42, 38, 36);
            lblCelAvisar.Text = Usuario.TelAvisarA;
        }

    }
}
