using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUARDIAS.WIN
{
    public partial class xfrmReportesGRD : xfrmBase
    {
        public xfrmReportesGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmReportesGRD_Load(object sender, EventArgs e)
        {
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarReporte");
            bbiImprimir.Visibility = Utilerias.VisibilidadPermiso("ImprimirReporte");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BeginInvoke(new MethodInvoker(delegate { Controles(); }));
        }

        private void Controles()
        {
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            rgTipoBusqueda.SelectedIndex = 1;
            txtFolio.Focus();

            BinaryOperator bo = new BinaryOperator("Activo", true);

            XPView Empleados = new XPView(Unidad, typeof(Usuario));
            Empleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            Empleados.Criteria = bo;
            lueEmpleado.Properties.DataSource = Empleados;
            lueEmpleado.Properties.DisplayMember = "Nombre";
            lueEmpleado.Properties.BestFit();
        }

        private void rgTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioGroup)sender).SelectedIndex == 0)
            {
                lciFolio.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciDE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciAl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                txtFolio.Text = string.Empty;
                lueEmpleado.Focus();
            }  
            else
            {
                lciFolio.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciDE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciAl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                dteAl.DateTime = dteDel.DateTime = DateTime.Now;
                lueEmpleado.EditValue = null;
                txtFolio.Focus();
            }
            grdReportes.DataSource = null;
                
        }

        private bool ValidarCOntroles()
        {
            if (string.IsNullOrEmpty(txtFolio.Text))
            {
                XtraMessageBox.Show("Debe de agregar un folio.");
                return false;
            }
            return true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            if (rgTipoBusqueda.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtFolio.Text))
                {
                    XtraMessageBox.Show("Debe de agregar un folio.");
                    lueEmpleado.Focus();
                    return;
                }
                string[] Num = Regex.Split(txtFolio.Text, @"\D+");
                string[] Depa = Regex.Split(txtFolio.Text, @"[^A-Z]+");
                
                go.Operands.Add(new BinaryOperator("Folio", Num[1]));
                go.Operands.Add(new BinaryOperator("Departamento", Depa[0]));
            }
            else
            {
                if (lueEmpleado.EditValue == null)
                {
                    XtraMessageBox.Show("Debe de seleccionar un empleado.");
                    lueEmpleado.Focus();
                    return;
                }
                go.Operands.Add(new BinaryOperator("FechaAlta", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                go.Operands.Add(new BinaryOperator("FechaAlta", dteAl.DateTime.Date.AddDays(1), BinaryOperatorType.LessOrEqual));
                go.Operands.Add(new BinaryOperator("Empleado.Oid", lueEmpleado.EditValue));
            }

            XPView Reportes = new XPView(Unidad, typeof(Reportes));
            Reportes.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Folio", SortDirection.None, "[Departamento] + ToStr([Folio])", false, true),
                  new ViewProperty("Empleado", SortDirection.None, "ToStr([Empleado.NumEmpleado]) + ' - ' + [Empleado.Nombre]", false, true)
                 });
            Reportes.Criteria = go;

            grdReportes.DataSource = Reportes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grdReportes.DataSource = null;
            rgTipoBusqueda.SelectedIndex = 1;
            lueEmpleado.EditValue = null;
            txtFolio.Text = string.Empty;
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            txtFolio.Focus();
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewReporte = grvReportes.GetFocusedRow() as ViewRecord;
            if (ViewReporte != null)
            {
                xfrmNuevoReporte xfrm = new xfrmNuevoReporte();
                xfrm.ReporteModificacion = ViewReporte.GetObject() as Reportes;
                xfrm.ShowDialog();
            }else
            {
                XtraMessageBox.Show("Debe seleccionar un reporte.");
            }

        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xfrmReportesGRD_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
