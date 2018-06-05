namespace Unidades
{
    partial class xfrmTotales
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
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel10 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView10 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle10 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel9 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView9 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle9 = new DevExpress.XtraCharts.SeriesTitle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spnTipoCambio = new DevExpress.XtraEditors.SpinEdit();
            this.lciTipoCambio = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.GraficaDolar = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.GraficaPesos = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
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
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(677, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.GraficaPesos);
            this.lcMain.Controls.Add(this.GraficaDolar);
            this.lcMain.Controls.Add(this.btnCalcular);
            this.lcMain.Controls.Add(this.spnTipoCambio);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(729, 300, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(677, 551);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(677, 551);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // spnTipoCambio
            // 
            this.spnTipoCambio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnTipoCambio.Location = new System.Drawing.Point(102, 42);
            this.spnTipoCambio.MenuManager = this.ribbonControl1;
            this.spnTipoCambio.Name = "spnTipoCambio";
            this.spnTipoCambio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnTipoCambio.Properties.DisplayFormat.FormatString = "c";
            this.spnTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnTipoCambio.Properties.EditFormat.FormatString = "c";
            this.spnTipoCambio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnTipoCambio.Properties.Mask.EditMask = "c";
            this.spnTipoCambio.Size = new System.Drawing.Size(551, 20);
            this.spnTipoCambio.StyleController = this.lcMain;
            this.spnTipoCambio.TabIndex = 5;
            // 
            // lciTipoCambio
            // 
            this.lciTipoCambio.Control = this.spnTipoCambio;
            this.lciTipoCambio.Location = new System.Drawing.Point(0, 0);
            this.lciTipoCambio.Name = "lciTipoCambio";
            this.lciTipoCambio.Size = new System.Drawing.Size(633, 24);
            this.lciTipoCambio.Text = "Tipo de cambio:";
            this.lciTipoCambio.TextSize = new System.Drawing.Size(75, 13);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(460, 66);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 22);
            this.btnCalcular.StyleController = this.lcMain;
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCalcular;
            this.layoutControlItem3.Location = new System.Drawing.Point(436, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(197, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // GraficaDolar
            // 
            this.GraficaDolar.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.GraficaDolar.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.GraficaDolar.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.GraficaDolar.Legend.Name = "Default Legend";
            this.GraficaDolar.Location = new System.Drawing.Point(12, 104);
            this.GraficaDolar.Name = "GraficaDolar";
            this.GraficaDolar.PaletteName = "Paleta 1";
            this.GraficaDolar.PaletteRepository.Add("Paleta 1", new DevExpress.XtraCharts.Palette("Paleta 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))))}));
            doughnutSeriesLabel10.TextPattern = "{V:$0.00}";
            series10.Label = doughnutSeriesLabel10;
            series10.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series10.LegendTextPattern = "{A}";
            series10.Name = "Serie1";
            doughnutSeriesView10.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise;
            seriesTitle10.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle10.Text = "Total en dolar";
            doughnutSeriesView10.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle10});
            doughnutSeriesView10.TotalLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView10.TotalLabel.TextPattern = "Total                              {TV:$0.00}";
            doughnutSeriesView10.TotalLabel.Visible = true;
            series10.View = doughnutSeriesView10;
            this.GraficaDolar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series10};
            this.GraficaDolar.Size = new System.Drawing.Size(325, 435);
            this.GraficaDolar.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.GraficaDolar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(329, 439);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // GraficaPesos
            // 
            this.GraficaPesos.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.GraficaPesos.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.GraficaPesos.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.GraficaPesos.Legend.MarkerSize = new System.Drawing.Size(20, 15);
            this.GraficaPesos.Legend.Name = "Default Legend";
            this.GraficaPesos.Location = new System.Drawing.Point(341, 104);
            this.GraficaPesos.Name = "GraficaPesos";
            this.GraficaPesos.PaletteName = "Paleta 1";
            this.GraficaPesos.PaletteRepository.Add("Paleta 1", new DevExpress.XtraCharts.Palette("Paleta 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))))}));
            doughnutSeriesLabel9.TextPattern = "{V:$0.00}";
            series9.Label = doughnutSeriesLabel9;
            series9.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series9.LegendTextPattern = "{A}";
            series9.Name = "Serie1";
            doughnutSeriesView9.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise;
            seriesTitle9.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle9.Indent = 20;
            seriesTitle9.Text = "Total en pesos";
            seriesTitle9.Visibility = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesView9.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle9});
            doughnutSeriesView9.TotalLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView9.TotalLabel.TextPattern = "Total                               {TV:$0.00}";
            doughnutSeriesView9.TotalLabel.Visible = true;
            series9.View = doughnutSeriesView9;
            this.GraficaPesos.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9};
            this.GraficaPesos.Size = new System.Drawing.Size(324, 435);
            this.GraficaPesos.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.GraficaPesos;
            this.layoutControlItem5.Location = new System.Drawing.Point(329, 92);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(328, 439);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTipoCambio,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(657, 92);
            this.layoutControlGroup2.Text = "Ingresar tipo de cambio";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(436, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 578);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmTotales";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totales";
            this.Load += new System.EventHandler(this.xfrmTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private DevExpress.XtraEditors.SpinEdit spnTipoCambio;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoCambio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraCharts.ChartControl GraficaPesos;
        private DevExpress.XtraCharts.ChartControl GraficaDolar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}