namespace COMBUSTIBLE.WIN
{
    partial class xfrmTanquesCombustibleGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTanquesCombustibleGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.prgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSalir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdTanques = new DevExpress.XtraGrid.GridControl();
            this.grvTanques = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colCombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTanques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNuevo,
            this.bbiModificar,
            this.bbiEliminar,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(510, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNuevo.ImageOptions.LargeImage")));
            this.bbiNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar";
            this.bbiModificar.Id = 2;
            this.bbiModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiModificar.ImageOptions.LargeImage")));
            this.bbiModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 3;
            this.bbiEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminar.ImageOptions.LargeImage")));
            this.bbiEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminar_ItemClick);
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
            this.prgAcciones,
            this.rpgSalir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // prgAcciones
            // 
            this.prgAcciones.AllowTextClipping = false;
            this.prgAcciones.ItemLinks.Add(this.bbiNuevo);
            this.prgAcciones.ItemLinks.Add(this.bbiModificar);
            this.prgAcciones.ItemLinks.Add(this.bbiEliminar);
            this.prgAcciones.Name = "prgAcciones";
            this.prgAcciones.ShowCaptionButton = false;
            // 
            // rpgSalir
            // 
            this.rpgSalir.AllowTextClipping = false;
            this.rpgSalir.ItemLinks.Add(this.bbiSalir);
            this.rpgSalir.Name = "rpgSalir";
            this.rpgSalir.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdTanques);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(510, 281);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdTanques
            // 
            this.grdTanques.Location = new System.Drawing.Point(12, 12);
            this.grdTanques.MainView = this.grvTanques;
            this.grdTanques.MenuManager = this.ribbonControl1;
            this.grdTanques.Name = "grdTanques";
            this.grdTanques.Size = new System.Drawing.Size(486, 257);
            this.grdTanques.TabIndex = 4;
            this.grdTanques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTanques});
            // 
            // grvTanques
            // 
            this.grvTanques.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNombre,
            this.colCombustible,
            this.colCapacidad});
            this.grvTanques.GridControl = this.grdTanques;
            this.grvTanques.Name = "grvTanques";
            this.grvTanques.OptionsBehavior.Editable = false;
            this.grvTanques.OptionsBehavior.ReadOnly = true;
            this.grvTanques.OptionsView.ShowAutoFilterRow = true;
            this.grvTanques.OptionsView.ShowDetailButtons = false;
            this.grvTanques.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "Oid";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 54;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Descripcion";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 200;
            // 
            // colCapacidad
            // 
            this.colCapacidad.Caption = "Capacidad";
            this.colCapacidad.FieldName = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.OptionsColumn.AllowEdit = false;
            this.colCapacidad.OptionsColumn.AllowFocus = false;
            this.colCapacidad.Visible = true;
            this.colCapacidad.VisibleIndex = 3;
            this.colCapacidad.Width = 104;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(510, 281);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdTanques;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(490, 261);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colCombustible
            // 
            this.colCombustible.Caption = "Tipo de combustible";
            this.colCombustible.FieldName = "TipoCombustible";
            this.colCombustible.Name = "colCombustible";
            this.colCombustible.OptionsColumn.AllowEdit = false;
            this.colCombustible.OptionsColumn.AllowFocus = false;
            this.colCombustible.Visible = true;
            this.colCombustible.VisibleIndex = 2;
            this.colCombustible.Width = 110;
            // 
            // xfrmTanquesCombustibleGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 403);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmTanquesCombustibleGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Tanques de combustibles";
            this.Load += new System.EventHandler(this.xfrmDepartamentoGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTanques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTanques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup prgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdTanques;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTanques;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevo;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCombustible;
    }
}