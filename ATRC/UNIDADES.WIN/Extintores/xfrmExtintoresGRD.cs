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
using DevExpress.XtraEditors.Repository;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.WIN
{ 
    public partial class xfrmExtintoresGRD : xfrmBase
    {
        public xfrmExtintoresGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmRadiosGRD_Load(object sender, EventArgs e)
        {

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Extintores = new XPView(Unidad, typeof(Extintores));
            Extintores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumExtintor", SortDirection.None, "[NumExtintor]", false, true),
                  new ViewProperty("FechaRecarga", SortDirection.None, "[FechaRecarga]", false, true),
                  new ViewProperty("FechaVencimiento", SortDirection.None, "[FechaVencimiento]", false, true),
                  new ViewProperty("UbicacionExtintor", SortDirection.None,  "iif([UbicacionExtintor] == 0,[Unidad.Nombre],iif([UbicacionExtintor] == 1, [Oficina], 'Almacen'))", false, true),
                  new ViewProperty("Peso", SortDirection.None,  "ToStr([Peso]) + ' kg'", false, true),
                  new ViewProperty("Tipo", SortDirection.None,  "[Tipo]", false, true),
                  new ViewProperty("EstadoExtintor", SortDirection.None,  "[EstadoExtintor]", false, true),
                  new ViewProperty("FechaInventario", SortDirection.None,  "[FechaInventario]", false, true),});
            grdExtintor.DataSource = Extintores;

            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_green);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_blue);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_yellow);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_red);
            //Configuracion columna de estado

            RepositoryItemImageComboBox imageCombo_Estado = grdExtintor.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            imageCombo_Estado.SmallImages = images;
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bueno", EstadoExtintor.Bueno, 0));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Usado", EstadoExtintor.Usado, 1));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mantenimiento", EstadoExtintor.Mantenimiento, 2));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Vencido", EstadoExtintor.Vencido, 3));

            imageCombo_Estado.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            grvExtintor.Columns["EstadoExtintor"].ColumnEdit = imageCombo_Estado;
        }
        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmExtintores xfrm = new xfrmExtintores())
            {
                UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = NuevaUnidad;
                xfrm.EsNuevo = true;
                xfrm.Size = new Size(460,381);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdExtintor.DataSource as XPView).Reload();
            }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewExtintor = grvExtintor.GetFocusedRow() as ViewRecord;
            if (ViewExtintor != null)
            {
                Extintores Extintor = (Extintores)ViewExtintor.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el extintor '" + Extintor.NumExtintor + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Extintor.Delete();
                    Unidad.CommitChanges();
                    (grdExtintor.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewExtintor = grvExtintor.GetFocusedRow() as ViewRecord;
            if (ViewExtintor != null)
                using (xfrmExtintores xfrm = new xfrmExtintores())
                {
                    UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    
                    xfrm.Unidad = NuevaUnidad;
                    xfrm.Extintor = NuevaUnidad.GetObjectByKey<Extintores>(ViewExtintor["Oid"]);
                    xfrm.ShowInTaskbar = false;
                    xfrm.Size = new Size(460, 381);
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdExtintor.DataSource as XPView).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdExtintor.ShowRibbonPrintPreview();
        }
    }
}
