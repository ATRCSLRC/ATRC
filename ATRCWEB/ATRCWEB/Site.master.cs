using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using ATRCBASE.BL;
using DevExpress.Web;

namespace ATRCWEB
{ 
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Session.Remove("Unidad");
                Session.Remove("cmbUsuario");
                Session.Remove("cmbResponsable");
                
                Session.Remove("img");
                if(!HttpContext.Current.Request.Url.AbsoluteUri.Contains("Reporte.aspx"))
                {
                    Session.Remove("DEL");
                    Session.Remove("AL");
                }
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OidAdministrador"] != null)
            {
                

                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Usuario usuario = Unidad.GetObjectByKey<Usuario>(Session["OidAdministrador"]);
                lblUsuarioSup.InnerText = lblNombreLateral.InnerText = lblNombreDetalle.InnerText = usuario.Nombre;
                lblPuesto.InnerText = lblPuestoDetalle.InnerText = usuario.Puesto == null ? "" : usuario.Puesto.Descripcion;
                if (usuario.Imagen != null)
                    if (!string.IsNullOrEmpty(usuario.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(usuario.Imagen.Archivo);
                        System.IO.MemoryStream stream = new System.IO.MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        imgFotoSup.ContentBytes = imgFotoDetalle.ContentBytes = imgFotoLateral.ContentBytes = stream.ToArray();
                    }
            }
            else
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}