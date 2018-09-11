namespace ATRCBASE.WIN
{
    partial class xfrmCambioContraseña
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirmarContraseña = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciContraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciConfirmarContraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMensaje = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirmarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lblMensaje);
            this.lcMain.Controls.Add(this.txtConfirmarContraseña);
            this.lcMain.Controls.Add(this.txtContraseña);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(300, 119);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Appearance.Options.UseFont = true;
            this.lblMensaje.Appearance.Options.UseForeColor = true;
            this.lblMensaje.Location = new System.Drawing.Point(126, 92);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(162, 13);
            this.lblMensaje.StyleController = this.lcMain;
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "No coinciden las contraseñas";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.EnterMoveNextControl = true;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(12, 68);
            this.txtConfirmarContraseña.MenuManager = this.ribbonControl1;
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Properties.NullValuePrompt = "Confirmar contraseña";
            this.txtConfirmarContraseña.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtConfirmarContraseña.Properties.PasswordChar = '*';
            this.txtConfirmarContraseña.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(276, 20);
            this.txtConfirmarContraseña.StyleController = this.lcMain;
            this.txtConfirmarContraseña.TabIndex = 5;
            this.txtConfirmarContraseña.TextChanged += new System.EventHandler(this.txtConfirmarContraseña_TextChanged);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(300, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.Guardar;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.Cancelar;
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.EnterMoveNextControl = true;
            this.txtContraseña.Location = new System.Drawing.Point(12, 28);
            this.txtContraseña.MenuManager = this.ribbonControl1;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.NullValuePrompt = "Contraseña";
            this.txtContraseña.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtContraseña.Properties.PasswordChar = '*';
            this.txtContraseña.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtContraseña.Size = new System.Drawing.Size(276, 20);
            this.txtContraseña.StyleController = this.lcMain;
            this.txtContraseña.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciContraseña,
            this.emptySpaceItem1,
            this.lciConfirmarContraseña,
            this.lciMensaje});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 119);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciContraseña
            // 
            this.lciContraseña.Control = this.txtContraseña;
            this.lciContraseña.Location = new System.Drawing.Point(0, 0);
            this.lciContraseña.Name = "lciContraseña";
            this.lciContraseña.Size = new System.Drawing.Size(280, 40);
            this.lciContraseña.Text = "Contraseña:";
            this.lciContraseña.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciContraseña.TextSize = new System.Drawing.Size(108, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 80);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(114, 19);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciConfirmarContraseña
            // 
            this.lciConfirmarContraseña.Control = this.txtConfirmarContraseña;
            this.lciConfirmarContraseña.Location = new System.Drawing.Point(0, 40);
            this.lciConfirmarContraseña.Name = "lciConfirmarContraseña";
            this.lciConfirmarContraseña.Size = new System.Drawing.Size(280, 40);
            this.lciConfirmarContraseña.Text = "Confirmar contraseña:";
            this.lciConfirmarContraseña.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciConfirmarContraseña.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciMensaje
            // 
            this.lciMensaje.Control = this.lblMensaje;
            this.lciMensaje.Location = new System.Drawing.Point(114, 80);
            this.lciMensaje.Name = "lciMensaje";
            this.lciMensaje.Size = new System.Drawing.Size(166, 19);
            this.lciMensaje.TextSize = new System.Drawing.Size(0, 0);
            this.lciMensaje.TextVisible = false;
            this.lciMensaje.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 241);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmCambioContraseña";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Cambio de contraseña";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmCambioContraseña_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConfirmarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraEditors.TextEdit txtConfirmarContraseña;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraLayout.LayoutControlItem lciContraseña;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciConfirmarContraseña;
        private DevExpress.XtraLayout.LayoutControlItem lciMensaje;
    }
}