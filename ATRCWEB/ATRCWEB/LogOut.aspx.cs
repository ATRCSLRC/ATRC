using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATRCWEB
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Session["USERNAME" + Session.SessionID] = null;
            Session["OidAdministrador"] = null;
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx", false);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}