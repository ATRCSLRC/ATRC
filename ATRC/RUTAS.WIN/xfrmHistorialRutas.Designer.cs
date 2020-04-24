namespace RUTAS.WIN
{
    partial class xfrmHistorialRutas
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdHistorial = new DevExpress.XtraGrid.GridControl();
            this.grvHistorial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsRutaExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsrutaCompleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtraChoferEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsExtraChoferSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colComentariosFacturacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colModifico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1438, 27);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdHistorial);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 27);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1438, 439);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdHistorial
            // 
            this.grdHistorial.Location = new System.Drawing.Point(12, 12);
            this.grdHistorial.MainView = this.grvHistorial;
            this.grdHistorial.MenuManager = this.ribbonControl1;
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemMemoExEdit2});
            this.grdHistorial.Size = new System.Drawing.Size(1414, 415);
            this.grdHistorial.TabIndex = 4;
            this.grdHistorial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHistorial});
            // 
            // grvHistorial
            // 
            this.grvHistorial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuta,
            this.colServicio,
            this.colFechaRuta,
            this.colTipoRuta,
            this.colTurno,
            this.colHoraEntrada,
            this.colHoraSalida,
            this.colChoferEntrada,
            this.colChoferSalida,
            this.colEsRutaExtra,
            this.colEsrutaCompleta,
            this.colEsExtraChoferEntrada,
            this.colEsExtraChoferSalida,
            this.colComentarios,
            this.colComentariosFacturacion,
            this.colModifico,
            this.colHorarioModificacion});
            this.grvHistorial.GridControl = this.grdHistorial;
            this.grvHistorial.Name = "grvHistorial";
            this.grvHistorial.OptionsView.AllowHtmlDrawGroups = false;
            this.grvHistorial.OptionsView.ShowDetailButtons = false;
            this.grvHistorial.OptionsView.ShowGroupPanel = false;
            // 
            // colRuta
            // 
            this.colRuta.Caption = "Ruta";
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.OptionsColumn.AllowEdit = false;
            this.colRuta.OptionsColumn.AllowFocus = false;
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 2;
            this.colRuta.Width = 83;
            // 
            // colServicio
            // 
            this.colServicio.Caption = "Servicio";
            this.colServicio.FieldName = "Servicio.Descripcion";
            this.colServicio.Name = "colServicio";
            this.colServicio.OptionsColumn.AllowEdit = false;
            this.colServicio.OptionsColumn.AllowFocus = false;
            this.colServicio.Visible = true;
            this.colServicio.VisibleIndex = 3;
            this.colServicio.Width = 90;
            // 
            // colFechaRuta
            // 
            this.colFechaRuta.Caption = "Fecha";
            this.colFechaRuta.FieldName = "FechaRuta";
            this.colFechaRuta.Name = "colFechaRuta";
            this.colFechaRuta.OptionsColumn.AllowEdit = false;
            this.colFechaRuta.OptionsColumn.AllowFocus = false;
            this.colFechaRuta.Visible = true;
            this.colFechaRuta.VisibleIndex = 1;
            this.colFechaRuta.Width = 65;
            // 
            // colTipoRuta
            // 
            this.colTipoRuta.Caption = "Tipo ruta";
            this.colTipoRuta.FieldName = "TipoRuta";
            this.colTipoRuta.Name = "colTipoRuta";
            this.colTipoRuta.OptionsColumn.AllowEdit = false;
            this.colTipoRuta.OptionsColumn.AllowFocus = false;
            this.colTipoRuta.Visible = true;
            this.colTipoRuta.VisibleIndex = 4;
            this.colTipoRuta.Width = 71;
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.FieldName = "Turno.Descripcion";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.AllowFocus = false;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 5;
            this.colTurno.Width = 82;
            // 
            // colHoraEntrada
            // 
            this.colHoraEntrada.Caption = "Hora entrada";
            this.colHoraEntrada.FieldName = "HoraEntrada";
            this.colHoraEntrada.Name = "colHoraEntrada";
            this.colHoraEntrada.OptionsColumn.AllowEdit = false;
            this.colHoraEntrada.OptionsColumn.AllowFocus = false;
            this.colHoraEntrada.Visible = true;
            this.colHoraEntrada.VisibleIndex = 6;
            this.colHoraEntrada.Width = 73;
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.Caption = "Hora salida";
            this.colHoraSalida.FieldName = "HoraSalida";
            this.colHoraSalida.Name = "colHoraSalida";
            this.colHoraSalida.OptionsColumn.AllowEdit = false;
            this.colHoraSalida.OptionsColumn.AllowFocus = false;
            this.colHoraSalida.Visible = true;
            this.colHoraSalida.VisibleIndex = 7;
            this.colHoraSalida.Width = 64;
            // 
            // colChoferEntrada
            // 
            this.colChoferEntrada.Caption = "Chofer entrada";
            this.colChoferEntrada.FieldName = "ChoferEntrada.Nombre";
            this.colChoferEntrada.Name = "colChoferEntrada";
            this.colChoferEntrada.OptionsColumn.AllowEdit = false;
            this.colChoferEntrada.OptionsColumn.AllowFocus = false;
            this.colChoferEntrada.Visible = true;
            this.colChoferEntrada.VisibleIndex = 9;
            this.colChoferEntrada.Width = 82;
            // 
            // colChoferSalida
            // 
            this.colChoferSalida.Caption = "Chofer salida";
            this.colChoferSalida.FieldName = "ChoferSalida.Nombre";
            this.colChoferSalida.Name = "colChoferSalida";
            this.colChoferSalida.OptionsColumn.AllowEdit = false;
            this.colChoferSalida.OptionsColumn.AllowFocus = false;
            this.colChoferSalida.Visible = true;
            this.colChoferSalida.VisibleIndex = 11;
            this.colChoferSalida.Width = 82;
            // 
            // colEsRutaExtra
            // 
            this.colEsRutaExtra.Caption = "Es extra";
            this.colEsRutaExtra.FieldName = "EsRutaExtra";
            this.colEsRutaExtra.Name = "colEsRutaExtra";
            this.colEsRutaExtra.OptionsColumn.AllowEdit = false;
            this.colEsRutaExtra.OptionsColumn.AllowFocus = false;
            this.colEsRutaExtra.Visible = true;
            this.colEsRutaExtra.VisibleIndex = 0;
            this.colEsRutaExtra.Width = 44;
            // 
            // colEsrutaCompleta
            // 
            this.colEsrutaCompleta.Caption = "Es completa";
            this.colEsrutaCompleta.FieldName = "RutaCompleta";
            this.colEsrutaCompleta.Name = "colEsrutaCompleta";
            this.colEsrutaCompleta.OptionsColumn.AllowEdit = false;
            this.colEsrutaCompleta.OptionsColumn.AllowFocus = false;
            this.colEsrutaCompleta.Visible = true;
            this.colEsrutaCompleta.VisibleIndex = 8;
            this.colEsrutaCompleta.Width = 67;
            // 
            // colEsExtraChoferEntrada
            // 
            this.colEsExtraChoferEntrada.Caption = "Extra chofer entrada";
            this.colEsExtraChoferEntrada.FieldName = "PagarChoferEntrada";
            this.colEsExtraChoferEntrada.Name = "colEsExtraChoferEntrada";
            this.colEsExtraChoferEntrada.OptionsColumn.AllowEdit = false;
            this.colEsExtraChoferEntrada.OptionsColumn.AllowFocus = false;
            this.colEsExtraChoferEntrada.Visible = true;
            this.colEsExtraChoferEntrada.VisibleIndex = 10;
            this.colEsExtraChoferEntrada.Width = 82;
            // 
            // colEsExtraChoferSalida
            // 
            this.colEsExtraChoferSalida.Caption = "Extra chofer salida";
            this.colEsExtraChoferSalida.FieldName = "PagarChoferSalida";
            this.colEsExtraChoferSalida.Name = "colEsExtraChoferSalida";
            this.colEsExtraChoferSalida.OptionsColumn.AllowEdit = false;
            this.colEsExtraChoferSalida.OptionsColumn.AllowFocus = false;
            this.colEsExtraChoferSalida.Visible = true;
            this.colEsExtraChoferSalida.VisibleIndex = 12;
            this.colEsExtraChoferSalida.Width = 82;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentario chofer";
            this.colComentarios.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 13;
            this.colComentarios.Width = 93;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.ReadOnly = true;
            // 
            // colComentariosFacturacion
            // 
            this.colComentariosFacturacion.Caption = "Comentarios facturación";
            this.colComentariosFacturacion.ColumnEdit = this.repositoryItemMemoExEdit2;
            this.colComentariosFacturacion.FieldName = "ComentariosFacturacion";
            this.colComentariosFacturacion.Name = "colComentariosFacturacion";
            this.colComentariosFacturacion.Visible = true;
            this.colComentariosFacturacion.VisibleIndex = 14;
            this.colComentariosFacturacion.Width = 87;
            // 
            // repositoryItemMemoExEdit2
            // 
            this.repositoryItemMemoExEdit2.AutoHeight = false;
            this.repositoryItemMemoExEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit2.Name = "repositoryItemMemoExEdit2";
            this.repositoryItemMemoExEdit2.ReadOnly = true;
            // 
            // colModifico
            // 
            this.colModifico.Caption = "Modificó";
            this.colModifico.FieldName = "UsuarioModificacion.Nombre";
            this.colModifico.Name = "colModifico";
            this.colModifico.OptionsColumn.AllowEdit = false;
            this.colModifico.OptionsColumn.AllowFocus = false;
            this.colModifico.Visible = true;
            this.colModifico.VisibleIndex = 15;
            this.colModifico.Width = 82;
            // 
            // colHorarioModificacion
            // 
            this.colHorarioModificacion.Caption = "Horario modificación";
            this.colHorarioModificacion.DisplayFormat.FormatString = "G";
            this.colHorarioModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHorarioModificacion.FieldName = "HorarioModificacion";
            this.colHorarioModificacion.Name = "colHorarioModificacion";
            this.colHorarioModificacion.OptionsColumn.AllowEdit = false;
            this.colHorarioModificacion.OptionsColumn.AllowFocus = false;
            this.colHorarioModificacion.Visible = true;
            this.colHorarioModificacion.VisibleIndex = 16;
            this.colHorarioModificacion.Width = 167;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1438, 439);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdHistorial;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1418, 419);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmHistorialRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 466);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmHistorialRutas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Historial de rutas";
            this.Load += new System.EventHandler(this.xfrmHistorialRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grdHistorial;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHistorial;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colEsRutaExtra;
        private DevExpress.XtraGrid.Columns.GridColumn colEsrutaCompleta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtraChoferEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colEsExtraChoferSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colComentariosFacturacion;
        private DevExpress.XtraGrid.Columns.GridColumn colModifico;
        private DevExpress.XtraGrid.Columns.GridColumn colHorarioModificacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit2;
    }
}