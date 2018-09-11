using ATRCBASE.BL;
using ATRCBASE.WIN;
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

namespace ATRC
{
    public partial class xfrmLogin : xfrmBase
    {
        public xfrmLogin()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        #region Eventos
        private void xfrmLogin_Load(object sender, EventArgs e)
        {

#if DEBUG
            //txtUsuario.Text = "1";
            //txtContraseña.Text = "atrc1234";
#endif
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar.PerformClick();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) || !string.IsNullOrEmpty(txtContraseña.Text))
                Ingresar();
            else
                XtraMessageBox.Show("Favor de ingresar los todos los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Cursor.Current = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Metodos
        private void Ingresar()
        {
            
            Cursor.Current = Cursors.WaitCursor;
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("NumEmpleado", txtUsuario.Text));
            go.Operands.Add(new BinaryOperator("EsAdministrativo", true));
            go.Operands.Add(new BinaryOperator("ConstraseñaDesencriptada", txtContraseña.Text));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                ATRCBASE.BL.Utilerias.UsuarioActual = Usuario;
                if(Usuario.NumEmpleado == 726)
                    DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                this.DialogResult = DialogResult.OK;
                
                this.Dispose();
            }
            else
                XtraMessageBox.Show("Los datos proporcionados son incorrectos.","Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion
    }
}
