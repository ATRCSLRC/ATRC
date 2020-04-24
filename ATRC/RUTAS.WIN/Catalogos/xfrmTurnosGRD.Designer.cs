namespace RUTAS.WIN
{
    partial class xfrmTurnosGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTurnosGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevoTurno = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificarTurno = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarTurno = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lciMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdTurnos = new DevExpress.XtraGrid.GridControl();
            this.grvTurnos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).BeginInit();
            this.lciMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNuevoTurno,
            this.bbiModificarTurno,
            this.bbiEliminarTurno,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(320, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevoTurno
            // 
            this.bbiNuevoTurno.Caption = "Nuevo turno";
            this.bbiNuevoTurno.Id = 1;
            this.bbiNuevoTurno.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNuevoTurno.ImageOptions.LargeImage")));
            this.bbiNuevoTurno.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevoTurno.Name = "bbiNuevoTurno";
            this.bbiNuevoTurno.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevoTurno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoTurno_ItemClick);
            // 
            // bbiModificarTurno
            // 
            this.bbiModificarTurno.Caption = "Modificar turno";
            this.bbiModificarTurno.Id = 2;
            this.bbiModificarTurno.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiModificarTurno.ImageOptions.LargeImage")));
            this.bbiModificarTurno.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificarTurno.Name = "bbiModificarTurno";
            this.bbiModificarTurno.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificarTurno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarTurno_ItemClick);
            // 
            // bbiEliminarTurno
            // 
            this.bbiEliminarTurno.Caption = "Eliminar turno";
            this.bbiEliminarTurno.Id = 3;
            this.bbiEliminarTurno.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarTurno.ImageOptions.LargeImage")));
            this.bbiEliminarTurno.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminarTurno.Name = "bbiEliminarTurno";
            this.bbiEliminarTurno.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminarTurno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarTurno_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 4;
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevoTurno);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificarTurno);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarTurno);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = " ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = " ";
            // 
            // lciMain
            // 
            this.lciMain.Controls.Add(this.grdTurnos);
            this.lciMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lciMain.Location = new System.Drawing.Point(0, 122);
            this.lciMain.Name = "lciMain";
            this.lciMain.Root = this.layoutControlGroup1;
            this.lciMain.Size = new System.Drawing.Size(320, 339);
            this.lciMain.TabIndex = 1;
            this.lciMain.Text = "layoutControl1";
            // 
            // grdTurnos
            // 
            this.grdTurnos.Location = new System.Drawing.Point(12, 12);
            this.grdTurnos.MainView = this.grvTurnos;
            this.grdTurnos.MenuManager = this.ribbonControl1;
            this.grdTurnos.Name = "grdTurnos";
            this.grdTurnos.Size = new System.Drawing.Size(296, 315);
            this.grdTurnos.TabIndex = 4;
            this.grdTurnos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTurnos});
            // 
            // grvTurnos
            // 
            this.grvTurnos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion});
            this.grvTurnos.GridControl = this.grdTurnos;
            this.grvTurnos.Name = "grvTurnos";
            this.grvTurnos.OptionsBehavior.Editable = false;
            this.grvTurnos.OptionsBehavior.ReadOnly = true;
            this.grvTurnos.OptionsFind.AlwaysVisible = true;
            this.grvTurnos.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(320, 339);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTurnos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(300, 319);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmTurnosGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 461);
            this.Controls.Add(this.lciMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmTurnosGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.xfrmTurnosGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).EndInit();
            this.lciMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lciMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grdTurnos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTurnos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoTurno;
        private DevExpress.XtraBars.BarButtonItem bbiModificarTurno;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarTurno;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}