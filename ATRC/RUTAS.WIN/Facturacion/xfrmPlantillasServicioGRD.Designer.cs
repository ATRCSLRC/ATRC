namespace RUTAS.WIN.Facturacion
{
    partial class xfrmPlantillasServicioGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPlantillasServicioGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevaPlantilla = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificarPlantilla = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarPlantilla = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdPlantillaServiciosRealizados = new DevExpress.XtraGrid.GridControl();
            this.grvPlantillaServiciosRealizados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantillaServiciosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPlantillaServiciosRealizados)).BeginInit();
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
            this.bbiNuevaPlantilla,
            this.bbiModificarPlantilla,
            this.bbiEliminarPlantilla,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(300, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevaPlantilla
            // 
            this.bbiNuevaPlantilla.Caption = "Nueva plantilla";
            this.bbiNuevaPlantilla.Id = 1;
            this.bbiNuevaPlantilla.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_herramientas_del_administrador_32__1_;
            this.bbiNuevaPlantilla.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevaPlantilla.Name = "bbiNuevaPlantilla";
            this.bbiNuevaPlantilla.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevaPlantilla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevaPlantilla_ItemClick);
            // 
            // bbiModificarPlantilla
            // 
            this.bbiModificarPlantilla.Caption = "Modificar plantilla";
            this.bbiModificarPlantilla.Id = 2;
            this.bbiModificarPlantilla.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_herramientas_del_administrador_32__2_;
            this.bbiModificarPlantilla.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificarPlantilla.Name = "bbiModificarPlantilla";
            this.bbiModificarPlantilla.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificarPlantilla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarPlantilla_ItemClick);
            // 
            // bbiEliminarPlantilla
            // 
            this.bbiEliminarPlantilla.Caption = "Eliminar plantilla";
            this.bbiEliminarPlantilla.Id = 3;
            this.bbiEliminarPlantilla.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_herramientas_del_administrador_32__3_;
            this.bbiEliminarPlantilla.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminarPlantilla.Name = "bbiEliminarPlantilla";
            this.bbiEliminarPlantilla.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminarPlantilla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarPlantilla_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 4;
            this.bbiSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSalir.ImageOptions.Image")));
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevaPlantilla);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificarPlantilla);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarPlantilla);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdPlantillaServiciosRealizados);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(300, 302);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdPlantillaServiciosRealizados
            // 
            this.grdPlantillaServiciosRealizados.Location = new System.Drawing.Point(12, 12);
            this.grdPlantillaServiciosRealizados.MainView = this.grvPlantillaServiciosRealizados;
            this.grdPlantillaServiciosRealizados.MenuManager = this.ribbonControl1;
            this.grdPlantillaServiciosRealizados.Name = "grdPlantillaServiciosRealizados";
            this.grdPlantillaServiciosRealizados.Size = new System.Drawing.Size(276, 278);
            this.grdPlantillaServiciosRealizados.TabIndex = 3;
            this.grdPlantillaServiciosRealizados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPlantillaServiciosRealizados});
            // 
            // grvPlantillaServiciosRealizados
            // 
            this.grvPlantillaServiciosRealizados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre});
            this.grvPlantillaServiciosRealizados.GridControl = this.grdPlantillaServiciosRealizados;
            this.grvPlantillaServiciosRealizados.Name = "grvPlantillaServiciosRealizados";
            this.grvPlantillaServiciosRealizados.OptionsBehavior.Editable = false;
            this.grvPlantillaServiciosRealizados.OptionsBehavior.ReadOnly = true;
            this.grvPlantillaServiciosRealizados.OptionsDetail.ShowDetailTabs = false;
            this.grvPlantillaServiciosRealizados.OptionsView.AllowHtmlDrawGroups = false;
            this.grvPlantillaServiciosRealizados.OptionsView.ShowDetailButtons = false;
            this.grvPlantillaServiciosRealizados.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Empresa.Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(300, 302);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdPlantillaServiciosRealizados;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(280, 282);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmPlantillasServicioGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 434);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPlantillasServicioGRD.IconOptions.Icon")));
            this.Name = "xfrmPlantillasServicioGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Plantillas de servicios realizados";
            this.Load += new System.EventHandler(this.xfrmPlantillasServicioGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantillaServiciosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPlantillaServiciosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdPlantillaServiciosRealizados;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPlantillaServiciosRealizados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevaPlantilla;
        private DevExpress.XtraBars.BarButtonItem bbiModificarPlantilla;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarPlantilla;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}