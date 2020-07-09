namespace ATRCBASE.WIN
{
    partial class xfrmConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmConfiguraciones));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.chkSSL = new DevExpress.XtraEditors.CheckEdit();
            this.btnEnvioCorreo = new DevExpress.XtraEditors.SimpleButton();
            this.txtCorreoAutentificacion = new DevExpress.XtraEditors.TextEdit();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.txtContraseñas = new DevExpress.XtraEditors.TextEdit();
            this.txtPuerto = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSSL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPuerto = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHost = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCorreoAutentificacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCorreos = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoAutentificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseñas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCorreoAutentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCorreos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.SearchEditItem,
            this.ribbonControl1.ExpandCollapseItem,
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
            this.ribbonControl1.Size = new System.Drawing.Size(615, 132);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnEnvioCorreo);
            this.lcMain.Controls.Add(this.chkSSL);
            this.lcMain.Controls.Add(this.txtPuerto);
            this.lcMain.Controls.Add(this.txtContraseñas);
            this.lcMain.Controls.Add(this.txtHost);
            this.lcMain.Controls.Add(this.txtCorreoAutentificacion);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(663, 73, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(615, 200);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgCorreos});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(615, 200);
            this.Root.TextVisible = false;
            // 
            // chkSSL
            // 
            this.chkSSL.Location = new System.Drawing.Point(324, 117);
            this.chkSSL.MenuManager = this.ribbonControl1;
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Properties.Caption = "SSL";
            this.chkSSL.Size = new System.Drawing.Size(267, 20);
            this.chkSSL.StyleController = this.lcMain;
            this.chkSSL.TabIndex = 8;
            // 
            // btnEnvioCorreo
            // 
            this.btnEnvioCorreo.Location = new System.Drawing.Point(24, 141);
            this.btnEnvioCorreo.Name = "btnEnvioCorreo";
            this.btnEnvioCorreo.Size = new System.Drawing.Size(567, 22);
            this.btnEnvioCorreo.StyleController = this.lcMain;
            this.btnEnvioCorreo.TabIndex = 9;
            this.btnEnvioCorreo.Text = "Probar envio de correo";
            this.btnEnvioCorreo.Click += new System.EventHandler(this.btnEnvioCorreo_Click);
            // 
            // txtCorreoAutentificacion
            // 
            this.txtCorreoAutentificacion.Location = new System.Drawing.Point(146, 45);
            this.txtCorreoAutentificacion.MenuManager = this.ribbonControl1;
            this.txtCorreoAutentificacion.Name = "txtCorreoAutentificacion";
            this.txtCorreoAutentificacion.Size = new System.Drawing.Size(445, 20);
            this.txtCorreoAutentificacion.StyleController = this.lcMain;
            this.txtCorreoAutentificacion.TabIndex = 4;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(146, 69);
            this.txtHost.MenuManager = this.ribbonControl1;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(445, 20);
            this.txtHost.StyleController = this.lcMain;
            this.txtHost.TabIndex = 5;
            // 
            // txtContraseñas
            // 
            this.txtContraseñas.Location = new System.Drawing.Point(146, 93);
            this.txtContraseñas.MenuManager = this.ribbonControl1;
            this.txtContraseñas.Name = "txtContraseñas";
            this.txtContraseñas.Size = new System.Drawing.Size(445, 20);
            this.txtContraseñas.StyleController = this.lcMain;
            this.txtContraseñas.TabIndex = 6;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(146, 117);
            this.txtPuerto.MenuManager = this.ribbonControl1;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(174, 20);
            this.txtPuerto.StyleController = this.lcMain;
            this.txtPuerto.TabIndex = 7;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEnvioCorreo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(571, 39);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // lciSSL
            // 
            this.lciSSL.Control = this.chkSSL;
            this.lciSSL.Location = new System.Drawing.Point(300, 72);
            this.lciSSL.Name = "lciSSL";
            this.lciSSL.Size = new System.Drawing.Size(271, 24);
            this.lciSSL.TextSize = new System.Drawing.Size(0, 0);
            this.lciSSL.TextVisible = false;
            // 
            // lciPuerto
            // 
            this.lciPuerto.Control = this.txtPuerto;
            this.lciPuerto.Location = new System.Drawing.Point(0, 72);
            this.lciPuerto.Name = "lciPuerto";
            this.lciPuerto.Size = new System.Drawing.Size(300, 24);
            this.lciPuerto.Text = "Puerto:";
            this.lciPuerto.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lciContraseña
            // 
            this.lciContraseña.Control = this.txtContraseñas;
            this.lciContraseña.Location = new System.Drawing.Point(0, 48);
            this.lciContraseña.Name = "lciContraseña";
            this.lciContraseña.Size = new System.Drawing.Size(571, 24);
            this.lciContraseña.Text = "Contraseña:";
            this.lciContraseña.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lciHost
            // 
            this.lciHost.Control = this.txtHost;
            this.lciHost.Location = new System.Drawing.Point(0, 24);
            this.lciHost.Name = "lciHost";
            this.lciHost.Size = new System.Drawing.Size(571, 24);
            this.lciHost.Text = "Host:";
            this.lciHost.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lciCorreoAutentificacion
            // 
            this.lciCorreoAutentificacion.Control = this.txtCorreoAutentificacion;
            this.lciCorreoAutentificacion.Location = new System.Drawing.Point(0, 0);
            this.lciCorreoAutentificacion.Name = "lciCorreoAutentificacion";
            this.lciCorreoAutentificacion.Size = new System.Drawing.Size(571, 24);
            this.lciCorreoAutentificacion.Text = "Correo autentificación:";
            this.lciCorreoAutentificacion.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lcgCorreos
            // 
            this.lcgCorreos.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.lciSSL,
            this.lciPuerto,
            this.lciContraseña,
            this.lciHost,
            this.lciCorreoAutentificacion});
            this.lcgCorreos.Location = new System.Drawing.Point(0, 0);
            this.lcgCorreos.Name = "lcgCorreos";
            this.lcgCorreos.Size = new System.Drawing.Size(595, 180);
            this.lcgCorreos.Text = "Configuración de correo electrónico";
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
            // xfrmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 332);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmConfiguraciones.IconOptions.Icon")));
            this.Name = "xfrmConfiguraciones";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.xfrmConfiguraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoAutentificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseñas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCorreoAutentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCorreos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SimpleButton btnEnvioCorreo;
        private DevExpress.XtraEditors.CheckEdit chkSSL;
        private DevExpress.XtraEditors.TextEdit txtPuerto;
        private DevExpress.XtraEditors.TextEdit txtContraseñas;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private DevExpress.XtraEditors.TextEdit txtCorreoAutentificacion;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCorreos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem lciSSL;
        private DevExpress.XtraLayout.LayoutControlItem lciPuerto;
        private DevExpress.XtraLayout.LayoutControlItem lciContraseña;
        private DevExpress.XtraLayout.LayoutControlItem lciHost;
        private DevExpress.XtraLayout.LayoutControlItem lciCorreoAutentificacion;
    }
}