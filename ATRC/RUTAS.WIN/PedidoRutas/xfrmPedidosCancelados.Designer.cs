namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmPedidosCancelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPedidosCancelados));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdPedidosCancelados = new DevExpress.XtraGrid.GridControl();
            this.grvPedidosCancelados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosCancelados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidosCancelados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(942, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdPedidosCancelados);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(942, 418);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdPedidosCancelados
            // 
            this.grdPedidosCancelados.Location = new System.Drawing.Point(12, 12);
            this.grdPedidosCancelados.MainView = this.grvPedidosCancelados;
            this.grdPedidosCancelados.MenuManager = this.ribbonControl1;
            this.grdPedidosCancelados.Name = "grdPedidosCancelados";
            this.grdPedidosCancelados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeRutas,
            this.ribeHistorial});
            this.grdPedidosCancelados.Size = new System.Drawing.Size(918, 394);
            this.grdPedidosCancelados.TabIndex = 4;
            this.grdPedidosCancelados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPedidosCancelados});
            // 
            // grvPedidosCancelados
            // 
            this.grvPedidosCancelados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colEmpresa,
            this.colNombre,
            this.colFechaPedido,
            this.colCantidadRutas,
            this.colCreado,
            this.colRutas,
            this.colHistorial});
            this.grvPedidosCancelados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvPedidosCancelados.GridControl = this.grdPedidosCancelados;
            this.grvPedidosCancelados.Name = "grvPedidosCancelados";
            this.grvPedidosCancelados.OptionsFind.AlwaysVisible = true;
            this.grvPedidosCancelados.OptionsView.ShowGroupPanel = false;
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
            this.colEstado.Width = 83;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            this.colEmpresa.Width = 114;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 144;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.Caption = "Fecha de pedido";
            this.colFechaPedido.FieldName = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.Visible = true;
            this.colFechaPedido.VisibleIndex = 3;
            this.colFechaPedido.Width = 89;
            // 
            // colCantidadRutas
            // 
            this.colCantidadRutas.Caption = "Cantidad de rutas";
            this.colCantidadRutas.FieldName = "Rutas";
            this.colCantidadRutas.Name = "colCantidadRutas";
            this.colCantidadRutas.Visible = true;
            this.colCantidadRutas.VisibleIndex = 4;
            this.colCantidadRutas.Width = 94;
            // 
            // colCreado
            // 
            this.colCreado.Caption = "Creado";
            this.colCreado.FieldName = "UsuarioCreacion";
            this.colCreado.Name = "colCreado";
            this.colCreado.Visible = true;
            this.colCreado.VisibleIndex = 5;
            this.colCreado.Width = 163;
            // 
            // colRutas
            // 
            this.colRutas.Caption = "Rutas";
            this.colRutas.ColumnEdit = this.ribeRutas;
            this.colRutas.Name = "colRutas";
            this.colRutas.Visible = true;
            this.colRutas.VisibleIndex = 6;
            this.colRutas.Width = 95;
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
            this.colHistorial.Caption = "Historial pedido";
            this.colHistorial.ColumnEdit = this.ribeHistorial;
            this.colHistorial.Name = "colHistorial";
            this.colHistorial.Visible = true;
            this.colHistorial.VisibleIndex = 7;
            this.colHistorial.Width = 111;
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
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(942, 418);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdPedidosCancelados;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(922, 398);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmPedidosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPedidosCancelados.IconOptions.Icon")));
            this.Name = "xfrmPedidosCancelados";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Pedidos cancelados";
            this.Load += new System.EventHandler(this.xfrmPedidosCancelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosCancelados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedidosCancelados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdPedidosCancelados;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPedidosCancelados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadRutas;
        private DevExpress.XtraGrid.Columns.GridColumn colCreado;
        private DevExpress.XtraGrid.Columns.GridColumn colRutas;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorial;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeRutas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeHistorial;
    }
}