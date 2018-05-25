namespace UNIDADES.WIN
{
    partial class xfrmRadios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRadios));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.rgDestino = new DevExpress.XtraEditors.RadioGroup();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMarca = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciModelo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSerie = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTipoDestino = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.lciUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(450, 122);
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
            this.lcMain.Controls.Add(this.lueUsuario);
            this.lcMain.Controls.Add(this.lueUnidad);
            this.lcMain.Controls.Add(this.rgDestino);
            this.lcMain.Controls.Add(this.txtSerie);
            this.lcMain.Controls.Add(this.txtModelo);
            this.lcMain.Controls.Add(this.txtMarca);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(502, 34, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(450, 191);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // lueUnidad
            // 
            this.lueUnidad.Location = new System.Drawing.Point(92, 101);
            this.lueUnidad.MenuManager = this.ribbonControl1;
            this.lueUnidad.Name = "lueUnidad";
            this.lueUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUnidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueUnidad.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueUnidad.Properties.NullText = "[SELECCIONE]";
            this.lueUnidad.Size = new System.Drawing.Size(346, 20);
            this.lueUnidad.StyleController = this.lcMain;
            this.lueUnidad.TabIndex = 8;
            // 
            // rgDestino
            // 
            this.rgDestino.Location = new System.Drawing.Point(92, 84);
            this.rgDestino.MenuManager = this.ribbonControl1;
            this.rgDestino.Name = "rgDestino";
            this.rgDestino.Properties.Columns = 2;
            this.rgDestino.Size = new System.Drawing.Size(346, 13);
            this.rgDestino.StyleController = this.lcMain;
            this.rgDestino.TabIndex = 7;
            this.rgDestino.SelectedIndexChanged += new System.EventHandler(this.rgDestino_SelectedIndexChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(92, 60);
            this.txtSerie.MenuManager = this.ribbonControl1;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Size = new System.Drawing.Size(346, 20);
            this.txtSerie.StyleController = this.lcMain;
            this.txtSerie.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(92, 36);
            this.txtModelo.MenuManager = this.ribbonControl1;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Size = new System.Drawing.Size(346, 20);
            this.txtModelo.StyleController = this.lcMain;
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(92, 12);
            this.txtMarca.MenuManager = this.ribbonControl1;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Size = new System.Drawing.Size(346, 20);
            this.txtMarca.StyleController = this.lcMain;
            this.txtMarca.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMarca,
            this.emptySpaceItem1,
            this.lciModelo,
            this.lciSerie,
            this.lciTipoDestino,
            this.lciUnidad,
            this.lciUsuario});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 191);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciMarca
            // 
            this.lciMarca.Control = this.txtMarca;
            this.lciMarca.Location = new System.Drawing.Point(0, 0);
            this.lciMarca.Name = "lciMarca";
            this.lciMarca.Size = new System.Drawing.Size(430, 24);
            this.lciMarca.Text = "Marca:";
            this.lciMarca.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 137);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(430, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciModelo
            // 
            this.lciModelo.Control = this.txtModelo;
            this.lciModelo.Location = new System.Drawing.Point(0, 24);
            this.lciModelo.Name = "lciModelo";
            this.lciModelo.Size = new System.Drawing.Size(430, 24);
            this.lciModelo.Text = "Modelo:";
            this.lciModelo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciSerie
            // 
            this.lciSerie.Control = this.txtSerie;
            this.lciSerie.Location = new System.Drawing.Point(0, 48);
            this.lciSerie.Name = "lciSerie";
            this.lciSerie.Size = new System.Drawing.Size(430, 24);
            this.lciSerie.Text = "Serie:";
            this.lciSerie.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciTipoDestino
            // 
            this.lciTipoDestino.Control = this.rgDestino;
            this.lciTipoDestino.Location = new System.Drawing.Point(0, 72);
            this.lciTipoDestino.Name = "lciTipoDestino";
            this.lciTipoDestino.Size = new System.Drawing.Size(430, 17);
            this.lciTipoDestino.Text = "Tipo de destino:";
            this.lciTipoDestino.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciUnidad
            // 
            this.lciUnidad.Control = this.lueUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 89);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(430, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lueUsuario
            // 
            this.lueUsuario.Location = new System.Drawing.Point(92, 125);
            this.lueUsuario.MenuManager = this.ribbonControl1;
            this.lueUsuario.Name = "lueUsuario";
            this.lueUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueUsuario.Properties.NullText = "[SELECCIONE]";
            this.lueUsuario.Size = new System.Drawing.Size(346, 20);
            this.lueUsuario.StyleController = this.lcMain;
            this.lueUsuario.TabIndex = 10;
            // 
            // lciUsuario
            // 
            this.lciUsuario.Control = this.lueUsuario;
            this.lciUsuario.Location = new System.Drawing.Point(0, 113);
            this.lciUsuario.Name = "lciUsuario";
            this.lciUsuario.Size = new System.Drawing.Size(430, 24);
            this.lciUsuario.Text = "Usuario:";
            this.lciUsuario.TextSize = new System.Drawing.Size(77, 13);
            // 
            // xfrmRadios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 313);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmRadios";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Radios";
            this.Load += new System.EventHandler(this.xfrmRadios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.LookUpEdit lueUnidad;
        private DevExpress.XtraEditors.RadioGroup rgDestino;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciMarca;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciModelo;
        private DevExpress.XtraLayout.LayoutControlItem lciSerie;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoDestino;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.LookUpEdit lueUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciUsuario;
    }
}