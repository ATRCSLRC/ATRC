namespace COMBUSTIBLE.WIN
{
    partial class xfrmCapturaDiesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCapturaDiesel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAgregarPedido = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiesel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMedidor = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bbiTanques = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiasAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rsbTanques = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.dteDia = new DevExpress.XtraEditors.DateEdit();
            this.grdUnidadDiesel = new DevExpress.XtraGrid.GridControl();
            this.grvUnidadDiesel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciDia = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidadDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDia)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiAgregarPedido,
            this.bbiDiesel,
            this.bbiSalir,
            this.bbiMedidor,
            this.barStaticItem1,
            this.bbiTanques,
            this.bbiDiasAnterior});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(480, 122);
            this.ribbonControl1.StatusBar = this.rsbTanques;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAgregarPedido
            // 
            this.bbiAgregarPedido.Caption = "Agregar pedido";
            this.bbiAgregarPedido.Id = 1;
            this.bbiAgregarPedido.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPedido.ImageOptions.LargeImage")));
            this.bbiAgregarPedido.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7);
            this.bbiAgregarPedido.Name = "bbiAgregarPedido";
            this.bbiAgregarPedido.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAgregarPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAgregarPedido_ItemClick);
            // 
            // bbiDiesel
            // 
            this.bbiDiesel.Caption = "Diesel en unidad";
            this.bbiDiesel.Id = 2;
            this.bbiDiesel.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_plataforma_petrolera_32;
            this.bbiDiesel.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiDiesel.Name = "bbiDiesel";
            this.bbiDiesel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDiesel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiesel_ItemClick);
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
            // bbiMedidor
            // 
            this.bbiMedidor.Caption = "Medidores de tanque";
            this.bbiMedidor.Id = 4;
            this.bbiMedidor.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_manómetro_de_buceo_32;
            this.bbiMedidor.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiMedidor.Name = "bbiMedidor";
            this.bbiMedidor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiMedidor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMedidor_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // bbiTanques
            // 
            this.bbiTanques.Id = 6;
            this.bbiTanques.Name = "bbiTanques";
            // 
            // bbiDiasAnterior
            // 
            this.bbiDiasAnterior.Caption = "Días anteriores";
            this.bbiDiasAnterior.Id = 7;
            this.bbiDiasAnterior.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_plataforma_petrolera_32__3_1;
            this.bbiDiasAnterior.Name = "bbiDiasAnterior";
            this.bbiDiasAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDiasAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiasAnterior_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDiesel);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMedidor);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAgregarPedido);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDiasAnterior);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // rsbTanques
            // 
            this.rsbTanques.ItemLinks.Add(this.bbiTanques);
            this.rsbTanques.Location = new System.Drawing.Point(0, 587);
            this.rsbTanques.Name = "rsbTanques";
            this.rsbTanques.Ribbon = this.ribbonControl1;
            this.rsbTanques.Size = new System.Drawing.Size(480, 31);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.dteDia);
            this.lcMain.Controls.Add(this.grdUnidadDiesel);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(537, 311, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(480, 496);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // dteDia
            // 
            this.dteDia.EditValue = null;
            this.dteDia.Location = new System.Drawing.Point(90, 12);
            this.dteDia.MenuManager = this.ribbonControl1;
            this.dteDia.Name = "dteDia";
            this.dteDia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDia.Properties.DisplayFormat.FormatString = "D";
            this.dteDia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDia.Properties.EditFormat.FormatString = "D";
            this.dteDia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDia.Properties.Mask.EditMask = "D";
            this.dteDia.Size = new System.Drawing.Size(378, 20);
            this.dteDia.StyleController = this.lcMain;
            this.dteDia.TabIndex = 5;
            this.dteDia.EditValueChanged += new System.EventHandler(this.dteDia_EditValueChanged);
            // 
            // grdUnidadDiesel
            // 
            this.grdUnidadDiesel.Location = new System.Drawing.Point(12, 36);
            this.grdUnidadDiesel.MainView = this.grvUnidadDiesel;
            this.grdUnidadDiesel.MenuManager = this.ribbonControl1;
            this.grdUnidadDiesel.Name = "grdUnidadDiesel";
            this.grdUnidadDiesel.Size = new System.Drawing.Size(456, 426);
            this.grdUnidadDiesel.TabIndex = 4;
            this.grdUnidadDiesel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUnidadDiesel});
            // 
            // grvUnidadDiesel
            // 
            this.grvUnidadDiesel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2});
            this.grvUnidadDiesel.GridControl = this.grdUnidadDiesel;
            this.grvUnidadDiesel.Name = "grvUnidadDiesel";
            this.grvUnidadDiesel.OptionsFind.AlwaysVisible = true;
            this.grvUnidadDiesel.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Llenado";
            this.gridColumn3.FieldName = "Llenado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Unidad";
            this.gridColumn1.FieldName = "Unidad.Nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 130;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Chofer";
            this.gridColumn2.FieldName = "Empleado.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 276;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.lciDia});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(480, 496);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUnidadDiesel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(460, 430);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 454);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(460, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciDia
            // 
            this.lciDia.Control = this.dteDia;
            this.lciDia.Location = new System.Drawing.Point(0, 0);
            this.lciDia.Name = "lciDia";
            this.lciDia.Size = new System.Drawing.Size(460, 24);
            this.lciDia.Text = "Seleccionar día:";
            this.lciDia.TextSize = new System.Drawing.Size(75, 13);
            this.lciDia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmCapturaDiesel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 618);
            this.Controls.Add(this.rsbTanques);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmCapturaDiesel";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.rsbTanques;
            this.Text = "Captura diesel";
            this.Load += new System.EventHandler(this.xfrmCapturaDiesel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidadDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiAgregarPedido;
        private DevExpress.XtraBars.BarButtonItem bbiDiesel;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdUnidadDiesel;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUnidadDiesel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiMedidor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rsbTanques;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem bbiTanques;
        private DevExpress.XtraEditors.DateEdit dteDia;
        private DevExpress.XtraLayout.LayoutControlItem lciDia;
        private DevExpress.XtraBars.BarButtonItem bbiDiasAnterior;
    }
}