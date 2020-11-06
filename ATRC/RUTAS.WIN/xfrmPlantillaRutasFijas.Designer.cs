namespace RUTAS.WIN
{
    partial class xfrmPlantillaRutasFijas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPlantillaRutasFijas));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.grdRutasExtras = new DevExpress.XtraGrid.GridControl();
            this.grvRutasExtras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtraEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsApoyo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueMaquiladora = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMaquiladora = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.flpAcciones = new DevExpress.Utils.FlyoutPanel();
            this.Loading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::RUTAS.WIN.WaitForm1), true, true);
            this.chkEsExterno = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutasExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutasExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaquiladora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMaquiladora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsExterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1171, 132);
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
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.chkEsExterno);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Controls.Add(this.grdRutasExtras);
            this.lcMain.Controls.Add(this.lueMaquiladora);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1171, 427);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtNombre
            // 
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(77, 12);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(963, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 6;
            // 
            // grdRutasExtras
            // 
            this.grdRutasExtras.AllowDrop = true;
            gridLevelNode1.RelationName = "Level1";
            this.grdRutasExtras.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdRutasExtras.Location = new System.Drawing.Point(12, 60);
            this.grdRutasExtras.MainView = this.grvRutasExtras;
            this.grdRutasExtras.MenuManager = this.ribbonControl1;
            this.grdRutasExtras.Name = "grdRutasExtras";
            this.grdRutasExtras.Size = new System.Drawing.Size(1147, 313);
            this.grdRutasExtras.TabIndex = 5;
            this.grdRutasExtras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRutasExtras});
            this.grdRutasExtras.DragDrop += new System.Windows.Forms.DragEventHandler(this.grdRutasExtras_DragDrop);
            this.grdRutasExtras.DragOver += new System.Windows.Forms.DragEventHandler(this.grdRutasExtras_DragOver);
            // 
            // grvRutasExtras
            // 
            this.grvRutasExtras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuta,
            this.colTipoRuta,
            this.colServicio,
            this.colTurno,
            this.colHoraDe,
            this.colHoraA,
            this.colChoferEntrada,
            this.colEsExtraEntrada,
            this.colChoferSalida,
            this.colExtraSalida,
            this.colComentarios,
            this.colEsApoyo,
            this.colEsExtra});
            this.grvRutasExtras.GridControl = this.grdRutasExtras;
            this.grvRutasExtras.Name = "grvRutasExtras";
            this.grvRutasExtras.OptionsBehavior.Editable = false;
            this.grvRutasExtras.OptionsBehavior.ReadOnly = true;
            this.grvRutasExtras.OptionsDetail.EnableMasterViewMode = false;
            this.grvRutasExtras.OptionsDetail.ShowDetailTabs = false;
            this.grvRutasExtras.OptionsDetail.SmartDetailExpand = false;
            this.grvRutasExtras.OptionsView.AllowHtmlDrawGroups = false;
            this.grvRutasExtras.OptionsView.ShowDetailButtons = false;
            this.grvRutasExtras.OptionsView.ShowGroupPanel = false;
            this.grvRutasExtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvRutasExtras_MouseDown);
            this.grvRutasExtras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grvRutasExtras_MouseMove);
            // 
            // colRuta
            // 
            this.colRuta.Caption = "Ruta";
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.OptionsColumn.AllowEdit = false;
            this.colRuta.OptionsColumn.AllowFocus = false;
            this.colRuta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRuta.OptionsFilter.AllowFilter = false;
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 0;
            this.colRuta.Width = 76;
            // 
            // colTipoRuta
            // 
            this.colTipoRuta.Caption = "Tipo de ruta";
            this.colTipoRuta.FieldName = "TipoRuta";
            this.colTipoRuta.Name = "colTipoRuta";
            this.colTipoRuta.OptionsColumn.AllowEdit = false;
            this.colTipoRuta.OptionsColumn.AllowFocus = false;
            this.colTipoRuta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoRuta.OptionsFilter.AllowFilter = false;
            this.colTipoRuta.Visible = true;
            this.colTipoRuta.VisibleIndex = 1;
            this.colTipoRuta.Width = 66;
            // 
            // colServicio
            // 
            this.colServicio.Caption = "Tipo de unidad";
            this.colServicio.FieldName = "Servicio.TipoUnidad";
            this.colServicio.Name = "colServicio";
            this.colServicio.OptionsColumn.AllowEdit = false;
            this.colServicio.OptionsColumn.AllowFocus = false;
            this.colServicio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServicio.OptionsFilter.AllowFilter = false;
            this.colServicio.Visible = true;
            this.colServicio.VisibleIndex = 2;
            this.colServicio.Width = 62;
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.FieldName = "Turno.Descripcion";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowFocus = false;
            this.colTurno.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTurno.OptionsFilter.AllowFilter = false;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 3;
            this.colTurno.Width = 62;
            // 
            // colHoraDe
            // 
            this.colHoraDe.Caption = "Hora de";
            this.colHoraDe.DisplayFormat.FormatString = "t";
            this.colHoraDe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraDe.FieldName = "HoraEntrada";
            this.colHoraDe.GroupFormat.FormatString = "t";
            this.colHoraDe.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraDe.Name = "colHoraDe";
            this.colHoraDe.OptionsColumn.AllowEdit = false;
            this.colHoraDe.OptionsColumn.AllowFocus = false;
            this.colHoraDe.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHoraDe.OptionsFilter.AllowFilter = false;
            this.colHoraDe.Visible = true;
            this.colHoraDe.VisibleIndex = 4;
            this.colHoraDe.Width = 63;
            // 
            // colHoraA
            // 
            this.colHoraA.Caption = "A hora";
            this.colHoraA.DisplayFormat.FormatString = "t";
            this.colHoraA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraA.FieldName = "HoraSalida";
            this.colHoraA.Name = "colHoraA";
            this.colHoraA.OptionsColumn.AllowEdit = false;
            this.colHoraA.OptionsColumn.AllowFocus = false;
            this.colHoraA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHoraA.OptionsFilter.AllowFilter = false;
            this.colHoraA.Visible = true;
            this.colHoraA.VisibleIndex = 5;
            this.colHoraA.Width = 53;
            // 
            // colChoferEntrada
            // 
            this.colChoferEntrada.Caption = "Chofer de entrada";
            this.colChoferEntrada.FieldName = "ChoferEntrada.Nombre";
            this.colChoferEntrada.Name = "colChoferEntrada";
            this.colChoferEntrada.OptionsColumn.AllowEdit = false;
            this.colChoferEntrada.OptionsColumn.AllowFocus = false;
            this.colChoferEntrada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colChoferEntrada.OptionsFilter.AllowFilter = false;
            this.colChoferEntrada.Visible = true;
            this.colChoferEntrada.VisibleIndex = 6;
            this.colChoferEntrada.Width = 134;
            // 
            // colEsExtraEntrada
            // 
            this.colEsExtraEntrada.Caption = "Entrada extra";
            this.colEsExtraEntrada.FieldName = "PagarChoferEntrada";
            this.colEsExtraEntrada.Name = "colEsExtraEntrada";
            this.colEsExtraEntrada.OptionsColumn.AllowEdit = false;
            this.colEsExtraEntrada.OptionsColumn.AllowFocus = false;
            this.colEsExtraEntrada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEsExtraEntrada.OptionsFilter.AllowFilter = false;
            this.colEsExtraEntrada.Visible = true;
            this.colEsExtraEntrada.VisibleIndex = 7;
            this.colEsExtraEntrada.Width = 66;
            // 
            // colChoferSalida
            // 
            this.colChoferSalida.Caption = "Chofer de salida";
            this.colChoferSalida.FieldName = "ChoferSalida.Nombre";
            this.colChoferSalida.Name = "colChoferSalida";
            this.colChoferSalida.OptionsColumn.AllowEdit = false;
            this.colChoferSalida.OptionsColumn.AllowFocus = false;
            this.colChoferSalida.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colChoferSalida.OptionsFilter.AllowFilter = false;
            this.colChoferSalida.Visible = true;
            this.colChoferSalida.VisibleIndex = 8;
            this.colChoferSalida.Width = 134;
            // 
            // colExtraSalida
            // 
            this.colExtraSalida.Caption = "Salida Extra";
            this.colExtraSalida.FieldName = "PagarChoferSalida";
            this.colExtraSalida.Name = "colExtraSalida";
            this.colExtraSalida.OptionsColumn.AllowEdit = false;
            this.colExtraSalida.OptionsColumn.AllowFocus = false;
            this.colExtraSalida.OptionsColumn.AllowSize = false;
            this.colExtraSalida.OptionsFilter.AllowFilter = false;
            this.colExtraSalida.Visible = true;
            this.colExtraSalida.VisibleIndex = 9;
            this.colExtraSalida.Width = 62;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentarios";
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.OptionsColumn.AllowEdit = false;
            this.colComentarios.OptionsColumn.AllowFocus = false;
            this.colComentarios.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colComentarios.OptionsFilter.AllowFilter = false;
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 10;
            this.colComentarios.Width = 240;
            // 
            // colEsApoyo
            // 
            this.colEsApoyo.Caption = "Es apoyo";
            this.colEsApoyo.FieldName = "EsApoyo";
            this.colEsApoyo.Name = "colEsApoyo";
            this.colEsApoyo.OptionsColumn.AllowEdit = false;
            this.colEsApoyo.OptionsColumn.AllowFocus = false;
            this.colEsApoyo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEsApoyo.Visible = true;
            this.colEsApoyo.VisibleIndex = 11;
            this.colEsApoyo.Width = 53;
            // 
            // colEsExtra
            // 
            this.colEsExtra.Caption = "Es extra";
            this.colEsExtra.FieldName = "EsRutaExtra";
            this.colEsExtra.Name = "colEsExtra";
            this.colEsExtra.OptionsColumn.AllowEdit = false;
            this.colEsExtra.OptionsColumn.AllowFocus = false;
            this.colEsExtra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEsExtra.OptionsFilter.AllowFilter = false;
            this.colEsExtra.Visible = true;
            this.colEsExtra.VisibleIndex = 12;
            this.colEsExtra.Width = 51;
            // 
            // lueMaquiladora
            // 
            this.lueMaquiladora.EnterMoveNextControl = true;
            this.lueMaquiladora.Location = new System.Drawing.Point(77, 36);
            this.lueMaquiladora.MenuManager = this.ribbonControl1;
            this.lueMaquiladora.Name = "lueMaquiladora";
            this.lueMaquiladora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaquiladora.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueMaquiladora.Properties.DisplayMember = "Nombre";
            this.lueMaquiladora.Properties.NullText = "[Seleccioné]";
            this.lueMaquiladora.Properties.ValueMember = "Oid";
            this.lueMaquiladora.Size = new System.Drawing.Size(1082, 20);
            this.lueMaquiladora.StyleController = this.lcMain;
            this.lueMaquiladora.TabIndex = 4;
            this.lueMaquiladora.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lueMaquiladora_CustomDisplayText);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMaquiladora,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.lciNombre,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1171, 427);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciMaquiladora
            // 
            this.lciMaquiladora.Control = this.lueMaquiladora;
            this.lciMaquiladora.Location = new System.Drawing.Point(0, 24);
            this.lciMaquiladora.Name = "lciMaquiladora";
            this.lciMaquiladora.Size = new System.Drawing.Size(1151, 24);
            this.lciMaquiladora.Text = "Maquiladora:";
            this.lciMaquiladora.TextSize = new System.Drawing.Size(62, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 365);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 42);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 42);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1151, 42);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdRutasExtras;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1151, 317);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(0, 0);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(1032, 24);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextSize = new System.Drawing.Size(62, 13);
            // 
            // flpAcciones
            // 
            this.flpAcciones.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAcciones.Appearance.ForeColor = System.Drawing.Color.White;
            this.flpAcciones.Appearance.Options.UseBackColor = true;
            this.flpAcciones.Appearance.Options.UseForeColor = true;
            this.flpAcciones.Location = new System.Drawing.Point(12, 404);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.flpAcciones.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAcciones.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom;
            this.flpAcciones.OptionsBeakPanel.Opacity = 0.5D;
            this.flpAcciones.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.flpAcciones.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelHeight = 45;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = global::RUTAS.WIN.Properties.Resources.AgregarRuta;
            buttonImageOptions2.Image = global::RUTAS.WIN.Properties.Resources.ModificarRuta;
            buttonImageOptions3.Image = global::RUTAS.WIN.Properties.Resources.EliminarRuta;
            this.flpAcciones.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Agregar ruta", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Modificar ruta", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Eliminar ruta", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.flpAcciones.OptionsButtonPanel.ShowButtonPanel = true;
            this.flpAcciones.OwnerControl = this;
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.flpAcciones.Size = new System.Drawing.Size(418, 44);
            this.flpAcciones.TabIndex = 3;
            this.flpAcciones.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flpAcciones_ButtonClick);
            // 
            // Loading
            // 
            this.Loading.ClosingDelay = 500;
            // 
            // chkEsExterno
            // 
            this.chkEsExterno.Location = new System.Drawing.Point(1044, 12);
            this.chkEsExterno.MenuManager = this.ribbonControl1;
            this.chkEsExterno.Name = "chkEsExterno";
            this.chkEsExterno.Properties.Caption = "Mostrar a externos";
            this.chkEsExterno.Size = new System.Drawing.Size(115, 20);
            this.chkEsExterno.StyleController = this.lcMain;
            this.chkEsExterno.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkEsExterno;
            this.layoutControlItem1.Location = new System.Drawing.Point(1032, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(119, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmPlantillaRutasFijas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 559);
            this.Controls.Add(this.flpAcciones);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPlantillaRutasFijas.IconOptions.Icon")));
            this.Name = "xfrmPlantillaRutasFijas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Plantilla de rutas";
            this.Load += new System.EventHandler(this.xfrmPlantillaRutasExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutasExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutasExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaquiladora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMaquiladora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsExterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdRutasExtras;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRutasExtras;
        private DevExpress.XtraEditors.LookUpEdit lueMaquiladora;
        private DevExpress.XtraLayout.LayoutControlItem lciMaquiladora;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.FlyoutPanel flpAcciones;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraDe;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraA;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtraEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colExtraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraSplashScreen.SplashScreenManager Loading;
        private DevExpress.XtraGrid.Columns.GridColumn colServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colEsApoyo;
        private DevExpress.XtraEditors.CheckEdit chkEsExterno;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}