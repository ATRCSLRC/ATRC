namespace ATRCBASE.WIN
{
    partial class xfrmAccesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAccesos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdAccesos = new DevExpress.XtraGrid.GridControl();
            this.grvAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDormitorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTimeDe = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colHoraA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTimeA = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repchkComedor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repchkDormitorio = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTimeDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTimeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkComedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkDormitorio)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(738, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdAccesos);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(738, 487);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdAccesos
            // 
            this.grdAccesos.Location = new System.Drawing.Point(12, 12);
            this.grdAccesos.MainView = this.grvAccesos;
            this.grdAccesos.MenuManager = this.ribbonControl1;
            this.grdAccesos.Name = "grdAccesos";
            this.grdAccesos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repchkComedor,
            this.repchkDormitorio,
            this.repTimeDe,
            this.repTimeA});
            this.grdAccesos.Size = new System.Drawing.Size(714, 463);
            this.grdAccesos.TabIndex = 4;
            this.grdAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAccesos});
            // 
            // grvAccesos
            // 
            this.grvAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumEmpleado,
            this.colUsuario,
            this.colComedor,
            this.colDormitorio,
            this.colHoraDe,
            this.colHoraA});
            this.grvAccesos.GridControl = this.grdAccesos;
            this.grvAccesos.Name = "grvAccesos";
            this.grvAccesos.OptionsFind.AlwaysVisible = true;
            this.grvAccesos.OptionsView.AllowHtmlDrawGroups = false;
            this.grvAccesos.OptionsView.ShowDetailButtons = false;
            this.grvAccesos.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grvAccesos.OptionsView.ShowGroupPanel = false;
            this.grvAccesos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvAccesos_CellValueChanged);
            // 
            // colNumEmpleado
            // 
            this.colNumEmpleado.Caption = "Num. Empleado";
            this.colNumEmpleado.FieldName = "NumEmpleado";
            this.colNumEmpleado.Name = "colNumEmpleado";
            this.colNumEmpleado.OptionsColumn.AllowEdit = false;
            this.colNumEmpleado.OptionsColumn.AllowFocus = false;
            this.colNumEmpleado.Visible = true;
            this.colNumEmpleado.VisibleIndex = 0;
            this.colNumEmpleado.Width = 69;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Nombre";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowFocus = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 1;
            this.colUsuario.Width = 213;
            // 
            // colComedor
            // 
            this.colComedor.Caption = "Accesos a comedor";
            this.colComedor.FieldName = "AccesoComedor";
            this.colComedor.Name = "colComedor";
            this.colComedor.Visible = true;
            this.colComedor.VisibleIndex = 2;
            this.colComedor.Width = 100;
            // 
            // colDormitorio
            // 
            this.colDormitorio.Caption = "Acceso a dormitorio";
            this.colDormitorio.ColumnEdit = this.repchkDormitorio;
            this.colDormitorio.FieldName = "AccesoDormitorio";
            this.colDormitorio.Name = "colDormitorio";
            this.colDormitorio.Visible = true;
            this.colDormitorio.VisibleIndex = 3;
            this.colDormitorio.Width = 104;
            // 
            // colHoraDe
            // 
            this.colHoraDe.Caption = "De";
            this.colHoraDe.ColumnEdit = this.repTimeDe;
            this.colHoraDe.FieldName = "HoraDeDormitorio";
            this.colHoraDe.Name = "colHoraDe";
            this.colHoraDe.Visible = true;
            this.colHoraDe.VisibleIndex = 4;
            this.colHoraDe.Width = 105;
            // 
            // repTimeDe
            // 
            this.repTimeDe.AutoHeight = false;
            this.repTimeDe.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTimeDe.Name = "repTimeDe";
            // 
            // colHoraA
            // 
            this.colHoraA.Caption = "A";
            this.colHoraA.ColumnEdit = this.repTimeA;
            this.colHoraA.FieldName = "HoraADormitorio";
            this.colHoraA.Name = "colHoraA";
            this.colHoraA.Visible = true;
            this.colHoraA.VisibleIndex = 5;
            this.colHoraA.Width = 98;
            // 
            // repTimeA
            // 
            this.repTimeA.AutoHeight = false;
            this.repTimeA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTimeA.Name = "repTimeA";
            // 
            // repchkComedor
            // 
            this.repchkComedor.AutoHeight = false;
            this.repchkComedor.Name = "repchkComedor";
            this.repchkComedor.CheckedChanged += new System.EventHandler(this.repchkComedor_CheckedChanged);
            // 
            // repchkDormitorio
            // 
            this.repchkDormitorio.AutoHeight = false;
            this.repchkDormitorio.Name = "repchkDormitorio";
            this.repchkDormitorio.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repchkDormitorio.CheckedChanged += new System.EventHandler(this.repchk_CheckedChanged);
            this.repchkDormitorio.CheckStateChanged += new System.EventHandler(this.repchkDormitorio_CheckStateChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(738, 487);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdAccesos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(718, 467);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 519);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmAccesos.IconOptions.Icon")));
            this.Name = "xfrmAccesos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Accesos";
            this.Load += new System.EventHandler(this.xfrmAccesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTimeDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTimeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkComedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkDormitorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAccesos;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colComedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDormitorio;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repchkComedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repchkDormitorio;
        private DevExpress.XtraGrid.Columns.GridColumn colNumEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraDe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repTimeDe;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraA;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repTimeA;
    }
}