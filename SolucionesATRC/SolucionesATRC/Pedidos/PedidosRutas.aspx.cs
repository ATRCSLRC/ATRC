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
using System.Web.UI.WebControls;

namespace SolucionesATRC
{
    public partial class PedidosRutas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.Header.DataBind();
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdPedidos.DataBind();
                grdPedidos.FocusedRowIndex = -1;
            }
        }

        protected void grdPedidos_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    GroupOperator GoEmpresa = new GroupOperator(GroupOperatorType.And);
                    GroupOperator Go = new GroupOperator(GroupOperatorType.Or);
                    Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Creado));
                    Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Enviado));
                    Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Revision));
                    Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Pendiente));
                    GoEmpresa.Operands.Add(Go);
                    GoEmpresa.Operands.Add(new BinaryOperator("Empresa", 1));
                    

                    XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
                    Pedidos.AddProperty("Oid", "Oid", true);
                    Pedidos.AddProperty("Nombre", "Nombre", true);
                    Pedidos.AddProperty("Estado", "Estado", true);
                    Pedidos.AddProperty("FechaPedido", "Fecha", true);
                    Pedidos.AddProperty("Fecha", "FechaAlta", true);
                    Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
                    Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
                    Pedidos.Criteria = GoEmpresa;
                    grdPedidos.DataSource = Pedidos;
                }

            }
        }

        protected void CallbackRedireccionar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(e.Parameter))
                {
                    ViewRecord viewRuta = grdPedidos.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
                    e.Result = ATRCBASE.BL.Utilerias.EncriptarString(viewRuta["Oid"].ToString());
                }else
                {
                    e.Result = "";
                }
            }
            catch (Exception exc)
            {
                //Elmah.ErrorSignal.FromCurrentContext().Raise(exc);
                e.Result = "";
            }
}

        protected void CallbackEliminar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            ViewRecord viewRuta = grdPedidos.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            PedidoRutas Pedido = (PedidoRutas)viewRuta.GetObject();
            Pedido.Delete();
            Pedido.Session.CommitTransaction();
        }

        protected void grdPedidos_CustomUnboundColumnData(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewColumnDataEventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (e.Column.FieldName == "UsuarioCreacion")
                {
                    //ViewRecord viewPedido = grdPedidos.GetRow(e.ListSourceRowIndex) as ViewRecord;
                    //if (viewPedido != null)
                    //{
                    Usuario Usuario = Unidad.GetObjectByKey<Usuario>(e.GetListSourceFieldValue("Usuario"));
                    if (Usuario != null)
                    {
                        e.Value = Usuario.Nombre;
                    }
                    else
                        e.Value = string.Empty;
                    //}else
                    //{

                    //}
                }
            }
        }

        protected void grdHistorial_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            ViewRecord viewRuta = grdPedidos.GetRow(Convert.ToInt32(e.Parameters)) as ViewRecord;
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    XPView HistorialPedidos = new XPView(Unidad, typeof(RUTAS.BL.HistorialPedidoRutas));
                    HistorialPedidos.AddProperty("Oid", "Oid", true);
                    HistorialPedidos.AddProperty("Nombre", "Nombre", true);
                    HistorialPedidos.AddProperty("Estado", "Estado", true);
                    HistorialPedidos.AddProperty("HorarioModificacion", "HorarioModificacion", true);
                    HistorialPedidos.AddProperty("Usuario", "Usuario.Nombre", true);
                    HistorialPedidos.Criteria = new BinaryOperator("PedidoRutas", viewRuta["Oid"]);
                    grdHistorial.DataSource = HistorialPedidos;
                    grdHistorial.DataBind();
                }

            }
        }

        protected void btnDescargar_Init(object sender, EventArgs e)
        {
            BootstrapButton btn = (BootstrapButton)sender;
            GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)btn.NamingContainer;
            btn.JSProperties.Add("cpVisibleIndex", templateContainer.VisibleIndex);
        }

        protected void CallbackDescargar_Callback(object source, CallbackEventArgs e)
        {
            ViewRecord viewRuta = grdPedidos.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    e.Result = ATRCBASE.BL.Utilerias.EncriptarString(viewRuta["Oid"].ToString());
                }
            }
        }

        protected void CallbackEnviar_Callback(object source, CallbackEventArgs e)
        {
            ViewRecord viewRuta = grdPedidos.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            PedidoRutas Pedido = (PedidoRutas)viewRuta.GetObject();
            Pedido.Estado = Enums.EstadoPedidoRutas.Enviado;
            Pedido.Save();
            Pedido.Session.CommitTransaction();
            RUTAS.BL.Utilerias.EnviarCorreoMaquiladora(Pedido);
        }
    }
}