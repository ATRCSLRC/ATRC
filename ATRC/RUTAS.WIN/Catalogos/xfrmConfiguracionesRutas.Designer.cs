namespace RUTAS.WIN
{
    partial class xfrmConfiguracionesRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmConfiguracionesRutas));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.tknCorreosEncargados = new DevExpress.XtraEditors.TokenEdit();
            this.spnDiasHabiles = new DevExpress.XtraEditors.SpinEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.tknRecibir = new DevExpress.XtraEditors.TokenEdit();
            this.chkActivarSeguridad = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgModificacionRutas = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRecibir = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDiasHabiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgEncargados = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEncargosRutas = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tknCorreosEncargados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDiasHabiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknRecibir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivarSeguridad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgModificacionRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEncargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEncargosRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(684, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.tknCorreosEncargados);
            this.lcMain.Controls.Add(this.spnDiasHabiles);
            this.lcMain.Controls.Add(this.txtCodigo);
            this.lcMain.Controls.Add(this.tknRecibir);
            this.lcMain.Controls.Add(this.chkActivarSeguridad);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(17, 436, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(684, 231);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // tknCorreosEncargados
            // 
            this.tknCorreosEncargados.Location = new System.Drawing.Point(173, 162);
            this.tknCorreosEncargados.MenuManager = this.ribbonControl1;
            this.tknCorreosEncargados.Name = "tknCorreosEncargados";
            this.tknCorreosEncargados.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tknCorreosEncargados.Properties.Separators.AddRange(new string[] {
            ",",
            ";",
            " "});
            this.tknCorreosEncargados.Size = new System.Drawing.Size(487, 20);
            this.tknCorreosEncargados.StyleController = this.lcMain;
            this.tknCorreosEncargados.TabIndex = 8;
            this.tknCorreosEncargados.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tknCorreosEncargados_ValidateToken);
            this.tknCorreosEncargados.EditValueChanged += new System.EventHandler(this.tknCorreosEncargados_EditValueChanged);
            // 
            // spnDiasHabiles
            // 
            this.spnDiasHabiles.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDiasHabiles.Location = new System.Drawing.Point(493, 93);
            this.spnDiasHabiles.MenuManager = this.ribbonControl1;
            this.spnDiasHabiles.Name = "spnDiasHabiles";
            this.spnDiasHabiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnDiasHabiles.Size = new System.Drawing.Size(167, 20);
            this.spnDiasHabiles.StyleController = this.lcMain;
            this.spnDiasHabiles.TabIndex = 7;
            this.spnDiasHabiles.EditValueChanged += new System.EventHandler(this.spnDiasHabiles_EditValueChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 93);
            this.txtCodigo.MenuManager = this.ribbonControl1;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(216, 20);
            this.txtCodigo.StyleController = this.lcMain;
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.EditValueChanged += new System.EventHandler(this.txtCodigo_EditValueChanged);
            // 
            // tknRecibir
            // 
            this.tknRecibir.Location = new System.Drawing.Point(65, 69);
            this.tknRecibir.MenuManager = this.ribbonControl1;
            this.tknRecibir.Name = "tknRecibir";
            this.tknRecibir.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tknRecibir.Properties.Separators.AddRange(new string[] {
            ","});
            this.tknRecibir.Size = new System.Drawing.Size(595, 20);
            this.tknRecibir.StyleController = this.lcMain;
            this.tknRecibir.TabIndex = 5;
            this.tknRecibir.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tknRecibir_ValidateToken);
            this.tknRecibir.EditValueChanged += new System.EventHandler(this.tknRecibir_EditValueChanged);
            // 
            // chkActivarSeguridad
            // 
            this.chkActivarSeguridad.Location = new System.Drawing.Point(464, 45);
            this.chkActivarSeguridad.MenuManager = this.ribbonControl1;
            this.chkActivarSeguridad.Name = "chkActivarSeguridad";
            this.chkActivarSeguridad.Properties.Caption = "Activar seguridad modificación rutas";
            this.chkActivarSeguridad.Size = new System.Drawing.Size(196, 20);
            this.chkActivarSeguridad.StyleController = this.lcMain;
            this.chkActivarSeguridad.TabIndex = 4;
            this.chkActivarSeguridad.EditValueChanged += new System.EventHandler(this.chkActivarSeguridad_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lcgModificacionRutas,
            this.lcgEncargados});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(684, 231);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 186);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(664, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgModificacionRutas
            // 
            this.lcgModificacionRutas.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRecibir,
            this.lciDiasHabiles,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.lciCodigo});
            this.lcgModificacionRutas.Location = new System.Drawing.Point(0, 0);
            this.lcgModificacionRutas.Name = "lcgModificacionRutas";
            this.lcgModificacionRutas.Size = new System.Drawing.Size(664, 117);
            this.lcgModificacionRutas.Text = "Modificación de rutas";
            // 
            // lciRecibir
            // 
            this.lciRecibir.Control = this.tknRecibir;
            this.lciRecibir.Location = new System.Drawing.Point(0, 24);
            this.lciRecibir.Name = "lciRecibir";
            this.lciRecibir.Size = new System.Drawing.Size(640, 24);
            this.lciRecibir.Text = "Recibir:";
            this.lciRecibir.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciRecibir.TextSize = new System.Drawing.Size(36, 13);
            this.lciRecibir.TextToControlDistance = 5;
            // 
            // lciDiasHabiles
            // 
            this.lciDiasHabiles.Control = this.spnDiasHabiles;
            this.lciDiasHabiles.Location = new System.Drawing.Point(320, 48);
            this.lciDiasHabiles.Name = "lciDiasHabiles";
            this.lciDiasHabiles.Size = new System.Drawing.Size(320, 24);
            this.lciDiasHabiles.Text = "Días habiles para modificación:";
            this.lciDiasHabiles.TextSize = new System.Drawing.Size(146, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkActivarSeguridad;
            this.layoutControlItem1.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(440, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCodigo
            // 
            this.lciCodigo.Control = this.txtCodigo;
            this.lciCodigo.Location = new System.Drawing.Point(0, 48);
            this.lciCodigo.Name = "lciCodigo";
            this.lciCodigo.Size = new System.Drawing.Size(320, 24);
            this.lciCodigo.Text = "Código desbloqueo:";
            this.lciCodigo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciCodigo.TextSize = new System.Drawing.Size(95, 13);
            this.lciCodigo.TextToControlDistance = 5;
            // 
            // lcgEncargados
            // 
            this.lcgEncargados.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEncargosRutas});
            this.lcgEncargados.Location = new System.Drawing.Point(0, 117);
            this.lcgEncargados.Name = "lcgEncargados";
            this.lcgEncargados.Size = new System.Drawing.Size(664, 69);
            this.lcgEncargados.Text = "Encargados de rutas";
            // 
            // lciEncargosRutas
            // 
            this.lciEncargosRutas.Control = this.tknCorreosEncargados;
            this.lciEncargosRutas.Location = new System.Drawing.Point(0, 0);
            this.lciEncargosRutas.Name = "lciEncargosRutas";
            this.lciEncargosRutas.Size = new System.Drawing.Size(640, 24);
            this.lciEncargosRutas.Text = "Correos de encargados:";
            this.lciEncargosRutas.TextSize = new System.Drawing.Size(146, 13);
            // 
            // xfrmConfiguracionesRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 263);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmConfiguracionesRutas.IconOptions.Icon")));
            this.Name = "xfrmConfiguracionesRutas";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Configuraciones de rutas";
            this.Load += new System.EventHandler(this.xfrmConfiguracionesRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tknCorreosEncargados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDiasHabiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknRecibir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivarSeguridad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgModificacionRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecibir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEncargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEncargosRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TokenEdit tknCorreosEncargados;
        private DevExpress.XtraEditors.SpinEdit spnDiasHabiles;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TokenEdit tknRecibir;
        private DevExpress.XtraEditors.CheckEdit chkActivarSeguridad;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgModificacionRutas;
        private DevExpress.XtraLayout.LayoutControlItem lciRecibir;
        private DevExpress.XtraLayout.LayoutControlItem lciDiasHabiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciCodigo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgEncargados;
        private DevExpress.XtraLayout.LayoutControlItem lciEncargosRutas;
    }
}