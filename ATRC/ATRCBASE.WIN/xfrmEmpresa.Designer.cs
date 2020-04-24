namespace ATRCBASE.WIN
{
    partial class xfrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmEmpresa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.spnIva = new DevExpress.XtraEditors.SpinEdit();
            this.txtNombreOficial = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtLocacion = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRFC = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDireccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLocacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNombreOficial = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIva = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOficial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreOficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIva)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(460, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.Guardar;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.Cancelar;
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
            this.lcMain.Controls.Add(this.spnIva);
            this.lcMain.Controls.Add(this.txtNombreOficial);
            this.lcMain.Controls.Add(this.txtTel);
            this.lcMain.Controls.Add(this.txtLocacion);
            this.lcMain.Controls.Add(this.txtDireccion);
            this.lcMain.Controls.Add(this.txtRFC);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Controls.Add(this.txtClave);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(512, 14, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(460, 194);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // spnIva
            // 
            this.spnIva.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnIva.Location = new System.Drawing.Point(368, 12);
            this.spnIva.MenuManager = this.ribbonControl1;
            this.spnIva.Name = "spnIva";
            this.spnIva.Properties.DisplayFormat.FormatString = "p";
            this.spnIva.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnIva.Properties.EditFormat.FormatString = "p";
            this.spnIva.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnIva.Properties.Mask.EditMask = "p";
            this.spnIva.Size = new System.Drawing.Size(80, 20);
            this.spnIva.StyleController = this.lcMain;
            this.spnIva.TabIndex = 13;
            // 
            // txtNombreOficial
            // 
            this.txtNombreOficial.EnterMoveNextControl = true;
            this.txtNombreOficial.Location = new System.Drawing.Point(86, 60);
            this.txtNombreOficial.MenuManager = this.ribbonControl1;
            this.txtNombreOficial.Name = "txtNombreOficial";
            this.txtNombreOficial.Size = new System.Drawing.Size(362, 20);
            this.txtNombreOficial.StyleController = this.lcMain;
            this.txtNombreOficial.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.EnterMoveNextControl = true;
            this.txtTel.Location = new System.Drawing.Point(86, 156);
            this.txtTel.MenuManager = this.ribbonControl1;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(362, 20);
            this.txtTel.StyleController = this.lcMain;
            this.txtTel.TabIndex = 11;
            // 
            // txtLocacion
            // 
            this.txtLocacion.EnterMoveNextControl = true;
            this.txtLocacion.Location = new System.Drawing.Point(86, 132);
            this.txtLocacion.MenuManager = this.ribbonControl1;
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(362, 20);
            this.txtLocacion.StyleController = this.lcMain;
            this.txtLocacion.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.EnterMoveNextControl = true;
            this.txtDireccion.Location = new System.Drawing.Point(86, 108);
            this.txtDireccion.MenuManager = this.ribbonControl1;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(362, 20);
            this.txtDireccion.StyleController = this.lcMain;
            this.txtDireccion.TabIndex = 9;
            // 
            // txtRFC
            // 
            this.txtRFC.EnterMoveNextControl = true;
            this.txtRFC.Location = new System.Drawing.Point(86, 84);
            this.txtRFC.MenuManager = this.ribbonControl1;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(362, 20);
            this.txtRFC.StyleController = this.lcMain;
            this.txtRFC.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(86, 36);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.EnterMoveNextControl = true;
            this.txtClave.Location = new System.Drawing.Point(86, 12);
            this.txtClave.MenuManager = this.ribbonControl1;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(143, 20);
            this.txtClave.StyleController = this.lcMain;
            this.txtClave.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClave,
            this.lciNombre,
            this.lciRFC,
            this.lciDireccion,
            this.lciLocacion,
            this.lciTel,
            this.emptySpaceItem1,
            this.lciNombreOficial,
            this.lciIva});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(460, 194);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciClave
            // 
            this.lciClave.Control = this.txtClave;
            this.lciClave.Location = new System.Drawing.Point(0, 0);
            this.lciClave.Name = "lciClave";
            this.lciClave.Size = new System.Drawing.Size(221, 24);
            this.lciClave.Text = "Clave:";
            this.lciClave.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(0, 24);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(440, 24);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciRFC
            // 
            this.lciRFC.Control = this.txtRFC;
            this.lciRFC.Location = new System.Drawing.Point(0, 72);
            this.lciRFC.Name = "lciRFC";
            this.lciRFC.Size = new System.Drawing.Size(440, 24);
            this.lciRFC.Text = "RFC:";
            this.lciRFC.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciDireccion
            // 
            this.lciDireccion.Control = this.txtDireccion;
            this.lciDireccion.Location = new System.Drawing.Point(0, 96);
            this.lciDireccion.Name = "lciDireccion";
            this.lciDireccion.Size = new System.Drawing.Size(440, 24);
            this.lciDireccion.Text = "Dirección:";
            this.lciDireccion.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciLocacion
            // 
            this.lciLocacion.Control = this.txtLocacion;
            this.lciLocacion.Location = new System.Drawing.Point(0, 120);
            this.lciLocacion.Name = "lciLocacion";
            this.lciLocacion.Size = new System.Drawing.Size(440, 24);
            this.lciLocacion.Text = "Locacion:";
            this.lciLocacion.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciTel
            // 
            this.lciTel.Control = this.txtTel;
            this.lciTel.Location = new System.Drawing.Point(0, 144);
            this.lciTel.Name = "lciTel";
            this.lciTel.Size = new System.Drawing.Size(440, 30);
            this.lciTel.Text = "Tel:";
            this.lciTel.TextSize = new System.Drawing.Size(71, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(221, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(109, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNombreOficial
            // 
            this.lciNombreOficial.Control = this.txtNombreOficial;
            this.lciNombreOficial.Location = new System.Drawing.Point(0, 48);
            this.lciNombreOficial.Name = "lciNombreOficial";
            this.lciNombreOficial.Size = new System.Drawing.Size(440, 24);
            this.lciNombreOficial.Text = "Nombre oficial:";
            this.lciNombreOficial.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciIva
            // 
            this.lciIva.Control = this.spnIva;
            this.lciIva.Location = new System.Drawing.Point(330, 0);
            this.lciIva.Name = "lciIva";
            this.lciIva.Size = new System.Drawing.Size(110, 24);
            this.lciIva.Text = "IVA:";
            this.lciIva.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciIva.TextSize = new System.Drawing.Size(21, 13);
            this.lciIva.TextToControlDistance = 5;
            // 
            // xfrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 316);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmEmpresa";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.xfrmPuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOficial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreOficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIva)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraLayout.LayoutControlItem lciClave;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtLocacion;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciRFC;
        private DevExpress.XtraLayout.LayoutControlItem lciDireccion;
        private DevExpress.XtraLayout.LayoutControlItem lciLocacion;
        private DevExpress.XtraLayout.LayoutControlItem lciTel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtNombreOficial;
        private DevExpress.XtraLayout.LayoutControlItem lciNombreOficial;
        private DevExpress.XtraEditors.SpinEdit spnIva;
        private DevExpress.XtraLayout.LayoutControlItem lciIva;
    }
}