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
    public partial class xfrmBusquedaArticulos : xfrmBase
    {
        public xfrmBusquedaArticulos()
        {
            InitializeComponent();
        }
        XPView Articulos;
        public UnidadDeTrabajo Unidad;
        public InventarioArticulo Inventario;
        public bool Asignar;
        public string Codigo = "";
        #region Eventos
        private void xfrmBusquedaArticulos_Load(object sender, EventArgs e)
        {
            if(Unidad == null)
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Articulos = new XPView(Unidad, typeof(Factura));

            Articulos.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
            new ViewProperty("NumParte", SortDirection.None, "[NumParte]", false, true),
            new ViewProperty("Codigo", SortDirection.None, "[Articulo.Codigo]", false, true),
            new ViewProperty("Articulo", SortDirection.None, "[Articulo.Oid]", false, true),
            new ViewProperty("Nombre", SortDirection.None, "[Articulo.Nombre]", false, true),
            new ViewProperty("Cantidad", SortDirection.None, "[Cantidad]", false, true),
            new ViewProperty("Proveedor.Nombre", SortDirection.None, "[Proveedor.Nombre]", false, true),
            new ViewProperty("NumFactura", SortDirection.None, "[NumFactura]", false, true),
            new ViewProperty("Fecha", SortDirection.None, "[Fecha]", false, true),
            //new ViewProperty("Cantidad", SortDirection.None, "[Facturas].Sum([Cantidad])", false, true)
            });
            rgBusqueda.SelectedIndex = 0;
            if (Asignar)
                col.Visible = false;
            else
                colAsignar.Visible = false;
        }
        private void ribEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewArticulo = (ViewRecord)grvArticulos.GetRow(grvArticulos.FocusedRowHandle);
            if (ViewArticulo != null)
                using (xfrmArticulo xfrm = new xfrmArticulo())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Articulo = (Articulo)ViewArticulo.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdArticulos.DataSource as XPView).Reload();
                }
        }

        private void ribtnAsignar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewArticulo = (ViewRecord)grvArticulos.GetRow(grvArticulos.FocusedRowHandle);
            if (ViewArticulo != null)
            {
                Factura Factura = (Factura)ViewArticulo.GetObject();
                if (Asignar & Inventario != null)
                {
                    Inventario.Articulos.Add(Factura.Articulo);
                    Inventario.Save();
                    XtraMessageBox.Show("Se agregó el artículo '" + Factura.Articulo.Nombre + "'");
                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea seleccionar el artículo '" + Factura.Articulo.Nombre + "' ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.Codigo = Factura.Articulo.Codigo;
                        this.Close();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator();
            if(!chkHistorico.Checked)
                go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));
            switch (rgBusqueda.SelectedIndex)
            {
                case 0://Codigo
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("Articulo.Codigo"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
                case 1://Descripcion
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("Articulo.Nombre"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
                case 2://NumParte
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("NumParte"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
            }
            grdArticulos.DataSource = Articulos;
        }

        private void rgBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rgBusqueda.SelectedIndex)
            {
                case 0://Codigo
                    lciBusqueda.Text = "Ingresé código:";
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    txtFiltro.Focus();
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 1://Nombre
                    lciBusqueda.Text = "Ingresé descripción:";
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    txtFiltro.Focus();
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 2://NumParte
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    txtFiltro.Focus();
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 3://Marca
                    
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    lueCatalogo.Focus();
                    Utilerias.CargarLookupEdit(lueCatalogo, typeof(Marcas), Unidad, "Nombre", "Nombre", false);
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 4://Proveedor
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    lueCatalogo.Focus();
                    Utilerias.CargarLookupEdit(lueCatalogo, typeof(Proveedor), Unidad, "Nombre", "Nombre", false);
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
            }
        }

        private void lueCatalogo_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCatalogo.EditValue != null)
            {
                GroupOperator go = new GroupOperator();
                if (!chkHistorico.Checked)
                    go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));

                if (lueCatalogo.EditValue.GetType() == typeof(Proveedor))
                {
                    go.Operands.Add(new BinaryOperator("Proveedor.Oid", ((Proveedor)lueCatalogo.EditValue).Oid, BinaryOperatorType.Equal));
                    Articulos.Criteria = go;
                }
                else
                {
                    go.Operands.Add(new BinaryOperator("Marca.Oid", ((Marcas)lueCatalogo.EditValue).Oid, BinaryOperatorType.Equal));
                    Articulos.Criteria = go;
                }
                grdArticulos.DataSource = Articulos;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            grdArticulos.DataSource = null;
            txtFiltro.Text = string.Empty;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar.PerformClick();
           
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            GroupOperator go = new GroupOperator();
            if (!chkHistorico.Checked)
                go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));
            switch (rgBusqueda.SelectedIndex)
            {
                case 0://Codigo
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("Articulo.Codigo"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
                case 1://Descripcion
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("Articulo.Nombre"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
                case 2://NumParte
                    go.Operands.Add(new FunctionOperator("Like", new OperandProperty("NumParte"), new OperandValue("%" + txtFiltro.Text + "%")));
                    Articulos.Criteria = go;
                    break;
            }
            grdArticulos.DataSource = Articulos;
        }
        #endregion
        #region Metodos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                btnBuscar.PerformClick();
                return true;
            }
            if (keyData == Keys.F12)
            {
                btnLimpiar.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
