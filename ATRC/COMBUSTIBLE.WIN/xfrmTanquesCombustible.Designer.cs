namespace COMBUSTIBLE.WIN
{
    partial class xfrmTanquesCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTanquesCombustible));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.spnCapacidad = new DevExpress.XtraEditors.SpinEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCapacidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgTipoCombustible = new DevExpress.XtraEditors.RadioGroup();
            this.lciCombustible = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCapacidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCombustible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCombustible)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(362, 122);
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
            this.lcMain.Controls.Add(this.rgTipoCombustible);
            this.lcMain.Controls.Add(this.spnCapacidad);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(362, 156);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // spnCapacidad
            // 
            this.spnCapacidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCapacidad.EnterMoveNextControl = true;
            this.spnCapacidad.Location = new System.Drawing.Point(12, 112);
            this.spnCapacidad.MenuManager = this.ribbonControl1;
            this.spnCapacidad.Name = "spnCapacidad";
            this.spnCapacidad.Properties.MaxLength = 99999999;
            this.spnCapacidad.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.spnCapacidad.Size = new System.Drawing.Size(338, 20);
            this.spnCapacidad.StyleController = this.lcMain;
            this.spnCapacidad.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(12, 28);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNombre,
            this.lciCapacidad,
            this.lciCombustible});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(362, 156);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(0, 0);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(342, 40);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNombre.TextSize = new System.Drawing.Size(98, 13);
            // 
            // lciCapacidad
            // 
            this.lciCapacidad.Control = this.spnCapacidad;
            this.lciCapacidad.Location = new System.Drawing.Point(0, 84);
            this.lciCapacidad.Name = "lciCapacidad";
            this.lciCapacidad.Size = new System.Drawing.Size(342, 52);
            this.lciCapacidad.Text = "Capacidad:";
            this.lciCapacidad.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCapacidad.TextSize = new System.Drawing.Size(98, 13);
            // 
            // rgTipoCombustible
            // 
            this.rgTipoCombustible.EnterMoveNextControl = true;
            this.rgTipoCombustible.Location = new System.Drawing.Point(12, 68);
            this.rgTipoCombustible.MenuManager = this.ribbonControl1;
            this.rgTipoCombustible.Name = "rgTipoCombustible";
            this.rgTipoCombustible.Size = new System.Drawing.Size(338, 24);
            this.rgTipoCombustible.StyleController = this.lcMain;
            this.rgTipoCombustible.TabIndex = 7;
            // 
            // lciCombustible
            // 
            this.lciCombustible.Control = this.rgTipoCombustible;
            this.lciCombustible.Location = new System.Drawing.Point(0, 40);
            this.lciCombustible.MaxSize = new System.Drawing.Size(0, 44);
            this.lciCombustible.MinSize = new System.Drawing.Size(97, 44);
            this.lciCombustible.Name = "lciCombustible";
            this.lciCombustible.Size = new System.Drawing.Size(342, 44);
            this.lciCombustible.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCombustible.Text = "Tipo de combustible:";
            this.lciCombustible.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCombustible.TextSize = new System.Drawing.Size(98, 13);
            // 
            // xfrmTanquesCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 278);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmTanquesCombustible";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Tanque de combustible";
            this.Load += new System.EventHandler(this.xfrmDepartamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmTanquesCombustible_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnCapacidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCombustible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.SpinEdit spnCapacidad;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciCapacidad;
        private DevExpress.XtraEditors.RadioGroup rgTipoCombustible;
        private DevExpress.XtraLayout.LayoutControlItem lciCombustible;
    }
}