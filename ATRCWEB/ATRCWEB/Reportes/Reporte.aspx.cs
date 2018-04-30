using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATRCWEB.Reportes
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!Page.IsCallback || !Page.IsPostBack)
                {
                    if (Request.QueryString.Count > 0)
                    {
                        string ID = Utilerias.DesencriptarString(Request.QueryString[0]);
                        switch (ID)
                        {
                            case "concentrado":
                                if (Session["DEL"] != null & Session["AL"] != null)
                                {
                                    Viewer.OpenReport(new Reportes.ConcentradoNomina((DateTime)Session["DEL"], (DateTime)Session["AL"]));
                                }
                                break;
                            case "horas":
                                if (Session["DEL"] != null & Session["AL"] != null)
                                {
                                    Viewer.OpenReport(new Reportes.HorasSemanalesTrabajadas(Convert.ToInt32(Utilerias.DesencriptarString(Request.QueryString[1])), (DateTime)Session["DEL"], (DateTime)Session["AL"]));
                                }
                                break;
                            case "usuario":
                                Viewer.OpenReport(new Reportes.Usuarios());
                                break;
                            case "gafete":
                                Viewer.Visible = false;
                                pgcGafete.ClientVisible = true;
                                string IDUsuario = Utilerias.DesencriptarString(Request.QueryString[1]);
                                Usuario Usuario = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo().GetObjectByKey<Usuario>(Convert.ToInt32(IDUsuario));
                                if (Usuario != null)
                                {
                                    ViewerGafeteFrontal.OpenReport(new Reportes.GafeteFrente(Usuario));
                                    ViewerGafeteTrasero.OpenReport(new Reportes.GafeteAtras(Usuario));
                                }
                                break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                Response.Redirect("~/PaginaIncorrecta.aspx", false);
                return;
            }       
        }
    }
}