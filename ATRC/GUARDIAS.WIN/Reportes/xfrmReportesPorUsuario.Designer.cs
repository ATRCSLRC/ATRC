namespace GUARDIAS.WIN
{
    partial class xfrmReportesPorUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmReportesPorUsuario));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtTotal = new DevExpress.XtraBars.BarStaticItem();
            this.bbiVistaPrevia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdReportes = new DevExpress.XtraGrid.GridControl();
            this.grvReportes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotal = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.txtTotal,
            this.bbiVistaPrevia,
            this.lblTotal});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(670, 122);
            this.ribbonControl1.StatusBar = this.bar;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Id = 1;
            this.txtTotal.Name = "txtTotal";
            // 
            // bbiVistaPrevia
            // 
            this.bbiVistaPrevia.Caption = "Vista previa";
            this.bbiVistaPrevia.Id = 2;
            this.bbiVistaPrevia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiVistaPrevia.ImageOptions.Image")));
            this.bbiVistaPrevia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVistaPrevia.ImageOptions.LargeImage")));
            this.bbiVistaPrevia.Name = "bbiVistaPrevia";
            this.bbiVistaPrevia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiVistaPrevia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiVistaPrevia_ItemClick);
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiVistaPrevia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // bar
            // 
            this.bar.ItemLinks.Add(this.lblTotal);
            this.bar.Location = new System.Drawing.Point(0, 423);
            this.bar.Name = "bar";
            this.bar.Ribbon = this.ribbonControl1;
            this.bar.Size = new System.Drawing.Size(670, 31);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdReportes);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(670, 301);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdReportes
            // 
            this.grdReportes.Location = new System.Drawing.Point(12, 12);
            this.grdReportes.MainView = this.grvReportes;
            this.grdReportes.MenuManager = this.ribbonControl1;
            this.grdReportes.Name = "grdReportes";
            this.grdReportes.Size = new System.Drawing.Size(646, 277);
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
            this.grvReportes.OptionsBehavior.Editable = false;
            this.grvReportes.OptionsBehavior.ReadOnly = true;
            this.grvReportes.OptionsView.ShowAutoFilterRow = true;
            this.grvReportes.OptionsView.ShowDetailButtons = false;
            this.grvReportes.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(670, 301);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdReportes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(650, 281);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colFolio
            // 
            this.colFolio.Caption = "Folio";
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.OptionsColumn.AllowEdit = false;
            this.colFolio.OptionsColumn.AllowFocus = false;
            this.colFolio.OptionsColumn.ReadOnly = true;
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 0;
            this.colFolio.Width = 155;
            // 
            // colEmpleado
            // 
            this.colEmpleado.Caption = "Empleado";
            this.colEmpleado.FieldName = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.OptionsColumn.AllowEdit = false;
            this.colEmpleado.OptionsColumn.AllowFocus = false;
            this.colEmpleado.OptionsColumn.ReadOnly = true;
            this.colEmpleado.Visible = true;
            this.colEmpleado.VisibleIndex = 1;
            this.colEmpleado.Width = 300;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "FechaAlta";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 173;
            // 
            // lblTotal
            // 
            this.lblTotal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblTotal.Id = 3;
            this.lblTotal.Name = "lblTotal";
            // 
            // xfrmReportesPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 454);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmReportesPorUsuario";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.bar;
            this.Text = "xfrmReportesPorUsuario";
            this.Load += new System.EventHandler(this.xfrmReportesPorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem txtTotal;
        private DevExpress.XtraBars.BarButtonItem bbiVistaPrevia;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar bar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReportes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraBars.BarStaticItem lblTotal;
    }
}