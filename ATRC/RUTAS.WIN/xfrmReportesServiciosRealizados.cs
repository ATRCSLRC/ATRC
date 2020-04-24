using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmReportesServiciosRealizados : xfrmBase
    {
        public xfrmReportesServiciosRealizados()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmReportesServiciosRealizados_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
        }

        private void rgEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgEmpresa.SelectedIndex == 0)
                lciEmpresa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciEmpresa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator();
            if(rgEmpresa.SelectedIndex == 1)
                go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresa.EditValue));
            go.Operands.Add(new BetweenOperator("Fecha", dteDe.DateTime.Date, dteAl.DateTime.Date));
            XPView Reportes = new XPView(Unidad, typeof(ReportesServiciosRealizados), "Oid;Fecha;Descripcion;Empresa.Nombre;Archivo", go);
            grdReportes.DataSource = Reportes;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            ViewRecord ViewReporte = grvReportes.GetFocusedRow() as ViewRecord;
            byte[] pdf = Convert.FromBase64String(ViewReporte["Archivo"].ToString());
            MemoryStream stream = new MemoryStream(pdf);
            xfrmVisorPDF Reporte = new xfrmVisorPDF();
            Reporte.PDF = stream;
            Reporte.Show();
            //ReportPrintTool repServiciosRealizados = new ReportPrintTool(stream);
            //repServiciosRealizados.ShowPreview();
        }
    }
}
