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
    public partial class xfrmPlantillasRutasExtrasGRD : xfrmBase
    {
        public xfrmPlantillasRutasExtrasGRD()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        private void xfrmPlantillasRutasExtrasGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Rutas = new XPView(Unidad, typeof(PlantillaRutas), "Oid;Nombre;Empresa.Nombre", null);
            grdPlantillas.DataSource = Rutas;
        }

        private void bbiAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmPlantillaRutasExtras xfrm = new xfrmPlantillaRutasExtras())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                xfrm.Plantilla = new PlantillaRutas(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdPlantillas.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPlantilla = grvPlantillas.GetFocusedRow() as ViewRecord;
            if (ViewPlantilla != null)
                using (xfrmPlantillaRutasExtras xfrm = new xfrmPlantillaRutasExtras())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Plantilla = (PlantillaRutas)ViewPlantilla.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdPlantillas.DataSource).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPlantilla = grvPlantillas.GetFocusedRow() as ViewRecord;
            if (ViewPlantilla != null)
            {
                PlantillaRutas Plantilla = (PlantillaRutas)ViewPlantilla.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la plantilla " + Plantilla.Empresa.Nombre + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Plantilla.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdPlantillas.DataSource).Reload();
                }
            }
        }
    }
}
