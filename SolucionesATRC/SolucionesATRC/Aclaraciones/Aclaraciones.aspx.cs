using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SolucionesATRC.Aclaraciones
{
    public partial class Aclaraciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                dteDel.Date = dteAl.Date = DateTime.Now;
                //grdAclaraciones.DataBind();
                //grdAclaraciones.FocusedRowIndex = -1;
            }
        }

        protected void grdAclaraciones_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    GroupOperator Go = new GroupOperator(GroupOperatorType.And);
                    Go.Operands.Add(new BinaryOperator("Pedido.Empresa.Oid", 1));
                    Go.Operands.Add(new BetweenOperator("FechaAlta", dteDel.Date, dteAl.Date));

                    XPView Aclaraciones = new XPView(Unidad, typeof(AclaracionesPedido));
                    Aclaraciones.Properties.AddRange(new ViewProperty[] {
                    new ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", true, true),
                    new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", true, true),
                    new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", true, true),
                    new ViewProperty("Pedido", SortDirection.None, "[Pedido]", true, true),
                    new ViewProperty("EmpresaNombre", SortDirection.None, "[Pedido.Empresa.Nombre]", true, true),
                    new ViewProperty("Estado", SortDirection.Ascending, "[Estado]", true, true)});
                    Aclaraciones.Criteria = Go;
                    grdAclaraciones.DataSource = Aclaraciones;
                }
            }
        }


        protected void btnDescargar_Init(object sender, EventArgs e)
        {
            BootstrapButton btn = (BootstrapButton)sender;
            GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)btn.NamingContainer;
            btn.JSProperties.Add("cpVisibleIndex", templateContainer.VisibleIndex);
        }

        protected void grdHistorial_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            ViewRecord viewRuta = grdAclaraciones.GetRow(Convert.ToInt32(e.Parameters)) as ViewRecord;
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    XPView HistorialPedidos = new XPView(Unidad, typeof(RUTAS.BL.HistorialAclaracionesPedido));
                    HistorialPedidos.AddProperty("Oid", "Oid", true);
                    HistorialPedidos.AddProperty("Descripcion", "Descripcion", true);
                    HistorialPedidos.AddProperty("Estado", "Estado", true);
                    HistorialPedidos.AddProperty("FechaAlta", "FechaAlta", true);
                    HistorialPedidos.AddProperty("Usuario", "UsuarioAlta", true);
                    HistorialPedidos.Criteria = new BinaryOperator("AclaracionPedido", viewRuta["Oid"]);
                    grdHistorial.DataSource = HistorialPedidos;
                    grdHistorial.DataBind();
                }

            }
        }

        protected void CallbackDescargar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            ViewRecord viewRuta = grdAclaraciones.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    string ID = ATRCBASE.BL.Utilerias.EncriptarString(viewRuta["Oid"].ToString());
                    string Apartado = ATRCBASE.BL.Utilerias.EncriptarString("Aclaracion");
                    e.Result = ID + "&Apart=" + Apartado;
                }
            }
        }

        protected void CallbackEnviar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            ViewRecord viewRuta = grdAclaraciones.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            AclaracionesPedido Aclaracion = (AclaracionesPedido)viewRuta.GetObject();
            Aclaracion.Estado = Enums.EstadoAclaraciones.Aprobada_Maquiladora;
            Aclaracion.Motivo = "Se aprobo la aclaración.";
            Aclaracion.Save();
            Aclaracion.Session.CommitTransaction();
            //RUTAS.BL.Utilerias.EnviarCorreoMaquiladora(Pedido);
        }

        protected void grdHistorial_CustomUnboundColumnData(object sender, BootstrapGridViewColumnDataEventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (e.Column.FieldName == "UsuarioCreacion")
                {
                    Usuario Usuario = Unidad.GetObjectByKey<Usuario>(e.GetListSourceFieldValue("Usuario"));
                    if (Usuario != null)
                    {
                        e.Value = Usuario.Nombre;
                    }
                    else
                        e.Value = string.Empty;
                }

                //if (e.Column.FieldName == "EstadoAclaracion")
                //{
                //    bool Maquiladora = (bool)e.GetListSourceFieldValue("EnviadoPorMaquiladora");
                //    e.Value = ((Enums.EstadoAclaraciones)e.GetListSourceFieldValue("Estado")).ToString() + (!Maquiladora ? " Maquiladora" : " Rutas");
                //}
            }
        }

        protected void CallbackNueva_Callback(object source, CallbackEventArgs e)
        {
            //if (Session["Unidad"] != null)
            //{
            //    UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            //    AclaracionesPedido Aclaracion = new AclaracionesPedido(Unidad);
            //    Aclaracion.Descripcion = MemoDescripcion.Text;
            //    Aclaracion.Estado = Enums.EstadoAclaraciones.Creado_Maquiladora;
            //    Unidad.CommitChanges();
            //}
        }

        protected void grdAclaraciones_CustomUnboundColumnData(object sender, BootstrapGridViewColumnDataEventArgs e)
        {
            //if (Session["Unidad"] != null)
            //{
            //    UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            //    if (e.Column.FieldName == "EstadoAclaracion")
            //    {
            //        bool Maquiladora = (bool)e.GetListSourceFieldValue("EnviadoPorMaquiladora");
            //        e.Value = ((Enums.EstadoAclaraciones)e.GetListSourceFieldValue("Estado")).ToString() + (!Maquiladora ? " Maquiladora" : " Rutas");
            //    }
            //}
        }

        protected void CallbackRevisar_Callback(object source, CallbackEventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                ViewRecord viewRuta = grdAclaraciones.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
                AclaracionesPedido Aclaracion = (AclaracionesPedido)viewRuta.GetObject();
                Aclaracion.Estado = Enums.EstadoAclaraciones.Revision_Maquiladora;
                Aclaracion.Motivo = "Se en revisión la aclaración.";
                Aclaracion.Save();
                Aclaracion.Session.CommitTransaction();
            }
        }

        protected void CallbackRechazar_Callback(object source, CallbackEventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                ViewRecord viewRuta = grdAclaraciones.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
                AclaracionesPedido Aclaracion = (AclaracionesPedido)viewRuta.GetObject();
                Aclaracion.Estado = Enums.EstadoAclaraciones.Rechazada_Maquiladora;
                Aclaracion.Motivo = "Se rechazo la aclaración.";
                Aclaracion.Save();
                Aclaracion.Session.CommitTransaction();
            }
        }

        protected void grdAclaraciones_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            grdAclaraciones.DataBind();
        }
    }
}