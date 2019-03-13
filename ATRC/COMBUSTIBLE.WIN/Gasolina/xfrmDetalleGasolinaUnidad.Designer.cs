namespace COMBUSTIBLE.WIN
{
    partial class xfrmDetalleGasolinaUnidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDetalleGasolinaUnidad));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.rgTanques = new DevExpress.XtraEditors.RadioGroup();
            this.txtLitros = new DevExpress.XtraEditors.TextEdit();
            this.txtCandadoActual = new DevExpress.XtraEditors.TextEdit();
            this.txtCandadoAnterior = new DevExpress.XtraEditors.TextEdit();
            this.txtMillas = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMillas = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCandadoAnterior = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCandadoActual = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLitros = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTanque = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCandadoActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCandadoAnterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMillas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCandadoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCandadoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanque)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(403, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.LargeImage")));
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.Cancelar1;
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.rgTanques);
            this.lcMain.Controls.Add(this.txtLitros);
            this.lcMain.Controls.Add(this.txtCandadoActual);
            this.lcMain.Controls.Add(this.txtCandadoAnterior);
            this.lcMain.Controls.Add(this.txtMillas);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(403, 243);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // rgTanques
            // 
            this.rgTanques.EnterMoveNextControl = true;
            this.rgTanques.Location = new System.Drawing.Point(12, 28);
            this.rgTanques.MenuManager = this.ribbonControl1;
            this.rgTanques.Name = "rgTanques";
            this.rgTanques.Size = new System.Drawing.Size(379, 27);
            this.rgTanques.StyleController = this.lcMain;
            this.rgTanques.TabIndex = 8;
            // 
            // txtLitros
            // 
            this.txtLitros.EnterMoveNextControl = true;
            this.txtLitros.Location = new System.Drawing.Point(12, 195);
            this.txtLitros.MenuManager = this.ribbonControl1;
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLitros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLitros.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtLitros.Size = new System.Drawing.Size(379, 20);
            this.txtLitros.StyleController = this.lcMain;
            this.txtLitros.TabIndex = 7;
            // 
            // txtCandadoActual
            // 
            this.txtCandadoActual.EnterMoveNextControl = true;
            this.txtCandadoActual.Location = new System.Drawing.Point(12, 155);
            this.txtCandadoActual.MenuManager = this.ribbonControl1;
            this.txtCandadoActual.Name = "txtCandadoActual";
            this.txtCandadoActual.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCandadoActual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCandadoActual.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCandadoActual.Size = new System.Drawing.Size(379, 20);
            this.txtCandadoActual.StyleController = this.lcMain;
            this.txtCandadoActual.TabIndex = 6;
            // 
            // txtCandadoAnterior
            // 
            this.txtCandadoAnterior.EnterMoveNextControl = true;
            this.txtCandadoAnterior.Location = new System.Drawing.Point(12, 115);
            this.txtCandadoAnterior.MenuManager = this.ribbonControl1;
            this.txtCandadoAnterior.Name = "txtCandadoAnterior";
            this.txtCandadoAnterior.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCandadoAnterior.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCandadoAnterior.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCandadoAnterior.Size = new System.Drawing.Size(379, 20);
            this.txtCandadoAnterior.StyleController = this.lcMain;
            this.txtCandadoAnterior.TabIndex = 5;
            this.txtCandadoAnterior.Leave += new System.EventHandler(this.txtCandadoAnterior_Leave);
            // 
            // txtMillas
            // 
            this.txtMillas.EnterMoveNextControl = true;
            this.txtMillas.Location = new System.Drawing.Point(12, 75);
            this.txtMillas.MenuManager = this.ribbonControl1;
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMillas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMillas.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMillas.Size = new System.Drawing.Size(379, 20);
            this.txtMillas.StyleController = this.lcMain;
            this.txtMillas.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMillas,
            this.lciCandadoAnterior,
            this.lciCandadoActual,
            this.lciLitros,
            this.lciTanque});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(403, 243);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciMillas
            // 
            this.lciMillas.Control = this.txtMillas;
            this.lciMillas.Location = new System.Drawing.Point(0, 47);
            this.lciMillas.Name = "lciMillas";
            this.lciMillas.Size = new System.Drawing.Size(383, 40);
            this.lciMillas.Text = "Millas:";
            this.lciMillas.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMillas.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lciCandadoAnterior
            // 
            this.lciCandadoAnterior.Control = this.txtCandadoAnterior;
            this.lciCandadoAnterior.Location = new System.Drawing.Point(0, 87);
            this.lciCandadoAnterior.Name = "lciCandadoAnterior";
            this.lciCandadoAnterior.Size = new System.Drawing.Size(383, 40);
            this.lciCandadoAnterior.Text = "Candado anterior:";
            this.lciCandadoAnterior.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCandadoAnterior.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lciCandadoActual
            // 
            this.lciCandadoActual.Control = this.txtCandadoActual;
            this.lciCandadoActual.Location = new System.Drawing.Point(0, 127);
            this.lciCandadoActual.Name = "lciCandadoActual";
            this.lciCandadoActual.Size = new System.Drawing.Size(383, 40);
            this.lciCandadoActual.Text = "Candado actual:";
            this.lciCandadoActual.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCandadoActual.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lciLitros
            // 
            this.lciLitros.Control = this.txtLitros;
            this.lciLitros.Location = new System.Drawing.Point(0, 167);
            this.lciLitros.Name = "lciLitros";
            this.lciLitros.Size = new System.Drawing.Size(383, 56);
            this.lciLitros.Text = "Litros:";
            this.lciLitros.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLitros.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lciTanque
            // 
            this.lciTanque.Control = this.rgTanques;
            this.lciTanque.Location = new System.Drawing.Point(0, 0);
            this.lciTanque.MaxSize = new System.Drawing.Size(0, 47);
            this.lciTanque.MinSize = new System.Drawing.Size(97, 47);
            this.lciTanque.Name = "lciTanque";
            this.lciTanque.Size = new System.Drawing.Size(383, 47);
            this.lciTanque.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTanque.Text = "Tanque:";
            this.lciTanque.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTanque.TextSize = new System.Drawing.Size(88, 13);
            // 
            // xfrmDetalleGasolinaUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 365);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmDetalleGasolinaUnidad";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Detalle de llenado de diesel";
            this.Load += new System.EventHandler(this.xfrmDetalleDieselUnidad_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmDetalleDieselUnidad_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCandadoActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCandadoAnterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMillas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCandadoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCandadoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanque)).EndInit();
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
        private DevExpress.XtraEditors.RadioGroup rgTanques;
        private DevExpress.XtraEditors.TextEdit txtLitros;
        private DevExpress.XtraEditors.TextEdit txtCandadoActual;
        private DevExpress.XtraEditors.TextEdit txtCandadoAnterior;
        private DevExpress.XtraEditors.TextEdit txtMillas;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciMillas;
        private DevExpress.XtraLayout.LayoutControlItem lciCandadoAnterior;
        private DevExpress.XtraLayout.LayoutControlItem lciCandadoActual;
        private DevExpress.XtraLayout.LayoutControlItem lciLitros;
        private DevExpress.XtraLayout.LayoutControlItem lciTanque;
    }
}