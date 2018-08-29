namespace CHECADOR.WIN
{
    partial class xfrmFiltrosReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmFiltrosReportes));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnNumUsuario = new DevExpress.XtraEditors.ButtonEdit();
            this.rgTipoBusqueda = new DevExpress.XtraEditors.RadioGroup();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDesde = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHasta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNumUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(625, 122);
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
            this.bbiCancelar.ImageOptions.LargeImage = global::CHECADOR.WIN.Properties.Resources.Cancelar;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Controls.Add(this.btnNumUsuario);
            this.lcMain.Controls.Add(this.rgTipoBusqueda);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDel);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(625, 146);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(358, 95);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 8;
            // 
            // btnNumUsuario
            // 
            this.btnNumUsuario.Location = new System.Drawing.Point(121, 95);
            this.btnNumUsuario.MenuManager = this.ribbonControl1;
            this.btnNumUsuario.Name = "btnNumUsuario";
            this.btnNumUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnNumUsuario.Properties.Mask.EditMask = "\\d{1,10}";
            this.btnNumUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.btnNumUsuario.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.btnNumUsuario.Size = new System.Drawing.Size(136, 20);
            this.btnNumUsuario.StyleController = this.lcMain;
            this.btnNumUsuario.TabIndex = 7;
            this.btnNumUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNumUsuario_KeyDown);
            this.btnNumUsuario.Leave += new System.EventHandler(this.btnNumUsuario_Leave);
            // 
            // rgTipoBusqueda
            // 
            this.rgTipoBusqueda.Location = new System.Drawing.Point(121, 66);
            this.rgTipoBusqueda.MenuManager = this.ribbonControl1;
            this.rgTipoBusqueda.Name = "rgTipoBusqueda";
            this.rgTipoBusqueda.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todos los usuarios"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Usuario específico")});
            this.rgTipoBusqueda.Size = new System.Drawing.Size(480, 25);
            this.rgTipoBusqueda.StyleController = this.lcMain;
            this.rgTipoBusqueda.TabIndex = 6;
            this.rgTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.rgTipoBusqueda_SelectedIndexChanged);
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(411, 42);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Size = new System.Drawing.Size(190, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 5;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.Location = new System.Drawing.Point(121, 42);
            this.dteDel.MenuManager = this.ribbonControl1;
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Size = new System.Drawing.Size(189, 20);
            this.dteDel.StyleController = this.lcMain;
            this.dteDel.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgBusqueda});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(625, 146);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDesde,
            this.lciHasta,
            this.lciTipo,
            this.lciNumUsuario,
            this.lciNombre});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(605, 126);
            this.lcgBusqueda.Text = "Criterios de búsqueda";
            // 
            // lciDesde
            // 
            this.lciDesde.Control = this.dteDel;
            this.lciDesde.Location = new System.Drawing.Point(0, 0);
            this.lciDesde.Name = "lciDesde";
            this.lciDesde.Size = new System.Drawing.Size(290, 24);
            this.lciDesde.Text = "Del:";
            this.lciDesde.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciHasta
            // 
            this.lciHasta.Control = this.dteAl;
            this.lciHasta.Location = new System.Drawing.Point(290, 0);
            this.lciHasta.Name = "lciHasta";
            this.lciHasta.Size = new System.Drawing.Size(291, 24);
            this.lciHasta.Text = "Al:";
            this.lciHasta.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciTipo
            // 
            this.lciTipo.Control = this.rgTipoBusqueda;
            this.lciTipo.Location = new System.Drawing.Point(0, 24);
            this.lciTipo.MaxSize = new System.Drawing.Size(0, 29);
            this.lciTipo.MinSize = new System.Drawing.Size(152, 29);
            this.lciTipo.Name = "lciTipo";
            this.lciTipo.Size = new System.Drawing.Size(581, 29);
            this.lciTipo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipo.Text = "Tipo de búsqueda:";
            this.lciTipo.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciNumUsuario
            // 
            this.lciNumUsuario.Control = this.btnNumUsuario;
            this.lciNumUsuario.Location = new System.Drawing.Point(0, 53);
            this.lciNumUsuario.Name = "lciNumUsuario";
            this.lciNumUsuario.Size = new System.Drawing.Size(237, 31);
            this.lciNumUsuario.Text = "Número de usuario:";
            this.lciNumUsuario.TextSize = new System.Drawing.Size(94, 13);
            this.lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(237, 53);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(344, 31);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextSize = new System.Drawing.Size(94, 13);
            this.lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmFiltrosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 268);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmFiltrosReportes";
            this.Ribbon = this.ribbonControl1;
            this.Text = "";
            this.Load += new System.EventHandler(this.xfrmFiltrosReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.ButtonEdit btnNumUsuario;
        private DevExpress.XtraEditors.RadioGroup rgTipoBusqueda;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciDesde;
        private DevExpress.XtraLayout.LayoutControlItem lciHasta;
        private DevExpress.XtraLayout.LayoutControlItem lciTipo;
        private DevExpress.XtraLayout.LayoutControlItem lciNumUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
    }
}