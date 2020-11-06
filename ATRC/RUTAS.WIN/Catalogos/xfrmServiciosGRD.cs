using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using RUTAS.WIN.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmServiciosGRD : xfrmBase
    {
        public xfrmServiciosGRD()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        private void xfrmServiciosGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = ATRCBASE.BL.Utilerias.VisibilidadPermiso("NuevoServicio");
            bbiModificar.Visibility = ATRCBASE.BL.Utilerias.VisibilidadPermiso("ModificarServicio");
            bbiEliminar.Visibility = ATRCBASE.BL.Utilerias.VisibilidadPermiso("EliminarServicio");

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Servicios = new XPView(Unidad, typeof(Servicio), "Oid;Clave;Descripcion;TipoUnidad", null);
            grdServicios.DataSource = Servicios;
            //bbiAgregar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //bbiModificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //bbiEliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmServicio xfrm = new xfrmServicio())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                //xfrm.Servicio = new Servicio(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdServicios.DataSource as XPView).Reload();
            }
            
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewServicio = grvServicios.GetFocusedRow() as ViewRecord;
            if (ViewServicio != null)
                using (xfrmServicio xfrm = new xfrmServicio())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Servicio = (Servicio)ViewServicio.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdServicios.DataSource).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewServicio = grvServicios.GetFocusedRow() as ViewRecord;
            if (ViewServicio != null)
            {
                Servicio Servicio = (Servicio)ViewServicio.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el servicio " + Servicio.Descripcion + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Servicio.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdServicios.DataSource).Reload();
                }
            }
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
