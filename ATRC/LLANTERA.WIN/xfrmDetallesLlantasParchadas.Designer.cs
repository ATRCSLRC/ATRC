namespace LLANTERA.WIN
{
    partial class xfrmDetallesLlantasParchadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDetallesLlantasParchadas));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.grdParches = new DevExpress.XtraGrid.GridControl();
            this.grvCambios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnLimpiar);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.grdParches);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDel);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(829, 171, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(816, 423);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(535, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(257, 22);
            this.btnLimpiar.StyleController = this.lcMain;
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar (F12)";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBuscar.Location = new System.Drawing.Point(273, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(258, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar (F5)";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdParches
            // 
            this.grdParches.Location = new System.Drawing.Point(12, 128);
            this.grdParches.MainView = this.grvCambios;
            this.grdParches.Name = "grdParches";
            this.grdParches.Size = new System.Drawing.Size(792, 283);
            this.grdParches.TabIndex = 7;
            this.grdParches.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCambios});
            // 
            // grvCambios
            // 
            this.grvCambios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2});
            this.grvCambios.GridControl = this.grdParches;
            this.grvCambios.Name = "grvCambios";
            this.grvCambios.OptionsBehavior.Editable = false;
            this.grvCambios.OptionsBehavior.ReadOnly = true;
            this.grvCambios.OptionsDetail.ShowDetailTabs = false;
            this.grvCambios.OptionsDetail.SmartDetailExpand = false;
            this.grvCambios.OptionsView.ShowDetailButtons = false;
            this.grvCambios.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha";
            this.gridColumn6.DisplayFormat.FormatString = "g";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "Fecha";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Unidad";
            this.gridColumn1.FieldName = "Unidad";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Posición de llanta";
            this.gridColumn2.FieldName = "PosicionLlanta";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(376, 66);
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
            this.dteAl.Size = new System.Drawing.Size(416, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 6;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.Location = new System.Drawing.Point(127, 66);
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.EditFormat.FormatString = "D";
            this.dteDel.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Size = new System.Drawing.Size(142, 20);
            this.dteDel.StyleController = this.lcMain;
            this.dteDel.TabIndex = 5;
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(127, 42);
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.NullText = "[Seleccioné]";
            this.lueUnidad.Size = new System.Drawing.Size(665, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(816, 423);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.grdParches;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(796, 287);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUnidad,
            this.lciFechaDel,
            this.lciFechaAl,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(796, 116);
            this.layoutControlGroup2.Text = "Detalle de búsqueda";
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 0);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(772, 24);
            this.lciUnidad.Text = "Seleccioné la unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(100, 13);
            // 
            // lciFechaDel
            // 
            this.lciFechaDel.Control = this.dteDel;
            this.lciFechaDel.Location = new System.Drawing.Point(0, 24);
            this.lciFechaDel.Name = "lciFechaDel";
            this.lciFechaDel.Size = new System.Drawing.Size(249, 24);
            this.lciFechaDel.Text = "Del:";
            this.lciFechaDel.TextSize = new System.Drawing.Size(100, 13);
            // 
            // lciFechaAl
            // 
            this.lciFechaAl.Control = this.dteAl;
            this.lciFechaAl.Location = new System.Drawing.Point(249, 24);
            this.lciFechaAl.Name = "lciFechaAl";
            this.lciFechaAl.Size = new System.Drawing.Size(523, 24);
            this.lciFechaAl.Text = "Al:";
            this.lciFechaAl.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnBuscar;
            this.layoutControlItem5.Location = new System.Drawing.Point(249, 48);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(262, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(262, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(262, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnLimpiar;
            this.layoutControlItem6.Location = new System.Drawing.Point(511, 48);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(261, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(261, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(261, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(816, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // xfrmDetallesLlantasParchadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmDetallesLlantasParchadas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Detalle de llantas parchadas";
            this.Load += new System.EventHandler(this.xfrmDetallesCambioDeLlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdParches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grdParches;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCambios;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaDel;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaAl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}