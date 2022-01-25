using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraMap;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmUbicacionesEmpleados : xfrmBase
    {
        public xfrmUbicacionesEmpleados()
        {
            InitializeComponent();
        }

        XPView Usuarios;
        private void xfrmUbicacionesEmpleados_Load(object sender, EventArgs e)
        {
            Usuarios = new XPView(UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(Usuario));


            Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true),
                  new ViewProperty("Longitud", SortDirection.None, "[Longitud]", false, true),
                  new ViewProperty("Latitud", SortDirection.None, "[Latitud]", false, true) });
            Usuarios.Criteria = new BinaryOperator("Activo", true);
            lookUpEdit1.Properties.DataSource = Usuarios;
            MapItemStorage storage = new MapItemStorage();
            storage.Items.AddRange(ObtenerUbicacines());
            vectorItemsLayer1.Data = storage;

            MapControlUbicacion.SetCenterPoint(MapControlUbicacion.CenterPoint, true);
            MapControlUbicacion.Zoom(14);
        }

        List<MapItem> ObtenerUbicacines()
        {
            List<MapItem> Ubicaciones = new List<MapItem>();
            
            foreach (ViewRecord viewEmpleado in Usuarios)
            {
                if (Convert.ToDouble(viewEmpleado["Latitud"]) > 0)
                    Ubicaciones.Add(new MapCallout() { Text = viewEmpleado["NomCompleto"].ToString() , Location = new GeoPoint(Convert.ToDouble(viewEmpleado["Latitud"]), Convert.ToDouble(viewEmpleado["Longitud"])) });
            }
            return Ubicaciones;
        }

        public Image stringToImage(string inputString)
        {
            byte[] image = Convert.FromBase64String(inputString);
            MemoryStream stream = new MemoryStream(image);
            Image returnImage = Image.FromStream(stream);
            return (Image)(new Bitmap(returnImage, new Size(30, 30)));
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = MapControlUbicacion;
            System.Drawing.Printing.Margins Margen = new System.Drawing.Printing.Margins();
            Margen.Left = Margen.Right = 2;
            Margen.Top = Margen.Bottom = 2;
            link.Margins = Margen;
            link.Landscape = true;
            link.PaperKind = System.Drawing.Printing.PaperKind.Legal;
            link.ShowPreview();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ViewRecord viewEmpleado = lookUpEdit1.EditValue as ViewRecord;
            GeoPoint gp = new GeoPoint();
            gp.Latitude = Convert.ToDouble(viewEmpleado["Latitud"]);
            gp.Longitude = Convert.ToDouble(viewEmpleado["Longitud"]);
            MapControlUbicacion.Zoom(17);
            MapControlUbicacion.SetCenterPoint(gp , true);
        }
    }
}
