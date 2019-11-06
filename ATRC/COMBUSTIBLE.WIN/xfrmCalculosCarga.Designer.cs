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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCalculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(565, 49);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdCalculos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 49);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(565, 368);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdCalculos
            // 
            this.grdCalculos.Location = new System.Drawing.Point(12, 12);
            this.grdCalculos.MainView = this.grvCalculos;
            this.grdCalculos.MenuManager = this.ribbonControl1;
            this.grdCalculos.Name = "grdCalculos";
            this.grdCalculos.Size = new System.Drawing.Size(541, 344);
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
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(565, 368);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCalculos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(545, 348);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmCalculosCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 417);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmCalculosCarga";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Calculos de carga";
            this.Load += new System.EventHandler(this.xfrmCalculosCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCalculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCalculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
    }
}