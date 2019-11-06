using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmUsuariosGRD : xfrmBase
    {
        public xfrmUsuariosGRD()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public int IDUsuario;

        private void xfrmUsuariosGRD_Load(object sender, EventArgs e)
        {
            bbiNuevos.Visibility = Utilerias.VisibilidadPermiso("NuevoUsuario");
            bbiModificarUsuario.Visibility = Utilerias.VisibilidadPermiso("ModificarUsuario");
            bbiReportes.Visibility = Utilerias.VisibilidadPermiso("HistorialReportesUsuario");
            bbiDesactivarEmpleado.Visibility = Utilerias.VisibilidadPermiso("ActivarDasactivarUsuario");
            bbiGafete.Visibility = Utilerias.VisibilidadPermiso("ImprimirGafete");
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                bbiAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                bbiModificarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiEliminarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiNuevos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiGafete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                rpgGafete.Visible = false;
            }
            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;NumEmpleado;Nombre;Activo;Imagen;RFC;IMSS;Puesto.Descripcion;FechaIngreso", null);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            grdUsuarios.DataSource = Usuarios;
        }

        private void bbiNuevos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmUsuario xfrm = new xfrmUsuario())
            {
                UnidadDeTrabajo UnidadNuevo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = UnidadNuevo;
                xfrm.EsNuevo = true;
                xfrm.Usuario = new Usuario(UnidadNuevo);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdUsuarios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
                using (xfrmUsuario xfrm = new xfrmUsuario())
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    xfrm.Unidad = UnidadModificar;
                    xfrm.Usuario = UnidadModificar.GetObjectByKey<Usuario>(ViewUsuario["Oid"]);
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
        }

        private void bbiEliminarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el usuario '" + Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
            }
        }

        private void bbiSalirUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void bbiAsignar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                IDUsuario = Usuario.NumEmpleado;
                this.Close();
            }
        }

        private void bbiGafete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                ATRCBASE.WIN.Reportes.GafeteFrente gafeteFrente = new ATRCBASE.WIN.Reportes.GafeteFrente(Usuario);
                gafeteFrente.CreateDocument();
                //repGafeteFrente.ShowPreviewDialog();
                ATRCBASE.WIN.Reportes.GafeteAtras gafeteAtras = new ATRCBASE.WIN.Reportes.GafeteAtras(Usuario);
                gafeteAtras.CreateDocument();
                gafeteFrente.Pages.AddRange(gafeteAtras.Pages);

                Watermark wm = new Watermark();
                wm.Image = gafeteAtras.Watermark.Image;
                wm.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
                //productReport.Pages[0].AssignWatermark(wm);
                gafeteFrente.Pages[1].AssignWatermark(wm);


                ReportPrintTool repGafete = new ReportPrintTool(gafeteFrente);
                repGafete.ShowPreview();
            }
        }

        private void bbiDesactivarEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer " + (!Usuario.Activo ? "activar" : "desactivar") + " el usuario '" + Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario.Activo = !Usuario.Activo;
                    Unidad.CommitChanges();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
            }
        }

        private void bbiReportes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Type form = Assembly.Load("GUARDIAS.WIN").GetType("GUARDIAS.WIN.xfrmReportesPorUsuario");
                MethodInfo Metodo = form.GetMethod("MostrarVentana");
                object Retorno = Metodo.Invoke(null, new object[] { Convert.ToInt32(ViewUsuario["NumEmpleado"]), ViewUsuario["Nombre"].ToString() });
            }
        }

        private void grvUsuarios_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Imagen Imagen = Unidad.GetObjectByKey<Imagen>(Convert.ToInt32(ViewUsuario["Imagen"]));
                if (Imagen != null)
                {
                    if (!string.IsNullOrEmpty(Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        peFotoUsuario.EditValue = stream.ToArray();
                    }
                    else
                        peFotoUsuario.Image = ATRCBASE.WIN.Properties.Resources.usuario_desconocido;
                }
                else
                    peFotoUsuario.Image = ATRCBASE.WIN.Properties.Resources.usuario_desconocido;

                lblDetalleFecha.Text = ViewUsuario["FechaIngreso"] == null ? "" : ((DateTime)ViewUsuario["FechaIngreso"]).ToShortDateString();
                lblDetalleUsuario.Text = ViewUsuario["NumEmpleado"].ToString() + " - " + ViewUsuario["Nombre"].ToString();
                lblIMSSDetalle.Text = ViewUsuario["IMSS"] == null ? "" : ViewUsuario["IMSS"].ToString();
                lblRFCDetalle.Text = ViewUsuario["RFC"] == null ? "" : ViewUsuario["RFC"].ToString();
                lblPuestoDetalle.Text = ViewUsuario["Puesto.Descripcion"] == null ? "" : ViewUsuario["Puesto.Descripcion"].ToString();
                ftpDetalleUsuario.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
                esiDetalleUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ftpDetalleUsuario.ShowPopup();
            }
        }

        private void ftpDetalleUsuario_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            esiDetalleUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ftpDetalleUsuario.HidePopup();
        }

        private void grvUsuarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Imagen Imagen = Unidad.GetObjectByKey<Imagen>(Convert.ToInt32(ViewUsuario["Imagen"]));
                if (Imagen != null)
                {
                    if (!string.IsNullOrEmpty(Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        peFotoUsuario.EditValue = stream.ToArray();
                    }
                    else
                        peFotoUsuario.Image = ATRCBASE.WIN.Properties.Resources.usuario_desconocido;
                }
                else
                    peFotoUsuario.Image = ATRCBASE.WIN.Properties.Resources.usuario_desconocido;

                lblDetalleFecha.Text = ViewUsuario["FechaIngreso"] == null ? "" : ((DateTime)ViewUsuario["FechaIngreso"]).ToShortDateString();
                lblDetalleUsuario.Text = ViewUsuario["NumEmpleado"].ToString() + " - " + ViewUsuario["Nombre"].ToString();
                lblIMSSDetalle.Text = ViewUsuario["IMSS"] == null ? "" : ViewUsuario["IMSS"].ToString();
                lblRFCDetalle.Text = ViewUsuario["RFC"] == null ? "" : ViewUsuario["RFC"].ToString();
                lblPuestoDetalle.Text = ViewUsuario["Puesto.Descripcion"] == null ? "" : ViewUsuario["Puesto.Descripcion"].ToString();
                ftpDetalleUsuario.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
                esiDetalleUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ftpDetalleUsuario.ShowPopup();
            }
        }
    }
}
