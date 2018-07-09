namespace UNIDADES.WIN
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
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtMillas = new DevExpress.XtraEditors.TextEdit();
            this.memoDetalles = new DevExpress.XtraEditors.MemoEdit();
            this.rgTipoServicio = new DevExpress.XtraEditors.RadioGroup();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciServicio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDetalles = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMillas = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMillas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDetalles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillas)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(347, 122);
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
            this.rpgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.rpgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtMillas);
            this.lcMain.Controls.Add(this.memoDetalles);
            this.lcMain.Controls.Add(this.rgTipoServicio);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(347, 280);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtMillas
            // 
            this.txtMillas.Location = new System.Drawing.Point(93, 111);
            this.txtMillas.MenuManager = this.ribbonControl1;
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(242, 20);
            this.txtMillas.StyleController = this.lcMain;
            this.txtMillas.TabIndex = 8;
            // 
            // memoDetalles
            // 
            this.memoDetalles.Location = new System.Drawing.Point(12, 151);
            this.memoDetalles.MenuManager = this.ribbonControl1;
            this.memoDetalles.Name = "memoDetalles";
            this.memoDetalles.Size = new System.Drawing.Size(323, 117);
            this.memoDetalles.StyleController = this.lcMain;
            this.memoDetalles.TabIndex = 7;
            // 
            // rgTipoServicio
            // 
            this.rgTipoServicio.Location = new System.Drawing.Point(93, 60);
            this.rgTipoServicio.MenuManager = this.ribbonControl1;
            this.rgTipoServicio.Name = "rgTipoServicio";
            this.rgTipoServicio.Size = new System.Drawing.Size(242, 47);
            this.rgTipoServicio.StyleController = this.lcMain;
            this.rgTipoServicio.TabIndex = 6;
            this.rgTipoServicio.SelectedIndexChanged += new System.EventHandler(this.rgTipoServicio_SelectedIndexChanged);
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(93, 36);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.NullText = "[SELECCIONE]";
            this.lueUnidad.Size = new System.Drawing.Size(242, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 5;
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(93, 12);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Size = new System.Drawing.Size(242, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFecha,
            this.lciUnidad,
            this.lciServicio,
            this.lciDetalles,
            this.lciMillas});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(347, 280);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(327, 24);
            this.lciFecha.Text = "Fecha:";
            this.lciFecha.TextSize = new System.Drawing.Size(78, 13);
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 24);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(327, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(78, 13);
            // 
            // lciServicio
            // 
            this.lciServicio.Control = this.rgTipoServicio;
            this.lciServicio.Location = new System.Drawing.Point(0, 48);
            this.lciServicio.Name = "lciServicio";
            this.lciServicio.Size = new System.Drawing.Size(327, 51);
            this.lciServicio.Text = "Tipo de servicio:";
            this.lciServicio.TextSize = new System.Drawing.Size(78, 13);
            // 
            // lciDetalles
            // 
            this.lciDetalles.Control = this.memoDetalles;
            this.lciDetalles.Location = new System.Drawing.Point(0, 123);
            this.lciDetalles.Name = "lciDetalles";
            this.lciDetalles.Size = new System.Drawing.Size(327, 137);
            this.lciDetalles.Text = "Detalles";
            this.lciDetalles.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDetalles.TextSize = new System.Drawing.Size(78, 13);
            // 
            // lciMillas
            // 
            this.lciMillas.Control = this.txtMillas;
            this.lciMillas.Location = new System.Drawing.Point(0, 99);
            this.lciMillas.Name = "lciMillas";
            this.lciMillas.Size = new System.Drawing.Size(327, 24);
            this.lciMillas.Text = "Millas:";
            this.lciMillas.TextSize = new System.Drawing.Size(78, 13);
            this.lciMillas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xfrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 402);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmServicios";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.xfrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMillas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDetalles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.MemoEdit memoDetalles;
        private DevExpress.XtraEditors.RadioGroup rgTipoServicio;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraLayout.LayoutControlItem lciServicio;
        private DevExpress.XtraLayout.LayoutControlItem lciDetalles;
        private DevExpress.XtraEditors.TextEdit txtMillas;
        private DevExpress.XtraLayout.LayoutControlItem lciMillas;
    }
}