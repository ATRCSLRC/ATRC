namespace RUTAS.WIN
{
    partial class xfrmReportesServiciosRealizados
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
            this.btnBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.rgEmpresa = new DevExpress.XtraEditors.RadioGroup();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.grdReportes = new DevExpress.XtraGrid.GridControl();
            this.grvReportes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(658, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnBusqueda);
            this.lcMain.Controls.Add(this.rgEmpresa);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.grdReportes);
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(710, 225, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(658, 457);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(331, 119);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(303, 22);
            this.btnBusqueda.StyleController = this.lcMain;
            this.btnBusqueda.TabIndex = 9;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // rgEmpresa
            // 
            this.rgEmpresa.EditValue = "Todas";
            this.rgEmpresa.Location = new System.Drawing.Point(85, 66);
            this.rgEmpresa.MenuManager = this.ribbonControl1;
            this.rgEmpresa.Name = "rgEmpresa";
            this.rgEmpresa.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Todas", "Todas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Empresa", "Empresa")});
            this.rgEmpresa.Size = new System.Drawing.Size(549, 25);
            this.rgEmpresa.StyleController = this.lcMain;
            this.rgEmpresa.TabIndex = 8;
            this.rgEmpresa.SelectedIndexChanged += new System.EventHandler(this.rgEmpresa_SelectedIndexChanged);
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.Location = new System.Drawing.Point(46, 42);
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
            this.dteDe.Size = new System.Drawing.Size(281, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 7;
            // 
            // grdReportes
            // 
            this.grdReportes.Location = new System.Drawing.Point(12, 157);
            this.grdReportes.MainView = this.grvReportes;
            this.grdReportes.MenuManager = this.ribbonControl1;
            this.grdReportes.Name = "grdReportes";
            this.grdReportes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.grdReportes.Size = new System.Drawing.Size(634, 288);
            this.grdReportes.TabIndex = 6;
            this.grdReportes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReportes});
            // 
            // grvReportes
            // 
            this.grvReportes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colEmpresa,
            this.colDescripcion,
            this.colArchivo});
            this.grvReportes.GridControl = this.grdReportes;
            this.grvReportes.Name = "grvReportes";
            this.grvReportes.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 96;
            // 
            // colEmpresa
            // 
            this.colEmpresa.Caption = "Empresa";
            this.colEmpresa.FieldName = "Empresa.Nombre";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.OptionsColumn.AllowEdit = false;
            this.colEmpresa.OptionsColumn.AllowFocus = false;
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            this.colEmpresa.Width = 126;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Semana";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 288;
            // 
            // colArchivo
            // 
            this.colArchivo.Caption = "Archivo";
            this.colArchivo.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colArchivo.Name = "colArchivo";
            this.colArchivo.Visible = true;
            this.colArchivo.VisibleIndex = 3;
            this.colArchivo.Width = 106;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(85, 95);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Properties.DisplayMember = "Nombre";
            this.lueEmpresa.Properties.ValueMember = "Oid";
            this.lueEmpresa.Size = new System.Drawing.Size(549, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 5;
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(349, 42);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.EditFormat.FormatString = "D";
            this.dteAl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Size = new System.Drawing.Size(285, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(658, 457);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdReportes;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(638, 292);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Detalles de búsqueda";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEmpresa,
            this.lciTipoEmpresa,
            this.lciFechaDe,
            this.lciAl,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(638, 145);
            this.layoutControlGroup2.Text = "Detalle de búsqueda";
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(0, 53);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(614, 24);
            this.lciEmpresa.Text = "Seleccionar:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(58, 13);
            this.lciEmpresa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciTipoEmpresa
            // 
            this.lciTipoEmpresa.Control = this.rgEmpresa;
            this.lciTipoEmpresa.Location = new System.Drawing.Point(0, 24);
            this.lciTipoEmpresa.MaxSize = new System.Drawing.Size(0, 29);
            this.lciTipoEmpresa.MinSize = new System.Drawing.Size(150, 29);
            this.lciTipoEmpresa.Name = "lciTipoEmpresa";
            this.lciTipoEmpresa.Size = new System.Drawing.Size(614, 29);
            this.lciTipoEmpresa.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoEmpresa.Text = "Empresa:";
            this.lciTipoEmpresa.TextSize = new System.Drawing.Size(58, 13);
            // 
            // lciFechaDe
            // 
            this.lciFechaDe.Control = this.dteDe;
            this.lciFechaDe.Location = new System.Drawing.Point(0, 0);
            this.lciFechaDe.Name = "lciFechaDe";
            this.lciFechaDe.Size = new System.Drawing.Size(307, 24);
            this.lciFechaDe.Text = "De:";
            this.lciFechaDe.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciFechaDe.TextSize = new System.Drawing.Size(17, 13);
            this.lciFechaDe.TextToControlDistance = 5;
            // 
            // lciAl
            // 
            this.lciAl.Control = this.dteAl;
            this.lciAl.Location = new System.Drawing.Point(307, 0);
            this.lciAl.Name = "lciAl";
            this.lciAl.Size = new System.Drawing.Size(307, 24);
            this.lciAl.Text = "Al:";
            this.lciAl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciAl.TextSize = new System.Drawing.Size(13, 13);
            this.lciAl.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBusqueda;
            this.layoutControlItem4.Location = new System.Drawing.Point(307, 77);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(307, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 77);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(307, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmReportesServiciosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 484);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmReportesServiciosRealizados";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Reportes de servicios realizados";
            this.Load += new System.EventHandler(this.xfrmReportesServiciosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraGrid.GridControl grdReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciAl;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaDe;
        private DevExpress.XtraEditors.SimpleButton btnBusqueda;
        private DevExpress.XtraEditors.RadioGroup rgEmpresa;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}