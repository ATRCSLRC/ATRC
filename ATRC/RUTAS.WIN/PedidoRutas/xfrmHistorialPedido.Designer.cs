namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmHistorialPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmHistorialPedido));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdHistorial = new DevExpress.XtraGrid.GridControl();
            this.grvHistorial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(694, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdHistorial);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(694, 417);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdHistorial
            // 
            this.grdHistorial.Location = new System.Drawing.Point(12, 12);
            this.grdHistorial.MainView = this.grvHistorial;
            this.grdHistorial.MenuManager = this.ribbonControl1;
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.grdHistorial.Size = new System.Drawing.Size(670, 393);
            this.grdHistorial.TabIndex = 4;
            this.grdHistorial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHistorial});
            // 
            // grvHistorial
            // 
            this.grvHistorial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colUsuario,
            this.colHora,
            this.colDetalle});
            this.grvHistorial.GridControl = this.grdHistorial;
            this.grvHistorial.Name = "grvHistorial";
            this.grvHistorial.OptionsView.ShowGroupPanel = false;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Options.UseTextOptions = true;
            this.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowFocus = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 59;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsuario.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsuario.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUsuario.Caption = "Usuario modificación";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowFocus = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 1;
            this.colUsuario.Width = 126;
            // 
            // colHora
            // 
            this.colHora.AppearanceCell.Options.UseTextOptions = true;
            this.colHora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHora.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHora.AppearanceHeader.Options.UseTextOptions = true;
            this.colHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHora.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHora.Caption = "Hora modificación";
            this.colHora.ColumnEdit = this.repositoryItemDateEdit1;
            this.colHora.FieldName = "HorarioModificacion";
            this.colHora.GroupFormat.FormatString = "f";
            this.colHora.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.OptionsColumn.AllowFocus = false;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 2;
            this.colHora.Width = 240;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "f";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "f";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "f";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colDetalle
            // 
            this.colDetalle.AppearanceCell.Options.UseTextOptions = true;
            this.colDetalle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetalle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDetalle.AppearanceHeader.Options.UseTextOptions = true;
            this.colDetalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetalle.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colDetalle.Caption = "Detalle";
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.OptionsColumn.AllowEdit = false;
            this.colDetalle.OptionsColumn.AllowFocus = false;
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 3;
            this.colDetalle.Width = 220;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(694, 417);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdHistorial;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(674, 397);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmHistorialPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 449);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmHistorialPedido.IconOptions.Icon")));
            this.Name = "xfrmHistorialPedido";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Historial de cambios de pedidos";
            this.Load += new System.EventHandler(this.xfrmHistorialPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdHistorial;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHistorial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}