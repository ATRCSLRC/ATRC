namespace Unidades
{
    partial class xfrmUnidadGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmUnidadGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDetalleUnidad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSalir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdUnidades = new DevExpress.XtraGrid.GridControl();
            this.grvUnidades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiDetalleVenta = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidades)).BeginInit();
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
            this.bbiEditar,
            this.bbiEliminar,
            this.bbiSalir,
            this.bbiModificar,
            this.bbiDetalleUnidad,
            this.bbiDetalleVenta});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(859, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.LargeImage = global::Unidades.Properties.Resources.icons8_agregar_archivo_80;
            this.bbiNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
            // 
            // bbiEditar
            // 
            this.bbiEditar.Caption = "Editar";
            this.bbiEditar.Id = 2;
            this.bbiEditar.ImageOptions.LargeImage = global::Unidades.Properties.Resources.icons8_editar_archivo_80;
            this.bbiEditar.Name = "bbiEditar";
            this.bbiEditar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 3;
            this.bbiEliminar.ImageOptions.LargeImage = global::Unidades.Properties.Resources.icons8_eliminar_archivo_80;
            this.bbiEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminar_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 4;
            this.bbiSalir.ImageOptions.LargeImage = global::Unidades.Properties.Resources.Salir1;
            this.bbiSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Editar";
            this.bbiModificar.Id = 5;
            this.bbiModificar.ImageOptions.LargeImage = global::Unidades.Properties.Resources.icons8_editar_archivo_80;
            this.bbiModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // bbiDetalleUnidad
            // 
            this.bbiDetalleUnidad.Caption = "Gastos de unidad";
            this.bbiDetalleUnidad.Id = 6;
            this.bbiDetalleUnidad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDetalleUnidad.ImageOptions.Image")));
            this.bbiDetalleUnidad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDetalleUnidad.ImageOptions.LargeImage")));
            this.bbiDetalleUnidad.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7);
            this.bbiDetalleUnidad.Name = "bbiDetalleUnidad";
            this.bbiDetalleUnidad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDetalleUnidad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDetalleUnidad_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAcciones,
            this.rpgSalir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.AllowMinimize = false;
            this.rpgAcciones.AllowTextClipping = false;
            this.rpgAcciones.ItemLinks.Add(this.bbiNuevo);
            this.rpgAcciones.ItemLinks.Add(this.bbiModificar);
            this.rpgAcciones.ItemLinks.Add(this.bbiEliminar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // rpgSalir
            // 
            this.rpgSalir.AllowMinimize = false;
            this.rpgSalir.AllowTextClipping = false;
            this.rpgSalir.ItemLinks.Add(this.bbiDetalleUnidad);
            this.rpgSalir.ItemLinks.Add(this.bbiDetalleVenta);
            this.rpgSalir.ItemLinks.Add(this.bbiSalir);
            this.rpgSalir.Name = "rpgSalir";
            this.rpgSalir.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdUnidades);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(859, 328);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdUnidades
            // 
            this.grdUnidades.Location = new System.Drawing.Point(12, 12);
            this.grdUnidades.MainView = this.grvUnidades;
            this.grdUnidades.MenuManager = this.ribbonControl1;
            this.grdUnidades.Name = "grdUnidades";
            this.grdUnidades.Size = new System.Drawing.Size(835, 304);
            this.grdUnidades.TabIndex = 4;
            this.grdUnidades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUnidades});
            // 
            // grvUnidades
            // 
            this.grvUnidades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colTipoUnidad,
            this.colUnidad,
            this.colMarca,
            this.colModelo,
            this.colVIN,
            this.colPagado});
            this.grvUnidades.GridControl = this.grdUnidades;
            this.grvUnidades.Name = "grvUnidades";
            this.grvUnidades.OptionsBehavior.Editable = false;
            this.grvUnidades.OptionsBehavior.ReadOnly = true;
            this.grvUnidades.OptionsDetail.EnableMasterViewMode = false;
            this.grvUnidades.OptionsDetail.ShowDetailTabs = false;
            this.grvUnidades.OptionsDetail.SmartDetailExpand = false;
            this.grvUnidades.OptionsView.AllowHtmlDrawGroups = false;
            this.grvUnidades.OptionsView.ShowAutoFilterRow = true;
            this.grvUnidades.OptionsView.ShowDetailButtons = false;
            this.grvUnidades.OptionsView.ShowGroupPanel = false;
            this.grvUnidades.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvUnidades_FocusedRowChanged);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowFocus = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 135;
            // 
            // colTipoUnidad
            // 
            this.colTipoUnidad.Caption = "Tipo de unidad";
            this.colTipoUnidad.FieldName = "TipoUnidad";
            this.colTipoUnidad.Name = "colTipoUnidad";
            this.colTipoUnidad.OptionsColumn.AllowFocus = false;
            this.colTipoUnidad.Visible = true;
            this.colTipoUnidad.VisibleIndex = 1;
            this.colTipoUnidad.Width = 109;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "Nombre";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowFocus = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 2;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowFocus = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            this.colMarca.Width = 170;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowFocus = false;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 4;
            this.colModelo.Width = 170;
            // 
            // colVIN
            // 
            this.colVIN.Caption = "VIN";
            this.colVIN.FieldName = "VIN";
            this.colVIN.Name = "colVIN";
            this.colVIN.OptionsColumn.AllowFocus = false;
            this.colVIN.Visible = true;
            this.colVIN.VisibleIndex = 5;
            this.colVIN.Width = 174;
            // 
            // colPagado
            // 
            this.colPagado.Caption = "Saldado";
            this.colPagado.FieldName = "DetalleVenta.Pagado";
            this.colPagado.Name = "colPagado";
            this.colPagado.OptionsColumn.AllowFocus = false;
            this.colPagado.Visible = true;
            this.colPagado.VisibleIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(859, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUnidades;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(839, 308);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bbiDetalleVenta
            // 
            this.bbiDetalleVenta.Caption = "Detalle de venta";
            this.bbiDetalleVenta.Id = 7;
            this.bbiDetalleVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDetalleVenta.ImageOptions.Image")));
            this.bbiDetalleVenta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDetalleVenta.ImageOptions.LargeImage")));
            this.bbiDetalleVenta.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.bbiDetalleVenta.Name = "bbiDetalleVenta";
            this.bbiDetalleVenta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiDetalleVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDetalleVenta_ItemClick);
            // 
            // xfrmUnidadGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmUnidadGRD";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfrmUnidadGRD_FormClosing);
            this.Load += new System.EventHandler(this.xfrmUnidadGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevo;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSalir;
        private DevExpress.XtraGrid.GridControl grdUnidades;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraBars.BarButtonItem bbiDetalleUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colVIN;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colPagado;
        private DevExpress.XtraBars.BarButtonItem bbiDetalleVenta;
    }
}