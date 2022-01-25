namespace UNIDADES.WIN
{
    partial class xfrmExtintores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmExtintores));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.dteVencimiento = new DevExpress.XtraEditors.DateEdit();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.rgEstado = new DevExpress.XtraEditors.RadioGroup();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.dteFechaRecarga = new DevExpress.XtraEditors.DateEdit();
            this.txtOficina = new DevExpress.XtraEditors.TextEdit();
            this.txtExtintor = new DevExpress.XtraEditors.TextEdit();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.rgUbicacion = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTipoUbicacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNumExtintor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOficina = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaRecarga = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPeso = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEstado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaVencimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciComentarios = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaRecarga.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaRecarga.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtintor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumExtintor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOficina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaRecarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(450, 132);
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
            this.rpgAcciones});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.AllowTextClipping = false;
            this.rpgAcciones.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.memoComentarios);
            this.lcMain.Controls.Add(this.dteVencimiento);
            this.lcMain.Controls.Add(this.rgTipo);
            this.lcMain.Controls.Add(this.rgEstado);
            this.lcMain.Controls.Add(this.txtPeso);
            this.lcMain.Controls.Add(this.dteFechaRecarga);
            this.lcMain.Controls.Add(this.txtOficina);
            this.lcMain.Controls.Add(this.txtExtintor);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.rgUbicacion);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(502, 34, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(450, 305);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(132, 246);
            this.memoComentarios.MenuManager = this.ribbonControl1;
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(306, 47);
            this.memoComentarios.StyleController = this.lcMain;
            this.memoComentarios.TabIndex = 19;
            // 
            // dteVencimiento
            // 
            this.dteVencimiento.EditValue = null;
            this.dteVencimiento.EnterMoveNextControl = true;
            this.dteVencimiento.Location = new System.Drawing.Point(132, 60);
            this.dteVencimiento.MenuManager = this.ribbonControl1;
            this.dteVencimiento.Name = "dteVencimiento";
            this.dteVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteVencimiento.Properties.DisplayFormat.FormatString = "D";
            this.dteVencimiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteVencimiento.Properties.EditFormat.FormatString = "D";
            this.dteVencimiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteVencimiento.Properties.Mask.EditMask = "D";
            this.dteVencimiento.Size = new System.Drawing.Size(306, 20);
            this.dteVencimiento.StyleController = this.lcMain;
            this.dteVencimiento.TabIndex = 18;
            // 
            // rgTipo
            // 
            this.rgTipo.EditValue = "PQS";
            this.rgTipo.EnterMoveNextControl = true;
            this.rgTipo.Location = new System.Drawing.Point(132, 162);
            this.rgTipo.MenuManager = this.ribbonControl1;
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PQS", "PQS")});
            this.rgTipo.Size = new System.Drawing.Size(306, 26);
            this.rgTipo.StyleController = this.lcMain;
            this.rgTipo.TabIndex = 17;
            // 
            // rgEstado
            // 
            this.rgEstado.EnterMoveNextControl = true;
            this.rgEstado.Location = new System.Drawing.Point(132, 216);
            this.rgEstado.MenuManager = this.ribbonControl1;
            this.rgEstado.Name = "rgEstado";
            this.rgEstado.Size = new System.Drawing.Size(306, 26);
            this.rgEstado.StyleController = this.lcMain;
            this.rgEstado.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.EnterMoveNextControl = true;
            this.txtPeso.Location = new System.Drawing.Point(132, 192);
            this.txtPeso.MenuManager = this.ribbonControl1;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Mask.EditMask = "n";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeso.Size = new System.Drawing.Size(306, 20);
            this.txtPeso.StyleController = this.lcMain;
            this.txtPeso.TabIndex = 15;
            // 
            // dteFechaRecarga
            // 
            this.dteFechaRecarga.EditValue = null;
            this.dteFechaRecarga.EnterMoveNextControl = true;
            this.dteFechaRecarga.Location = new System.Drawing.Point(132, 36);
            this.dteFechaRecarga.MenuManager = this.ribbonControl1;
            this.dteFechaRecarga.Name = "dteFechaRecarga";
            this.dteFechaRecarga.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFechaRecarga.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFechaRecarga.Properties.DisplayFormat.FormatString = "D";
            this.dteFechaRecarga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFechaRecarga.Properties.EditFormat.FormatString = "D";
            this.dteFechaRecarga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFechaRecarga.Properties.Mask.EditMask = "D";
            this.dteFechaRecarga.Size = new System.Drawing.Size(306, 20);
            this.dteFechaRecarga.StyleController = this.lcMain;
            this.dteFechaRecarga.TabIndex = 13;
            // 
            // txtOficina
            // 
            this.txtOficina.EnterMoveNextControl = true;
            this.txtOficina.Location = new System.Drawing.Point(132, 138);
            this.txtOficina.MenuManager = this.ribbonControl1;
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(306, 20);
            this.txtOficina.StyleController = this.lcMain;
            this.txtOficina.TabIndex = 12;
            // 
            // txtExtintor
            // 
            this.txtExtintor.EnterMoveNextControl = true;
            this.txtExtintor.Location = new System.Drawing.Point(132, 12);
            this.txtExtintor.MenuManager = this.ribbonControl1;
            this.txtExtintor.Name = "txtExtintor";
            this.txtExtintor.Properties.Mask.EditMask = "d";
            this.txtExtintor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtExtintor.Size = new System.Drawing.Size(306, 20);
            this.txtExtintor.StyleController = this.lcMain;
            this.txtExtintor.TabIndex = 11;
            // 
            // lueUnidad
            // 
            this.lueUnidad.EnterMoveNextControl = true;
            this.lueUnidad.Location = new System.Drawing.Point(132, 114);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.NullText = "[Seleccioné]";
            this.lueUnidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueUnidad.Properties.ValueMember = "Oid";
            this.lueUnidad.Size = new System.Drawing.Size(306, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 8;
            // 
            // rgUbicacion
            // 
            this.rgUbicacion.EnterMoveNextControl = true;
            this.rgUbicacion.Location = new System.Drawing.Point(132, 84);
            this.rgUbicacion.MenuManager = this.ribbonControl1;
            this.rgUbicacion.Name = "rgUbicacion";
            this.rgUbicacion.Properties.Columns = 3;
            this.rgUbicacion.Size = new System.Drawing.Size(306, 26);
            this.rgUbicacion.StyleController = this.lcMain;
            this.rgUbicacion.TabIndex = 7;
            this.rgUbicacion.SelectedIndexChanged += new System.EventHandler(this.rgDestino_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTipoUbicacion,
            this.lciUnidad,
            this.lciNumExtintor,
            this.lciOficina,
            this.lciFechaRecarga,
            this.lciPeso,
            this.lciEstado,
            this.lciTipo,
            this.lciFechaVencimiento,
            this.lciComentarios});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 305);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciTipoUbicacion
            // 
            this.lciTipoUbicacion.Control = this.rgUbicacion;
            this.lciTipoUbicacion.Location = new System.Drawing.Point(0, 72);
            this.lciTipoUbicacion.MaxSize = new System.Drawing.Size(0, 30);
            this.lciTipoUbicacion.MinSize = new System.Drawing.Size(165, 30);
            this.lciTipoUbicacion.Name = "lciTipoUbicacion";
            this.lciTipoUbicacion.Size = new System.Drawing.Size(430, 30);
            this.lciTipoUbicacion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipoUbicacion.Text = "Tipo de ubicación:";
            this.lciTipoUbicacion.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 102);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(430, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciNumExtintor
            // 
            this.lciNumExtintor.Control = this.txtExtintor;
            this.lciNumExtintor.Location = new System.Drawing.Point(0, 0);
            this.lciNumExtintor.Name = "lciNumExtintor";
            this.lciNumExtintor.Size = new System.Drawing.Size(430, 24);
            this.lciNumExtintor.Text = "Extintor:";
            this.lciNumExtintor.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciOficina
            // 
            this.lciOficina.Control = this.txtOficina;
            this.lciOficina.Location = new System.Drawing.Point(0, 126);
            this.lciOficina.Name = "lciOficina";
            this.lciOficina.Size = new System.Drawing.Size(430, 24);
            this.lciOficina.Text = "Oficina:";
            this.lciOficina.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciFechaRecarga
            // 
            this.lciFechaRecarga.Control = this.dteFechaRecarga;
            this.lciFechaRecarga.Location = new System.Drawing.Point(0, 24);
            this.lciFechaRecarga.Name = "lciFechaRecarga";
            this.lciFechaRecarga.Size = new System.Drawing.Size(430, 24);
            this.lciFechaRecarga.Text = "Fecha de recarga:";
            this.lciFechaRecarga.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciPeso
            // 
            this.lciPeso.Control = this.txtPeso;
            this.lciPeso.Location = new System.Drawing.Point(0, 180);
            this.lciPeso.Name = "lciPeso";
            this.lciPeso.Size = new System.Drawing.Size(430, 24);
            this.lciPeso.Text = "Peso (kg):";
            this.lciPeso.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciEstado
            // 
            this.lciEstado.Control = this.rgEstado;
            this.lciEstado.Location = new System.Drawing.Point(0, 204);
            this.lciEstado.MaxSize = new System.Drawing.Size(0, 30);
            this.lciEstado.MinSize = new System.Drawing.Size(165, 30);
            this.lciEstado.Name = "lciEstado";
            this.lciEstado.Size = new System.Drawing.Size(430, 30);
            this.lciEstado.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciEstado.Text = "Estado:";
            this.lciEstado.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciTipo
            // 
            this.lciTipo.Control = this.rgTipo;
            this.lciTipo.Location = new System.Drawing.Point(0, 150);
            this.lciTipo.MaxSize = new System.Drawing.Size(0, 30);
            this.lciTipo.MinSize = new System.Drawing.Size(165, 30);
            this.lciTipo.Name = "lciTipo";
            this.lciTipo.Size = new System.Drawing.Size(430, 30);
            this.lciTipo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTipo.Text = "Tipo:";
            this.lciTipo.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciFechaVencimiento
            // 
            this.lciFechaVencimiento.Control = this.dteVencimiento;
            this.lciFechaVencimiento.Location = new System.Drawing.Point(0, 48);
            this.lciFechaVencimiento.Name = "lciFechaVencimiento";
            this.lciFechaVencimiento.Size = new System.Drawing.Size(430, 24);
            this.lciFechaVencimiento.Text = "Fecha de vencimiento:";
            this.lciFechaVencimiento.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lciComentarios
            // 
            this.lciComentarios.Control = this.memoComentarios;
            this.lciComentarios.Location = new System.Drawing.Point(0, 234);
            this.lciComentarios.Name = "lciComentarios";
            this.lciComentarios.Size = new System.Drawing.Size(430, 51);
            this.lciComentarios.Text = "Comentarios:";
            this.lciComentarios.TextSize = new System.Drawing.Size(108, 13);
            this.lciComentarios.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmExtintores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 437);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmExtintores.IconOptions.Icon")));
            this.Name = "xfrmExtintores";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Extintor";
            this.Load += new System.EventHandler(this.xfrmRadios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmExtintores_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaRecarga.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaRecarga.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtintor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumExtintor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOficina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaRecarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraEditors.RadioGroup rgUbicacion;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoUbicacion;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtExtintor;
        private DevExpress.XtraLayout.LayoutControlItem lciNumExtintor;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.DateEdit dteFechaRecarga;
        private DevExpress.XtraEditors.TextEdit txtOficina;
        private DevExpress.XtraLayout.LayoutControlItem lciOficina;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaRecarga;
        private DevExpress.XtraLayout.LayoutControlItem lciPeso;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private DevExpress.XtraEditors.RadioGroup rgEstado;
        private DevExpress.XtraLayout.LayoutControlItem lciEstado;
        private DevExpress.XtraLayout.LayoutControlItem lciTipo;
        private DevExpress.XtraEditors.DateEdit dteVencimiento;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaVencimiento;
        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraLayout.LayoutControlItem lciComentarios;
    }
}