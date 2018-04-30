using ATRCBASE.BL;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATRCWEB.Administracion
{
    public partial class Departamentos : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = null;
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdDepartamentos.DataBind();
            }
        }

        protected void grdDepartamentos_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            XPCollection<Departamento> depas = new XPCollection<Departamento>(Unidad);
            grdDepartamentos.DataSource = depas;
        }

        protected void grdDepartamentos_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e)
        {
            if (e == null) return;
            if (e.KeyValue == null) return;
            BootstrapGridView grid = (BootstrapGridView)sender;
            Departamento Departamento = (Departamento)grid.GetRow(e.VisibleIndex);
            if (Departamento == null) return;
            BootstrapGridViewDataColumn colAcciones = (BootstrapGridViewDataColumn)grid.Columns["Acciones"];
            BootstrapButton btnModificar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnModificar");
            BootstrapButton btnEliminar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnEliminar");
            btnModificar.ClientSideEvents.Click = "function(s,e){ PopupControlDepartamento.Show(); lblTituloDepartamento.SetText('Modificar departamento'); " + 
                                                  "txtDescripcion.SetText('" + Departamento.Descripcion + "'); HiddenDepartamento.Set('Modificar', '" + e.VisibleIndex + "');}";
            btnEliminar.ClientSideEvents.Click = "function(s,e){ PopupControlEliminar.Show(); lblContenidoConfimacion.SetText('¿Desea eliminar el departamento "+'"'+ Departamento.Descripcion + '"' +" ?');" +
                                                 "HiddenDepartamento.Set('Eliminar', '" + e.VisibleIndex + "');}";
        }

        protected void CallbackConfirmacion_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            try
            {
                switch (e.Parameter)
                {
                    case "Nuevo":
                        #region Nuevo
                        UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
                        Departamento NuevoDepartamento = new Departamento(Unidad);
                        NuevoDepartamento.Descripcion = txtDescripcion.Text;
                        NuevoDepartamento.Save();
                        Unidad.CommitChanges();
                        #endregion
                        break;
                    case "Modificacion":
                        #region Modificacion
                        Departamento departamentoModificacion = null;
                        if (HiddenDepartamento.Get("Modificar") != null)
                            departamentoModificacion = (Departamento)grdDepartamentos.GetRow(Convert.ToInt32(HiddenDepartamento.Get("Modificar")));
                        if (departamentoModificacion == null) return;
                        departamentoModificacion.Descripcion = txtDescripcion.Text;
                        departamentoModificacion.Save();
                        departamentoModificacion.Session.CommitTransaction();
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        Departamento departamento = null;
                        if (HiddenDepartamento.Get("Eliminar") != null)
                            departamento = (Departamento)grdDepartamentos.GetRow(Convert.ToInt32(HiddenDepartamento.Get("Eliminar")));
                        if (departamento == null) return;

                        departamento.Delete();
                        departamento.Session.CommitTransaction();
                        #endregion
                        break;
                }
                
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }
        #endregion
    }
}