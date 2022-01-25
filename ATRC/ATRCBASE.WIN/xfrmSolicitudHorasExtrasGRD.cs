using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmSolicitudHorasExtrasGRD : xfrmBase
    {
        public xfrmSolicitudHorasExtrasGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;

        private void xfrmSolicitudHorasExtrasGRD_Load(object sender, EventArgs e)
        {

            bbiNuevaSolicitud.Visibility = Utilerias.VisibilidadPermiso("NuevaSolicitud");
            bbiModificarSolicitud.Visibility = Utilerias.VisibilidadPermiso("ModificarSolicitud");
            bbiEliminarSolicitud.Visibility = Utilerias.VisibilidadPermiso("EliminarSolicitud");
            bbiReimprimir.Visibility = Utilerias.VisibilidadPermiso("ImprimirSolicitud");

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            XPView Servicios = new XPView(Unidad, typeof(SolicitudHorasExtra));
            Servicios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[FechaSolicitud]", false, true),
                  new ViewProperty("Motivo", SortDirection.None, "[MotivoHorasExtra]", false, true),
                  new ViewProperty("Otro", SortDirection.None, "[Otro]", false, true),
                  new ViewProperty("De", SortDirection.None, "[NominaDe]", false, true),
                  new ViewProperty("A", SortDirection.None, "[NominaA]", false, true),
                  new ViewProperty("Dias", SortDirection.None, "[Dias]", false, true),
                  new ViewProperty("Empleado", SortDirection.None, "Concat(ToStr([Empleado.NumEmpleado]), ' - ', [Empleado.Nombre])", false, true)
                 });
            Servicios.Sorting.Add(new SortProperty("Fecha", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdSolicitudes.DataSource = Servicios;
        }

        private void bbiNuevaSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmSolicitudHorasExtras xfrm = new xfrmSolicitudHorasExtras())
            {
                xfrm.EsNuevo = true;
                //xfrm.Unidad = Unidad;
                xfrm.ShowDialog();
                xfrm.Dispose();
                ((XPView)grdSolicitudes.DataSource).Reload();
            }
        }

        private void bbiModificarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewSolicitud = grvSolicitudes.GetFocusedRow() as ViewRecord;
            if (viewSolicitud != null)
                using (xfrmSolicitudHorasExtras xfrm = new xfrmSolicitudHorasExtras())
                {
                    xfrm.IDSolicitud = Convert.ToInt32(viewSolicitud["Oid"]);
                    //xfrm.Unidad = Unidad;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdSolicitudes.DataSource).Reload();
                }
        }

        private void bbiEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewSolicitud = grvSolicitudes.GetFocusedRow() as ViewRecord;
            if (viewSolicitud != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la solicitud de horas extras?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    SolicitudHorasExtra Plantilla = (SolicitudHorasExtra)viewSolicitud.GetObject();
                    Plantilla.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdSolicitudes.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiReimprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bbiReimprimir.Caption == "Seleccionar imprimir solicitud")
            {
                grvSolicitudes.OptionsSelection.MultiSelect = true;
                grvSolicitudes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                bbiReimprimir.Caption = "Imprimir";
                bbiEliminarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiModificarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiNuevaSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                rpgSalir.Visible = false;
            }
            else
            {
                Int32[] selectedRowHandles = grvSolicitudes.GetSelectedRows();
                if (selectedRowHandles.Count() > 0)
                {
                    GroupOperator Go = new GroupOperator(GroupOperatorType.Or);
                    for (int i = 0; i < selectedRowHandles.Length; i++)
                    {
                        int selectedRowHandle = selectedRowHandles[i];
                        if (selectedRowHandle >= 0)
                        {
                            ViewRecord ViewSolicitud = ((ViewRecord)grvSolicitudes.GetRow(selectedRowHandle));
                            Go.Operands.Add(new BinaryOperator("Oid", ViewSolicitud["Oid"]));
                        }
                    }
                    ReportPrintTool repHorasTrabajadasTodo = new ReportPrintTool(new REPORTES.SolicitudHorasExtras(Go));
                    repHorasTrabajadasTodo.ShowPreview();
                    grvSolicitudes.OptionsSelection.MultiSelect = false;
                    grvSolicitudes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                    bbiReimprimir.Caption = "Seleccionar imprimir solicitud";
                    bbiEliminarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bbiModificarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bbiNuevaSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    rpgSalir.Visible = true;
                }
                else
                {
                    XtraMessageBox.Show("Debe seleccionar solicitudes.");
                }
            }
            
            //ViewRecord viewSolicitud = grvSolicitudes.GetFocusedRow() as ViewRecord;
            //if (viewSolicitud != null)
            //{
            //   // ReportPrintTool repHorasTrabajadasTodo = new ReportPrintTool(new REPORTES.SolicitudHorasExtras());
            //   // repHorasTrabajadasTodo.ShowPreview();
            //}

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvSolicitudes.OptionsSelection.MultiSelect = false;
            grvSolicitudes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            bbiReimprimir.Caption = "Seleccionar imprimir solicitud";
            bbiEliminarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            bbiModificarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            bbiNuevaSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            rpgSalir.Visible = true;
        }
    }
}
