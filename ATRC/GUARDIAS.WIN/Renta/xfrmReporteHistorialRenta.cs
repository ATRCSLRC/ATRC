using ATRCBASE.WIN;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN.Renta
{
    public partial class xfrmReporteHistorialRenta : xfrmBase
    {
        public xfrmReporteHistorialRenta()
        {
            InitializeComponent();
        }

        private void xfrmReporteHistorialRenta_Load(object sender, EventArgs e)
        {
            dteDe.DateTime = dteA.DateTime = DateTime.Now;
        }

        private void bbiGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new REPORTES.Guardias.HistorialRenta(dteDe.DateTime, dteA.DateTime));
            repUsuarioRegistrado.ShowPreview();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
