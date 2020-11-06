namespace COMBUSTIBLE.WIN
{
    partial class xfrmRecargasGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRecargasGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.rpAcciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.rgTanques = new DevExpress.XtraEditors.RadioGroup();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.grdRecargas = new DevExpress.XtraGrid.GridControl();
            this.grvRecargas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciTanques = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanques)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiModificar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAcciones});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar";
            this.bbiModificar.Id = 1;
            this.bbiModificar.ImageOptions.Image = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_plataforma_petrolera_32;
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // rpAcciones
            // 
            this.rpAcciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpAcciones.Name = "rpAcciones";
            this.rpAcciones.Text = "ribbonPage1";
            this.rpAcciones.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.rgTanques);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.dteA);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.grdRecargas);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 191, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // rgTanques
            // 
            this.rgTanques.Location = new System.Drawing.Point(77, 69);
            this.rgTanques.MenuManager = this.ribbonControl1;
            this.rgTanques.Name = "rgTanques";
            this.rgTanques.Size = new System.Drawing.Size(699, 30);
            this.rgTanques.StyleController = this.lcMain;
            this.rgTanques.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(591, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.EnterMoveNextControl = true;
            this.dteA.Location = new System.Drawing.Point(455, 45);
            this.dteA.MenuManager = this.ribbonControl1;
            this.dteA.Name = "dteA";
            this.dteA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.DisplayFormat.FormatString = "D";
            this.dteA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.EditFormat.FormatString = "D";
            this.dteA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.Mask.EditMask = "D";
            this.dteA.Size = new System.Drawing.Size(321, 20);
            this.dteA.StyleController = this.lcMain;
            this.dteA.TabIndex = 6;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.EnterMoveNextControl = true;
            this.dteDe.Location = new System.Drawing.Point(77, 45);
            this.dteDe.MenuManager = this.ribbonControl1;
            this.dteDe.Name = "dteDe";
            this.dteDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.DisplayFormat.FormatString = "D";
            this.dteDe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.EditFormat.FormatString = "D";
            this.dteDe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.Mask.EditMask = "D";
            this.dteDe.Size = new System.Drawing.Size(321, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 5;
            // 
            // grdRecargas
            // 
            this.grdRecargas.Location = new System.Drawing.Point(12, 141);
            this.grdRecargas.MainView = this.grvRecargas;
            this.grdRecargas.MenuManager = this.ribbonControl1;
            this.grdRecargas.Name = "grdRecargas";
            this.grdRecargas.Size = new System.Drawing.Size(776, 165);
            this.grdRecargas.TabIndex = 4;
            this.grdRecargas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRecargas});
            // 
            // grvRecargas
            // 
            this.grvRecargas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colProveedor,
            this.colTanque,
            this.colCantidad,
            this.colPrecio,
            this.colInicial,
            this.colFinal,
            this.colTotal});
            this.grvRecargas.GridControl = this.grdRecargas;
            this.grvRecargas.Name = "grvRecargas";
            this.grvRecargas.OptionsDetail.ShowDetailTabs = false;
            this.grvRecargas.OptionsDetail.SmartDetailExpand = false;
            this.grvRecargas.OptionsView.ShowDetailButtons = false;
            this.grvRecargas.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "FechaAlta";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFecha.OptionsFilter.AllowFilter = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 92;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.OptionsColumn.AllowFocus = false;
            this.colProveedor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProveedor.OptionsFilter.AllowFilter = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            this.colProveedor.Width = 177;
            // 
            // colTanque
            // 
            this.colTanque.Caption = "Tanque";
            this.colTanque.FieldName = "Tanque.Descripcion";
            this.colTanque.Name = "colTanque";
            this.colTanque.OptionsColumn.AllowEdit = false;
            this.colTanque.OptionsColumn.AllowFocus = false;
            this.colTanque.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTanque.OptionsFilter.AllowFilter = false;
            this.colTanque.Visible = true;
            this.colTanque.VisibleIndex = 2;
            this.colTanque.Width = 103;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.DisplayFormat.FormatString = "d";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCantidad.OptionsFilter.AllowFilter = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 72;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.DisplayFormat.FormatString = "c";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "PrecioLitro";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            // 
            // colInicial
            // 
            this.colInicial.Caption = "Inicial";
            this.colInicial.FieldName = "Lectura";
            this.colInicial.Name = "colInicial";
            this.colInicial.OptionsColumn.AllowEdit = false;
            this.colInicial.OptionsColumn.AllowFocus = false;
            this.colInicial.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInicial.OptionsFilter.AllowFilter = false;
            this.colInicial.Visible = true;
            this.colInicial.VisibleIndex = 5;
            this.colInicial.Width = 146;
            // 
            // colFinal
            // 
            this.colFinal.Caption = "Final";
            this.colFinal.FieldName = "LecturaFinal";
            this.colFinal.Name = "colFinal";
            this.colFinal.OptionsColumn.AllowEdit = false;
            this.colFinal.OptionsColumn.AllowFocus = false;
            this.colFinal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFinal.OptionsFilter.AllowFilter = false;
            this.colFinal.Visible = true;
            this.colFinal.VisibleIndex = 6;
            this.colFinal.Width = 161;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotal.OptionsFilter.AllowFilter = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcgBusqueda});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 318);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdRecargas;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 169);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciA,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciTanques});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(780, 129);
            this.lcgBusqueda.Text = "Búsqueda";
            this.lcgBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(378, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(378, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(378, 24);
            this.lciA.Text = "A:";
            this.lciA.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBuscar;
            this.layoutControlItem4.Location = new System.Drawing.Point(567, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(189, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(378, 58);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(189, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(378, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciTanques
            // 
            this.lciTanques.Control = this.rgTanques;
            this.lciTanques.Location = new System.Drawing.Point(0, 24);
            this.lciTanques.MaxSize = new System.Drawing.Size(0, 34);
            this.lciTanques.MinSize = new System.Drawing.Size(150, 34);
            this.lciTanques.Name = "lciTanques";
            this.lciTanques.Size = new System.Drawing.Size(756, 34);
            this.lciTanques.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTanques.TextSize = new System.Drawing.Size(50, 13);
            // 
            // xfrmRecargasGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmRecargasGRD.IconOptions.Icon")));
            this.Name = "xfrmRecargasGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Recargas";
            this.Load += new System.EventHandler(this.xfrmRecargasGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAcciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdRecargas;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRecargas;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colTanque;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colFinal;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.RadioGroup rgTanques;
        private DevExpress.XtraLayout.LayoutControlItem lciTanques;
    }
}