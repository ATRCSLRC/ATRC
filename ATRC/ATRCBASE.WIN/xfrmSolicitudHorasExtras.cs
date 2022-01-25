using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using GUARDIAS.BL;
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
    public partial class xfrmSolicitudHorasExtras : xfrmBase
    {
        public xfrmSolicitudHorasExtras()
        {
            InitializeComponent();
        }

        public int IDSolicitud;
        public bool EsNuevo = false;
        public UnidadDeTrabajo Unidad;
        SolicitudHorasExtra Solicitud;

        private void xfrmSolicitudHorasExtras_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            CargarEmpleados();

            if (EsNuevo)
                Solicitud = new SolicitudHorasExtra(Unidad);
            else
            {
                Solicitud = Unidad.GetObjectByKey<SolicitudHorasExtra>(IDSolicitud);
                //lueCliente.Properties.DataSource = IniciarClientes();
                CargarValoresModificar();
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validar())
            {
                Solicitud.FechaSolicitud = dteFecha.DateTime;
                Solicitud.NominaDe = dteDe.DateTime;
                Solicitud.NominaA = dteA.DateTime;
                Solicitud.Empleado = Unidad.GetObjectByKey<Usuario>(lue.EditValue);
                string Motivo = string.Empty;
                foreach (CheckedListBoxItem item in clbEmpleado.CheckedItems)
                {
                    Motivo += item.Value + ",";
                }
                Solicitud.MotivoHorasExtra = Motivo.TrimEnd(',');
                Solicitud.Otro = txtOtro.Text;
                Solicitud.Dias = txtDias.Text;
                Solicitud.Save();
                Unidad.CommitChanges();

                //ReportPrintTool repHorasTrabajadasTodo = new ReportPrintTool(new REPORTES.SolicitudHorasExtras());
                //repHorasTrabajadasTodo.ShowPreview();

                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CargarValoresModificar()
        {
            dteFecha.DateTime = Solicitud.FechaSolicitud;
            dteDe.DateTime = Solicitud.NominaDe;
            dteA.DateTime = Solicitud.NominaA;
            lue.EditValue = Solicitud.Empleado.Oid;
            string[] Motivos = Solicitud.MotivoHorasExtra.Split(',');
            foreach(string Motivo in Motivos)
            {
                clbEmpleado.SetItemChecked(clbEmpleado.FindString(Motivo), true);
            }
            txtOtro.Text = Solicitud.Otro;
            txtDias.Text = Solicitud.Dias;
        }

        public void CargarEmpleados()
        {
            dteFecha.DateTime = dteDe.DateTime = dteA.DateTime = DateTime.Now;
            XPView Empleados = new XPView(Unidad, typeof(Usuario));
            Empleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                   new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                 });
            Empleados.Criteria = new BinaryOperator("Activo", true);
            Empleados.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            lue.Properties.DataSource = Empleados;
        }

        private bool Validar()
        {
            if(dteFecha.EditValue == null)
            {
                XtraMessageBox.Show("Debe de selecccionar la fecha de la solicitud.");
                dteFecha.Focus();
                return false;
            }

            if (dteDe.EditValue == null)
            {
                XtraMessageBox.Show("Debe de selecccionar la fecha De.");
                dteDe.Focus();
                return false;
            }

            if (dteA.EditValue == null)
            {
                XtraMessageBox.Show("Debe de selecccionar la fecha A.");
                dteA.Focus();
                return false;
            }

            if (lue.EditValue == null)
            {
                XtraMessageBox.Show("Debe de selecccionar un empleado.");

                lue.Focus();
                return false;
            }

            if (clbEmpleado.CheckedItemsCount == 0)
            {
                XtraMessageBox.Show("Debe de selecccionar un motivo.");
                clbEmpleado.Focus();
                return false;
            }
            return true;
        }

        private void clbEmpleado_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if(e.Index == 8)
            {
                if (e.State == CheckState.Checked)
                    lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                else
                    lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}
