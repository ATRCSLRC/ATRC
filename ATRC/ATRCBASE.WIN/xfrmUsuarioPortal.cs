using ATRCBASE.BL;
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

namespace ATRCBASE.WIN
{
    public partial class xfrmUsuarioPortal : xfrmBase
    {
        public xfrmUsuarioPortal()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Usuario Usuario;
        public bool EsNuevo;

        private void xfrmUsuarioPortal_Load(object sender, EventArgs e)
        {
            Utilerias.CargarLookupEdit(lueEmpresa, typeof(Empresas), Unidad, "Nombre", "Nombre", false);
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                
                Usuario.EsExterno = true;
                Usuario.Save();
                if (EsNuevo)
                {
                    ActivacionUsuario Activacion = new ActivacionUsuario(Unidad);
                    Activacion.Vencimiento = DateTime.Now.AddHours(48);
                    Activacion.Usuario = Usuario;
                    Activacion.Save();
                }
                Unidad.CommitChanges();
                if (EsNuevo)
                    Utilerias.EnviarCorreo(Usuario.Correo,"Mensaje ","Activación de usuario de portal ATRC", null, null);
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void LigarControles()
        {
            txtNombre.DataBindings.Add("EditValue", Usuario, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            lueEmpresa.DataBindings.Add("EditValue", Usuario, "Empresa!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCorreo.DataBindings.Add("EditValue", Usuario, "Correo", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe asignarle un nombre.");
                txtNombre.Focus();
                return false;
            }

            //if (string.IsNullOrEmpty(txtUsuario.Text))
            //{
            //    XtraMessageBox.Show("Debe asignar un usuario.");
            //    txtNombre.Focus();
            //    return false;
            //}

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                XtraMessageBox.Show("Debe asignarle un correo.");
                txtCorreo.Focus();
                return false;
            }

            if (lueEmpresa.EditValue == null)
            {
                XtraMessageBox.Show("Debe asignarle una empresa.");
                lueEmpresa.Focus();
                return false;
            }
            return true;

        }
    }
}
