namespace COMBUSTIBLE.WIN
{
    partial class xfrmConfiguracionDiesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmConfiguracionDiesel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.chkListDias = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lciDiasDiesel = new DevExpress.XtraLayout.LayoutControlItem();
            this.tmeHoraDe = new DevExpress.XtraEditors.TimeSpanEdit();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.tmeHoraA = new DevExpress.XtraEditors.TimeSpanEdit();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiasDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.SearchEditItem,
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(545, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.tmeHoraA);
            this.lcMain.Controls.Add(this.tmeHoraDe);
            this.lcMain.Controls.Add(this.chkListDias);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 499, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(545, 105);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciA,
            this.lciDiasDiesel});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 105);
            this.Root.TextVisible = false;
            // 
            // chkListDias
            // 
            this.chkListDias.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "Lunes"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "Martes"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(3, "Miércoles"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(4, "Jueves"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(5, "Viernes")});
            this.chkListDias.Location = new System.Drawing.Point(12, 52);
            this.chkListDias.MultiColumn = true;
            this.chkListDias.Name = "chkListDias";
            this.chkListDias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.chkListDias.Size = new System.Drawing.Size(521, 41);
            this.chkListDias.StyleController = this.lcMain;
            this.chkListDias.TabIndex = 4;
            this.chkListDias.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkListDias_ItemCheck);
            // 
            // lciDiasDiesel
            // 
            this.lciDiasDiesel.Control = this.chkListDias;
            this.lciDiasDiesel.Location = new System.Drawing.Point(0, 24);
            this.lciDiasDiesel.Name = "lciDiasDiesel";
            this.lciDiasDiesel.Size = new System.Drawing.Size(525, 61);
            this.lciDiasDiesel.Text = "Días de diesel";
            this.lciDiasDiesel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDiasDiesel.TextSize = new System.Drawing.Size(65, 13);
            // 
            // tmeHoraDe
            // 
            this.tmeHoraDe.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tmeHoraDe.Location = new System.Drawing.Point(34, 12);
            this.tmeHoraDe.MenuManager = this.ribbonControl1;
            this.tmeHoraDe.Name = "tmeHoraDe";
            this.tmeHoraDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeHoraDe.Size = new System.Drawing.Size(236, 20);
            this.tmeHoraDe.StyleController = this.lcMain;
            this.tmeHoraDe.TabIndex = 5;
            this.tmeHoraDe.EditValueChanged += new System.EventHandler(this.tmeHoraDe_EditValueChanged);
            // 
            // lciDe
            // 
            this.lciDe.Control = this.tmeHoraDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(262, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDe.TextSize = new System.Drawing.Size(17, 13);
            this.lciDe.TextToControlDistance = 5;
            // 
            // tmeHoraA
            // 
            this.tmeHoraA.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tmeHoraA.Location = new System.Drawing.Point(290, 12);
            this.tmeHoraA.MenuManager = this.ribbonControl1;
            this.tmeHoraA.Name = "tmeHoraA";
            this.tmeHoraA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeHoraA.Size = new System.Drawing.Size(243, 20);
            this.tmeHoraA.StyleController = this.lcMain;
            this.tmeHoraA.TabIndex = 6;
            this.tmeHoraA.EditValueChanged += new System.EventHandler(this.tmeHoraA_EditValueChanged);
            // 
            // lciA
            // 
            this.lciA.Control = this.tmeHoraA;
            this.lciA.Location = new System.Drawing.Point(262, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(263, 24);
            this.lciA.Text = "A:";
            this.lciA.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciA.TextSize = new System.Drawing.Size(11, 13);
            this.lciA.TextToControlDistance = 5;
            // 
            // xfrmConfiguracionDiesel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 137);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmConfiguracionDiesel.IconOptions.Icon")));
            this.Name = "xfrmConfiguracionDiesel";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Configuración de diesel";
            this.Load += new System.EventHandler(this.xfrmConfiguracionDiesel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkListDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiasDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TimeSpanEdit tmeHoraA;
        private DevExpress.XtraEditors.TimeSpanEdit tmeHoraDe;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListDias;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.LayoutControlItem lciDiasDiesel;
    }
}