﻿
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Saraff.Twain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRC
{
    public partial class xfrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Regex MailRegex = new Regex(@"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$",
        RegexOptions.Compiled);
        public xfrmMain()
        {
            InitializeComponent();
        }

        private void xfrmMain_Load(object sender, EventArgs e)
        {
            //Se revisa la version
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            string version = assemblyName.Version.ToString();

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                this.Text = "Auto Transportes del Río Colorado - " + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            else
                this.Text = "Auto Transportes del Río Colorado - " + version;
            #region Usuario
            rbnpUsuarios.Visible = VisibilidadPermiso("Usuario") == BarItemVisibility.Always ? true : false;
            if(rbnpUsuarios.Visible)
            {
                bbiUsuarios.Visibility = VisibilidadPermiso("Usuarios");
                bbiAnunciosUsuarios.Visibility = VisibilidadPermiso("AnunciosUsuario");
                bbiAccesos.Visibility = VisibilidadPermiso("AccesosUsuario");
                bbiHistorialAccesos.Visibility = VisibilidadPermiso("HistorialAccesosUsuario");
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
                rbnpgAdministracion.Visible = bbiChecador.Visibility == BarItemVisibility.Always || bbiConsultasChecada.Visibility == BarItemVisibility.Always ||
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
                bbiHistorialHerramientaPrestada.Visibility = VisibilidadPermiso("HistorialPrestamoHerramienta");
                bbiBitacoraSalida.Visibility = VisibilidadPermiso("BitacorasSalidas");
                bbiInventarios.Visibility = VisibilidadPermiso("InventarioAlmacen");
                bbiMarcas.Visibility = VisibilidadPermiso("Marcas");
                bbiProveedor.Visibility = VisibilidadPermiso("Proveedor");
                bbiCodigos.Visibility = VisibilidadPermiso("CodigosArticulos");
                rpgConfiguracion.Visible = VisibilidadPermiso("ImpresoraTicketAlmacen") == BarItemVisibility.Always ? true : false;
                rpgInventario.Visible = bbiInventarios.Visibility == BarItemVisibility.Always || bbiBitacoraSalida.Visibility == BarItemVisibility.Always;
                rpgCatalogo.Visible = bbiMarcas.Visibility == BarItemVisibility.Always || bbiProveedor.Visibility == BarItemVisibility.Always || bbiCodigos.Visibility == BarItemVisibility.Always;

                if (rpgConfiguracion.Visible)
                {
                    foreach (string Impresora in PrinterSettings.InstalledPrinters)
                    {
                        repositoryItemComboBox1.Items.Add(Impresora);
                    }

                    ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ImpresoraTicketsAlmacen"));
                    if (Configuracion != null)
                        beiImpresoraAlmacen.EditValue = Configuracion.Accion;
                }
            }
            #endregion

            #region Unidades
            rbnpUnidades.Visible = VisibilidadPermiso("Unidades") == BarItemVisibility.Always ? true : false;
            if (rbnpUnidades.Visible)
            {
                bbiUnidad.Visibility = VisibilidadPermiso("NuevaUnidad");
                bbiBusquedaUnidad.Visibility = VisibilidadPermiso("DetallesDeUnidad");
                bbiUnidadesFueraServicio.Visibility = VisibilidadPermiso("FueraServicioUnidad");
                bbiServicios.Visibility = VisibilidadPermiso("ServiciosUnidad");
                bbiRadios.Visibility = VisibilidadPermiso("Radios");
                bbiCambiosAceite.Visibility = VisibilidadPermiso("ProximosCambiosAceite");
                bbiExtintores.Visibility = VisibilidadPermiso("Extintores");
                bbiInventarioExtintores.Visibility = VisibilidadPermiso("InventarioExtintores");
                bbiHistorialInventarioExtintores.Visibility = VisibilidadPermiso("HistorialExtintores");
                bbiBaterias.Visibility = VisibilidadPermiso("InventarioBaterias");
                bbiHistorialBaterias.Visibility = VisibilidadPermiso("HistorialBaterias");
                bbiUnidadesDisponibles.Visibility = VisibilidadPermiso("UnidadesDisponibles");
                rpgReportesUnidad.Visible = VisibilidadPermiso("ReportesUnidades") == BarItemVisibility.Always ? true : false;
                rpgExtintores.Visible = bbiExtintores.Visibility == BarItemVisibility.Always & bbiInventarioExtintores.Visibility == BarItemVisibility.Always
                    & bbiHistorialInventarioExtintores.Visibility == BarItemVisibility.Always ? true : false;
                rpgBaterias.Visible = bbiBaterias.Visibility == BarItemVisibility.Always & bbiHistorialBaterias.Visibility == BarItemVisibility.Always ? true : false;
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
                rpgRutas.Visible = bbiMapa.Visibility == BarItemVisibility.Always || bbiMapaEmpresa.Visibility == BarItemVisibility.Always ? true : false;

                bbiChecadorRutas.Visibility = VisibilidadPermiso("ChecadorRutas");
                bbiRegistrosRutas.Visibility = VisibilidadPermiso("EntradaSalidaRutas");
                rpgChecadorRutas.Visible = bbiChecadorRutas.Visibility == BarItemVisibility.Always || bbiRegistrosRutas.Visibility == BarItemVisibility.Always ? true : false;

                bbiRutasExternas.Visibility = VisibilidadPermiso("GenerarRutas");
                bbiPlantillasRutasExternas.Visibility = VisibilidadPermiso("PlantillasRutas");
                bbiTurnos.Visibility = VisibilidadPermiso("Turnos");
                bbiServiciosRutas.Visibility = VisibilidadPermiso("ServiciosRutas");
                bbiPrecioServicio.Visibility = VisibilidadPermiso("PreciosServicios");
                bbiImportarRutas.Visibility = VisibilidadPermiso("ImportacionRutas");
                bbiServiciosRealizados.Visibility = VisibilidadPermiso("ServiciosRealizados");
                bbiReportesServicios.Visibility = VisibilidadPermiso("ConsultaReportesServicios");
                bbiHistorialRutasGeneradas.Visibility = VisibilidadPermiso("HistorialRutasGeneradas");
                bbiPublicarRutas.Visibility = VisibilidadPermiso("PublicarRutas");
                rpgReportesRutas.Visible = VisibilidadPermiso("ReportesRutas") == BarItemVisibility.Always ? true : false;
                rpgConfiguracionRutas.Visible = VisibilidadPermiso("ConfiguracionRutas") == BarItemVisibility.Always ? true : false;

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
                bbiNuevaRecarga.Visibility = VisibilidadPermiso("NuevaRecargaCombustible");
                bbiRecargaDiesel.Visibility = VisibilidadPermiso("RecargasCombustible");
                bbiMapa.Visibility = VisibilidadPermiso("MapaRutas");
                bbiDetalleCandados.Visibility = VisibilidadPermiso("DetallesCandados");
                bbiModificarGasolina.Visibility = VisibilidadPermiso("ModificacionGasolina");
                bbiCalculosCarga.Visibility = VisibilidadPermiso("CalculoCargosDiesel");
                bbiCalculosCargaGasolina.Visibility = VisibilidadPermiso("CalculoCargosGasolina");
                rpgReportesCombustible.Visible = VisibilidadPermiso("ReportesCombustibles") == BarItemVisibility.Always ? true : false;
            }
            #endregion

            #region Guardias
            rbnpGuardias.Visible = VisibilidadPermiso("Guardias") == BarItemVisibility.Always ? true : false;
            if(rbnpGuardias.Visible)
            {
                bbiReporteNuevo.Visibility = VisibilidadPermiso("NuevoReporte");
                bbiReportesAcciones.Visibility = VisibilidadPermiso("ReportesIndiciplina");
                rpgReportesGuardias.Visible = bbiReporteNuevo.Visibility == BarItemVisibility.Always ||
                    bbiReportesAcciones.Visibility == BarItemVisibility.Always ? true : false;
                bbiListaDiesel.Visibility = VisibilidadPermiso("PedidosDieselGuardias");
                bbiPedidoGasolina.Visibility = VisibilidadPermiso("PedidosGasolinaGuardias");
                rpgCombustiblesGuardias.Visible = bbiListaDiesel.Visibility == BarItemVisibility.Always || 
                    bbiPedidoGasolina.Visibility == BarItemVisibility.Always ? true : false;
                bbiNuevoRecibo.Visibility = VisibilidadPermiso("NuevoRecibo");
                bbiRecibos.Visibility = VisibilidadPermiso("RecibosPago");
                rpgRecibosPago.Visible = bbiNuevoRecibo.Visibility == BarItemVisibility.Always &
                    bbiRecibos.Visibility == BarItemVisibility.Always ? true : false;

                bbiContrato.Visibility = VisibilidadPermiso("NuevoContrato");
                bbiAbonar.Visibility = VisibilidadPermiso("AbonarContrato");
                bbiEntregaUnidad.Visibility = VisibilidadPermiso("EntregarUnidad");
                bbiRecibirUnidadRentada.Visibility = VisibilidadPermiso("RecibirUnidad");
                bbiContratos.Visibility = VisibilidadPermiso("Contratos");
                bbiCalendarioRentas.Visibility = VisibilidadPermiso("CalendarioRentas");
                bbiHistorialRentas.Visibility = VisibilidadPermiso("HistorialRentas");
                bbiClientesRenta.Visibility = VisibilidadPermiso("NuevoReporte");

                rpgRentas.Visible = bbiContrato.Visibility == BarItemVisibility.Always || bbiAbonar.Visibility == BarItemVisibility.Always ||
                    bbiContratos.Visibility == BarItemVisibility.Always || bbiClientesRenta.Visibility == BarItemVisibility.Always || bbiHistorialRentas.Visibility == BarItemVisibility.Always ? true : false;

                beiEscanerGuardias.Visibility = VisibilidadPermiso("EscanerGuardias");
                beiEscanerOficina.Visibility = VisibilidadPermiso("EscanerOficina");
                bbiUnidadesRenta.Visibility = VisibilidadPermiso("UnidadesRenta");

                rpgConfiguracionGuardias.Visible = beiEscanerGuardias.Visibility == BarItemVisibility.Always || bbiUnidadesRenta.Visibility == BarItemVisibility.Always || beiEscanerOficina.Visibility == BarItemVisibility.Always ? true : false;
                Twain32 twain = new Twain32();
                twain.OpenDSM();
                bbiUsuario.Caption = "Usuario : " + ATRCBASE.BL.Utilerias.UsuarioActual.Nombre;
                for (int i = 0; i < twain.SourcesCount; i++)
                {
                    cmbEscanerGuardias.Items.Add(twain.GetSourceProductName(i));
                    cmbEscanerOficina.Items.Add(twain.GetSourceProductName(i));
                }

                ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                ATRCBASE.BL.Configuraciones ConfiguracionGuardias = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "EscanerGuardias"));
                if (ConfiguracionGuardias != null)
                    beiEscanerGuardias.EditValue = twain.GetSourceProductName(Convert.ToInt32(ConfiguracionGuardias.Accion));

                ATRCBASE.BL.Configuraciones ConfiguracionOficina = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "EscanerOficina"));
                if (ConfiguracionOficina != null)
                    beiEscanerOficina.EditValue = twain.GetSourceProductName(Convert.ToInt32(ConfiguracionOficina.Accion));
            }
            #endregion

        }

        private void bvbiSalir_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.Close();
            //Application.Exit();
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

        private void bbiAnunciosUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmAnunciosUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmAnunciosUsuariosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAccesos_ItemClick(object sender, ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmAccesos xfrm = new ATRCBASE.WIN.xfrmAccesos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiHistorialAccesos_ItemClick(object sender, ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmHistorialAccesos xfrm = new ATRCBASE.WIN.xfrmHistorialAccesos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
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
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DevExpress.Xpo.XPView Usuarios = new DevExpress.Xpo.XPView(Unidad, typeof(ATRCBASE.BL.Usuario), "Oid;NumEmpleado;Imagen.Archivo", null);
            Usuarios.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord Usuario in Usuarios)
            {
                if (Usuario["Imagen.Archivo"] != null)
                {
                    byte[] image = Convert.FromBase64String(Usuario["Imagen.Archivo"].ToString());
                    if (image != null)
                    {
                        string f = "C:\\Users\\ATRC SISTEMAS\\Desktop\\img\\" + Usuario["NumEmpleado"].ToString() + ".JPEG";
                        if (!File.Exists(f))
                        {
                            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(image))
                            {
                                Image returnImage = Image.FromStream(stream);

                                File.WriteAllBytes(f, image);
                            }
                        }
                    }
                }
            }
           // Utilerias.ActualizarEsquema();
            //Application.Exit();
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
                    xfrm.MdiParent = this;
                    xfrm.Show();
                    break;
                case "Concentrado de nómina":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrmConcentrado = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrmConcentrado.Titulo = e.Item.Description;
                    xfrmConcentrado.Size = new Size(635, 240);
                    xfrmConcentrado.MdiParent = this;
                    xfrmConcentrado.Show();
                    break;
                case "Total horas trabajadas semanales":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrmHoras = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrmHoras.Titulo = e.Item.Description;
                    xfrmHoras.Size = new Size(635, 240);
                    xfrmHoras.Todos = true;
                    xfrmHoras.MdiParent = this;
                    xfrmHoras.Show();
                    break;
                case "Rutas a pagar por usuario":
                    CHECADOR.WIN.xfrmFiltrosReportes xfrmRutasUaurios = new CHECADOR.WIN.xfrmFiltrosReportes();
                    xfrmRutasUaurios.Titulo = e.Item.Description;
                    xfrmRutasUaurios.Size = new Size(635, 240);
                    xfrmRutasUaurios.Todos = false;
                    xfrmRutasUaurios.MdiParent = this;
                    xfrmRutasUaurios.Show();
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
            ALMACEN.WIN.Articulos.xfrmPrestamoArticulo xfrm = new ALMACEN.WIN.Articulos.xfrmPrestamoArticulo();
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

        private void bbiHistorialHerramientaPrestada_ItemClick(object sender, ItemClickEventArgs e)
        {
            ALMACEN.WIN.xfrmBusquedaHerramientaPrestada xfrm = new ALMACEN.WIN.xfrmBusquedaHerramientaPrestada();
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

        private void bbiHistorialInventarioExtintores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UNIDADES.WIN.xfrmHistorialExtintores xfrm = new UNIDADES.WIN.xfrmHistorialExtintores();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiBaterias_ItemClick(object sender, ItemClickEventArgs e)
        {
            UNIDADES.WIN.Baterias.xfrmInventarioBaterias xfrm = new UNIDADES.WIN.Baterias.xfrmInventarioBaterias();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiHistorialBaterias_ItemClick(object sender, ItemClickEventArgs e)
        {
            UNIDADES.WIN.Baterias.xfrmHistorialInventarioBaterias xfrm = new UNIDADES.WIN.Baterias.xfrmHistorialInventarioBaterias();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiUnidadesFueraServicio_ItemClick(object sender, ItemClickEventArgs e)
        {
            UNIDADES.WIN.Unidades.xfrmUnidadesFueraServicio xfrm = new UNIDADES.WIN.Unidades.xfrmUnidadesFueraServicio();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
        #endregion

        #region Llantera

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
        #endregion

        #region Taller
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
        #endregion

        #region Rutas
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

        

        private void bbiPlantillasRutasExternas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmPlantillasRutasFijasGRD xfrm = new RUTAS.WIN.xfrmPlantillasRutasFijasGRD();
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

        private void bbiTurnos_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmTurnosGRD xfrmd = new RUTAS.WIN.xfrmTurnosGRD();
            xfrmd.ShowInTaskbar = false;
            xfrmd.MdiParent = this;
            xfrmd.Show();
        }

        private void bbiServiciosRutas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmServiciosGRD xfrm = new RUTAS.WIN.xfrmServiciosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPrecioServicio_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmPreciosPorEmpresa xfrm = new RUTAS.WIN.xfrmPreciosPorEmpresa();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiImportarRutas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmImportacionRutas xfrm = new RUTAS.WIN.xfrmImportacionRutas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiServiciosRealizados_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmServiciosRealizados xfrm = new RUTAS.WIN.xfrmServiciosRealizados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiReportesServicios_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmReportesServiciosRealizados xfrm = new RUTAS.WIN.xfrmReportesServiciosRealizados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void rgbiReportesRutas_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            //switch (e.Item.Description)
            //{
            //    case "Rutas fijas":
            //        break;
            //    case "Rutas extras":
            //        break;
            //    case "Rutas fijas por usuario":
            //        break;
            //    case "Rutas extras por usuario":
            //        break;
            //    case "Total horas trabajadas semanales":
            CHECADOR.WIN.xfrmFiltrosReportes xfrmHoras = new CHECADOR.WIN.xfrmFiltrosReportes();
            xfrmHoras.Titulo = e.Item.Description;
            xfrmHoras.Size = new Size(635, 240);
            xfrmHoras.Todos = false;
            xfrmHoras.MdiParent = this;
            xfrmHoras.Show();
            //        break;
            //}    
        }

        private void bbiHistorialRutasGeneradas_ItemClick(object sender, ItemClickEventArgs e)
        {
            CHECADOR.WIN.xfrmFiltrosReportes xfrmHistorial = new CHECADOR.WIN.xfrmFiltrosReportes();
            xfrmHistorial.Titulo = e.Item.Caption;
            xfrmHistorial.Size = new Size(635, 240);
            xfrmHistorial.Todos = true;
            xfrmHistorial.MdiParent = this;
            xfrmHistorial.Show();
        }
        #endregion

        #region Guardias
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

        private void bbiNuevoRecibo_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmRecibos xfrm = new GUARDIAS.WIN.xfrmRecibos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRecibos_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmRecibosGRD xfrm = new GUARDIAS.WIN.xfrmRecibosGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiClientesRenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmClientesRentaGRD xfrm = new GUARDIAS.WIN.xfrmClientesRentaGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiContrato_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmContrato xfrm = new GUARDIAS.WIN.xfrmContrato();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPrecioUnidades_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmUnidadesRenta xfrm = new GUARDIAS.WIN.xfrmUnidadesRenta();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiEntregaUnidad_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmSalidaUnidad xfrm = new GUARDIAS.WIN.xfrmSalidaUnidad();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiContratos_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmContratos xfrm = new GUARDIAS.WIN.xfrmContratos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiRecibirUnidadRentada_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ReportPrintTool repUsuarioRegistrado = new ReportPrintTool(new REPORTES.Usuarios.Usuarios());
            //repUsuarioRegistrado.ShowPreview();
            GUARDIAS.WIN.Renta.xfrmSeguimientoContrato xfrm = new GUARDIAS.WIN.Renta.xfrmSeguimientoContrato();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();

        }

        private void bbiCalendarioRentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.Renta.xfrmCalendarioREnta xfrm = new GUARDIAS.WIN.Renta.xfrmCalendarioREnta();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAbonar_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.Renta.xfrmAbonoContrato xfrm = new GUARDIAS.WIN.Renta.xfrmAbonoContrato();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiHistorialRentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.Renta.xfrmReporteHistorialRenta xfrm = new GUARDIAS.WIN.Renta.xfrmReporteHistorialRenta();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiUnidadesDisponibles_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.Renta.xfrmUnidadesDisponibles xfrm = new GUARDIAS.WIN.Renta.xfrmUnidadesDisponibles();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiUnidadesRenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUARDIAS.WIN.xfrmUnidadesRenta xfrm = new GUARDIAS.WIN.xfrmUnidadesRenta();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
        #endregion

        #region Combustible

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
            COMBUSTIBLE.WIN.xfrmRecargasGRD xfrm = new COMBUSTIBLE.WIN.xfrmRecargasGRD();
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
                case "Detalles de medidores":
                    xfrm.ReporteCombustible = ATRCBASE.BL.Enums.ReporteCombustible.DetallesMedidores;
                    break;
            }
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

        private void bbiModificarGasolina_ItemClick(object sender, ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmModificarGasolina xfrm = new COMBUSTIBLE.WIN.xfrmModificarGasolina();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiCalculosCarga_ItemClick(object sender, ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmCalculosCarga xfrm = new COMBUSTIBLE.WIN.xfrmCalculosCarga();
            xfrm.Tipo = ATRCBASE.BL.Enums.Combustible.Diesel;
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiCalculosCargaGasolina_ItemClick(object sender, ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmCalculosCarga xfrm = new COMBUSTIBLE.WIN.xfrmCalculosCarga();
            xfrm.Tipo = ATRCBASE.BL.Enums.Combustible.Gasolina;
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiNuevaRecarga_ItemClick(object sender, ItemClickEventArgs e)
        {
            COMBUSTIBLE.WIN.xfrmRecargaDiesel xfrm = new COMBUSTIBLE.WIN.xfrmRecargaDiesel();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
        #endregion

        #region Configuraciones
        private void bbiUsuariosExternos_ItemClick(object sender, ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosPortalGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosPortalGRD();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiConfiguracion_ItemClick(object sender, ItemClickEventArgs e)
        {
            ATRCBASE.WIN.xfrmConfiguraciones xfrm = new ATRCBASE.WIN.xfrmConfiguraciones();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiActualizarPermisos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ATRCBASE.BL.Utilerias.Permisos();
        }
        #endregion

        private void bvbiContraseña_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            ATRCBASE.WIN.xfrmCambioContraseña xfrm = new ATRCBASE.WIN.xfrmCambioContraseña();
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
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

        

        private void repositoryItemComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit editor = sender as DevExpress.XtraEditors.ComboBoxEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedItem));
            go.Operands.Add(new BinaryOperator("Propiedad", "ImpresoraTicketsAlmacen"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if(Configuracion != null)
            {
                Configuracion.Accion = editor.SelectedItem.ToString();
            }

            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "ImpresoraTicketsAlmacen";
                Configuracion.Accion = editor.SelectedItem.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void cmbEscanerOficina_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit editor = sender as DevExpress.XtraEditors.ComboBoxEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "EscanerOficina"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.SelectedIndex.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "EscanerOficina";
                Configuracion.Accion = editor.SelectedIndex.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void cmbEscanerGuardias_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit editor = sender as DevExpress.XtraEditors.ComboBoxEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "EscanerGuardias"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.SelectedIndex.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "EscanerGuardias";
                Configuracion.Accion = editor.SelectedIndex.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }


        private void xfrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea salir del sistema?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bbiPedidosRecibidos_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.PedidoRutas.xfrmPedidosRecibidos xfrm = new RUTAS.WIN.PedidoRutas.xfrmPedidosRecibidos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPedidosAprobados_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.PedidoRutas.xfrmPedidosAprobados xfrm = new RUTAS.WIN.PedidoRutas.xfrmPedidosAprobados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPedidosCancelados_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.PedidoRutas.xfrmPedidosCancelados xfrm = new RUTAS.WIN.PedidoRutas.xfrmPedidosCancelados();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPedidos_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.PedidoRutas.xfrmPedidos xfrm = new RUTAS.WIN.PedidoRutas.xfrmPedidos();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPlantillaCorreo_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.PedidoRutas.xfrmPlantillasDeCorreo xfrm = new RUTAS.WIN.PedidoRutas.xfrmPlantillasDeCorreo();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiConfiguracionRutas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmConfiguracionesRutas xfrm = new RUTAS.WIN.xfrmConfiguracionesRutas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAclaraciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmAclaraciones xfrm = new RUTAS.WIN.xfrmAclaraciones();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAclaracionesAprobadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmAclaracionesAprobadas xfrm = new RUTAS.WIN.xfrmAclaracionesAprobadas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAclarcacionesCreadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmAclaracionesCreadas xfrm = new RUTAS.WIN.xfrmAclaracionesCreadas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAclaracionesRechazadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmAclaracionesRechazadas xfrm = new RUTAS.WIN.xfrmAclaracionesRechazadas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiAclaracionesRecibidas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.xfrmAclaracionesRecibidas xfrm = new RUTAS.WIN.xfrmAclaracionesRecibidas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }

        private void bbiPublicarRutas_ItemClick(object sender, ItemClickEventArgs e)
        {
            RUTAS.WIN.Anuncios.xfrmPublicacionRutas xfrm = new RUTAS.WIN.Anuncios.xfrmPublicacionRutas();
            xfrm.ShowInTaskbar = false;
            xfrm.MdiParent = this;
            xfrm.Show();
        }
    }
}
