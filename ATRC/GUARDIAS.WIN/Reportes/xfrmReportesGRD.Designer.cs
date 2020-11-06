namespace GUARDIAS.WIN
{
    partial class xfrmReportesGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmReportesGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lciMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.lueEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.rgTipoBusqueda = new DevExpress.XtraEditors.RadioGroup();
            this.grdReportes = new DevExpress.XtraGrid.GridControl();
            this.grvReportes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFolio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoBusqueda = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciDE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).BeginInit();
            this.lciMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiModificar,
            this.bbiImprimir,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(794, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar";
            this.bbiModificar.Id = 1;
            this.bbiModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiModificar.ImageOptions.LargeImage")));
            this.bbiModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 2;
            this.bbiImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.Image")));
            this.bbiImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.LargeImage")));
            this.bbiImprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // lciMain
            // 
            this.lciMain.Controls.Add(this.btnCancelar);
            this.lciMain.Controls.Add(this.dteAl);
            this.lciMain.Controls.Add(this.dteDel);
            this.lciMain.Controls.Add(this.btnBuscar);
            this.lciMain.Controls.Add(this.lueEmpleado);
            this.lciMain.Controls.Add(this.txtFolio);
            this.lciMain.Controls.Add(this.rgTipoBusqueda);
            this.lciMain.Controls.Add(this.grdReportes);
            this.lciMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lciMain.Location = new System.Drawing.Point(0, 122);
            this.lciMain.Name = "lciMain";
            this.lciMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(846, 236, 650, 400);
            this.lciMain.Root = this.layoutControlGroup2;
            this.lciMain.Size = new System.Drawing.Size(794, 393);
            this.lciMain.TabIndex = 2;
            this.lciMain.Text = "layoutControl2";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(666, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 22);
            this.btnCancelar.StyleController = this.lciMain;
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.EnterMoveNextControl = true;
            this.dteAl.Location = new System.Drawing.Point(491, 97);
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
            this.dteAl.Size = new System.Drawing.Size(279, 20);
            this.dteAl.StyleController = this.lciMain;
            this.dteAl.TabIndex = 10;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.EnterMoveNextControl = true;
            this.dteDel.Location = new System.Drawing.Point(116, 97);
            this.dteDel.MenuManager = this.ribbonControl1;
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.EditFormat.FormatString = "D";
            this.dteDel.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Size = new System.Drawing.Size(279, 20);
            this.dteDel.StyleController = this.lciMain;
            this.dteDel.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 22);
            this.btnBuscar.StyleController = this.lciMain;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lueEmpleado
            // 
            this.lueEmpleado.EnterMoveNextControl = true;
            this.lueEmpleado.Location = new System.Drawing.Point(116, 121);
            this.lueEmpleado.MenuManager = this.ribbonControl1;
            this.lueEmpleado.Name = "lueEmpleado";
            this.lueEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpleado.Properties.DisplayMember = "Nombre";
            this.lueEmpleado.Properties.NullText = "[Seleccioné]";
            this.lueEmpleado.Properties.ValueMember = "Oid";
            this.lueEmpleado.Size = new System.Drawing.Size(654, 20);
            this.lueEmpleado.StyleController = this.lciMain;
            this.lueEmpleado.TabIndex = 7;
            // 
            // txtFolio
            // 
            this.txtFolio.EnterMoveNextControl = true;
            this.txtFolio.Location = new System.Drawing.Point(116, 73);
            this.txtFolio.MenuManager = this.ribbonControl1;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Properties.Mask.EditMask = "\\p{Lu}+\\d+";
            this.txtFolio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFolio.Size = new System.Drawing.Size(654, 20);
            this.txtFolio.StyleController = this.lciMain;
            this.txtFolio.TabIndex = 6;
            // 
            // rgTipoBusqueda
            // 
            this.rgTipoBusqueda.Location = new System.Drawing.Point(116, 42);
            this.rgTipoBusqueda.MenuManager = this.ribbonControl1;
            this.rgTipoBusqueda.Name = "rgTipoBusqueda";
            this.rgTipoBusqueda.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Empleado", true, "Empleado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Folio", true, "Folio")});
            this.rgTipoBusqueda.Size = new System.Drawing.Size(654, 27);
            this.rgTipoBusqueda.StyleController = this.lciMain;
            this.rgTipoBusqueda.TabIndex = 5;
            this.rgTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.rgTipoBusqueda_SelectedIndexChanged);
            // 
            // grdReportes
            // 
            this.grdReportes.Location = new System.Drawing.Point(12, 183);
            this.grdReportes.MainView = this.grvReportes;
            this.grdReportes.MenuManager = this.ribbonControl1;
            this.grdReportes.Name = "grdReportes";
            this.grdReportes.Size = new System.Drawing.Size(770, 198);
            this.grdReportes.TabIndex = 4;
            this.grdReportes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReportes});
            // 
            // grvReportes
            // 
            this.grvReportes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolio,
            this.colEmpleado,
            this.colFecha});
            this.grvReportes.GridControl = this.grdReportes;
            this.grvReportes.Name = "grvReportes";
            this.grvReportes.OptionsView.ShowGroupPanel = false;
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
            // 
            // colEmpleado
            // 
            this.colEmpleado.Caption = "Empleado";
            this.colEmpleado.FieldName = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.OptionsColumn.AllowEdit = false;
            this.colEmpleado.OptionsColumn.AllowFocus = false;
            this.colEmpleado.Visible = true;
            this.colEmpleado.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "FechaAlta";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup1});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(794, 393);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdReportes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 171);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(774, 202);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEmpleado,
            this.lciFolio,
            this.lciTipoBusqueda,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.lciDE,
            this.lciAl,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(774, 171);
            this.layoutControlGroup1.Text = "Detalle de búsqueda";
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.Control = this.lueEmpleado;
            this.lciEmpleado.Location = new System.Drawing.Point(0, 79);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(750, 24);
            this.lciEmpleado.Text = "Empleado:";
            this.lciEmpleado.TextSize = new System.Drawing.Size(89, 13);
            this.lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciFolio
            // 
            this.lciFolio.Control = this.txtFolio;
            this.lciFolio.Location = new System.Drawing.Point(0, 31);
            this.lciFolio.Name = "lciFolio";
            this.lciFolio.Size = new System.Drawing.Size(750, 24);
            this.lciFolio.Text = "Folio:";
            this.lciFolio.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lciTipoBusqueda
            // 
            this.lciTipoBusqueda.Control = this.rgTipoBusqueda;
            this.lciTipoBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lciTipoBusqueda.MaxSize = new System.Drawing.Size(0, 31);
            this.lciTipoBusqueda.MinSize = new System.Drawing.Size(150, 31);
            this.lciTipoBusqueda.Name = "lciTipoBusqueda";
            this.lciTipoBusqueda.Size = new System.Drawing.Size(750, 31);
            this.lciTipoBusqueda.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoBusqueda.Text = "Tipo de búsqueda:";
            this.lciTipoBusqueda.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnBuscar;
            this.layoutControlItem5.Location = new System.Drawing.Point(535, 103);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 103);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(535, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciDE
            // 
            this.lciDE.Control = this.dteDel;
            this.lciDE.Location = new System.Drawing.Point(0, 55);
            this.lciDE.Name = "lciDE";
            this.lciDE.Size = new System.Drawing.Size(375, 24);
            this.lciDE.Text = "Del:";
            this.lciDE.TextSize = new System.Drawing.Size(89, 13);
            this.lciDE.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciAl
            // 
            this.lciAl.Control = this.dteAl;
            this.lciAl.Location = new System.Drawing.Point(375, 55);
            this.lciAl.Name = "lciAl";
            this.lciAl.Size = new System.Drawing.Size(375, 24);
            this.lciAl.Text = "Al:";
            this.lciAl.TextSize = new System.Drawing.Size(89, 13);
            this.lciAl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancelar;
            this.layoutControlItem2.Location = new System.Drawing.Point(642, 103);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // xfrmReportesGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 515);
            this.Controls.Add(this.lciMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmReportesGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Reportes de indiciplina";
            this.Load += new System.EventHandler(this.xfrmReportesGRD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmReportesGRD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).EndInit();
            this.lciMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lciMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.XtraEditors.RadioGroup rgTipoBusqueda;
        private DevExpress.XtraGrid.GridControl grdReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciFolio;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LookUpEdit lueEmpleado;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.XtraLayout.LayoutControlItem lciDE;
        private DevExpress.XtraLayout.LayoutControlItem lciAl;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}