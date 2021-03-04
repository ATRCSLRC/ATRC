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
    public partial class AclaracionesAprobadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdAclaraciones.DataBind();
                grdAclaraciones.FocusedRowIndex = -1;
            }
        }

        protected void grdAclaraciones_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {

                    GroupOperator go = new GroupOperator(GroupOperatorType.Or);
                    go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoAclaraciones.Aprobada_Maquiladora));
                    go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoAclaraciones.Aprobada_Rutas));
                    go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoAclaraciones.Cambios_Realizados));

                    XPView Aclaraciones = new XPView(Unidad, typeof(AclaracionesPedido));
                    Aclaraciones.Properties.AddRange(new ViewProperty[] {
                    new ViewProperty("Oid", SortDirection.None, "[Oid]", true, true),
                    new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", true, true),
                    new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", true, true),
                    new ViewProperty("Pedido", SortDirection.None, "[Pedido]", true, true),
                    new ViewProperty("Estado", SortDirection.Ascending, "[Estado]", true, true)});
                    Aclaraciones.Criteria = go;
                    Aclaraciones.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
                    grdAclaraciones.DataSource = Aclaraciones;
                }
            }
        }

        protected void grdAclaraciones_CustomUnboundColumnData(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewColumnDataEventArgs e)
        {

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
                    HistorialPedidos.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
                    grdHistorial.DataSource = HistorialPedidos;
                    grdHistorial.DataBind();
                }

            }
        }

        protected void grdHistorial_CustomUnboundColumnData(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewColumnDataEventArgs e)
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
    }
}