using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.IO;

namespace REPORTES.Unidades
{
    public partial class DetalleDeUnidad : DevExpress.XtraReports.UI.XtraReport
    {
        public DetalleDeUnidad(int ID)
        {
            InitializeComponent();
            XPCollection Radios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(UNIDADES.BL.Unidad), new BinaryOperator("Oid",ID));
            this.DataSource = Radios;
        }

        private void xrPictureBox2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRPictureBox xrBox = sender as XRPictureBox;
            UNIDADES.BL.Unidad Unidad = (UNIDADES.BL.Unidad)this.GetCurrentRow();
            Image img = ByteArrayToImage(Convert.FromBase64String(Unidad.Imagen.Archivo));
            xrBox.Image = img;
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
