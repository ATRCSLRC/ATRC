using ATRCBASE.BL;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC.Plantilla
{
    public partial class EdicionPlantillaRutas : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsCallback || !Page.IsPostBack)
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    RUTAS.BL.PlantillaRutas Plantilla = null;
                    if (Request.QueryString.Count > 0)
                    {
                        string id = ATRCBASE.BL.Utilerias.DesencriptarString(Request.QueryString[0].ToString());
                        Plantilla = Unidad.GetObjectByKey<RUTAS.BL.PlantillaRutas>(Convert.ToInt32(id));
                        txtNombre.Text = Plantilla.Nombre;
                    }
                    else
                    {
                        Plantilla = new RUTAS.BL.PlantillaRutas(Unidad);
                    }
                    Session["Plantilla"] = Plantilla;
                    Session["Unidad"] = Unidad;
                    grdRutas.DataBind();
                    cmbServicio.DataBind();
                    cmbTurno.DataBind();
                    grdRutas.FocusedRowIndex = -1;
                }
            }
            catch (Exception ex)
            {
                // Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdRutas_DataBinding(object sender, EventArgs e)
        {
            if (Session["Plantilla"] != null)
            {
                RUTAS.BL.PlantillaRutas Plantilla = Session["Plantilla"] as RUTAS.BL.PlantillaRutas;
                grdRutas.DataSource = Plantilla.PlantillasRutasFijas;
            }
        }

        protected void PanelRuta_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            PlantillaRutaFija Ruta = grdRutas.GetRow(Convert.ToInt32(e.Parameter)) as PlantillaRutaFija;
            txtRuta.Text = Ruta.Ruta;
            chkRutaExtra.Checked = Ruta.EsRutaExtra;
            cmbServicio.SelectedItem = cmbServicio.Items.FindByValue(Ruta.Servicio.Oid);
            CargarTipoRuta(Ruta.Session as UnidadDeTrabajo, Ruta.Servicio.Oid);
            cmbTipoRuta.SelectedItem = cmbTipoRuta.Items.FindByValue((int)Ruta.TipoRuta);
            switch (Ruta.TipoRuta)
            {
                case Enums.TipoRuta.Entrada:
                    tmeAhora.ClientVisible = false;
                    break;
                case Enums.TipoRuta.Salida:
                    tmeHoraDe.ClientVisible = false;
                    break;
            }

            if (Ruta.Turno != null)
                cmbTurno.Value = Ruta.Turno.Oid;
            if (Ruta.HoraEntrada != null)
                tmeHoraDe.DateTime = (DateTime)Ruta.HoraEntrada;
            if (Ruta.HoraSalida != null)
                tmeAhora.DateTime = (DateTime)Ruta.HoraSalida;
        }

        protected void cmbTipoRuta_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (Session["Unidad"] != null)
            {
                CargarTipoRuta(Session["Unidad"] as UnidadDeTrabajo, Convert.ToInt32(e.Parameter));
                //Servicio Servicio = (Session["Unidad"] as UnidadDeTrabajo).GetObjectByKey<Servicio>(Convert.ToInt32(e.Parameter));
                //if (Servicio.EsMediaVuelta)
                //{
                //    cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Entrada.ToString(), Enums.TipoRuta.Entrada));
                //    cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Salida.ToString(), Enums.TipoRuta.Salida));
                //}
                //else
                //{
                //    cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Normal.ToString(), Enums.TipoRuta.Normal));
                //}
            }
        }

        protected void cmbTurno_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                XPView Servicios = new XPView(Session["Unidad"] as UnidadDeTrabajo, typeof(Turno), "Oid;Descripcion", null);
                cmbTurno.DataSource = Servicios;
            }
        }

        protected void cmbServicio_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                XPView Servicios = new XPView(Session["Unidad"] as UnidadDeTrabajo, typeof(Servicio), "Oid;Clave;Descripcion", null);
                cmbServicio.DataSource = Servicios;
            }
        }

        protected void CallbackGuardarRutas_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (Session["Plantilla"] != null)
            {
                string[] Parametro = e.Parameter.Split('|');

                RUTAS.BL.PlantillaRutas Plantilla = Session["Plantilla"] as RUTAS.BL.PlantillaRutas;
                PlantillaRutaFija Ruta;

                switch (Parametro[0])
                {
                    case "EditRow":
                    case "FocusedRowContext":
                        Ruta = grdRutas.GetRow(grdRutas.FocusedRowIndex) as PlantillaRutaFija;
                        GurdarRuta(Ruta, Parametro[1]);
                        Plantilla.PlantillasRutasFijas.Add(Ruta);
                        break;
                    case "DeleteRow":
                        Ruta = grdRutas.GetRow(grdRutas.FocusedRowIndex) as PlantillaRutaFija;
                        Plantilla.PlantillasRutasFijas.Remove(Ruta);
                        break;
                    default:
                        Ruta = new PlantillaRutaFija(Plantilla.Session);
                        GurdarRuta(Ruta, Parametro[1]);
                        Plantilla.PlantillasRutasFijas.Add(Ruta);
                        break;
                }

                Session["Plantilla"] = Plantilla;
            }
        }

        protected void CallbackGuardarPedido_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (Session["Plantilla"] != null)
            {
                RUTAS.BL.PlantillaRutas Plantilla = Session["Plantilla"] as RUTAS.BL.PlantillaRutas;
                Plantilla.Nombre = txtNombre.Text;
                Plantilla.EsExterno = true;
                Plantilla.Save();
                Plantilla.Session.CommitTransaction();
            }
        }

        private void GurdarRuta(PlantillaRutaFija Ruta, string TipoRuta)
        {

            Ruta.Ruta = txtRuta.Text;
            Ruta.EsRutaExtra = chkRutaExtra.Checked;
            Ruta.Servicio = Ruta.Session.GetObjectByKey<Servicio>(cmbServicio.Value);
            Ruta.TipoRuta = (Enums.TipoRuta)Enum.Parse(typeof(Enums.TipoRuta), TipoRuta);
            Ruta.Turno = Ruta.Session.GetObjectByKey<Turno>(cmbTurno.Value);
            Ruta.HoraEntrada = tmeHoraDe.Value is null ? null : (DateTime?)new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tmeHoraDe.DateTime.Hour, tmeHoraDe.DateTime.Minute, tmeHoraDe.DateTime.Second);
            Ruta.HoraSalida = tmeAhora.Value is null ? null : (DateTime?)new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tmeAhora.DateTime.Hour, tmeAhora.DateTime.Minute, tmeAhora.DateTime.Second);
            Ruta.Save();
        }
        private void CargarTipoRuta(UnidadDeTrabajo Unidad, Int32 ID)
        {
            Servicio Servicio = Unidad.GetObjectByKey<Servicio>(ID);
            if (Servicio.EsMediaVuelta)
            {
                cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Entrada.ToString(), Enums.TipoRuta.Entrada));
                cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Salida.ToString(), Enums.TipoRuta.Salida));
            }
            else
            {
                cmbTipoRuta.Items.Add(new BootstrapListEditItem(Enums.TipoRuta.Normal.ToString(), Enums.TipoRuta.Normal));
            }
        }
    }
}