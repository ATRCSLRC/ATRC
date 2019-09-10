namespace UNIDADES.WIN.Baterias
{
    partial class xfrmInventarioBaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmInventarioBaterias));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiRevisar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdBaterias = new DevExpress.XtraGrid.GridControl();
            this.grvBaterias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaterias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiExportar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiRevisar,
            this.bbiSalir,
            this.bbiExportar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(569, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiRevisar
            // 
            this.bbiRevisar.Caption = "Revisar";
            this.bbiRevisar.Id = 1;
            this.bbiRevisar.ImageOptions.LargeImage = global::UNIDADES.WIN.Properties.Resources.icons8_para_hacer_32__1_;
            this.bbiRevisar.Name = "bbiRevisar";
            this.bbiRevisar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRevisar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRevisar_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 2;
            this.bbiSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.ImageOptions.LargeImage")));
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRevisar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiExportar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdBaterias);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(569, 418);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdBaterias
            // 
            this.grdBaterias.Location = new System.Drawing.Point(12, 12);
            this.grdBaterias.MainView = this.grvBaterias;
            this.grdBaterias.MenuManager = this.ribbonControl1;
            this.grdBaterias.Name = "grdBaterias";
            this.grdBaterias.Size = new System.Drawing.Size(545, 394);
            this.grdBaterias.TabIndex = 4;
            this.grdBaterias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaterias});
            // 
            // grvBaterias
            // 
            this.grvBaterias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRevision,
            this.colUnidad,
            this.colBaterias,
            this.colComentario});
            this.grvBaterias.GridControl = this.grdBaterias;
            this.grvBaterias.Name = "grvBaterias";
            this.grvBaterias.OptionsView.ShowAutoFilterRow = true;
            this.grvBaterias.OptionsView.ShowGroupPanel = false;
            // 
            // colRevision
            // 
            this.colRevision.Caption = "Revisado";
            this.colRevision.FieldName = "Revisado";
            this.colRevision.Name = "colRevision";
            this.colRevision.OptionsColumn.AllowEdit = false;
            this.colRevision.OptionsColumn.AllowFocus = false;
            this.colRevision.Visible = true;
            this.colRevision.VisibleIndex = 0;
            this.colRevision.Width = 62;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "Nombre";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowEdit = false;
            this.colUnidad.OptionsColumn.AllowFocus = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 1;
            this.colUnidad.Width = 99;
            // 
            // colBaterias
            // 
            this.colBaterias.Caption = "Baterias";
            this.colBaterias.FieldName = "Baterias";
            this.colBaterias.Name = "colBaterias";
            this.colBaterias.OptionsColumn.AllowEdit = false;
            this.colBaterias.OptionsColumn.AllowFocus = false;
            this.colBaterias.Visible = true;
            this.colBaterias.VisibleIndex = 2;
            this.colBaterias.Width = 175;
            // 
            // colComentario
            // 
            this.colComentario.Caption = "Comentario";
            this.colComentario.FieldName = "ComentarioBateria";
            this.colComentario.Name = "colComentario";
            this.colComentario.OptionsColumn.AllowEdit = false;
            this.colComentario.OptionsColumn.AllowFocus = false;
            this.colComentario.OptionsColumn.ReadOnly = true;
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 3;
            this.colComentario.Width = 191;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(569, 418);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdBaterias;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(549, 398);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bbiExportar
            // 
            this.bbiExportar.Caption = "Exportar";
            this.bbiExportar.Id = 3;
            this.bbiExportar.Name = "bbiExportar";
            this.bbiExportar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportar_ItemClick);
            // 
            // xfrmInventarioBaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 540);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmInventarioBaterias";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Inventario de baterias";
            this.Load += new System.EventHandler(this.xfrmInventarioBaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdBaterias;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaterias;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colRevision;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colBaterias;
        private DevExpress.XtraBars.BarButtonItem bbiRevisar;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraBars.BarButtonItem bbiExportar;
    }
}