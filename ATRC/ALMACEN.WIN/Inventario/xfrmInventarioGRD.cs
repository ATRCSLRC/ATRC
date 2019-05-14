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
    public partial class xfrmInventarioGRD : xfrmBase
    {
        public xfrmInventarioGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmInventarioGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevoInventario");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarInventario");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarInventario");
            bbiImprimir.Visibility = Utilerias.VisibilidadPermiso("ImprimirInventario");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Inventarios = new XPView(Unidad, typeof(InventarioArticulo), "Oid;Nombre", null);
            grdInventarios.DataSource = Inventarios;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmInventario xfrm = new xfrmInventario())
            {
                xfrm.Unidad = Unidad;
                xfrm.Inventario = new InventarioArticulo(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdInventarios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewInventario = grvInventarios.GetFocusedRow() as ViewRecord;
            if (ViewInventario != null)
                using (xfrmInventario xfrm = new xfrmInventario())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Inventario = (InventarioArticulo)ViewInventario.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdInventarios.DataSource as XPView).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewInventario = grvInventarios.GetFocusedRow() as ViewRecord;
            if (ViewInventario != null)
            {
                InventarioArticulo Inventario = (InventarioArticulo)ViewInventario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el inventario '" + Inventario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Inventario.Delete();
                    Unidad.CommitChanges();
                    (grdInventarios.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewInventario = grvInventarios.GetFocusedRow() as ViewRecord;
            if (ViewInventario != null)
            {
                ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new Inventario(Convert.ToInt32(ViewInventario["Oid"])));
                repUsuarioRegistrado.ShowPreview();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }
    }
}
