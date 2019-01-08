using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
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

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmTanquesCombustibleGRD : xfrmBase
    {
        public xfrmTanquesCombustibleGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmDepartamentoGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion;Capacidad;TipoCombustible", null);
            grdTanques.DataSource = Tanques;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmTanquesCombustible xfrm = new xfrmTanquesCombustible())
            {
                UnidadDeTrabajo UnidadNueva = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = UnidadNueva;
                xfrm.Tanque = new DieselActual(UnidadNueva);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdTanques.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewTanque = grvTanques.GetFocusedRow() as ViewRecord;
            if (ViewTanque != null)
                using (xfrmTanquesCombustible xfrm = new xfrmTanquesCombustible())
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    xfrm.Unidad = UnidadModificar;
                    xfrm.Tanque = UnidadModificar.GetObjectByKey<DieselActual>(Convert.ToInt32(ViewTanque["Oid"]));
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdTanques.DataSource as XPView).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewTanque = grvTanques.GetFocusedRow() as ViewRecord;
            if (ViewTanque != null)
            {
                DieselActual Tanque = ViewTanque.GetObject() as DieselActual;
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el tanque '" + Tanque.Descripcion + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Tanque.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdTanques.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
