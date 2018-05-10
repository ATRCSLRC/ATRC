using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class xfrmInventario : xfrmBase
    {
        public xfrmInventario()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public InventarioArticulo Inventario;

        private void xfrmInventario_Load(object sender, EventArgs e)
        {
            grdArticulos.DataSource = Inventario.Articulos;
            txtNombre.Text = Inventario.Nombre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (xfrmBusquedaArticulos xfrm = new xfrmBusquedaArticulos())
            {
                xfrm.Unidad = Unidad;
                xfrm.Inventario = Inventario;
                xfrm.ShowDialog();
                xfrm.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo Articulo = grvArticulos.GetFocusedRow() as Articulo;
            if(Articulo != null)
            {
                Inventario.Articulos.Remove(Articulo);
                Inventario.Save();
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text))
            {
                Inventario.Nombre = txtNombre.Text;
                Inventario.Save();
                Unidad.CommitChanges();
                ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new Inventario(Inventario.Oid));
                repUsuarioRegistrado.ShowPreview();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Debe agregar un nombre al inventario");
                txtNombre.Focus();
            }
                
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }
    }
}
