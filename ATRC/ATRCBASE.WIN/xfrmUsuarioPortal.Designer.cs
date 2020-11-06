namespace ATRCBASE.WIN
{
    partial class xfrmUsuarioPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmUsuarioPortal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCorreo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCorreo)).BeginInit();
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
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(457, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Guardar;
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Cancelar;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtCorreo);
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(505, 42, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(457, 104);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(60, 60);
            this.txtCorreo.MenuManager = this.ribbonControl1;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(385, 20);
            this.txtCorreo.StyleController = this.lcMain;
            this.txtCorreo.TabIndex = 6;
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(60, 36);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Size = new System.Drawing.Size(385, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 12);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(385, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNombre,
            this.emptySpaceItem1,
            this.lciEmpresa,
            this.lciCorreo});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(457, 104);
            this.Root.TextVisible = false;
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(0, 0);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(437, 24);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextSize = new System.Drawing.Size(45, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(0, 24);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(437, 24);
            this.lciEmpresa.Text = "Empresa:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(45, 13);
            // 
            // lciCorreo
            // 
            this.lciCorreo.Control = this.txtCorreo;
            this.lciCorreo.Location = new System.Drawing.Point(0, 48);
            this.lciCorreo.Name = "lciCorreo";
            this.lciCorreo.Size = new System.Drawing.Size(437, 24);
            this.lciCorreo.Text = "Correo:";
            this.lciCorreo.TextSize = new System.Drawing.Size(45, 13);
            // 
            // xfrmUsuarioPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 236);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmUsuarioPortal.IconOptions.Icon")));
            this.Name = "xfrmUsuarioPortal";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.xfrmUsuarioPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCorreo)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem lciCorreo;
    }
}