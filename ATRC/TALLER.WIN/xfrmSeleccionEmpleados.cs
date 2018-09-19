using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Utils.Drawing;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Selection;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TALLER.WIN
{
    public partial class xfrmSeleccionEmpleados : xfrmBase
    {
        public xfrmSeleccionEmpleados()
        {
            InitializeComponent();
            this.grd = new GridCheckMarksSelection(grvEmpleados);
            
        }
        GridCheckMarksSelection grd;
        UnidadDeTrabajo Unidad;
        protected ArrayList selection;
        private void xfrmSeleccionEmpleados_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            selection = new ArrayList();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Departamento", 1, BinaryOperatorType.NotEqual));//Administracion
            go.Operands.Add(new BinaryOperator("Departamento", 5, BinaryOperatorType.NotEqual));//Seguridad
            go.Operands.Add(new BinaryOperator("Activo", true, BinaryOperatorType.Equal));

            XPView Usuarios = new XPView(Unidad, typeof(Usuario));
            Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                 });
            Usuarios.Criteria = go;
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            grdEmpleados.DataSource = Usuarios;
        }

        private void bbiGenerarBitacora_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<ViewRecord> Usuarios = new List<ViewRecord>();
            //Int32[] selectedRowHandles = grvEmpleados.GetSelectedRows();
            //if (selectedRowHandles.Length > 0)
            //{
                Loading.ShowWaitForm();
                //for (int i = 0; i < selectedRowHandles.Length; i++)
                //{
                //    int selectedRowHandle = selectedRowHandles[i];
                //    if (selectedRowHandle >= 0)
                //    {
                //        Usuarios.Add((ViewRecord)grvEmpleados.GetRow(selectedRowHandle));
                //    }
                //}
                Loading.CloseWaitForm();

                ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new REPORTES.Taller.BitacoraEmpleadosTaller(grd.selection));
                repUsuarioRegistrado.ShowPreview();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Debe seleccionar almenos un empleado.");
            //}
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
    }
}
