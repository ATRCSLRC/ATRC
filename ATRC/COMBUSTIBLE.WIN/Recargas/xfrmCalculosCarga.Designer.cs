namespace COMBUSTIBLE.WIN
{
    partial class xfrmCalculosCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCalculosCarga));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAvanzado = new DevExpress.XtraBars.BarButtonItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.grdCalculos = new DevExpress.XtraGrid.GridControl();
            this.grvCalculos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalMedidor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalTanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCalculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiAvanzado});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.bbiAvanzado);
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(565, 58);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAvanzado
            // 
            this.bbiAvanzado.Caption = "Avanzado";
            this.bbiAvanzado.Id = 1;
            this.bbiAvanzado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAvanzado.ImageOptions.Image")));
            this.bbiAvanzado.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAvanzado.ImageOptions.LargeImage")));
            this.bbiAvanzado.Name = "bbiAvanzado";
            this.bbiAvanzado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAvanzado_ItemClick);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.dteA);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.grdCalculos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 58);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(565, 359);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.Location = new System.Drawing.Point(298, 45);
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
            this.dteA.Size = new System.Drawing.Size(243, 20);
            this.dteA.StyleController = this.lcMain;
            this.dteA.TabIndex = 6;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.Location = new System.Drawing.Point(44, 45);
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
            this.dteDe.Size = new System.Drawing.Size(230, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 5;
            // 
            // grdCalculos
            // 
            this.grdCalculos.Location = new System.Drawing.Point(12, 107);
            this.grdCalculos.MainView = this.grvCalculos;
            this.grdCalculos.MenuManager = this.ribbonControl1;
            this.grdCalculos.Name = "grdCalculos";
            this.grdCalculos.Size = new System.Drawing.Size(541, 240);
            this.grdCalculos.TabIndex = 4;
            this.grdCalculos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCalculos});
            // 
            // grvCalculos
            // 
            this.grvCalculos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanque,
            this.colFecha,
            this.colInicial,
            this.colFinal,
            this.colTotalMedidor,
            this.colTotalTanque,
            this.colDiferencia});
            this.grvCalculos.GridControl = this.grdCalculos;
            this.grvCalculos.Name = "grvCalculos";
            this.grvCalculos.OptionsBehavior.Editable = false;
            this.grvCalculos.OptionsBehavior.ReadOnly = true;
            this.grvCalculos.OptionsView.ShowGroupPanel = false;
            // 
            // colTanque
            // 
            this.colTanque.Caption = "Tanque";
            this.colTanque.FieldName = "Nombre";
            this.colTanque.Name = "colTanque";
            this.colTanque.OptionsColumn.AllowEdit = false;
            this.colTanque.OptionsColumn.AllowFocus = false;
            this.colTanque.Visible = true;
            this.colTanque.VisibleIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            // 
            // colInicial
            // 
            this.colInicial.Caption = "Inicial";
            this.colInicial.FieldName = "Inicial";
            this.colInicial.Name = "colInicial";
            this.colInicial.OptionsColumn.AllowEdit = false;
            this.colInicial.OptionsColumn.AllowFocus = false;
            this.colInicial.Visible = true;
            this.colInicial.VisibleIndex = 2;
            // 
            // colFinal
            // 
            this.colFinal.Caption = "Final";
            this.colFinal.FieldName = "Final";
            this.colFinal.Name = "colFinal";
            this.colFinal.OptionsColumn.AllowEdit = false;
            this.colFinal.OptionsColumn.AllowFocus = false;
            this.colFinal.Visible = true;
            this.colFinal.VisibleIndex = 3;
            // 
            // colTotalMedidor
            // 
            this.colTotalMedidor.Caption = "Total medidor";
            this.colTotalMedidor.FieldName = "TotalMedidor";
            this.colTotalMedidor.Name = "colTotalMedidor";
            this.colTotalMedidor.OptionsColumn.AllowEdit = false;
            this.colTotalMedidor.OptionsColumn.AllowFocus = false;
            this.colTotalMedidor.Visible = true;
            this.colTotalMedidor.VisibleIndex = 4;
            // 
            // colTotalTanque
            // 
            this.colTotalTanque.Caption = "Total tanque";
            this.colTotalTanque.FieldName = "TotalTanque";
            this.colTotalTanque.Name = "colTotalTanque";
            this.colTotalTanque.OptionsColumn.AllowEdit = false;
            this.colTotalTanque.OptionsColumn.AllowFocus = false;
            this.colTotalTanque.Visible = true;
            this.colTotalTanque.VisibleIndex = 5;
            // 
            // colDiferencia
            // 
            this.colDiferencia.Caption = "Diferencia";
            this.colDiferencia.FieldName = "Diferencia";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.OptionsColumn.AllowEdit = false;
            this.colDiferencia.OptionsColumn.AllowFocus = false;
            this.colDiferencia.Visible = true;
            this.colDiferencia.VisibleIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcgBusqueda});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(565, 359);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCalculos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(545, 244);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciA,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(545, 95);
            this.lcgBusqueda.Text = "Búsqueda";
            this.lcgBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(254, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(17, 13);
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(254, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(267, 24);
            this.lciA.Text = "A:";
            this.lciA.TextSize = new System.Drawing.Size(17, 13);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(263, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnBuscar;
            this.layoutControlItem2.Location = new System.Drawing.Point(254, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(267, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(254, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmCalculosCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 417);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmCalculosCarga.IconOptions.Icon")));
            this.Name = "xfrmCalculosCarga";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Calculos de carga";
            this.Load += new System.EventHandler(this.xfrmCalculosCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCalculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grdCalculos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCalculos;
        private DevExpress.XtraGrid.Columns.GridColumn colTanque;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalMedidor;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalTanque;
        private DevExpress.XtraGrid.Columns.GridColumn colDiferencia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiAvanzado;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}