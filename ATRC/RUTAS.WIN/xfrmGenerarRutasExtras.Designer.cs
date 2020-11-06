namespace RUTAS.WIN
{
    partial class xfrmGenerarRutasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmGenerarRutasExtras));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions6 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.grdRutas = new DevExpress.XtraGrid.GridControl();
            this.grvRutas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraEntrda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagarChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagarChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.flpAcciones = new DevExpress.Utils.FlyoutPanel();
            this.Loading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::RUTAS.WIN.WaitForm1), true, true);
            this.ofdDocumento = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.colEsApoyo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAcciones)).BeginInit();
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
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1184, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.LargeImage")));
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancelar.ImageOptions.LargeImage")));
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Controls.Add(this.grdRutas);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(890, 368, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1184, 582);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(91, 36);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Properties.DisplayMember = "Nombre";
            this.lueEmpresa.Properties.ValueMember = "Oid";
            this.lueEmpresa.Size = new System.Drawing.Size(1081, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 6;
            this.lueEmpresa.EditValueChanged += new System.EventHandler(this.lueEmpresa_EditValueChanged);
            this.lueEmpresa.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lueEmpresa_CustomDisplayText);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(91, 12);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Size = new System.Drawing.Size(1081, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 5;
            this.dteFecha.EditValueChanged += new System.EventHandler(this.dteFecha_EditValueChanged);
            // 
            // grdRutas
            // 
            this.grdRutas.AllowDrop = true;
            this.grdRutas.Location = new System.Drawing.Point(12, 60);
            this.grdRutas.MainView = this.grvRutas;
            this.grdRutas.MenuManager = this.ribbonControl1;
            this.grdRutas.Name = "grdRutas";
            this.grdRutas.Size = new System.Drawing.Size(1160, 462);
            this.grdRutas.TabIndex = 4;
            this.grdRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRutas});
            this.grdRutas.DragDrop += new System.Windows.Forms.DragEventHandler(this.grdRutas_DragDrop);
            this.grdRutas.DragOver += new System.Windows.Forms.DragEventHandler(this.grdRutas_DragOver);
            // 
            // grvRutas
            // 
            this.grvRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuta,
            this.colTipoRuta,
            this.colTipoUnidad,
            this.colTurno,
            this.colHoraEntrda,
            this.colHoraSalida,
            this.colChoferEntrada,
            this.colPagarChoferEntrada,
            this.colChoferSalida,
            this.colPagarChoferSalida,
            this.colComentarios,
            this.colEsApoyo,
            this.colEsExtra});
            this.grvRutas.GridControl = this.grdRutas;
            this.grvRutas.Name = "grvRutas";
            this.grvRutas.OptionsDetail.ShowDetailTabs = false;
            this.grvRutas.OptionsFind.AlwaysVisible = true;
            this.grvRutas.OptionsView.ShowDetailButtons = false;
            this.grvRutas.OptionsView.ShowGroupPanel = false;
            this.grvRutas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvRutas_MouseDown);
            this.grvRutas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grvRutas_MouseMove);
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
            this.colRuta.Width = 61;
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
            this.colTipoRuta.Width = 63;
            // 
            // colTipoUnidad
            // 
            this.colTipoUnidad.Caption = "Tipo de unidad";
            this.colTipoUnidad.FieldName = "Servicio.TipoUnidad";
            this.colTipoUnidad.Name = "colTipoUnidad";
            this.colTipoUnidad.OptionsColumn.AllowEdit = false;
            this.colTipoUnidad.OptionsColumn.AllowFocus = false;
            this.colTipoUnidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoUnidad.OptionsFilter.AllowFilter = false;
            this.colTipoUnidad.Visible = true;
            this.colTipoUnidad.VisibleIndex = 2;
            this.colTipoUnidad.Width = 72;
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
            this.colTurno.Width = 66;
            // 
            // colHoraEntrda
            // 
            this.colHoraEntrda.Caption = "Hora de entrada";
            this.colHoraEntrda.DisplayFormat.FormatString = "t";
            this.colHoraEntrda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraEntrda.FieldName = "HoraEntrada";
            this.colHoraEntrda.Name = "colHoraEntrda";
            this.colHoraEntrda.OptionsColumn.AllowEdit = false;
            this.colHoraEntrda.OptionsColumn.AllowFocus = false;
            this.colHoraEntrda.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHoraEntrda.OptionsFilter.AllowFilter = false;
            this.colHoraEntrda.Visible = true;
            this.colHoraEntrda.VisibleIndex = 4;
            this.colHoraEntrda.Width = 77;
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.Caption = "Hora de salida";
            this.colHoraSalida.DisplayFormat.FormatString = "t";
            this.colHoraSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraSalida.FieldName = "HoraSalida";
            this.colHoraSalida.Name = "colHoraSalida";
            this.colHoraSalida.OptionsColumn.AllowEdit = false;
            this.colHoraSalida.OptionsColumn.AllowFocus = false;
            this.colHoraSalida.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHoraSalida.OptionsFilter.AllowFilter = false;
            this.colHoraSalida.Visible = true;
            this.colHoraSalida.VisibleIndex = 5;
            this.colHoraSalida.Width = 70;
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
            this.colChoferEntrada.Width = 143;
            // 
            // colPagarChoferEntrada
            // 
            this.colPagarChoferEntrada.Caption = "Entrada extra";
            this.colPagarChoferEntrada.FieldName = "PagarChoferEntrada";
            this.colPagarChoferEntrada.Name = "colPagarChoferEntrada";
            this.colPagarChoferEntrada.OptionsColumn.AllowEdit = false;
            this.colPagarChoferEntrada.OptionsColumn.AllowFocus = false;
            this.colPagarChoferEntrada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPagarChoferEntrada.OptionsFilter.AllowFilter = false;
            this.colPagarChoferEntrada.Visible = true;
            this.colPagarChoferEntrada.VisibleIndex = 7;
            this.colPagarChoferEntrada.Width = 66;
            // 
            // colChoferSalida
            // 
            this.colChoferSalida.Caption = "Chofer de salida";
            this.colChoferSalida.FieldName = "ChoferSalida.Nombre";
            this.colChoferSalida.Name = "colChoferSalida";
            this.colChoferSalida.OptionsColumn.AllowEdit = false;
            this.colChoferSalida.OptionsColumn.AllowFocus = false;
            this.colChoferSalida.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colChoferSalida.OptionsFilter.AllowFilter = false;
            this.colChoferSalida.Visible = true;
            this.colChoferSalida.VisibleIndex = 8;
            this.colChoferSalida.Width = 162;
            // 
            // colPagarChoferSalida
            // 
            this.colPagarChoferSalida.Caption = "Salida extra";
            this.colPagarChoferSalida.FieldName = "PagarChoferSalida";
            this.colPagarChoferSalida.Name = "colPagarChoferSalida";
            this.colPagarChoferSalida.OptionsColumn.AllowEdit = false;
            this.colPagarChoferSalida.OptionsColumn.AllowFocus = false;
            this.colPagarChoferSalida.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPagarChoferSalida.OptionsFilter.AllowFilter = false;
            this.colPagarChoferSalida.Visible = true;
            this.colPagarChoferSalida.VisibleIndex = 9;
            this.colPagarChoferSalida.Width = 66;
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
            this.colComentarios.Width = 189;
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
            this.colEsExtra.Width = 48;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.lciFecha,
            this.lciEmpresa});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1184, 582);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdRutas;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1164, 466);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 514);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1164, 48);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(1164, 24);
            this.lciFecha.Text = "Fecha de rutas:";
            this.lciFecha.TextSize = new System.Drawing.Size(76, 13);
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(0, 24);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(1164, 24);
            this.lciEmpresa.Text = "Empresa:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(76, 13);
            // 
            // flpAcciones
            // 
            this.flpAcciones.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAcciones.Appearance.ForeColor = System.Drawing.Color.White;
            this.flpAcciones.Appearance.Options.UseBackColor = true;
            this.flpAcciones.Appearance.Options.UseForeColor = true;
            this.flpAcciones.Location = new System.Drawing.Point(49, 569);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.flpAcciones.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flpAcciones.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom;
            this.flpAcciones.OptionsBeakPanel.Opacity = 0.5D;
            this.flpAcciones.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.flpAcciones.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelHeight = 40;
            this.flpAcciones.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = global::RUTAS.WIN.Properties.Resources.icons8_prioridad_media_34;
            buttonImageOptions2.Image = global::RUTAS.WIN.Properties.Resources.AgregarRuta;
            buttonImageOptions3.Image = global::RUTAS.WIN.Properties.Resources.ModificarRuta;
            buttonImageOptions4.Image = global::RUTAS.WIN.Properties.Resources.EliminarRuta;
            buttonImageOptions5.Image = global::RUTAS.WIN.Properties.Resources.icons8_cancelar_32;
            buttonImageOptions6.Image = global::RUTAS.WIN.Properties.Resources.icons8_ruta_32;
            this.flpAcciones.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Plantillas de rutas", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Ruta nueva", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Modificar ruta", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Eliminar ruta", true, buttonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Cancelar", true, buttonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, false, null, -1, false),
            new DevExpress.Utils.PeekFormButton("Historial ruta", true, buttonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.flpAcciones.OptionsButtonPanel.ShowButtonPanel = true;
            this.flpAcciones.OwnerControl = this;
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.flpAcciones.Size = new System.Drawing.Size(690, 43);
            this.flpAcciones.TabIndex = 4;
            this.flpAcciones.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flpAcciones_ButtonClick);
            // 
            // Loading
            // 
            this.Loading.ClosingDelay = 500;
            // 
            // ofdDocumento
            // 
            this.ofdDocumento.FileName = "xtraOpenFileDialog1";
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
            this.colEsApoyo.Width = 52;
            // 
            // xfrmGenerarRutasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 614);
            this.Controls.Add(this.flpAcciones);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmGenerarRutasExtras.IconOptions.Icon")));
            this.Name = "xfrmGenerarRutasExtras";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Crear rutas extras";
            this.Load += new System.EventHandler(this.xfrmGenerarRutasExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flpAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdRutas;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRutas;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.FlyoutPanel flpAcciones;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraEntrda;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colPagarChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colPagarChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraSplashScreen.SplashScreenManager Loading;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofdDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colEsApoyo;
    }
}