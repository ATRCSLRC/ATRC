namespace ALMACEN.WIN
{
    partial class xfrmBusquedaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmBusquedaArticulos));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueCatalogo = new DevExpress.XtraEditors.LookUpEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.grvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.rgBusqueda = new DevExpress.XtraEditors.RadioGroup();
            this.txtFiltro = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcibtnBuscar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciTipoBusqueda = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBusqueda = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCatalogos = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCatalogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcibtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCatalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnLimpiar);
            this.lcMain.Controls.Add(this.lueCatalogo);
            this.lcMain.Controls.Add(this.grdArticulos);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.rgBusqueda);
            this.lcMain.Controls.Add(this.txtFiltro);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(800, 423);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lueCatalogo
            // 
            this.lueCatalogo.Location = new System.Drawing.Point(136, 66);
            this.lueCatalogo.MenuManager = this.ribbonControl1;
            this.lueCatalogo.Name = "lueCatalogo";
            this.lueCatalogo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCatalogo.Properties.NullText = "";
            this.lueCatalogo.Size = new System.Drawing.Size(640, 20);
            this.lueCatalogo.StyleController = this.lcMain;
            this.lueCatalogo.TabIndex = 8;
            this.lueCatalogo.EditValueChanged += new System.EventHandler(this.lueCatalogo_EditValueChanged);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // grdArticulos
            // 
            this.grdArticulos.Location = new System.Drawing.Point(12, 157);
            this.grdArticulos.MainView = this.grvArticulos;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribEditar});
            this.grdArticulos.Size = new System.Drawing.Size(776, 254);
            this.grdArticulos.TabIndex = 7;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvArticulos});
            // 
            // grvArticulos
            // 
            this.grvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col,
            this.colCodigo,
            this.colNombre,
            this.colExistencia,
            this.colProveedor,
            this.colFactura,
            this.colFecha});
            this.grvArticulos.GridControl = this.grdArticulos;
            this.grvArticulos.Name = "grvArticulos";
            this.grvArticulos.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.grvArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // col
            // 
            this.col.Caption = "Editar";
            this.col.ColumnEdit = this.ribEditar;
            this.col.Name = "col";
            this.col.Visible = true;
            this.col.VisibleIndex = 0;
            this.col.Width = 40;
            // 
            // ribEditar
            // 
            this.ribEditar.AutoHeight = false;
            this.ribEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.ribEditar.Name = "ribEditar";
            this.ribEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribEditar_ButtonClick);
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 119;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 119;
            // 
            // colExistencia
            // 
            this.colExistencia.Caption = "Existencia";
            this.colExistencia.FieldName = "Cantidad";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.OptionsColumn.ReadOnly = true;
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 3;
            this.colExistencia.Width = 119;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor.Nombre";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.ReadOnly = true;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 4;
            this.colProveedor.Width = 119;
            // 
            // colFactura
            // 
            this.colFactura.Caption = "Factura";
            this.colFactura.FieldName = "NumFactura";
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.ReadOnly = true;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 5;
            this.colFactura.Width = 119;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha entrada";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 6;
            this.colFecha.Width = 123;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(538, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rgBusqueda
            // 
            this.rgBusqueda.Location = new System.Drawing.Point(136, 90);
            this.rgBusqueda.Name = "rgBusqueda";
            this.rgBusqueda.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Código"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Descripción"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Número de parte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Marca"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Proveedor")});
            this.rgBusqueda.Size = new System.Drawing.Size(640, 25);
            this.rgBusqueda.StyleController = this.lcMain;
            this.rgBusqueda.TabIndex = 5;
            this.rgBusqueda.SelectedIndexChanged += new System.EventHandler(this.rgBusqueda_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(136, 42);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(640, 20);
            this.txtFiltro.StyleController = this.lcMain;
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgBusqueda,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 423);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcibtnBuscar,
            this.emptySpaceItem1,
            this.lciTipoBusqueda,
            this.lciBusqueda,
            this.lciCatalogos,
            this.layoutControlItem1});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(780, 145);
            this.lcgBusqueda.Text = "Detalle de búsqueda";
            // 
            // lcibtnBuscar
            // 
            this.lcibtnBuscar.Control = this.btnBuscar;
            this.lcibtnBuscar.Location = new System.Drawing.Point(514, 77);
            this.lcibtnBuscar.Name = "lcibtnBuscar";
            this.lcibtnBuscar.Size = new System.Drawing.Size(121, 26);
            this.lcibtnBuscar.TextSize = new System.Drawing.Size(0, 0);
            this.lcibtnBuscar.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 77);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(514, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciTipoBusqueda
            // 
            this.lciTipoBusqueda.Control = this.rgBusqueda;
            this.lciTipoBusqueda.Location = new System.Drawing.Point(0, 48);
            this.lciTipoBusqueda.Name = "lciTipoBusqueda";
            this.lciTipoBusqueda.Size = new System.Drawing.Size(756, 29);
            this.lciTipoBusqueda.Text = "Buscar por:";
            this.lciTipoBusqueda.TextSize = new System.Drawing.Size(109, 13);
            // 
            // lciBusqueda
            // 
            this.lciBusqueda.Control = this.txtFiltro;
            this.lciBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lciBusqueda.Name = "lciBusqueda";
            this.lciBusqueda.Size = new System.Drawing.Size(756, 24);
            this.lciBusqueda.Text = "Ingresé código:";
            this.lciBusqueda.TextSize = new System.Drawing.Size(109, 13);
            // 
            // lciCatalogos
            // 
            this.lciCatalogos.Control = this.lueCatalogo;
            this.lciCatalogos.Location = new System.Drawing.Point(0, 24);
            this.lciCatalogos.Name = "lciCatalogos";
            this.lciCatalogos.Size = new System.Drawing.Size(756, 24);
            this.lciCatalogos.Text = "Seleccione una opción:";
            this.lciCatalogos.TextSize = new System.Drawing.Size(109, 13);
            this.lciCatalogos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.grdArticulos;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 258);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(659, 119);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 22);
            this.btnLimpiar.StyleController = this.lcMain;
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnLimpiar;
            this.layoutControlItem1.Location = new System.Drawing.Point(635, 77);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmBusquedaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmBusquedaArticulos";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de articulos";
            this.Load += new System.EventHandler(this.xfrmBusquedaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueCatalogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcibtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCatalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvArticulos;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.RadioGroup rgBusqueda;
        private DevExpress.XtraEditors.TextEdit txtFiltro;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lcibtnBuscar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribEditar;
        private DevExpress.XtraEditors.LookUpEdit lueCatalogo;
        private DevExpress.XtraLayout.LayoutControlItem lciCatalogos;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}