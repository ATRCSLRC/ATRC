using ATRCBASE.BL;
using UNIDADES.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UNIDADES.WIN
{ 
    public partial class xfrmRadiosGRD : xfrmBase
    {
        public xfrmRadiosGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmRadiosGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Radios = new XPView(Unidad, typeof(Radios));
            Radios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Radio", SortDirection.None, "[Radio]", false, true),
                  new ViewProperty("Marca", SortDirection.None, "[Marca]", false, true),
                  new ViewProperty("Modelo", SortDirection.None, "[Modelo]", false, true),
                  new ViewProperty("Serie", SortDirection.None, "[Serie]", false, true),
                  new ViewProperty("Destino", SortDirection.None,  "iif([Destino] == 0,[Unidad.Nombre],[Usuario.Nombre])", false, true)});
            grdRadios.DataSource = Radios;
        }
        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmRadios xfrm = new xfrmRadios())
            {
                UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = NuevaUnidad;
                xfrm.Radio = new Radios(NuevaUnidad);
                xfrm.EsNuevo = true;
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdRadios.DataSource as XPView).Reload();
            }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRadio = grvRadios.GetFocusedRow() as ViewRecord;
            if (ViewRadio != null)
            {
                Radios Radio = (Radios)ViewRadio.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el radio '" + Radio.Modelo + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Radio.Delete();
                    Unidad.CommitChanges();
                    (grdRadios.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRadio = grvRadios.GetFocusedRow() as ViewRecord;
            if (ViewRadio != null)
                using (xfrmRadios xfrm = new xfrmRadios())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Radio = (Radios)ViewRadio.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdRadios.DataSource as XPView).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
