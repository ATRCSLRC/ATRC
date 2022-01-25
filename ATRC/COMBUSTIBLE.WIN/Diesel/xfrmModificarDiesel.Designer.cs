namespace COMBUSTIBLE.WIN
{
    partial class xfrmModificarDiesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmModificarDiesel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiModificar = new DevExpress.XtraBars.BarButtonItem();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdDiesel = new DevExpress.XtraGrid.GridControl();
            this.grvDiesel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMillas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCandadoAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCandadoAct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLitros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bbiLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.bbiBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFeha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFeha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiModificar,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(797, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiModificar
            // 
            this.bbiModificar.Caption = "Modificar diesel";
            this.bbiModificar.Id = 1;
            this.bbiModificar.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.icons8_plataforma_petrolera_321;
            this.bbiModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiModificar.Name = "bbiModificar";
            this.bbiModificar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificar_ItemClick);
            // 
            // rpMain
            // 
            this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpMain.Name = "rpMain";
            this.rpMain.Text = "ribbonPage1";
            this.rpMain.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdDiesel);
            this.lcMain.Controls.Add(this.bbiLimpiar);
            this.lcMain.Controls.Add(this.bbiBuscar);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(849, 165, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(797, 311);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdDiesel
            // 
            this.grdDiesel.Location = new System.Drawing.Point(12, 131);
            this.grdDiesel.MainView = this.grvDiesel;
            this.grdDiesel.MenuManager = this.ribbonControl1;
            this.grdDiesel.Name = "grdDiesel";
            this.grdDiesel.Size = new System.Drawing.Size(773, 168);
            this.grdDiesel.TabIndex = 8;
            this.grdDiesel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDiesel});
            // 
            // grvDiesel
            // 
            this.grvDiesel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMillas,
            this.colCandadoAnt,
            this.colCandadoAct,
            this.colTanque,
            this.colLitros});
            this.grvDiesel.GridControl = this.grdDiesel;
            this.grvDiesel.Name = "grvDiesel";
            this.grvDiesel.OptionsView.ShowGroupPanel = false;
            // 
            // colMillas
            // 
            this.colMillas.Caption = "Millas";
            this.colMillas.FieldName = "Millas";
            this.colMillas.Name = "colMillas";
            this.colMillas.OptionsColumn.AllowEdit = false;
            this.colMillas.OptionsColumn.AllowFocus = false;
            this.colMillas.OptionsColumn.ReadOnly = true;
            this.colMillas.Visible = true;
            this.colMillas.VisibleIndex = 0;
            // 
            // colCandadoAnt
            // 
            this.colCandadoAnt.Caption = "Candado anterior";
            this.colCandadoAnt.FieldName = "CandadoAnterior";
            this.colCandadoAnt.Name = "colCandadoAnt";
            this.colCandadoAnt.OptionsColumn.AllowEdit = false;
            this.colCandadoAnt.OptionsColumn.AllowFocus = false;
            this.colCandadoAnt.OptionsColumn.ReadOnly = true;
            this.colCandadoAnt.Visible = true;
            this.colCandadoAnt.VisibleIndex = 1;
            // 
            // colCandadoAct
            // 
            this.colCandadoAct.Caption = "Candado actual";
            this.colCandadoAct.FieldName = "CandadoActual";
            this.colCandadoAct.Name = "colCandadoAct";
            this.colCandadoAct.OptionsColumn.AllowEdit = false;
            this.colCandadoAct.OptionsColumn.AllowFocus = false;
            this.colCandadoAct.OptionsColumn.ReadOnly = true;
            this.colCandadoAct.Visible = true;
            this.colCandadoAct.VisibleIndex = 2;
            // 
            // colTanque
            // 
            this.colTanque.Caption = "Tanque";
            this.colTanque.FieldName = "UltimaRecarga.Tanque.Descripcion";
            this.colTanque.Name = "colTanque";
            this.colTanque.OptionsColumn.AllowEdit = false;
            this.colTanque.OptionsColumn.AllowFocus = false;
            this.colTanque.OptionsColumn.ReadOnly = true;
            this.colTanque.Visible = true;
            this.colTanque.VisibleIndex = 3;
            // 
            // colLitros
            // 
            this.colLitros.Caption = "Litros";
            this.colLitros.FieldName = "Litros";
            this.colLitros.Name = "colLitros";
            this.colLitros.OptionsColumn.AllowEdit = false;
            this.colLitros.OptionsColumn.AllowFocus = false;
            this.colLitros.OptionsColumn.ReadOnly = true;
            this.colLitros.Visible = true;
            this.colLitros.VisibleIndex = 4;
            // 
            // bbiLimpiar
            // 
            this.bbiLimpiar.Location = new System.Drawing.Point(620, 93);
            this.bbiLimpiar.Name = "bbiLimpiar";
            this.bbiLimpiar.Size = new System.Drawing.Size(153, 22);
            this.bbiLimpiar.StyleController = this.lcMain;
            this.bbiLimpiar.TabIndex = 7;
            this.bbiLimpiar.Text = "Limpiar";
            this.bbiLimpiar.Click += new System.EventHandler(this.bbiLimpiar_Click);
            // 
            // bbiBuscar
            // 
            this.bbiBuscar.Location = new System.Drawing.Point(482, 93);
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.Size = new System.Drawing.Size(134, 22);
            this.bbiBuscar.StyleController = this.lcMain;
            this.bbiBuscar.TabIndex = 6;
            this.bbiBuscar.Text = "Buscar";
            this.bbiBuscar.Click += new System.EventHandler(this.bbiBuscar_Click);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.EnterMoveNextControl = true;
            this.dteFecha.Location = new System.Drawing.Point(73, 69);
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
            this.dteFecha.Size = new System.Drawing.Size(700, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 5;
            // 
            // lueUnidad
            // 
            this.lueUnidad.EnterMoveNextControl = true;
            this.lueUnidad.Location = new System.Drawing.Point(73, 45);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueUnidad.Properties.ValueMember = "Oid";
            this.lueUnidad.Size = new System.Drawing.Size(700, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(797, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFeha,
            this.lciUnidad,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(777, 119);
            this.layoutControlGroup2.Text = "Filtros de búsqueda:";
            // 
            // lciFeha
            // 
            this.lciFeha.Control = this.dteFecha;
            this.lciFeha.Location = new System.Drawing.Point(0, 24);
            this.lciFeha.Name = "lciFeha";
            this.lciFeha.Size = new System.Drawing.Size(753, 24);
            this.lciFeha.Text = "Fecha:";
            this.lciFeha.TextSize = new System.Drawing.Size(37, 13);
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 0);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(753, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bbiBuscar;
            this.layoutControlItem3.Location = new System.Drawing.Point(458, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bbiLimpiar;
            this.layoutControlItem4.Location = new System.Drawing.Point(596, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(458, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grdDiesel;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(777, 172);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // xfrmModificarDiesel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 443);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmModificarDiesel.IconOptions.Icon")));
            this.Name = "xfrmModificarDiesel";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Modificación de diesel";
            this.Load += new System.EventHandler(this.xfrmModificarDiesel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmModificarDiesel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFeha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiModificar;
        private DevExpress.XtraGrid.GridControl grdDiesel;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDiesel;
        private DevExpress.XtraGrid.Columns.GridColumn colMillas;
        private DevExpress.XtraGrid.Columns.GridColumn colCandadoAnt;
        private DevExpress.XtraGrid.Columns.GridColumn colCandadoAct;
        private DevExpress.XtraGrid.Columns.GridColumn colTanque;
        private DevExpress.XtraGrid.Columns.GridColumn colLitros;
        private DevExpress.XtraEditors.SimpleButton bbiLimpiar;
        private DevExpress.XtraEditors.SimpleButton bbiBuscar;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciFeha;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}