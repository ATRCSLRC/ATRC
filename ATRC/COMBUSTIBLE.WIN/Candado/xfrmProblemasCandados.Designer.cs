namespace COMBUSTIBLE.WIN
{
    partial class xfrmProblemasCandados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmProblemasCandados));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiDetalleProblema = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.laMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdProblemasCandados = new DevExpress.XtraGrid.GridControl();
            this.grvProblemasCandados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCandadoActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCandadoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laMain)).BeginInit();
            this.laMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProblemasCandados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProblemasCandados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiDetalleProblema,
            this.bbiSalir,
            this.barButtonItem3});
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
            this.ribbonControl1.Size = new System.Drawing.Size(507, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiDetalleProblema
            // 
            this.bbiDetalleProblema.Caption = "Detalle del problema";
            this.bbiDetalleProblema.Id = 1;
            this.bbiDetalleProblema.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDetalleProblema.ImageOptions.Image")));
            this.bbiDetalleProblema.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDetalleProblema.ImageOptions.LargeImage")));
            this.bbiDetalleProblema.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiDetalleProblema.Name = "bbiDetalleProblema";
            this.bbiDetalleProblema.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDetalleProblema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDetalleProblema_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 2;
            this.bbiSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.ImageOptions.LargeImage")));
            this.bbiSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDetalleProblema);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // laMain
            // 
            this.laMain.Controls.Add(this.grdProblemasCandados);
            this.laMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laMain.Location = new System.Drawing.Point(0, 122);
            this.laMain.Name = "laMain";
            this.laMain.Root = this.layoutControlGroup1;
            this.laMain.Size = new System.Drawing.Size(507, 328);
            this.laMain.TabIndex = 1;
            this.laMain.Text = "layoutControl1";
            // 
            // grdProblemasCandados
            // 
            this.grdProblemasCandados.Location = new System.Drawing.Point(12, 12);
            this.grdProblemasCandados.MainView = this.grvProblemasCandados;
            this.grdProblemasCandados.MenuManager = this.ribbonControl1;
            this.grdProblemasCandados.Name = "grdProblemasCandados";
            this.grdProblemasCandados.Size = new System.Drawing.Size(483, 304);
            this.grdProblemasCandados.TabIndex = 4;
            this.grdProblemasCandados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProblemasCandados});
            // 
            // grvProblemasCandados
            // 
            this.grvProblemasCandados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colNombre,
            this.colCandadoActual,
            this.colCandadoAnterior});
            this.grvProblemasCandados.GridControl = this.grdProblemasCandados;
            this.grvProblemasCandados.Name = "grvProblemasCandados";
            this.grvProblemasCandados.OptionsView.ShowGroupPanel = false;
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
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 97;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(507, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdProblemasCandados;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(487, 308);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 80;
            // 
            // colCandadoActual
            // 
            this.colCandadoActual.Caption = "Tenia";
            this.colCandadoActual.FieldName = "CandadoActual";
            this.colCandadoActual.Name = "colCandadoActual";
            this.colCandadoActual.OptionsColumn.AllowEdit = false;
            this.colCandadoActual.OptionsColumn.AllowFocus = false;
            this.colCandadoActual.OptionsColumn.ReadOnly = true;
            this.colCandadoActual.Visible = true;
            this.colCandadoActual.VisibleIndex = 2;
            this.colCandadoActual.Width = 80;
            // 
            // colCandadoAnterior
            // 
            this.colCandadoAnterior.Caption = "Debe tener";
            this.colCandadoAnterior.FieldName = "CandadoAnterior";
            this.colCandadoAnterior.Name = "colCandadoAnterior";
            this.colCandadoAnterior.OptionsColumn.AllowEdit = false;
            this.colCandadoAnterior.OptionsColumn.AllowFocus = false;
            this.colCandadoAnterior.OptionsColumn.ReadOnly = true;
            this.colCandadoAnterior.Visible = true;
            this.colCandadoAnterior.VisibleIndex = 3;
            this.colCandadoAnterior.Width = 87;
            // 
            // xfrmProblemasCandados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.laMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmProblemasCandados";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Problemas con candados";
            this.Load += new System.EventHandler(this.xfrmProblemasCandados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laMain)).EndInit();
            this.laMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProblemasCandados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProblemasCandados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl laMain;
        private DevExpress.XtraGrid.GridControl grdProblemasCandados;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProblemasCandados;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDetalleProblema;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCandadoActual;
        private DevExpress.XtraGrid.Columns.GridColumn colCandadoAnterior;
    }
}