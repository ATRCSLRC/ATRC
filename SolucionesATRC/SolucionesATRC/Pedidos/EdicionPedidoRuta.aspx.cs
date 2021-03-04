using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC.Pedidos
{
    public partial class EdicionPedidoRuta : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsCallback || !Page.IsPostBack)
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    PedidoRutas Pedido = null;
                    if (Request.QueryString.Count > 0)
                    {
                        string id = ATRCBASE.BL.Utilerias.DesencriptarString(Request.QueryString[0].ToString());
                        Pedido = Unidad.GetObjectByKey<PedidoRutas>(Convert.ToInt32(id));
                        txtNombre.Text = Pedido.Nombre;
                        dteFechaPedido.Date = Pedido.Fecha;
                    }
                    else
                    {
                        Pedido = new PedidoRutas(Unidad);
                    }
                    Session["Pedido"] = Pedido;
                    Session["Unidad"] = Unidad;
                    Session["DocumentoRuta"] = null;
                    Session["NombreDocumentoRuta"] = null;
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

        protected void CallbackGuardarRutas_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (Session["Pedido"] != null)
            {
                string[] Parametro = e.Parameter.Split('|');

                PedidoRutas Pedido = Session["Pedido"] as PedidoRutas;
                RutasDePedido Ruta;

                switch (Parametro[0])
                {
                    case "EditRow":
                    case "FocusedRowContext":
                        Ruta = grdRutas.GetRow(grdRutas.FocusedRowIndex) as RutasDePedido;
                        GurdarRuta(Ruta, Parametro[1]);
                        Pedido.Rutas.Add(Ruta);
                        break;
                    case "DeleteRow":
                        Ruta = grdRutas.GetRow(grdRutas.FocusedRowIndex) as RutasDePedido;
                        Pedido.Rutas.Remove(Ruta);
                        break;
                    default:
                        Ruta = new RutasDePedido(Pedido.Session);
                        GurdarRuta(Ruta, Parametro[1]);
                        Pedido.Rutas.Add(Ruta);
                        break;
                }

                Session["Pedido"] = Pedido;
            }
        }

        protected void CallbackGuararPedido_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (Session["Pedido"] != null)
            {
                PedidoRutas Pedido = Session["Pedido"] as PedidoRutas;
                Pedido.Nombre = txtNombre.Text;
                Pedido.Fecha = dteFechaPedido.Date;
                Pedido.Save();
                Pedido.Session.CommitTransaction();
            }
        }

        protected void grdRutas_DataBinding(object sender, EventArgs e)
        {
            if (Session["Pedido"] != null)
            {
                PedidoRutas Pedido = Session["Pedido"] as PedidoRutas;
                grdRutas.DataSource = Pedido.Rutas;
                Session["DocumentoRuta"] = null;
                Session["NombreDocumentoRuta"] = null;
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

        protected void cmbTipoRuta_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                Servicio Servicio = (Session["Unidad"] as UnidadDeTrabajo).GetObjectByKey<Servicio>(Convert.ToInt32(cmbServicio.Value));
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

        protected void cmbTurno_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                XPView Servicios = new XPView(Session["Unidad"] as UnidadDeTrabajo, typeof(Turno), "Oid;Descripcion", null);
                cmbTurno.DataSource = Servicios;
            }
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

        protected void PanelRuta_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            RutasDePedido Ruta = grdRutas.GetRow(Convert.ToInt32(e.Parameter)) as RutasDePedido;
            //txtRuta.Text = Ruta.Ruta;
            //chkRutaExtra.Checked = Ruta.EsRutaExtra;
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

            if(Ruta.Turno != null)
                cmbTurno.Value = Ruta.Turno.Oid;
            if (Ruta.HoraEntrada != null)
                tmeHoraDe.DateTime = (DateTime)Ruta.HoraEntrada;
            if(Ruta.HoraSalida != null)
                tmeAhora.DateTime = (DateTime)Ruta.HoraSalida;
        }

        private void GurdarRuta(RutasDePedido Ruta, string TipoRuta)
        {

            Ruta.Ruta = "Extra";
            Ruta.EsApoyo = false;
            Ruta.EsRutaExtra = true;
            Ruta.Documento = Session["DocumentoRuta"] as byte[];
            Ruta.NombreDocumento = Session["NombreDocumentoRuta"] as string;
            Ruta.Servicio = Ruta.Session.GetObjectByKey<Servicio>(cmbServicio.Value);
            Ruta.TipoRuta = (Enums.TipoRuta)Enum.Parse(typeof(Enums.TipoRuta), TipoRuta);
            Ruta.Turno = Ruta.Session.GetObjectByKey<Turno>(cmbTurno.Value);
            Ruta.HoraEntrada = tmeHoraDe.Value is null ? null : (DateTime?)new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tmeHoraDe.DateTime.Hour, tmeHoraDe.DateTime.Minute, tmeHoraDe.DateTime.Second); 
            Ruta.HoraSalida = tmeAhora.Value is null ? null : (DateTime?)new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, tmeAhora.DateTime.Hour, tmeAhora.DateTime.Minute, tmeAhora.DateTime.Second);
            Ruta.Save();
            Session["DocumentoRuta"] = null;
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

        protected void grdPlantillas_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("PlantillaRutas.EsExterno", true));
                    go.Operands.Add(new BinaryOperator("PlantillaRutas.Empresa.Oid", 1));
                    XPView Pedidos = new XPView(Unidad, typeof(PlantillaRutaFija), "Oid;Ruta;OrdenRutas;TipoRuta;EsRutaExtra;EsApoyo;Servicio.Descripcion;" +
                        "Turno.Descripcion;HoraEntrada;HoraSalida;PlantillaRutas.Nombre ", go);
                    Pedidos.Sorting = new SortingCollection(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
                    grdPlantillas.DataSource = Pedidos;
                }
            }
        }

        protected void CallbackPlantilla_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (Session["Pedido"] != null)
            {
                PedidoRutas Pedido = Session["Pedido"] as PedidoRutas;
                string[] IDS = e.Parameter.Split(',');

                foreach (string ID in IDS)
                {
                    PlantillaRutaFija PlantillaRuta = Pedido.Session.GetObjectByKey<PlantillaRutaFija>(Convert.ToInt32(ID)) as PlantillaRutaFija;

                    RutasDePedido Ruta = new RutasDePedido(Pedido.Session);
                    Ruta.Ruta = PlantillaRuta.Ruta;
                    Ruta.EsRutaExtra = PlantillaRuta.EsRutaExtra;
                    Ruta.EsApoyo = PlantillaRuta.EsApoyo;
                    Ruta.ChoferEntrada = PlantillaRuta.ChoferEntrada;
                    Ruta.ChoferSalida = PlantillaRuta.ChoferSalida;
                    Ruta.PagarChoferEntrada = PlantillaRuta.PagarChoferEntrada;
                    Ruta.PagarChoferSalida = PlantillaRuta.PagarChoferSalida;
                    Ruta.Servicio = PlantillaRuta.Servicio;
                    Ruta.TipoRuta = PlantillaRuta.TipoRuta;
                    Ruta.Turno = PlantillaRuta.Turno;
                    Ruta.HoraEntrada = PlantillaRuta.HoraEntrada;
                    Ruta.HoraSalida = PlantillaRuta.HoraSalida;
                    Ruta.RutaCompleta = PlantillaRuta.RutaCompleta;
                    Ruta.Comentarios = PlantillaRuta.Comentarios;
                    Ruta.ComentariosFacturacion = PlantillaRuta.ComentariosFacturacion;
                    Ruta.Save();
                    Pedido.Rutas.Add(Ruta);
                }





                //------------------------------------------
                //ViewRecord ViewPlantilla = grdPlantillas.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
                //PlantillaRutas Plantilla = ViewPlantilla.GetObject() as PlantillaRutas;
                //foreach (PlantillaRutaFija RutaPlantilla in Plantilla.PlantillasRutasFijas)
                //{

                //    RutasDePedido Ruta = new RutasDePedido(Pedido.Session);
                //    Ruta.Ruta = RutaPlantilla.Ruta;
                //    Ruta.EsRutaExtra = RutaPlantilla.EsRutaExtra;
                //    Ruta.Servicio = RutaPlantilla.Servicio;
                //    Ruta.TipoRuta = RutaPlantilla.TipoRuta;
                //    Ruta.Turno = RutaPlantilla.Turno;
                //    Ruta.HoraEntrada = RutaPlantilla.HoraEntrada;
                //    Ruta.HoraSalida = RutaPlantilla.HoraSalida;
                //    Ruta.Save();
                //    Pedido.Rutas.Add(Ruta);
                //}
                Session["Pedido"] = Pedido;
            }
        }

        protected void grdPlantillas_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            string[] parameters = e.Parameters.Split(';');
            int index = int.Parse(parameters[0]);
            bool isGroupRowSelected = bool.Parse(parameters[1]);
            for (int i = 0; i < grdPlantillas.GetChildRowCount(index); i++)
            {
                ViewRecord row = (ViewRecord)grdPlantillas.GetChildRow(index, i);
                grdPlantillas.Selection.SetSelectionByKey(row["Oid"], isGroupRowSelected);
            }
        }

        protected void grdPlantillas_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType == GridViewRowType.Group)
            {
                BootstrapCheckBox checkBox = grdPlantillas.FindGroupRowTemplateControl(e.VisibleIndex, "chkGrupo") as BootstrapCheckBox;
                if (checkBox != null)
                {
                    checkBox.ClientSideEvents.CheckedChanged = string.Format("function(s, e){{ grdPlantillas.PerformCallback('{0};' + s.GetChecked()); }}", e.VisibleIndex);
                    checkBox.Checked = GetChecked(e.VisibleIndex);
                }
            }
        }

        protected bool GetChecked(int visibleIndex)
        {
            for (int i = 0; i < grdPlantillas.GetChildRowCount(visibleIndex); i++)
            {
                bool isRowSelected = grdPlantillas.Selection.IsRowSelectedByKey(((ViewRecord)grdPlantillas.GetChildRow(visibleIndex, i))["Oid"]);
                if (!isRowSelected)
                    return false;
            }
            return true;
        }

        protected string GetCaptionText(GridViewGroupRowTemplateContainer container)
        {
            string captionText = !string.IsNullOrEmpty(container.Column.Caption) ? container.Column.Caption : container.Column.FieldName;
            return string.Format("{0} : {1} {2}", captionText, container.GroupText, container.SummaryText);
        }

        protected void UploadDocumento_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            UploadedFile uploadedFile = e.UploadedFile;
            string fileName = uploadedFile.FileName;
            Session["DocumentoRuta"] = uploadedFile.FileBytes;
            Session["NombreDocumentoRuta"] = fileName;
            e.CallbackData = fileName;
        }

        protected void btnDescargar_Init(object sender, EventArgs e)
        {
            BootstrapButton btn = (BootstrapButton)sender;
            GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)btn.NamingContainer;
            btn.JSProperties.Add("cpVisibleIndex", templateContainer.VisibleIndex);
        }

        protected void CallbackDescargar_Callback(object source, CallbackEventArgs e)
        {
            RutasDePedido Ruta = grdRutas.GetRow(Convert.ToInt32(e.Parameter)) as RutasDePedido;
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                Session["Descargar"] = Ruta.Documento;
                Session["NombreDocumentoRuta"] = Ruta.NombreDocumento;
            }
        }
    }
}