using DevExpress.Map;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmMapa : xfrmBase
    {
        public xfrmMapa()
        {
            InitializeComponent();
        }
        DevExpress.Map.CoordPoint gpClick;
        public bool Guardar;
        public double Latitud;
        public double Longitud;
        private void xfrmMapa_Load(object sender, EventArgs e)
        {
           // bingGeocodeDataProvider1.MaxVisibleResultCount = 1;
            if (Latitud > 0)
            {
                MapItemStorage storage = new MapItemStorage();
                vectorItemsLayer1.Data = storage;
                storage.Items.Add(new MapPushpin() { Location = new GeoPoint(Latitud, Longitud) });
                // bingGeocodeDataProvider1.RequestLocationInformation(new DevExpress.XtraMap.GeoPoint(Latitud, Longitud), 0);
                MapControlUbicacion.SetCenterPoint(new DevExpress.XtraMap.GeoPoint(Latitud, Longitud), true);
            }
            else
            {
                MapControlUbicacion.SetCenterPoint(MapControlUbicacion.CenterPoint, true);
            }
            
            MapControlUbicacion.Zoom(17);
        }
        private void bingGeocodeDataProvider1_LocationInformationReceived(object sender, DevExpress.XtraMap.LocationInformationReceivedEventArgs e)
        {
           // Latitud = e.Result.Locations[0].Location.Latitude;
            //Longitud = e.Result.Locations[0].Location.Longitude; 
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar = true;
            XtraMessageBox.Show("Se ha asignado la ubicación correctamente.");
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void MapControlUbicacion_MouseUp(object sender, MouseEventArgs e)
        {
            gpClick = this.MapControlUbicacion.ScreenPointToCoordPoint(e.Location);
        }

        private void MapControlUbicacion_Click(object sender, EventArgs e)
        {
            MapItemStorage storage = new MapItemStorage();
            vectorItemsLayer1.Data = storage;
            storage.Items.Add(new MapPushpin() { Location = new GeoPoint(gpClick.GetY(), gpClick.GetX()) });
        }

        private void MapControlUbicacion_DoubleClick(object sender, EventArgs e)
        {
            MapItemStorage storage = new MapItemStorage();
            vectorItemsLayer1.Data = storage;
            storage.Items.Add(new MapPushpin() { Location = new GeoPoint(gpClick.GetY(), gpClick.GetX()) });
            Latitud = gpClick.GetY();
            Longitud = gpClick.GetX(); 
        }
    }
}
