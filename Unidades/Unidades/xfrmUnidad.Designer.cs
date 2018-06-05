namespace Unidades
{
    partial class xfrmUnidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmUnidad));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtVIN = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciModelo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMarca = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVIN = new DevExpress.XtraLayout.LayoutControlItem();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.spnPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.lciPrecio = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboTipoMoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lciTipoMoneda = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.lciLugarCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cboFormaPago = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lciFormaPago = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLugarCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFormaPago)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(568, 122);
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
            this.bbiCancelar.ImageOptions.LargeImage = global::Unidades.Properties.Resources.Cancelar1;
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAcciones});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.AllowMinimize = false;
            this.rpgAcciones.AllowTextClipping = false;
            this.rpgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.cboFormaPago);
            this.lcMain.Controls.Add(this.txtLugar);
            this.lcMain.Controls.Add(this.cboTipoMoneda);
            this.lcMain.Controls.Add(this.spnPrecio);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Controls.Add(this.txtVIN);
            this.lcMain.Controls.Add(this.txtMarca);
            this.lcMain.Controls.Add(this.txtModelo);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(568, 328);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(12, 148);
            this.txtVIN.MenuManager = this.ribbonControl1;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(544, 20);
            this.txtVIN.StyleController = this.lcMain;
            this.txtVIN.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 68);
            this.txtMarca.MenuManager = this.ribbonControl1;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(544, 20);
            this.txtMarca.StyleController = this.lcMain;
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 108);
            this.txtModelo.MenuManager = this.ribbonControl1;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(544, 20);
            this.txtModelo.StyleController = this.lcMain;
            this.txtModelo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 28);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(544, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNombre,
            this.lciModelo,
            this.lciMarca,
            this.lciVIN,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(568, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciNombre
            // 
            this.lciNombre.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciNombre.AppearanceItemCaption.Options.UseFont = true;
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(0, 0);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(548, 40);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNombre.TextSize = new System.Drawing.Size(86, 13);
            // 
            // lciModelo
            // 
            this.lciModelo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciModelo.AppearanceItemCaption.Options.UseFont = true;
            this.lciModelo.Control = this.txtModelo;
            this.lciModelo.Location = new System.Drawing.Point(0, 80);
            this.lciModelo.Name = "lciModelo";
            this.lciModelo.Size = new System.Drawing.Size(548, 40);
            this.lciModelo.Text = "Modelo:";
            this.lciModelo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciModelo.TextSize = new System.Drawing.Size(86, 13);
            // 
            // lciMarca
            // 
            this.lciMarca.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciMarca.AppearanceItemCaption.Options.UseFont = true;
            this.lciMarca.Control = this.txtMarca;
            this.lciMarca.Location = new System.Drawing.Point(0, 40);
            this.lciMarca.Name = "lciMarca";
            this.lciMarca.Size = new System.Drawing.Size(548, 40);
            this.lciMarca.Text = "Marca:";
            this.lciMarca.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMarca.TextSize = new System.Drawing.Size(86, 13);
            // 
            // lciVIN
            // 
            this.lciVIN.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciVIN.AppearanceItemCaption.Options.UseFont = true;
            this.lciVIN.Control = this.txtVIN;
            this.lciVIN.Location = new System.Drawing.Point(0, 120);
            this.lciVIN.Name = "lciVIN";
            this.lciVIN.Size = new System.Drawing.Size(548, 40);
            this.lciVIN.Text = "VIN:";
            this.lciVIN.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciVIN.TextSize = new System.Drawing.Size(86, 13);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(113, 202);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Size = new System.Drawing.Size(431, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 8;
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(524, 24);
            this.lciFecha.Text = "Fecha de compra:";
            this.lciFecha.TextSize = new System.Drawing.Size(86, 13);
            // 
            // spnPrecio
            // 
            this.spnPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrecio.Location = new System.Drawing.Point(113, 226);
            this.spnPrecio.MenuManager = this.ribbonControl1;
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnPrecio.Properties.DisplayFormat.FormatString = "c";
            this.spnPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.EditFormat.FormatString = "c";
            this.spnPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.Mask.EditMask = "c";
            this.spnPrecio.Size = new System.Drawing.Size(169, 20);
            this.spnPrecio.StyleController = this.lcMain;
            this.spnPrecio.TabIndex = 9;
            // 
            // lciPrecio
            // 
            this.lciPrecio.Control = this.spnPrecio;
            this.lciPrecio.Location = new System.Drawing.Point(0, 24);
            this.lciPrecio.Name = "lciPrecio";
            this.lciPrecio.Size = new System.Drawing.Size(262, 24);
            this.lciPrecio.Text = "Precio:";
            this.lciPrecio.TextSize = new System.Drawing.Size(86, 13);
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.Location = new System.Drawing.Point(375, 226);
            this.cboTipoMoneda.MenuManager = this.ribbonControl1;
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoMoneda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTipoMoneda.Size = new System.Drawing.Size(169, 20);
            this.cboTipoMoneda.StyleController = this.lcMain;
            this.cboTipoMoneda.TabIndex = 10;
            // 
            // lciTipoMoneda
            // 
            this.lciTipoMoneda.Control = this.cboTipoMoneda;
            this.lciTipoMoneda.Location = new System.Drawing.Point(262, 24);
            this.lciTipoMoneda.Name = "lciTipoMoneda";
            this.lciTipoMoneda.Size = new System.Drawing.Size(262, 24);
            this.lciTipoMoneda.Text = "Tipo de moneda:";
            this.lciTipoMoneda.TextSize = new System.Drawing.Size(86, 13);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(113, 274);
            this.txtLugar.MenuManager = this.ribbonControl1;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(431, 20);
            this.txtLugar.StyleController = this.lcMain;
            this.txtLugar.TabIndex = 13;
            // 
            // lciLugarCompra
            // 
            this.lciLugarCompra.Control = this.txtLugar;
            this.lciLugarCompra.Location = new System.Drawing.Point(0, 72);
            this.lciLugarCompra.Name = "lciLugarCompra";
            this.lciLugarCompra.Size = new System.Drawing.Size(524, 34);
            this.lciLugarCompra.Text = "Lugar de compra:";
            this.lciLugarCompra.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFecha,
            this.lciPrecio,
            this.lciLugarCompra,
            this.lciTipoMoneda,
            this.lciFormaPago});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 160);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(548, 148);
            this.layoutControlGroup2.Text = "Costo de unidad";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.Location = new System.Drawing.Point(113, 250);
            this.cboFormaPago.MenuManager = this.ribbonControl1;
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFormaPago.Size = new System.Drawing.Size(431, 20);
            this.cboFormaPago.StyleController = this.lcMain;
            this.cboFormaPago.TabIndex = 14;
            // 
            // lciFormaPago
            // 
            this.lciFormaPago.Control = this.cboFormaPago;
            this.lciFormaPago.Location = new System.Drawing.Point(0, 48);
            this.lciFormaPago.Name = "lciFormaPago";
            this.lciFormaPago.Size = new System.Drawing.Size(524, 24);
            this.lciFormaPago.Text = "Forma de pago:";
            this.lciFormaPago.TextSize = new System.Drawing.Size(86, 13);
            // 
            // xfrmUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmUnidad";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad";
            this.Load += new System.EventHandler(this.xfrmUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtVIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLugarCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFormaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtVIN;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciModelo;
        private DevExpress.XtraLayout.LayoutControlItem lciMarca;
        private DevExpress.XtraLayout.LayoutControlItem lciVIN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private DevExpress.XtraEditors.ComboBoxEdit cboTipoMoneda;
        private DevExpress.XtraEditors.SpinEdit spnPrecio;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciPrecio;
        private DevExpress.XtraLayout.LayoutControlItem lciLugarCompra;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoMoneda;
        private DevExpress.XtraEditors.ComboBoxEdit cboFormaPago;
        private DevExpress.XtraLayout.LayoutControlItem lciFormaPago;
    }
}