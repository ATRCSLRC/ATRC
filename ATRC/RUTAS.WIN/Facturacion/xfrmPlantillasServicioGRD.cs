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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.Facturacion
{
    public partial class xfrmPlantillasServicioGRD : xfrmBase
    {
        public xfrmPlantillasServicioGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;

        private void xfrmPlantillasServicioGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            XPView Servicios = new XPView(Unidad, typeof(PlantillaServiciosRealizados), "Oid;Empresa.Nombre", null);
            Servicios.Sorting.Add(new SortProperty("Empresa.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdPlantillaServiciosRealizados.DataSource = Servicios;
        }

        private void bbiNuevaPlantilla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmPlantillasServicios xfrm = new xfrmPlantillasServicios())
            {
                xfrm.EsNuevo = true;
                xfrm.ShowDialog();
                xfrm.Dispose();
                ((XPView)grdPlantillaServiciosRealizados.DataSource).Reload();
            }
        }

        private void bbiModificarPlantilla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewPlantilla = grvPlantillaServiciosRealizados.GetFocusedRow() as ViewRecord;
            if (viewPlantilla != null)
                using (xfrmPlantillasServicios xfrm = new xfrmPlantillasServicios())
                {
                    xfrm.IDServicio = Convert.ToInt32(viewPlantilla["Oid"]);
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdPlantillaServiciosRealizados.DataSource).Reload();
                }
        }

        private void bbiEliminarPlantilla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewPlantilla = grvPlantillaServiciosRealizados.GetFocusedRow() as ViewRecord;
            if (viewPlantilla != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la plantilla del cliente '" + viewPlantilla["Empresa.Nombre"] + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PlantillaServiciosRealizados Plantilla = (PlantillaServiciosRealizados)viewPlantilla.GetObject();
                    Plantilla.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdPlantillaServiciosRealizados.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
    }
}
