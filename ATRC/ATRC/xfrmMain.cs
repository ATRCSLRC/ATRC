
using DevExpress.Xpo;
using DevExpress.XtraBars;
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

            #region Usuario
            rbnpUsuarios.Visible = VisibilidadPermiso("Usuario") == BarItemVisibility.Always ? true : false;
            if(rbnpUsuarios.Visible)
            {
                bbiUsuarios.Visibility = VisibilidadPermiso("Usuarios");
                rbnpgReportesUsuarios.Visible = VisibilidadPermiso("ReportesUsuarios") == BarItemVisibility.Always ? true : false;
                rbnpgUsuario.Visible = bbiUsuarios.Visibility == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Checador
            rbnpChecador.Visible = VisibilidadPermiso("Checador") == BarItemVisibility.Always ? true : false;
            if (rbnpChecador.Visible)
            {
                bbiChecador.Visibility = VisibilidadPermiso("NuevaChecada");
                bbiConsultasChecada.Visibility = VisibilidadPermiso("HistorialChecador");
                bbiNotificacionesChecador.Visibility = VisibilidadPermiso("NotificacionesChecador");
                rbnpgReportesChecador.Visible = VisibilidadPermiso("ReportesChecador") == BarItemVisibility.Always ? true : false;
                rbnpgAdministracion.Visible = bbiChecador.Visibility == BarItemVisibility.Always & bbiConsultasChecada.Visibility == BarItemVisibility.Always &
                    bbiNotificacionesChecador.Visibility == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Configuracion
            rbnpConfiguracion.Visible = VisibilidadPermiso("Configuracion") == BarItemVisibility.Always ? true : false;
            if (rbnpConfiguracion.Visible)
            {
                bbiDepartamento.Visibility = VisibilidadPermiso("Departamento");
                bbiPuestos.Visibility = VisibilidadPermiso("Puesto");
                bbiEmpresa.Visibility = VisibilidadPermiso("Empresa");
                bbiTanques.Visibility = VisibilidadPermiso("Tanques");
                bbiActualizarEsquemas.Visibility = VisibilidadPermiso("ActualizarEsquemas");
                bbiActualizarPermisos.Visibility = VisibilidadPermiso("ActualizarPermisos");
                rpgMantenimiento.Visible = bbiActualizarEsquemas.Visibility == BarItemVisibility.Always & 
                    bbiActualizarPermisos.Visibility == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Almacen
            rpAlmacen.Visible = VisibilidadPermiso("Almacen") == BarItemVisibility.Always ? true : false;
            if (rpAlmacen.Visible)
            {
                bbiArticulo.Visibility = VisibilidadPermiso("NuevoArticulo");
                bbiModificar.Visibility = VisibilidadPermiso("ModificarArticulo");
                bbiBusquedaArticulos.Visibility = VisibilidadPermiso("BusquedaArticulos");
                bbiSalida.Visibility = VisibilidadPermiso("SalidaArticulos");
                bbiPrestamos.Visibility = VisibilidadPermiso("PrestamoArticulos");
                bbiBitacoraSalida.Visibility = VisibilidadPermiso("BitacorasSalidas");
                bbiInventarios.Visibility = VisibilidadPermiso("InventarioAlmacen");
                bbiMarcas.Visibility = VisibilidadPermiso("Marcas");
                bbiProveedor.Visibility = VisibilidadPermiso("Proveedor");
                bbiCodigos.Visibility = VisibilidadPermiso("CodigosArticulos");
            }
            #endregion

            #region Unidades
            rbnpUnidades.Visible = VisibilidadPermiso("Unidades") == BarItemVisibility.Always ? true : false;
            if (rbnpUnidades.Visible)
            {
                bbiUnidad.Visibility = VisibilidadPermiso("NuevaUnidad");
                bbiBusquedaUnidad.Visibility = VisibilidadPermiso("DetallesDeUnidad");
                bbiServicios.Visibility = VisibilidadPermiso("ServiciosUnidad");
                bbiRadios.Visibility = VisibilidadPermiso("Radios");
                bbiCambiosAceite.Visibility = VisibilidadPermiso("ProximosCambiosAceite");
                bbiExtintores.Visibility = VisibilidadPermiso("Extintores");
                bbiInventarioExtintores.Visibility = VisibilidadPermiso("InventarioExtintores");
                bbiHistorialInventarioExtintores.Visibility = VisibilidadPermiso("HistorialExtintores");
                rpgReportesUnidad.Visible = VisibilidadPermiso("ReportesUnidades") == BarItemVisibility.Always ? true : false;
                rpgExtintores.Visible = bbiExtintores.Visibility == BarItemVisibility.Always & bbiInventarioExtintores.Visibility == BarItemVisibility.Always
                    & bbiHistorialInventarioExtintores.Visibility == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region LLantera
            rbnpLlantera.Visible = VisibilidadPermiso("Llantera") == BarItemVisibility.Always ? true : false;
            if(rbnpLlantera.Visible)
            {
                bbiCambioLlanta.Visibility = VisibilidadPermiso("CambiosLlanta");
                bbiReparacionLlanta.Visibility = VisibilidadPermiso("ReparacionLlanta");
                rpgInventarioLlantas.Visible = VisibilidadPermiso("InventariosLlanta") == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Taller
            rbnpTaller.Visible = VisibilidadPermiso("Taller") == BarItemVisibility.Always ? true : false;
            if(rbnpTaller.Visible)
            {
                bbiBitacoraActividades.Visibility = VisibilidadPermiso("BitacoraActividadesTaller");
                bbiCapturaActividades.Visibility = VisibilidadPermiso("ActividadesTaller");
                rpgReportesTaller.Visible = VisibilidadPermiso("ReportesTaller") == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Rutas
            rbnpRutas.Visible = VisibilidadPermiso("Rutas") == BarItemVisibility.Always ? true : false;
            if(rbnpRutas.Visible)
            {
                bbiMapa.Visibility = VisibilidadPermiso("MapaRutas");
                bbiMapaEmpresa.Visibility = VisibilidadPermiso("MapaEmpresa");
                bbiChecadorRutas.Visibility = VisibilidadPermiso("ChecadorRutas");
                bbiRegistrosRutas.Visibility = VisibilidadPermiso("EntradaSalidaRutas");
            }
            #endregion

            #region Administracion
            rbnpAdministracion.Visible = VisibilidadPermiso("Administracion") == BarItemVisibility.Always ? true : false;
            if(rbnpAdministracion.Visible)
            {
                bbiChecadorAdmin.Visibility = VisibilidadPermiso("ChecadorAdministracion");
                bbiRegistrosAdmin.Visibility = VisibilidadPermiso("EntradaSalidaAdministracion");
            }
            #endregion

            #region Combustible
            rbnpCombustible.Visible = VisibilidadPermiso("Combustible") == BarItemVisibility.Always ? true : false;
            if(rbnpCombustible.Visible)
            {
                bbiDiesel.Visibility = VisibilidadPermiso("Diesel");
                bbiModificacionDiesel.Visibility = VisibilidadPermiso("ModificacionDiesel");
                bbiGasolina.Visibility = VisibilidadPermiso("Gasolina");
                bbiMedidorTanques.Visibility = VisibilidadPermiso("MedidoresTanqueCombustible");
                bbiRecargaDiesel.Visibility = VisibilidadPermiso("RecargasCombustible"); bbiMapa.Visibility = VisibilidadPermiso("MapaRutas");
                bbiDetalleCandados.Visibility = VisibilidadPermiso("DetallesCandados");
                rpgReportesCombustible.Visible = VisibilidadPermiso("ReportesCombustibles") == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Guardias
            rbnpGuardias.Visible = VisibilidadPermiso("Guardias") == BarItemVisibility.Always ? true : false;
            if(rbnpGuardias.Visible)
            {
                bbiReporteNuevo.Visibility = VisibilidadPermiso("NuevoReporte");
                bbiReportesAcciones.Visibility = VisibilidadPermiso("ReportesIndiciplina");
                bbiListaDiesel.Visibility = VisibilidadPermiso("PedidosDieselGuardias");
                bbiPedidoGasolina.Visibility = VisibilidadPermiso("PedidosGasolinaGuardias");
                rpgCombustiblesGuardias.Visible = bbiListaDiesel.Visibility == BarItemVisibility.Always & 
                    bbiPedidoGasolina.Visibility == BarItemVisibility.Always ? true : false;
            }
            #endregion

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
                case "Consumo de combustible":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.Consumo;
                    break;
                case "Recargas de combustible":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.PedidoDiesel;
                    break;
                case "Unidades con combustible":
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

        private void bbiDetalleCandados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmProblemasCandados xfrm = new COMBUSTIBLE.WIN.xfrmProblemasCandados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiModificacionDiesel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmModificarDiesel xfrm = new COMBUSTIBLE.WIN.xfrmModificarDiesel();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiActualizarPermisos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.BL.Utilerias.Permisos();
        }

        private BarItemVisibility VisibilidadPermiso(string permiso)
        {
            if (ATRCBASE.BL.Utilerias.TienePermisos(permiso))
            {
                return BarItemVisibility.Always;
            }
            else
            {
                return BarItemVisibility.Never;
            }
        }

        private void rgbiTaller_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch (e.Item.Description)
            {
                case "Actividades de taller por empleado":
                    TALLER.WIN.xfrmFiltrosTaller xfrmEmpleado = new TALLER.WIN.xfrmFiltrosTaller();
                    xfrmEmpleado.EsDiario = false;
                    xfrmEmpleado.Show();
                    break;
                case "Actividades de taller por día":
                    TALLER.WIN.xfrmFiltrosTaller xfrmDiario = new TALLER.WIN.xfrmFiltrosTaller();
                    xfrmDiario.EsDiario = true;
                    xfrmDiario.Show();
                    break;
            }
        }
    }
}
