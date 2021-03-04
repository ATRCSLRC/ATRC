namespace ATRCBASE.WIN
{
    partial class xfrmHistorialAccesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmHistorialAccesos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lciMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdAccesos = new DevExpress.XtraGrid.GridControl();
            this.grvAccesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGafete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).BeginInit();
            this.lciMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(835, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lciMain
            // 
            this.lciMain.Controls.Add(this.grdAccesos);
            this.lciMain.Controls.Add(this.btnBuscar);
            this.lciMain.Controls.Add(this.rgTipo);
            this.lciMain.Controls.Add(this.dteA);
            this.lciMain.Controls.Add(this.dteDe);
            this.lciMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lciMain.Location = new System.Drawing.Point(0, 32);
            this.lciMain.Name = "lciMain";
            this.lciMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 171, 650, 400);
            this.lciMain.Root = this.Root;
            this.lciMain.Size = new System.Drawing.Size(835, 545);
            this.lciMain.TabIndex = 1;
            this.lciMain.Text = "layoutControl1";
            // 
            // grdAccesos
            // 
            this.grdAccesos.Location = new System.Drawing.Point(12, 145);
            this.grdAccesos.MainView = this.grvAccesos;
            this.grdAccesos.MenuManager = this.ribbonControl1;
            this.grdAccesos.Name = "grdAccesos";
            this.grdAccesos.Size = new System.Drawing.Size(811, 388);
            this.grdAccesos.TabIndex = 8;
            this.grdAccesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAccesos});
            // 
            // grvAccesos
            // 
            this.grvAccesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGafete,
            this.colTipo,
            this.colUsuario,
            this.colHorario});
            this.grvAccesos.GridControl = this.grdAccesos;
            this.grvAccesos.Name = "grvAccesos";
            this.grvAccesos.OptionsView.ShowDetailButtons = false;
            this.grvAccesos.OptionsView.ShowGroupPanel = false;
            // 
            // colGafete
            // 
            this.colGafete.Caption = "Gafete";
            this.colGafete.FieldName = "IDCard";
            this.colGafete.Name = "colGafete";
            this.colGafete.OptionsColumn.AllowEdit = false;
            this.colGafete.OptionsColumn.AllowFocus = false;
            this.colGafete.Visible = true;
            this.colGafete.VisibleIndex = 0;
            this.colGafete.Width = 158;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "TipoAcceso";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.OptionsColumn.AllowFocus = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 149;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Nombre";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowFocus = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 2;
            this.colUsuario.Width = 256;
            // 
            // colHorario
            // 
            this.colHorario.Caption = "Horario";
            this.colHorario.DisplayFormat.FormatString = "g";
            this.colHorario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHorario.FieldName = "FechaAlta";
            this.colHorario.Name = "colHorario";
            this.colHorario.OptionsColumn.AllowEdit = false;
            this.colHorario.OptionsColumn.AllowFocus = false;
            this.colHorario.Visible = true;
            this.colHorario.VisibleIndex = 3;
            this.colHorario.Width = 223;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(392, 22);
            this.btnBuscar.StyleController = this.lciMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rgTipo
            // 
            this.rgTipo.Location = new System.Drawing.Point(60, 69);
            this.rgTipo.MenuManager = this.ribbonControl1;
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Comedor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Dormitorio"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todos")});
            this.rgTipo.Size = new System.Drawing.Size(751, 34);
            this.rgTipo.StyleController = this.lciMain;
            this.rgTipo.TabIndex = 6;
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.Location = new System.Drawing.Point(455, 45);
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
            this.dteA.Properties.MaskSettings.Set("mask", "D");
            this.dteA.Size = new System.Drawing.Size(356, 20);
            this.dteA.StyleController = this.lciMain;
            this.dteA.TabIndex = 5;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.Location = new System.Drawing.Point(60, 45);
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
            this.dteDe.Properties.MaskSettings.Set("mask", "D");
            this.dteDe.Size = new System.Drawing.Size(355, 20);
            this.dteDe.StyleController = this.lciMain;
            this.dteDe.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(835, 545);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grdAccesos;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 133);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(815, 392);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciA,
            this.lciDe,
            this.lciTipo,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(815, 133);
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(395, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(396, 24);
            this.lciA.Text = "A:";
            this.lciA.TextSize = new System.Drawing.Size(24, 13);
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(395, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(24, 13);
            // 
            // lciTipo
            // 
            this.lciTipo.Control = this.rgTipo;
            this.lciTipo.Location = new System.Drawing.Point(0, 24);
            this.lciTipo.MaxSize = new System.Drawing.Size(0, 38);
            this.lciTipo.MinSize = new System.Drawing.Size(90, 38);
            this.lciTipo.Name = "lciTipo";
            this.lciTipo.Size = new System.Drawing.Size(791, 38);
            this.lciTipo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipo.Text = "Tipo:";
            this.lciTipo.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBuscar;
            this.layoutControlItem4.Location = new System.Drawing.Point(395, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(396, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 62);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(395, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmHistorialAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 577);
            this.Controls.Add(this.lciMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmHistorialAccesos.IconOptions.Icon")));
            this.Name = "xfrmHistorialAccesos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Historial de accesos";
            this.Load += new System.EventHandler(this.xfrmHistorialAccesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).EndInit();
            this.lciMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lciMain;
        private DevExpress.XtraGrid.GridControl grdAccesos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAccesos;
        private DevExpress.XtraGrid.Columns.GridColumn colGafete;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colHorario;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciTipo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
    }
}