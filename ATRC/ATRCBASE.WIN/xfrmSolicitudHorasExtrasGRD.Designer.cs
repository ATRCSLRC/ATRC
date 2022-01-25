namespace ATRCBASE.WIN
{
    partial class xfrmSolicitudHorasExtrasGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSolicitudHorasExtrasGRD));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevaSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReimprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSalir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.grvSolicitudes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiNuevaSolicitud,
            this.bbiModificarSolicitud,
            this.bbiEliminarSolicitud,
            this.bbiSalir,
            this.bbiReimprimir,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevaSolicitud
            // 
            this.bbiNuevaSolicitud.Caption = "Nueva solicitud";
            this.bbiNuevaSolicitud.Id = 1;
            this.bbiNuevaSolicitud.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.icons8_últimas_48_horas_32__1_;
            this.bbiNuevaSolicitud.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevaSolicitud.Name = "bbiNuevaSolicitud";
            this.bbiNuevaSolicitud.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevaSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevaSolicitud_ItemClick);
            // 
            // bbiModificarSolicitud
            // 
            this.bbiModificarSolicitud.Caption = "Modificar solicitud";
            this.bbiModificarSolicitud.Id = 2;
            this.bbiModificarSolicitud.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.icons8_últimas_48_horas_32__3_;
            this.bbiModificarSolicitud.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificarSolicitud.Name = "bbiModificarSolicitud";
            this.bbiModificarSolicitud.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificarSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarSolicitud_ItemClick);
            // 
            // bbiEliminarSolicitud
            // 
            this.bbiEliminarSolicitud.Caption = "Eliminar solicitud";
            this.bbiEliminarSolicitud.Id = 3;
            this.bbiEliminarSolicitud.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.icons8_últimas_48_horas_32__2_;
            this.bbiEliminarSolicitud.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminarSolicitud.Name = "bbiEliminarSolicitud";
            this.bbiEliminarSolicitud.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminarSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarSolicitud_ItemClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 4;
            this.bbiSalir.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Salir;
            this.bbiSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalir_ItemClick);
            // 
            // bbiReimprimir
            // 
            this.bbiReimprimir.Caption = "Seleccionar imprimir solicitud";
            this.bbiReimprimir.Id = 5;
            this.bbiReimprimir.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.icons8_últimas_48_horas_32__4_;
            this.bbiReimprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.bbiReimprimir.Name = "bbiReimprimir";
            this.bbiReimprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiReimprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReimprimir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpgSalir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevaSolicitud);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificarSolicitud);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarSolicitud);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReimprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rpgSalir
            // 
            this.rpgSalir.ItemLinks.Add(this.bbiSalir);
            this.rpgSalir.Name = "rpgSalir";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdSolicitudes);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.Location = new System.Drawing.Point(12, 12);
            this.grdSolicitudes.MainView = this.grvSolicitudes;
            this.grdSolicitudes.MenuManager = this.ribbonControl1;
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.Size = new System.Drawing.Size(776, 294);
            this.grdSolicitudes.TabIndex = 4;
            this.grdSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSolicitudes});
            // 
            // grvSolicitudes
            // 
            this.grvSolicitudes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colEmpleado,
            this.colDe,
            this.colA,
            this.colMotivo,
            this.colOtro,
            this.colDias});
            this.grvSolicitudes.GridControl = this.grdSolicitudes;
            this.grvSolicitudes.Name = "grvSolicitudes";
            this.grvSolicitudes.OptionsBehavior.Editable = false;
            this.grvSolicitudes.OptionsBehavior.ReadOnly = true;
            this.grvSolicitudes.OptionsCustomization.AllowGroup = false;
            this.grvSolicitudes.OptionsView.AllowHtmlDrawGroups = false;
            this.grvSolicitudes.OptionsView.ShowAutoFilterRow = true;
            this.grvSolicitudes.OptionsView.ShowDetailButtons = false;
            this.grvSolicitudes.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.AllowFocus = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 76;
            // 
            // colEmpleado
            // 
            this.colEmpleado.Caption = "Empleado";
            this.colEmpleado.FieldName = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.OptionsColumn.AllowEdit = false;
            this.colEmpleado.OptionsColumn.AllowFocus = false;
            this.colEmpleado.Visible = true;
            this.colEmpleado.VisibleIndex = 1;
            this.colEmpleado.Width = 134;
            // 
            // colDe
            // 
            this.colDe.Caption = "De";
            this.colDe.FieldName = "De";
            this.colDe.Name = "colDe";
            this.colDe.OptionsColumn.AllowEdit = false;
            this.colDe.OptionsColumn.AllowFocus = false;
            this.colDe.Visible = true;
            this.colDe.VisibleIndex = 2;
            this.colDe.Width = 82;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.OptionsColumn.AllowEdit = false;
            this.colA.OptionsColumn.AllowFocus = false;
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 73;
            // 
            // colMotivo
            // 
            this.colMotivo.Caption = "Motivo";
            this.colMotivo.FieldName = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.OptionsColumn.AllowEdit = false;
            this.colMotivo.OptionsColumn.AllowFocus = false;
            this.colMotivo.Visible = true;
            this.colMotivo.VisibleIndex = 4;
            this.colMotivo.Width = 123;
            // 
            // colOtro
            // 
            this.colOtro.Caption = "Otro";
            this.colOtro.FieldName = "Otro";
            this.colOtro.Name = "colOtro";
            this.colOtro.OptionsColumn.AllowEdit = false;
            this.colOtro.OptionsColumn.AllowFocus = false;
            this.colOtro.Visible = true;
            this.colOtro.VisibleIndex = 5;
            this.colOtro.Width = 123;
            // 
            // colDias
            // 
            this.colDias.Caption = "Días";
            this.colDias.FieldName = "Dias";
            this.colDias.Name = "colDias";
            this.colDias.OptionsColumn.AllowEdit = false;
            this.colDias.OptionsColumn.AllowFocus = false;
            this.colDias.Visible = true;
            this.colDias.VisibleIndex = 6;
            this.colDias.Width = 140;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 318);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdSolicitudes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 6;
            this.bbiCancelar.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Cancelar;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // xfrmSolicitudHorasExtrasGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmSolicitudHorasExtrasGRD.IconOptions.Icon")));
            this.Name = "xfrmSolicitudHorasExtrasGRD";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Solicitudes de horas extras";
            this.Load += new System.EventHandler(this.xfrmSolicitudHorasExtrasGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSolicitudes;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevaSolicitud;
        private DevExpress.XtraBars.BarButtonItem bbiModificarSolicitud;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarSolicitud;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colDe;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colOtro;
        private DevExpress.XtraGrid.Columns.GridColumn colDias;
        private DevExpress.XtraBars.BarButtonItem bbiReimprimir;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
    }
}