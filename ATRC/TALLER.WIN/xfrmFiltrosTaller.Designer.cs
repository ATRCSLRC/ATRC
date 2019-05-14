namespace TALLER.WIN
{
    partial class xfrmFiltrosTaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmFiltrosTaller));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.lueEmpleados = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.lueEmpleados);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(512, 104);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(311, 36);
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
            this.dteAl.Size = new System.Drawing.Size(189, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 6;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiImprimir,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(512, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 1;
            this.bbiImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.Image")));
            this.bbiImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.LargeImage")));
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.Location = new System.Drawing.Point(65, 36);
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
            this.dteDe.Size = new System.Drawing.Size(189, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 5;
            // 
            // lueEmpleados
            // 
            this.lueEmpleados.Location = new System.Drawing.Point(65, 12);
            this.lueEmpleados.MenuManager = this.ribbonControl1;
            this.lueEmpleados.Name = "lueEmpleados";
            this.lueEmpleados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpleados.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpleados.Properties.DisplayMember = "Nombre";
            this.lueEmpleados.Properties.ValueMember = "NumEmpleado";
            this.lueEmpleados.Size = new System.Drawing.Size(435, 20);
            this.lueEmpleados.StyleController = this.lcMain;
            this.lueEmpleados.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciAl,
            this.lciEmpleado});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(512, 104);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 24);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(246, 60);
            this.lciDe.Text = "De:";
            this.lciDe.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciAl
            // 
            this.lciAl.Control = this.dteAl;
            this.lciAl.Location = new System.Drawing.Point(246, 24);
            this.lciAl.Name = "lciAl";
            this.lciAl.Size = new System.Drawing.Size(246, 60);
            this.lciAl.Text = "Al:";
            this.lciAl.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.Control = this.lueEmpleados;
            this.lciEmpleado.Location = new System.Drawing.Point(0, 0);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(492, 24);
            this.lciEmpleado.Text = "Empleado:";
            this.lciEmpleado.TextSize = new System.Drawing.Size(50, 13);
            // 
            // xfrmFiltrosTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 226);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmFiltrosTaller";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Filtros de reportes de taller";
            this.Load += new System.EventHandler(this.xfrmFiltrosTaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lueEmpleados;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciAl;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
    }
}