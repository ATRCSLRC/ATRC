using ALMACEN.BL;
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
            }
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); })); //IniciarControles();
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
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Factura factura = new Factura(Unidad);
                    factura.Almacen = Convert.ToInt32(spnAlmacen.Value);
                    factura.Cantidad = Convert.ToInt32(spnCantidad.Value);
                    factura.Fecha = dteFechaEntrega.DateTime;
                    factura.Marca = (Marcas)lueMarca.EditValue;
                    factura.Medida = txtMedida.Text;
                    factura.NumFactura = txtFactura.Text;
                    factura.NumParte = txtParte.Text;
                    factura.Precio = Convert.ToInt32(spnPrecio.Value);
                    factura.Proveedor = (Proveedor)lueProveedor.EditValue;
                    factura.Serie = txtSerie.Text;
                    factura.Tipo = txtTipo.Text;
                    factura.TipoMedida = (Enums.TipoMedida)cboTipoMedida.EditValue;
                    factura.Save();

                    if (Articulo != null)
                    {
                        Articulo.Facturas.Add(factura);
                    }
                    else
                    {
                        Articulo = new Articulo(Unidad);
                        Articulo.Nombre = txtNombre.Text;
                        Articulo.Codigo = txtCodigo.Text;
                        Articulo.TipoArticulo = (Enums.TipoArticulo)rgOpciones.EditValue;
                        Articulo.Facturas.Add(factura);
                    }
                    Articulo.Save();
                    Unidad.CommitChanges();
                    LimpiarControles();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarControles();
        }

        #endregion

        #region metodos

        private void IniciarControles()
        {
            txtCodigo.Focus();
            cboTipoMedida.Properties.Items.AddRange(typeof(Enums.TipoMedida).GetEnumValues());
            rgOpciones.Properties.Items.AddEnum(typeof(Enums.TipoArticulo));
            dteFechaEntrega.DateTime = DateTime.Now;
            Utilerias.CargarLookupEdit(lueProveedor, typeof(Proveedor), Unidad, "Nombre", "Nombre", false);
            Utilerias.CargarLookupEdit(lueMarca, typeof(Marcas), Unidad, "Nombre", "Nombre", false);
            rgOpciones.SelectedIndex = 0;
        }
        
        private void LimpiarControles()
        {
            Articulo = null;
            rgOpciones.SelectedIndex = 0;
            dteFechaEntrega.DateTime = DateTime.Now;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            spnAlmacen.Value = 0;
            spnCantidad.Value = 0;
            spnPrecio.Value = 0;
            cboTipoMedida.SelectedIndex = 0;
            lueMarca.EditValue = null;
            lueProveedor.EditValue = null;
            txtFactura.Text = string.Empty;
            txtMedida.Text = string.Empty;
            txtParte.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtCodigo.Focus();
            
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

            if (spnPrecio.Value <= 0)
            {
                XtraMessageBox.Show("Debe ingresar un precio.");
                spnCantidad.Focus();
                return false;
            }

            if (lueProveedor.EditValue == null)
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

            if (lueMarca.EditValue == null)
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

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", txtCodigo.Text));
                if (Articulo != null)
                {
                    txtNombre.Text = Articulo.Nombre;
                    rgOpciones.EditValue = Articulo.TipoArticulo;
                    txtNombre.ReadOnly = true;
                    rgOpciones.ReadOnly = true;
                    spnCantidad.Focus();
                }
                else
                {
                    Articulo = null;
                    txtNombre.ReadOnly = false;
                    rgOpciones.ReadOnly = false;
                    txtNombre.Text = string.Empty;
                    rgOpciones.SelectedIndex = 0;
                    txtNombre.Focus();
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", txtCodigo.Text));
                if (Articulo != null)
                {
                    txtNombre.Text = Articulo.Nombre;
                    rgOpciones.EditValue = Articulo.TipoArticulo;
                    txtNombre.ReadOnly = true;
                    rgOpciones.ReadOnly = true;
                    spnCantidad.Focus();
                }
                else
                {
                    Articulo = null;
                    txtNombre.ReadOnly = false;
                    rgOpciones.ReadOnly = false;
                    txtNombre.Text = string.Empty;
                    rgOpciones.SelectedIndex = 0;
                    txtNombre.Focus();
                }
            }
        }
    }
}
