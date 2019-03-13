﻿
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            rbnpConfiguracion.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) &&  ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Configuración") ? true : false;
            rpAlmacen.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) &&  ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Almacen") ? true : false;
            rbnpUnidades.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Unidades") ? true : false;
            rbnpLlantera.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Llantera") ? true : false;
            rbnpTaller.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Taller") ? true : false;
            rbnpRutas.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Rutas") ? true : false;
            rbnpAdministracion.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Administración") ? true : false;
            rbnpCombustible.Visible = !string.IsNullOrEmpty(ATRCBASE.BL.Utilerias.UsuarioActual.Modulos) && ATRCBASE.BL.Utilerias.UsuarioActual.Modulos.Contains("Combustible") ? true : false;
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
                case "Direcciones de usuarios":
                    ATRCBASE.WIN.xfrmUbicacionesEmpleados xfrmUbicaciones = new ATRCBASE.WIN.xfrmUbicacionesEmpleados();
                    xfrmUbicaciones.Show();
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

        private void bbiEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmEmpresaGRD xfrm = new ATRCBASE.WIN.xfrmEmpresaGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiActualizarEsquemas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //DevExpress.Xpo.XPView Usuarios = new DevExpress.Xpo.XPView(Unidad, typeof(ATRCBASE.BL.Usuario), "Oid;NumEmpleado;Imagen.Archivo", null);
            //Usuarios.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            //foreach (ViewRecord Usuario in Usuarios)
            //{
            //    if (Usuario["Imagen.Archivo"] != null)
            //    {
            //        byte[] image = Convert.FromBase64String(Usuario["Imagen.Archivo"].ToString());
            //        if (image != null)
            //        {
            //            System.IO.MemoryStream stream = new System.IO.MemoryStream(image);
            //            Image returnImage = Image.FromStream(stream);
            //            string f = "C:\\Users\\ATRC SISTEMAS\\Desktop\\img\\" + Usuario["NumEmpleado"].ToString() + "." + ATRCBASE.BL.Utilerias.GetExtension(returnImage).ToString();
            //            File.WriteAllBytes(f, image);
            //        }
            //    }
            //}
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

        private void bbiCodigos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmCodigoArticulos xfrm = new ALMACEN.WIN.xfrmCodigoArticulos();
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

        private void bbiMapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmRutasGRD xfrm = new RUTAS.WIN.xfrmRutasGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiMapaEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmRutasPorEmpresa xfrm = new RUTAS.WIN.xfrmRutasPorEmpresa();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiChecadorRutas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmHistorialChecadas xfrm = new CHECADOR.WIN.xfrmHistorialChecadas();
            xfrm.esConsulta = true;
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiChecadorAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmHistorialChecadas xfrm = new CHECADOR.WIN.xfrmHistorialChecadas();
            xfrm.esConsulta = true;
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRegistrosRutas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmEmpleadosLaborando xfrm = new CHECADOR.WIN.xfrmEmpleadosLaborando();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRegistrosAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmEmpleadosLaborando xfrm = new CHECADOR.WIN.xfrmEmpleadosLaborando();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bvbiContraseña_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            ATRCBASE.WIN.xfrmCambioContraseña xfrm = new ATRCBASE.WIN.xfrmCambioContraseña();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void bbiPlantillasRutasExternas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmPlantillasRutasExtrasGRD xfrm = new RUTAS.WIN.xfrmPlantillasRutasExtrasGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRutasExternas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmGenerarRutasExtras xfrm = new RUTAS.WIN.xfrmGenerarRutasExtras();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiReporteNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmNuevoReporte xfrm = new GUARDIAS.WIN.xfrmNuevoReporte();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiReportesAcciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmReportesGRD xfrm = new GUARDIAS.WIN.xfrmReportesGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiListaDiesel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmPedidoDiesel xfrm = new COMBUSTIBLE.WIN.xfrmPedidoDiesel();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiExtintores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmExtintoresGRD xfrm = new UNIDADES.WIN.xfrmExtintoresGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiInventarioExtintores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmInventarioExtintores xfrm = new UNIDADES.WIN.xfrmInventarioExtintores();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiTanques_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmTanquesCombustibleGRD xfrm = new COMBUSTIBLE.WIN.xfrmTanquesCombustibleGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiDiesel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmCapturaDiesel xfrm = new COMBUSTIBLE.WIN.xfrmCapturaDiesel();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRecargaDiesel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmRecargaDiesel xfrm = new COMBUSTIBLE.WIN.xfrmRecargaDiesel();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiMedidorTanque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmMedidores xfrm = new COMBUSTIBLE.WIN.xfrmMedidores();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void bbiGasolina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmCapturaGasolina xfrm = new COMBUSTIBLE.WIN.xfrmCapturaGasolina();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void rgbiCombustibles_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmFiltrosCombustible xfrm = new COMBUSTIBLE.WIN.xfrmFiltrosCombustible();
            switch (e.Item.Description)
            {
                case "Consumo de diesel":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.Consumo;
                    break;
                case "Recargas de combustible":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.PedidoDiesel;
                    break;
                case "Unidades con diesel":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.UnidadDiesel;
                    break;
            }
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show(); 
        }

        private void bbiHistorialInventarioExtintores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmHistorialExtintores xfrm = new UNIDADES.WIN.xfrmHistorialExtintores();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPedidoGasolina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmUnidadesGasolina xfrm = new COMBUSTIBLE.WIN.xfrmUnidadesGasolina();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
    }
}
