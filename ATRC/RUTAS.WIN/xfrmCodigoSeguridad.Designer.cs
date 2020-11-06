namespace RUTAS.WIN
{
    partial class xfrmCodigoSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCodigoSeguridad));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblInstrucciones = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstrucciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
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
            this.ribbonControl1.Size = new System.Drawing.Size(522, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtCodigo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(570, 0, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(522, 95);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 57);
            this.txtCodigo.MenuManager = this.ribbonControl1;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtCodigo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCodigo.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCodigo.Properties.PasswordChar = '*';
            this.txtCodigo.Size = new System.Drawing.Size(498, 26);
            this.txtCodigo.StyleController = this.lcMain;
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblInstrucciones,
            this.lciCodigo,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(522, 95);
            this.Root.TextVisible = false;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AllowHotTrack = false;
            this.lblInstrucciones.AppearanceItemCaption.BackColor = System.Drawing.Color.Red;
            this.lblInstrucciones.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.lblInstrucciones.AppearanceItemCaption.Options.UseBackColor = true;
            this.lblInstrucciones.AppearanceItemCaption.Options.UseFont = true;
            this.lblInstrucciones.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblInstrucciones.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblInstrucciones.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInstrucciones.Location = new System.Drawing.Point(0, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(502, 23);
            this.lblInstrucciones.Text = "Favor de ingresar el código del administrador.";
            this.lblInstrucciones.TextSize = new System.Drawing.Size(374, 19);
            // 
            // lciCodigo
            // 
            this.lciCodigo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciCodigo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciCodigo.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lciCodigo.Control = this.txtCodigo;
            this.lciCodigo.Location = new System.Drawing.Point(0, 45);
            this.lciCodigo.Name = "lciCodigo";
            this.lciCodigo.Size = new System.Drawing.Size(502, 30);
            this.lciCodigo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCodigo.TextSize = new System.Drawing.Size(0, 0);
            this.lciCodigo.TextToControlDistance = 0;
            this.lciCodigo.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(502, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmCodigoSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 127);
            this.ControlBox = false;
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmCodigoSeguridad.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmCodigoSeguridad";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Código de seguridad";
            this.Load += new System.EventHandler(this.xfrmCodigoSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstrucciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem lblInstrucciones;
        private DevExpress.XtraLayout.LayoutControlItem lciCodigo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}