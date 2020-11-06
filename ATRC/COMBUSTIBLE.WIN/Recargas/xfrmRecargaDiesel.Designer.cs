namespace COMBUSTIBLE.WIN
{
    partial class xfrmRecargaDiesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRecargaDiesel));
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInicializarCero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTerminarRecarga = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtLecturaInicial = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.GaugeControlMedidor = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge11 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.spnPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.spnCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.rgTanques = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTanques = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrecio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMedidor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFactura = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLecturaInicial = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLecturaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMedidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLecturaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGuardar,
            this.bbiCancelar,
            this.bbiInicializarCero,
            this.bbiTerminarRecarga});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(432, 132);
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
            // bbiInicializarCero
            // 
            this.bbiInicializarCero.Caption = "Inicializar en cero";
            this.bbiInicializarCero.Id = 3;
            this.bbiInicializarCero.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiInicializarCero.ImageOptions.Image")));
            this.bbiInicializarCero.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiInicializarCero.ImageOptions.LargeImage")));
            this.bbiInicializarCero.Name = "bbiInicializarCero";
            this.bbiInicializarCero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiInicializarCero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInicializarCero_ItemClick);
            // 
            // bbiTerminarRecarga
            // 
            this.bbiTerminarRecarga.Caption = "Terminar recarga";
            this.bbiTerminarRecarga.Id = 4;
            this.bbiTerminarRecarga.ImageOptions.Image = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_gas_pump_32__1_;
            this.bbiTerminarRecarga.Name = "bbiTerminarRecarga";
            this.bbiTerminarRecarga.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiTerminarRecarga.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTerminarRecarga_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpg});
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
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // rpg
            // 
            this.rpg.AllowTextClipping = false;
            this.rpg.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpg.ItemLinks.Add(this.bbiTerminarRecarga);
            this.rpg.ItemLinks.Add(this.bbiInicializarCero);
            this.rpg.Name = "rpg";
            this.rpg.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtLecturaInicial);
            this.lcMain.Controls.Add(this.txtProveedor);
            this.lcMain.Controls.Add(this.txtFactura);
            this.lcMain.Controls.Add(this.GaugeControlMedidor);
            this.lcMain.Controls.Add(this.spnPrecio);
            this.lcMain.Controls.Add(this.spnCantidad);
            this.lcMain.Controls.Add(this.rgTanques);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(610, 47, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(432, 435);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtLecturaInicial
            // 
            this.txtLecturaInicial.Location = new System.Drawing.Point(84, 147);
            this.txtLecturaInicial.MenuManager = this.ribbonControl1;
            this.txtLecturaInicial.Name = "txtLecturaInicial";
            this.txtLecturaInicial.Size = new System.Drawing.Size(336, 20);
            this.txtLecturaInicial.StyleController = this.lcMain;
            this.txtLecturaInicial.TabIndex = 10;
            // 
            // txtProveedor
            // 
            this.txtProveedor.EnterMoveNextControl = true;
            this.txtProveedor.Location = new System.Drawing.Point(84, 123);
            this.txtProveedor.MenuManager = this.ribbonControl1;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(336, 20);
            this.txtProveedor.StyleController = this.lcMain;
            this.txtProveedor.TabIndex = 9;
            // 
            // txtFactura
            // 
            this.txtFactura.EnterMoveNextControl = true;
            this.txtFactura.Location = new System.Drawing.Point(84, 99);
            this.txtFactura.MenuManager = this.ribbonControl1;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(336, 20);
            this.txtFactura.StyleController = this.lcMain;
            this.txtFactura.TabIndex = 8;
            // 
            // GaugeControlMedidor
            // 
            this.GaugeControlMedidor.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge11});
            this.GaugeControlMedidor.Location = new System.Drawing.Point(12, 171);
            this.GaugeControlMedidor.Name = "GaugeControlMedidor";
            this.GaugeControlMedidor.Size = new System.Drawing.Size(408, 252);
            this.GaugeControlMedidor.TabIndex = 7;
            // 
            // circularGauge11
            // 
            this.circularGauge11.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge11.Bounds = new System.Drawing.Rectangle(6, 6, 396, 240);
            this.circularGauge11.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge11.Name = "circularGauge11";
            this.circularGauge11.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge11.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.circularGauge11.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.501F, 0.57F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style26;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 224F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F);
            this.arcScaleComponent1.EndAngle = 45F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style26_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -8F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style26_2;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.RadiusX = 97F;
            this.arcScaleComponent1.RadiusY = 97F;
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange1.EndThickness = 14F;
            arcScaleRange1.EndValue = 33F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = 0F;
            arcScaleRange1.StartThickness = 14F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D");
            arcScaleRange2.EndThickness = 14F;
            arcScaleRange2.EndValue = 66F;
            arcScaleRange2.Name = "Range1";
            arcScaleRange2.ShapeOffset = 0F;
            arcScaleRange2.StartThickness = 14F;
            arcScaleRange2.StartValue = 33F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75");
            arcScaleRange3.EndThickness = 14F;
            arcScaleRange3.EndValue = 100F;
            arcScaleRange3.Name = "Range2";
            arcScaleRange3.ShapeOffset = 0F;
            arcScaleRange3.StartThickness = 14F;
            arcScaleRange3.StartValue = 66F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
            this.arcScaleComponent1.StartAngle = -225F;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.labelComponent1.Name = "circularGauge11_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 100F);
            this.labelComponent1.Text = "";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 23F;
            this.arcScaleNeedleComponent1.Name = "needle1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style26;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "cap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style26;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // spnPrecio
            // 
            this.spnPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPrecio.EnterMoveNextControl = true;
            this.spnPrecio.Location = new System.Drawing.Point(84, 51);
            this.spnPrecio.MenuManager = this.ribbonControl1;
            this.spnPrecio.Name = "spnPrecio";
            this.spnPrecio.Properties.DisplayFormat.FormatString = "c";
            this.spnPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.EditFormat.FormatString = "c";
            this.spnPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnPrecio.Properties.Mask.EditMask = "c";
            this.spnPrecio.Size = new System.Drawing.Size(336, 20);
            this.spnPrecio.StyleController = this.lcMain;
            this.spnPrecio.TabIndex = 6;
            // 
            // spnCantidad
            // 
            this.spnCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCantidad.EnterMoveNextControl = true;
            this.spnCantidad.Location = new System.Drawing.Point(84, 75);
            this.spnCantidad.MenuManager = this.ribbonControl1;
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Properties.DisplayFormat.FormatString = "d";
            this.spnCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.EditFormat.FormatString = "d";
            this.spnCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCantidad.Properties.Mask.EditMask = "d";
            this.spnCantidad.Size = new System.Drawing.Size(336, 20);
            this.spnCantidad.StyleController = this.lcMain;
            this.spnCantidad.TabIndex = 5;
            this.spnCantidad.EditValueChanged += new System.EventHandler(this.spnCantidad_EditValueChanged);
            // 
            // rgTanques
            // 
            this.rgTanques.Location = new System.Drawing.Point(84, 12);
            this.rgTanques.MenuManager = this.ribbonControl1;
            this.rgTanques.Name = "rgTanques";
            this.rgTanques.Size = new System.Drawing.Size(336, 35);
            this.rgTanques.StyleController = this.lcMain;
            this.rgTanques.TabIndex = 4;
            this.rgTanques.SelectedIndexChanged += new System.EventHandler(this.rgTanques_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTanques,
            this.lciCantidad,
            this.lciPrecio,
            this.lciMedidor,
            this.lciFactura,
            this.lciProveedor,
            this.lciLecturaInicial});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(432, 435);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciTanques
            // 
            this.lciTanques.Control = this.rgTanques;
            this.lciTanques.Location = new System.Drawing.Point(0, 0);
            this.lciTanques.MaxSize = new System.Drawing.Size(0, 39);
            this.lciTanques.MinSize = new System.Drawing.Size(126, 39);
            this.lciTanques.Name = "lciTanques";
            this.lciTanques.Size = new System.Drawing.Size(412, 39);
            this.lciTanques.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTanques.Text = "Tanques:";
            this.lciTanques.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciCantidad
            // 
            this.lciCantidad.Control = this.spnCantidad;
            this.lciCantidad.Location = new System.Drawing.Point(0, 63);
            this.lciCantidad.Name = "lciCantidad";
            this.lciCantidad.Size = new System.Drawing.Size(412, 24);
            this.lciCantidad.Text = "Cantidad (lts):";
            this.lciCantidad.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciPrecio
            // 
            this.lciPrecio.Control = this.spnPrecio;
            this.lciPrecio.Location = new System.Drawing.Point(0, 39);
            this.lciPrecio.Name = "lciPrecio";
            this.lciPrecio.Size = new System.Drawing.Size(412, 24);
            this.lciPrecio.Text = "Precio:";
            this.lciPrecio.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciMedidor
            // 
            this.lciMedidor.Control = this.GaugeControlMedidor;
            this.lciMedidor.Location = new System.Drawing.Point(0, 159);
            this.lciMedidor.Name = "lciMedidor";
            this.lciMedidor.Size = new System.Drawing.Size(412, 256);
            this.lciMedidor.TextSize = new System.Drawing.Size(0, 0);
            this.lciMedidor.TextVisible = false;
            // 
            // lciFactura
            // 
            this.lciFactura.Control = this.txtFactura;
            this.lciFactura.Location = new System.Drawing.Point(0, 87);
            this.lciFactura.Name = "lciFactura";
            this.lciFactura.Size = new System.Drawing.Size(412, 24);
            this.lciFactura.Text = "Factura:";
            this.lciFactura.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciProveedor
            // 
            this.lciProveedor.Control = this.txtProveedor;
            this.lciProveedor.Location = new System.Drawing.Point(0, 111);
            this.lciProveedor.Name = "lciProveedor";
            this.lciProveedor.Size = new System.Drawing.Size(412, 24);
            this.lciProveedor.Text = "Proveedor:";
            this.lciProveedor.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciLecturaInicial
            // 
            this.lciLecturaInicial.Control = this.txtLecturaInicial;
            this.lciLecturaInicial.Location = new System.Drawing.Point(0, 135);
            this.lciLecturaInicial.Name = "lciLecturaInicial";
            this.lciLecturaInicial.Size = new System.Drawing.Size(412, 24);
            this.lciLecturaInicial.Text = "Lectura inicial:";
            this.lciLecturaInicial.TextSize = new System.Drawing.Size(69, 13);
            // 
            // xfrmRecargaDiesel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 567);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmRecargaDiesel.IconOptions.Icon")));
            this.Name = "xfrmRecargaDiesel";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Recarga de combustible";
            this.Load += new System.EventHandler(this.xfrmRecargaDiesel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmRecargaDiesel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLecturaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTanques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTanques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMedidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLecturaInicial)).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit spnPrecio;
        private DevExpress.XtraEditors.SpinEdit spnCantidad;
        private DevExpress.XtraEditors.RadioGroup rgTanques;
        private DevExpress.XtraLayout.LayoutControlItem lciTanques;
        private DevExpress.XtraLayout.LayoutControlItem lciCantidad;
        private DevExpress.XtraLayout.LayoutControlItem lciPrecio;
        private DevExpress.XtraGauges.Win.GaugeControl GaugeControlMedidor;
        private DevExpress.XtraLayout.LayoutControlItem lciMedidor;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge11;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraLayout.LayoutControlItem lciFactura;
        private DevExpress.XtraLayout.LayoutControlItem lciProveedor;
        private DevExpress.XtraEditors.TextEdit txtLecturaInicial;
        private DevExpress.XtraLayout.LayoutControlItem lciLecturaInicial;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg;
        private DevExpress.XtraBars.BarButtonItem bbiInicializarCero;
        private DevExpress.XtraBars.BarButtonItem bbiTerminarRecarga;
    }
}