using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmUsuario : xfrmBase
    {
        public xfrmUsuario()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Usuario Usuario;
        public bool EsNuevo;

        #region Eventos

        private void xfrmUsuario_Load(object sender, EventArgs e)
        {
            Utilerias.CargarLookupEdit(lueDepartamento, typeof(Departamento), Unidad, "Descripcion", "Descripcion", false);
            Utilerias.CargarLookupEdit(luePuesto, typeof(Puesto), Unidad, "Descripcion", "Descripcion", false);
            
            LigarControles();
            
            if (EsNuevo)
                txtNumeroEmpleado.Text = Utilerias.NumEmpleado(Unidad);

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (chkEsAdministrativo.Checked & !string.IsNullOrEmpty(txtContraseña.Text))
                    Usuario.Constraseña = txtContraseña.Text;
                Usuario.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiSeleccionar_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream Archivo = new System.IO.FileStream(ofdFoto.FileName, FileMode.Open, FileAccess.Read);
                    MemoryStream streampdf = new MemoryStream();
                    Archivo.CopyTo(streampdf);
                    Archivo.Dispose();
                    peFoto.EditValue = streampdf.ToArray();
                    if (Usuario.Imagen != null)
                    {
                        Usuario.Imagen.Archivo = Convert.ToBase64String(streampdf.ToArray());
                        Usuario.Imagen.Nombre = ofdFoto.FileName;
                    }
                    else
                    {
                        Imagen img = new Imagen(Unidad);
                        img.Archivo = Convert.ToBase64String(streampdf.ToArray());
                        img.Descripcion = ofdFoto.FileName;
                        Usuario.Imagen = img;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void bbiCamara_Click(object sender, EventArgs e)
        {
            TakePictureDialog Camera = new TakePictureDialog();
            if (Camera.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    Camera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    peFoto.Image = Camera.Image;
                    if (Usuario.Imagen != null)
                    {
                        Usuario.Imagen.Archivo = Convert.ToBase64String(ms.ToArray());
                        Usuario.Imagen.Nombre = string.Empty;
                    }
                    else
                    {
                        Imagen img = new Imagen(Unidad);
                        img.Archivo = Convert.ToBase64String(ms.ToArray());
                        img.Descripcion = string.Empty;
                        Usuario.Imagen = img;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void bbiCancelarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                ATRCBASE.WIN.Properties.Resources.usuario_desconocido.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                peFoto.EditValue = ATRCBASE.WIN.Properties.Resources.usuario_desconocido;
                if (Usuario.Imagen != null)
                {
                    Usuario.Imagen.Archivo = Convert.ToBase64String(ms.ToArray());
                    Usuario.Imagen.Nombre = string.Empty;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void chkEsAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEsAdministrativo.Checked)
                TabSeguridad.PageVisible = true;
            else
                TabSeguridad.PageVisible = false;
        }

        private void txtConfContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(txtConfContraseña.Text))
                lciComparaContraseña.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciComparaContraseña.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        #endregion

        #region Metodos
        private void LigarControles()
        {
            if (Usuario.Imagen != null)
            {
                if (!string.IsNullOrEmpty(Usuario.Imagen.Archivo))
                {
                    byte[] image = Convert.FromBase64String(Usuario.Imagen.Archivo);
                    MemoryStream stream = new MemoryStream(image);
                    Image returnImage = Image.FromStream(stream);
                    peFoto.EditValue = stream.ToArray();
                }
            }
            else
            {
                Imagen img = new Imagen(Unidad);
                Usuario.Imagen = img;
            }

            peFoto.Properties.ContextMenu = new ContextMenu();
            txtNumeroEmpleado.DataBindings.Add("EditValue", Usuario, "NumEmpleado", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTel.DataBindings.Add("EditValue", Usuario, "TelAvisarA", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("EditValue", Usuario, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRFC.DataBindings.Add("EditValue", Usuario, "RFC", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIMSS.DataBindings.Add("EditValue", Usuario, "IMSS", true, DataSourceUpdateMode.OnPropertyChanged);
            luePuesto.DataBindings.Add("EditValue", Usuario, "Puesto!", true, DataSourceUpdateMode.OnPropertyChanged);
            lueDepartamento.DataBindings.Add("EditValue", Usuario, "Departamento!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNumCredencial.DataBindings.Add("EditValue", Usuario, "IDCard", true, DataSourceUpdateMode.OnPropertyChanged);
            chkEsAdministrativo.DataBindings.Add("EditValue", Usuario, "EsAdministrativo", true, DataSourceUpdateMode.OnPropertyChanged);
            dteIngreso.DataBindings.Add("EditValue", Usuario, "FechaIngreso", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbPatron.DataBindings.Add("EditValue", Usuario, "Patron", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAvisar.DataBindings.Add("EditValue", Usuario, "AvisarA", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipoSangre.DataBindings.Add("EditValue", Usuario, "TipoSangre", true, DataSourceUpdateMode.OnPropertyChanged);
            checkedComboBoxEdit1.DataBindings.Add("EditValue", Usuario , "Modulos", true, DataSourceUpdateMode.OnPropertyChanged);
            txtContraseña.Text = txtConfContraseña.Text = Usuario.ConstraseñaDesencriptada;
        }

        private void Desligar()
        {
            txtNumeroEmpleado.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtRFC.DataBindings.Clear();
            txtIMSS.DataBindings.Clear();
            luePuesto.DataBindings.Clear();
            lueDepartamento.DataBindings.Clear();
            txtNumCredencial.DataBindings.Clear();
            chkEsAdministrativo.DataBindings.Clear();
        }
        
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe asignarle un nombre.");
                return false;
            }
            if (chkEsAdministrativo.Checked)
            {
                if (string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfContraseña.Text))
                {
                    XtraMessageBox.Show("Debe asignarle una contraseña.");
                    return false;
                }
                if (!txtContraseña.Text.Equals(txtConfContraseña.Text))
                {
                    XtraMessageBox.Show("Las contraseñas asignadas no coinciden.");
                    return false;
                }
            }
            return true;

        }

        #endregion
 
    }
}
