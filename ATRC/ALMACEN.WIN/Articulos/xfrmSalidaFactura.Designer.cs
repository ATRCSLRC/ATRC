namespace ALMACEN.WIN
{
    partial class xfrmSalidaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSalidaFactura));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalida = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.rpAcciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtOtroRecibo = new DevExpress.XtraEditors.TextEdit();
            this.txtOtro = new DevExpress.XtraEditors.TextEdit();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.lueRecibo = new DevExpress.XtraEditors.LookUpEdit();
            this.rgRecibo = new DevExpress.XtraEditors.RadioGroup();
            this.rgDestino = new DevExpress.XtraEditors.RadioGroup();
            this.rgTipoSalida = new DevExpress.XtraEditors.RadioGroup();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.grvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumParte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFactura = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciArticulos = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoSalida = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDestino = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRecibio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOtro = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOtroEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.flpAccionesFactura = new DevExpress.Utils.FlyoutPanel();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtroEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAccionesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiSalida,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAcciones});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiSalida
            // 
            this.bbiSalida.Caption = "Generar salida";
            this.bbiSalida.Id = 1;
            this.bbiSalida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSalida.ImageOptions.Image")));
            this.bbiSalida.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiSalida.Name = "bbiSalida";
            this.bbiSalida.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalida_ItemClick);
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
            // rpAcciones
            // 
            this.rpAcciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpAcciones.Name = "rpAcciones";
            this.rpAcciones.Text = "ribbonPage1";
            this.rpAcciones.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalida);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtOtroRecibo);
            this.lcMain.Controls.Add(this.txtOtro);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.lueRecibo);
            this.lcMain.Controls.Add(this.rgRecibo);
            this.lcMain.Controls.Add(this.rgDestino);
            this.lcMain.Controls.Add(this.rgTipoSalida);
            this.lcMain.Controls.Add(this.grdArticulos);
            this.lcMain.Controls.Add(this.txtCodigo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(143, 613, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 386);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "lcMain";
            // 
            // txtOtroRecibo
            // 
            this.txtOtroRecibo.EnterMoveNextControl = true;
            this.txtOtroRecibo.Location = new System.Drawing.Point(12, 354);
            this.txtOtroRecibo.MenuManager = this.ribbonControl1;
            this.txtOtroRecibo.Name = "txtOtroRecibo";
            this.txtOtroRecibo.Size = new System.Drawing.Size(776, 20);
            this.txtOtroRecibo.StyleController = this.lcMain;
            this.txtOtroRecibo.TabIndex = 13;
            // 
            // txtOtro
            // 
            this.txtOtro.EnterMoveNextControl = true;
            this.txtOtro.Location = new System.Drawing.Point(12, 268);
            this.txtOtro.MenuManager = this.ribbonControl1;
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(776, 20);
            this.txtOtro.StyleController = this.lcMain;
            this.txtOtro.TabIndex = 12;
            // 
            // lueUnidad
            // 
            this.lueUnidad.EnterMoveNextControl = true;
            this.lueUnidad.Location = new System.Drawing.Point(12, 244);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.NullText = "[Seleccione]";
            this.lueUnidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueUnidad.Properties.ValueMember = "Oid";
            this.lueUnidad.Size = new System.Drawing.Size(776, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 11;
            // 
            // lueRecibo
            // 
            this.lueRecibo.EnterMoveNextControl = true;
            this.lueRecibo.Location = new System.Drawing.Point(12, 330);
            this.lueRecibo.MenuManager = this.ribbonControl1;
            this.lueRecibo.Name = "lueRecibo";
            this.lueRecibo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRecibo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomCompleto", "Nombre")});
            this.lueRecibo.Properties.DisplayMember = "NomCompleto";
            this.lueRecibo.Properties.NullText = "[Seleccione]";
            this.lueRecibo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueRecibo.Properties.ValueMember = "Oid";
            this.lueRecibo.Size = new System.Drawing.Size(776, 20);
            this.lueRecibo.StyleController = this.lcMain;
            this.lueRecibo.TabIndex = 10;
            // 
            // rgRecibo
            // 
            this.rgRecibo.EditValue = "Empleado";
            this.rgRecibo.EnterMoveNextControl = true;
            this.rgRecibo.Location = new System.Drawing.Point(65, 292);
            this.rgRecibo.MenuManager = this.ribbonControl1;
            this.rgRecibo.Name = "rgRecibo";
            this.rgRecibo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Empleado", "Empleado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Otro", "Otro")});
            this.rgRecibo.Size = new System.Drawing.Size(723, 34);
            this.rgRecibo.StyleController = this.lcMain;
            this.rgRecibo.TabIndex = 9;
            this.rgRecibo.SelectedIndexChanged += new System.EventHandler(this.rgRecibo_SelectedIndexChanged);
            // 
            // rgDestino
            // 
            this.rgDestino.EditValue = "Unidad";
            this.rgDestino.EnterMoveNextControl = true;
            this.rgDestino.Location = new System.Drawing.Point(65, 206);
            this.rgDestino.MenuManager = this.ribbonControl1;
            this.rgDestino.Name = "rgDestino";
            this.rgDestino.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Unidad", "Unidad"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Otro", "Otro")});
            this.rgDestino.Size = new System.Drawing.Size(723, 34);
            this.rgDestino.StyleController = this.lcMain;
            this.rgDestino.TabIndex = 8;
            this.rgDestino.SelectedIndexChanged += new System.EventHandler(this.rgDestino_SelectedIndexChanged);
            // 
            // rgTipoSalida
            // 
            this.rgTipoSalida.EditValue = "Factura";
            this.rgTipoSalida.Location = new System.Drawing.Point(12, 12);
            this.rgTipoSalida.MenuManager = this.ribbonControl1;
            this.rgTipoSalida.Name = "rgTipoSalida";
            this.rgTipoSalida.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Factura", "Factura", true, "Factura"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Salida masiva", "Salida masiva")});
            this.rgTipoSalida.Size = new System.Drawing.Size(776, 34);
            this.rgTipoSalida.StyleController = this.lcMain;
            this.rgTipoSalida.TabIndex = 7;
            this.rgTipoSalida.SelectedIndexChanged += new System.EventHandler(this.rgTipoSalida_SelectedIndexChanged);
            // 
            // grdArticulos
            // 
            this.grdArticulos.Location = new System.Drawing.Point(12, 74);
            this.grdArticulos.MainView = this.grvArticulos;
            this.grdArticulos.MenuManager = this.ribbonControl1;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.Size = new System.Drawing.Size(776, 128);
            this.grdArticulos.TabIndex = 6;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvArticulos});
            // 
            // grvArticulos
            // 
            this.grvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colCantidad,
            this.colNombre,
            this.colTipoMedida,
            this.colPrecio,
            this.colProveedor,
            this.colAlmacen,
            this.colNumParte,
            this.colMarca});
            this.grvArticulos.GridControl = this.grdArticulos;
            this.grvArticulos.Name = "grvArticulos";
            this.grvArticulos.OptionsBehavior.Editable = false;
            this.grvArticulos.OptionsBehavior.ReadOnly = true;
            this.grvArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Articulo.Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.AllowFocus = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowFocus = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Articulo.Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colTipoMedida
            // 
            this.colTipoMedida.Caption = "Tipo medida";
            this.colTipoMedida.FieldName = "TipoMedida";
            this.colTipoMedida.Name = "colTipoMedida";
            this.colTipoMedida.OptionsColumn.AllowEdit = false;
            this.colTipoMedida.OptionsColumn.AllowFocus = false;
            this.colTipoMedida.Visible = true;
            this.colTipoMedida.VisibleIndex = 3;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.AllowFocus = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor.Nombre";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.OptionsColumn.AllowFocus = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 5;
            // 
            // colAlmacen
            // 
            this.colAlmacen.Caption = "Almacen";
            this.colAlmacen.FieldName = "Almacen";
            this.colAlmacen.Name = "colAlmacen";
            this.colAlmacen.OptionsColumn.AllowEdit = false;
            this.colAlmacen.OptionsColumn.AllowFocus = false;
            this.colAlmacen.Visible = true;
            this.colAlmacen.VisibleIndex = 6;
            // 
            // colNumParte
            // 
            this.colNumParte.Caption = "# Parte";
            this.colNumParte.FieldName = "NumParte";
            this.colNumParte.Name = "colNumParte";
            this.colNumParte.OptionsColumn.AllowEdit = false;
            this.colNumParte.OptionsColumn.AllowFocus = false;
            this.colNumParte.Visible = true;
            this.colNumParte.VisibleIndex = 7;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca.Nombre";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.AllowFocus = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 50);
            this.txtCodigo.MenuManager = this.ribbonControl1;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(723, 20);
            this.txtCodigo.StyleController = this.lcMain;
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFactura,
            this.lciArticulos,
            this.lciTipoSalida,
            this.lciDestino,
            this.lciRecibio,
            this.lciEmpleado,
            this.lciUnidad,
            this.lciOtro,
            this.lciOtroEmpleado});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 386);
            this.Root.TextVisible = false;
            // 
            // lciFactura
            // 
            this.lciFactura.Control = this.txtCodigo;
            this.lciFactura.Location = new System.Drawing.Point(0, 38);
            this.lciFactura.Name = "lciFactura";
            this.lciFactura.Size = new System.Drawing.Size(780, 24);
            this.lciFactura.Text = "Factura:";
            this.lciFactura.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciArticulos
            // 
            this.lciArticulos.Control = this.grdArticulos;
            this.lciArticulos.Location = new System.Drawing.Point(0, 62);
            this.lciArticulos.Name = "lciArticulos";
            this.lciArticulos.Size = new System.Drawing.Size(780, 132);
            this.lciArticulos.TextSize = new System.Drawing.Size(0, 0);
            this.lciArticulos.TextVisible = false;
            // 
            // lciTipoSalida
            // 
            this.lciTipoSalida.Control = this.rgTipoSalida;
            this.lciTipoSalida.Location = new System.Drawing.Point(0, 0);
            this.lciTipoSalida.MaxSize = new System.Drawing.Size(0, 38);
            this.lciTipoSalida.MinSize = new System.Drawing.Size(54, 38);
            this.lciTipoSalida.Name = "lciTipoSalida";
            this.lciTipoSalida.Size = new System.Drawing.Size(780, 38);
            this.lciTipoSalida.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoSalida.TextSize = new System.Drawing.Size(0, 0);
            this.lciTipoSalida.TextVisible = false;
            // 
            // lciDestino
            // 
            this.lciDestino.Control = this.rgDestino;
            this.lciDestino.Location = new System.Drawing.Point(0, 194);
            this.lciDestino.MaxSize = new System.Drawing.Size(0, 38);
            this.lciDestino.MinSize = new System.Drawing.Size(107, 38);
            this.lciDestino.Name = "lciDestino";
            this.lciDestino.Size = new System.Drawing.Size(780, 38);
            this.lciDestino.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDestino.Text = "Destino:";
            this.lciDestino.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciRecibio
            // 
            this.lciRecibio.Control = this.rgRecibo;
            this.lciRecibio.Location = new System.Drawing.Point(0, 280);
            this.lciRecibio.MaxSize = new System.Drawing.Size(0, 38);
            this.lciRecibio.MinSize = new System.Drawing.Size(107, 38);
            this.lciRecibio.Name = "lciRecibio";
            this.lciRecibio.Size = new System.Drawing.Size(780, 38);
            this.lciRecibio.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRecibio.Text = "Recibo:";
            this.lciRecibio.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.Control = this.lueRecibo;
            this.lciEmpleado.Location = new System.Drawing.Point(0, 318);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(780, 24);
            this.lciEmpleado.TextSize = new System.Drawing.Size(0, 0);
            this.lciEmpleado.TextVisible = false;
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 232);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(780, 24);
            this.lciUnidad.TextSize = new System.Drawing.Size(0, 0);
            this.lciUnidad.TextVisible = false;
            // 
            // lciOtro
            // 
            this.lciOtro.Control = this.txtOtro;
            this.lciOtro.Location = new System.Drawing.Point(0, 256);
            this.lciOtro.Name = "lciOtro";
            this.lciOtro.Size = new System.Drawing.Size(780, 24);
            this.lciOtro.TextSize = new System.Drawing.Size(0, 0);
            this.lciOtro.TextVisible = false;
            this.lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciOtroEmpleado
            // 
            this.lciOtroEmpleado.Control = this.txtOtroRecibo;
            this.lciOtroEmpleado.Location = new System.Drawing.Point(0, 342);
            this.lciOtroEmpleado.Name = "lciOtroEmpleado";
            this.lciOtroEmpleado.Size = new System.Drawing.Size(780, 24);
            this.lciOtroEmpleado.TextSize = new System.Drawing.Size(0, 0);
            this.lciOtroEmpleado.TextVisible = false;
            this.lciOtroEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // flpAccionesFactura
            // 
            this.flpAccionesFactura.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAccionesFactura.Appearance.Options.UseBackColor = true;
            this.flpAccionesFactura.Location = new System.Drawing.Point(12, 391);
            this.flpAccionesFactura.Name = "flpAccionesFactura";
            this.flpAccionesFactura.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.flpAccionesFactura.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAccionesFactura.OptionsBeakPanel.Opacity = 0.5D;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.flpAccionesFactura.OptionsButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.flpAccionesFactura.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.flpAccionesFactura.OptionsButtonPanel.ButtonPanelHeight = 80;
            this.flpAccionesFactura.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            this.flpAccionesFactura.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Nuevo artículo", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Eliminar artículo", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.flpAccionesFactura.OptionsButtonPanel.ShowButtonPanel = true;
            this.flpAccionesFactura.OwnerControl = this.grdArticulos;
            this.flpAccionesFactura.Padding = new System.Windows.Forms.Padding(0, 0, 0, 80);
            this.flpAccionesFactura.Size = new System.Drawing.Size(776, 38);
            this.flpAccionesFactura.TabIndex = 3;
            this.flpAccionesFactura.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flpAccionesFactura_ButtonClick);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.flpAccionesFactura;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1, 222);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // xfrmSalidaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.flpAccionesFactura);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmSalidaFactura.IconOptions.Icon")));
            this.Name = "xfrmSalidaFactura";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Salida de factura";
            this.Load += new System.EventHandler(this.xfrmSalidaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtroEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAccionesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAcciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvArticulos;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciFactura;
        private DevExpress.XtraLayout.LayoutControlItem lciArticulos;
        private DevExpress.XtraBars.BarButtonItem bbiSalida;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colAlmacen;
        private DevExpress.XtraGrid.Columns.GridColumn colNumParte;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraEditors.TextEdit txtOtro;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraEditors.LookUpEdit lueRecibo;
        private DevExpress.XtraEditors.RadioGroup rgRecibo;
        private DevExpress.XtraEditors.RadioGroup rgDestino;
        private DevExpress.XtraEditors.RadioGroup rgTipoSalida;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoSalida;
        private DevExpress.XtraLayout.LayoutControlItem lciDestino;
        private DevExpress.XtraLayout.LayoutControlItem lciRecibio;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciOtro;
        private DevExpress.Utils.FlyoutPanel flpAccionesFactura;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtOtroRecibo;
        private DevExpress.XtraLayout.LayoutControlItem lciOtroEmpleado;
    }
}