using DevExpress.XtraEditors;
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
        public bool Guardar;
        public double Latitud;
        public double Longitud;
        private void xfrmMapa_Load(object sender, EventArgs e)
        {
            bingGeocodeDataProvider1.MaxVisibleResultCount = 1;
            if (Latitud > 0)
            {
                bingGeocodeDataProvider1.RequestLocationInformation(new DevExpress.XtraMap.GeoPoint(Latitud, Longitud), 0);
                MapControlUbicacion.SetCenterPoint(new DevExpress.XtraMap.GeoPoint(Latitud, Longitud), true);
            }
            else
            {
                MapControlUbicacion.SetCenterPoint(MapControlUbicacion.CenterPoint, true);
            }
            
            MapControlUbicacion.Zoom(14);
        }
        private void bingGeocodeDataProvider1_LocationInformationReceived(object sender, DevExpress.XtraMap.LocationInformationReceivedEventArgs e)
        {
            Latitud = e.Result.Locations[0].Location.Latitude;
            Longitud = e.Result.Locations[0].Location.Longitude; 
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
    }
}
