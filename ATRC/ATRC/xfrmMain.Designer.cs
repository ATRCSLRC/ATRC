namespace ATRC
{
    partial class xfrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMain));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.rbnMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bvcAyuda = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvbiAyuda = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbiSalir = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bbiUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChecador = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConsultasChecada = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNotificacionesChecador = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiChecador = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.rgbiUsuarios = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDepartamento = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPuestos = new DevExpress.XtraBars.BarButtonItem();
            this.reporte = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem3 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiActualizarEsquemas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMarcas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMedidas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiArticulo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBusquedaArticulos = new DevExpress.XtraBars.BarButtonItem();
            this.rbnpUsuarios = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnpgUsuario = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnpgReportesUsuarios = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnpChecador = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnpgAdministracion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnpgReportesChecador = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAlmacen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgArticulos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgCatalogo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnpAdministracion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pbnpgCatalogos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rsbMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvcAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnMain
            // 
            this.rbnMain.AllowMinimizeRibbon = false;
            this.rbnMain.ApplicationButtonDropDownControl = this.bvcAyuda;
            this.rbnMain.ApplicationIcon = global::ATRC.Properties.Resources.school_bus;
            this.rbnMain.ExpandCollapseItem.Id = 0;
            this.rbnMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnMain.ExpandCollapseItem,
            this.bbiUsuario,
            this.bbiChecador,
            this.bbiConsultasChecada,
            this.bbiNotificacionesChecador,
            this.rgbiChecador,
            this.rgbiUsuarios,
            this.bbiUsuarios,
            this.bbiDepartamento,
            this.bbiPuestos,
            this.reporte,
            this.ribbonGalleryBarItem3,
            this.bbiActualizarEsquemas,
            this.bbiMarcas,
            this.bbiMedidas,
            this.bbiProveedor,
            this.bbiArticulo,
            this.bbiBusquedaArticulos});
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.MaxItemId = 19;
            this.rbnMain.Name = "rbnMain";
            this.rbnMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnpUsuarios,
            this.rbnpChecador,
            this.rpAlmacen,
            this.rbnpAdministracion});
            this.rbnMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.rbnMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.rbnMain.ShowItemCaptionsInPageHeader = true;
            this.rbnMain.ShowToolbarCustomizeItem = false;
            this.rbnMain.Size = new System.Drawing.Size(1061, 143);
            this.rbnMain.StatusBar = this.rsbMain;
            this.rbnMain.Toolbar.ShowCustomizeItem = false;
            this.rbnMain.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bvcAyuda
            // 
            this.bvcAyuda.Items.Add(this.bvbiAyuda);
            this.bvcAyuda.Items.Add(this.bvbiSalir);
            this.bvcAyuda.Location = new System.Drawing.Point(0, 136);
            this.bvcAyuda.Name = "bvcAyuda";
            this.bvcAyuda.OwnerControl = this.rbnMain;
            this.bvcAyuda.Size = new System.Drawing.Size(283, 415);
            this.bvcAyuda.TabIndex = 2;
            this.bvcAyuda.Text = "backstageViewControl1";
            // 
            // bvbiAyuda
            // 
            this.bvbiAyuda.Caption = "Ayuda";
            this.bvbiAyuda.Name = "bvbiAyuda";
            // 
            // bvbiSalir
            // 
            this.bvbiSalir.Caption = "Salir";
            this.bvbiSalir.Name = "bvbiSalir";
            this.bvbiSalir.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbiSalir_ItemClick);
            // 
            // bbiUsuario
            // 
            this.bbiUsuario.Id = 1;
            this.bbiUsuario.Name = "bbiUsuario";
            // 
            // bbiChecador
            // 
            this.bbiChecador.Caption = "Checador";
            this.bbiChecador.Id = 2;
            this.bbiChecador.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiChecador.ImageOptions.Image")));
            this.bbiChecador.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiChecador.ImageOptions.LargeImage")));
            this.bbiChecador.Name = "bbiChecador";
            this.bbiChecador.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiChecador.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChecador_ItemClick);
            // 
            // bbiConsultasChecada
            // 
            this.bbiConsultasChecada.Caption = "Historial de checador";
            this.bbiConsultasChecada.Id = 3;
            this.bbiConsultasChecada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiConsultasChecada.ImageOptions.Image")));
            this.bbiConsultasChecada.Name = "bbiConsultasChecada";
            this.bbiConsultasChecada.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbiConsultasChecada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConsultasChecada_ItemClick);
            // 
            // bbiNotificacionesChecador
            // 
            this.bbiNotificacionesChecador.Caption = "Notificaciones";
            this.bbiNotificacionesChecador.Id = 4;
            this.bbiNotificacionesChecador.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNotificacionesChecador.ImageOptions.Image")));
            this.bbiNotificacionesChecador.Name = "bbiNotificacionesChecador";
            this.bbiNotificacionesChecador.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbiNotificacionesChecador.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNotificacionesChecador_ItemClick);
            // 
            // rgbiChecador
            // 
            this.rgbiChecador.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group3";
            galleryItem1.Description = "Concentrado de nómina";
            galleryItem1.ImageOptions.HoverImage = ((System.Drawing.Image)(resources.GetObject("resource.HoverImage")));
            galleryItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            galleryItem2.Description = "Horas trabajadas semanales";
            galleryItem2.ImageOptions.HoverImage = ((System.Drawing.Image)(resources.GetObject("resource.HoverImage1")));
            galleryItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
            this.rgbiChecador.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.rgbiChecador.Gallery.ImageSize = new System.Drawing.Size(30, 30);
            this.rgbiChecador.Gallery.ShowItemText = true;
            this.rgbiChecador.Id = 6;
            this.rgbiChecador.Name = "rgbiChecador";
            this.rgbiChecador.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiChecador_GalleryItemClick);
            // 
            // rgbiUsuarios
            // 
            this.rgbiUsuarios.Caption = "Usuarios";
            // 
            // 
            // 
            this.rgbiUsuarios.Gallery.AllowHoverImages = true;
            this.rgbiUsuarios.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.ImageAndText;
            this.rgbiUsuarios.Gallery.ColumnCount = 2;
            galleryItemGroup2.Caption = "Usuarios";
            galleryItem3.Description = "Usuarios registrados";
            galleryItem3.Hint = "Usuarios registrados";
            galleryItem3.ImageOptions.HoverImage = ((System.Drawing.Image)(resources.GetObject("resource.HoverImage2")));
            galleryItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem1.Text = "Usuarios registrados";
            superToolTip1.Items.Add(toolTipTitleItem1);
            galleryItem3.SuperTip = superToolTip1;
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem3});
            this.rgbiUsuarios.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.rgbiUsuarios.Gallery.ImageSize = new System.Drawing.Size(28, 28);
            this.rgbiUsuarios.Gallery.RowCount = 1;
            this.rgbiUsuarios.Gallery.ShowItemText = true;
            this.rgbiUsuarios.Id = 7;
            this.rgbiUsuarios.Name = "rgbiUsuarios";
            this.rgbiUsuarios.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiUsuarios_GalleryItemClick);
            // 
            // bbiUsuarios
            // 
            this.bbiUsuarios.Caption = "Usuarios";
            this.bbiUsuarios.Id = 8;
            this.bbiUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiUsuarios.ImageOptions.Image")));
            this.bbiUsuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiUsuarios.ImageOptions.LargeImage")));
            this.bbiUsuarios.Name = "bbiUsuarios";
            this.bbiUsuarios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsuarios_ItemClick);
            // 
            // bbiDepartamento
            // 
            this.bbiDepartamento.Caption = "Departamentos";
            this.bbiDepartamento.Id = 9;
            this.bbiDepartamento.ImageOptions.Image = global::ATRC.Properties.Resources.Departamento;
            this.bbiDepartamento.Name = "bbiDepartamento";
            this.bbiDepartamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDepartamento_ItemClick);
            // 
            // bbiPuestos
            // 
            this.bbiPuestos.Caption = "Puestos";
            this.bbiPuestos.Id = 10;
            this.bbiPuestos.ImageOptions.Image = global::ATRC.Properties.Resources.Puestos;
            this.bbiPuestos.Name = "bbiPuestos";
            this.bbiPuestos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPuestos_ItemClick);
            // 
            // reporte
            // 
            this.reporte.Caption = "barButtonItem1";
            this.reporte.Id = 11;
            this.reporte.Name = "reporte";
            this.reporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reporte_ItemClick);
            // 
            // ribbonGalleryBarItem3
            // 
            this.ribbonGalleryBarItem3.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup3.Caption = "Group2";
            this.ribbonGalleryBarItem3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.ribbonGalleryBarItem3.Id = 12;
            this.ribbonGalleryBarItem3.Name = "ribbonGalleryBarItem3";
            // 
            // bbiActualizarEsquemas
            // 
            this.bbiActualizarEsquemas.Caption = "Actualizar esquemas";
            this.bbiActualizarEsquemas.Id = 13;
            this.bbiActualizarEsquemas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiActualizarEsquemas.ImageOptions.Image")));
            this.bbiActualizarEsquemas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiActualizarEsquemas.ImageOptions.LargeImage")));
            this.bbiActualizarEsquemas.Name = "bbiActualizarEsquemas";
            this.bbiActualizarEsquemas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiActualizarEsquemas_ItemClick);
            // 
            // bbiMarcas
            // 
            this.bbiMarcas.Caption = "Marcas";
            this.bbiMarcas.Id = 14;
            this.bbiMarcas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiMarcas.ImageOptions.Image")));
            this.bbiMarcas.Name = "bbiMarcas";
            this.bbiMarcas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMarcas_ItemClick);
            // 
            // bbiMedidas
            // 
            this.bbiMedidas.Caption = "Medidas";
            this.bbiMedidas.Id = 15;
            this.bbiMedidas.Name = "bbiMedidas";
            this.bbiMedidas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMedidas_ItemClick);
            // 
            // bbiProveedor
            // 
            this.bbiProveedor.Caption = "Proveedor";
            this.bbiProveedor.Id = 16;
            this.bbiProveedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiProveedor.ImageOptions.Image")));
            this.bbiProveedor.Name = "bbiProveedor";
            this.bbiProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProveedor_ItemClick);
            // 
            // bbiArticulo
            // 
            this.bbiArticulo.Caption = "Artículo";
            this.bbiArticulo.Id = 17;
            this.bbiArticulo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiArticulo.ImageOptions.Image")));
            this.bbiArticulo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiArticulo.ImageOptions.LargeImage")));
            this.bbiArticulo.Name = "bbiArticulo";
            this.bbiArticulo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiArticulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiArticulo_ItemClick);
            // 
            // bbiBusquedaArticulos
            // 
            this.bbiBusquedaArticulos.Caption = "Búsqueda";
            this.bbiBusquedaArticulos.Id = 18;
            this.bbiBusquedaArticulos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBusquedaArticulos.ImageOptions.Image")));
            this.bbiBusquedaArticulos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBusquedaArticulos.ImageOptions.LargeImage")));
            this.bbiBusquedaArticulos.Name = "bbiBusquedaArticulos";
            this.bbiBusquedaArticulos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiBusquedaArticulos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBusquedaArticulos_ItemClick);
            // 
            // rbnpUsuarios
            // 
            this.rbnpUsuarios.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnpgUsuario,
            this.rbnpgReportesUsuarios});
            this.rbnpUsuarios.Name = "rbnpUsuarios";
            this.rbnpUsuarios.Text = "Usuarios";
            // 
            // rbnpgUsuario
            // 
            this.rbnpgUsuario.AllowTextClipping = false;
            this.rbnpgUsuario.ItemLinks.Add(this.bbiUsuarios);
            this.rbnpgUsuario.Name = "rbnpgUsuario";
            this.rbnpgUsuario.ShowCaptionButton = false;
            this.rbnpgUsuario.Text = "Usuario";
            // 
            // rbnpgReportesUsuarios
            // 
            this.rbnpgReportesUsuarios.AllowTextClipping = false;
            this.rbnpgReportesUsuarios.ItemLinks.Add(this.rgbiUsuarios);
            this.rbnpgReportesUsuarios.Name = "rbnpgReportesUsuarios";
            this.rbnpgReportesUsuarios.ShowCaptionButton = false;
            this.rbnpgReportesUsuarios.Text = "Reportes";
            // 
            // rbnpChecador
            // 
            this.rbnpChecador.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnpgAdministracion,
            this.rbnpgReportesChecador});
            this.rbnpChecador.Name = "rbnpChecador";
            this.rbnpChecador.Text = "Administrador de checador";
            // 
            // rbnpgAdministracion
            // 
            this.rbnpgAdministracion.ItemLinks.Add(this.bbiChecador);
            this.rbnpgAdministracion.ItemLinks.Add(this.bbiConsultasChecada);
            this.rbnpgAdministracion.ItemLinks.Add(this.bbiNotificacionesChecador);
            this.rbnpgAdministracion.Name = "rbnpgAdministracion";
            this.rbnpgAdministracion.ShowCaptionButton = false;
            this.rbnpgAdministracion.Text = "Administración";
            // 
            // rbnpgReportesChecador
            // 
            this.rbnpgReportesChecador.AllowTextClipping = false;
            this.rbnpgReportesChecador.ItemLinks.Add(this.rgbiChecador);
            this.rbnpgReportesChecador.Name = "rbnpgReportesChecador";
            this.rbnpgReportesChecador.ShowCaptionButton = false;
            this.rbnpgReportesChecador.Text = "Reportes";
            // 
            // rpAlmacen
            // 
            this.rpAlmacen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgArticulos,
            this.rpgCatalogo});
            this.rpAlmacen.Name = "rpAlmacen";
            this.rpAlmacen.Text = "Almacen";
            // 
            // rpgArticulos
            // 
            this.rpgArticulos.AllowMinimize = false;
            this.rpgArticulos.ItemLinks.Add(this.bbiArticulo);
            this.rpgArticulos.ItemLinks.Add(this.bbiBusquedaArticulos);
            this.rpgArticulos.Name = "rpgArticulos";
            this.rpgArticulos.ShowCaptionButton = false;
            this.rpgArticulos.Text = "Artículos";
            // 
            // rpgCatalogo
            // 
            this.rpgCatalogo.AllowMinimize = false;
            this.rpgCatalogo.ItemLinks.Add(this.bbiMarcas);
            this.rpgCatalogo.ItemLinks.Add(this.bbiProveedor);
            this.rpgCatalogo.Name = "rpgCatalogo";
            this.rpgCatalogo.ShowCaptionButton = false;
            this.rpgCatalogo.Text = "Catálogo";
            // 
            // rbnpAdministracion
            // 
            this.rbnpAdministracion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pbnpgCatalogos,
            this.rpgMantenimiento});
            this.rbnpAdministracion.Name = "rbnpAdministracion";
            this.rbnpAdministracion.Text = "Administración";
            // 
            // pbnpgCatalogos
            // 
            this.pbnpgCatalogos.AllowTextClipping = false;
            this.pbnpgCatalogos.ItemLinks.Add(this.bbiDepartamento);
            this.pbnpgCatalogos.ItemLinks.Add(this.bbiPuestos);
            this.pbnpgCatalogos.Name = "pbnpgCatalogos";
            this.pbnpgCatalogos.ShowCaptionButton = false;
            this.pbnpgCatalogos.Text = "Catálogos";
            // 
            // rpgMantenimiento
            // 
            this.rpgMantenimiento.AllowTextClipping = false;
            this.rpgMantenimiento.ItemLinks.Add(this.bbiActualizarEsquemas);
            this.rpgMantenimiento.Name = "rpgMantenimiento";
            this.rpgMantenimiento.ShowCaptionButton = false;
            this.rpgMantenimiento.Text = "Mantenimiento";
            // 
            // rsbMain
            // 
            this.rsbMain.ItemLinks.Add(this.bbiUsuario);
            this.rsbMain.Location = new System.Drawing.Point(0, 520);
            this.rsbMain.Name = "rsbMain";
            this.rsbMain.Ribbon = this.rbnMain;
            this.rsbMain.Size = new System.Drawing.Size(1061, 31);
            // 
            // xfrmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 551);
            this.Controls.Add(this.bvcAyuda);
            this.Controls.Add(this.rsbMain);
            this.Controls.Add(this.rbnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "xfrmMain";
            this.Ribbon = this.rbnMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rsbMain;
            this.Text = "Auto transportes del rio colorado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.xfrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bvcAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbnMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnpChecador;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnpgAdministracion;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rsbMain;
        private DevExpress.XtraBars.BarButtonItem bbiUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnpgReportesChecador;
        private DevExpress.XtraBars.BarButtonItem bbiChecador;
        private DevExpress.XtraBars.BarButtonItem bbiConsultasChecada;
        private DevExpress.XtraBars.BarButtonItem bbiNotificacionesChecador;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiChecador;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiUsuarios;
        private DevExpress.XtraBars.BarButtonItem bbiUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnpUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnpgUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnpgReportesUsuarios;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl bvcAyuda;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbiSalir;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbiAyuda;
        private DevExpress.XtraBars.BarButtonItem bbiDepartamento;
        private DevExpress.XtraBars.BarButtonItem bbiPuestos;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnpAdministracion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pbnpgCatalogos;
        private DevExpress.XtraBars.BarButtonItem reporte;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem3;
        private DevExpress.XtraBars.BarButtonItem bbiActualizarEsquemas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAlmacen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgArticulos;
        private DevExpress.XtraBars.BarButtonItem bbiMarcas;
        private DevExpress.XtraBars.BarButtonItem bbiMedidas;
        private DevExpress.XtraBars.BarButtonItem bbiProveedor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCatalogo;
        private DevExpress.XtraBars.BarButtonItem bbiArticulo;
        private DevExpress.XtraBars.BarButtonItem bbiBusquedaArticulos;
    }
}