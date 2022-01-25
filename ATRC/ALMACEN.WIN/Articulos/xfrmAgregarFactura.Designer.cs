namespace ALMACEN.WIN
{
    partial class xfrmAgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAgregarFactura));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.fypEdicion = new DevExpress.Utils.FlyoutPanel();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.grvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCodigo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTipoMedida = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPrecio = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repAlmacen = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colParte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMarca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFactura = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fypEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTipoMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.Image")));
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.Image")));
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.fypEdicion);
            this.lcMain.Controls.Add(this.grdArticulos);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Controls.Add(this.txtFactura);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // fypEdicion
            // 
            this.fypEdicion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.Appearance.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.Appearance.Options.UseBackColor = true;
            this.fypEdicion.Appearance.Options.UseForeColor = true;
            this.fypEdicion.Location = new System.Drawing.Point(12, 268);
            this.fypEdicion.Name = "fypEdicion";
            this.fypEdicion.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.OptionsBeakPanel.Opacity = 0.5D;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelHeight = 10;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            this.fypEdicion.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Nuevo", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Eliminar", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.fypEdicion.OptionsButtonPanel.ShowButtonPanel = true;
            this.fypEdicion.OwnerControl = this.grdArticulos;
            this.fypEdicion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fypEdicion.ParentForm = this;
            this.fypEdicion.Size = new System.Drawing.Size(776, 38);
            this.fypEdicion.TabIndex = 7;
            this.fypEdicion.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.fypEdicion_ButtonClick);
            // 
            // grdArticulos
            // 
            this.grdArticulos.Location = new System.Drawing.Point(12, 36);
            this.grdArticulos.MainView = this.grvArticulos;
            this.grdArticulos.MenuManager = this.ribbonControl1;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCantidad,
            this.repTipoMedida,
            this.repPrecio,
            this.repProveedor,
            this.repAlmacen,
            this.repMarca,
            this.repCodigo});
            this.grdArticulos.Size = new System.Drawing.Size(776, 228);
            this.grdArticulos.TabIndex = 6;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvArticulos});
            // 
            // grvArticulos
            // 
            this.grvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colCantidad,
            this.colNombre,
            this.colTipoMedida,
            this.colPrecio,
            this.colProveedor,
            this.colAlmacen,
            this.colParte,
            this.colMarca});
            this.grvArticulos.GridControl = this.grdArticulos;
            this.grvArticulos.Name = "grvArticulos";
            this.grvArticulos.OptionsView.ShowGroupPanel = false;
            this.grvArticulos.LostFocus += new System.EventHandler(this.grvArticulos_LostFocus);
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Codigo";
            this.colCodigo.ColumnEdit = this.repCodigo;
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 83;
            // 
            // repCodigo
            // 
            this.repCodigo.AutoHeight = false;
            this.repCodigo.Name = "repCodigo";
            this.repCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repCodigo_KeyDown);
            this.repCodigo.Leave += new System.EventHandler(this.repCodigo_Leave);
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.repCantidad;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 55;
            // 
            // repCantidad
            // 
            this.repCantidad.AutoHeight = false;
            this.repCantidad.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCantidad.Name = "repCantidad";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 124;
            // 
            // colTipoMedida
            // 
            this.colTipoMedida.Caption = "Tipo de medida";
            this.colTipoMedida.ColumnEdit = this.repTipoMedida;
            this.colTipoMedida.FieldName = "TipoMedida";
            this.colTipoMedida.Name = "colTipoMedida";
            this.colTipoMedida.Visible = true;
            this.colTipoMedida.VisibleIndex = 3;
            this.colTipoMedida.Width = 79;
            // 
            // repTipoMedida
            // 
            this.repTipoMedida.AutoHeight = false;
            this.repTipoMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTipoMedida.Name = "repTipoMedida";
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.ColumnEdit = this.repPrecio;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 56;
            // 
            // repPrecio
            // 
            this.repPrecio.AutoHeight = false;
            this.repPrecio.BeepOnError = false;
            this.repPrecio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPrecio.DisplayFormat.FormatString = "c";
            this.repPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repPrecio.EditFormat.FormatString = "c";
            this.repPrecio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repPrecio.MaskSettings.Set("mask", "c");
            this.repPrecio.Name = "repPrecio";
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.ColumnEdit = this.repProveedor;
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 5;
            this.colProveedor.Width = 125;
            // 
            // repProveedor
            // 
            this.repProveedor.AutoHeight = false;
            this.repProveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repProveedor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.repProveedor.DisplayMember = "Nombre";
            this.repProveedor.Name = "repProveedor";
            // 
            // colAlmacen
            // 
            this.colAlmacen.Caption = "Almacen";
            this.colAlmacen.ColumnEdit = this.repAlmacen;
            this.colAlmacen.FieldName = "Almacen";
            this.colAlmacen.Name = "colAlmacen";
            this.colAlmacen.Visible = true;
            this.colAlmacen.VisibleIndex = 6;
            this.colAlmacen.Width = 56;
            // 
            // repAlmacen
            // 
            this.repAlmacen.AutoHeight = false;
            this.repAlmacen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repAlmacen.MaxLength = 1;
            this.repAlmacen.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.repAlmacen.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repAlmacen.Name = "repAlmacen";
            // 
            // colParte
            // 
            this.colParte.Caption = "# Parte";
            this.colParte.FieldName = "NumParte";
            this.colParte.Name = "colParte";
            this.colParte.Visible = true;
            this.colParte.VisibleIndex = 7;
            this.colParte.Width = 62;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.ColumnEdit = this.repMarca;
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 8;
            this.colMarca.Width = 111;
            // 
            // repMarca
            // 
            this.repMarca.AutoHeight = false;
            this.repMarca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repMarca.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.repMarca.DisplayMember = "Nombre";
            this.repMarca.Name = "repMarca";
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.EnterMoveNextControl = true;
            this.dteFecha.Location = new System.Drawing.Point(455, 12);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.MaskSettings.Set("mask", "D");
            this.dteFecha.Size = new System.Drawing.Size(333, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 5;
            // 
            // txtFactura
            // 
            this.txtFactura.EnterMoveNextControl = true;
            this.txtFactura.Location = new System.Drawing.Point(65, 12);
            this.txtFactura.MenuManager = this.ribbonControl1;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(333, 20);
            this.txtFactura.StyleController = this.lcMain;
            this.txtFactura.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFactura,
            this.lciFecha,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 318);
            this.Root.TextVisible = false;
            // 
            // lciFactura
            // 
            this.lciFactura.Control = this.txtFactura;
            this.lciFactura.Location = new System.Drawing.Point(0, 0);
            this.lciFactura.Name = "lciFactura";
            this.lciFactura.Size = new System.Drawing.Size(390, 24);
            this.lciFactura.Text = "Factura:";
            this.lciFactura.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(390, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(390, 24);
            this.lciFecha.Text = "Fecha:";
            this.lciFecha.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdArticulos;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 232);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.fypEdicion;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 256);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmAgregarFactura.IconOptions.Icon")));
            this.Name = "xfrmAgregarFactura";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Agregar factura";
            this.Load += new System.EventHandler(this.xfrmAgregarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fypEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTipoMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvArticulos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colAlmacen;
        private DevExpress.XtraGrid.Columns.GridColumn colParte;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciFactura;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repTipoMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repPrecio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repAlmacen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMarca;
        private DevExpress.Utils.FlyoutPanel fypEdicion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repCodigo;
    }
}