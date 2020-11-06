namespace GUARDIAS.WIN
{
    partial class xfrmRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRecibos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.rgTipoCambio = new DevExpress.XtraEditors.RadioGroup();
            this.memoConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtEmisor = new DevExpress.XtraEditors.TextEdit();
            this.spnPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPrecio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRecibi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciConcepto = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoCambio = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(743, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.LargeImage")));
            this.bbiGuardar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiGuardar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
            this.bbiCancelar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiCancelar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 3;
            this.bbiSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.ImageOptions.LargeImage")));
            this.bbiSalir.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiSalir.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bbiSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
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
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.rgTipoCambio);
            this.lcMain.Controls.Add(this.memoConcepto);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Controls.Add(this.txtEmisor);
            this.lcMain.Controls.Add(this.spnPrecio);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(743, 205);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // rgTipoCambio
            // 
            this.rgTipoCambio.EnterMoveNextControl = true;
            this.rgTipoCambio.Location = new System.Drawing.Point(108, 38);
            this.rgTipoCambio.MenuManager = this.ribbonControl1;
            this.rgTipoCambio.Name = "rgTipoCambio";
            this.rgTipoCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTipoCambio.Properties.Appearance.Options.UseFont = true;
            this.rgTipoCambio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Pesos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Dólares")});
            this.rgTipoCambio.Size = new System.Drawing.Size(261, 26);
            this.rgTipoCambio.StyleController = this.lcMain;
            this.rgTipoCambio.TabIndex = 8;
            // 
            // memoConcepto
            // 
            this.memoConcepto.Location = new System.Drawing.Point(108, 94);
            this.memoConcepto.MenuManager = this.ribbonControl1;
            this.memoConcepto.Name = "memoConcepto";
            this.memoConcepto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoConcepto.Properties.Appearance.Options.UseFont = true;
            this.memoConcepto.Properties.MaxLength = 280;
            this.memoConcepto.Size = new System.Drawing.Size(623, 99);
            this.memoConcepto.StyleController = this.lcMain;
            this.memoConcepto.TabIndex = 7;
            this.memoConcepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memoConcepto_KeyDown);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.EnterMoveNextControl = true;
            this.dteFecha.Location = new System.Drawing.Point(108, 12);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha.Properties.Appearance.Options.UseFont = true;
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Size = new System.Drawing.Size(623, 22);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 6;
            // 
            // txtEmisor
            // 
            this.txtEmisor.EnterMoveNextControl = true;
            this.txtEmisor.Location = new System.Drawing.Point(108, 68);
            this.txtEmisor.MenuManager = this.ribbonControl1;
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmisor.Properties.Appearance.Options.UseFont = true;
            this.txtEmisor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmisor.Size = new System.Drawing.Size(623, 22);
            this.txtEmisor.StyleController = this.lcMain;
            this.txtEmisor.TabIndex = 5;
            // 
            // spnPrecio
            // 
            this.spnPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrecio.EnterMoveNextControl = true;
            this.spnPrecio.Location = new System.Drawing.Point(469, 38);
            this.spnPrecio.MenuManager = this.ribbonControl1;
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnPrecio.Properties.Appearance.Options.UseFont = true;
            this.spnPrecio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnPrecio.Properties.DisplayFormat.FormatString = "c";
            this.spnPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.EditFormat.FormatString = "c";
            this.spnPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.Mask.EditMask = "c";
            this.spnPrecio.Size = new System.Drawing.Size(262, 22);
            this.spnPrecio.StyleController = this.lcMain;
            this.spnPrecio.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPrecio,
            this.lciRecibi,
            this.lciConcepto,
            this.lciFecha,
            this.lciTipoCambio});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(743, 205);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciPrecio
            // 
            this.lciPrecio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciPrecio.AppearanceItemCaption.Options.UseFont = true;
            this.lciPrecio.Control = this.spnPrecio;
            this.lciPrecio.Location = new System.Drawing.Point(361, 26);
            this.lciPrecio.Name = "lciPrecio";
            this.lciPrecio.Size = new System.Drawing.Size(362, 30);
            this.lciPrecio.Text = "Precio:";
            this.lciPrecio.TextSize = new System.Drawing.Size(93, 16);
            // 
            // lciRecibi
            // 
            this.lciRecibi.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciRecibi.AppearanceItemCaption.Options.UseFont = true;
            this.lciRecibi.Control = this.txtEmisor;
            this.lciRecibi.Location = new System.Drawing.Point(0, 56);
            this.lciRecibi.Name = "lciRecibi";
            this.lciRecibi.Size = new System.Drawing.Size(723, 26);
            this.lciRecibi.Text = "Recibí de:";
            this.lciRecibi.TextSize = new System.Drawing.Size(93, 16);
            // 
            // lciConcepto
            // 
            this.lciConcepto.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciConcepto.AppearanceItemCaption.Options.UseFont = true;
            this.lciConcepto.Control = this.memoConcepto;
            this.lciConcepto.Location = new System.Drawing.Point(0, 82);
            this.lciConcepto.Name = "lciConcepto";
            this.lciConcepto.Size = new System.Drawing.Size(723, 103);
            this.lciConcepto.Text = "Concepto:";
            this.lciConcepto.TextSize = new System.Drawing.Size(93, 16);
            // 
            // lciFecha
            // 
            this.lciFecha.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciFecha.AppearanceItemCaption.Options.UseFont = true;
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(723, 26);
            this.lciFecha.Text = "Fecha:";
            this.lciFecha.TextSize = new System.Drawing.Size(93, 16);
            // 
            // lciTipoCambio
            // 
            this.lciTipoCambio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciTipoCambio.AppearanceItemCaption.Options.UseFont = true;
            this.lciTipoCambio.Control = this.rgTipoCambio;
            this.lciTipoCambio.Location = new System.Drawing.Point(0, 26);
            this.lciTipoCambio.Name = "lciTipoCambio";
            this.lciTipoCambio.Size = new System.Drawing.Size(361, 30);
            this.lciTipoCambio.Text = "Tipo de cambio:";
            this.lciTipoCambio.TextSize = new System.Drawing.Size(93, 16);
            // 
            // xfrmRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 327);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmRecibos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.xfrmRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.MemoEdit memoConcepto;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraEditors.TextEdit txtEmisor;
        private DevExpress.XtraEditors.SpinEdit spnPrecio;
        private DevExpress.XtraLayout.LayoutControlItem lciPrecio;
        private DevExpress.XtraLayout.LayoutControlItem lciRecibi;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciConcepto;
        private DevExpress.XtraEditors.RadioGroup rgTipoCambio;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoCambio;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}