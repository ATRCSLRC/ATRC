using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SolucionesATRC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
            ATRCBASE.BL.Utilerias.TipoAplicacion = ATRCBASE.BL.Enums.TipoAplicacion.Web;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = this.Server.GetLastError();
            //if (exception.HResult == -2147467259)
            //{
            //    Response.Redirect("Login.aspx");
            //}



            DevExpress.Web.ASPxWebControl.SetCallbackErrorMessage(exception.Message);
            Elmah.ErrorSignal.FromCurrentContext().Raise(exception);
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Response.RedirectToRoute("Login.aspx");
            Session["OidAdministrador"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Session["USERNAME" + Session.SessionID] = null;
            Session["OidAdministrador"] = null;
            FormsAuthentication.SignOut();
            //Response.Redirect("~/Login.aspx", false);
            //Session["OidAdministrador"] = null;
            //Response.Redirect("Login.aspx");
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            //if (Context.Handler is IRequiresSessionState || Context.Handler is IReadOnlySessionState)
            //{
            //    if (Session.Count > 0)
            //    {
            //        if (!Context.Request.Url.AbsoluteUri.Contains("/Login.aspx"))
            //        {

            //            if (Session["OidAdministrador"] == null)
            //            {
            //                Response.Redirect("Login.aspx");
            //            }
            //        }
            //    }
            //}
            //if ((Session.Count == 0) &&
            //   !(Request.Url.AbsolutePath.EndsWith("default.aspx",
            //     StringComparison.InvariantCultureIgnoreCase)))
            //{
            //    Response.Redirect("~/default.aspx");
            //}
        }
    }
}