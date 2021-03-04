using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CallbackLogin_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Correo", email.Value));
            go.Operands.Add(new BinaryOperator("Activo", true));
            go.Operands.Add(new BinaryOperator("EsExterno", true));
            //go.Operands.Add(new BinaryOperator("ConstraseñaDesencriptada", pass.Value));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                Session["OidAdministrador"] = Usuario.Oid;
                Utilerias.sessionID = Session.SessionID;
                FormsAuthentication.SetAuthCookie(Usuario.Nombre, false);
                if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("ReturnUrl"))
                    if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("Reporte") || HttpContext.Current.Request.Url.AbsoluteUri.Contains("FiltroReporte"))
                        ASPxWebControl.RedirectOnCallback("~/Default.aspx");
                    else
                        ASPxWebControl.RedirectOnCallback("~" + FormsAuthentication.GetRedirectUrl(Usuario.Nombre, false));
                else
                    ASPxWebControl.RedirectOnCallback("~/Default.aspx");

            }
            else
                e.Result = "Los datos proporcionados son incorrectos.";

            //Session["OidAdministrador"] = 1d;
            //Utilerias.sessionID = Session.SessionID;
            //FormsAuthentication.SetAuthCookie("1", false);
            //ASPxWebControl.RedirectOnCallback("~/Default.aspx");
        }
    }
}