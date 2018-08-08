using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TALLER.BL;

namespace TALLER.WIN
{
    public partial class xfrmCapturaActividades : xfrmBase
    {
        public xfrmCapturaActividades()
        {
            InitializeComponent();
        }

        Usuario Usuario;
        UnidadDeTrabajo Unidad;
        List<Actividades> Actividades;
        private void xfrmCapturaActividades_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); }));
        }

        private void btnEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnEmpleado_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnEmpleado.Text))
            {
                Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnEmpleado.Text)));
                if (Usuario != null)
                {
                    txtNombre.Text = Usuario.Nombre;
                    dteFecha.ReadOnly = true;
                    btnEmpleado.ReadOnly = true;
                    ActivarControles();
                    XPCollection<Actividades> actividades = new XPCollection<Actividades>(Unidad, new BinaryOperator("Fecha", dteFecha.DateTime.Date));
                    Actividades.AddRange(actividades);
                    grdActividades.RefreshDataSource();
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = string.Empty;
                    btnEmpleado.Focus();
                }
            }
            else
            {
                txtNombre.Text = string.Empty;
                btnEmpleado.Focus();
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(xfrm.IDUsuario)));
                if (Usuario != null)
                {
                    txtNombre.Text = Usuario.Nombre;
                    btnEmpleado.Text = Usuario.NumEmpleado.ToString();
                    dteFecha.ReadOnly = true;
                    btnEmpleado.ReadOnly = true;
                    ActivarControles();
                    txtActividad.Focus();
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnEmpleado.Text = txtNombre.Text = string.Empty;
                    btnEmpleado.Focus();
                }
            }
            else
            {
                Usuario = null;
                btnEmpleado.Text = txtNombre.Text = string.Empty;
                btnEmpleado.Focus();
            }
        }

        private void xfrmCapturaActividades_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtActividad.Text))
            {
                Actividades Actividad = new Actividades(Unidad);
                Actividad.Fecha = dteFecha.DateTime.Date;
                Actividad.Usuario = Usuario;
                Actividad.Actividad = txtActividad.Text;
                Actividad.HoraInicial = timeHoraInicio.Time.TimeOfDay;
                Actividad.HoraFinal = timeHoraFinal.Time.TimeOfDay;
                Actividad.Total = (timeHoraFinal.Time.TimeOfDay - timeHoraInicio.Time.TimeOfDay).TotalHours;
                Actividad.Save();
                Actividades.Add(Actividad);
                grdActividades.RefreshDataSource();

                txtActividad.Text = string.Empty;
                timeHoraInicio.EditValue = timeHoraFinal.EditValue;
                timeHoraFinal.EditValue = new TimeSpan(0, 0, 0);
                txtActividad.Focus();
            }
            else
            {
                XtraMessageBox.Show("Favor de llenar todos los campos");
            }
        }

        private void repositoryItemBorrarActividad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Actividades Actividad =  (Actividades)grvActividades.GetFocusedRow();
            if(Actividad != null)
            {
                if (XtraMessageBox.Show("¿Se encuentra seguro de eliminar esta actividad?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Actividades.Remove(Actividad);
                    Actividad.Delete();
                    grdActividades.RefreshDataSource();
                }
            }
        }

        private void grvActividades_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            int row = view.GetRowHandle(e.ListSourceRowIndex);
            Actividades Actividad = (Actividades)view.GetRow(row);
            if (e.Column.FieldName == "HoraInicialT")
            {
                if (e.IsGetData)
                    e.Value = Actividad.HoraInicial;
                if (e.IsSetData)
                {
                    Actividad.HoraInicial = Convert.ToDateTime(e.Value).TimeOfDay;
                    Actividad.Total = (Actividad.HoraFinal - Actividad.HoraInicial).TotalHours;
                    Actividad.Save();
                    grdActividades.RefreshDataSource();
                }
            }
            if (e.Column.FieldName == "HoraFinalT")
            {
                if (e.IsGetData)
                    e.Value = Actividad.HoraFinal;
                if (e.IsSetData)
                {
                    Actividad.HoraFinal = Convert.ToDateTime(e.Value).TimeOfDay;
                    Actividad.Total = (Actividad.HoraFinal - Actividad.HoraInicial).TotalHours;
                    Actividad.Save();
                    grdActividades.RefreshDataSource();
                }
            }
        }

        private void ActivarControles()
        {
            txtActividad.ReadOnly = false;
            timeHoraFinal.ReadOnly = timeHoraInicio.ReadOnly = false;
            btnAgregarActividad.Enabled = btnCancelarActividad.Enabled = true;
        }

        private void DesactivarControles()
        {
            txtActividad.ReadOnly = true;
            timeHoraFinal.ReadOnly = timeHoraInicio.ReadOnly = true;
            btnAgregarActividad.Enabled = btnCancelarActividad.Enabled = false;
            Actividades = new List<Actividades>();
            grdActividades.DataSource = Actividades;
        }

        private void btnCancelarActividad_Click(object sender, EventArgs e)
        {
            txtActividad.Text = string.Empty;
            timeHoraInicio.EditValue = new TimeSpan(0, 0, 0);
            timeHoraFinal.EditValue = new TimeSpan(0, 0, 0);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Unidad.CommitChanges();
                Actividades = new List<Actividades>();
                txtNombre.Text = string.Empty;
                btnEmpleado.Text = string.Empty;
                dteFecha.ReadOnly = false;
                btnEmpleado.ReadOnly = false;
                DesactivarControles();
                timeHoraInicio.EditValue = new TimeSpan(0, 0, 0);
                timeHoraFinal.EditValue = new TimeSpan(0, 0, 0);
                btnEmpleado.Focus();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de cancelar? Si, continúa podría perder sus cambios.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Actividades = new List<Actividades>();
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                txtNombre.Text = string.Empty;
                btnEmpleado.Text = string.Empty;
                dteFecha.ReadOnly = false;
                btnEmpleado.ReadOnly = false;
                DesactivarControles();
                txtActividad.Text = string.Empty;
                timeHoraInicio.EditValue = new TimeSpan(0, 0, 0);
                timeHoraFinal.EditValue = new TimeSpan(0, 0, 0);
                btnEmpleado.Focus();
            }
        }

        private void IniciarControles()
        {
            dteFecha.DateTime = DateTime.Now;
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Actividades = new List<Actividades>();
            grdActividades.DataSource = Actividades;
            btnEmpleado.Focus();
        }

        private void btnEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnEmpleado.Text))
                {
                    Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnEmpleado.Text)));
                    if (Usuario != null)
                    {
                        txtNombre.Text = Usuario.Nombre;
                        dteFecha.ReadOnly = true;
                        btnEmpleado.ReadOnly = true;
                        ActivarControles();
                        txtActividad.Focus();
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Fecha", dteFecha.DateTime.Date));
                        go.Operands.Add(new BinaryOperator("Usuario.Oid", Usuario.Oid));
                        XPCollection<Actividades> actividades = new XPCollection<Actividades>(Unidad,go);
                        Actividades.AddRange(actividades);
                        grdActividades.RefreshDataSource();
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombre.Text = string.Empty;
                        btnEmpleado.Focus();
                    }
                }
                else
                {
                    txtNombre.Text = string.Empty;
                    btnEmpleado.Focus();
                }
            }
        }
    }
}
