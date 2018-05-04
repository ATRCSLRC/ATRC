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
        UnidadDeTrabajo Unidad;

        #region Eventos
        private void xfrmBusquedaArticulos_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Articulos = new XPView(Unidad, typeof(Articulo),"Oid;Codigo;Nombre;Cantidad;Proveedor.Nombre;NumFactura;Fecha",null);
            rgBusqueda.SelectedIndex = 0;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (rgBusqueda.SelectedIndex)
            {
                case 0://Codigo
                    Articulos.Criteria = new BinaryOperator("Codigo", txtFiltro.Text, BinaryOperatorType.Equal);
                    break;
                case 1://Descripcion
                    Articulos.Criteria = new BinaryOperator("Nombre", txtFiltro.Text +"%", BinaryOperatorType.Like);
                    break;
                case 2://NumParte
                    Articulos.Criteria = new BinaryOperator("NumParte", txtFiltro.Text, BinaryOperatorType.Equal);
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
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 1://Nombre
                    lciBusqueda.Text = "Ingresé descripción:";
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 2://NumParte
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 3://Marca
                    rgBusqueda.SelectedIndex = 0;
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
                    Utilerias.CargarLookupEdit(lueCatalogo, typeof(Marcas), Unidad, "Nombre", "Nombre", false);
                    lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcibtnBuscar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 4://Proveedor
                    rgBusqueda.SelectedIndex = 0;
                    grdArticulos.DataSource = null;
                    txtFiltro.Text = string.Empty;
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
                if (lueCatalogo.EditValue.GetType() == typeof(Proveedor))
                    Articulos.Criteria = new BinaryOperator("Proveedor.Oid", ((Proveedor)lueCatalogo.EditValue).Oid, BinaryOperatorType.Equal);
                else
                    Articulos.Criteria = new BinaryOperator("Marca.Oid", ((Marcas)lueCatalogo.EditValue).Oid, BinaryOperatorType.Equal);
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
        #endregion
    }
}
