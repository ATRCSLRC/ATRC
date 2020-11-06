using System;
using System.Linq;
using System.Web.Security;

namespace SolucionesATRC {
    public partial class Site : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page.Header.DataBind();
            // Page.ClientScript.RegisterStartupScript(this.GetType(), "onLoad", "SessionTimeout()", true);
            //Response.AddHeader("Refresh", Convert.ToString((Session.Timeout * 60) + 5));
            if (Session["OidAdministrador"] == null)
            {
                Session["USERNAME" + Session.SessionID] = null;
                Session["OidAdministrador"] = null;
                FormsAuthentication.SignOut();
            }
            //    Server.Transfer("Login.aspx");
        }

        protected void CallbackRevisar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            e.Result = true.ToString();
        }

        //[System.Web.Services.WebMethod]
        //public string OnValidarSesion()
        //{
        //    return Session["OidAdministrador"] == null ? "" : Session["OidAdministrador"].ToString();
        //}
    }
}