using ATRCBASE.BL;
using GUARDIAS.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace GUARDIAS.WIN
{
    public partial class xfrmReportesPorUsuario : xfrmBase
    {
        public xfrmReportesPorUsuario()
        {
            InitializeComponent();
        }

        public int NumEmpleado;
        private void xfrmReportesPorUsuario_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Reportes = new XPView(Unidad, typeof(Reportes));
            Reportes.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Folio", SortDirection.None, "[Departamento] + ToStr([Folio])", false, true),
                  new ViewProperty("Empleado", SortDirection.None, "ToStr([Empleado.NumEmpleado]) + ' - ' + [Empleado.Nombre]", false, true)
                 });
            Reportes.Criteria = new BinaryOperator("Empleado.NumEmpleado", NumEmpleado);
            Reportes.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdReportes.DataSource = Reportes;
            lblTotal.Caption = "Total de reportes: " + Reportes.Count;
        }

        public static void MostrarVentana(int NumEmpleado, string Nombre)
        {
            xfrmReportesPorUsuario xfrm = new xfrmReportesPorUsuario();
            xfrm.NumEmpleado = NumEmpleado;
            xfrm.Text = "Reportes del empleado " + Nombre;
            xfrm.Show();
        }

        private void bbiVistaPrevia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewReporte = grvReportes.GetFocusedRow() as ViewRecord;
            if (ViewReporte != null)
            {
                ReportPrintTool repReporte = new ReportPrintTool(new REPORTES.Guardias.ReporteIndiciplina(Convert.ToInt32(ViewReporte["Oid"])));
                repReporte.ShowPreview();
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un reporte.");
            }
        }
    }
}
