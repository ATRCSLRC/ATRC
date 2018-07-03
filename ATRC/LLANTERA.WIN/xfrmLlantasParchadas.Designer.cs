namespace LLANTERA.WIN
{
    partial class xfrmLlantasParchadas
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.memoDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.cmbCambioLlanta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPosicionLlanta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCambioLlanta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPosicionLlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.memoDescripcion);
            this.lcMain.Controls.Add(this.cmbCambioLlanta);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(433, 276);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Location = new System.Drawing.Point(12, 134);
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Size = new System.Drawing.Size(409, 130);
            this.memoDescripcion.StyleController = this.lcMain;
            this.memoDescripcion.TabIndex = 6;
            // 
            // cmbCambioLlanta
            // 
            this.cmbCambioLlanta.Location = new System.Drawing.Point(12, 94);
            this.cmbCambioLlanta.Name = "cmbCambioLlanta";
            this.cmbCambioLlanta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCambioLlanta.Size = new System.Drawing.Size(409, 20);
            this.cmbCambioLlanta.StyleController = this.lcMain;
            this.cmbCambioLlanta.TabIndex = 5;
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(24, 42);
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.DisplayMember = "Nombre";
            this.lueUnidad.Properties.NullText = "[Seleccioné]";
            this.lueUnidad.Size = new System.Drawing.Size(385, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 4;
            this.lueUnidad.EditValueChanged += new System.EventHandler(this.lueUnidad_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPosicionLlanta,
            this.lciDescripcion,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(433, 276);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciPosicionLlanta
            // 
            this.lciPosicionLlanta.Control = this.cmbCambioLlanta;
            this.lciPosicionLlanta.Location = new System.Drawing.Point(0, 66);
            this.lciPosicionLlanta.Name = "lciPosicionLlanta";
            this.lciPosicionLlanta.Size = new System.Drawing.Size(413, 40);
            this.lciPosicionLlanta.Text = "Posición de llanta:";
            this.lciPosicionLlanta.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPosicionLlanta.TextSize = new System.Drawing.Size(122, 13);
            // 
            // lciDescripcion
            // 
            this.lciDescripcion.Control = this.memoDescripcion;
            this.lciDescripcion.Location = new System.Drawing.Point(0, 106);
            this.lciDescripcion.Name = "lciDescripcion";
            this.lciDescripcion.Size = new System.Drawing.Size(413, 150);
            this.lciDescripcion.Text = "Descripción del problema:";
            this.lciDescripcion.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDescripcion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUnidad});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(413, 66);
            this.layoutControlGroup2.Text = "Seleccioné la unidad:";
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 0);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(389, 24);
            this.lciUnidad.Text = "Seleccioné la unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(0, 0);
            this.lciUnidad.TextVisible = false;
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
            this.ribbonControl1.Size = new System.Drawing.Size(433, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = global::LLANTERA.WIN.Properties.Resources.icons8_guardar_32;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = global::LLANTERA.WIN.Properties.Resources.icons8_eliminar_32;
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
            // xfrmLlantasParchadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 398);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmLlantasParchadas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Llantas parchadas";
            this.Load += new System.EventHandler(this.xfrmLlantasParchadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCambioLlanta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPosicionLlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.MemoEdit memoDescripcion;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCambioLlanta;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciPosicionLlanta;
        private DevExpress.XtraLayout.LayoutControlItem lciDescripcion;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
    }
}