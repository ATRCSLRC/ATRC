
using ATRCBASE.BL;
using cs_pdf_to_image;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmAnunciosUsuario : xfrmBase
    {
        public xfrmAnunciosUsuario()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public AnuncioUsuario Anuncio;
        public bool EsNuevo = false;

        private void xfrmAnunciosUsuario_Load(object sender, EventArgs e)
        {
            //cmbLugarPublicacion.Properties.Items.AddRange(Enum.GetValues(typeof(Enums.LugarPublicar)));
            cmbLugarPublicacion.Properties.Items.Add(Enums.LugarPublicar.Comedor);
            cmbLugarPublicacion.Properties.Items.Add(Enums.LugarPublicar.Caseta);
            cmbLugarPublicacion.Properties.Items.Add(Enums.LugarPublicar.Recepcion);
            cmbLugarPublicacion.Properties.Items.Add(Enums.LugarPublicar.Todas);
            if (!EsNuevo)
            {
                txtNombre.Text = Anuncio.Nombre;
                rgTipoAnuncio.EditValue = Anuncio.TipoAnuncio;
                chkPublicar.Checked = Anuncio.Publicar;
                cmbLugarPublicacion.EditValue = (Enums.LugarPublicar)Anuncio.LugarPublicar;
                if(Anuncio.TipoAnuncio == "Texto")
                {
                    Stream stream = new MemoryStream(Anuncio.Documento);
                    richTexto.LoadDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                }
                else
                {
                    if (Anuncio.Anuncio != null)
                    {
                        MemoryStream stream = new MemoryStream(Anuncio.Anuncio);
                        Image returnImage = Image.FromStream(stream);
                        picImagen.EditValue = stream.ToArray();
                    }
                }
            }
            else
            {
                Anuncio = new AnuncioUsuario(Unidad);
            }
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    richEditControl1.SaveDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
            //    //documento.DocumentoGenerado = stream.ToArray();

            //    using (Image image = Image.FromStream(stream))
            //    {
            //        // Upon success image contains the bitmap
            //        //  and can be saved to a file:
            //        image.Save(System.IO.Path.GetTempFileName() + ATRCBASE.BL.Utilerias.GetExtension(image));
            //    }
            //}
            Byte[] DocumentoGenerado;
            string archivoTemporal = System.IO.Path.GetTempFileName() + ".pdf";
            using (Stream stream = new MemoryStream())
            {
                richTexto.ExportToPdf(stream);
                DocumentoGenerado = new byte[stream.Length];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(DocumentoGenerado, 0, (int)stream.Length);

                File.WriteAllBytes(archivoTemporal, DocumentoGenerado);

            }
            //Pdf2Image settings;

            //settings = new Pdf2ImageSettings();
            //settings.AntiAliasMode = AntiAliasMode.High;
            //settings.Dpi = 300;
            //settings.GridFitMode = GridFitMode.Topological;
            //settings.ImageFormat = Cyotek.GhostScript.ImageFormat.Png24;
            //settings.TrimMode = PdfTrimMode.CropBox;
            List<string> errors = cs_pdf_to_image.Pdf2Image.Convert(archivoTemporal, System.IO.Path.GetTempFileName() + ".png");
            //Bitmap firstPage = new Pdf2Image(archivoTemporal).GetImage(1);

            //string outputfilePath = System.IO.Path.Combine(@"D:\temp\", System.IO.Path.GetFileNameWithoutExtension(txtFilePath.Text));

            // firstPage.Save("pruebanueva.png", System.Drawing.Imaging.ImageFormat.Png);

            //using (FileStream fs = new FileStream(archivoTemporal, FileMode.Open))
            //{
            //    Document document = new Document(fs);

            //    // process and save pages one by one
            //    for (int i = 0; i < document.Pages.Count; i++)
            //    {
            //        Page currentPage = document.Pages[i];

            //        // we use original page's width and height for image as well as default rendering settings
            //        using (Bitmap bitmap = currentPage.Render((int)currentPage.Width, (int)currentPage.Height, new RenderingSettings()))
            //        {
            //            bitmap.Save(string.Format("{0}.png", i), ImageFormat.Png);
            //        }
            //    }
            //}

        }


        private void rgTipoAnuncio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rgTipoAnuncio.SelectedIndex ==  0)
            {
                Tab.SelectedTabPage = TabImagen;
            }else
            {
                Tab.SelectedTabPage = TabTexto;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Anuncio.Nombre = txtNombre.Text;
                Anuncio.TipoAnuncio = rgTipoAnuncio.Text;
                Anuncio.LugarPublicar = (Enums.LugarPublicar)cmbLugarPublicacion.EditValue;
                Anuncio.Publicar = chkPublicar.Checked;
                if (rgTipoAnuncio.SelectedIndex == 1)
                {

                    PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
                    ImageExportOptions options = new ImageExportOptions(ImageFormat.Png);
                    options.Resolution = 300;
                    options.ExportMode = ImageExportMode.SingleFilePageByPage;

                    pcl.Component = richTexto;
                    pcl.CreateDocument();

                    using (Stream stream = new MemoryStream())
                    {
                        pcl.ExportToImage(stream, options);
                        Anuncio.Anuncio = new byte[stream.Length];
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.Read(Anuncio.Anuncio, 0, (int)stream.Length);

                    }
                    using (MemoryStream stream = new MemoryStream())
                    {
                        richTexto.SaveDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                        Anuncio.Documento = stream.ToArray();
                    }
                }
                Anuncio.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream Archivo = new System.IO.FileStream(ofdImagen.FileName, FileMode.Open, FileAccess.Read);
                    MemoryStream streampdf = new MemoryStream();
                    Archivo.CopyTo(streampdf);
                    Archivo.Dispose();
                    Anuncio.Anuncio = streampdf.ToArray();
                    picImagen.EditValue = streampdf.ToArray();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe ingresar el nombre del anuncio.");
                txtNombre.Focus();
                return false;
            }

            if (cmbLugarPublicacion.SelectedItem == null)
            {
                XtraMessageBox.Show("Debe seleccionar donde publicar el anuncio.");
                cmbLugarPublicacion.Focus();
                return false;
            }

            return true;
        }

    }
}
