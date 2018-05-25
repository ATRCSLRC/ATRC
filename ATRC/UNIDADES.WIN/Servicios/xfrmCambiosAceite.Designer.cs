namespace UNIDADES.WIN
{
    partial class xfrmCambiosAceite
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
            this.grdUnidades = new DevExpress.XtraGrid.GridControl();
            this.grvUnidades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimoCambioAceite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProximoCambioACeite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colTipoUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdUnidades);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(800, 423);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdUnidades
            // 
            this.grdUnidades.Location = new System.Drawing.Point(12, 12);
            this.grdUnidades.MainView = this.grvUnidades;
            this.grdUnidades.MenuManager = this.ribbonControl1;
            this.grdUnidades.Name = "grdUnidades";
            this.grdUnidades.Size = new System.Drawing.Size(776, 399);
            this.grdUnidades.TabIndex = 4;
            this.grdUnidades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUnidades});
            // 
            // grvUnidades
            // 
            this.grvUnidades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnidad,
            this.colTipoUnidad,
            this.colCombustible,
            this.colUltimoCambioAceite,
            this.colProximoCambioACeite});
            this.grvUnidades.GridControl = this.grdUnidades;
            this.grvUnidades.Name = "grvUnidades";
            this.grvUnidades.OptionsBehavior.Editable = false;
            this.grvUnidades.OptionsBehavior.ReadOnly = true;
            this.grvUnidades.OptionsView.ShowAutoFilterRow = true;
            this.grvUnidades.OptionsView.ShowDetailButtons = false;
            this.grvUnidades.OptionsView.ShowGroupPanel = false;
            this.grvUnidades.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grvUnidades_RowStyle);
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "Nombre";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowFocus = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 0;
            // 
            // colCombustible
            // 
            this.colCombustible.Caption = "Combustible";
            this.colCombustible.FieldName = "Combustible";
            this.colCombustible.Name = "colCombustible";
            this.colCombustible.Visible = true;
            this.colCombustible.VisibleIndex = 2;
            // 
            // colUltimoCambioAceite
            // 
            this.colUltimoCambioAceite.Caption = "Ultimo cambio de aceite";
            this.colUltimoCambioAceite.FieldName = "UltimoCambioAceite";
            this.colUltimoCambioAceite.Name = "colUltimoCambioAceite";
            this.colUltimoCambioAceite.OptionsColumn.AllowFocus = false;
            this.colUltimoCambioAceite.Visible = true;
            this.colUltimoCambioAceite.VisibleIndex = 3;
            // 
            // colProximoCambioACeite
            // 
            this.colProximoCambioACeite.Caption = "Próximo cambio de aceite";
            this.colProximoCambioACeite.FieldName = "ProximoCambioAceite";
            this.colProximoCambioACeite.Name = "colProximoCambioACeite";
            this.colProximoCambioACeite.OptionsColumn.AllowFocus = false;
            this.colProximoCambioACeite.Visible = true;
            this.colProximoCambioACeite.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 423);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUnidades;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 403);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colTipoUnidad
            // 
            this.colTipoUnidad.Caption = "Tipo de unidad";
            this.colTipoUnidad.FieldName = "TipoUnidad";
            this.colTipoUnidad.Name = "colTipoUnidad";
            this.colTipoUnidad.Visible = true;
            this.colTipoUnidad.VisibleIndex = 1;
            // 
            // xfrmCambiosAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmCambiosAceite";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Próximos cambios de aceite";
            this.Load += new System.EventHandler(this.xfrmCambiosAceite_Load);
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
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdUnidades;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUnidades;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUltimoCambioAceite;
        private DevExpress.XtraGrid.Columns.GridColumn colProximoCambioACeite;
        private DevExpress.XtraGrid.Columns.GridColumn colCombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUnidad;
    }
}