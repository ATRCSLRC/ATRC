﻿using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC.Pedidos
{
    public partial class MisPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                dteDel.Date = dteAl.Date = DateTime.Now;
            }
           
        }

        protected void grdPedidos_CustomUnboundColumnData(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewColumnDataEventArgs e)
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

        protected void CallbackDescargar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
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

        protected void btnDescargar_Init(object sender, EventArgs e)
        {
            BootstrapButton btn = (BootstrapButton)sender;
            GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)btn.NamingContainer;
            btn.JSProperties.Add("cpVisibleIndex", templateContainer.VisibleIndex);
        }

        protected void grdPedidos_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            grdPedidos.DataBind();
        }

        protected void grdHistorial_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    GroupOperator Go = new GroupOperator(GroupOperatorType.And);
                    Go.Operands.Add(new BinaryOperator("Empresa", 1));
                    Go.Operands.Add(new BetweenOperator("Fecha", dteDel.Date, dteAl.Date));
                    XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
                    Pedidos.AddProperty("Oid", "Oid", true);
                    Pedidos.AddProperty("Nombre", "Nombre", true);
                    Pedidos.AddProperty("Estado", "Estado", true);
                    Pedidos.AddProperty("FechaPedido", "Fecha", true);
                    Pedidos.AddProperty("Fecha", "FechaAlta", true);
                    Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
                    Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
                    Pedidos.Criteria = Go;
                    grdPedidos.DataSource = Pedidos;
                    //grdPedidos.DataBind();
                }

            }
        }

        protected void grdPedidos_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    GroupOperator Go = new GroupOperator(GroupOperatorType.And);
                    Go.Operands.Add(new BinaryOperator("Empresa", 1));
                    Go.Operands.Add(new BetweenOperator("Fecha", dteDel.Date, dteAl.Date));
                    XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
                    Pedidos.AddProperty("Oid", "Oid", true);
                    Pedidos.AddProperty("Nombre", "Nombre", true);
                    Pedidos.AddProperty("Estado", "Estado", true);
                    Pedidos.AddProperty("FechaPedido", "Fecha", true);
                    Pedidos.AddProperty("Fecha", "FechaAlta", true);
                    Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
                    Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
                    Pedidos.Criteria = Go;
                    grdPedidos.DataSource = Pedidos;
                    //grdPedidos.DataBind();
                }

            }
        }
    }
}