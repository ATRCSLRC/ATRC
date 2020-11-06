namespace ALMACEN.WIN.Articulos
{
    partial class xfrmPrestamoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPrestamoArticulo));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.rpAcciones = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lblUsuario = new DevExpress.XtraEditors.TextEdit();
            this.grdEntregasArticulos = new DevExpress.XtraGrid.GridControl();
            this.grvEntregasArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticuloEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.grvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnArticulo = new DevExpress.XtraEditors.ButtonEdit();
            this.btnUsuario = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgPrestar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciArticulo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgEntregar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.fypEdicion = new DevExpress.Utils.FlyoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregasArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntregasArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEntregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fypEdicion)).BeginInit();
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
            this.rpAcciones});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(541, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.Image")));
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.Image")));
            this.bbiCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // rpAcciones
            // 
            this.rpAcciones.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAcciones});
            this.rpAcciones.Name = "rpAcciones";
            this.rpAcciones.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lblUsuario);
            this.lcMain.Controls.Add(this.grdEntregasArticulos);
            this.lcMain.Controls.Add(this.grdArticulos);
            this.lcMain.Controls.Add(this.btnArticulo);
            this.lcMain.Controls.Add(this.btnUsuario);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(297, 441, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(541, 361);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(196, 12);
            this.lblUsuario.MenuManager = this.ribbonControl1;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Properties.Appearance.Options.UseFont = true;
            this.lblUsuario.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lblUsuario.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.lblUsuario.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUsuario.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblUsuario.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lblUsuario.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.lblUsuario.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUsuario.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblUsuario.Properties.ReadOnly = true;
            this.lblUsuario.Size = new System.Drawing.Size(333, 22);
            this.lblUsuario.StyleController = this.lcMain;
            this.lblUsuario.TabIndex = 8;
            // 
            // grdEntregasArticulos
            // 
            this.grdEntregasArticulos.Location = new System.Drawing.Point(24, 74);
            this.grdEntregasArticulos.MainView = this.grvEntregasArticulos;
            this.grdEntregasArticulos.MenuManager = this.ribbonControl1;
            this.grdEntregasArticulos.Name = "grdEntregasArticulos";
            this.grdEntregasArticulos.Size = new System.Drawing.Size(493, 263);
            this.grdEntregasArticulos.TabIndex = 7;
            this.grdEntregasArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEntregasArticulos});
            // 
            // grvEntregasArticulos
            // 
            this.grvEntregasArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaEntrega,
            this.colArticuloEntrega});
            this.grvEntregasArticulos.GridControl = this.grdEntregasArticulos;
            this.grvEntregasArticulos.Name = "grvEntregasArticulos";
            this.grvEntregasArticulos.OptionsSelection.MultiSelect = true;
            this.grvEntregasArticulos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvEntregasArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.Caption = "Fecha";
            this.colFechaEntrega.FieldName = "Fecha";
            this.colFechaEntrega.Name = "colFechaEntrega";
            this.colFechaEntrega.OptionsColumn.AllowEdit = false;
            this.colFechaEntrega.OptionsColumn.ReadOnly = true;
            this.colFechaEntrega.Visible = true;
            this.colFechaEntrega.VisibleIndex = 1;
            // 
            // colArticuloEntrega
            // 
            this.colArticuloEntrega.Caption = "Artículo";
            this.colArticuloEntrega.FieldName = "Articulo.Nombre";
            this.colArticuloEntrega.Name = "colArticuloEntrega";
            this.colArticuloEntrega.OptionsColumn.AllowEdit = false;
            this.colArticuloEntrega.Visible = true;
            this.colArticuloEntrega.VisibleIndex = 2;
            // 
            // grdArticulos
            // 
            this.grdArticulos.Location = new System.Drawing.Point(24, 100);
            this.grdArticulos.MainView = this.grvArticulos;
            this.grdArticulos.MenuManager = this.ribbonControl1;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.Size = new System.Drawing.Size(493, 237);
            this.grdArticulos.TabIndex = 6;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvArticulos});
            // 
            // grvArticulos
            // 
            this.grvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticulo,
            this.colFecha});
            this.grvArticulos.GridControl = this.grdArticulos;
            this.grvArticulos.Name = "grvArticulos";
            this.grvArticulos.OptionsBehavior.Editable = false;
            this.grvArticulos.OptionsBehavior.ReadOnly = true;
            this.grvArticulos.OptionsDetail.EnableMasterViewMode = false;
            this.grvArticulos.OptionsDetail.ShowDetailTabs = false;
            this.grvArticulos.OptionsDetail.SmartDetailExpand = false;
            this.grvArticulos.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grvArticulos.OptionsView.ShowGroupPanel = false;
            this.grvArticulos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvArticulos_RowClick);
            // 
            // colArticulo
            // 
            this.colArticulo.Caption = "Artículo";
            this.colArticulo.FieldName = "Articulo.Nombre";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.OptionsColumn.AllowEdit = false;
            this.colArticulo.OptionsColumn.AllowFocus = false;
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.DisplayFormat.FormatString = "g";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(83, 74);
            this.btnArticulo.MenuManager = this.ribbonControl1;
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.btnArticulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.Properties.Appearance.Options.UseFont = true;
            this.btnArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnArticulo.Properties.DisplayFormat.FormatString = "d";
            this.btnArticulo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnArticulo.Properties.EditFormat.FormatString = "d";
            this.btnArticulo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnArticulo.Properties.Mask.EditMask = "d";
            this.btnArticulo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnArticulo.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.NullValue;
            this.btnArticulo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnArticulo_Properties_ButtonClick);
            this.btnArticulo.Size = new System.Drawing.Size(434, 22);
            this.btnArticulo.StyleController = this.lcMain;
            this.btnArticulo.TabIndex = 5;
            this.btnArticulo.ToolTip = "Presione F2 para busqueda avanzada";
            this.btnArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnArticulo_KeyDown);
            this.btnArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnArticulo_KeyPress);
            // 
            // btnUsuario
            // 
            this.btnUsuario.EnterMoveNextControl = true;
            this.btnUsuario.Location = new System.Drawing.Point(80, 12);
            this.btnUsuario.MenuManager = this.ribbonControl1;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.btnUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Properties.Appearance.Options.UseFont = true;
            this.btnUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnUsuario.Properties.DisplayFormat.FormatString = "d";
            this.btnUsuario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnUsuario.Properties.EditFormat.FormatString = "d";
            this.btnUsuario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnUsuario.Properties.Mask.EditMask = "d";
            this.btnUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnUsuario.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.NullValue;
            this.btnUsuario.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnUsuario_Properties_ButtonClick);
            this.btnUsuario.Size = new System.Drawing.Size(112, 22);
            this.btnUsuario.StyleController = this.lcMain;
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.ToolTip = "Presione F2 para busqueda avanzada";
            this.btnUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUsuario_KeyDown);
            this.btnUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnUsuario_KeyPress);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUsuario,
            this.tabbedControlGroup1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(541, 361);
            this.Root.TextVisible = false;
            // 
            // lciUsuario
            // 
            this.lciUsuario.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciUsuario.AppearanceItemCaption.Options.UseFont = true;
            this.lciUsuario.Control = this.btnUsuario;
            this.lciUsuario.Location = new System.Drawing.Point(0, 0);
            this.lciUsuario.Name = "lciUsuario";
            this.lciUsuario.Size = new System.Drawing.Size(184, 26);
            this.lciUsuario.Text = "Usuario:";
            this.lciUsuario.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciUsuario.TextSize = new System.Drawing.Size(63, 18);
            this.lciUsuario.TextToControlDistance = 5;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 26);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.lcgPrestar;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(521, 315);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgPrestar,
            this.lcgEntregar});
            // 
            // lcgPrestar
            // 
            this.lcgPrestar.AppearanceTabPage.Header.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgPrestar.AppearanceTabPage.Header.Options.UseFont = true;
            this.lcgPrestar.Enabled = false;
            this.lcgPrestar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.lciArticulo});
            this.lcgPrestar.Location = new System.Drawing.Point(0, 0);
            this.lcgPrestar.Name = "lcgPrestar";
            this.lcgPrestar.Size = new System.Drawing.Size(497, 267);
            this.lcgPrestar.Text = "Prestar artículos";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdArticulos;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(497, 241);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lciArticulo
            // 
            this.lciArticulo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciArticulo.AppearanceItemCaption.Options.UseFont = true;
            this.lciArticulo.Control = this.btnArticulo;
            this.lciArticulo.Location = new System.Drawing.Point(0, 0);
            this.lciArticulo.Name = "lciArticulo";
            this.lciArticulo.Size = new System.Drawing.Size(497, 26);
            this.lciArticulo.Text = "Artículo:";
            this.lciArticulo.TextSize = new System.Drawing.Size(56, 16);
            // 
            // lcgEntregar
            // 
            this.lcgEntregar.AppearanceTabPage.Header.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgEntregar.AppearanceTabPage.Header.Options.UseFont = true;
            this.lcgEntregar.Enabled = false;
            this.lcgEntregar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgEntregar.Location = new System.Drawing.Point(0, 0);
            this.lcgEntregar.Name = "lcgEntregar";
            this.lcgEntregar.Size = new System.Drawing.Size(497, 267);
            this.lcgEntregar.Text = "Entregar artículos";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdEntregasArticulos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(497, 267);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lblUsuario;
            this.layoutControlItem2.Enabled = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(184, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(337, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // fypEdicion
            // 
            this.fypEdicion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.Appearance.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.Appearance.Options.UseBackColor = true;
            this.fypEdicion.Appearance.Options.UseForeColor = true;
            this.fypEdicion.Location = new System.Drawing.Point(12, 441);
            this.fypEdicion.Name = "fypEdicion";
            this.fypEdicion.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.fypEdicion.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom;
            this.fypEdicion.OptionsBeakPanel.Opacity = 0.5D;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopRight;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelHeight = 10;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            this.fypEdicion.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Eliminar", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, true),
            new DevExpress.Utils.PeekFormButton("Cerrar", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.fypEdicion.OptionsButtonPanel.ShowButtonPanel = true;
            this.fypEdicion.OwnerControl = this.grdArticulos;
            this.fypEdicion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fypEdicion.Size = new System.Drawing.Size(490, 40);
            this.fypEdicion.TabIndex = 4;
            this.fypEdicion.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.fypEdicion_ButtonClick);
            // 
            // xfrmPrestamoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 493);
            this.Controls.Add(this.fypEdicion);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPrestamoArticulo.IconOptions.Icon")));
            this.Name = "xfrmPrestamoArticulo";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Préstamo de artículos";
            this.Load += new System.EventHandler(this.xfrmPrestamoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregasArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntregasArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPrestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEntregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fypEdicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAcciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.ButtonEdit btnUsuario;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciUsuario;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvArticulos;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraEditors.ButtonEdit btnArticulo;
        private DevExpress.XtraLayout.LayoutControlItem lciArticulo;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPrestar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup lcgEntregar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraGrid.GridControl grdEntregasArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEntregasArticulos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colArticuloEntrega;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.FlyoutPanel fypEdicion;
        private DevExpress.XtraEditors.TextEdit lblUsuario;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}