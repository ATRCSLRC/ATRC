
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
        }

        private void bvbiSalir_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }

        private void bbiUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();

        }

        #region Administracion
        private void bbiDepartamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmDepartamentoGRD xfrm = new ATRCBASE.WIN.xfrmDepartamentoGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiPuestos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmPuestoGRD xfrm = new ATRCBASE.WIN.xfrmPuestoGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }
        #endregion

        private void bbiChecador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmChecador xfrm = new CHECADOR.WIN.xfrmChecador();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiNotificacionesChecador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmNotificacionesGRD xfrm = new CHECADOR.WIN.xfrmNotificacionesGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiConsultasChecada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmHistorialChecadas xfrm = new CHECADOR.WIN.xfrmHistorialChecadas();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void reporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CHECADOR.WIN.xfrmNewLogin xfrm = new CHECADOR.WIN.xfrmNewLogin();
            xfrm.ShowDialog();
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

        private void rgbiChecador_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Horas trabajadas semanales":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrm = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrm.Titulo = e.Item.Description;
                    xfrm.EsConcentrado = false;
                    xfrm.ShowDialog();
                    break;
                case "Concentrado de nómina":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrmConcentrado = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrmConcentrado.Titulo = e.Item.Description;
                    xfrmConcentrado.EsConcentrado = true;
                    xfrmConcentrado.Size = new Size(635, 240);
                    xfrmConcentrado.ShowDialog();
                    break;
            }
        }

        private void bbiActualizarEsquemas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilerias.ActualizarEsquema();
            Application.Exit();
        }

        private void bbiMarcas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmMarcasGRD xfrm = new ALMACEN.WIN.xfrmMarcasGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiMedidas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ALMACEN.WIN.xfrmMedidaGRD xfrm = new ALMACEN.WIN.xfrmMedidaGRD();
            //xfrm.ShowInTaskbar = false;
            //xfrm.ShowDialog();
        }

        private void bbiProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmProveedorGRD xfrm = new ALMACEN.WIN.xfrmProveedorGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiArticulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmArticulo xfrm = new ALMACEN.WIN.xfrmArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiBusquedaArticulos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmBusquedaArticulos xfrm = new ALMACEN.WIN.xfrmBusquedaArticulos();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmSalidaArticulo xfrm = new ALMACEN.WIN.xfrmSalidaArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiBitacoraSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmBitacoraSalidas xfrm = new ALMACEN.WIN.xfrmBitacoraSalidas();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiInventarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmInventarioGRD xfrm = new ALMACEN.WIN.xfrmInventarioGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmModificarArticulo xfrm = new ALMACEN.WIN.xfrmModificarArticulo();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiPrestamos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmPrestamoArticulos xfrm = new ALMACEN.WIN.xfrmPrestamoArticulos();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmUnidad xfrm = new UNIDADES.WIN.xfrmUnidad();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiServicios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmServicios xfrm = new UNIDADES.WIN.xfrmServicios();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiBusquedaUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmBusquedaUnidades xfrm = new UNIDADES.WIN.xfrmBusquedaUnidades();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiRadios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmRadiosGRD xfrm = new UNIDADES.WIN.xfrmRadiosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void rgbiReportesUnidades_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Servicios":
                    UNIDADES.WIN.Reportes.xfrmServicios xfrm = new UNIDADES.WIN.Reportes.xfrmServicios();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    break;
                case "Gastos por unidad":
                    UNIDADES.WIN.Reportes.xfrmGastosPorUnidad xfrmConcentrado = new UNIDADES.WIN.Reportes.xfrmGastosPorUnidad();
                    xfrmConcentrado.ShowDialog();
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
            xfrm.ShowDialog();
        }
    }
}
