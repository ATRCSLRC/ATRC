namespace UNIDADES.WIN.Reportes
{
    partial class xfrmGastosPorUnidad
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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel2 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView3 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView4 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmGastosPorUnidad));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Grafica = new DevExpress.XtraCharts.ChartControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.fypImprimir = new DevExpress.Utils.FlyoutPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fypImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.Grafica);
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDel);
            this.lcMain.Controls.Add(this.fypImprimir);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1070, 205, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(800, 576);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // Grafica
            // 
            this.Grafica.AppearanceNameSerializable = "Chameleon";
            this.Grafica.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.Grafica.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.Grafica.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.Grafica.Legend.Name = "Default Legend";
            this.Grafica.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.Grafica.Location = new System.Drawing.Point(12, 131);
            this.Grafica.Name = "Grafica";
            this.Grafica.PaletteName = "Paleta 1";
            this.Grafica.PaletteRepository.Add("Paleta 1", new DevExpress.XtraCharts.Palette("Paleta 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))))}));
            doughnutSeriesLabel2.TextPattern = "{V:$0.00}";
            series2.Label = doughnutSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendName = "Default Legend";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Serie1";
            doughnutSeriesView3.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise;
            doughnutSeriesView3.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesView3.TotalLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView3.TotalLabel.TextPattern = "Total                    {TV:$0.00}";
            doughnutSeriesView3.TotalLabel.Visible = true;
            series2.View = doughnutSeriesView3;
            this.Grafica.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.Grafica.SeriesTemplate.View = doughnutSeriesView4;
            this.Grafica.Size = new System.Drawing.Size(776, 433);
            this.Grafica.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(640, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 22);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar [F12]";
            this.btnCancelar.Click += new System.EventHandler(this.bbiCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(497, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar [F5]";
            this.btnBuscar.Click += new System.EventHandler(this.bbiBuscar_Click);
            // 
            // lueUnidad
            // 
            this.lueUnidad.EnterMoveNextControl = true;
            this.lueUnidad.Location = new System.Drawing.Point(64, 69);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.NullText = "[SELECCIONE]";
            this.lueUnidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueUnidad.Size = new System.Drawing.Size(712, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 6;
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.EnterMoveNextControl = true;
            this.dteAl.Location = new System.Drawing.Point(442, 45);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Size = new System.Drawing.Size(334, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 5;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.EnterMoveNextControl = true;
            this.dteDel.Location = new System.Drawing.Point(64, 45);
            this.dteDel.MenuManager = this.ribbonControl1;
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Size = new System.Drawing.Size(334, 20);
            this.dteDel.StyleController = this.lcMain;
            this.dteDel.TabIndex = 4;
            // 
            // fypImprimir
            // 
            this.fypImprimir.Appearance.BackColor = System.Drawing.Color.Red;
            this.fypImprimir.Appearance.ForeColor = System.Drawing.Color.White;
            this.fypImprimir.Appearance.Options.UseBackColor = true;
            this.fypImprimir.Appearance.Options.UseForeColor = true;
            this.fypImprimir.Location = new System.Drawing.Point(12, 345);
            this.fypImprimir.Name = "fypImprimir";
            this.fypImprimir.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.fypImprimir.OptionsBeakPanel.BackColor = System.Drawing.Color.Red;
            this.fypImprimir.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.fypImprimir.OptionsButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.fypImprimir.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.fypImprimir.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            buttonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions4.Image")));
            this.fypImprimir.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Imprimir gastos almacen", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, true),
            new DevExpress.Utils.PeekFormButton("Imprimir gastos combustible", true, buttonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.fypImprimir.OptionsButtonPanel.ShowButtonPanel = true;
            this.fypImprimir.OwnerControl = this.Grafica;
            this.fypImprimir.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.fypImprimir.ParentForm = this;
            this.fypImprimir.Size = new System.Drawing.Size(776, 38);
            this.fypImprimir.TabIndex = 3;
            this.fypImprimir.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.fypImprimir_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 576);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.lciUnidad,
            this.lciFechaDel,
            this.lciFechaAl});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 119);
            this.layoutControlGroup2.Text = "Detalles para búsqueda";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(473, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancelar;
            this.layoutControlItem5.Location = new System.Drawing.Point(616, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBuscar;
            this.layoutControlItem4.Location = new System.Drawing.Point(473, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 24);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(756, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(37, 13);
            // 
            // lciFechaDel
            // 
            this.lciFechaDel.Control = this.dteDel;
            this.lciFechaDel.Location = new System.Drawing.Point(0, 0);
            this.lciFechaDel.Name = "lciFechaDel";
            this.lciFechaDel.Size = new System.Drawing.Size(378, 24);
            this.lciFechaDel.Text = "Del:";
            this.lciFechaDel.TextSize = new System.Drawing.Size(37, 13);
            // 
            // lciFechaAl
            // 
            this.lciFechaAl.Control = this.dteAl;
            this.lciFechaAl.Location = new System.Drawing.Point(378, 0);
            this.lciFechaAl.Name = "lciFechaAl";
            this.lciFechaAl.Size = new System.Drawing.Size(378, 24);
            this.lciFechaAl.Text = "Al:";
            this.lciFechaAl.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Grafica;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 437);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // xfrmGastosPorUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmGastosPorUnidad.IconOptions.Icon")));
            this.Name = "xfrmGastosPorUnidad";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Detalle de gastos por unidad";
            this.Load += new System.EventHandler(this.xfrmGastosPorUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fypImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.Utils.FlyoutPanel fypImprimir;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaDel;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaAl;
        private DevExpress.XtraCharts.ChartControl Grafica;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}