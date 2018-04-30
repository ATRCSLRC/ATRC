using ATRCBASE.BL;
using DevExpress.Web;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB.Reportes
{
    public partial class FiltroReporte : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsCallback & !Page.IsPostBack)
                {
                    Session["cmbUsuario"] = null;
                    dteAl.Date = dteDel.Date = DateTime.Now;
                    if (Request.QueryString.Count > 0)
                    {

                        string ID = Utilerias.DesencriptarString(Request.QueryString[0]);
                        switch (ID)
                        {
                            case "concentrado":
                                divTipoBusqueda.Visible = false;
                                titulo.InnerText = "Concentrado de nómina";
                                btnImprimir.Visible = false;
                                break;
                            case "horas":
                                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                                Session["Unidad"] = Unidad;
                                titulo.InnerText = "Horas semanales trabajadas";
                                btnImprimirConcentrado.Visible = false;
                                break;

                        }

                    }
                }
                cmbUsuario.DataBind();
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                Response.Redirect("~/PaginaIncorrecta.aspx", false);
                return;
            }
        }

        protected void CallbackReporte_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            Session["DEL"] = dteDel.Date;
            Session["AL"] = dteAl.Date;
            string ID = Utilerias.DesencriptarString(Request.QueryString[0]);
            if (ID == "concentrado")
            {
                ASPxWebControl.RedirectOnCallback("~/Reportes/Reporte.aspx?id=" + Utilerias.EncriptarString("concentrado"));
            }
                else
            {
                if (rblTipoBusqueda.SelectedIndex == 0)
                    ASPxWebControl.RedirectOnCallback("~/Reportes/Reporte.aspx?id=" + Utilerias.EncriptarString("horas") + "&US=" + Utilerias.EncriptarString("0"));
                else
                {
                    if (!string.IsNullOrEmpty(e.Parameter))
                        ASPxWebControl.RedirectOnCallback("~/Reportes/Reporte.aspx?id=" + Utilerias.EncriptarString("horas") + "&US=" + Utilerias.EncriptarString(e.Parameter));
                    else
                        e.Result = "Debe de llenar todos los campos.";
                }
            }
        }

        protected void cmbUsuario_DataBinding(object sender, EventArgs e)
        {
            if (Session["cmbUsuario"] == null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    XPView Usuarios = new XPView(Unidad, typeof(Usuario));
                    Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true),
                  new ViewProperty("Departamento", SortDirection.None, "[Departamento.Descripcion]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                  //new ViewProperty("Imagen", SortDirection.None, "[Imagen.Archivo]", false, true),
                 });
                    cmbUsuario.DataSource = Usuarios;
                    Session["cmbUsuario"] = Usuarios;
                }
            }
            else
            {
                cmbUsuario.DataSource = Session["cmbUsuario"];
            }
        }
        #endregion

        #region Metodo
        public byte[] ObtenerFoto(string Imagen)
        {
            if (!string.IsNullOrEmpty(Imagen))
            {
                byte[] image = Convert.FromBase64String(Imagen);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image);
                Image returnImage = Image.FromStream(stream);
                return stream.ToArray();
            }
            return null;

        }
        #endregion

        
    }
}