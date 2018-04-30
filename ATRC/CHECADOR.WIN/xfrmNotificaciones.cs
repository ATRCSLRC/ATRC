using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECADOR.WIN
{
    public partial class xfrmNotificaciones : xfrmBase
    {
        public xfrmNotificaciones()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Notificaciones Notificacion;
        UsuarioChecador Usuario;

        #region Eventos
        private void xfrmNotificaciones_Load(object sender, EventArgs e)
        {
            ATRCBASE.BL.Utilerias.CargarLookupEdit(lueResponsable, typeof(Usuario), new BinaryOperator("EsAdministrativo", true) ,Unidad, "Nombre", "Nombre", false);
        }
        
        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Notificacion.Responsable = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, ((Usuario)lueResponsable.EditValue).NumEmpleado);
                Notificacion.Receptor = Usuario;
                Notificacion.Motivo = memoMotivo.Text;
                Notificacion.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void btnNumUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnNumUsuario.Text))
                {
                    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnNumUsuario.Text));
                    if (Usuario != null)
                    {
                        if (Usuario.Usuario != null)
                            txtNombre.Text = Usuario.Usuario.Nombre;
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombre.Text = string.Empty;
                    }
                }
                else
                {
                    txtNombre.Text = string.Empty;
                }
            }
        }

        private void btnNumUsuario_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, xfrm.IDUsuario);
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                    {
                        txtNombre.Text = Usuario.Usuario.Nombre;
                        btnNumUsuario.Text = Usuario.Usuario.NumEmpleado.ToString();
                    }
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
                }
            }
            else
            {
                Usuario = null;
                btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
            }
        }

        private void btnNumUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnNumUsuario.Text))
            {
                Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnNumUsuario.Text));
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                        txtNombre.Text = Usuario.Usuario.Nombre;
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = string.Empty;
                }
            }
            else
            {
                txtNombre.Text = string.Empty;
            }
        }
        #endregion

        #region Metodos
        private bool ValidarCampos()
        {
            if (Usuario == null)
            {
                XtraMessageBox.Show("Favor de seleccionar un usuario.");
                return false;
            }
            if (lueResponsable.EditValue == null)
            {
                XtraMessageBox.Show("Favor de seleccionar un usuario con el cual debe pasar.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
