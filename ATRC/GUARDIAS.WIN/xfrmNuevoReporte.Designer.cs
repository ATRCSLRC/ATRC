namespace GUARDIAS.WIN
{
    partial class xfrmNuevoReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmNuevoReporte));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lueGuardia = new DevExpress.XtraEditors.LookUpEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.memoMotivo = new DevExpress.XtraEditors.MemoEdit();
            this.lueDepartamento = new DevExpress.XtraEditors.LookUpEdit();
            this.lueEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDepartamento = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMotivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGuardia = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueGuardia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGuardia)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lueGuardia);
            this.lcMain.Controls.Add(this.memoMotivo);
            this.lcMain.Controls.Add(this.lueDepartamento);
            this.lcMain.Controls.Add(this.lueEmpleado);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(536, 339);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lueGuardia
            // 
            this.lueGuardia.EnterMoveNextControl = true;
            this.lueGuardia.Location = new System.Drawing.Point(126, 60);
            this.lueGuardia.MenuManager = this.ribbonControl1;
            this.lueGuardia.Name = "lueGuardia";
            this.lueGuardia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGuardia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueGuardia.Properties.DisplayMember = "Nombre";
            this.lueGuardia.Properties.NullText = "[Seleccioné]";
            this.lueGuardia.Properties.ValueMember = "Oid";
            this.lueGuardia.Size = new System.Drawing.Size(398, 20);
            this.lueGuardia.StyleController = this.lcMain;
            this.lueGuardia.TabIndex = 9;
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
            this.ribbonControl1.Size = new System.Drawing.Size(536, 122);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // memoMotivo
            // 
            this.memoMotivo.EnterMoveNextControl = true;
            this.memoMotivo.Location = new System.Drawing.Point(12, 100);
            this.memoMotivo.MenuManager = this.ribbonControl1;
            this.memoMotivo.Name = "memoMotivo";
            this.memoMotivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoMotivo.Size = new System.Drawing.Size(512, 227);
            this.memoMotivo.StyleController = this.lcMain;
            this.memoMotivo.TabIndex = 8;
            // 
            // lueDepartamento
            // 
            this.lueDepartamento.EnterMoveNextControl = true;
            this.lueDepartamento.Location = new System.Drawing.Point(126, 36);
            this.lueDepartamento.MenuManager = this.ribbonControl1;
            this.lueDepartamento.Name = "lueDepartamento";
            this.lueDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepartamento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueDepartamento.Properties.DisplayMember = "Nombre";
            this.lueDepartamento.Properties.NullText = "[Seleccioné]";
            this.lueDepartamento.Properties.ValueMember = "Oid";
            this.lueDepartamento.Size = new System.Drawing.Size(398, 20);
            this.lueDepartamento.StyleController = this.lcMain;
            this.lueDepartamento.TabIndex = 5;
            // 
            // lueEmpleado
            // 
            this.lueEmpleado.EnterMoveNextControl = true;
            this.lueEmpleado.Location = new System.Drawing.Point(126, 12);
            this.lueEmpleado.MenuManager = this.ribbonControl1;
            this.lueEmpleado.Name = "lueEmpleado";
            this.lueEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueEmpleado.Properties.DisplayMember = "Nombre";
            this.lueEmpleado.Properties.NullText = "[Seleccioné]";
            this.lueEmpleado.Properties.ValueMember = "Oid";
            this.lueEmpleado.Size = new System.Drawing.Size(398, 20);
            this.lueEmpleado.StyleController = this.lcMain;
            this.lueEmpleado.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEmpleado,
            this.lciDepartamento,
            this.lciMotivo,
            this.lciGuardia});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(536, 339);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.Control = this.lueEmpleado;
            this.lciEmpleado.Location = new System.Drawing.Point(0, 0);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(516, 24);
            this.lciEmpleado.Text = "Empleado:";
            this.lciEmpleado.TextSize = new System.Drawing.Size(111, 13);
            // 
            // lciDepartamento
            // 
            this.lciDepartamento.Control = this.lueDepartamento;
            this.lciDepartamento.Location = new System.Drawing.Point(0, 24);
            this.lciDepartamento.Name = "lciDepartamento";
            this.lciDepartamento.Size = new System.Drawing.Size(516, 24);
            this.lciDepartamento.Text = "Jefe de departamento:";
            this.lciDepartamento.TextSize = new System.Drawing.Size(111, 13);
            // 
            // lciMotivo
            // 
            this.lciMotivo.Control = this.memoMotivo;
            this.lciMotivo.Location = new System.Drawing.Point(0, 72);
            this.lciMotivo.Name = "lciMotivo";
            this.lciMotivo.Size = new System.Drawing.Size(516, 247);
            this.lciMotivo.Text = "Motivo:";
            this.lciMotivo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMotivo.TextSize = new System.Drawing.Size(111, 13);
            // 
            // lciGuardia
            // 
            this.lciGuardia.Control = this.lueGuardia;
            this.lciGuardia.Location = new System.Drawing.Point(0, 48);
            this.lciGuardia.Name = "lciGuardia";
            this.lciGuardia.Size = new System.Drawing.Size(516, 24);
            this.lciGuardia.Text = "Guardia:";
            this.lciGuardia.TextSize = new System.Drawing.Size(111, 13);
            // 
            // xfrmNuevoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 461);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmNuevoReporte";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Reporte indiciplina";
            this.Load += new System.EventHandler(this.xfrmNuevoReporte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmNuevoReporte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueGuardia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGuardia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LookUpEdit lueDepartamento;
        private DevExpress.XtraEditors.LookUpEdit lueEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraLayout.LayoutControlItem lciDepartamento;
        private DevExpress.XtraEditors.LookUpEdit lueGuardia;
        private DevExpress.XtraEditors.MemoEdit memoMotivo;
        private DevExpress.XtraLayout.LayoutControlItem lciMotivo;
        private DevExpress.XtraLayout.LayoutControlItem lciGuardia;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
    }
}