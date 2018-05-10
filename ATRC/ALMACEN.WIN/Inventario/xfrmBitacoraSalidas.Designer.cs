namespace ALMACEN.WIN
{
    partial class xfrmBitacoraSalidas
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdSalida = new DevExpress.XtraGrid.GridControl();
            this.grvSalidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecibio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevolver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribtnDevolver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.rgOpcion = new DevExpress.XtraEditors.RadioGroup();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciOpcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribtnDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOpcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdSalida);
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.btnBusqueda);
            this.lcMain.Controls.Add(this.txtCodigo);
            this.lcMain.Controls.Add(this.rgOpcion);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDel);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(953, 179, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(963, 492);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdSalida
            // 
            this.grdSalida.Location = new System.Drawing.Point(12, 157);
            this.grdSalida.MainView = this.grvSalidas;
            this.grdSalida.MenuManager = this.ribbonControl1;
            this.grdSalida.Name = "grdSalida";
            this.grdSalida.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribtnDevolver});
            this.grdSalida.Size = new System.Drawing.Size(939, 323);
            this.grdSalida.TabIndex = 10;
            this.grdSalida.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSalidas});
            // 
            // grvSalidas
            // 
            this.grvSalidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colCodigo,
            this.colNombre,
            this.colCantidad,
            this.colDestino,
            this.colRecibio,
            this.colFechaSalida,
            this.colDevolver});
            this.grvSalidas.GridControl = this.grdSalida;
            this.grvSalidas.Name = "grvSalidas";
            this.grvSalidas.OptionsView.ShowGroupPanel = false;
            this.grvSalidas.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvSalidas_CustomRowCellEdit);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 61;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Articulo.Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Articulo.Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 170;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 51;
            // 
            // colDestino
            // 
            this.colDestino.Caption = "Destino";
            this.colDestino.FieldName = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.OptionsColumn.AllowEdit = false;
            this.colDestino.OptionsColumn.ReadOnly = true;
            this.colDestino.Visible = true;
            this.colDestino.VisibleIndex = 4;
            this.colDestino.Width = 110;
            // 
            // colRecibio
            // 
            this.colRecibio.Caption = "Recibio";
            this.colRecibio.FieldName = "UsuarioRecibo.Nombre";
            this.colRecibio.Name = "colRecibio";
            this.colRecibio.OptionsColumn.AllowEdit = false;
            this.colRecibio.OptionsColumn.ReadOnly = true;
            this.colRecibio.Visible = true;
            this.colRecibio.VisibleIndex = 5;
            this.colRecibio.Width = 110;
            // 
            // colFechaSalida
            // 
            this.colFechaSalida.Caption = "Fecha salida";
            this.colFechaSalida.FieldName = "Fecha";
            this.colFechaSalida.Name = "colFechaSalida";
            this.colFechaSalida.OptionsColumn.AllowEdit = false;
            this.colFechaSalida.OptionsColumn.ReadOnly = true;
            this.colFechaSalida.Visible = true;
            this.colFechaSalida.VisibleIndex = 6;
            this.colFechaSalida.Width = 51;
            // 
            // colDevolver
            // 
            this.colDevolver.Caption = "Devolver";
            this.colDevolver.ColumnEdit = this.ribtnDevolver;
            this.colDevolver.Name = "colDevolver";
            this.colDevolver.Visible = true;
            this.colDevolver.VisibleIndex = 7;
            this.colDevolver.Width = 51;
            // 
            // ribtnDevolver
            // 
            this.ribtnDevolver.AutoHeight = false;
            this.ribtnDevolver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo)});
            this.ribtnDevolver.Name = "ribtnDevolver";
            this.ribtnDevolver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribtnDevolver.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribtnDevolver_ButtonClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(963, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(786, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 22);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar (F12)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(612, 119);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(170, 22);
            this.btnBusqueda.StyleController = this.lcMain;
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "Buscar (F5)";
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 95);
            this.txtCodigo.MenuManager = this.ribbonControl1;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(810, 20);
            this.txtCodigo.StyleController = this.lcMain;
            this.txtCodigo.TabIndex = 7;
            // 
            // rgOpcion
            // 
            this.rgOpcion.Location = new System.Drawing.Point(129, 66);
            this.rgOpcion.MenuManager = this.ribbonControl1;
            this.rgOpcion.Name = "rgOpcion";
            this.rgOpcion.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Artículo específico")});
            this.rgOpcion.Size = new System.Drawing.Size(810, 25);
            this.rgOpcion.StyleController = this.lcMain;
            this.rgOpcion.TabIndex = 6;
            this.rgOpcion.SelectedIndexChanged += new System.EventHandler(this.rgOpcion_SelectedIndexChanged);
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(589, 42);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dteAl.Size = new System.Drawing.Size(350, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 5;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.Location = new System.Drawing.Point(129, 42);
            this.dteDel.MenuManager = this.ribbonControl1;
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dteDel.Size = new System.Drawing.Size(351, 20);
            this.dteDel.StyleController = this.lcMain;
            this.dteDel.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgBusqueda,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(963, 492);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgBusqueda
            // 
            this.lcgBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.lciOpcion,
            this.lciCodigo,
            this.lciAl,
            this.lciDel});
            this.lcgBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgBusqueda.Name = "lcgBusqueda";
            this.lcgBusqueda.Size = new System.Drawing.Size(943, 145);
            this.lcgBusqueda.Text = "Detalle de búsqueda";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(762, 77);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnBusqueda;
            this.layoutControlItem5.Location = new System.Drawing.Point(588, 77);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(174, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 77);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(588, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciOpcion
            // 
            this.lciOpcion.Control = this.rgOpcion;
            this.lciOpcion.Location = new System.Drawing.Point(0, 24);
            this.lciOpcion.MaxSize = new System.Drawing.Size(0, 29);
            this.lciOpcion.MinSize = new System.Drawing.Size(160, 29);
            this.lciOpcion.Name = "lciOpcion";
            this.lciOpcion.Size = new System.Drawing.Size(919, 29);
            this.lciOpcion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOpcion.Text = "Opción de búsqueda:";
            this.lciOpcion.TextSize = new System.Drawing.Size(102, 13);
            // 
            // lciCodigo
            // 
            this.lciCodigo.Control = this.txtCodigo;
            this.lciCodigo.Location = new System.Drawing.Point(0, 53);
            this.lciCodigo.Name = "lciCodigo";
            this.lciCodigo.Size = new System.Drawing.Size(919, 24);
            this.lciCodigo.Text = "Código:";
            this.lciCodigo.TextSize = new System.Drawing.Size(102, 13);
            this.lciCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciAl
            // 
            this.lciAl.Control = this.dteAl;
            this.lciAl.Location = new System.Drawing.Point(460, 0);
            this.lciAl.Name = "lciAl";
            this.lciAl.Size = new System.Drawing.Size(459, 24);
            this.lciAl.Text = "Al:";
            this.lciAl.TextSize = new System.Drawing.Size(102, 13);
            // 
            // lciDel
            // 
            this.lciDel.Control = this.dteDel;
            this.lciDel.Location = new System.Drawing.Point(0, 0);
            this.lciDel.Name = "lciDel";
            this.lciDel.Size = new System.Drawing.Size(460, 24);
            this.lciDel.Text = "Del:";
            this.lciDel.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.grdSalida;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(943, 327);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // xfrmBitacoraSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 519);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmBitacoraSalidas";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitácora de salidas";
            this.Load += new System.EventHandler(this.xfrmBitacoraSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribtnDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOpcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdSalida;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSalidas;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colRecibio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSalida;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnBusqueda;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.RadioGroup rgOpcion;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBusqueda;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciOpcion;
        private DevExpress.XtraLayout.LayoutControlItem lciCodigo;
        private DevExpress.XtraLayout.LayoutControlItem lciAl;
        private DevExpress.XtraLayout.LayoutControlItem lciDel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colDevolver;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribtnDevolver;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}