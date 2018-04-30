using ATRCBASE.BL;
using CHECADOR.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB.Checador
{
    public partial class Checador : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsCallback)
            {
                Session["cmbUsuario"] = null;
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                tdeFecha.Date = DateTime.Now;
            }
            cmbUsuario.DataBind();
        }

        protected void CallbackChecador_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                string[] valor = e.Parameter.Split('|');
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecadorPorID(Unidad ,Convert.ToInt32(valor[0]));
                CHECADOR.BL.Utilerias.CrearChecada(tdeFecha.Date, tmeEntrada.DateTime.TimeOfDay, tmeSalida.DateTime.TimeOfDay,
                    tmeEntrada.Value == null ? false : true, tmeSalida.Value == null ? false : true, memoObservacion.Text, Usuario, Unidad);
                Unidad.CommitChanges();
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
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