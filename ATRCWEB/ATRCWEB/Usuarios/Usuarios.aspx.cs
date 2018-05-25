using ATRCBASE.BL;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB.Usuarios
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsCallback)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdUsuarios.DataBind();
                XPCollection<Departamento> Departamentos = new XPCollection<Departamento>(Unidad);
                XPCollection<Puesto> Puestos = new XPCollection<Puesto>(Unidad);
                cmbDepartamento.DataSource = Departamentos;
                cmbDepartamento.DataBind();
                cmbPuestos.DataSource = Puestos;
                cmbPuestos.DataBind();
                cmbPatron.DataSource = new string[] { "AutoTransportes del Río Colorado S.A. de C.V.", "Recursos Profesionales Integrados S.C." };
                cmbPatron.DataBind();
            }
            
        }

        protected void CallbackUsuario_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                switch (e.Parameter)
                {
                    case "Nuevo":
                        #region Nuevo
                        UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                        Usuario NuevoUsuario = new Usuario(Unidad);
                        NuevoUsuario.EsAdministrativo = chkAdmistrador.Checked;
                        NuevoUsuario.NumEmpleado = Convert.ToInt32(txtNumEmpleado.Text);
                        NuevoUsuario.Nombre = txtNombre.Text;
                        NuevoUsuario.RFC = txtRFC.Text;
                        NuevoUsuario.IMSS = txtIMSS.Text;
                        NuevoUsuario.Puesto = Unidad.GetObjectByKey<Puesto>(Convert.ToInt32(cmbPuestos.Value));
                        NuevoUsuario.Departamento = Unidad.GetObjectByKey<Departamento>(Convert.ToInt32(cmbDepartamento.Value));
                        if(!string.IsNullOrEmpty(txtCredencial.Text))
                            NuevoUsuario.IDCard = Convert.ToInt32(txtCredencial.Text);
                        NuevoUsuario.FechaIngreso = dteIngreso.Date;
                        NuevoUsuario.Patron = cmbPatron.Text;
                        NuevoUsuario.AvisarA = txtAvisarA.Text;
                        NuevoUsuario.TelAvisarA = txtTelefono.Text;
                        NuevoUsuario.TipoSangre = txtTipoSangre.Text;
                        if(NuevoUsuario.EsAdministrativo)
                            NuevoUsuario.Constraseña = txtContraseña.Text;

                        NuevoUsuario.Imagen = new Imagen(Unidad);
                        NuevoUsuario.Imagen.Archivo = bniFoto.Value == null ? string.Empty : Convert.ToBase64String((Byte[])bniFoto.Value);
                        NuevoUsuario.Imagen.Save();

                        NuevoUsuario.Save();
                        Unidad.CommitChanges();
                        Session["img"] = null;
                        #endregion
                        break;
                    case "Modificacion":
                        #region Modificacion
                        Usuario UsuarioModificacion = null;
                        if (HiddenUsuario.Get("Modificar") != null)
                        {
                            ViewRecord ViewUsuario = (ViewRecord)grdUsuarios.GetRow(Convert.ToInt32(HiddenUsuario.Get("Modificar")));
                            UsuarioModificacion = (Usuario)ViewUsuario.GetObject();
                        }
                        if (UsuarioModificacion == null) return;
                        UsuarioModificacion.EsAdministrativo = chkAdmistrador.Checked;
                        UsuarioModificacion.Nombre = txtNombre.Text;
                        UsuarioModificacion.RFC = txtRFC.Text;
                        UsuarioModificacion.IMSS = txtIMSS.Text;
                        UsuarioModificacion.Puesto = UsuarioModificacion.Session.GetObjectByKey<Puesto>(Convert.ToInt32(cmbPuestos.Value));
                        UsuarioModificacion.Departamento = UsuarioModificacion.Session.GetObjectByKey<Departamento>(Convert.ToInt32(cmbDepartamento.Value));
                        if (!string.IsNullOrEmpty(txtCredencial.Text))
                            UsuarioModificacion.IDCard = Convert.ToInt32(txtCredencial.Text);
                        UsuarioModificacion.FechaIngreso = dteIngreso.Date;
                        UsuarioModificacion.Patron = cmbPatron.Text;
                        UsuarioModificacion.AvisarA = txtAvisarA.Text;
                        UsuarioModificacion.TelAvisarA = txtTelefono.Text;
                        UsuarioModificacion.TipoSangre = txtTipoSangre.Text;
                        if(UsuarioModificacion.EsAdministrativo)
                            UsuarioModificacion.Constraseña = txtContraseña.Text;

                        if (UsuarioModificacion.Imagen == null)
                        {
                            UsuarioModificacion.Imagen = new Imagen(UsuarioModificacion.Session);
                            UsuarioModificacion.Imagen.Archivo = bniFoto.Value == null ? string.Empty : Convert.ToBase64String((Byte[])bniFoto.Value);
                            UsuarioModificacion.Imagen.Save();
                        } else
                        {
                            UsuarioModificacion.Imagen.Archivo = bniFoto.Value == null ? string.Empty : Convert.ToBase64String((Byte[])bniFoto.Value);
                        }
                        UsuarioModificacion.Save();
                        UsuarioModificacion.Session.CommitTransaction();
                        Session["img"] = null;
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        Usuario Usuario = null;
                        if (HiddenUsuario.Get("Eliminar") != null)
                        {
                            ViewRecord ViewUsuario = (ViewRecord)grdUsuarios.GetRow(Convert.ToInt32(HiddenUsuario.Get("Eliminar")));
                            Usuario = (Usuario)ViewUsuario.GetObject();
                        }
                            
                        if (Usuario == null) return;

                        Usuario.Delete();
                        Usuario.Session.CommitTransaction();
                        Session["img"] = null;
                        #endregion
                        break;
                    case "Cancelar":
                        Session["img"] = null;
                        break;
                }

            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }

        protected void grdUsuarios_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            if (Unidad != null)
            {
                XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;NumEmpleado;Nombre", null);
                grdUsuarios.DataSource = Usuarios;
            }
        }

        protected void grdUsuarios_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e)
        {
            if (e == null) return;
            if (e.KeyValue == null) return;
            BootstrapGridView grid = (BootstrapGridView)sender;
            ViewRecord ViewUsuario = (ViewRecord)grid.GetRow(e.VisibleIndex);
            Usuario Usuario = (Usuario)ViewUsuario.GetObject();
            if (Usuario == null) return;
            BootstrapGridViewDataColumn colAcciones = (BootstrapGridViewDataColumn)grid.Columns["Acciones"];
            BootstrapButton btnModificar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnModificar");
            BootstrapButton btnImprimir = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnImprimir");
            BootstrapButton btnEliminar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnEliminar");
            string adm = Usuario.EsAdministrativo ? "true" : "false";
            btnModificar.ClientSideEvents.Click = "function(s,e){ pgcUsuario.SetActiveTabIndex(0); txtNombre.SetIsValid(true); txtRFC.SetIsValid(true); txtIMSS.SetIsValid(true); cmbPuestos.SetIsValid(true); cmbDepartamento.SetIsValid(true);" +
                                                  "PopupControlUsuario.Show(); lblTituloNotificacion.SetText('Modificar usuario'); bniFoto.PerformCallback('" + e.VisibleIndex + "'); chkAdmistrador.SetChecked(" + adm + "); var mytab = pgcUsuario.GetTab(2); mytab.SetVisible(" + adm + "); " +
                                                  "txtNumEmpleado.SetText('" + Usuario.NumEmpleado + "'); txtContraseña.SetText('" + Usuario.ConstraseñaDesencriptada + "'); txtNombre.SetText('" + Usuario.Nombre + "'); txtRFC.SetText('" + Usuario.RFC + "'); txtIMSS.SetText('" + Usuario.IMSS + "'); " +
                                                  "txtCredencial.SetText('" + Usuario.IDCard + "'); var puesto = '" + Convert.ToString(Usuario.Puesto == null ? -1 : Usuario.Puesto.Oid) + "'; if(puesto == -1){cmbPuestos.SetSelectedIndex(puesto);}else{ cmbPuestos.SetValue(puesto);} " +
                                                  "var departamento = '" + Convert.ToString(Usuario.Departamento == null ? -1 : Usuario.Departamento.Oid) + "'; if(departamento == -1){cmbDepartamento.SetSelectedIndex(departamento);}else{ cmbDepartamento.SetValue(departamento);} " +
                                                  "var myDate = new Date('"+ Usuario.FechaIngreso.Year + "', '"+ Usuario.FechaIngreso.Month + "', '"+ Usuario.FechaIngreso.Minute + "'); dteIngreso.SetValue(myDate); cmbPatron.SetText('" + Usuario.Patron + "'); txtAvisarA.SetText('"+ Usuario.AvisarA + "'); txtTipoSangre.SetText('"+ Usuario.TipoSangre +"');  " +
                                                  "HiddenUsuario.Set('Modificar', '" + e.VisibleIndex + "');  txtTelefono.SetText('" + Usuario.TelAvisarA + "'); bniFoto.PerformCallback()}";
            btnImprimir.ClientSideEvents.Click = "function(s,e){ window.location.href = '../Reportes/Reporte.aspx?id=" + Utilerias.EncriptarString("gafete") +"&US=" + Utilerias.EncriptarString(Usuario.Oid.ToString()) +"';}";
            btnEliminar.ClientSideEvents.Click = "function(s,e){ PopupControlEliminar.Show(); lblContenidoConfimacion.SetText('¿Desea eliminar al usuario " + '"' + Usuario.NumEmpleado + " - " + Usuario.Nombre + '"' + " ?');" +
                                                 "HiddenUsuario.Set('Eliminar', '" + e.VisibleIndex + "');}";
        }
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

        protected void CallbackNumEmpleado_Callback(object sender, DevExpress.Web.CallbackEventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            e.Result = Utilerias.NumEmpleado(Unidad);
        }
        public byte[] ObtenerFoto()
        {
            Usuario UsuarioModificacion = null;
            if (HiddenUsuario.Get("Modificar") != null)
            {
                ViewRecord ViewUsuario = (ViewRecord)grdUsuarios.GetRow(Convert.ToInt32(HiddenUsuario.Get("Modificar")));
                UsuarioModificacion = (Usuario)ViewUsuario.GetObject();
                if (UsuarioModificacion.Imagen != null)
                    if (!string.IsNullOrEmpty(UsuarioModificacion.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(UsuarioModificacion.Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        return stream.ToArray();
                    }
            }
            return null;
        }

        protected void bniFoto_CustomCallback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (!string.IsNullOrEmpty(e.Parameter))
            {
                ViewRecord ViewUsuario = (ViewRecord)grdUsuarios.GetRow(Convert.ToInt32(e.Parameter));
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                if (Usuario.Imagen != null)
                    if (!string.IsNullOrEmpty(Usuario.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(Usuario.Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        Session["img"] = stream.ToArray();
                        return;
                    }
                Session["img"] = null;
            }

            if (Session["img"] != null)
                bniFoto.ContentBytes = (Byte[])Session["img"];
            else
                bniFoto.ContentBytes = null;
        }
    }
}