namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPedidos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAccion = new DevExpress.XtraBars.BarButtonItem();
            this.rpAccion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.grdPedidos = new DevExpress.XtraGrid.GridControl();
            this.grvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadRutas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeRutas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colHistorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeHistorial = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpresas = new DevExpress.XtraLayout.LayoutControlItem();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiAccion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAccion});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(941, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAccion
            // 
            this.bbiAccion.Caption = "barButtonItem1";
            this.bbiAccion.Id = 1;
            this.bbiAccion.Name = "bbiAccion";
            this.bbiAccion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rpAccion
            // 
            this.rpAccion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpAccion.Name = "rpAccion";
            this.rpAccion.Text = "ribbonPage1";
            this.rpAccion.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAccion);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.dteA);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.grdPedidos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 171, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(941, 392);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(320, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(72, 69);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Properties.DisplayMember = "Nombre";
            this.lueEmpresa.Properties.ValueMember = "Oid";
            this.lueEmpresa.Size = new System.Drawing.Size(845, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 7;
            this.lueEmpresa.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lueEmpresa_CustomDisplayText);
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.Location = new System.Drawing.Point(520, 45);
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
            this.dteA.Size = new System.Drawing.Size(397, 20);
            this.dteA.StyleController = this.lcMain;
            this.dteA.TabIndex = 6;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.Location = new System.Drawing.Point(72, 45);
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
            this.dteDe.Size = new System.Drawing.Size(396, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 5;
            // 
            // grdPedidos
            // 
            this.grdPedidos.Location = new System.Drawing.Point(12, 131);
            this.grdPedidos.MainView = this.grvPedidos;
            this.grdPedidos.MenuManager = this.ribbonControl1;
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeRutas,
            this.ribeHistorial});
            this.grdPedidos.Size = new System.Drawing.Size(917, 249);
            this.grdPedidos.TabIndex = 4;
            this.grdPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPedidos});
            // 
            // grvPedidos
            // 
            this.grvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colEmpresa,
            this.colNombre,
            this.colFechaPedido,
            this.colCantidadRutas,
            this.colCreado,
            this.colRutas,
            this.colHistorial});
            this.grvPedidos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvPedidos.GridControl = this.grdPedidos;
            this.grvPedidos.Name = "grvPedidos";
            this.grvPedidos.OptionsView.ShowGroupPanel = false;
            this.grvPedidos.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvPedidos_CustomRowCellEdit);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.Caption = "Fecha de pedido";
            this.colFechaPedido.FieldName = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.Visible = true;
            this.colFechaPedido.VisibleIndex = 3;
            // 
            // colCantidadRutas
            // 
            this.colCantidadRutas.Caption = "Cantidad de rutas";
            this.colCantidadRutas.FieldName = "Rutas";
            this.colCantidadRutas.Name = "colCantidadRutas";
            this.colCantidadRutas.Visible = true;
            this.colCantidadRutas.VisibleIndex = 4;
            // 
            // colCreado
            // 
            this.colCreado.Caption = "Creado";
            this.colCreado.FieldName = "UsuarioCreacion";
            this.colCreado.Name = "colCreado";
            this.colCreado.Visible = true;
            this.colCreado.VisibleIndex = 5;
            // 
            // colRutas
            // 
            this.colRutas.Caption = "Rutas";
            this.colRutas.Name = "colRutas";
            this.colRutas.Visible = true;
            this.colRutas.VisibleIndex = 6;
            // 
            // ribeRutas
            // 
            this.ribeRutas.AutoHeight = false;
            this.ribeRutas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribeRutas.Name = "ribeRutas";
            this.ribeRutas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeRutas.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeRutas_ButtonClick);
            // 
            // colHistorial
            // 
            this.colHistorial.Caption = "Historial cambios";
            this.colHistorial.ColumnEdit = this.ribeHistorial;
            this.colHistorial.Name = "colHistorial";
            this.colHistorial.Visible = true;
            this.colHistorial.VisibleIndex = 7;
            // 
            // ribeHistorial
            // 
            this.ribeHistorial.AutoHeight = false;
            this.ribeHistorial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribeHistorial.Name = "ribeHistorial";
            this.ribeHistorial.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeHistorial.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeHistorial_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcgBusqueda});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(941, 392);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdPedidos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(921, 253);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciA,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.lciEmpresas});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(921, 119);
            this.lcgBusqueda.Text = "Detalles de búsqueda";
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(448, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(45, 13);
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(448, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(449, 24);
            this.lciA.Text = "A:";
            this.lciA.TextSize = new System.Drawing.Size(45, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(573, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnBuscar;
            this.layoutControlItem5.Location = new System.Drawing.Point(573, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(324, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lciEmpresas
            // 
            this.lciEmpresas.Control = this.lueEmpresa;
            this.lciEmpresas.Location = new System.Drawing.Point(0, 24);
            this.lciEmpresas.Name = "lciEmpresas";
            this.lciEmpresas.Size = new System.Drawing.Size(897, 24);
            this.lciEmpresas.Text = "Empresa:";
            this.lciEmpresas.TextSize = new System.Drawing.Size(45, 13);
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            // 
            // xfrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 524);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPedidos.IconOptions.Icon")));
            this.Name = "xfrmPedidos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.xfrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAccion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPedidos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiAccion;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadRutas;
        private DevExpress.XtraGrid.Columns.GridColumn colCreado;
        private DevExpress.XtraGrid.Columns.GridColumn colRutas;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorial;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeRutas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeHistorial;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
    }
}