namespace GUARDIAS.WIN
{
    partial class xfrmRecibosGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRecibosGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReimprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExportar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelarRecibo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.spnFolio = new DevExpress.XtraEditors.SpinEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.rgTipoBusqueda = new DevExpress.XtraEditors.RadioGroup();
            this.grdRecibos = new DevExpress.XtraGrid.GridControl();
            this.grvRecibos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgFiltros = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBuscar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoBusqueda = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFolio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCancelar = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiModificar,
            this.bbiReimprimir,
            this.bbiSalir,
            this.bbiExportar,
            this.bbiCancelarRecibo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(834, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar";
            this.bbiModificar.Id = 1;
            this.bbiModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiModificar.ImageOptions.LargeImage")));
            this.bbiModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // bbiReimprimir
            // 
            this.bbiReimprimir.Caption = "Imprimir";
            this.bbiReimprimir.Id = 2;
            this.bbiReimprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReimprimir.ImageOptions.Image")));
            this.bbiReimprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReimprimir.ImageOptions.LargeImage")));
            this.bbiReimprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10);
            this.bbiReimprimir.Name = "bbiReimprimir";
            this.bbiReimprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiReimprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReimprimir_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 3;
            this.bbiSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.ImageOptions.LargeImage")));
            this.bbiSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
            // 
            // bbiExportar
            // 
            this.bbiExportar.Caption = "Exportar";
            this.bbiExportar.Id = 4;
            this.bbiExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExportar.ImageOptions.Image")));
            this.bbiExportar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExportar.ImageOptions.LargeImage")));
            this.bbiExportar.Name = "bbiExportar";
            this.bbiExportar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportar_ItemClick);
            // 
            // bbiCancelarRecibo
            // 
            this.bbiCancelarRecibo.Caption = "Cancelar recibo";
            this.bbiCancelarRecibo.Id = 5;
            this.bbiCancelarRecibo.ImageOptions.Image = global::GUARDIAS.WIN.Properties.Resources.icons8_archivo_48;
            this.bbiCancelarRecibo.Name = "bbiCancelarRecibo";
            this.bbiCancelarRecibo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelarRecibo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelarRecibo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReimprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelarRecibo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExportar);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.dteA);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.spnFolio);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.rgTipoBusqueda);
            this.lcMain.Controls.Add(this.grdRecibos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(779, 194, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(834, 340);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.EnterMoveNextControl = true;
            this.dteA.Location = new System.Drawing.Point(510, 99);
            this.dteA.MenuManager = this.ribbonControl1;
            this.dteA.Name = "dteA";
            this.dteA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.DisplayFormat.FormatString = "D";
            this.dteA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.EditFormat.FormatString = "D";
            this.dteA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.Mask.EditMask = "D";
            this.dteA.Size = new System.Drawing.Size(300, 20);
            this.dteA.StyleController = this.lcMain;
            this.dteA.TabIndex = 10;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.EnterMoveNextControl = true;
            this.dteDe.Location = new System.Drawing.Point(116, 99);
            this.dteDe.MenuManager = this.ribbonControl1;
            this.dteDe.Name = "dteDe";
            this.dteDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.DisplayFormat.FormatString = "D";
            this.dteDe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.EditFormat.FormatString = "D";
            this.dteDe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.Mask.EditMask = "D";
            this.dteDe.Size = new System.Drawing.Size(298, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 9;
            // 
            // spnFolio
            // 
            this.spnFolio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnFolio.EnterMoveNextControl = true;
            this.spnFolio.Location = new System.Drawing.Point(116, 75);
            this.spnFolio.MenuManager = this.ribbonControl1;
            this.spnFolio.Name = "spnFolio";
            this.spnFolio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnFolio.Size = new System.Drawing.Size(694, 20);
            this.spnFolio.StyleController = this.lcMain;
            this.spnFolio.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(535, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(677, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 22);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rgTipoBusqueda
            // 
            this.rgTipoBusqueda.EnterMoveNextControl = true;
            this.rgTipoBusqueda.Location = new System.Drawing.Point(116, 45);
            this.rgTipoBusqueda.MenuManager = this.ribbonControl1;
            this.rgTipoBusqueda.Name = "rgTipoBusqueda";
            this.rgTipoBusqueda.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Folio"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rango de fechas")});
            this.rgTipoBusqueda.Size = new System.Drawing.Size(694, 26);
            this.rgTipoBusqueda.StyleController = this.lcMain;
            this.rgTipoBusqueda.TabIndex = 5;
            this.rgTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.rgTipoBusqueda_SelectedIndexChanged);
            // 
            // grdRecibos
            // 
            this.grdRecibos.Location = new System.Drawing.Point(12, 161);
            this.grdRecibos.MainView = this.grvRecibos;
            this.grdRecibos.MenuManager = this.ribbonControl1;
            this.grdRecibos.Name = "grdRecibos";
            this.grdRecibos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grdRecibos.Size = new System.Drawing.Size(810, 167);
            this.grdRecibos.TabIndex = 4;
            this.grdRecibos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRecibos});
            // 
            // grvRecibos
            // 
            this.grvRecibos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolio,
            this.colFecha,
            this.colTipoCambio,
            this.colPrecio,
            this.colEmisor,
            this.colConcepto,
            this.colCancelado});
            this.grvRecibos.GridControl = this.grdRecibos;
            this.grvRecibos.Name = "grvRecibos";
            this.grvRecibos.OptionsBehavior.Editable = false;
            this.grvRecibos.OptionsBehavior.ReadOnly = true;
            this.grvRecibos.OptionsView.ShowDetailButtons = false;
            this.grvRecibos.OptionsView.ShowGroupPanel = false;
            // 
            // colFolio
            // 
            this.colFolio.Caption = "Folio";
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.OptionsColumn.AllowEdit = false;
            this.colFolio.OptionsColumn.AllowFocus = false;
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 0;
            this.colFolio.Width = 56;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 77;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.Caption = "Tipo de cambio";
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.OptionsColumn.AllowEdit = false;
            this.colTipoCambio.OptionsColumn.AllowFocus = false;
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 2;
            this.colTipoCambio.Width = 67;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "C2";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 67;
            // 
            // colEmisor
            // 
            this.colEmisor.Caption = "Emisor";
            this.colEmisor.FieldName = "Emisor";
            this.colEmisor.Name = "colEmisor";
            this.colEmisor.OptionsColumn.AllowEdit = false;
            this.colEmisor.OptionsColumn.AllowFocus = false;
            this.colEmisor.Visible = true;
            this.colEmisor.VisibleIndex = 4;
            this.colEmisor.Width = 185;
            // 
            // colConcepto
            // 
            this.colConcepto.Caption = "Concepto";
            this.colConcepto.FieldName = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.OptionsColumn.AllowEdit = false;
            this.colConcepto.OptionsColumn.AllowFocus = false;
            this.colConcepto.Visible = true;
            this.colConcepto.VisibleIndex = 5;
            this.colConcepto.Width = 276;
            // 
            // colCancelado
            // 
            this.colCancelado.Caption = "Cancelado";
            this.colCancelado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCancelado.FieldName = "Cancelado";
            this.colCancelado.Name = "colCancelado";
            this.colCancelado.OptionsColumn.AllowEdit = false;
            this.colCancelado.OptionsColumn.AllowFocus = false;
            this.colCancelado.Visible = true;
            this.colCancelado.VisibleIndex = 6;
            this.colCancelado.Width = 57;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcgFiltros});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(834, 340);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdRecibos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(814, 171);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcgFiltros
            // 
            this.lcgFiltros.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBuscar,
            this.lciTipoBusqueda,
            this.lciFolio,
            this.lciDe,
            this.lciA,
            this.emptySpaceItem1,
            this.lciCancelar});
            this.lcgFiltros.Location = new System.Drawing.Point(0, 0);
            this.lcgFiltros.Name = "lcgFiltros";
            this.lcgFiltros.Size = new System.Drawing.Size(814, 149);
            this.lcgFiltros.Text = "Filtros de búsqueda";
            // 
            // lciBuscar
            // 
            this.lciBuscar.Control = this.btnBuscar;
            this.lciBuscar.Location = new System.Drawing.Point(511, 78);
            this.lciBuscar.Name = "lciBuscar";
            this.lciBuscar.Size = new System.Drawing.Size(142, 26);
            this.lciBuscar.TextSize = new System.Drawing.Size(0, 0);
            this.lciBuscar.TextVisible = false;
            // 
            // lciTipoBusqueda
            // 
            this.lciTipoBusqueda.Control = this.rgTipoBusqueda;
            this.lciTipoBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lciTipoBusqueda.MaxSize = new System.Drawing.Size(0, 30);
            this.lciTipoBusqueda.MinSize = new System.Drawing.Size(146, 30);
            this.lciTipoBusqueda.Name = "lciTipoBusqueda";
            this.lciTipoBusqueda.Size = new System.Drawing.Size(790, 30);
            this.lciTipoBusqueda.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoBusqueda.Text = "Tipo de búsqueda:";
            this.lciTipoBusqueda.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lciFolio
            // 
            this.lciFolio.Control = this.spnFolio;
            this.lciFolio.Location = new System.Drawing.Point(0, 30);
            this.lciFolio.Name = "lciFolio";
            this.lciFolio.Size = new System.Drawing.Size(790, 24);
            this.lciFolio.Text = "Folio:";
            this.lciFolio.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 54);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(394, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(89, 13);
            this.lciDe.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(394, 54);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(396, 24);
            this.lciA.Text = "A:";
            this.lciA.TextSize = new System.Drawing.Size(89, 13);
            this.lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 78);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(511, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCancelar
            // 
            this.lciCancelar.Control = this.btnCancelar;
            this.lciCancelar.Location = new System.Drawing.Point(653, 78);
            this.lciCancelar.Name = "lciCancelar";
            this.lciCancelar.Size = new System.Drawing.Size(137, 26);
            this.lciCancelar.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancelar.TextVisible = false;
            // 
            // xfrmRecibosGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 472);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmRecibosGRD.IconOptions.Icon")));
            this.Name = "xfrmRecibosGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.xfrmRecibosGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraBars.BarButtonItem bbiReimprimir;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdRecibos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRecibos;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colEmisor;
        private DevExpress.XtraGrid.Columns.GridColumn colConcepto;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraEditors.SpinEdit spnFolio;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.RadioGroup rgTipoBusqueda;
        private DevExpress.XtraLayout.LayoutControlGroup lcgFiltros;
        private DevExpress.XtraLayout.LayoutControlItem lciBuscar;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciFolio;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraBars.BarButtonItem bbiExportar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelarRecibo;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}