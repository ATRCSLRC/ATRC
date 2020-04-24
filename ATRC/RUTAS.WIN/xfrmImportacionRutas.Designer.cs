namespace RUTAS.WIN
{
    partial class xfrmImportacionRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmImportacionRutas));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImportar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.chkRutasExtras = new DevExpress.XtraEditors.CheckEdit();
            this.lueEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.grdRutas = new DevExpress.XtraGrid.GridControl();
            this.grvRutas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueServicios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueTurno = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colHoraEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colHoraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueChoferEntrada = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEntradaExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueChoferSalida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSalidaExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpresa = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ofdDocumento = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRutasExtras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoferEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoferSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiImportar,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1184, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiImportar
            // 
            this.bbiImportar.Caption = "Importar rutas";
            this.bbiImportar.Id = 1;
            this.bbiImportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImportar.ImageOptions.Image")));
            this.bbiImportar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImportar.ImageOptions.LargeImage")));
            this.bbiImportar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.bbiImportar.Name = "bbiImportar";
            this.bbiImportar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportar_ItemClick);
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.LargeImage")));
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 3;
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImportar, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.chkRutasExtras);
            this.lcMain.Controls.Add(this.lueEmpresa);
            this.lcMain.Controls.Add(this.grdRutas);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(736, 276, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1184, 413);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // chkRutasExtras
            // 
            this.chkRutasExtras.Location = new System.Drawing.Point(1074, 12);
            this.chkRutasExtras.MenuManager = this.ribbonControl1;
            this.chkRutasExtras.Name = "chkRutasExtras";
            this.chkRutasExtras.Properties.Caption = "Rutas extras";
            this.chkRutasExtras.Size = new System.Drawing.Size(98, 19);
            this.chkRutasExtras.StyleController = this.lcMain;
            this.chkRutasExtras.TabIndex = 6;
            // 
            // lueEmpresa
            // 
            this.lueEmpresa.Location = new System.Drawing.Point(60, 35);
            this.lueEmpresa.MenuManager = this.ribbonControl1;
            this.lueEmpresa.Name = "lueEmpresa";
            this.lueEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpresa.Size = new System.Drawing.Size(1112, 20);
            this.lueEmpresa.StyleController = this.lcMain;
            this.lueEmpresa.TabIndex = 5;
            this.lueEmpresa.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lookUpEdit1_CustomDisplayText);
            // 
            // grdRutas
            // 
            this.grdRutas.Location = new System.Drawing.Point(12, 59);
            this.grdRutas.MainView = this.grvRutas;
            this.grdRutas.MenuManager = this.ribbonControl1;
            this.grdRutas.Name = "grdRutas";
            this.grdRutas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueChoferEntrada,
            this.lueChoferSalida,
            this.lueTurno,
            this.lueServicios,
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeEdit2,
            this.repositoryItemMemoExEdit1});
            this.grdRutas.Size = new System.Drawing.Size(1160, 342);
            this.grdRutas.TabIndex = 4;
            this.grdRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRutas});
            // 
            // grvRutas
            // 
            this.grvRutas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colRuta,
            this.colTipoRuta,
            this.colTipoUnidad,
            this.colTurno,
            this.colHoraEntrada,
            this.colHoraSalida,
            this.colChoferEntrada,
            this.colEntradaExtra,
            this.colChoferSalida,
            this.colSalidaExtra,
            this.colComentarios,
            this.colEsExtra});
            this.grvRutas.GridControl = this.grdRutas;
            this.grvRutas.Name = "grvRutas";
            this.grvRutas.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "FechaRuta";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 87;
            // 
            // colRuta
            // 
            this.colRuta.Caption = "Ruta";
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 1;
            this.colRuta.Width = 79;
            // 
            // colTipoRuta
            // 
            this.colTipoRuta.Caption = "Tipo de ruta";
            this.colTipoRuta.FieldName = "TipoRuta";
            this.colTipoRuta.Name = "colTipoRuta";
            this.colTipoRuta.Visible = true;
            this.colTipoRuta.VisibleIndex = 2;
            this.colTipoRuta.Width = 68;
            // 
            // colTipoUnidad
            // 
            this.colTipoUnidad.Caption = "Servicio";
            this.colTipoUnidad.ColumnEdit = this.lueServicios;
            this.colTipoUnidad.FieldName = "Servicio!Key";
            this.colTipoUnidad.Name = "colTipoUnidad";
            this.colTipoUnidad.Visible = true;
            this.colTipoUnidad.VisibleIndex = 3;
            this.colTipoUnidad.Width = 145;
            // 
            // lueServicios
            // 
            this.lueServicios.AutoHeight = false;
            this.lueServicios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueServicios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre")});
            this.lueServicios.DisplayMember = "Descripcion";
            this.lueServicios.Name = "lueServicios";
            this.lueServicios.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueServicios.ValueMember = "Oid";
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.ColumnEdit = this.lueTurno;
            this.colTurno.FieldName = "Turno!Key";
            this.colTurno.Name = "colTurno";
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 4;
            this.colTurno.Width = 63;
            // 
            // lueTurno
            // 
            this.lueTurno.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueTurno.AutoHeight = false;
            this.lueTurno.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTurno.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre")});
            this.lueTurno.DisplayMember = "Descripcion";
            this.lueTurno.Name = "lueTurno";
            this.lueTurno.ValueMember = "Oid";
            // 
            // colHoraEntrada
            // 
            this.colHoraEntrada.Caption = "Hora de entrada";
            this.colHoraEntrada.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colHoraEntrada.DisplayFormat.FormatString = "t";
            this.colHoraEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraEntrada.FieldName = "HoraEntrada";
            this.colHoraEntrada.Name = "colHoraEntrada";
            this.colHoraEntrada.Visible = true;
            this.colHoraEntrada.VisibleIndex = 5;
            this.colHoraEntrada.Width = 71;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.Caption = "Hora de salida";
            this.colHoraSalida.ColumnEdit = this.repositoryItemTimeEdit2;
            this.colHoraSalida.DisplayFormat.FormatString = "t";
            this.colHoraSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraSalida.FieldName = "HoraSalida";
            this.colHoraSalida.Name = "colHoraSalida";
            this.colHoraSalida.Visible = true;
            this.colHoraSalida.VisibleIndex = 6;
            this.colHoraSalida.Width = 70;
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AutoHeight = false;
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // colChoferEntrada
            // 
            this.colChoferEntrada.Caption = "Chofer de entrada";
            this.colChoferEntrada.ColumnEdit = this.lueChoferEntrada;
            this.colChoferEntrada.FieldName = "ChoferEntrada!Key";
            this.colChoferEntrada.Name = "colChoferEntrada";
            this.colChoferEntrada.Visible = true;
            this.colChoferEntrada.VisibleIndex = 7;
            this.colChoferEntrada.Width = 150;
            // 
            // lueChoferEntrada
            // 
            this.lueChoferEntrada.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueChoferEntrada.AutoHeight = false;
            this.lueChoferEntrada.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueChoferEntrada.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "ID", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumEmpleado", "Número de empleado", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueChoferEntrada.DisplayMember = "Nombre";
            this.lueChoferEntrada.Name = "lueChoferEntrada";
            this.lueChoferEntrada.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueChoferEntrada.ValueMember = "Oid";
            // 
            // colEntradaExtra
            // 
            this.colEntradaExtra.Caption = "Entrada extra";
            this.colEntradaExtra.FieldName = "PagarChoferEntrada";
            this.colEntradaExtra.Name = "colEntradaExtra";
            this.colEntradaExtra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.colEntradaExtra.Visible = true;
            this.colEntradaExtra.VisibleIndex = 8;
            this.colEntradaExtra.Width = 58;
            // 
            // colChoferSalida
            // 
            this.colChoferSalida.Caption = "Chofer de salida";
            this.colChoferSalida.ColumnEdit = this.lueChoferSalida;
            this.colChoferSalida.FieldName = "ChoferSalida!Key";
            this.colChoferSalida.Name = "colChoferSalida";
            this.colChoferSalida.Visible = true;
            this.colChoferSalida.VisibleIndex = 9;
            this.colChoferSalida.Width = 145;
            // 
            // lueChoferSalida
            // 
            this.lueChoferSalida.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueChoferSalida.AutoHeight = false;
            this.lueChoferSalida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueChoferSalida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "ID", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumEmpleado", "Número de empleado", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueChoferSalida.DisplayMember = "Nombre";
            this.lueChoferSalida.Name = "lueChoferSalida";
            this.lueChoferSalida.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueChoferSalida.ValueMember = "Oid";
            // 
            // colSalidaExtra
            // 
            this.colSalidaExtra.Caption = "Salida extra";
            this.colSalidaExtra.FieldName = "PagarChoferSalida";
            this.colSalidaExtra.Name = "colSalidaExtra";
            this.colSalidaExtra.Visible = true;
            this.colSalidaExtra.VisibleIndex = 10;
            this.colSalidaExtra.Width = 58;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentarios";
            this.colComentarios.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 11;
            this.colComentarios.Width = 96;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colEsExtra
            // 
            this.colEsExtra.Caption = "Es extra";
            this.colEsExtra.FieldName = "EsRutaExtra";
            this.colEsExtra.Name = "colEsExtra";
            this.colEsExtra.Visible = true;
            this.colEsExtra.VisibleIndex = 12;
            this.colEsExtra.Width = 52;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciEmpresa,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1184, 413);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdRutas;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1164, 346);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciEmpresa
            // 
            this.lciEmpresa.Control = this.lueEmpresa;
            this.lciEmpresa.Location = new System.Drawing.Point(0, 23);
            this.lciEmpresa.Name = "lciEmpresa";
            this.lciEmpresa.Size = new System.Drawing.Size(1164, 24);
            this.lciEmpresa.Text = "Empresa:";
            this.lciEmpresa.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkRutasExtras;
            this.layoutControlItem2.Location = new System.Drawing.Point(1062, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(102, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1062, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ofdDocumento
            // 
            this.ofdDocumento.FileName = null;
            this.ofdDocumento.Filter = "Excel Files|*.xlsx;*.xlsm";
            // 
            // xfrmImportacionRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 535);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmImportacionRutas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Importación de rutas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfrmImportacionRutas_FormClosing);
            this.Load += new System.EventHandler(this.xfrmImportacionRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkRutasExtras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoferEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChoferSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdRutas;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRutas;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colEntradaExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colSalidaExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
        private DevExpress.XtraBars.BarButtonItem bbiImportar;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.LookUpEdit lueEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueChoferEntrada;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueChoferSalida;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofdDocumento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueServicios;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.CheckEdit chkRutasExtras;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}