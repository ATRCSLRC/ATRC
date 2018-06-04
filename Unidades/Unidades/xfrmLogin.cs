using DevExpress.Data.Filtering;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmLogin : RibbonForm
    {
        public xfrmLogin()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmLogin_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) || !string.IsNullOrEmpty(txtContraseña.Text))
                Ingresar();
            else
                XtraMessageBox.Show("Favor de ingresar los todos los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Cursor.Current = Cursors.Default;
        }

        #region Metodos
        private void Ingresar()
        {
            Cursor.Current = Cursors.WaitCursor;
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("NombreUsuario", txtUsuario.Text));
            go.Operands.Add(new BinaryOperator("ConstraseñaDesencriptada", txtContraseña.Text));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                Utilerias.UsuarioActual = Usuario;
                this.DialogResult = DialogResult.OK;

                this.Dispose();
            }
            else
                XtraMessageBox.Show("Los datos proporcionados son incorrectos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContraseña.Focus();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text) || !string.IsNullOrEmpty(txtContraseña.Text))
                    Ingresar();
                else
                    XtraMessageBox.Show("Favor de ingresar los todos los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Cursor.Current = Cursors.Default;
            }
        }
    }
}
