using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TALLER.WIN
{
    public partial class xfrmFiltrosTaller : xfrmBase
    {
        public xfrmFiltrosTaller()
        {
            InitializeComponent();
        }

        public bool EsDiario;
        private void xfrmFiltrosTaller_Load(object sender, EventArgs e)
        {
            dteAl.DateTime = DateTime.Now;
            dteDe.DateTime = DateTime.Now;
            if (!EsDiario)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("EsAdministrativo", false));
                go.Operands.Add(new BinaryOperator("Activo", true));

                XPView Empleados = new XPView(Unidad, typeof(Usuario));
                Empleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
                Empleados.Criteria = go;
                Empleados.Sorting.Add(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending));
                lueEmpleados.Properties.DataSource = Empleados;
            }
            else
            {
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciAl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                
            }
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!EsDiario)
            {
                ReportPrintTool repActividadesTallerEmpleado = new ReportPrintTool(new REPORTES.Taller.BitacoraActividadesEmpleadosTaller(dteDe.DateTime.Date, dteAl.DateTime.Date, Convert.ToInt32(lueEmpleados.EditValue)));                                                                                                                    //new REPORTES.Taller.BitacoraActividadesEmpleadosTaller(DateTime.Now.AddDays(-30), DateTime.Now,842));
                repActividadesTallerEmpleado.ShowPreview();
            }
            else
            {
                ReportPrintTool repActividadesTallerDiario = new ReportPrintTool(new REPORTES.Taller.BitacoraActividadesTallerDiario(dteDe.DateTime.Date));                                                                                                               //new REPORTES.Taller.BitacoraActividadesEmpleadosTaller(DateTime.Now.AddDays(-30), DateTime.Now,842));
                repActividadesTallerDiario.ShowPreview();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
