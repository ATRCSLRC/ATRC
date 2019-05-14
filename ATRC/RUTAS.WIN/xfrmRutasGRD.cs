using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class xfrmRutasGRD : xfrmBase
    {
        public xfrmRutasGRD()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        private void xfrmRutasGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevaRutas");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarRutas");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarRutas");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Rutas = new XPView(Unidad, typeof(Rutas), "Oid;Nombre;Empresa.Nombre;ColorRuta", null);
            grdRutas.DataSource = Rutas;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmRutas xfrm = new xfrmRutas())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                xfrm.Ruta = new Rutas(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdRutas.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRuta = grvRutas.GetFocusedRow() as ViewRecord;
            if (ViewRuta != null)
                using (xfrmRutas xfrm = new xfrmRutas())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Ruta = (Rutas)ViewRuta.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdRutas.DataSource).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRuta = grvRutas.GetFocusedRow() as ViewRecord;
            if (ViewRuta != null)
            {
                Rutas Ruta = (Rutas)ViewRuta.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la ruta '" + Ruta.Nombre + "' de "+Ruta.Empresa.Nombre +"?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Ruta.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdRutas.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }
    }
}
