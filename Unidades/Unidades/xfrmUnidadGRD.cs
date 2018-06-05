using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
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
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmUnidadGRD : RibbonForm
    {
        public xfrmUnidadGRD()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        private void xfrmUnidadGRD_Load(object sender, EventArgs e)
        {
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            }
            XPView Unidades = new XPView(Unidad, typeof(Unidad.BL.Unidad), "Oid;Nombre", null);
            grdUnidades.DataSource = Unidades;
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (ViewUnidad != null)
                using (xfrmUnidad xfrm = new xfrmUnidad())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.UnidadCamion = (Unidad.BL.Unidad)ViewUnidad.GetObject();
                    xfrm.esModificacion = true;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdUnidades.DataSource).Reload();
                }
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmUnidad xfrm = new xfrmUnidad())
            {
                xfrm.esModificacion = false;
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdUnidades.DataSource as XPView).Reload();
            }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (ViewUnidad != null)
            {
                Unidad.BL.Unidad UnidadCamion = (Unidad.BL.Unidad)ViewUnidad.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la unidad '" + UnidadCamion.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UnidadCamion.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdUnidades.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void xfrmUnidadGRD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unidad.RollbackTransaction();
        }

        private void bbiDetalleUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (ViewUnidad != null)
            {
                ReportPrintTool repRadios = new ReportPrintTool(new DetallesUnidad(Convert.ToInt32(ViewUnidad["Oid"])));
                repRadios.ShowPreview();
            }
        }
    }
}
