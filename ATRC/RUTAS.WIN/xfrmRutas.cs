using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class xfrmRutas : xfrmBase
    {

        //VectorItemsLayer layer = new VectorItemsLayer();
        //MapItemStorage storage = new MapItemStorage();
        //GeoCoordinateWatcher gcw = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

        DevExpress.Map.CoordPoint gpClick;
        List<RouteWaypoint> waypoints;
        public UnidadDeTrabajo Unidad;
        public Rutas Ruta;
        public bool EsNuevo;
        public xfrmRutas()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            //gcw.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(GeoPositionChanged);
            //gcw.Start();
            GeoPositionChanged();
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
            Ruta.Coordenadas.Sorting.Add(new SortProperty("Indice", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdCoordenada.DataSource = Ruta.Coordenadas;
            txtRuta.Text = Ruta.Nombre;
            lueEmpresa.EditValue = Ruta.Empresa != null ? Ruta.Empresa.Oid : -1;
            waypoints = new List<RouteWaypoint>();
            PrepararListaPuntos();
            if (!string.IsNullOrEmpty(Ruta.ColorRuta))
            {
                System.Drawing.ColorConverter converter = new System.Drawing.ColorConverter();
                colorRuta.Color = (Color)converter.ConvertFromString(Ruta.ColorRuta);
            }
            
            flyEdicion.ShowPopup();
        }

        //private void GeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        //{
        //    MapItem[] ItemsMapa = null;
        //    GeoPoint gp = new GeoPoint();
        //    gp.Latitude = e.Position.Location.Latitude;
        //    gp.Longitude = e.Position.Location.Longitude;
        //    ItemsMapa = IniciarMapa(e.Position.Location.Latitude, e.Position.Location.Longitude);
        //    storage.Items.AddRange(ItemsMapa);
        //    layer.Data = storage;
        //    MapControlUbicacion.SetCenterPoint(gp, true);
        //    MapControlUbicacion.Zoom(15);
        //    gcw.Stop();

        //}

        private void GeoPositionChanged()
        {
            MapControlUbicacion.SetCenterPoint(MapControlUbicacion.CenterPoint, true);
            MapControlUbicacion.Zoom(14);

        }

        private void MapControlUbicacion_MouseUp(object sender, MouseEventArgs e)
        {
            gpClick = this.MapControlUbicacion.ScreenPointToCoordPoint(e.Location);
        }

        private void bingRouteDataProvider1_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e)
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
                }
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null)
                {
                    polyline.Stroke = colorRuta.Color;//Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
        }

        private void bingGeocodeDataProvider1_LocationInformationReceived(object sender, LocationInformationReceivedEventArgs e)
        {
            GeocodeRequestResult result = e.Result;
            Coordenadas coordenada = new Coordenadas(Unidad);
            coordenada.Longitud = result.Locations[0].Location.GetX();
            coordenada.Latitud = result.Locations[0].Location.GetY();
            coordenada.Calle = ((BingAddress)result.Locations[0].Address).AddressLine;
            coordenada.Indice = Ruta.Coordenadas.Count == 0 ? 1 : Ruta.Coordenadas[Ruta.Coordenadas.Count - 1].Indice + 1;
            waypoints.Add(new RouteWaypoint("", new GeoPoint(coordenada.Latitud, coordenada.Longitud)));
            Ruta.Coordenadas.Add(coordenada);
            grdCoordenada.RefreshDataSource();
            if (Ruta.Coordenadas.Count > 1)
            {
                routeProvider.CalculateRoute(waypoints);
                informationLayer2.Visible = false;
            }
        }

        private void flyEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Eliminar":
                    if (grvCoordenada.FocusedRowHandle < 0) { return; }
                    Coordenadas CoordenadaBorrar = grvCoordenada.GetRow(grvCoordenada.FocusedRowHandle) as Coordenadas;
                    Ruta.Coordenadas.Remove(CoordenadaBorrar);
                    if(Ruta.Coordenadas.Count > 0)
                    {
                        int cont = 0;
                        foreach (Coordenadas coordenada in Ruta.Coordenadas)
                        {
                            cont++;
                            coordenada.Indice = cont;
                        }
                    }
                    break;
                case "Mover arriba":
                    if (grvCoordenada.FocusedRowHandle < 0) { return; }

                    Coordenadas CoordenadaA = grvCoordenada.GetRow(grvCoordenada.FocusedRowHandle) as Coordenadas;

                    if (CoordenadaA.Indice == 1) { return; }

                    Coordenadas CoordenadaB = grvCoordenada.GetRow(grvCoordenada.FocusedRowHandle - 1) as Coordenadas;

                    int temp = CoordenadaA.Indice;
                    CoordenadaA.Indice = CoordenadaB.Indice;
                    CoordenadaB.Indice = temp;
          
                    break;
                case "Mover abajo":
                    if (grvCoordenada.FocusedRowHandle < 0) { return; }

                    Coordenadas CoordenadaBajarA = grvCoordenada.GetRow(grvCoordenada.FocusedRowHandle) as Coordenadas;

                    if (CoordenadaBajarA.Indice > Ruta.Coordenadas.Count - 1) { return; }

                    Coordenadas CoordenadaBajarB = grvCoordenada.GetRow(grvCoordenada.FocusedRowHandle + 1) as Coordenadas;

                    int tempBajar = CoordenadaBajarA.Indice;
                    CoordenadaBajarA.Indice = CoordenadaBajarB.Indice;
                    CoordenadaBajarB.Indice = tempBajar;
                    break;
            }
            PrepararListaPuntos();
            grdCoordenada.RefreshDataSource();
            routeProvider.CalculateRoute(waypoints);
        }

        private void colorRuta_EditValueChanged(object sender, EventArgs e)
        {
            routeProvider.CalculateRoute(waypoints);
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
            //MapControlUbicacion.ShowRibbonPrintPreview();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ValidarCampos())
            {
                Ruta.Nombre = txtRuta.Text;
                Ruta.ColorRuta = colorRuta.Color.ToArgb().ToString();
                Ruta.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                Ruta.Save();
                Unidad.CommitChanges();
                this.Close();
                XtraMessageBox.Show("Los cambios se guardaron correctamente.");
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de querer salir? Podría perder sus cambios.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Unidad.RollbackTransaction();
                this.Close();
            }
        }
        #endregion

        #region Metodos
        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtRuta.Text))
            {
                XtraMessageBox.Show("Debe agregar un nombre a la ruta.");
                txtRuta.Focus();
                return false;
            }

            if (Convert.ToInt32(lueEmpresa.EditValue) <= -1)
            {
                XtraMessageBox.Show("Debe seleccionar una empresa.");
                lueEmpresa.Focus();
                return false;
            }

            if (Ruta.Coordenadas.Count <= 0)
            {
                XtraMessageBox.Show("Debe agregar una ruta a seguir en el mapa.");
                return false;
            }

            return true;
        }

        private void PrepararListaPuntos()
        {
            waypoints.Clear();
            foreach (Coordenadas coordenada in Ruta.Coordenadas)
            {
                waypoints.Add(new RouteWaypoint("", new GeoPoint(coordenada.Latitud, coordenada.Longitud)));
            }
        }

        MapItem[] IniciarMapa(double Lat, double Long)
        {
            return new MapItem[] {
                new MapCallout() { Text = "Su ubicación actual", Location = new GeoPoint(Lat, Long) }
            };
        }

        #endregion
    }
}
