using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
            XPView Unidades = new XPView(Unidad, typeof(Unidad.BL.Unidad), "Oid;Nombre;TipoUnidad;Nombre;Marca;Modelo;VIN;Estado;DetalleVenta.Pagado", null);
            grdUnidades.DataSource = Unidades;

            //Cargar imagenes 
            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Azul);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Amarillo);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Verde);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Rojo);
            //Configuracion columna de estado

            RepositoryItemImageComboBox imageCombo_Estado = grdUnidades.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            imageCombo_Estado.SmallImages = images;
            imageCombo_Estado.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            imageCombo_Estado.Buttons[0].Appearance.BackColor = Color.White;
            imageCombo_Estado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            imageCombo_Estado.LookAndFeel.UseDefaultLookAndFeel = false;
            imageCombo_Estado.LookAndFeel.SkinName = "Office 2016 Colorful";
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Translado", Enums.Estado.Translado, 0));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Detallado", Enums.Estado.Detallado, 1));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Preparado", Enums.Estado.Preparado, 2));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Vendido", Enums.Estado.Vendido, 3));

            imageCombo_Estado.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            grvUnidades.Columns["Estado"].ColumnEdit = imageCombo_Estado;
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
            Unidad.DropChanges();
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void xfrmUnidadGRD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unidad.DropChanges();
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

        private void bbiDetalleVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (ViewUnidad != null)
            {
                ReportPrintTool repRadios = new ReportPrintTool(new DetalleVenta(Convert.ToInt32(ViewUnidad["Oid"])));
                repRadios.ShowPreview();
            }
        }

        private void grvUnidades_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewRecord ViewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (ViewUnidad != null)
            {
                if ((Enums.Estado)ViewUnidad["Estado"] != Enums.Estado.Vendido)
                    bbiDetalleVenta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                else
                    bbiDetalleVenta.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
    }
}
