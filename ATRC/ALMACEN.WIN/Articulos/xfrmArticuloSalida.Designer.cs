namespace ALMACEN.WIN
{
    partial class xfrmArticuloSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmArticuloSalida));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.rpControl = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.spnCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.lueFactura = new DevExpress.XtraEditors.LookUpEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCodigo = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciArticulos = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblPrecio = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblTotal = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiAgregar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpControl});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(784, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAgregar
            // 
            this.bbiAgregar.Caption = "Agregar artículo";
            this.bbiAgregar.Id = 1;
            this.bbiAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregar.ImageOptions.Image")));
            this.bbiAgregar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiAgregar.Name = "bbiAgregar";
            this.bbiAgregar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAgregar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.Image")));
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // rpControl
            // 
            this.rpControl.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpControl.Name = "rpControl";
            this.rpControl.Text = "ribbonPage1";
            this.rpControl.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAgregar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.spnCantidad);
            this.lcMain.Controls.Add(this.lueFactura);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.btnCodigo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(160, 442, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(784, 92);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // spnCantidad
            // 
            this.spnCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCantidad.Enabled = false;
            this.spnCantidad.Location = new System.Drawing.Point(111, 95);
            this.spnCantidad.MenuManager = this.ribbonControl1;
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnCantidad.Size = new System.Drawing.Size(260, 20);
            this.spnCantidad.StyleController = this.lcMain;
            this.spnCantidad.TabIndex = 7;
            this.spnCantidad.EditValueChanged += new System.EventHandler(this.spnCantidad_EditValueChanged);
            // 
            // lueFactura
            // 
            this.lueFactura.Enabled = false;
            this.lueFactura.Location = new System.Drawing.Point(111, 71);
            this.lueFactura.MenuManager = this.ribbonControl1;
            this.lueFactura.Name = "lueFactura";
            this.lueFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFactura.Properties.NullText = "[Seleccione]";
            this.lueFactura.Size = new System.Drawing.Size(632, 20);
            this.lueFactura.StyleController = this.lcMain;
            this.lueFactura.TabIndex = 6;
            this.lueFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lueFactura_KeyUp);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(683, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(99, 12);
            this.btnCodigo.MenuManager = this.ribbonControl1;
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCodigo.Size = new System.Drawing.Size(580, 20);
            this.btnCodigo.StyleController = this.lcMain;
            this.btnCodigo.TabIndex = 4;
            this.btnCodigo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnCodigo_ButtonClick);
            this.btnCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCodigo_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCodigo,
            this.layoutControlItem2,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(767, 149);
            this.Root.TextVisible = false;
            // 
            // lciCodigo
            // 
            this.lciCodigo.Control = this.btnCodigo;
            this.lciCodigo.Location = new System.Drawing.Point(0, 0);
            this.lciCodigo.Name = "lciCodigo";
            this.lciCodigo.Size = new System.Drawing.Size(671, 26);
            this.lciCodigo.Text = "Ingresé código:";
            this.lciCodigo.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnBuscar;
            this.layoutControlItem2.Location = new System.Drawing.Point(671, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(76, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciArticulos,
            this.lciCantidad,
            this.simpleLabelItem4,
            this.lblPrecio,
            this.simpleLabelItem2,
            this.lblTotal,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(747, 103);
            this.layoutControlGroup1.Text = "Detalles";
            // 
            // lciArticulos
            // 
            this.lciArticulos.Control = this.lueFactura;
            this.lciArticulos.Location = new System.Drawing.Point(0, 0);
            this.lciArticulos.Name = "lciArticulos";
            this.lciArticulos.Size = new System.Drawing.Size(723, 24);
            this.lciArticulos.Text = "Artículos:";
            this.lciArticulos.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciCantidad
            // 
            this.lciCantidad.Control = this.spnCantidad;
            this.lciCantidad.Location = new System.Drawing.Point(0, 24);
            this.lciCantidad.Name = "lciCantidad";
            this.lciCantidad.Size = new System.Drawing.Size(351, 24);
            this.lciCantidad.Text = "Cantidad:";
            this.lciCantidad.TextSize = new System.Drawing.Size(75, 13);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.Location = new System.Drawing.Point(351, 24);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(79, 24);
            this.simpleLabelItem4.Text = "Precio:";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AllowHotTrack = false;
            this.lblPrecio.Location = new System.Drawing.Point(430, 24);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(115, 24);
            this.lblPrecio.Text = " ";
            this.lblPrecio.TextSize = new System.Drawing.Size(75, 13);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(545, 24);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(79, 24);
            this.simpleLabelItem2.Text = "Total:";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lblTotal
            // 
            this.lblTotal.AllowHotTrack = false;
            this.lblTotal.Location = new System.Drawing.Point(624, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 24);
            this.lblTotal.Text = " ";
            this.lblTotal.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(723, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmArticuloSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 224);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmArticuloSalida.IconOptions.Icon")));
            this.Name = "xfrmArticuloSalida";
            this.Ribbon = this.ribbonControl1;
            this.Text = "xfrmArticuloSalida";
            this.Load += new System.EventHandler(this.xfrmArticuloSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarButtonItem bbiAgregar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.SpinEdit spnCantidad;
        private DevExpress.XtraEditors.LookUpEdit lueFactura;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.ButtonEdit btnCodigo;
        private DevExpress.XtraLayout.LayoutControlItem lciCodigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciArticulos;
        private DevExpress.XtraLayout.LayoutControlItem lciCantidad;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private DevExpress.XtraLayout.SimpleLabelItem lblPrecio;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem lblTotal;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}