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
    public partial class xfrmChecador : xfrmBase
    {
        public xfrmChecador()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        UsuarioChecador Usuario;

        #region Eventos
        private void xfrmChecador_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteFecha.DateTime = DateTime.Now;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Usuario != null)
            {
                CHECADOR.BL.Utilerias.CrearChecada(dteFecha.DateTime, tmeHoraEntrada.Time.TimeOfDay, tmeHoraSalida.Time.TimeOfDay, tmeHoraEntrada.EditValue == null ? false : true, tmeHoraSalida.EditValue == null ? false : true, memoMotivo.Text, Usuario, Unidad);
                Unidad.CommitChanges();
                this.Close();
            }else
            {
                XtraMessageBox.Show("Debe de seleccionar un usuario.");
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
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
                        txtNombreUsuario.Text = Usuario.Usuario.Nombre;
                        btnNumUsuario.Text = Usuario.Usuario.NumEmpleado.ToString();
                    }
                }else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
                }
            }else
            {
                Usuario = null;
                btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
            }
        }

        private void btnNumUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnNumUsuario.Text))
                {
                    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnNumUsuario.Text));
                    if (Usuario != null)
                    {
                        if (Usuario.Usuario != null)
                            txtNombreUsuario.Text = Usuario.Usuario.Nombre;
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombreUsuario.Text = string.Empty;
                    }
                }else
                {
                    txtNombreUsuario.Text = string.Empty;
                }
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
                        txtNombreUsuario.Text = Usuario.Usuario.Nombre;
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombreUsuario.Text = string.Empty;
                }
            }
            else
            {
                txtNombreUsuario.Text = string.Empty;
            }
        }
        #endregion

       
    }

}
