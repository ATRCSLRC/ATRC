using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using REPORTES.Rutas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.Anuncios
{
    public partial class xfrmPublicacionRutas : xfrmBase
    {
        public xfrmPublicacionRutas()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;

        private void xfrmPublicacionRutas_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Publicaciones = new XPView(Unidad, typeof(PublicacionAnuncios), "Oid;FechaPublicacion;EsExtra", null);
            Publicaciones.Sorting.Add(new SortProperty("FechaPublicacion", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdAnuncios.DataSource = Publicaciones;
        }

        private void bbiNuevaPublicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Seleccionar fecha de publicación";
            args.Prompt = "Fecha:";
            DateEdit editor = new DateEdit();
            editor.Properties.DisplayFormat.FormatString = "D";
            editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            editor.Properties.EditFormat.FormatString = "D";
            editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            editor.Properties.EditMask = "D";
            args.Editor = editor;
            args.DefaultResponse = DateTime.Now;
            var result = XtraInputBox.Show(args);
            if (result != null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                PublicacionAnuncios Publicacion = new PublicacionAnuncios(Unidad);
                Publicacion.FechaPublicacion = ((DateTime)result).ToLongDateString();
                Publicacion.EsExtra = false;
                // List<byte[]> previewImages = new List<byte[]>();
                ReporteRutasPublicar report = new ReporteRutasPublicar(((DateTime)result).Date, false);
                report.CreateDocument();
                report.ShowPreview();

                XtraReport tempReport;
                for (int i = 0; i < report.Pages.Count; i++)
                {
                    tempReport = new XtraReport();
                    tempReport.Pages.Add(report.Pages[i]);

                    GetReportPreviewImage(tempReport, Publicacion);
                }
                Publicacion.Save();
                Unidad.CommitChanges();
                ((XPView)grdAnuncios.DataSource).Reload();
            }
        }

        private void bbiPublicaionExtra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Seleccionar fecha de publicación";
            args.Prompt = "Fecha:";
            DateEdit editor = new DateEdit();
            editor.Properties.DisplayFormat.FormatString = "D";
            editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            editor.Properties.EditFormat.FormatString = "D";
            editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            editor.Properties.EditMask = "D";
            args.Editor = editor;
            args.DefaultResponse = DateTime.Now;
            var result = XtraInputBox.Show(args);
            if (result != null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                PublicacionAnuncios Publicacion = new PublicacionAnuncios(Unidad);
                Publicacion.FechaPublicacion = ((DateTime)result).ToLongDateString();
                Publicacion.EsExtra = true;
                // List<byte[]> previewImages = new List<byte[]>();
                ReporteRutasPublicar report = new ReporteRutasPublicar(((DateTime)result).Date, true);
                report.CreateDocument();
                report.ShowPreview();

                XtraReport tempReport;
                for (int i = 0; i < report.Pages.Count; i++)
                {
                    tempReport = new XtraReport();
                    tempReport.Pages.Add(report.Pages[i]);

                    GetReportPreviewImage(tempReport, Publicacion);
                }
                Publicacion.Save();
                Unidad.CommitChanges();
                ((XPView)grdAnuncios.DataSource).Reload();
            }
        }

        private void bbiEliminarPublicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewPublicacion = grvAnuncios.GetFocusedRow() as ViewRecord;
            if (XtraMessageBox.Show("¿Desea eliminar la publicación?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (viewPublicacion != null)
                {
                    PublicacionAnuncios Publicacion = (PublicacionAnuncios)viewPublicacion.GetObject();
                    Publicacion.Delete();
                    //Publicacion.Session.PurgeDeletedObjects();
                    Publicacion.Session.CommitTransaction();
                    ((XPView)grdAnuncios.DataSource).Reload();
                }
            }

        }

        private void GetReportPreviewImage(XtraReport report, PublicacionAnuncios Publicacion)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                report.ExportToImage(memoryStream, new DevExpress.XtraPrinting.ImageExportOptions() { ExportMode = DevExpress.XtraPrinting.ImageExportMode.SingleFilePageByPage });

                memoryStream.Seek(0, SeekOrigin.Begin);

                //Image image = Image.FromStream(memoryStream.to);

                //image.Save("C:/debug/image_" + (new Random().Next(1, 100000)) + ".png");  
                //return memoryStream.ToArray();
                AnuncioUsuario Anuncio = new AnuncioUsuario(Publicacion.Session);
                Anuncio.Anuncio = memoryStream.ToArray();
                Anuncio.LugarPublicar = Enums.LugarPublicar.Rutas;
                Anuncio.Publicar = true;
                Anuncio.TipoAnuncio = "Imagen";
                Anuncio.Nombre = DateTime.Now.ToLongDateString();
                Anuncio.Publicacion = Publicacion;
                Anuncio.Save();
            }
        }
    }
}
