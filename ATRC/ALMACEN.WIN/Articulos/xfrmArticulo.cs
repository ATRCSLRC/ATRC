using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALMACEN.WIN
{
    public partial class xfrmArticulo : xfrmBase
    {
        public xfrmArticulo()
        {
            InitializeComponent();
        }

        public Articulo Articulo;
        public UnidadDeTrabajo Unidad;

        #region Eventos

        private void xfrmArticulo_Load(object sender, EventArgs e)
        {
            
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Articulo = new Articulo(Unidad);
            }
            LigarControles();
            
        }

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

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Articulo.Save();
                Unidad.CommitChanges();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region metodos
        private void LigarControles()
        {

            cboTipoMedida.Properties.Items.AddRange(typeof(Enums.TipoMedida).GetEnumValues());
            rgOpciones.Properties.Items.AddEnum(typeof(Enums.TipoArticulo));

            Utilerias.CargarLookupEdit(lueProveedor, typeof(Proveedor), Unidad, "Nombre", "Nombre", false);
            Utilerias.CargarLookupEdit(lueMarca, typeof(Marcas), Unidad, "Nombre", "Nombre", false);

            rgOpciones.DataBindings.Add("EditValue", Articulo, "TipoArticulo", true, DataSourceUpdateMode.OnPropertyChanged);
            dteFechaEntrega.DataBindings.Add("EditValue", Articulo, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigo.DataBindings.Add("EditValue", Articulo, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("EditValue", Articulo, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            spnCantidad.DataBindings.Add("EditValue", Articulo, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTipoMedida.DataBindings.Add("EditValue", Articulo, "TipoMedida", true, DataSourceUpdateMode.OnPropertyChanged);
            spnPrecio.DataBindings.Add("EditValue", Articulo, "Precio", true, DataSourceUpdateMode.OnPropertyChanged);
            lueProveedor.DataBindings.Add("EditValue", Articulo, "Proveedor!", true, DataSourceUpdateMode.OnPropertyChanged);
            spnAlmacen.DataBindings.Add("EditValue", Articulo, "Almacen", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipo.DataBindings.Add("EditValue", Articulo, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSerie.DataBindings.Add("EditValue", Articulo, "Serie", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFactura.DataBindings.Add("EditValue", Articulo, "NumFactura", true, DataSourceUpdateMode.OnPropertyChanged);
            txtParte.DataBindings.Add("EditValue", Articulo, "NumParte", true, DataSourceUpdateMode.OnPropertyChanged);
            lueMarca.DataBindings.Add("EditValue", Articulo, "Marca!", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMedida.DataBindings.Add("EditValue", Articulo, "Medida", true, DataSourceUpdateMode.OnPropertyChanged);
            if (Articulo.Fecha == DateTime.MinValue)
                dteFechaEntrega.DateTime = DateTime.Now;
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

            if (spnCantidad.Value <= 0)
            {
                XtraMessageBox.Show("Debe ingresar una cantidad.");
                spnCantidad.Focus();
                return false;
            }

            if (cboTipoMedida.SelectedIndex == 0)
            {
                XtraMessageBox.Show("Debe sleccionar un tipo de medida.");
                cboTipoMedida.Focus();
                return false;
            }

            if (spnPrecio.Value <= 0)
            {
                XtraMessageBox.Show("Debe ingresar un precio.");
                spnCantidad.Focus();
                return false;
            }

            if (lueProveedor.EditValue != null)
            {
                XtraMessageBox.Show("Debe selccionar un proveedor.");
                lueProveedor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFactura.Text))
            {
                XtraMessageBox.Show("Debe ingresar una factura.");
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtParte.Text))
            {
                XtraMessageBox.Show("Debe ingresar el número de parte.");
                txtNombre.Focus();
                return false;
            }

            if (lueMarca.EditValue != null)
            {
                XtraMessageBox.Show("Debe selccionar una marca.");
                lueProveedor.Focus();
                return false;
            }

            Enums.TipoArticulo Articulo = (Enums.TipoArticulo)rgOpciones.EditValue;
            switch (Articulo)
            {
                
                case Enums.TipoArticulo.Baterias:
                    if(string.IsNullOrEmpty(txtTipo.Text))
                    {
                        XtraMessageBox.Show("Debe ingresar el tipo.");
                        txtTipo.Focus();
                        return false;
                    }

                    if (string.IsNullOrEmpty(txtSerie.Text))
                    {
                        XtraMessageBox.Show("Debe ingresar una serie.");
                        txtSerie.Focus();
                        return false;
                    }
                    break;
                case Enums.TipoArticulo.Llantas:
                    if (string.IsNullOrEmpty(txtMedida.Text))
                    {
                        XtraMessageBox.Show("Debe ingresar una medida.");
                        txtMedida.Focus();
                        return false;
                    }
                    break;
            }
            return true;
        }
        #endregion
    }
}
