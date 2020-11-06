using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using RUTAS.BL;
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
    public partial class xfrmPreciosPorEmpresa : xfrmBase
    {
        public xfrmPreciosPorEmpresa()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmPreciosPorEmpresa_Load(object sender, EventArgs e)
        {
            bbiNuevoServicio.Visibility = ATRCBASE.BL.Utilerias.VisibilidadPermiso("NuevoServicioPrecio");
            bbiModificarServicio.Visibility = ATRCBASE.BL.Utilerias.VisibilidadPermiso("ModificarServicioPrecio");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Nombre" , null);
            lueEmpresa.Properties.DataSource = Empresas;
        }

        private void lueEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (lueEmpresa.EditValue != null)
            {
                XPView PreciosServicios = new XPView(Unidad, typeof(PreciosServicios), "Oid;Servicio.Clave;Servicio.Descripcion;Precio", new BinaryOperator("Empresa", lueEmpresa.EditValue));
                grdPreciosServicios.DataSource = PreciosServicios;
                rpAcciones.Visible = true;
            }else
            {
                grdPreciosServicios.DataSource = null;
                rpAcciones.Visible = false;
            }
        }

        private void bbiNuevoServicio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmPrecioServicio xfrm = new xfrmPrecioServicio())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                xfrm.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                //xfrm.Servicio = new Servicio(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdPreciosServicios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificarServicio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPrecioServicio = grvPreciosServicios.GetFocusedRow() as ViewRecord;
            if (ViewPrecioServicio != null)
                using (xfrmPrecioServicio xfrm = new xfrmPrecioServicio())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.PrecioServicio = (PreciosServicios)ViewPrecioServicio.GetObject();
                    xfrm.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdPreciosServicios.DataSource).Reload();
                }
        }
    }
}
