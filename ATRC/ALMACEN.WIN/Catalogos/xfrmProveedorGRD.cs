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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMACEN.WIN
{
    public partial class xfrmProveedorGRD : xfrmBase
    {
        public xfrmProveedorGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmPuestoGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevoProveedor");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarProveedor");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarProveedor");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Proveedor> Proveedores = new XPCollection<Proveedor>(Unidad);
            grdMedidas.DataSource = Proveedores;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmProveedor xfrm = new xfrmProveedor())
            {
                xfrm.Unidad = Unidad;
                xfrm.Proveedor = new Proveedor(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdMedidas.DataSource as XPCollection<Proveedor>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Proveedor Proveedor = grvMedidas.GetFocusedRow() as Proveedor;
            if (Proveedor != null)
                using (xfrmProveedor xfrm = new xfrmProveedor())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Proveedor = Proveedor;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdMedidas.DataSource as XPCollection<Proveedor>).Reload();
                }   
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Proveedor Proveedor = grvMedidas.GetFocusedRow() as Proveedor;
            if(Proveedor != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el proveedor '" + Proveedor.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Proveedor.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Proveedor>)grdMedidas.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
