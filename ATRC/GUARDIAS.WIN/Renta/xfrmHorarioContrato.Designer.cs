namespace GUARDIAS.WIN
{
    partial class xfrmHorarioContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmHorarioContrato));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dteDia = new DevExpress.XtraEditors.DateEdit();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tmeHora = new DevExpress.XtraEditors.TimeEdit();
            this.lciHora = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(390, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.tmeHora);
            this.lcMain.Controls.Add(this.dteDia);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(135, 427, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(390, 94);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFecha,
            this.emptySpaceItem1,
            this.lciHora,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(390, 94);
            this.Root.TextVisible = false;
            // 
            // dteDia
            // 
            this.dteDia.EditValue = null;
            this.dteDia.Location = new System.Drawing.Point(42, 24);
            this.dteDia.MenuManager = this.ribbonControl1;
            this.dteDia.Name = "dteDia";
            this.dteDia.Properties.Appearance.Options.UseTextOptions = true;
            this.dteDia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteDia.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dteDia.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.dteDia.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteDia.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dteDia.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.dteDia.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteDia.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dteDia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDia.Properties.DisplayFormat.FormatString = "D";
            this.dteDia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDia.Properties.EditFormat.FormatString = "D";
            this.dteDia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDia.Properties.Mask.EditMask = "D";
            this.dteDia.Size = new System.Drawing.Size(336, 20);
            this.dteDia.StyleController = this.lcMain;
            this.dteDia.TabIndex = 4;
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteDia;
            this.lciFecha.Location = new System.Drawing.Point(0, 12);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(370, 24);
            this.lciFecha.Text = "Día:";
            this.lciFecha.TextSize = new System.Drawing.Size(27, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(370, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tmeHora
            // 
            this.tmeHora.EditValue = new System.DateTime(2020, 8, 17, 0, 0, 0, 0);
            this.tmeHora.Location = new System.Drawing.Point(42, 48);
            this.tmeHora.MenuManager = this.ribbonControl1;
            this.tmeHora.Name = "tmeHora";
            this.tmeHora.Properties.Appearance.Options.UseTextOptions = true;
            this.tmeHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmeHora.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tmeHora.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.tmeHora.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmeHora.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tmeHora.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.tmeHora.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmeHora.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tmeHora.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.tmeHora.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmeHora.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tmeHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeHora.Size = new System.Drawing.Size(336, 20);
            this.tmeHora.StyleController = this.lcMain;
            this.tmeHora.TabIndex = 5;
            // 
            // lciHora
            // 
            this.lciHora.Control = this.tmeHora;
            this.lciHora.Location = new System.Drawing.Point(0, 36);
            this.lciHora.Name = "lciHora";
            this.lciHora.Size = new System.Drawing.Size(370, 24);
            this.lciHora.Text = "Hora:";
            this.lciHora.TextSize = new System.Drawing.Size(27, 13);
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.Image")));
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.Image")));
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(370, 12);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmHorarioContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 226);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmHorarioContrato.IconOptions.Icon")));
            this.Name = "xfrmHorarioContrato";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Horario de contrato";
            this.Load += new System.EventHandler(this.xfrmHorarioContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.TimeEdit tmeHora;
        private DevExpress.XtraEditors.DateEdit dteDia;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciHora;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}