using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using ALMACEN.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ALMACEN.WIN
{
    public partial class xfrmModificarArticulo : xfrmBase
    {
        public xfrmModificarArticulo()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        Articulo Articulo;
        private void xfrmModificarArticulo_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Utilerias.CargarLookupEdit(lueProveedor, typeof(Proveedor), Unidad, "Nombre", "Nombre", false);
            Utilerias.CargarLookupEdit(lueMarca, typeof(Marcas), Unidad, "Nombre", "Nombre", false);
            rgOpciones.Properties.Items.AddEnum(typeof(Enums.TipoArticulo));
            DesligarControles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", txtCodigo.Text));
            if (Articulo != null)
            {
                LigarControles();
            }
            else
            {
                XtraMessageBox.Show("No se encuentra el artículo.");
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", txtCodigo.Text));
                if (Articulo != null)
                {
                    LigarControles();

                }
                else
                {
                    XtraMessageBox.Show("No se encuentra el artículo.");
                }
            }
        }

        #region

        private void LigarControles()
        {
            txtNombre.Focus();
            txtCodigo.Text = string.Empty;
            txtNombre.DataBindings.Add("EditValue", Articulo, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            rgOpciones.DataBindings.Add("EditValue", Articulo, "TipoArticulo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigoEditar.DataBindings.Add("EditValue", Articulo, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            dteFecha.DataBindings.Add("EditValue", Articulo.Facturas, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFactura.DataBindings.Add("EditValue", Articulo.Facturas, "NumFactura", true, DataSourceUpdateMode.OnPropertyChanged);
            spnCantidad.DataBindings.Add("EditValue", Articulo.Facturas, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTipoMedida.DataBindings.Add("EditValue", Articulo.Facturas, "TipoMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            spnPrecio.DataBindings.Add("EditValue", Articulo.Facturas, "Precio", true, DataSourceUpdateMode.OnPropertyChanged);
            spnAlmacen.DataBindings.Add("EditValue", Articulo.Facturas, "Almacen", true, DataSourceUpdateMode.OnPropertyChanged);
            lueProveedor.DataBindings.Add("EditValue", Articulo.Facturas, "Proveedor!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtParte.DataBindings.Add("EditValue", Articulo.Facturas, "NumParte", true, DataSourceUpdateMode.OnPropertyChanged);
            lueMarca.DataBindings.Add("EditValue", Articulo.Facturas, "Marca!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMedida.DataBindings.Add("EditValue", Articulo.Facturas, "Medida", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSerie.DataBindings.Add("EditValue", Articulo.Facturas, "Serie", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipo.DataBindings.Add("EditValue", Articulo.Facturas, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            dlcFacturas.DataSource = dnFacturas.DataSource = Articulo.Facturas;

            txtNombre.ReadOnly = false;
            rgOpciones.ReadOnly = false;
            txtCodigoEditar.ReadOnly = false;
            dteFecha.ReadOnly = false;
            txtFactura.ReadOnly = false;
            spnCantidad.ReadOnly = false;
            cboTipoMedida.ReadOnly = false;
            spnPrecio.ReadOnly = false;
            spnAlmacen.ReadOnly = false;
            lueProveedor.ReadOnly = false;
            txtParte.ReadOnly = false;
            lueMarca.ReadOnly = false;
            txtMedida.ReadOnly = false;
            txtSerie.ReadOnly = false;
            txtTipo.ReadOnly = false;
            rpAcciones.Visible = true;
            lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciBoton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

        }

        private void DesligarControles()
        {
            
            txtNombre.DataBindings.Clear();
            rgOpciones.DataBindings.Clear();
            txtCodigoEditar.DataBindings.Clear();
            dteFecha.DataBindings.Clear();
            txtFactura.DataBindings.Clear();
            spnCantidad.DataBindings.Clear();
            cboTipoMedida.DataBindings.Clear();
            spnPrecio.DataBindings.Clear();
            spnAlmacen.DataBindings.Clear();
            lueProveedor.DataBindings.Clear();
            txtParte.DataBindings.Clear();
            lueMarca.DataBindings.Clear();
            txtMedida.DataBindings.Clear();
            txtSerie.DataBindings.Clear();
            txtTipo.DataBindings.Clear();

            txtNombre.Text = string.Empty;
            rgOpciones.SelectedIndex = 0;
            txtCodigoEditar.Text = string.Empty;
            dteFecha.EditValue = null;
            txtFactura.Text = string.Empty;
            spnCantidad.EditValue = 0;
            cboTipoMedida.SelectedIndex = -1;
            spnPrecio.EditValue = 0;
            spnAlmacen.EditValue = 0;
            txtParte.Text = string.Empty;
            txtMedida.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtTipo.Text = string.Empty;
            lueMarca.EditValue = false;
            lueProveedor.EditValue = false;
            dlcFacturas.DataSource = dnFacturas.DataSource = null;
            Articulo = null;
            lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lciBoton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            txtNombre.ReadOnly = true;
            rgOpciones.ReadOnly = true;
            txtCodigoEditar.ReadOnly = true;
            dteFecha.ReadOnly = true;
            txtFactura.ReadOnly = true;
            spnCantidad.ReadOnly = true;
            cboTipoMedida.ReadOnly = true;
            spnPrecio.ReadOnly = true;
            spnAlmacen.ReadOnly = true;
            lueProveedor.ReadOnly = true;
            txtParte.ReadOnly = true;
            lueMarca.ReadOnly = true;
            txtMedida.ReadOnly = true;
            txtSerie.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtCodigo.Focus();
        }

        #endregion

        private void rgOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            if (rg != null)
            {
                Enums.TipoArticulo Articulo = (Enums.TipoArticulo)rg.EditValue;
                txtTipo.Text = string.Empty;
                txtSerie.Text = string.Empty;
                txtMedida.Text = string.Empty;
                switch (Articulo)
                {
                    case Enums.TipoArticulo.General:
                        lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciMedida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciSerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case Enums.TipoArticulo.Herramienta:
                        lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciMedida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciSerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case Enums.TipoArticulo.Baterias:
                        lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lciMedida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciSerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        break;
                    case Enums.TipoArticulo.Llantas:
                        lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciMedida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lciSerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        break;
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DesligarControles();
            rpAcciones.Visible = false;
            txtCodigo.Focus();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Articulo.Save();
                Unidad.CommitChanges();
                rpAcciones.Visible = false;
                DesligarControles();
                XtraMessageBox.Show("Se guardaron los cambios correctamente.");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                XtraMessageBox.Show("Debe ingresar un código.");
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe ingresar el nombre del artículo.");
                txtNombre.Focus();
                return false;
            }

            return true;
        }
    }
}
