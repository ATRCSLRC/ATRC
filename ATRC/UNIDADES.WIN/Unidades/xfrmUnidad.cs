using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN
{
    public partial class xfrmUnidad : xfrmBase
    {
        public xfrmUnidad()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Unidad UnidadCamion;
        public bool esModificacion = false;
        #region Eventos
        private void xfrmUnidad_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UnidadCamion = new Unidad(Unidad);
            }
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); }));
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(btnNumeroUsuario.Text))
                    {
                        
                        Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnNumeroUsuario.Text)));
                        if (Usuario != null)
                        {
                            UnidadCamion.Usuario = Usuario;
                        }
                    }
                    Extintores extintor = Unidad.GetObjectByKey<Extintores>(lueExtintor.EditValue);
                    if (extintor != null)
                    {
                        UnidadCamion.Extintor = extintor;
                        UnidadCamion.Extintor.UbicacionExtintor = Enums.UbicacionExtintor.Unidad;
                        UnidadCamion.Extintor.Oficina = string.Empty;
                    }
                    UnidadCamion.Save();
                    Unidad.CommitChanges();
                    if(!esModificacion)
                        XtraMessageBox.Show("Se agrego la unidad correctamente.");
                    else
                        XtraMessageBox.Show("Se modifico la unidad correctamente.");
                    this.Close();
                }
            }

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DesligarControles();
            this.Close();
        }
        
        private void txtColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tcUnidad.SelectedTabPage = TabInterior;
                txtMotor.Focus();
            }
        }

        private void rgAireAcondicionado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tcUnidad.SelectedTabPage = TabExterior;
                btnNumeroUsuario.Focus();
            }
        }

        private void rgRadio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tcUnidad.SelectedTabPage = TabFiltros;
                txtFiltroAceiteMotor.Focus();
            }
        }

        private void txtFiltroAgua_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tcUnidad.SelectedTabPage = TabFoto;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream Archivo = new System.IO.FileStream(OpenFile.FileName, FileMode.Open, FileAccess.Read);
                    MemoryStream streampdf = new MemoryStream();
                    Archivo.CopyTo(streampdf);
                    
                    if (Archivo.Length < 1000000)
                    {
                        picFoto.EditValue = streampdf.ToArray();
                        if (UnidadCamion.Imagen != null)
                        {
                            UnidadCamion.Imagen.Archivo = Convert.ToBase64String(streampdf.ToArray());
                            UnidadCamion.Imagen.Nombre = OpenFile.FileName;
                        }
                        else
                        {
                            Imagen img = new Imagen(Unidad);
                            img.Archivo = Convert.ToBase64String(streampdf.ToArray());
                            img.Descripcion = OpenFile.FileName;
                            UnidadCamion.Imagen = img;
                        }
                    }else
                    {
                        XtraMessageBox.Show("Archivo muy grande. Se debe de adjuntar imagen menor de 1MB.");
                    }
                    Archivo.Dispose();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                UNIDADES.WIN.Properties.Resources.car.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                if (UnidadCamion.Imagen != null)
                {
                    UnidadCamion.Imagen.Archivo = Convert.ToBase64String(ms.ToArray());
                    UnidadCamion.Imagen.Nombre = string.Empty;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnNumeroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnNumeroUsuario.Text))
                {
                    Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnNumeroUsuario.Text)));
                    if (Usuario != null)
                    {
                        txtNombreUsuario.Text = Usuario.Nombre;
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
        }

        private void btnNumeroUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnNumeroUsuario.Text))
            {
                Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnNumeroUsuario.Text)));
                if (Usuario != null)
                {
                    txtNombreUsuario.Text = Usuario.Nombre;
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

        private void btnNumeroUsuario_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", xfrm.IDUsuario));
                if (Usuario != null)
                {
                    txtNombreUsuario.Text = Usuario.Nombre;
                    btnNumeroUsuario.Text = Usuario.NumEmpleado.ToString();
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombreUsuario.Text = btnNumeroUsuario.Text = string.Empty;
                }
            }
            else
            {
                txtNombreUsuario.Text = btnNumeroUsuario.Text = string.Empty;
            }
        }
        #endregion

        #region Metodos
        private void IniciarControles()
        {
            txtNombre.Focus();
            rgTipoUnidad.Properties.Items.AddEnum(typeof(Enums.TipoUnidad));
            rgTransmision.Properties.Items.AddEnum(typeof(Enums.Transmision));
            rgCombustible.Properties.Items.AddEnum(typeof(Enums.Combustible));
            rgFrenos.Properties.Items.AddEnum(typeof(Enums.Frenos));
            rgSuspencion.Properties.Items.AddEnum(typeof(Enums.Suspencion));
            rgPuertas.Properties.Items.AddEnum(typeof(Enums.Puerta));
            picFoto.Properties.ContextMenu = new ContextMenu();
            XPView Extintores = new XPView(Unidad, typeof(Extintores));
            Extintores.Properties.AddRange(new ViewProperty[] {
                      new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                      new ViewProperty("Nombre", SortDirection.None, "[NumExtintor]", false, true),
                      new ViewProperty("Ubicacion", SortDirection.None, "iif([Unidad] is null, [Oficina], [Unidad.Nombre])", false, true)
                     });
            lueExtintor.Properties.DataSource = Extintores;

        }
        private void LigarControles()
        {
            if (UnidadCamion.Imagen != null)
            {
                if (!string.IsNullOrEmpty(UnidadCamion.Imagen.Archivo))
                {
                    byte[] image = Convert.FromBase64String(UnidadCamion.Imagen.Archivo);
                    MemoryStream stream = new MemoryStream(image);
                    Image returnImage = Image.FromStream(stream);
                    picFoto.EditValue = stream.ToArray();
                }
            }
            else
            {
                Imagen img = new Imagen(Unidad);
                UnidadCamion.Imagen = img;
            }
            chkEsRenta.DataBindings.Add("Checked", UnidadCamion, "EsRenta", true, DataSourceUpdateMode.OnPropertyChanged);
            #region General
            txtNombre.DataBindings.Add("EditValue", UnidadCamion, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMarca.DataBindings.Add("EditValue", UnidadCamion, "Marca", true, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("EditValue", UnidadCamion, "Modelo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVIN.DataBindings.Add("EditValue", UnidadCamion, "VIN", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPlacas.DataBindings.Add("EditValue", UnidadCamion, "Placas", true, DataSourceUpdateMode.OnPropertyChanged);
            txtColor.DataBindings.Add("EditValue", UnidadCamion, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            spnPasajeros.DataBindings.Add("EditValue", UnidadCamion, "Pasajeros", true, DataSourceUpdateMode.OnPropertyChanged);
            rgTipoUnidad.DataBindings.Add("EditValue", UnidadCamion, "TipoUnidad", true, DataSourceUpdateMode.OnPropertyChanged);
            dteUltimoCambioAceite.DataBindings.Add("EditValue", UnidadCamion, "UltimoCambioAceite", true, DataSourceUpdateMode.OnPropertyChanged);
            if(!esModificacion)
                dteUltimoCambioAceite.DateTime = DateTime.Now;
            #endregion

            #region Interior
            txtMotor.DataBindings.Add("EditValue", UnidadCamion, "Motor", true, DataSourceUpdateMode.OnPropertyChanged);
            spnCilindros.DataBindings.Add("EditValue", UnidadCamion, "Cilindros", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMillas.DataBindings.Add("EditValue", UnidadCamion, "Millas", true, DataSourceUpdateMode.OnPropertyChanged);
            rgTransmision.DataBindings.Add("EditValue", UnidadCamion, "Transmision", true, DataSourceUpdateMode.OnPropertyChanged);
            rgCombustible.DataBindings.Add("EditValue", UnidadCamion, "Combustible", true, DataSourceUpdateMode.OnPropertyChanged);
            rgFrenos.DataBindings.Add("EditValue", UnidadCamion, "Frenos", true, DataSourceUpdateMode.OnPropertyChanged);
            rgSuspencion.DataBindings.Add("EditValue", UnidadCamion, "Suspencion", true, DataSourceUpdateMode.OnPropertyChanged);
            rgPuertas.DataBindings.Add("EditValue", UnidadCamion, "Puerta", true, DataSourceUpdateMode.OnPropertyChanged);
            rgAireAcondicionado.DataBindings.Add("EditValue", UnidadCamion, "AireAcondicionado", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            #region Exterior

            
            spnAsientos.DataBindings.Add("EditValue", UnidadCamion, "Asientos", true, DataSourceUpdateMode.OnPropertyChanged);
            spnAbanicos.DataBindings.Add("EditValue", UnidadCamion, "Abanicos", true, DataSourceUpdateMode.OnPropertyChanged);
            spnVentanas.DataBindings.Add("EditValue", UnidadCamion, "VentanasLaterales", true, DataSourceUpdateMode.OnPropertyChanged);
            rgEstereo.DataBindings.Add("EditValue", UnidadCamion, "TieneEstereo", true, DataSourceUpdateMode.OnPropertyChanged);
            rgBocinas.DataBindings.Add("EditValue", UnidadCamion, "TieneBocinas", true, DataSourceUpdateMode.OnPropertyChanged);
            rgCamaras.DataBindings.Add("EditValue", UnidadCamion, "TieneCamaras", true, DataSourceUpdateMode.OnPropertyChanged);
            lueExtintor.EditValue = UnidadCamion.Extintor == null ? -1 : UnidadCamion.Extintor.Oid;
            rgTrancas.DataBindings.Add("EditValue", UnidadCamion, "TieneTrancas", true, DataSourceUpdateMode.OnPropertyChanged);
            rgRadio.DataBindings.Add("EditValue", UnidadCamion, "TieneRadio", true, DataSourceUpdateMode.OnPropertyChanged);
            tknBaterias.DataBindings.Add("EditValue", UnidadCamion, "Baterias", true, DataSourceUpdateMode.OnPropertyChanged);
            btnNumeroUsuario.Text = UnidadCamion.Usuario != null ? UnidadCamion.Usuario.NumEmpleado.ToString() : "";
            txtNombreUsuario.Text = UnidadCamion.Usuario != null ? UnidadCamion.Usuario.Nombre : "";
            #endregion

            #region Filtros
            txtFiltroAceiteMotor.DataBindings.Add("EditValue", UnidadCamion, "FiltroAceiteMotor", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFiltroAceiteTransmision.DataBindings.Add("EditValue", UnidadCamion, "FiltroAceiteTransmision", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCombustible.DataBindings.Add("EditValue", UnidadCamion, "FiltroCombustible", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFiltroAire.DataBindings.Add("EditValue", UnidadCamion, "FiltroAire", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFiltroAgua.DataBindings.Add("EditValue", UnidadCamion, "FiltroAgua", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe de agregar un nombre a la unidad.");
                txtNombre.Focus();
                return false;
            }
            return true;
        }
        private void DesligarControles()
        {
            chkEsRenta.DataBindings.Clear();

            #region General
            txtNombre.DataBindings.Clear();
            txtMarca.DataBindings.Clear();
            txtModelo.DataBindings.Clear();
            txtVIN.DataBindings.Clear();
            txtPlacas.DataBindings.Clear();
            txtColor.DataBindings.Clear();
            #endregion

            #region Interior
            txtMotor.DataBindings.Clear();
            spnCilindros.DataBindings.Clear();
            txtMillas.DataBindings.Clear();
            rgTransmision.DataBindings.Clear();
            rgCombustible.DataBindings.Clear();
            rgFrenos.DataBindings.Clear();
            rgSuspencion.DataBindings.Clear();
            rgPuertas.DataBindings.Clear();
            rgAireAcondicionado.DataBindings.Clear();
            #endregion

            #region Exterior
            spnAsientos.DataBindings.Clear();
            spnAbanicos.DataBindings.Clear();
            spnVentanas.DataBindings.Clear();
            rgEstereo.DataBindings.Clear();
            rgBocinas.DataBindings.Clear();
            rgCamaras.DataBindings.Clear();
            rgTrancas.DataBindings.Clear();
            rgRadio.DataBindings.Clear();
            #endregion

            #region General
            txtFiltroAceiteMotor.DataBindings.Clear();
            txtFiltroAceiteTransmision.DataBindings.Clear();
            txtCombustible.DataBindings.Clear();
            txtFiltroAire.DataBindings.Clear();
            txtFiltroAgua.DataBindings.Clear();
            #endregion
        }
        #endregion

        private void tknBaterias_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = true;
        }
    }
}
