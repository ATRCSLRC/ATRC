namespace ATRC
{
    partial class xfrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmLogin));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnIngresar = new DevExpress.XtraEditors.SimpleButton();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.lcgContenedor = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIngresar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancelar = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(283, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 323);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(283, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 323);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(283, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 323);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.btnIngresar);
            this.lcMain.Controls.Add(this.txtContraseña);
            this.lcMain.Controls.Add(this.txtUsuario);
            this.lcMain.Controls.Add(this.peLogo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(693, 153, 604, 600);
            this.lcMain.Root = this.lcgContenedor;
            this.lcMain.Size = new System.Drawing.Size(283, 291);
            this.lcMain.TabIndex = 4;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 22);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Appearance.Options.UseBackColor = true;
            this.btnIngresar.Location = new System.Drawing.Point(144, 257);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 22);
            this.btnIngresar.StyleController = this.lcMain;
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.EditValue = "";
            this.txtContraseña.Location = new System.Drawing.Point(12, 233);
            this.txtContraseña.MenuManager = this.barManager1;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.NullText = "Contraseña";
            this.txtContraseña.Properties.NullValuePrompt = "Contraseña";
            this.txtContraseña.Properties.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(259, 20);
            this.txtContraseña.StyleController = this.lcMain;
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.EnterMoveNextControl = true;
            this.txtUsuario.Location = new System.Drawing.Point(12, 209);
            this.txtUsuario.MenuManager = this.barManager1;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.NullText = "Número de usuario";
            this.txtUsuario.Properties.NullValuePrompt = "Número de usuario";
            this.txtUsuario.Size = new System.Drawing.Size(259, 20);
            this.txtUsuario.StyleController = this.lcMain;
            this.txtUsuario.TabIndex = 5;
            // 
            // peLogo
            // 
            this.peLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.peLogo.EditValue = global::ATRC.Properties.Resources.ATRC_LOGO_PNG;
            this.peLogo.Location = new System.Drawing.Point(12, 12);
            this.peLogo.MenuManager = this.barManager1;
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peLogo.Size = new System.Drawing.Size(259, 193);
            this.peLogo.StyleController = this.lcMain;
            this.peLogo.TabIndex = 4;
            // 
            // lcgContenedor
            // 
            this.lcgContenedor.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgContenedor.GroupBordersVisible = false;
            this.lcgContenedor.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLogo,
            this.lciUsuario,
            this.lciContraseña,
            this.lciIngresar,
            this.lciCancelar});
            this.lcgContenedor.Name = "lcgContenedor";
            this.lcgContenedor.Size = new System.Drawing.Size(283, 291);
            this.lcgContenedor.TextVisible = false;
            // 
            // lciLogo
            // 
            this.lciLogo.Control = this.peLogo;
            this.lciLogo.Location = new System.Drawing.Point(0, 0);
            this.lciLogo.Name = "lciLogo";
            this.lciLogo.Size = new System.Drawing.Size(263, 197);
            this.lciLogo.TextSize = new System.Drawing.Size(0, 0);
            this.lciLogo.TextVisible = false;
            // 
            // lciUsuario
            // 
            this.lciUsuario.Control = this.txtUsuario;
            this.lciUsuario.Location = new System.Drawing.Point(0, 197);
            this.lciUsuario.Name = "lciUsuario";
            this.lciUsuario.Size = new System.Drawing.Size(263, 24);
            this.lciUsuario.Text = "Usuario:";
            this.lciUsuario.TextSize = new System.Drawing.Size(0, 0);
            this.lciUsuario.TextVisible = false;
            // 
            // lciContraseña
            // 
            this.lciContraseña.Control = this.txtContraseña;
            this.lciContraseña.Location = new System.Drawing.Point(0, 221);
            this.lciContraseña.Name = "lciContraseña";
            this.lciContraseña.Size = new System.Drawing.Size(263, 24);
            this.lciContraseña.Text = "Contraseña:";
            this.lciContraseña.TextSize = new System.Drawing.Size(0, 0);
            this.lciContraseña.TextVisible = false;
            // 
            // lciIngresar
            // 
            this.lciIngresar.Control = this.btnIngresar;
            this.lciIngresar.Location = new System.Drawing.Point(132, 245);
            this.lciIngresar.Name = "lciIngresar";
            this.lciIngresar.Size = new System.Drawing.Size(131, 26);
            this.lciIngresar.TextSize = new System.Drawing.Size(0, 0);
            this.lciIngresar.TextVisible = false;
            // 
            // lciCancelar
            // 
            this.lciCancelar.Control = this.btnCancelar;
            this.lciCancelar.Location = new System.Drawing.Point(0, 245);
            this.lciCancelar.Name = "lciCancelar";
            this.lciCancelar.Size = new System.Drawing.Size(132, 26);
            this.lciCancelar.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancelar.TextVisible = false;
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
            this.ribbonControl1.Size = new System.Drawing.Size(283, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xfrmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 323);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmLogin.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmLogin";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.xfrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnIngresar;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgContenedor;
        private DevExpress.XtraLayout.LayoutControlItem lciLogo;
        private DevExpress.XtraLayout.LayoutControlItem lciUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciContraseña;
        private DevExpress.XtraLayout.LayoutControlItem lciIngresar;
        private DevExpress.XtraLayout.LayoutControlItem lciCancelar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}