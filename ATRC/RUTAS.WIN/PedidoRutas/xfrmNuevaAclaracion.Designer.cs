namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmNuevaAclaracion
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmNuevaAclaracion));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdRutas = new DevExpress.XtraGrid.GridControl();
            this.grvRuta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsApoyo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repchkApoyo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repExtra = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.replueServicio = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repcmbTipoRuta = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.replueTurno = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.reptimeHora = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repAHora = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.memoDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblInstrucciones = new DevExpress.XtraLayout.SimpleLabelItem();
            this.fypEdicion = new DevExpress.Utils.FlyoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkApoyo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repcmbTipoRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptimeHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstrucciones)).BeginInit();
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
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1073, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdRutas);
            this.lcMain.Controls.Add(this.memoDescripcion);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1121, 521, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(1073, 648);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdRutas
            // 
            this.grdRutas.Location = new System.Drawing.Point(12, 99);
            this.grdRutas.MainView = this.grvRuta;
            this.grdRutas.MenuManager = this.ribbonControl1;
            this.grdRutas.Name = "grdRutas";
            this.grdRutas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.replueServicio,
            this.repcmbTipoRuta,
            this.replueTurno,
            this.reptimeHora,
            this.repAHora,
            this.repchkApoyo,
            this.repExtra});
            this.grdRutas.Size = new System.Drawing.Size(1049, 537);
            this.grdRutas.TabIndex = 5;
            this.grdRutas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRuta});
            // 
            // grvRuta
            // 
            this.grvRuta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuta,
            this.colServicio,
            this.colTipoRuta,
            this.colTurno,
            this.colHoraDe,
            this.colAHora,
            this.colEsApoyo,
            this.colEsExtra});
            this.grvRuta.GridControl = this.grdRutas;
            this.grvRuta.Name = "grvRuta";
            this.grvRuta.OptionsView.ShowDetailButtons = false;
            this.grvRuta.OptionsView.ShowGroupPanel = false;
            this.grvRuta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvRuta_RowClick);
            this.grvRuta.ShownEditor += new System.EventHandler(this.grvRuta_ShownEditor);
            this.grvRuta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvRuta_FocusedRowChanged);
            // 
            // colRuta
            // 
            this.colRuta.Caption = "Ruta";
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.OptionsColumn.AllowEdit = false;
            this.colRuta.OptionsColumn.AllowFocus = false;
            this.colRuta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 0;
            this.colRuta.Width = 86;
            // 
            // colServicio
            // 
            this.colServicio.Caption = "Servicio";
            this.colServicio.FieldName = "Servicio";
            this.colServicio.Name = "colServicio";
            this.colServicio.OptionsColumn.AllowEdit = false;
            this.colServicio.OptionsColumn.AllowFocus = false;
            this.colServicio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServicio.Visible = true;
            this.colServicio.VisibleIndex = 1;
            this.colServicio.Width = 155;
            // 
            // colTipoRuta
            // 
            this.colTipoRuta.Caption = "Tipo de ruta";
            this.colTipoRuta.FieldName = "TipoRuta";
            this.colTipoRuta.Name = "colTipoRuta";
            this.colTipoRuta.OptionsColumn.AllowEdit = false;
            this.colTipoRuta.OptionsColumn.AllowFocus = false;
            this.colTipoRuta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoRuta.Visible = true;
            this.colTipoRuta.VisibleIndex = 2;
            this.colTipoRuta.Width = 76;
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.FieldName = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowFocus = false;
            this.colTurno.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 3;
            this.colTurno.Width = 114;
            // 
            // colHoraDe
            // 
            this.colHoraDe.Caption = "Hora de";
            this.colHoraDe.DisplayFormat.FormatString = "t";
            this.colHoraDe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHoraDe.FieldName = "HoraEntrada";
            this.colHoraDe.Name = "colHoraDe";
            this.colHoraDe.OptionsColumn.AllowEdit = false;
            this.colHoraDe.OptionsColumn.AllowFocus = false;
            this.colHoraDe.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHoraDe.Visible = true;
            this.colHoraDe.VisibleIndex = 4;
            this.colHoraDe.Width = 73;
            // 
            // colAHora
            // 
            this.colAHora.Caption = "A hora";
            this.colAHora.DisplayFormat.FormatString = "t";
            this.colAHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAHora.FieldName = "HoraSalida";
            this.colAHora.Name = "colAHora";
            this.colAHora.OptionsColumn.AllowEdit = false;
            this.colAHora.OptionsColumn.AllowFocus = false;
            this.colAHora.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAHora.Visible = true;
            this.colAHora.VisibleIndex = 5;
            this.colAHora.Width = 66;
            // 
            // colEsApoyo
            // 
            this.colEsApoyo.Caption = "Es apoyo";
            this.colEsApoyo.ColumnEdit = this.repchkApoyo;
            this.colEsApoyo.FieldName = "EsApoyo";
            this.colEsApoyo.Name = "colEsApoyo";
            this.colEsApoyo.OptionsColumn.AllowEdit = false;
            this.colEsApoyo.OptionsColumn.AllowFocus = false;
            this.colEsApoyo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEsApoyo.Visible = true;
            this.colEsApoyo.VisibleIndex = 6;
            this.colEsApoyo.Width = 55;
            // 
            // repchkApoyo
            // 
            this.repchkApoyo.AutoHeight = false;
            this.repchkApoyo.Name = "repchkApoyo";
            // 
            // colEsExtra
            // 
            this.colEsExtra.Caption = "Es extra";
            this.colEsExtra.ColumnEdit = this.repExtra;
            this.colEsExtra.FieldName = "EsRutaExtra";
            this.colEsExtra.Name = "colEsExtra";
            this.colEsExtra.OptionsColumn.AllowEdit = false;
            this.colEsExtra.OptionsColumn.AllowFocus = false;
            this.colEsExtra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEsExtra.Visible = true;
            this.colEsExtra.VisibleIndex = 7;
            this.colEsExtra.Width = 53;
            // 
            // repExtra
            // 
            this.repExtra.AutoHeight = false;
            this.repExtra.Name = "repExtra";
            // 
            // replueServicio
            // 
            this.replueServicio.AutoHeight = false;
            this.replueServicio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replueServicio.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clave", "Clave"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.replueServicio.DisplayMember = "Descripcion";
            this.replueServicio.Name = "replueServicio";
            this.replueServicio.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.replueServicio.EditValueChanged += new System.EventHandler(this.replueServicio_EditValueChanged);
            // 
            // repcmbTipoRuta
            // 
            this.repcmbTipoRuta.AutoHeight = false;
            this.repcmbTipoRuta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repcmbTipoRuta.Name = "repcmbTipoRuta";
            // 
            // replueTurno
            // 
            this.replueTurno.AutoHeight = false;
            this.replueTurno.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replueTurno.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.replueTurno.DisplayMember = "Descripcion";
            this.replueTurno.Name = "replueTurno";
            this.replueTurno.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // reptimeHora
            // 
            this.reptimeHora.AutoHeight = false;
            this.reptimeHora.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reptimeHora.Name = "reptimeHora";
            // 
            // repAHora
            // 
            this.repAHora.AutoHeight = false;
            this.repAHora.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repAHora.Name = "repAHora";
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Location = new System.Drawing.Point(75, 12);
            this.memoDescripcion.MenuManager = this.ribbonControl1;
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Size = new System.Drawing.Size(986, 66);
            this.memoDescripcion.StyleController = this.lcMain;
            this.memoDescripcion.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDescripcion,
            this.layoutControlItem2,
            this.lblInstrucciones});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1073, 648);
            this.Root.TextVisible = false;
            // 
            // lciDescripcion
            // 
            this.lciDescripcion.Control = this.memoDescripcion;
            this.lciDescripcion.Location = new System.Drawing.Point(0, 0);
            this.lciDescripcion.MaxSize = new System.Drawing.Size(0, 70);
            this.lciDescripcion.MinSize = new System.Drawing.Size(110, 70);
            this.lciDescripcion.Name = "lciDescripcion";
            this.lciDescripcion.Size = new System.Drawing.Size(1053, 70);
            this.lciDescripcion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDescripcion.Text = "Descripción:";
            this.lciDescripcion.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDescripcion.TextSize = new System.Drawing.Size(58, 13);
            this.lciDescripcion.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdRutas;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1053, 541);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AllowHotTrack = false;
            this.lblInstrucciones.Location = new System.Drawing.Point(0, 70);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(1053, 17);
            this.lblInstrucciones.Text = "Realizar modificaciones en las rutas del pedido:";
            this.lblInstrucciones.TextSize = new System.Drawing.Size(225, 13);
            // 
            // fypEdicion
            // 
            this.fypEdicion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.Appearance.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.Appearance.Options.UseBackColor = true;
            this.fypEdicion.Appearance.Options.UseForeColor = true;
            this.fypEdicion.Location = new System.Drawing.Point(12, 729);
            this.fypEdicion.Name = "fypEdicion";
            this.fypEdicion.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
            this.fypEdicion.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fypEdicion.OptionsBeakPanel.Opacity = 0.5D;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.fypEdicion.OptionsButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelHeight = 10;
            this.fypEdicion.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.fypEdicion.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Modificar", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.fypEdicion.OptionsButtonPanel.ShowButtonPanel = true;
            this.fypEdicion.OwnerControl = this;
            this.fypEdicion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fypEdicion.Size = new System.Drawing.Size(1049, 39);
            this.fypEdicion.TabIndex = 5;
            this.fypEdicion.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.fypEdicion_ButtonClick);
            // 
            // xfrmNuevaAclaracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 780);
            this.Controls.Add(this.fypEdicion);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmNuevaAclaracion.IconOptions.Icon")));
            this.Name = "xfrmNuevaAclaracion";
            this.Ribbon = this.ribbonControl1;
            this.Text = "xfrmNuevaAclaracion";
            this.Load += new System.EventHandler(this.xfrmNuevaAclaracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkApoyo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repcmbTipoRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replueTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptimeHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstrucciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fypEdicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdRutas;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraDe;
        private DevExpress.XtraGrid.Columns.GridColumn colAHora;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colEsApoyo;
        private DevExpress.XtraEditors.MemoEdit memoDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem lciDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.SimpleLabelItem lblInstrucciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replueServicio;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repcmbTipoRuta;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replueTurno;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit reptimeHora;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repAHora;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repchkApoyo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repExtra;
        private DevExpress.Utils.FlyoutPanel fypEdicion;
    }
}