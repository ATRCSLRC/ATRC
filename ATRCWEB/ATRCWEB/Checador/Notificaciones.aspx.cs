using ATRCBASE.BL;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB.Checador
{
    public partial class Notificaciones : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsCallback)
            {

                Session["cmbUsuario"] = Session["cmbResponsable"] = null;
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdNotificaciones.DataBind();
            }
            cmbUsuario.DataBind();
            cmbResponsable.DataBind();
        }

        protected void grdNotificaciones_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            XPCollection<CHECADOR.BL.Notificaciones> Notificaciones = new XPCollection<CHECADOR.BL.Notificaciones>(Unidad);
            grdNotificaciones.DataSource = Notificaciones;
        }

        protected void grdNotificaciones_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e)
        {
            if (e == null) return;
            if (e.KeyValue == null) return;
            BootstrapGridView grid = (BootstrapGridView)sender;
            CHECADOR.BL.Notificaciones Notificacion = (CHECADOR.BL.Notificaciones)grid.GetRow(e.VisibleIndex);
            if (Notificacion == null) return;
            BootstrapGridViewDataColumn colAcciones = (BootstrapGridViewDataColumn)grid.Columns["Acciones"];
            BootstrapButton btnEliminar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnEliminar");
            string DetalleUsuario = Notificacion.Receptor == null ? " " : Notificacion.Receptor.Usuario.NumEmpleado.ToString() + " - " +  Notificacion.Receptor.Usuario.Nombre;
            btnEliminar.ClientSideEvents.Click = "function(s,e){ PopupControlEliminar.Show(); lblContenidoConfimacion.SetText('¿Desea eliminar la notificación del usuario " + '"' + DetalleUsuario + '"' + " ?');" +
                                                 "HiddenNotificacion.Set('Eliminar', '" + e.VisibleIndex + "');}";
        }

        protected void CallbackConfirmacion_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                string[] valor = e.Parameter.Split('|');
                switch (valor[0])
                {
                    case "Nuevo":
                        #region Nuevo
                        UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                        CHECADOR.BL.Notificaciones NuevaNotificacion = new CHECADOR.BL.Notificaciones(Unidad);
                        NuevaNotificacion.Receptor = CHECADOR.BL.Utilerias.ObtenerUsuarioChecadorPorID(Unidad,Convert.ToInt32(valor[1]));
                        NuevaNotificacion.Responsable = CHECADOR.BL.Utilerias.ObtenerUsuarioChecadorPorID(Unidad, Convert.ToInt32(valor[2]));
                        NuevaNotificacion.Motivo = memoObservacion.Text;
                        NuevaNotificacion.Save();
                        Unidad.CommitChanges();
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        CHECADOR.BL.Notificaciones Notificacion = null;
                        if (HiddenNotificacion.Get("Eliminar") != null)
                            Notificacion = (CHECADOR.BL.Notificaciones)grdNotificaciones.GetRow(Convert.ToInt32(HiddenNotificacion.Get("Eliminar")));
                        if (Notificacion == null) return;

                        Notificacion.Delete();
                        Notificacion.Session.CommitTransaction();
                        #endregion
                        break;
                }

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

        protected void cmbResponsable_DataBinding(object sender, EventArgs e)
        {
            if (Session["cmbResponsable"] == null)
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                if (Unidad != null)
                {
                    XPView UsuariosAdmin = new XPView(Unidad, typeof(Usuario));
                    UsuariosAdmin.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true),
                  new ViewProperty("Departamento", SortDirection.None, "[Departamento.Descripcion]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                    //new ViewProperty("Imagen", SortDirection.None, "[Imagen.Archivo]", false, true),
                });
                    UsuariosAdmin.Criteria = new BinaryOperator("EsAdministrativo", true);

                    cmbResponsable.DataSource = UsuariosAdmin;
                    Session["cmbResponsable"] = UsuariosAdmin;
                }
            }
            else
            {
                cmbResponsable.DataSource = Session["cmbResponsable"];
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