namespace ALMACEN.WIN
{ 
    partial class xfrmBusquedaHerramientaPrestada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmBusquedaHerramientaPrestada));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiReporte = new DevExpress.XtraBars.BarButtonItem();
            this.rpReporte = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnCodigoHerramienta = new DevExpress.XtraEditors.ButtonEdit();
            this.rgHerramienta = new DevExpress.XtraEditors.RadioGroup();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.grdHerramienta = new DevExpress.XtraGrid.GridControl();
            this.grvHerramienta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoPrestamo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciArticulo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHerramienta = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigoHerramienta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgHerramienta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHerramienta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHerramienta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHerramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiReporte});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReporte});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiReporte
            // 
            this.bbiReporte.Caption = "Imprimir reporte";
            this.bbiReporte.Id = 1;
            this.bbiReporte.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReporte.ImageOptions.Image")));
            this.bbiReporte.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReporte.ImageOptions.LargeImage")));
            this.bbiReporte.Name = "bbiReporte";
            this.bbiReporte.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReporte_ItemClick);
            // 
            // rpReporte
            // 
            this.rpReporte.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpReporte.Name = "rpReporte";
            this.rpReporte.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReporte);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnCodigoHerramienta);
            this.lcMain.Controls.Add(this.rgHerramienta);
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.grdHerramienta);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.rgTipo);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 223, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 426);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnCodigoHerramienta
            // 
            this.btnCodigoHerramienta.EnterMoveNextControl = true;
            this.btnCodigoHerramienta.Location = new System.Drawing.Point(114, 107);
            this.btnCodigoHerramienta.MenuManager = this.ribbonControl1;
            this.btnCodigoHerramienta.Name = "btnCodigoHerramienta";
            this.btnCodigoHerramienta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.btnCodigoHerramienta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCodigoHerramienta.Properties.DisplayFormat.FormatString = "d";
            this.btnCodigoHerramienta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnCodigoHerramienta.Properties.EditFormat.FormatString = "d";
            this.btnCodigoHerramienta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnCodigoHerramienta.Properties.Mask.EditMask = "d";
            this.btnCodigoHerramienta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnCodigoHerramienta.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.NullValue;
            this.btnCodigoHerramienta.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.btnCodigoHerramienta.Size = new System.Drawing.Size(662, 20);
            this.btnCodigoHerramienta.StyleController = this.lcMain;
            this.btnCodigoHerramienta.TabIndex = 11;
            // 
            // rgHerramienta
            // 
            this.rgHerramienta.EnterMoveNextControl = true;
            this.rgHerramienta.Location = new System.Drawing.Point(114, 69);
            this.rgHerramienta.MenuManager = this.ribbonControl1;
            this.rgHerramienta.Name = "rgHerramienta";
            this.rgHerramienta.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Toda la herramienta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Herramienta específico")});
            this.rgHerramienta.Size = new System.Drawing.Size(662, 34);
            this.rgHerramienta.StyleController = this.lcMain;
            this.rgHerramienta.TabIndex = 10;
            this.rgHerramienta.SelectedIndexChanged += new System.EventHandler(this.rgHerramienta_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(185, 22);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdHerramienta
            // 
            this.grdHerramienta.Location = new System.Drawing.Point(12, 207);
            this.grdHerramienta.MainView = this.grvHerramienta;
            this.grdHerramienta.MenuManager = this.ribbonControl1;
            this.grdHerramienta.Name = "grdHerramienta";
            this.grdHerramienta.Size = new System.Drawing.Size(776, 207);
            this.grdHerramienta.TabIndex = 8;
            this.grdHerramienta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHerramienta});
            // 
            // grvHerramienta
            // 
            this.grvHerramienta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticulo,
            this.colEmpleado,
            this.colDiaPrestamo,
            this.colDiaEntrega});
            this.grvHerramienta.GridControl = this.grdHerramienta;
            this.grvHerramienta.Name = "grvHerramienta";
            this.grvHerramienta.OptionsView.ShowGroupPanel = false;
            // 
            // colArticulo
            // 
            this.colArticulo.Caption = "Artículo";
            this.colArticulo.FieldName = "Articulo.Nombre";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.OptionsColumn.AllowEdit = false;
            this.colArticulo.OptionsColumn.AllowFocus = false;
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 0;
            // 
            // colEmpleado
            // 
            this.colEmpleado.Caption = "Empleado";
            this.colEmpleado.FieldName = "Usuario.Nombre";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.OptionsColumn.AllowEdit = false;
            this.colEmpleado.OptionsColumn.AllowFocus = false;
            this.colEmpleado.Visible = true;
            this.colEmpleado.VisibleIndex = 1;
            // 
            // colDiaPrestamo
            // 
            this.colDiaPrestamo.Caption = "Día prestamo";
            this.colDiaPrestamo.DisplayFormat.FormatString = "g";
            this.colDiaPrestamo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDiaPrestamo.FieldName = "Fecha";
            this.colDiaPrestamo.Name = "colDiaPrestamo";
            this.colDiaPrestamo.OptionsColumn.AllowEdit = false;
            this.colDiaPrestamo.OptionsColumn.AllowFocus = false;
            this.colDiaPrestamo.Visible = true;
            this.colDiaPrestamo.VisibleIndex = 2;
            // 
            // colDiaEntrega
            // 
            this.colDiaEntrega.Caption = "Día entrega";
            this.colDiaEntrega.DisplayFormat.FormatString = "g";
            this.colDiaEntrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDiaEntrega.FieldName = "FechaEntrega";
            this.colDiaEntrega.Name = "colDiaEntrega";
            this.colDiaEntrega.OptionsColumn.AllowEdit = false;
            this.colDiaEntrega.OptionsColumn.AllowFocus = false;
            this.colDiaEntrega.Visible = true;
            this.colDiaEntrega.VisibleIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(402, 169);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Búsqueda";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rgTipo
            // 
            this.rgTipo.EditValue = "Todos";
            this.rgTipo.EnterMoveNextControl = true;
            this.rgTipo.Location = new System.Drawing.Point(114, 131);
            this.rgTipo.MenuManager = this.ribbonControl1;
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Todos", "Todos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Entregado", "Entregado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Sin entregar", "Sin entregar")});
            this.rgTipo.Size = new System.Drawing.Size(662, 34);
            this.rgTipo.StyleController = this.lcMain;
            this.rgTipo.TabIndex = 6;
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.EnterMoveNextControl = true;
            this.dteAl.Location = new System.Drawing.Point(420, 45);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.EditFormat.FormatString = "D";
            this.dteAl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Size = new System.Drawing.Size(356, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 5;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.EnterMoveNextControl = true;
            this.dteDe.Location = new System.Drawing.Point(46, 45);
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
            this.dteDe.Size = new System.Drawing.Size(352, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.lciBusqueda});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 426);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grdHerramienta;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 195);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 211);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lciBusqueda
            // 
            this.lciBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciAl,
            this.lciTipoPrestamo,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.lciArticulo,
            this.lciHerramienta});
            this.lciBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lciBusqueda.Name = "lciBusqueda";
            this.lciBusqueda.Size = new System.Drawing.Size(780, 195);
            this.lciBusqueda.Text = "Detalle de búsqueda";
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(378, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDe.TextSize = new System.Drawing.Size(17, 13);
            this.lciDe.TextToControlDistance = 5;
            // 
            // lciAl
            // 
            this.lciAl.Control = this.dteAl;
            this.lciAl.Location = new System.Drawing.Point(378, 0);
            this.lciAl.Name = "lciAl";
            this.lciAl.Size = new System.Drawing.Size(378, 24);
            this.lciAl.Text = "Al:";
            this.lciAl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciAl.TextSize = new System.Drawing.Size(13, 13);
            this.lciAl.TextToControlDistance = 5;
            // 
            // lciTipoPrestamo
            // 
            this.lciTipoPrestamo.Control = this.rgTipo;
            this.lciTipoPrestamo.Location = new System.Drawing.Point(0, 86);
            this.lciTipoPrestamo.MaxSize = new System.Drawing.Size(0, 38);
            this.lciTipoPrestamo.MinSize = new System.Drawing.Size(159, 38);
            this.lciTipoPrestamo.Name = "lciTipoPrestamo";
            this.lciTipoPrestamo.Size = new System.Drawing.Size(756, 38);
            this.lciTipoPrestamo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoPrestamo.Text = "Tipo de préstamo:";
            this.lciTipoPrestamo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(378, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBuscar;
            this.layoutControlItem4.Location = new System.Drawing.Point(378, 124);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(189, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(567, 124);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(189, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // lciArticulo
            // 
            this.lciArticulo.Control = this.rgHerramienta;
            this.lciArticulo.Location = new System.Drawing.Point(0, 24);
            this.lciArticulo.MaxSize = new System.Drawing.Size(0, 38);
            this.lciArticulo.MinSize = new System.Drawing.Size(159, 38);
            this.lciArticulo.Name = "lciArticulo";
            this.lciArticulo.Size = new System.Drawing.Size(756, 38);
            this.lciArticulo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciArticulo.Text = "Herramienta:";
            this.lciArticulo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHerramienta
            // 
            this.lciHerramienta.Control = this.btnCodigoHerramienta;
            this.lciHerramienta.Location = new System.Drawing.Point(0, 62);
            this.lciHerramienta.Name = "lciHerramienta";
            this.lciHerramienta.Size = new System.Drawing.Size(756, 24);
            this.lciHerramienta.Text = "Herramienta:";
            this.lciHerramienta.TextSize = new System.Drawing.Size(87, 13);
            this.lciHerramienta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmBusquedaHerramientaPrestada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmBusquedaHerramientaPrestada.IconOptions.Icon")));
            this.Name = "xfrmBusquedaHerramientaPrestada";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Búsqueda de herramienta prestada";
            this.Load += new System.EventHandler(this.xfrmBusquedaHerramientaPrestada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigoHerramienta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgHerramienta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHerramienta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHerramienta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHerramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReporte;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiReporte;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.GridControl grdHerramienta;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHerramienta;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaEntrega;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup lciBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciAl;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoPrestamo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ButtonEdit btnCodigoHerramienta;
        private DevExpress.XtraEditors.RadioGroup rgHerramienta;
        private DevExpress.XtraLayout.LayoutControlItem lciArticulo;
        private DevExpress.XtraLayout.LayoutControlItem lciHerramienta;
    }
}