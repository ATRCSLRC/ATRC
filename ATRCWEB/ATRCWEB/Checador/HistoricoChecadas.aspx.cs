using ATRCBASE.BL;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB.Checador
{
    public partial class HistoricoChecadas : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Session["cmbUsuario"] = null;
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                dteDel.Date = dteAl.Date = DateTime.Now;
            }
            cmbUsuario.DataBind();
        }

        protected void grdChecadas_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", dteDel.Date.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", dteAl.Date.Date, BinaryOperatorType.LessOrEqual));
            if (rblTipoBusqueda.SelectedIndex == 1 & Session["Usuario"] != null)
                go.Operands.Add(new BinaryOperator("Usuario", CHECADOR.BL.Utilerias.ObtenerUsuarioChecadorPorID(Unidad, Convert.ToInt32(Session["Usuario"]))));
            XPCollection<CHECADOR.BL.HistoricoChecadas> Checadas = new XPCollection<CHECADOR.BL.HistoricoChecadas>(Unidad, go);
            grdChecadas.DataSource = Checadas;
            
        }

        protected void grdChecadas_CustomGroupDisplayText(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewColumnDisplayTextEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.DisplayText))
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                UsuarioChecador Usuario = (UsuarioChecador)CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(e.DisplayText));
                e.DisplayText = e.DisplayText + " - " + Usuario.Usuario.Nombre + "     Horas trabajadas: " + CHECADOR.BL.Utilerias.HorasTrabajadas(Unidad, Usuario, dteDel.Date, dteAl.Date);
            }
        }

        protected void grdChecadas_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            int visibleIndex = Convert.ToInt32(e.Parameters);
            int count = 0;
            for (int i = 0; i < visibleIndex; i++)
                if (grdChecadas.GetRowLevel(i) > 0)
                    count++;
            grdChecadas.CollapseAll();
            grdChecadas.ExpandRow(visibleIndex - count);
        }
        
        protected void CallbackChecada_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            Session["Usuario"] = e.Parameter;
        }

        protected void grdChecadas_ParseValue(object sender, DevExpress.Web.Data.ASPxParseValueEventArgs e)
        {
            if(e.FieldName == "HoraChecadaEntrada" || e.FieldName == "HoraChecadaSalida")
                e.Value = Convert.ToDateTime(e.Value).TimeOfDay;
        }

        protected void grdChecadas_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            CHECADOR.BL.HistoricoChecadas checada = Unidad.GetObjectByKey<CHECADOR.BL.HistoricoChecadas>(e.Keys[0]);
            if ((TimeSpan)e.OldValues[1] != (TimeSpan)e.NewValues[1])
                checada.TipoIdentificacionEntrada = Enums.TipoIdentificacion.Manual;
            if((e.OldValues[2] == null ? null :(TimeSpan?)e.OldValues[2]) != (((TimeSpan)e.NewValues[2]).Ticks == 0 ? null : (TimeSpan?)e.NewValues[2]))
                checada.TipoIdentificacionSalida = Enums.TipoIdentificacion.Manual;
            checada.HoraChecadaEntrada = (TimeSpan)e.NewValues[1];
            checada.HoraChecadaSalida = ((TimeSpan)e.NewValues[2]).Ticks == 0 ? null : (TimeSpan?)e.NewValues[2];
            checada.Motivo =  e.NewValues[3] == null ? string.Empty : e.NewValues[3].ToString();
            checada.FechaChecada = (DateTime)e.NewValues[0];
            checada.Save();
            Unidad.CommitChanges();
            e.Cancel = true;
            grdChecadas.CancelEdit();
        }

        protected void grdChecadas_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            CHECADOR.BL.HistoricoChecadas checada = Unidad.GetObjectByKey<CHECADOR.BL.HistoricoChecadas>(e.Keys[0]);
            checada.Delete();
            Unidad.CommitChanges();
            e.Cancel = true;
            grdChecadas.CancelEdit();
        }

        protected void grdChecadas_CellEditorInitialize(object sender, DevExpress.Web.Bootstrap.BootstrapGridViewEditorEventArgs e)
        {
            if (grdChecadas.IsNewRowEditing) return;
            if (e.Column.FieldName == "HoraChecadaEntrada" || e.Column.FieldName == "HoraChecadaSalida")
            {
                if (e.Editor.Value != null)
                {
                    DateTime nuevo = new DateTime(((TimeSpan)e.Editor.Value).Ticks);
                    e.Editor.Value = nuevo;
                }
            }
                
        }

        protected void CallbackDetalles_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            if (!string.Equals(e.Parameter, ","))
            {
                string[] ID = e.Parameter.Split(',');
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                CHECADOR.BL.HistoricoChecadas Historico = Unidad.GetObjectByKey<CHECADOR.BL.HistoricoChecadas>(Convert.ToInt32(ID[0]));
                lblFecha.InnerText = Historico.FechaChecada.ToLongDateString();
                lblNombre.InnerText = Historico.Usuario.Usuario.NumEmpleado + " - " + Historico.Usuario.Usuario.Nombre;
                lblDel.InnerText = Historico.HoraChecadaEntrada.ToString();
                lblAl.InnerText = Historico.HoraChecadaSalida.ToString();
                lblHoras.InnerText = Historico.HoraChecadaCalculadaSalida > 0 & Historico.HoraChecadaCalculadaEntrada > 0 ? (Historico.HoraChecadaCalculadaSalida - Historico.HoraChecadaCalculadaEntrada).ToString() : "0";

                if (Historico.Usuario.Usuario.Imagen != null)
                    if (!string.IsNullOrEmpty(Historico.Usuario.Usuario.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(Historico.Usuario.Usuario.Imagen.Archivo);
                        System.IO.MemoryStream stream = new System.IO.MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        imgFoto.Value = stream.ToArray();
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