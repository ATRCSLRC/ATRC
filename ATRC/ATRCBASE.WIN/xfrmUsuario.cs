using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Nodes;
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
                if (chkAccesoSistema.Checked & !string.IsNullOrEmpty(txtContraseña.Text))
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
            
        }

        private void txtConfContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(txtConfContraseña.Text))
                lciComparaContraseña.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciComparaContraseña.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void bbiMapa_Click(object sender, EventArgs e)
        {
            xfrmMapa xfrm = new xfrmMapa();
            xfrm.Longitud = Usuario.Longitud;
            xfrm.Latitud = Usuario.Latitud;
            xfrm.ShowDialog();
            if (xfrm.Guardar)
            {
                Usuario.Longitud = xfrm.Longitud;
                Usuario.Latitud = xfrm.Latitud;
                txtDomicilio.Text = Usuario.Latitud.ToString() + ", "+ Usuario.Longitud.ToString();
            }
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
            txtCURP.DataBindings.Add("EditValue", Usuario, "CURP", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRFC.DataBindings.Add("EditValue", Usuario, "RFC", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIMSS.DataBindings.Add("EditValue", Usuario, "IMSS", true, DataSourceUpdateMode.OnPropertyChanged);
            luePuesto.DataBindings.Add("EditValue", Usuario, "Puesto!", true, DataSourceUpdateMode.OnPropertyChanged);
            lueDepartamento.DataBindings.Add("EditValue", Usuario, "Departamento!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNumCredencial.DataBindings.Add("EditValue", Usuario, "IDCard", true, DataSourceUpdateMode.OnPropertyChanged);
            chkEsAdministrativo.DataBindings.Add("EditValue", Usuario, "EsAdministrativo", true, DataSourceUpdateMode.OnPropertyChanged);
            chkAccesoSistema.DataBindings.Add("EditValue", Usuario, "AccesoSistema", true, DataSourceUpdateMode.OnPropertyChanged);
            dteIngreso.DataBindings.Add("EditValue", Usuario, "FechaIngreso", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbPatron.DataBindings.Add("EditValue", Usuario, "Patron", true, DataSourceUpdateMode.OnPropertyChanged);
            //cmbClasificacion.DataBindings.Add("EditValue", Usuario, "Clasificacion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAvisar.DataBindings.Add("EditValue", Usuario, "AvisarA", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipoSangre.DataBindings.Add("EditValue", Usuario, "TipoSangre", true, DataSourceUpdateMode.OnPropertyChanged);
            //checkedComboBoxEdit1.DataBindings.Add("EditValue", Usuario , "Modulos", true, DataSourceUpdateMode.OnPropertyChanged);
            txtContraseña.Text = txtConfContraseña.Text = Usuario.ConstraseñaDesencriptada;
            txtDomicilio.Text = Usuario.Latitud.ToString() + ", "+ Usuario.Longitud.ToString();
            //, new NullOperator("PermisoPadre")
            //XPCollection<Permiso> Permisos = new XPCollection<Permiso>(Unidad);
            XPView Permisos = new XPView(Unidad, typeof(Permiso), "Oid;Nombre;PermisoPadre", null);
            trModulos.DataSource = Permisos;

            if(Usuario.Bajas.Count > 0)
            {
                TabRenuncias.PageVisible = true;
                grdRenuncias.DataSource = Usuario.Bajas;
            }

            //
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
            chkAccesoSistema.DataBindings.Clear();
        }
        
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe asignarle un nombre.");
                return false;
            }
            if (chkAccesoSistema.Checked)
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

        private void treeList1_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (e.State == CheckState.Checked)
            {
                e.Node.CheckAll();
                ModificacionesPermisos(e.Node, true);
            }
            else
            {
                e.Node.UncheckAll();
                ModificacionesPermisos(e.Node, false);
            } 
        }

        private void treeList1_NodeChanged(object sender, DevExpress.XtraTreeList.NodeChangedEventArgs e)
        {
            
        }

        private void treeList1_Load(object sender, EventArgs e)
        {
            //treeList1.SetNodeCheckState(treeList1.FindNodeByKeyID(1), CheckState.Checked);
            foreach (Permiso Permiso in Usuario.Permisos)
            {
                trModulos.SetNodeCheckState(trModulos.FindNodeByKeyID(Permiso.Oid), CheckState.Checked);
            }
            //    treeList1.SetNodeCheckState(treeList1.FindNodeByKeyID(Permiso.Oid), CheckState.Checked);
        }

        private void ModificacionesPermisos(TreeListNode Nodo, bool Agregar)
        {
            if (Agregar)
            {
                int ID = Convert.ToInt32(Nodo.GetValue(trModulos.KeyFieldName));
                Permiso Permiso = Unidad.GetObjectByKey<Permiso>(ID);
                Usuario.Permisos.Add(Permiso);

                foreach (TreeListNode mNodo in Nodo.Nodes)
                {
                    ModificacionesPermisos(mNodo, true);
                }
            }else
            {
                int ID = Convert.ToInt32(Nodo.GetValue(trModulos.KeyFieldName));
                Permiso Permiso = Unidad.GetObjectByKey<Permiso>(ID);
                Usuario.Permisos.Remove(Permiso);

                foreach (TreeListNode mNodo in Nodo.Nodes)
                {
                    ModificacionesPermisos(mNodo, false);
                }
            }
        }

        private void chkAccesoSistema_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccesoSistema.Checked)
                TabSeguridad.PageVisible = true;
            else
                TabSeguridad.PageVisible = false;
        }
    }
}
