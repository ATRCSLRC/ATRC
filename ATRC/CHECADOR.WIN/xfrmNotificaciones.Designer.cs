namespace CHECADOR.WIN
{
    partial class xfrmNotificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmNotificaciones));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.memoMotivo = new DevExpress.XtraEditors.MemoEdit();
            this.lueResponsable = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnNumUsuario = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNumUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmisor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMotivo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotivo)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(522, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.LargeImage = global::CHECADOR.WIN.Properties.Resources.Guardar;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.LargeImage = global::CHECADOR.WIN.Properties.Resources.Cancelar;
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
            this.lcMain.Controls.Add(this.memoMotivo);
            this.lcMain.Controls.Add(this.lueResponsable);
            this.lcMain.Controls.Add(this.txtNombre);
            this.lcMain.Controls.Add(this.btnNumUsuario);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(522, 210);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // memoMotivo
            // 
            this.memoMotivo.EnterMoveNextControl = true;
            this.memoMotivo.Location = new System.Drawing.Point(94, 60);
            this.memoMotivo.MenuManager = this.ribbonControl1;
            this.memoMotivo.Name = "memoMotivo";
            this.memoMotivo.Size = new System.Drawing.Size(416, 138);
            this.memoMotivo.StyleController = this.lcMain;
            this.memoMotivo.TabIndex = 7;
            // 
            // lueResponsable
            // 
            this.lueResponsable.EnterMoveNextControl = true;
            this.lueResponsable.Location = new System.Drawing.Point(94, 36);
            this.lueResponsable.MenuManager = this.ribbonControl1;
            this.lueResponsable.Name = "lueResponsable";
            this.lueResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueResponsable.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueResponsable.Properties.DisplayMember = "Nombre";
            this.lueResponsable.Properties.NullText = "[Seleccione]";
            this.lueResponsable.Size = new System.Drawing.Size(416, 20);
            this.lueResponsable.StyleController = this.lcMain;
            this.lueResponsable.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(276, 12);
            this.txtNombre.MenuManager = this.ribbonControl1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.StyleController = this.lcMain;
            this.txtNombre.TabIndex = 5;
            // 
            // btnNumUsuario
            // 
            this.btnNumUsuario.Location = new System.Drawing.Point(94, 12);
            this.btnNumUsuario.MenuManager = this.ribbonControl1;
            this.btnNumUsuario.Name = "btnNumUsuario";
            this.btnNumUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnNumUsuario.Properties.Mask.EditMask = "\\d{1,10}";
            this.btnNumUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.btnNumUsuario.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnNumUsuario_Properties_ButtonClick);
            this.btnNumUsuario.Size = new System.Drawing.Size(96, 20);
            this.btnNumUsuario.StyleController = this.lcMain;
            this.btnNumUsuario.TabIndex = 4;
            this.btnNumUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNumUsuario_KeyDown);
            this.btnNumUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnNumUsuario_KeyUp);
            this.btnNumUsuario.Leave += new System.EventHandler(this.btnNumUsuario_Leave);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNumUsuario,
            this.lciNombre,
            this.lciEmisor,
            this.lciMotivo});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(522, 210);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciNumUsuario
            // 
            this.lciNumUsuario.Control = this.btnNumUsuario;
            this.lciNumUsuario.Location = new System.Drawing.Point(0, 0);
            this.lciNumUsuario.Name = "lciNumUsuario";
            this.lciNumUsuario.Size = new System.Drawing.Size(182, 24);
            this.lciNumUsuario.Text = "Número usuario:";
            this.lciNumUsuario.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciNombre
            // 
            this.lciNombre.Control = this.txtNombre;
            this.lciNombre.Location = new System.Drawing.Point(182, 0);
            this.lciNombre.Name = "lciNombre";
            this.lciNombre.Size = new System.Drawing.Size(320, 24);
            this.lciNombre.Text = "Nombre:";
            this.lciNombre.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciEmisor
            // 
            this.lciEmisor.Control = this.lueResponsable;
            this.lciEmisor.Location = new System.Drawing.Point(0, 24);
            this.lciEmisor.Name = "lciEmisor";
            this.lciEmisor.Size = new System.Drawing.Size(502, 24);
            this.lciEmisor.Text = "Pasar con:";
            this.lciEmisor.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciMotivo
            // 
            this.lciMotivo.Control = this.memoMotivo;
            this.lciMotivo.Location = new System.Drawing.Point(0, 48);
            this.lciMotivo.Name = "lciMotivo";
            this.lciMotivo.Size = new System.Drawing.Size(502, 142);
            this.lciMotivo.Text = "Motivo:";
            this.lciMotivo.TextSize = new System.Drawing.Size(79, 13);
            // 
            // xfrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 332);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmNotificaciones";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.xfrmNotificaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmNotificaciones_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotivo)).EndInit();
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
        private DevExpress.XtraEditors.MemoEdit memoMotivo;
        private DevExpress.XtraEditors.LookUpEdit lueResponsable;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.ButtonEdit btnNumUsuario;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciNumUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciNombre;
        private DevExpress.XtraLayout.LayoutControlItem lciEmisor;
        private DevExpress.XtraLayout.LayoutControlItem lciMotivo;
    }
}