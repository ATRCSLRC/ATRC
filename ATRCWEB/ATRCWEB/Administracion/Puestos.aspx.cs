using ATRCBASE.BL;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATRCWEB.Administracion
{
    public partial class Puestos : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = null;
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Unidad"] = Unidad;
                grdPuestos.DataBind();
            }
        }

        protected void grdPuestos_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Unidad"];
            XPCollection<Puesto> puestos = new XPCollection<Puesto>(Unidad);
            grdPuestos.DataSource = puestos;
        }

        protected void grdPuestos_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e)
        {
            if (e == null) return;
            if (e.KeyValue == null) return;
            BootstrapGridView grid = (BootstrapGridView)sender;
            Puesto Puesto = (Puesto)grid.GetRow(e.VisibleIndex);
            if (Puesto == null) return;
            BootstrapGridViewDataColumn colAcciones = (BootstrapGridViewDataColumn)grid.Columns["Acciones"];
            BootstrapButton btnModificar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnModificar");
            BootstrapButton btnEliminar = (BootstrapButton)grid.FindRowCellTemplateControl(e.VisibleIndex, colAcciones, "btnEliminar");
            btnModificar.ClientSideEvents.Click = "function(s,e){ PopupControlPuesto.Show(); lblTituloPuesto.SetText('Modificar puesto'); " +
                                                  "txtDescripcion.SetText('" + Puesto.Descripcion.Replace("\r", "").Replace("\n", "") + "'); HiddenPuesto.Set('Modificar', '" + e.VisibleIndex + "');}";
            btnEliminar.ClientSideEvents.Click = "function(s,e){ PopupControlEliminar.Show(); lblContenidoConfimacion.SetText('¿Desea eliminar el puesto " + '"' + Puesto.Descripcion.Replace("\r", "").Replace("\n", "") + '"' + " ?');" +
                                                 "HiddenPuesto.Set('Eliminar', '" + e.VisibleIndex + "');}";
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
                        Puesto NuevoPuesto = new Puesto(Unidad);
                        NuevoPuesto.Descripcion = txtDescripcion.Text;
                        NuevoPuesto.Save();
                        Unidad.CommitChanges();
                        #endregion
                        break;
                    case "Modificacion":
                        #region Modificacion
                        Puesto PuestoModificacion = null;
                        if (HiddenPuesto.Get("Modificar") != null)
                            PuestoModificacion = (Puesto)grdPuestos.GetRow(Convert.ToInt32(HiddenPuesto.Get("Modificar")));
                        if (PuestoModificacion == null) return;
                        PuestoModificacion.Descripcion = txtDescripcion.Text;
                        PuestoModificacion.Save();
                        PuestoModificacion.Session.CommitTransaction();
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        Puesto Puesto = null;
                        if (HiddenPuesto.Get("Eliminar") != null)
                            Puesto = (Puesto)grdPuestos.GetRow(Convert.ToInt32(HiddenPuesto.Get("Eliminar")));
                        if (Puesto == null) return;

                        Puesto.Delete();
                        Puesto.Session.CommitTransaction();
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