using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC.Plantilla
{
    public partial class PlantillaRutas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdPlantillas.DataBind();
                grdPlantillas.FocusedRowIndex = -1;
            }
        }

        protected void grdPlantillas_DataBinding(object sender, EventArgs e)
        {
            if (Session["Unidad"] != null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PlantillaRutas));
                    Pedidos.AddProperty("Oid", "Oid", true);
                    Pedidos.AddProperty("Nombre", "Nombre", true);
                    Pedidos.AddProperty("Rutas", "PlantillasRutasFijas.Count()", false);
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("EsExterno", true));
                    Pedidos.Criteria = go;
                    grdPlantillas.DataSource = Pedidos;
                }
            }
        }

        protected void CallbackRedireccionar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.Parameter))
                {
                    ViewRecord viewRuta = grdPlantillas.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
                    e.Result = Utilerias.EncriptarString(viewRuta["Oid"].ToString());
                }
                else
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
            ViewRecord viewRuta = grdPlantillas.GetRow(Convert.ToInt32(e.Parameter)) as ViewRecord;
            RUTAS.BL.PlantillaRutas Pedido = (RUTAS.BL.PlantillaRutas)viewRuta.GetObject();
            Pedido.Delete();
            Pedido.Session.CommitTransaction();
        }
    }
}