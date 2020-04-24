using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATRCWEB
{
    public partial class AnunciosUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback)
            {
                ASPxImageSlider1.ImageContentBytesField = "Anuncio";
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio", null);
                Session["Anuncios"] = Anuncios.Count;
                //Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
                ASPxImageSlider1.DataSource = Anuncios;
                ASPxImageSlider1.DataBind();
            }
        }

        protected void pnlActualizar_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            ASPxImageSlider1.ImageContentBytesField = "Anuncio";
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio", null);
            //Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Session["Anuncios"] = Anuncios.Count;
            ASPxImageSlider1.DataSource = Anuncios;
            ASPxImageSlider1.DataBind();
            
        }

        protected void CallBackValidar_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
           
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio", null);
            if(Anuncios.Count != Convert.ToInt32(Session["Anuncios"]))
                CallBackValidar.JSProperties["cpAnunciosActualizar"] = "SI";
            else
                CallBackValidar.JSProperties["cpAnunciosActualizar"] = "NO";
        }
    }
}