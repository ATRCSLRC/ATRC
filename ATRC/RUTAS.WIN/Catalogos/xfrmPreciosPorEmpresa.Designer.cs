namespace RUTAS.WIN
{
    partial class xfrmPreciosPorEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPreciosPorEmpresa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevoServicio = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificarServicio = new DevExpress.XtraBars.BarButtonItem();
            this.rpAcciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdPreciosServicios = new DevExpress.XtraGrid.GridControl();
            this.grvPreciosServicios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPreciosServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPreciosServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNuevoServicio,
            this.bbiModificarServicio});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAcciones});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(446, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevoServicio
            // 
            this.bbiNuevoServicio.Caption = "Nuevo servicio";
            this.bbiNuevoServicio.Id = 1;
            this.bbiNuevoServicio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNuevoServicio.ImageOptions.LargeImage")));
            this.bbiNuevoServicio.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevoServicio.Name = "bbiNuevoServicio";
            this.bbiNuevoServicio.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevoServicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoServicio_ItemClick);
            // 
            // bbiModificarServicio
            // 
            this.bbiModificarServicio.Caption = "Modificar Servicio";
            this.bbiModificarServicio.Id = 2;
            this.bbiModificarServicio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiModificarServicio.ImageOptions.LargeImage")));
            this.bbiModificarServicio.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificarServicio.Name = "bbiModificarServicio";
            this.bbiModificarServicio.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificarServicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarServicio_ItemClick);
            // 
            // rpAcciones
            // 
            this.rpAcciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpAcciones.Name = "rpAcciones";
            this.rpAcciones.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevoServicio);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificarServicio);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "  ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdPreciosServicios);
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(446, 328);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdPreciosServicios
            // 
            this.grdPreciosServicios.Location = new System.Drawing.Point(12, 78);
            this.grdPreciosServicios.MainView = this.grvPreciosServicios;
            this.grdPreciosServicios.MenuManager = this.ribbonControl1;
            this.grdPreciosServicios.Name = "grdPreciosServicios";
            this.grdPreciosServicios.Size = new System.Drawing.Size(422, 238);
            this.grdPreciosServicios.TabIndex = 5;
            this.grdPreciosServicios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPreciosServicios});
            // 
            // grvPreciosServicios
            // 
            this.grvPreciosServicios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClave,
            this.colServicio,
            this.colPrecio});
            this.grvPreciosServicios.GridControl = this.grdPreciosServicios;
            this.grvPreciosServicios.Name = "grvPreciosServicios";
            this.grvPreciosServicios.OptionsView.ShowGroupPanel = false;
            // 
            // colClave
            // 
            this.colClave.Caption = "Clave";
            this.colClave.FieldName = "Servicio.Clave";
            this.colClave.Name = "colClave";
            this.colClave.OptionsColumn.AllowEdit = false;
            this.colClave.OptionsColumn.AllowFocus = false;
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 0;
            this.colClave.Width = 50;
            // 
            // colServicio
            // 
            this.colServicio.Caption = "Servicio";
            this.colServicio.FieldName = "Servicio.Descripcion";
            this.colServicio.Name = "colServicio";
            this.colServicio.OptionsColumn.AllowEdit = false;
            this.colServicio.OptionsColumn.AllowFocus = false;
            this.colServicio.Visible = true;
            this.colServicio.VisibleIndex = 1;
            this.colServicio.Width = 175;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "c";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            this.colPrecio.Width = 50;
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(72, 42);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Properties.DisplayMember = "Nombre";
            this.lueEmpresa.Properties.ValueMember = "Oid";
            this.lueEmpresa.Size = new System.Drawing.Size(350, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 4;
            this.lueEmpresa.EditValueChanged += new System.EventHandler(this.lueEmpresa_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(446, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdPreciosServicios;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(426, 242);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEmpresa});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(426, 66);
            this.layoutControlGroup2.Text = "Seleccioné una empresa";
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(402, 24);
            this.lciEmpresa.Text = "Empresa:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(45, 13);
            // 
            // xfrmPreciosPorEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmPreciosPorEmpresa";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Precios de servicios";
            this.Load += new System.EventHandler(this.xfrmPreciosPorEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPreciosServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPreciosServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grdPreciosServicios;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPreciosServicios;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoServicio;
        private DevExpress.XtraBars.BarButtonItem bbiModificarServicio;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAcciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}