namespace RUTAS.WIN.Catalogos
{
    partial class xfrmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmServicio));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.chkMediaVuelta = new DevExpress.XtraEditors.CheckEdit();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoUnidad = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChk = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkMediaVuelta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChk)).BeginInit();
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
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(313, 122);
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
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = " ";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.chkMediaVuelta);
            this.lcMain.Controls.Add(this.txtClave);
            this.lcMain.Controls.Add(this.cmbTipoUnidad);
            this.lcMain.Controls.Add(this.txtDescripcion);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(52, 365, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(313, 100);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // chkMediaVuelta
            // 
            this.chkMediaVuelta.EnterMoveNextControl = true;
            this.chkMediaVuelta.Location = new System.Drawing.Point(168, 12);
            this.chkMediaVuelta.MenuManager = this.ribbonControl1;
            this.chkMediaVuelta.Name = "chkMediaVuelta";
            this.chkMediaVuelta.Properties.Caption = "Media vuelta";
            this.chkMediaVuelta.Size = new System.Drawing.Size(133, 19);
            this.chkMediaVuelta.StyleController = this.lcMain;
            this.chkMediaVuelta.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.EnterMoveNextControl = true;
            this.txtClave.Location = new System.Drawing.Point(89, 12);
            this.txtClave.MenuManager = this.ribbonControl1;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(75, 20);
            this.txtClave.StyleController = this.lcMain;
            this.txtClave.TabIndex = 6;
            // 
            // cmbTipoUnidad
            // 
            this.cmbTipoUnidad.Location = new System.Drawing.Point(89, 60);
            this.cmbTipoUnidad.MenuManager = this.ribbonControl1;
            this.cmbTipoUnidad.Name = "cmbTipoUnidad";
            this.cmbTipoUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoUnidad.Size = new System.Drawing.Size(212, 20);
            this.cmbTipoUnidad.StyleController = this.lcMain;
            this.cmbTipoUnidad.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EnterMoveNextControl = true;
            this.txtDescripcion.Location = new System.Drawing.Point(89, 36);
            this.txtDescripcion.MenuManager = this.ribbonControl1;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 20);
            this.txtDescripcion.StyleController = this.lcMain;
            this.txtDescripcion.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDescripcion,
            this.lciTipoUnidad,
            this.lciClave,
            this.lciChk});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(313, 100);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciDescripcion
            // 
            this.lciDescripcion.Control = this.txtDescripcion;
            this.lciDescripcion.Location = new System.Drawing.Point(0, 24);
            this.lciDescripcion.Name = "lciDescripcion";
            this.lciDescripcion.Size = new System.Drawing.Size(293, 24);
            this.lciDescripcion.Text = "Descripción:";
            this.lciDescripcion.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lciTipoUnidad
            // 
            this.lciTipoUnidad.Control = this.cmbTipoUnidad;
            this.lciTipoUnidad.Location = new System.Drawing.Point(0, 48);
            this.lciTipoUnidad.Name = "lciTipoUnidad";
            this.lciTipoUnidad.Size = new System.Drawing.Size(293, 32);
            this.lciTipoUnidad.Text = "Tipo de unidad:";
            this.lciTipoUnidad.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lciClave
            // 
            this.lciClave.Control = this.txtClave;
            this.lciClave.Location = new System.Drawing.Point(0, 0);
            this.lciClave.Name = "lciClave";
            this.lciClave.Size = new System.Drawing.Size(156, 24);
            this.lciClave.Text = "Clave:";
            this.lciClave.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lciChk
            // 
            this.lciChk.Control = this.chkMediaVuelta;
            this.lciChk.Location = new System.Drawing.Point(156, 0);
            this.lciChk.Name = "lciChk";
            this.lciChk.Size = new System.Drawing.Size(137, 24);
            this.lciChk.TextSize = new System.Drawing.Size(0, 0);
            this.lciChk.TextVisible = false;
            // 
            // xfrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 222);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmServicio";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.xfrmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkMediaVuelta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoUnidad;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem lciDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoUnidad;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraLayout.LayoutControlItem lciClave;
        private DevExpress.XtraEditors.CheckEdit chkMediaVuelta;
        private DevExpress.XtraLayout.LayoutControlItem lciChk;
    }
}