namespace RUTAS.WIN
{
    partial class xfrmRutas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRutas));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgImprimir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.colorRuta = new DevExpress.XtraEditors.ColorEdit();
            this.txtRuta = new DevExpress.XtraEditors.TextEdit();
            this.grdCoordenada = new DevExpress.XtraGrid.GridControl();
            this.grvCoordenada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIndice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MapControlUbicacion = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.routeProvider = new DevExpress.XtraMap.BingRouteDataProvider();
            this.informationLayer2 = new DevExpress.XtraMap.InformationLayer();
            this.bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDetalle = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciColorRuta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRuta = new DevExpress.XtraLayout.LayoutControlItem();
            this.flyEdicion = new DevExpress.Utils.FlyoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoordenada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoordenada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapControlUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciColorRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyEdicion)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.colorRuta);
            this.lcMain.Controls.Add(this.txtRuta);
            this.lcMain.Controls.Add(this.grdCoordenada);
            this.lcMain.Controls.Add(this.MapControlUbicacion);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1098, 368, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1316, 702);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(620, 42);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Properties.DisplayMember = "Nombre";
            this.lueEmpresa.Properties.NullText = "[Seleccione]";
            this.lueEmpresa.Properties.ValueMember = "Oid";
            this.lueEmpresa.Size = new System.Drawing.Size(429, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 9;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar,
            this.bbiImprimir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1316, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.LargeImage")));
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 3;
            this.bbiImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.Image")));
            this.bbiImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.LargeImage")));
            this.bbiImprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAcciones,
            this.rpgImprimir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.AllowTextClipping = false;
            this.rpgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // rpgImprimir
            // 
            this.rpgImprimir.AllowTextClipping = false;
            this.rpgImprimir.ItemLinks.Add(this.bbiImprimir);
            this.rpgImprimir.Name = "rpgImprimir";
            this.rpgImprimir.ShowCaptionButton = false;
            // 
            // colorRuta
            // 
            this.colorRuta.EditValue = System.Drawing.Color.Empty;
            this.colorRuta.Location = new System.Drawing.Point(1146, 42);
            this.colorRuta.MenuManager = this.ribbonControl1;
            this.colorRuta.Name = "colorRuta";
            this.colorRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorRuta.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colorRuta.Size = new System.Drawing.Size(146, 20);
            this.colorRuta.StyleController = this.lcMain;
            this.colorRuta.TabIndex = 8;
            this.colorRuta.EditValueChanged += new System.EventHandler(this.colorRuta_EditValueChanged);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(117, 42);
            this.txtRuta.MenuManager = this.ribbonControl1;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(406, 20);
            this.txtRuta.StyleController = this.lcMain;
            this.txtRuta.TabIndex = 7;
            // 
            // grdCoordenada
            // 
            this.grdCoordenada.Location = new System.Drawing.Point(12, 78);
            this.grdCoordenada.MainView = this.grvCoordenada;
            this.grdCoordenada.Name = "grdCoordenada";
            this.grdCoordenada.Size = new System.Drawing.Size(321, 612);
            this.grdCoordenada.TabIndex = 6;
            this.grdCoordenada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCoordenada});
            // 
            // grvCoordenada
            // 
            this.grvCoordenada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIndice,
            this.colCalle});
            this.grvCoordenada.GridControl = this.grdCoordenada;
            this.grvCoordenada.Name = "grvCoordenada";
            this.grvCoordenada.OptionsBehavior.Editable = false;
            this.grvCoordenada.OptionsBehavior.ReadOnly = true;
            this.grvCoordenada.OptionsDetail.ShowDetailTabs = false;
            this.grvCoordenada.OptionsView.AllowHtmlDrawGroups = false;
            this.grvCoordenada.OptionsView.ShowDetailButtons = false;
            this.grvCoordenada.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grvCoordenada.OptionsView.ShowGroupPanel = false;
            // 
            // colIndice
            // 
            this.colIndice.Caption = "Indice";
            this.colIndice.FieldName = "Indice";
            this.colIndice.Name = "colIndice";
            this.colIndice.OptionsColumn.AllowEdit = false;
            this.colIndice.OptionsColumn.AllowFocus = false;
            this.colIndice.OptionsColumn.ReadOnly = true;
            this.colIndice.Visible = true;
            this.colIndice.VisibleIndex = 0;
            this.colIndice.Width = 48;
            // 
            // colCalle
            // 
            this.colCalle.Caption = "Calle";
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.OptionsColumn.AllowEdit = false;
            this.colCalle.OptionsColumn.AllowFocus = false;
            this.colCalle.OptionsColumn.ReadOnly = true;
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 1;
            this.colCalle.Width = 255;
            // 
            // MapControlUbicacion
            // 
            this.MapControlUbicacion.CenterPoint = new DevExpress.XtraMap.GeoPoint(32.44745D, -114.765135D);
            this.MapControlUbicacion.Layers.Add(this.imageLayer1);
            this.MapControlUbicacion.Layers.Add(this.informationLayer1);
            this.MapControlUbicacion.Layers.Add(this.informationLayer2);
            this.MapControlUbicacion.Location = new System.Drawing.Point(337, 78);
            this.MapControlUbicacion.Name = "MapControlUbicacion";
            this.MapControlUbicacion.NavigationPanelOptions.BackgroundStyle.Fill = System.Drawing.Color.Transparent;
            this.MapControlUbicacion.NavigationPanelOptions.ScaleStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MapControlUbicacion.NavigationPanelOptions.ShowCoordinates = false;
            this.MapControlUbicacion.NavigationPanelOptions.ShowKilometersScale = false;
            this.MapControlUbicacion.NavigationPanelOptions.ShowMilesScale = false;
            this.MapControlUbicacion.PrintOptions.SizeMode = DevExpress.XtraMap.MapPrintSizeMode.Stretch;
            this.MapControlUbicacion.Size = new System.Drawing.Size(967, 612);
            this.MapControlUbicacion.TabIndex = 4;
            this.MapControlUbicacion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapControlUbicacion_MouseUp);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AsFpcLqFTZI0OBfJx-oDBp-hxtsuknATg9gZ7o3yt3DUnq3M7CSSFCD_FRLP-qJx";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.informationLayer1.DataProvider = this.routeProvider;
            this.informationLayer1.ItemStyle.Fill = System.Drawing.Color.Lime;
            this.informationLayer1.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.routeProvider.BingKey = "AsFpcLqFTZI0OBfJx-oDBp-hxtsuknATg9gZ7o3yt3DUnq3M7CSSFCD_FRLP-qJx";
            this.routeProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.bingRouteDataProvider1_LayerItemsGenerating);
            this.informationLayer2.DataProvider = this.bingGeocodeDataProvider1;
            this.bingGeocodeDataProvider1.BingKey = "AsFpcLqFTZI0OBfJx-oDBp-hxtsuknATg9gZ7o3yt3DUnq3M7CSSFCD_FRLP-qJx";
            this.bingGeocodeDataProvider1.MaxVisibleResultCount = 3;
            this.bingGeocodeDataProvider1.ProcessMouseEvents = true;
            this.bingGeocodeDataProvider1.LocationInformationReceived += new DevExpress.XtraMap.LocationInformationReceivedEventHandler(this.bingGeocodeDataProvider1_LocationInformationReceived);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.lcgDetalle});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1316, 702);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.MapControlUbicacion;
            this.layoutControlItem1.Location = new System.Drawing.Point(325, 66);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(971, 616);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdCoordenada;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(325, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(325, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(325, 616);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lcgDetalle
            // 
            this.lcgDetalle.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciColorRuta,
            this.lciEmpresa,
            this.lciRuta});
            this.lcgDetalle.Location = new System.Drawing.Point(0, 0);
            this.lcgDetalle.Name = "lcgDetalle";
            this.lcgDetalle.Size = new System.Drawing.Size(1296, 66);
            this.lcgDetalle.Text = "Detalle de ruta";
            // 
            // lciColorRuta
            // 
            this.lciColorRuta.Control = this.colorRuta;
            this.lciColorRuta.Location = new System.Drawing.Point(1029, 0);
            this.lciColorRuta.Name = "lciColorRuta";
            this.lciColorRuta.Size = new System.Drawing.Size(243, 24);
            this.lciColorRuta.Text = "Color de la ruta:";
            this.lciColorRuta.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(503, 0);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(526, 24);
            this.lciEmpresa.Text = "Empresa:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lciRuta
            // 
            this.lciRuta.Control = this.txtRuta;
            this.lciRuta.Location = new System.Drawing.Point(0, 0);
            this.lciRuta.Name = "lciRuta";
            this.lciRuta.Size = new System.Drawing.Size(503, 24);
            this.lciRuta.Text = "Nombre de la ruta:";
            this.lciRuta.TextSize = new System.Drawing.Size(90, 13);
            // 
            // flyEdicion
            // 
            this.flyEdicion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flyEdicion.Appearance.ForeColor = System.Drawing.Color.White;
            this.flyEdicion.Appearance.Options.UseBackColor = true;
            this.flyEdicion.Appearance.Options.UseForeColor = true;
            this.flyEdicion.Location = new System.Drawing.Point(12, 457);
            this.flyEdicion.Name = "flyEdicion";
            this.flyEdicion.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.flyEdicion.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flyEdicion.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.flyEdicion.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.flyEdicion.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.flyEdicion.OptionsButtonPanel.ButtonPanelHeight = 37;
            this.flyEdicion.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            this.flyEdicion.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Eliminar", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Mover arriba", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Mover abajo", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.flyEdicion.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyEdicion.OwnerControl = this.grdCoordenada;
            this.flyEdicion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 37);
            this.flyEdicion.Size = new System.Drawing.Size(321, 37);
            this.flyEdicion.TabIndex = 1;
            this.flyEdicion.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flyEdicion_ButtonClick);
            // 
            // xfrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 824);
            this.Controls.Add(this.flyEdicion);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmRutas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Ruta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoordenada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoordenada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapControlUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciColorRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyEdicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraMap.MapControl MapControlUbicacion;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraGrid.GridControl grdCoordenada;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCoordenada;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraMap.BingRouteDataProvider routeProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colIndice;
        private DevExpress.XtraMap.InformationLayer informationLayer2;
        private DevExpress.XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.Utils.FlyoutPanel flyEdicion;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.ColorEdit colorRuta;
        private DevExpress.XtraEditors.TextEdit txtRuta;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetalle;
        private DevExpress.XtraLayout.LayoutControlItem lciColorRuta;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem lciRuta;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgImprimir;
    }
}

