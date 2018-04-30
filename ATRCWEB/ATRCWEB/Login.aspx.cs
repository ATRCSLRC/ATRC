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

namespace ATRCWEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetFocus(spnNumUsuario);
        }

        protected void CallbackLogin_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
        UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        GroupOperator go = new GroupOperator( GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("NumEmpleado", spnNumUsuario.Text));
            go.Operands.Add(new BinaryOperator("EsAdministrativo", true));
            go.Operands.Add(new BinaryOperator("ConstraseñaDesencriptada", txtContraseña.Text));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                Session["OidAdministrador"] = Usuario.Oid;
                Utilerias.sessionID = Session.SessionID;
                FormsAuthentication.SetAuthCookie(Usuario.Nombre, false);
                if(HttpContext.Current.Request.Url.AbsoluteUri.Contains("ReturnUrl"))
                    if (HttpContext.Current.Request.Url.AbsoluteUri.Contains("Reporte") || HttpContext.Current.Request.Url.AbsoluteUri.Contains("FiltroReporte"))
                        ASPxWebControl.RedirectOnCallback("~/Default.aspx");
                    else
                        ASPxWebControl.RedirectOnCallback("~" + FormsAuthentication.GetRedirectUrl(Usuario.Nombre, false));
                else
                    ASPxWebControl.RedirectOnCallback("~/Default.aspx");
            }
            else
                e.Result = "Los datos proporcionados son incorrectos.";
        }
        
    }
}