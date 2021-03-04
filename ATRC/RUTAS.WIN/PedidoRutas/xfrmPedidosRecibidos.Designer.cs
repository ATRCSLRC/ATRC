namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmPedidosRecibidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPedidosRecibidos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAprobar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRechazado = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRevicion = new DevExpress.XtraBars.BarButtonItem();
            this.rpAccion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdPedidosRecibidos = new DevExpress.XtraGrid.GridControl();
            this.grvPedidosRecibidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadRutas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coilHistorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeHistorial = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribeRutas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidosRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).BeginInit();
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
            this.bbiAprobar,
            this.bbiRechazado,
            this.bbiRevicion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAccion});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(895, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAprobar
            // 
            this.bbiAprobar.Caption = "Marcar como aprobado";
            this.bbiAprobar.Id = 1;
            this.bbiAprobar.Name = "bbiAprobar";
            this.bbiAprobar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiAprobar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAprobar_ItemClick);
            // 
            // bbiRechazado
            // 
            this.bbiRechazado.Caption = "Marcar como rechazado";
            this.bbiRechazado.Id = 2;
            this.bbiRechazado.Name = "bbiRechazado";
            this.bbiRechazado.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRechazado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiRechazado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRechazado_ItemClick);
            // 
            // bbiRevicion
            // 
            this.bbiRevicion.Caption = "Marcar como revisión";
            this.bbiRevicion.Id = 3;
            this.bbiRevicion.Name = "bbiRevicion";
            this.bbiRevicion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRevicion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRevicion_ItemClick);
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
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRevicion);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAprobar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRechazado);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdPedidosRecibidos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(895, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdPedidosRecibidos
            // 
            this.grdPedidosRecibidos.Location = new System.Drawing.Point(12, 12);
            this.grdPedidosRecibidos.MainView = this.grvPedidosRecibidos;
            this.grdPedidosRecibidos.MenuManager = this.ribbonControl1;
            this.grdPedidosRecibidos.Name = "grdPedidosRecibidos";
            this.grdPedidosRecibidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeRutas,
            this.ribeHistorial});
            this.grdPedidosRecibidos.Size = new System.Drawing.Size(871, 294);
            this.grdPedidosRecibidos.TabIndex = 4;
            this.grdPedidosRecibidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPedidosRecibidos});
            // 
            // grvPedidosRecibidos
            // 
            this.grvPedidosRecibidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colEmpresa,
            this.colNombre,
            this.colFechaPedido,
            this.colCantidadRutas,
            this.colCreado,
            this.colRutas,
            this.coilHistorial});
            this.grvPedidosRecibidos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvPedidosRecibidos.GridControl = this.grdPedidosRecibidos;
            this.grvPedidosRecibidos.Name = "grvPedidosRecibidos";
            this.grvPedidosRecibidos.OptionsFind.AlwaysVisible = true;
            this.grvPedidosRecibidos.OptionsView.ShowDetailButtons = false;
            this.grvPedidosRecibidos.OptionsView.ShowGroupPanel = false;
            this.grvPedidosRecibidos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvPedidosRecibidos_RowClick);
            this.grvPedidosRecibidos.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvPedidosRecibidos_CustomRowCellEdit);
            this.grvPedidosRecibidos.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvPedidosRecibidos_CustomColumnDisplayText);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowFocus = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 77;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.AllowFocus = false;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            this.colEmpresa.Width = 107;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 125;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.Caption = "Fecha de pedido";
            this.colFechaPedido.FieldName = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.OptionsColumn.AllowEdit = false;
            this.colFechaPedido.OptionsColumn.AllowFocus = false;
            this.colFechaPedido.Visible = true;
            this.colFechaPedido.VisibleIndex = 3;
            this.colFechaPedido.Width = 88;
            // 
            // colCantidadRutas
            // 
            this.colCantidadRutas.Caption = "Cantidad de rutas";
            this.colCantidadRutas.FieldName = "Rutas";
            this.colCantidadRutas.Name = "colCantidadRutas";
            this.colCantidadRutas.OptionsColumn.AllowEdit = false;
            this.colCantidadRutas.OptionsColumn.AllowFocus = false;
            this.colCantidadRutas.Visible = true;
            this.colCantidadRutas.VisibleIndex = 4;
            this.colCantidadRutas.Width = 95;
            // 
            // colCreado
            // 
            this.colCreado.Caption = "Creado";
            this.colCreado.FieldName = "Usuario";
            this.colCreado.Name = "colCreado";
            this.colCreado.OptionsColumn.AllowEdit = false;
            this.colCreado.OptionsColumn.AllowFocus = false;
            this.colCreado.Visible = true;
            this.colCreado.VisibleIndex = 5;
            this.colCreado.Width = 199;
            // 
            // colRutas
            // 
            this.colRutas.Caption = "Rutas";
            this.colRutas.Name = "colRutas";
            this.colRutas.Visible = true;
            this.colRutas.VisibleIndex = 6;
            this.colRutas.Width = 50;
            // 
            // coilHistorial
            // 
            this.coilHistorial.Caption = "Historial de cambios";
            this.coilHistorial.ColumnEdit = this.ribeHistorial;
            this.coilHistorial.Name = "coilHistorial";
            this.coilHistorial.Visible = true;
            this.coilHistorial.VisibleIndex = 7;
            this.coilHistorial.Width = 105;
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
            // ribeRutas
            // 
            this.ribeRutas.AutoHeight = false;
            this.ribeRutas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribeRutas.Name = "ribeRutas";
            this.ribeRutas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeRutas.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeRutas_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(895, 318);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdPedidosRecibidos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(875, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmPedidosRecibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPedidosRecibidos.IconOptions.Icon")));
            this.Name = "xfrmPedidosRecibidos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Pedidos recibidos";
            this.Load += new System.EventHandler(this.xfrmPedidosRecibidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidosRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAccion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdPedidosRecibidos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPedidosRecibidos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiAprobar;
        private DevExpress.XtraBars.BarButtonItem bbiRechazado;
        private DevExpress.XtraBars.BarButtonItem bbiRevicion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadRutas;
        private DevExpress.XtraGrid.Columns.GridColumn colCreado;
        private DevExpress.XtraGrid.Columns.GridColumn colRutas;
        private DevExpress.XtraGrid.Columns.GridColumn coilHistorial;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeRutas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeHistorial;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
    }
}