namespace RUTAS.WIN.Anuncios
{
    partial class xfrmPublicacionRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPublicacionRutas));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevaPublicacion = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarPublicacion = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPublicaionExtra = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdAnuncios = new DevExpress.XtraGrid.GridControl();
            this.grvAnuncios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnuncios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAnuncios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiNuevaPublicacion,
            this.bbiEliminarPublicacion,
            this.bbiPublicaionExtra});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(347, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevaPublicacion
            // 
            this.bbiNuevaPublicacion.Caption = "Nueva publicación rutas fijas";
            this.bbiNuevaPublicacion.Id = 1;
            this.bbiNuevaPublicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNuevaPublicacion.ImageOptions.Image")));
            this.bbiNuevaPublicacion.Name = "bbiNuevaPublicacion";
            this.bbiNuevaPublicacion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevaPublicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevaPublicacion_ItemClick);
            // 
            // bbiEliminarPublicacion
            // 
            this.bbiEliminarPublicacion.Caption = "Eliminar publicación";
            this.bbiEliminarPublicacion.Id = 2;
            this.bbiEliminarPublicacion.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_la_televisión_32;
            this.bbiEliminarPublicacion.Name = "bbiEliminarPublicacion";
            this.bbiEliminarPublicacion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminarPublicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarPublicacion_ItemClick);
            // 
            // bbiPublicaionExtra
            // 
            this.bbiPublicaionExtra.Caption = "Nueva publicación  rutas extras";
            this.bbiPublicaionExtra.Id = 4;
            this.bbiPublicaionExtra.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_remote_desktop_32;
            this.bbiPublicaionExtra.Name = "bbiPublicaionExtra";
            this.bbiPublicaionExtra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiPublicaionExtra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPublicaionExtra_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevaPublicacion);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiPublicaionExtra);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarPublicacion);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdAnuncios);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(347, 386);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdAnuncios
            // 
            this.grdAnuncios.Location = new System.Drawing.Point(12, 12);
            this.grdAnuncios.MainView = this.grvAnuncios;
            this.grdAnuncios.MenuManager = this.ribbonControl1;
            this.grdAnuncios.Name = "grdAnuncios";
            this.grdAnuncios.Size = new System.Drawing.Size(323, 362);
            this.grdAnuncios.TabIndex = 4;
            this.grdAnuncios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAnuncios});
            // 
            // grvAnuncios
            // 
            this.grvAnuncios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDia,
            this.colEsExtra});
            this.grvAnuncios.GridControl = this.grdAnuncios;
            this.grvAnuncios.Name = "grvAnuncios";
            this.grvAnuncios.OptionsView.ShowGroupPanel = false;
            // 
            // colDia
            // 
            this.colDia.Caption = "Dia de rutas";
            this.colDia.FieldName = "FechaPublicacion";
            this.colDia.Name = "colDia";
            this.colDia.OptionsColumn.AllowEdit = false;
            this.colDia.OptionsColumn.AllowFocus = false;
            this.colDia.Visible = true;
            this.colDia.VisibleIndex = 0;
            this.colDia.Width = 247;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(347, 386);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdAnuncios;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(327, 366);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colEsExtra
            // 
            this.colEsExtra.Caption = "Es extra";
            this.colEsExtra.FieldName = "EsExtra";
            this.colEsExtra.Name = "colEsExtra";
            this.colEsExtra.OptionsColumn.AllowEdit = false;
            this.colEsExtra.OptionsColumn.AllowFocus = false;
            this.colEsExtra.Visible = true;
            this.colEsExtra.VisibleIndex = 1;
            this.colEsExtra.Width = 51;
            // 
            // xfrmPublicacionRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 518);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPublicacionRutas.IconOptions.Icon")));
            this.Name = "xfrmPublicacionRutas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Publicar rutas";
            this.Load += new System.EventHandler(this.xfrmPublicacionRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAnuncios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAnuncios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevaPublicacion;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarPublicacion;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdAnuncios;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAnuncios;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraBars.BarButtonItem bbiPublicaionExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
    }
}