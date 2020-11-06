namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmRevisionPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRevisionPedido));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdRevision = new DevExpress.XtraGrid.GridControl();
            this.grvRevision = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsApoyo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDocumento = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDocumento)).BeginInit();
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
            this.bbiImprimir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir rutas";
            this.bbiImprimir.Id = 1;
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdRevision);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 318);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdRevision
            // 
            this.grdRevision.Location = new System.Drawing.Point(12, 12);
            this.grdRevision.MainView = this.grvRevision;
            this.grdRevision.MenuManager = this.ribbonControl1;
            this.grdRevision.Name = "grdRevision";
            this.grdRevision.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeDocumento});
            this.grdRevision.Size = new System.Drawing.Size(776, 294);
            this.grdRevision.TabIndex = 4;
            this.grdRevision.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRevision});
            // 
            // grvRevision
            // 
            this.grvRevision.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuta,
            this.colServicio,
            this.colTipoRuta,
            this.colTurno,
            this.colHoraDe,
            this.colAHora,
            this.colEsApoyo,
            this.colEsExtra,
            this.colDocumento});
            this.grvRevision.GridControl = this.grdRevision;
            this.grvRevision.Name = "grvRevision";
            this.grvRevision.OptionsView.AllowHtmlDrawGroups = false;
            this.grvRevision.OptionsView.ShowDetailButtons = false;
            this.grvRevision.OptionsView.ShowGroupPanel = false;
            this.grvRevision.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvRevision_CustomRowCellEdit);
            // 
            // colRuta
            // 
            this.colRuta.Caption = "Ruta";
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.OptionsColumn.AllowEdit = false;
            this.colRuta.OptionsColumn.AllowFocus = false;
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 0;
            this.colRuta.Width = 86;
            // 
            // colServicio
            // 
            this.colServicio.Caption = "Servicio";
            this.colServicio.FieldName = "Servicio.Descripcion";
            this.colServicio.Name = "colServicio";
            this.colServicio.OptionsColumn.AllowEdit = false;
            this.colServicio.OptionsColumn.AllowFocus = false;
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
            this.colTipoRuta.Visible = true;
            this.colTipoRuta.VisibleIndex = 2;
            this.colTipoRuta.Width = 76;
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.FieldName = "Turno.Descripcion";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowFocus = false;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 3;
            this.colTurno.Width = 114;
            // 
            // colHoraDe
            // 
            this.colHoraDe.Caption = "Hora de";
            this.colHoraDe.FieldName = "HoraEntrada";
            this.colHoraDe.Name = "colHoraDe";
            this.colHoraDe.OptionsColumn.AllowEdit = false;
            this.colHoraDe.OptionsColumn.AllowFocus = false;
            this.colHoraDe.Visible = true;
            this.colHoraDe.VisibleIndex = 4;
            this.colHoraDe.Width = 73;
            // 
            // colAHora
            // 
            this.colAHora.Caption = "A hora";
            this.colAHora.FieldName = "HoraSalida";
            this.colAHora.Name = "colAHora";
            this.colAHora.OptionsColumn.AllowEdit = false;
            this.colAHora.OptionsColumn.AllowFocus = false;
            this.colAHora.Visible = true;
            this.colAHora.VisibleIndex = 5;
            this.colAHora.Width = 66;
            // 
            // colEsApoyo
            // 
            this.colEsApoyo.Caption = "Es apoyo";
            this.colEsApoyo.FieldName = "EsApoyo";
            this.colEsApoyo.Name = "colEsApoyo";
            this.colEsApoyo.OptionsColumn.AllowEdit = false;
            this.colEsApoyo.OptionsColumn.AllowFocus = false;
            this.colEsApoyo.Visible = true;
            this.colEsApoyo.VisibleIndex = 6;
            this.colEsApoyo.Width = 55;
            // 
            // colEsExtra
            // 
            this.colEsExtra.Caption = "Es extra";
            this.colEsExtra.FieldName = "EsRutaExtra";
            this.colEsExtra.Name = "colEsExtra";
            this.colEsExtra.OptionsColumn.AllowEdit = false;
            this.colEsExtra.OptionsColumn.AllowFocus = false;
            this.colEsExtra.Visible = true;
            this.colEsExtra.VisibleIndex = 7;
            this.colEsExtra.Width = 53;
            // 
            // colDocumento
            // 
            this.colDocumento.Caption = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.Visible = true;
            this.colDocumento.VisibleIndex = 8;
            this.colDocumento.Width = 73;
            // 
            // ribeDocumento
            // 
            this.ribeDocumento.AutoHeight = false;
            this.ribeDocumento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribeDocumento.Name = "ribeDocumento";
            this.ribeDocumento.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDocumento.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeDocumento_ButtonClick);
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
            this.layoutControlItem1.Control = this.grdRevision;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xtraSaveFileDialog
            // 
            this.xtraSaveFileDialog.FileName = "xtraSaveFileDialog1";
            this.xtraSaveFileDialog.Filter = "XLSx (*.xlsx;*.xls) | *.xlsx;*.xls";
            // 
            // xfrmRevisionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmRevisionPedido.IconOptions.Icon")));
            this.Name = "xfrmRevisionPedido";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Revisión  de pedido";
            this.Load += new System.EventHandler(this.xfrmRevisionPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDocumento)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdRevision;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRevision;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraDe;
        private DevExpress.XtraGrid.Columns.GridColumn colAHora;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colEsApoyo;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDocumento;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog;
    }
}