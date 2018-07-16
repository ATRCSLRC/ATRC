
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRC
{
    public partial class xfrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public xfrmMain()
        {
            InitializeComponent();
        }

        private void xfrmMain_Load(object sender, EventArgs e)
        {
            bbiUsuario.Caption = "Usuario : " + ATRCBASE.BL.Utilerias.UsuarioActual.Nombre;
            rbnpUsuarios.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Usuarios") ? true : false;
            rbnpChecador.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Checador") ? true : false;
            rbnpAdministracion.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) &&  ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Administración") ? true : false;
            rpAlmacen.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) &&  ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Almacen") ? true : false;
            rbnpUnidades.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Unidades") ? true : false;
            rbnpLlantera.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Llantera") ? true : false;
            rbnpTaller.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Taller") ? true : false;
        }

        private void bvbiSalir_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }

        #region Usuarios
        private void bbiUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();

        }

        private void rgbiUsuarios_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Usuarios registrados":
                    ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new ATRCBASE.WIN.Reportes.Usuarios());
                    repUsuarioRegistrado.ShowPreview();
                    break;
            }
        }

        #endregion

        #region Administracion
        private void bbiDepartamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmDepartamentoGRD xfrm = new ATRCBASE.WIN.xfrmDepartamentoGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPuestos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmPuestoGRD xfrm = new ATRCBASE.WIN.xfrmPuestoGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiActualizarEsquemas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilerias.ActualizarEsquema();
            Application.Exit();
        }
        #endregion

        #region Checador
        private void bbiChecador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmChecador xfrm = new CHECADOR.WIN.xfrmChecador();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiNotificacionesChecador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmNotificacionesGRD xfrm = new CHECADOR.WIN.xfrmNotificacionesGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiConsultasChecada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmHistorialChecadas xfrm = new CHECADOR.WIN.xfrmHistorialChecadas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void reporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CHECADOR.WIN.xfrmNewLogin xfrm = new CHECADOR.WIN.xfrmNewLogin();
            xfrm.Show();
        }

        private void rgbiChecador_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Horas trabajadas semanales":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrm = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrm.Titulo = e.Item.Description;
                    xfrm.EsConcentrado = false;
                    xfrm.MdiParent = this;
                    xfrm.Show();
                    break;
                case "Concentrado de nómina":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrmConcentrado = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrmConcentrado.Titulo = e.Item.Description;
                    xfrmConcentrado.EsConcentrado = true;
                    xfrmConcentrado.Size = new Size(635, 240);
                    xfrmConcentrado.MdiParent = this;
                    xfrmConcentrado.Show();
                    break;
            }
        }

        #endregion

        #region Almacen
        private void bbiMarcas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmMarcasGRD xfrm = new ALMACEN.WIN.xfrmMarcasGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiMedidas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ALMACEN.WIN.xfrmMedidaGRD xfrm = new ALMACEN.WIN.xfrmMedidaGRD();
            //xfrm.ShowInTaskbar = false;
            //xfrm.Show();
        }

        private void bbiProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmProveedorGRD xfrm = new ALMACEN.WIN.xfrmProveedorGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiArticulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmArticulo xfrm = new ALMACEN.WIN.xfrmArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiBusquedaArticulos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmBusquedaArticulos xfrm = new ALMACEN.WIN.xfrmBusquedaArticulos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmSalidaArticulo xfrm = new ALMACEN.WIN.xfrmSalidaArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiBitacoraSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmBitacoraSalidas xfrm = new ALMACEN.WIN.xfrmBitacoraSalidas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiInventarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmInventarioGRD xfrm = new ALMACEN.WIN.xfrmInventarioGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmModificarArticulo xfrm = new ALMACEN.WIN.xfrmModificarArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPrestamos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmPrestamoArticulos xfrm = new ALMACEN.WIN.xfrmPrestamoArticulos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
        #endregion

        #region Unidades
        private void bbiUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmUnidad xfrm = new UNIDADES.WIN.xfrmUnidad();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiServicios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmServicios xfrm = new UNIDADES.WIN.xfrmServicios();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiBusquedaUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmBusquedaUnidades xfrm = new UNIDADES.WIN.xfrmBusquedaUnidades();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRadios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmRadiosGRD xfrm = new UNIDADES.WIN.xfrmRadiosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void rgbiReportesUnidades_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Servicios":
                    UNIDADES.WIN.Reportes.xfrmServicios xfrm = new UNIDADES.WIN.Reportes.xfrmServicios();
                    xfrm.ShowInTaskbar = false;
                    xfrm.MdiParent = this;
                    xfrm.Show();
                    break;
                case "Gastos por unidad":
                    UNIDADES.WIN.Reportes.xfrmGastosPorUnidad xfrmConcentrado = new UNIDADES.WIN.Reportes.xfrmGastosPorUnidad();
                    xfrmConcentrado.MdiParent = this;
                    xfrmConcentrado.Show();
                    break;
                case "Radios":
                    ReportPrintTool repRadios = new ReportPrintTool(new REPORTES.Unidades.Radios());
                    repRadios.ShowPreview();
                    break;
            }
        }

        private void bbiCambiosAceite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmCambiosAceite xfrm = new UNIDADES.WIN.xfrmCambiosAceite();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        #endregion

        private void bbiCambioLlanta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LLANTERA.WIN.xfrmCambioLlanta xfrm = new LLANTERA.WIN.xfrmCambioLlanta();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void rgbiLlantas_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Detalle de cambios de llantas":
                    LLANTERA.WIN.xfrmDetallesCambioDeLlanta xfrm = new LLANTERA.WIN.xfrmDetallesCambioDeLlanta();
                    xfrm.ShowInTaskbar = false;
                    xfrm.MdiParent = this;
                    xfrm.Show();
                    break;
                case "Detalles de reparación de llantas":
                    LLANTERA.WIN.xfrmDetallesLlantasParchadas xfrmLlantasParchadas = new LLANTERA.WIN.xfrmDetallesLlantasParchadas();
                    xfrmLlantasParchadas.ShowInTaskbar = false;
                    xfrmLlantasParchadas.MdiParent = this;
                    xfrmLlantasParchadas.Show();
                    break;
            }
        }

        private void bbiReparacionLlanta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LLANTERA.WIN.xfrmLlantasParchadas xfrm = new LLANTERA.WIN.xfrmLlantasParchadas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiBitacoraActividades_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TALLER.WIN.xfrmSeleccionEmpleados xfrm = new TALLER.WIN.xfrmSeleccionEmpleados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiCapturaActividades_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TALLER.WIN.xfrmCapturaActividades xfrm = new TALLER.WIN.xfrmCapturaActividades();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
    }
}
