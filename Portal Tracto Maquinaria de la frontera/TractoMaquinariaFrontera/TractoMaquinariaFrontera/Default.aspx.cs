using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TractoMaquinariaFrontera {
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void CallbackEnviar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            string[] parametro = e.Parameter.Split('|');
            string contenido = CrearMensaje(parametro[0], parametro[1], parametro[2], parametro[3]);
            bool resultado = EnviarCorreo("tractomaquinariasdelafrontera@gmail.com", "Portal Tractomaquinarias del norte" , contenido);
            if (!resultado)
                e.Result =  "Error";
        }

        private string CrearMensaje(string Nombre, string Correo,string Asunto, string mensaje)
        {
            string contenido;

            if (System.DateTime.Now.Hour < 12)
                contenido = "Buenos días ";
            else
            {
                if (System.DateTime.Now.Hour < 18)
                    contenido = "Buenas tardes ";
                else
                    contenido = "Buenas noches ";
            }

            contenido += "<br/> El cliente " + Nombre + ", con correo " + Correo + " y número de teléfono " + Asunto + ".";
            contenido += "<br/> Dejo el siguiente mensaje: <br/>" + mensaje;
            return contenido;
        }
        private bool EnviarCorreo( string Destinatario, string Asunto, string Mensaje)
        {
            try
            {
                #region Variables para configuracion
                string correoAutenticacionConfig = "tractomaquinariasdelafrontera@gmail.com";
                string correoAutenticacionPassConfig = "@TRCSistemas1";
                string correoHostConfig = "relay-hosting.secureserver.net";
                string correoHostPortConfig = "25";
                #endregion
                
                #region Modificacion de formato del mensaje
                Mensaje = Mensaje.Replace("\n", "<br/>");
                //Mensaje = Mensaje.Replace("\r", "");
                #endregion
                
                MailMessage msg = new MailMessage();
                if (!string.IsNullOrWhiteSpace(Destinatario)) msg.To.Add(new MailAddress(Destinatario)); else throw new InvalidOperationException("El Destinatario no puede estar vacio");
                    
                msg.Body = Mensaje;
                if (Mensaje.Replace(" ", "").Contains("<br/>") || Mensaje.Replace(" ", "").Contains("<b>") || Mensaje.Replace(" ", "").Contains("<p>") || Mensaje.Replace(" ", "").Contains("</a>") || Mensaje.Replace(" ", "").Contains("<table"))
                    msg.IsBodyHtml = true;

                msg.From = new MailAddress(correoAutenticacionConfig, "", System.Text.Encoding.UTF8);
                msg.Subject = Asunto;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                // Configuración SMTP
                SmtpClient mailSmtp = new SmtpClient();
                mailSmtp.Host = correoHostConfig;
                System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential(correoAutenticacionConfig, correoAutenticacionPassConfig);
                mailSmtp.UseDefaultCredentials = false;
                mailSmtp.Credentials = mailAuthentication;
                //mailSmtp.EnableSsl = true;
                mailSmtp.Port = Convert.ToInt32(correoHostPortConfig);
                mailSmtp.Send(msg);
                return true;
            }
            catch (SmtpException ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return false;
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return false;
            }
        }

    }
}