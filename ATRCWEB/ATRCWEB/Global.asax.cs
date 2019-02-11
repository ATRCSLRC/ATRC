using System;
using System.Web;

namespace ATRCWEB {
    public class Global_asax : System.Web.HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
            ATRCBASE.BL.Utilerias.TipoAplicacion = ATRCBASE.BL.Enums.TipoAplicacion.Web;
        }

        void Application_End(object sender, EventArgs e) {
            // Code that runs on application shutdown
        }
    
        void Application_Error(object sender, EventArgs e) {
            var exception = HttpContext.Current.Server.GetLastError();
            DevExpress.Web.ASPxWebControl.SetCallbackErrorMessage(exception.Message);
            Elmah.ErrorSignal.FromCurrentContext().Raise(exception);
        }
        
        void Session_Start(object sender, EventArgs e) {
            // Code that runs when a new session is started
        }
    
        void Session_End(object sender, EventArgs e) {
            Session["OidAdministrador"] = null;
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
        
    }
}