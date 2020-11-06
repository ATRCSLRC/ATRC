namespace COMBUSTIBLE.WIN
{
    partial class xfrmPedidoDiesel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPedidoDiesel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancela = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdUnidades = new DevExpress.XtraGrid.GridControl();
            this.grvUnidades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.txtEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblEmpleado = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGuardar,
            this.bbiImprimir,
            this.bbiCancelar,
            this.bbiCancela});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(558, 132);
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
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 2;
            this.bbiImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.Image")));
            this.bbiImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.LargeImage")));
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 3;
            this.bbiCancelar.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.Cancelar1;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiCancela
            // 
            this.bbiCancela.Caption = "Cancelar";
            this.bbiCancela.Id = 4;
            this.bbiCancela.ImageOptions.LargeImage = global::COMBUSTIBLE.WIN.Properties.Resources.Cancelar1;
            this.bbiCancela.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiCancela.Name = "bbiCancela";
            this.bbiCancela.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiCancela.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancela);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdUnidades);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.txtEmpleado);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(640, 219, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(558, 255);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdUnidades
            // 
            this.grdUnidades.Location = new System.Drawing.Point(339, 28);
            this.grdUnidades.MainView = this.grvUnidades;
            this.grdUnidades.MenuManager = this.ribbonControl1;
            this.grdUnidades.Name = "grdUnidades";
            this.grdUnidades.Size = new System.Drawing.Size(207, 215);
            this.grdUnidades.TabIndex = 8;
            this.grdUnidades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUnidades});
            // 
            // grvUnidades
            // 
            this.grvUnidades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnidad});
            this.grvUnidades.GridControl = this.grdUnidades;
            this.grvUnidades.Name = "grvUnidades";
            this.grvUnidades.OptionsBehavior.Editable = false;
            this.grvUnidades.OptionsBehavior.ReadOnly = true;
            this.grvUnidades.OptionsDetail.SmartDetailExpand = false;
            this.grvUnidades.OptionsView.ShowDetailButtons = false;
            this.grvUnidades.OptionsView.ShowGroupPanel = false;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "Unidad.Nombre";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowEdit = false;
            this.colUnidad.OptionsColumn.AllowFocus = false;
            this.colUnidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnidad.OptionsFilter.AllowAutoFilter = false;
            this.colUnidad.OptionsFilter.AllowFilter = false;
            this.colUnidad.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 0;
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(24, 190);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Appearance.Options.UseTextOptions = true;
            this.lueUnidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lueUnidad.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.NullText = "[Seleccioné]";
            this.lueUnidad.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueUnidad.Properties.ValueMember = "Oid";
            this.lueUnidad.Size = new System.Drawing.Size(287, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 7;
            this.lueUnidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lueUnidad_KeyDown);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(24, 124);
            this.txtEmpleado.MenuManager = this.ribbonControl1;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmpleado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmpleado.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtEmpleado.Properties.Mask.EditMask = "d";
            this.txtEmpleado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEmpleado.Size = new System.Drawing.Size(287, 20);
            this.txtEmpleado.StyleController = this.lcMain;
            this.txtEmpleado.TabIndex = 5;
            this.txtEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleado_KeyDown);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Enabled = false;
            this.dteFecha.Location = new System.Drawing.Point(24, 81);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Appearance.Options.UseTextOptions = true;
            this.dteFecha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteFecha.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Properties.ReadOnly = true;
            this.dteFecha.Size = new System.Drawing.Size(287, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(558, 255);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.grdUnidades;
            this.layoutControlItem1.Location = new System.Drawing.Point(327, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(211, 235);
            this.layoutControlItem1.Text = "Unidad registradas:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(194, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(315, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(12, 235);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(12, 235);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(12, 235);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lciUnidad,
            this.lblEmpleado,
            this.lciEmpleado,
            this.lciFecha,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(315, 235);
            this.layoutControlGroup2.Text = "Pedido de diesel";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 169);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(291, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciUnidad
            // 
            this.lciUnidad.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciUnidad.AppearanceItemCaption.Options.UseFont = true;
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 126);
            this.lciUnidad.MaxSize = new System.Drawing.Size(291, 43);
            this.lciUnidad.MinSize = new System.Drawing.Size(291, 43);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(291, 43);
            this.lciUnidad.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciUnidad.Text = "Seleccioné la unidad:";
            this.lciUnidad.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciUnidad.TextSize = new System.Drawing.Size(194, 16);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AllowHotTrack = false;
            this.lblEmpleado.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.lblEmpleado.AppearanceItemCaption.Options.UseFont = true;
            this.lblEmpleado.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblEmpleado.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblEmpleado.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblEmpleado.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblEmpleado.Location = new System.Drawing.Point(0, 103);
            this.lblEmpleado.MaxSize = new System.Drawing.Size(291, 23);
            this.lblEmpleado.MinSize = new System.Drawing.Size(291, 23);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(291, 23);
            this.lblEmpleado.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblEmpleado.Text = " ";
            this.lblEmpleado.TextSize = new System.Drawing.Size(194, 19);
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciEmpleado.AppearanceItemCaption.Options.UseFont = true;
            this.lciEmpleado.Control = this.txtEmpleado;
            this.lciEmpleado.CustomizationFormText = "Ingresé número de empleado:";
            this.lciEmpleado.Location = new System.Drawing.Point(0, 60);
            this.lciEmpleado.MaxSize = new System.Drawing.Size(291, 43);
            this.lciEmpleado.MinSize = new System.Drawing.Size(291, 43);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(291, 43);
            this.lciEmpleado.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciEmpleado.Text = "Ingresé número de empleado:";
            this.lciEmpleado.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciEmpleado.TextSize = new System.Drawing.Size(194, 16);
            // 
            // lciFecha
            // 
            this.lciFecha.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciFecha.AppearanceItemCaption.Options.UseFont = true;
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 17);
            this.lciFecha.MaxSize = new System.Drawing.Size(291, 43);
            this.lciFecha.MinSize = new System.Drawing.Size(291, 43);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(291, 43);
            this.lciFecha.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFecha.Text = "Fecha:";
            this.lciFecha.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFecha.TextSize = new System.Drawing.Size(194, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(291, 17);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xfrmPedidoDiesel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 387);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmPedidoDiesel.IconOptions.Icon")));
            this.Name = "xfrmPedidoDiesel";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Pedido de diesel";
            this.Load += new System.EventHandler(this.xfrmPedidoDiesel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtEmpleado;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiCancela;
        private DevExpress.XtraGrid.GridControl grdUnidades;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.SimpleLabelItem lblEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
    }
}