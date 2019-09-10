namespace GUARDIAS.WIN.Renta
{
    partial class xfrmAbonoContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAbonoContrato));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAbonar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.spnCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.txtContrato = new DevExpress.XtraEditors.TextEdit();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtDestino = new DevExpress.XtraEditors.TextEdit();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgTotal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTotal = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciCantidadAbonar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDetallesRenta = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDestino = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFolio = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidadAbonar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetallesRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiAbonar,
            this.bbiCancelar,
            this.bbiSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(569, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAbonar
            // 
            this.bbiAbonar.Caption = "Abonar";
            this.bbiAbonar.Id = 1;
            this.bbiAbonar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAbonar.ImageOptions.LargeImage")));
            this.bbiAbonar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiAbonar.Name = "bbiAbonar";
            this.bbiAbonar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAbonar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAbonar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAbonar);
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
            this.lcMain.Controls.Add(this.spnCantidad);
            this.lcMain.Controls.Add(this.txtContrato);
            this.lcMain.Controls.Add(this.txtCliente);
            this.lcMain.Controls.Add(this.txtDestino);
            this.lcMain.Controls.Add(this.txtUnidad);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(560, 93, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(569, 170);
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
            this.spnCantidad.Location = new System.Drawing.Point(143, 126);
            this.spnCantidad.MenuManager = this.ribbonControl1;
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnCantidad.Properties.DisplayFormat.FormatString = "C";
            this.spnCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.EditFormat.FormatString = "C";
            this.spnCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.Mask.EditMask = "c";
            this.spnCantidad.Size = new System.Drawing.Size(414, 20);
            this.spnCantidad.StyleController = this.lcMain;
            this.spnCantidad.TabIndex = 6;
            this.spnCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spnCantidad_KeyDown);
            // 
            // txtContrato
            // 
            this.txtContrato.EnterMoveNextControl = true;
            this.txtContrato.Location = new System.Drawing.Point(143, 102);
            this.txtContrato.MenuManager = this.ribbonControl1;
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(414, 20);
            this.txtContrato.StyleController = this.lcMain;
            this.txtContrato.TabIndex = 5;
            this.txtContrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrato_KeyDown);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(66, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(313, 20);
            this.txtCliente.StyleController = this.lcMain;
            this.txtCliente.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(69, 66);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Properties.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(120, 20);
            this.txtDestino.StyleController = this.lcMain;
            this.txtDestino.TabIndex = 7;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(235, 66);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(144, 20);
            this.txtUnidad.StyleController = this.lcMain;
            this.txtUnidad.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgTotal,
            this.lciCantidadAbonar,
            this.lciDetallesRenta,
            this.lciFolio});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(569, 170);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgTotal
            // 
            this.lcgTotal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotal});
            this.lcgTotal.Location = new System.Drawing.Point(383, 0);
            this.lcgTotal.Name = "lcgTotal";
            this.lcgTotal.Size = new System.Drawing.Size(166, 90);
            this.lcgTotal.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AllowHotTrack = false;
            this.lblTotal.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.AppearanceItemCaption.Options.UseFont = true;
            this.lblTotal.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblTotal.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotal.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 48);
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextSize = new System.Drawing.Size(128, 25);
            // 
            // lciCantidadAbonar
            // 
            this.lciCantidadAbonar.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciCantidadAbonar.AppearanceItemCaption.Options.UseFont = true;
            this.lciCantidadAbonar.Control = this.spnCantidad;
            this.lciCantidadAbonar.Location = new System.Drawing.Point(0, 114);
            this.lciCantidadAbonar.Name = "lciCantidadAbonar";
            this.lciCantidadAbonar.Size = new System.Drawing.Size(549, 36);
            this.lciCantidadAbonar.Text = "Cantidad a abonar:";
            this.lciCantidadAbonar.TextSize = new System.Drawing.Size(128, 14);
            // 
            // lciDetallesRenta
            // 
            this.lciDetallesRenta.CustomizationFormText = "Detalles de renta";
            this.lciDetallesRenta.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCliente,
            this.lciDestino,
            this.lciUnidad});
            this.lciDetallesRenta.Location = new System.Drawing.Point(0, 0);
            this.lciDetallesRenta.Name = "lciDetallesRenta";
            this.lciDetallesRenta.Size = new System.Drawing.Size(383, 90);
            this.lciDetallesRenta.Text = "Detalles de renta";
            this.lciDetallesRenta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciCliente
            // 
            this.lciCliente.Control = this.txtCliente;
            this.lciCliente.CustomizationFormText = "Cliente:";
            this.lciCliente.Location = new System.Drawing.Point(0, 0);
            this.lciCliente.Name = "lciCliente";
            this.lciCliente.Size = new System.Drawing.Size(359, 24);
            this.lciCliente.Text = "Cliente:";
            this.lciCliente.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciCliente.TextSize = new System.Drawing.Size(37, 13);
            this.lciCliente.TextToControlDistance = 5;
            // 
            // lciDestino
            // 
            this.lciDestino.Control = this.txtDestino;
            this.lciDestino.CustomizationFormText = "Destino:";
            this.lciDestino.Location = new System.Drawing.Point(0, 24);
            this.lciDestino.Name = "lciDestino";
            this.lciDestino.Size = new System.Drawing.Size(169, 24);
            this.lciDestino.Text = "Destino:";
            this.lciDestino.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDestino.TextSize = new System.Drawing.Size(40, 13);
            this.lciDestino.TextToControlDistance = 5;
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.txtUnidad;
            this.lciUnidad.CustomizationFormText = "Unidad:";
            this.lciUnidad.Location = new System.Drawing.Point(169, 24);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(190, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciUnidad.TextSize = new System.Drawing.Size(37, 13);
            this.lciUnidad.TextToControlDistance = 5;
            // 
            // lciFolio
            // 
            this.lciFolio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciFolio.AppearanceItemCaption.Options.UseFont = true;
            this.lciFolio.Control = this.txtContrato;
            this.lciFolio.Location = new System.Drawing.Point(0, 90);
            this.lciFolio.Name = "lciFolio";
            this.lciFolio.Size = new System.Drawing.Size(549, 24);
            this.lciFolio.Text = "Número de contrato:";
            this.lciFolio.TextSize = new System.Drawing.Size(128, 14);
            // 
            // xfrmAbonoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 292);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmAbonoContrato";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Abonar en renta de unidad";
            this.Load += new System.EventHandler(this.xfrmAbonoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidadAbonar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetallesRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiAbonar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.SpinEdit spnCantidad;
        private DevExpress.XtraEditors.TextEdit txtContrato;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciCantidadAbonar;
        private DevExpress.XtraLayout.LayoutControlItem lciFolio;
        private DevExpress.XtraLayout.SimpleLabelItem lblTotal;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.TextEdit txtDestino;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraLayout.LayoutControlGroup lciDetallesRenta;
        private DevExpress.XtraLayout.LayoutControlItem lciCliente;
        private DevExpress.XtraLayout.LayoutControlItem lciDestino;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}