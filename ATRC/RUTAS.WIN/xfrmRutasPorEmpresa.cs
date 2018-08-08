using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraMap;
using DevExpress.XtraPrinting;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmRutasPorEmpresa : xfrmBase
    {
        public xfrmRutasPorEmpresa()
        {
            InitializeComponent();
        }

        VectorItemsLayer layer = new VectorItemsLayer();
        MapItemStorage storage = new MapItemStorage();
        GeoCoordinateWatcher gcw = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
        Rutas RutaActual;
        List<RouteWaypoint> waypoints;
        UnidadDeTrabajo Unidad;
        XPCollection<Rutas> Rutas;
        int Routing = 0;
        private void xfrmRutasPorEmpresa_Load(object sender, EventArgs e)
        {
            gcw.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(GeoPositionChanged);
            gcw.Start();
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
        }

        private void PrepararListaPuntos()
        {
            waypoints.Clear();
            foreach (Coordenadas coordenada in RutaActual.Coordenadas)
            {
                waypoints.Add(new RouteWaypoint("", new GeoPoint(coordenada.Latitud, coordenada.Longitud)));
            }
        }
        private void Routing_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            if (e.Cancelled || (e.Error != null)) return;
            int numMarker = 1;
            //char pushpinMarker = 'A';
            foreach (MapItem item in e.Items)
            {
                MapPushpin pushpin = item as MapPushpin;
                if (pushpin != null)
                {
                    pushpin.Text = numMarker++.ToString();
                    pushpin.Transparency = 200;
                }
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null)
                {
                    System.Drawing.ColorConverter converter = new System.Drawing.ColorConverter();
                    polyline.Stroke = (Color)converter.ConvertFromString(Rutas[Routing].ColorRuta);//Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
            Routing++;
        }

        private void GeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            MapItem[] ItemsMapa = null;
            GeoPoint gp = new GeoPoint();
            gp.Latitude = e.Position.Location.Latitude;
            gp.Longitude = e.Position.Location.Longitude;
            ItemsMapa = IniciarMapa(e.Position.Location.Latitude, e.Position.Location.Longitude);
            storage.Items.AddRange(ItemsMapa);
            layer.Data = storage;
            MapControlUbicacion.SetCenterPoint(gp, true);
            MapControlUbicacion.Zoom(15);
            gcw.Stop();

        }

        MapItem[] IniciarMapa(double Lat, double Long)
        {
            return new MapItem[] {
                new MapCallout() { Text = "Su ubicación actual", Location = new GeoPoint(Lat, Long) }
            };
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Rutas = new XPCollection<Rutas>(Unidad, new BinaryOperator("Empresa.Oid", lueEmpresa.EditValue));
            Routing = 0;
            MapControlUbicacion.Layers.Clear();
            MapControlUbicacion.Layers.Add(imageLayer1);
            ((ColorListLegend)MapControlUbicacion.Legends[0]).CustomItems.Clear();
            foreach (Rutas ruta in Rutas)
            {
                RutaActual = ruta;
                waypoints = new List<RouteWaypoint>();
                InformationLayer info = new InformationLayer();
                BingRouteDataProvider routing = new BingRouteDataProvider();
                info.DataProvider = routing;
                routing.BingKey = "AsFpcLqFTZI0OBfJx-oDBp-hxtsuknATg9gZ7o3yt3DUnq3M7CSSFCD_FRLP-qJx";
                routing.LayerItemsGenerating += Routing_LayerItemsGenerating;
                PrepararListaPuntos();
                MapControlUbicacion.Layers.Add(info);
                System.Drawing.ColorConverter converter = new System.Drawing.ColorConverter();
                ColorLegendItem color = new ColorLegendItem();
                color.Color = (Color)converter.ConvertFromString(ruta.ColorRuta);
                color.Text = ruta.Nombre;
                ((ColorListLegend)MapControlUbicacion.Legends[0]).CustomItems.Add(color);
                routing.CalculateRoute(waypoints);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = MapControlUbicacion;
            System.Drawing.Printing.Margins Margen = new System.Drawing.Printing.Margins();
            Margen.Left = 3;
            Margen.Right = 3;
            link.Margins = Margen;
            link.Landscape = true;
            link.PaperKind = System.Drawing.Printing.PaperKind.Legal;
            link.ShowPreview();
        }
    }
}
