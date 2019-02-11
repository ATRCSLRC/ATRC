namespace UNIDADES.WIN.Reportes
{
    partial class xfrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmServicios));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.rgCantidadUnidad = new DevExpress.XtraEditors.RadioGroup();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.rgServicios = new DevExpress.XtraEditors.RadioGroup();
            this.dteAl = new DevExpress.XtraEditors.DateEdit();
            this.dteDel = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgCriteriosBusqueda = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFechaDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciServicio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFechaAl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCantidadUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgCantidadUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgServicios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteriosBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidadUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiImprimir,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(638, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 1;
            this.bbiImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImprimir.ImageOptions.LargeImage")));
            this.bbiImprimir.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
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
            this.rpgAcciones.ItemLinks.Add(this.bbiImprimir);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.rgCantidadUnidad);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.rgServicios);
            this.lcMain.Controls.Add(this.dteAl);
            this.lcMain.Controls.Add(this.dteDel);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(52, 407, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(638, 248);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // rgCantidadUnidad
            // 
            this.rgCantidadUnidad.EditValue = "Todos";
            this.rgCantidadUnidad.Location = new System.Drawing.Point(24, 82);
            this.rgCantidadUnidad.MenuManager = this.ribbonControl1;
            this.rgCantidadUnidad.Name = "rgCantidadUnidad";
            this.rgCantidadUnidad.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Todos", "Todas las unidades"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Unidad", "Unidad específica")});
            this.rgCantidadUnidad.Size = new System.Drawing.Size(590, 25);
            this.rgCantidadUnidad.StyleController = this.lcMain;
            this.rgCantidadUnidad.TabIndex = 8;
            this.rgCantidadUnidad.SelectedIndexChanged += new System.EventHandler(this.rgCantidadUnidad_SelectedIndexChanged);
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(24, 127);
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
            this.lueUnidad.Properties.ValueMember = "Oid";
            this.lueUnidad.Size = new System.Drawing.Size(590, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 7;
            // 
            // rgServicios
            // 
            this.rgServicios.Location = new System.Drawing.Point(24, 167);
            this.rgServicios.MenuManager = this.ribbonControl1;
            this.rgServicios.Name = "rgServicios";
            this.rgServicios.Properties.Columns = 3;
            this.rgServicios.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Compostura"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Cambio de aceite"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Lavado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(3)), "Otro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(4)), "Todos")});
            this.rgServicios.Size = new System.Drawing.Size(590, 41);
            this.rgServicios.StyleController = this.lcMain;
            this.rgServicios.TabIndex = 6;
            // 
            // dteAl
            // 
            this.dteAl.EditValue = null;
            this.dteAl.Location = new System.Drawing.Point(410, 42);
            this.dteAl.MenuManager = this.ribbonControl1;
            this.dteAl.Name = "dteAl";
            this.dteAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAl.Properties.DisplayFormat.FormatString = "D";
            this.dteAl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteAl.Properties.Mask.EditMask = "D";
            this.dteAl.Size = new System.Drawing.Size(204, 20);
            this.dteAl.StyleController = this.lcMain;
            this.dteAl.TabIndex = 5;
            // 
            // dteDel
            // 
            this.dteDel.EditValue = null;
            this.dteDel.Location = new System.Drawing.Point(114, 42);
            this.dteDel.MenuManager = this.ribbonControl1;
            this.dteDel.Name = "dteDel";
            this.dteDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDel.Properties.DisplayFormat.FormatString = "D";
            this.dteDel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDel.Properties.Mask.EditMask = "D";
            this.dteDel.Size = new System.Drawing.Size(202, 20);
            this.dteDel.StyleController = this.lcMain;
            this.dteDel.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgCriteriosBusqueda});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 248);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgCriteriosBusqueda
            // 
            this.lcgCriteriosBusqueda.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFechaDel,
            this.lciServicio,
            this.lciFechaAl,
            this.emptySpaceItem1,
            this.lciUnidad,
            this.lciCantidadUnidad});
            this.lcgCriteriosBusqueda.Location = new System.Drawing.Point(0, 0);
            this.lcgCriteriosBusqueda.Name = "lcgCriteriosBusqueda";
            this.lcgCriteriosBusqueda.Size = new System.Drawing.Size(618, 228);
            this.lcgCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // lciFechaDel
            // 
            this.lciFechaDel.Control = this.dteDel;
            this.lciFechaDel.Location = new System.Drawing.Point(0, 0);
            this.lciFechaDel.Name = "lciFechaDel";
            this.lciFechaDel.Size = new System.Drawing.Size(296, 24);
            this.lciFechaDel.Text = "Del:";
            this.lciFechaDel.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciServicio
            // 
            this.lciServicio.Control = this.rgServicios;
            this.lciServicio.Location = new System.Drawing.Point(0, 109);
            this.lciServicio.Name = "lciServicio";
            this.lciServicio.Size = new System.Drawing.Size(594, 61);
            this.lciServicio.Text = "Servicio:";
            this.lciServicio.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciServicio.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciFechaAl
            // 
            this.lciFechaAl.Control = this.dteAl;
            this.lciFechaAl.Location = new System.Drawing.Point(296, 0);
            this.lciFechaAl.Name = "lciFechaAl";
            this.lciFechaAl.Size = new System.Drawing.Size(298, 24);
            this.lciFechaAl.Text = "Al:";
            this.lciFechaAl.TextSize = new System.Drawing.Size(87, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 175);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(594, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 69);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(594, 40);
            this.lciUnidad.Text = "Unidad específica:";
            this.lciUnidad.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciUnidad.TextSize = new System.Drawing.Size(87, 13);
            this.lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciCantidadUnidad
            // 
            this.lciCantidadUnidad.Control = this.rgCantidadUnidad;
            this.lciCantidadUnidad.Location = new System.Drawing.Point(0, 24);
            this.lciCantidadUnidad.MaxSize = new System.Drawing.Size(0, 45);
            this.lciCantidadUnidad.MinSize = new System.Drawing.Size(91, 45);
            this.lciCantidadUnidad.Name = "lciCantidadUnidad";
            this.lciCantidadUnidad.Size = new System.Drawing.Size(594, 45);
            this.lciCantidadUnidad.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCantidadUnidad.Text = "Unidad:";
            this.lciCantidadUnidad.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCantidadUnidad.TextSize = new System.Drawing.Size(87, 13);
            // 
            // xfrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 370);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmServicios";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Filtro de servicios";
            this.Load += new System.EventHandler(this.xfrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgCantidadUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgServicios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCriteriosBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFechaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCantidadUnidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.RadioGroup rgServicios;
        private DevExpress.XtraEditors.DateEdit dteAl;
        private DevExpress.XtraEditors.DateEdit dteDel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaDel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciFechaAl;
        private DevExpress.XtraLayout.LayoutControlItem lciServicio;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCriteriosBusqueda;
        private DevExpress.XtraEditors.RadioGroup rgCantidadUnidad;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciCantidadUnidad;
    }
}