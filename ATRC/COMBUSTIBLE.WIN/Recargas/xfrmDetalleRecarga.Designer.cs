namespace COMBUSTIBLE.WIN
{
    partial class xfrmDetalleRecarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDetalleRecarga));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.lciProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.spnCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.lciCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.spnPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.lciPrecio = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtInicial = new DevExpress.XtraEditors.TextEdit();
            this.lciInicial = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFinal = new DevExpress.XtraEditors.TextEdit();
            this.lciFinal = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFinal)).BeginInit();
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
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(354, 132);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtFinal);
            this.lcMain.Controls.Add(this.txtInicial);
            this.lcMain.Controls.Add(this.spnPrecio);
            this.lcMain.Controls.Add(this.spnCantidad);
            this.lcMain.Controls.Add(this.txtProveedor);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(354, 150);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProveedor,
            this.emptySpaceItem1,
            this.lciCantidad,
            this.lciPrecio,
            this.lciInicial,
            this.lciFinal});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(354, 150);
            this.Root.TextVisible = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = global::COMBUSTIBLE.WIN.Properties.Resources.Guardar1;
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = global::COMBUSTIBLE.WIN.Properties.Resources.Cancelar1;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // txtProveedor
            // 
            this.txtProveedor.EnterMoveNextControl = true;
            this.txtProveedor.Location = new System.Drawing.Point(78, 12);
            this.txtProveedor.MenuManager = this.ribbonControl1;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(264, 20);
            this.txtProveedor.StyleController = this.lcMain;
            this.txtProveedor.TabIndex = 4;
            // 
            // lciProveedor
            // 
            this.lciProveedor.Control = this.txtProveedor;
            this.lciProveedor.Location = new System.Drawing.Point(0, 0);
            this.lciProveedor.Name = "lciProveedor";
            this.lciProveedor.Size = new System.Drawing.Size(334, 24);
            this.lciProveedor.Text = "Proveedor:";
            this.lciProveedor.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(334, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // spnCantidad
            // 
            this.spnCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCantidad.EnterMoveNextControl = true;
            this.spnCantidad.Location = new System.Drawing.Point(78, 36);
            this.spnCantidad.MenuManager = this.ribbonControl1;
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Size = new System.Drawing.Size(264, 20);
            this.spnCantidad.StyleController = this.lcMain;
            this.spnCantidad.TabIndex = 5;
            // 
            // lciCantidad
            // 
            this.lciCantidad.Control = this.spnCantidad;
            this.lciCantidad.Location = new System.Drawing.Point(0, 24);
            this.lciCantidad.Name = "lciCantidad";
            this.lciCantidad.Size = new System.Drawing.Size(334, 24);
            this.lciCantidad.Text = "Cantidad:";
            this.lciCantidad.TextSize = new System.Drawing.Size(54, 13);
            // 
            // spnPrecio
            // 
            this.spnPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrecio.EnterMoveNextControl = true;
            this.spnPrecio.Location = new System.Drawing.Point(78, 60);
            this.spnPrecio.MenuManager = this.ribbonControl1;
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Properties.DisplayFormat.FormatString = "c";
            this.spnPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.EditFormat.FormatString = "c";
            this.spnPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.Mask.EditMask = "c";
            this.spnPrecio.Size = new System.Drawing.Size(264, 20);
            this.spnPrecio.StyleController = this.lcMain;
            this.spnPrecio.TabIndex = 6;
            // 
            // lciPrecio
            // 
            this.lciPrecio.Control = this.spnPrecio;
            this.lciPrecio.Location = new System.Drawing.Point(0, 48);
            this.lciPrecio.Name = "lciPrecio";
            this.lciPrecio.Size = new System.Drawing.Size(334, 24);
            this.lciPrecio.Text = "Precio:";
            this.lciPrecio.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txtInicial
            // 
            this.txtInicial.EnterMoveNextControl = true;
            this.txtInicial.Location = new System.Drawing.Point(78, 84);
            this.txtInicial.MenuManager = this.ribbonControl1;
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(264, 20);
            this.txtInicial.StyleController = this.lcMain;
            this.txtInicial.TabIndex = 7;
            // 
            // lciInicial
            // 
            this.lciInicial.Control = this.txtInicial;
            this.lciInicial.Location = new System.Drawing.Point(0, 72);
            this.lciInicial.Name = "lciInicial";
            this.lciInicial.Size = new System.Drawing.Size(334, 24);
            this.lciInicial.Text = "Inicial:";
            this.lciInicial.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(78, 108);
            this.txtFinal.MenuManager = this.ribbonControl1;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(264, 20);
            this.txtFinal.StyleController = this.lcMain;
            this.txtFinal.TabIndex = 8;
            // 
            // lciFinal
            // 
            this.lciFinal.Control = this.txtFinal;
            this.lciFinal.Location = new System.Drawing.Point(0, 96);
            this.lciFinal.Name = "lciFinal";
            this.lciFinal.Size = new System.Drawing.Size(334, 24);
            this.lciFinal.Text = "Final:";
            this.lciFinal.TextSize = new System.Drawing.Size(54, 13);
            // 
            // xfrmDetalleRecarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmDetalleRecarga.IconOptions.Icon")));
            this.Name = "xfrmDetalleRecarga";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Detalle de recarga";
            this.Load += new System.EventHandler(this.xfrmDetalleRecarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFinal)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtFinal;
        private DevExpress.XtraEditors.TextEdit txtInicial;
        private DevExpress.XtraEditors.SpinEdit spnPrecio;
        private DevExpress.XtraEditors.SpinEdit spnCantidad;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraLayout.LayoutControlItem lciProveedor;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciCantidad;
        private DevExpress.XtraLayout.LayoutControlItem lciPrecio;
        private DevExpress.XtraLayout.LayoutControlItem lciInicial;
        private DevExpress.XtraLayout.LayoutControlItem lciFinal;
    }
}