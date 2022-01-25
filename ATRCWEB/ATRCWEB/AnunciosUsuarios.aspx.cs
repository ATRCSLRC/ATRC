using ATRCBASE.BL;
using DevExpress.Data.Filtering;
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
                XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio;Publicacion;Publicacion.FechaPublicacion", new NotOperator(new NullOperator("Publicacion")));
                SortingCollection order = new SortingCollection();
                order.Add(new SortProperty("Publicacion.FechaPublicacion", DevExpress.Xpo.DB.SortingDirection.Ascending));
                order.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Ascending));
                Anuncios.Sorting = order;
                Session["Anuncios"] = Anuncios.Count;
                //Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
                ASPxImageSlider1.DataSource = Anuncios;
                ASPxImageSlider1.DataBind();
                
            }
            ASPxImageSlider1.Focus();
        }

        protected void pnlActualizar_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            ASPxImageSlider1.ImageContentBytesField = "Anuncio";
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //List<AnuncioUsuario> Anuncios = new List<AnuncioUsuario>();
            //XPCollection<PublicacionAnuncios> Publicaciones = new XPCollection<PublicacionAnuncios>(Unidad);
            //Publicaciones.Sorting.Add(new SortProperty("FechaPublicacion", DevExpress.Xpo.DB.SortingDirection.Ascending));
            //Publicaciones.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Ascending));
            //foreach (PublicacionAnuncios Publicacion in Publicaciones)
            //    Anuncios.AddRange(Publicacion.Anuncios);

            //Session["Anuncios"] = Anuncios.Count;
            //ASPxImageSlider1.DataSource = Anuncios;
            //ASPxImageSlider1.DataBind();

            
            XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio;Publicacion;Publicacion.FechaPublicacion", new NotOperator(new NullOperator("Publicacion")));
            SortingCollection order = new SortingCollection();
            order.Add(new SortProperty("Publicacion.FechaPublicacion", DevExpress.Xpo.DB.SortingDirection.Ascending));
            order.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Ascending));
            Anuncios.Sorting = order;

            //XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Anuncio", null);
            ////Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Session["Anuncios"] = Anuncios.Count;
            ASPxImageSlider1.DataSource = Anuncios;
            ASPxImageSlider1.DataBind();

        }

        protected void CallBackValidar_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
           
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Publicacion", new NotOperator(new NullOperator("Publicacion")));
            //XPView Anuncios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid", null);
            if (Anuncios.Count != Convert.ToInt32(Session["Anuncios"]))
                CallBackValidar.JSProperties["cpAnunciosActualizar"] = "SI";
            else
                CallBackValidar.JSProperties["cpAnunciosActualizar"] = "NO";
        }
    }
}