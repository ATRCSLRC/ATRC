using ATRCBASE.BL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmCambioContraseña : xfrmBase
    {
        public xfrmCambioContraseña()
        {
            InitializeComponent();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Usuario Usuario = Utilerias.ObtenerUsuarioActual(Unidad);
                if (Usuario != null)
                {
                    Usuario.Constraseña = txtContraseña.Text;
                    Usuario.Save();
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("La contraseña se ha guardado correctamente.");
                }
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(txtConfirmarContraseña.Text))
                lciMensaje.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
            {
                if(string.IsNullOrEmpty(txtConfirmarContraseña.Text))
                    lciMensaje.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                else
                    lciMensaje.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            }


        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfirmarContraseña.Text))
            {
                XtraMessageBox.Show("Debe llenar todos los campos.");
                return false;
            }

            if (!string.Equals(txtContraseña.Text, txtConfirmarContraseña.Text))
            {
                XtraMessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            return true;
        }

        private void xfrmCambioContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
