namespace RUTAS.WIN
{
    partial class xfrmAclaracionesRecibidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAclaracionesRecibidas));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAprobar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRechazar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRevision = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdAclaraciones = new DevExpress.XtraGrid.GridControl();
            this.grvAclaraciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeHistorial = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribeDescarga = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAclaraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAclaraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDescarga)).BeginInit();
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
            this.bbiRechazar,
            this.bbiRevision});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAprobar
            // 
            this.bbiAprobar.Caption = "Aprobar";
            this.bbiAprobar.Id = 1;
            this.bbiAprobar.Name = "bbiAprobar";
            this.bbiAprobar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiAprobar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAprobar_ItemClick);
            // 
            // bbiRechazar
            // 
            this.bbiRechazar.Caption = "Rechazar";
            this.bbiRechazar.Id = 2;
            this.bbiRechazar.Name = "bbiRechazar";
            this.bbiRechazar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiRechazar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRechazar_ItemClick);
            // 
            // bbiRevision
            // 
            this.bbiRevision.Caption = "Revisión";
            this.bbiRevision.Id = 3;
            this.bbiRevision.Name = "bbiRevision";
            this.bbiRevision.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRevision.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRevision_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRevision);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAprobar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRechazar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdAclaraciones);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdAclaraciones
            // 
            this.grdAclaraciones.Location = new System.Drawing.Point(12, 12);
            this.grdAclaraciones.MainView = this.grvAclaraciones;
            this.grdAclaraciones.MenuManager = this.ribbonControl1;
            this.grdAclaraciones.Name = "grdAclaraciones";
            this.grdAclaraciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeDescarga,
            this.ribeHistorial});
            this.grdAclaraciones.Size = new System.Drawing.Size(776, 294);
            this.grdAclaraciones.TabIndex = 4;
            this.grdAclaraciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAclaraciones});
            // 
            // grvAclaraciones
            // 
            this.grvAclaraciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colFecha,
            this.colPedido,
            this.colDescripcion,
            this.colEmpresa,
            this.colDescarga,
            this.colHistoria});
            this.grvAclaraciones.GridControl = this.grdAclaraciones;
            this.grvAclaraciones.Name = "grvAclaraciones";
            this.grvAclaraciones.OptionsFind.AlwaysVisible = true;
            this.grvAclaraciones.OptionsView.ShowGroupPanel = false;
            this.grvAclaraciones.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvAclaraciones_RowClick);
            this.grvAclaraciones.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvAclaraciones_CustomRowCellEdit);
            this.grvAclaraciones.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvAclaraciones_FocusedRowChanged);
            this.grvAclaraciones.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvAclaraciones_CustomColumnDisplayText);
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
            this.colEstado.Width = 107;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "FechaAlta";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 107;
            // 
            // colPedido
            // 
            this.colPedido.Caption = "Pedido";
            this.colPedido.FieldName = "Pedidos";
            this.colPedido.Name = "colPedido";
            this.colPedido.OptionsColumn.AllowEdit = false;
            this.colPedido.OptionsColumn.AllowFocus = false;
            this.colPedido.Visible = true;
            this.colPedido.VisibleIndex = 2;
            this.colPedido.Width = 107;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 3;
            this.colDescripcion.Width = 177;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Empresas";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.AllowFocus = false;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 4;
            this.colEmpresa.Width = 152;
            // 
            // colDescarga
            // 
            this.colDescarga.Caption = "Descarga";
            this.colDescarga.Name = "colDescarga";
            this.colDescarga.Visible = true;
            this.colDescarga.VisibleIndex = 5;
            this.colDescarga.Width = 53;
            // 
            // colHistoria
            // 
            this.colHistoria.Caption = "Historia";
            this.colHistoria.ColumnEdit = this.ribeHistorial;
            this.colHistoria.Name = "colHistoria";
            this.colHistoria.Visible = true;
            this.colHistoria.VisibleIndex = 6;
            this.colHistoria.Width = 48;
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
            // ribeDescarga
            // 
            this.ribeDescarga.AutoHeight = false;
            this.ribeDescarga.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribeDescarga.Name = "ribeDescarga";
            this.ribeDescarga.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDescarga.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeDescarga_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 318);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdAclaraciones;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmAclaracionesRecibidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmAclaracionesRecibidas.IconOptions.Icon")));
            this.Name = "xfrmAclaracionesRecibidas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Aclaraciones recibidas";
            this.Load += new System.EventHandler(this.xfrmAclaracionesRecibidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAclaraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAclaraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDescarga)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdAclaraciones;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAclaraciones;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiAprobar;
        private DevExpress.XtraBars.BarButtonItem bbiRechazar;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescarga;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDescarga;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeHistorial;
        private DevExpress.XtraBars.BarButtonItem bbiRevision;
    }
}