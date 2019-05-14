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
using DevExpress.XtraEditors.Repository;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.WIN
{
    public partial class xfrmInventarioExtintores : xfrmBase
    {
        public xfrmInventarioExtintores()
        {
            InitializeComponent();
        }

        private void xfrmInventarioExtintores_Load(object sender, EventArgs e)
        {
            bbiRevisar.Visibility = Utilerias.VisibilidadPermiso("RevisarExtintor");
            Controles();
        }

        private void Controles()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Extintores = new XPView(Unidad, typeof(Extintores));
            Extintores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Revisado", SortDirection.None, "iif(GETMONTH([FechaInventario]) == GETMONTH(NOW()), True, False)", false, true),
                  new ViewProperty("NumExtintor", SortDirection.None, "[NumExtintor]", false, true),
                  new ViewProperty("FechaRecarga", SortDirection.None, "[FechaRecarga]", false, true),
                  new ViewProperty("FechaVencimiento", SortDirection.None, "[FechaVencimiento]", false, true),
                  new ViewProperty("UbicacionExtintor", SortDirection.None,  "iif([UbicacionExtintor] == 0,[Unidad.Nombre],iif([UbicacionExtintor] == 1, [Oficina], 'Almacen'))", false, true),
                  new ViewProperty("Peso", SortDirection.None,  "ToStr([Peso]) + ' kg'", false, true),
                  new ViewProperty("Tipo", SortDirection.None,  "[Tipo]", false, true),
                  new ViewProperty("EstadoExtintor", SortDirection.None,  "[EstadoExtintor]", false, true),
                  new ViewProperty("FechaInventario", SortDirection.None,  "[FechaInventario]", false, true),
                  new ViewProperty("UltimoComentario", SortDirection.None,  "[UltimoComentario]", false, true)});
            grdInventario.DataSource = Extintores;

            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_green);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_blue);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_yellow);
            images.AddImage((Bitmap)global::UNIDADES.WIN.Properties.Resources.bullet_ball_red);
            //Configuracion columna de estado

            RepositoryItemImageComboBox imageCombo_Estado = grdInventario.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            imageCombo_Estado.SmallImages = images;
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bueno", EstadoExtintor.Bueno, 0));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Usado", EstadoExtintor.Usado, 1));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mantenimiento", EstadoExtintor.Mantenimiento, 2));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Vencido", EstadoExtintor.Vencido, 3));

            imageCombo_Estado.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            grvInventario.Columns["EstadoExtintor"].ColumnEdit = imageCombo_Estado;
        }

        private void bbiRevisar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewExtintor = grvInventario.GetFocusedRow() as ViewRecord;
            if (ViewExtintor != null)
                using (xfrmExtintores xfrm = new xfrmExtintores())
                {
                    UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

                    xfrm.Unidad = NuevaUnidad;
                    xfrm.Extintor = NuevaUnidad.GetObjectByKey<Extintores>(ViewExtintor["Oid"]);
                    xfrm.EsInventario = true;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdInventario.DataSource as XPView).Reload();
                }
        }
    }
}
