namespace CHECADOR.WIN
{
    partial class xfrmChecador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmChecador));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.prgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.memoMotivo = new DevExpress.XtraEditors.MemoEdit();
            this.tmeHoraEntrada = new DevExpress.XtraEditors.TimeEdit();
            this.tmeHoraSalida = new DevExpress.XtraEditors.TimeEdit();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnNumUsuario = new DevExpress.XtraEditors.ButtonEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgGrupo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDia = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNumUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHoraEntrada = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHoraSalida = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMotivo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraSalida)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(580, 122);
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
            this.prgAcciones});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // prgAcciones
            // 
            this.prgAcciones.AllowTextClipping = false;
            this.prgAcciones.ItemLinks.Add(this.bbiGuardar);
            this.prgAcciones.ItemLinks.Add(this.bbiCancelar);
            this.prgAcciones.Name = "prgAcciones";
            this.prgAcciones.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.memoMotivo);
            this.lcMain.Controls.Add(this.tmeHoraEntrada);
            this.lcMain.Controls.Add(this.tmeHoraSalida);
            this.lcMain.Controls.Add(this.txtNombreUsuario);
            this.lcMain.Controls.Add(this.btnNumUsuario);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(580, 189);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // memoMotivo
            // 
            this.memoMotivo.Location = new System.Drawing.Point(121, 114);
            this.memoMotivo.MenuManager = this.ribbonControl1;
            this.memoMotivo.Name = "memoMotivo";
            this.memoMotivo.Size = new System.Drawing.Size(435, 51);
            this.memoMotivo.StyleController = this.lcMain;
            this.memoMotivo.TabIndex = 9;
            // 
            // tmeHoraEntrada
            // 
            this.tmeHoraEntrada.EditValue = null;
            this.tmeHoraEntrada.Location = new System.Drawing.Point(121, 90);
            this.tmeHoraEntrada.MenuManager = this.ribbonControl1;
            this.tmeHoraEntrada.Name = "tmeHoraEntrada";
            this.tmeHoraEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeHoraEntrada.Properties.Mask.EditMask = "HH:mm";
            this.tmeHoraEntrada.Size = new System.Drawing.Size(174, 20);
            this.tmeHoraEntrada.StyleController = this.lcMain;
            this.tmeHoraEntrada.TabIndex = 8;
            // 
            // tmeHoraSalida
            // 
            this.tmeHoraSalida.EditValue = null;
            this.tmeHoraSalida.Location = new System.Drawing.Point(396, 90);
            this.tmeHoraSalida.MenuManager = this.ribbonControl1;
            this.tmeHoraSalida.Name = "tmeHoraSalida";
            this.tmeHoraSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeHoraSalida.Properties.Mask.EditMask = "HH:mm";
            this.tmeHoraSalida.Size = new System.Drawing.Size(160, 20);
            this.tmeHoraSalida.StyleController = this.lcMain;
            this.tmeHoraSalida.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(310, 66);
            this.txtNombreUsuario.MenuManager = this.ribbonControl1;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(246, 20);
            this.txtNombreUsuario.StyleController = this.lcMain;
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // btnNumUsuario
            // 
            this.btnNumUsuario.Location = new System.Drawing.Point(121, 66);
            this.btnNumUsuario.MenuManager = this.ribbonControl1;
            this.btnNumUsuario.Name = "btnNumUsuario";
            this.btnNumUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnNumUsuario.Properties.Mask.EditMask = "\\d{1,10}";
            this.btnNumUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.btnNumUsuario.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnNumUsuario_Properties_ButtonClick);
            this.btnNumUsuario.Size = new System.Drawing.Size(88, 20);
            this.btnNumUsuario.StyleController = this.lcMain;
            this.btnNumUsuario.TabIndex = 5;
            this.btnNumUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNumUsuario_KeyDown);
            this.btnNumUsuario.Leave += new System.EventHandler(this.btnNumUsuario_Leave);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(121, 42);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.Mask.EditMask = "D";
            this.dteFecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dteFecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dteFecha.Size = new System.Drawing.Size(435, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgGrupo});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(580, 189);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgGrupo
            // 
            this.lcgGrupo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDia,
            this.lciNumUsuario,
            this.lciNombreUsuario,
            this.lciHoraEntrada,
            this.lciHoraSalida,
            this.lciMotivo});
            this.lcgGrupo.Location = new System.Drawing.Point(0, 0);
            this.lcgGrupo.Name = "lcgGrupo";
            this.lcgGrupo.Size = new System.Drawing.Size(560, 169);
            this.lcgGrupo.Text = "Ingresar los siguientes datos";
            // 
            // lciDia
            // 
            this.lciDia.Control = this.dteFecha;
            this.lciDia.Location = new System.Drawing.Point(0, 0);
            this.lciDia.Name = "lciDia";
            this.lciDia.Size = new System.Drawing.Size(536, 24);
            this.lciDia.Text = "Fecha de entrada:";
            this.lciDia.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciNumUsuario
            // 
            this.lciNumUsuario.Control = this.btnNumUsuario;
            this.lciNumUsuario.Location = new System.Drawing.Point(0, 24);
            this.lciNumUsuario.Name = "lciNumUsuario";
            this.lciNumUsuario.Size = new System.Drawing.Size(189, 24);
            this.lciNumUsuario.Text = "Número usuario:";
            this.lciNumUsuario.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciNombreUsuario
            // 
            this.lciNombreUsuario.Control = this.txtNombreUsuario;
            this.lciNombreUsuario.Location = new System.Drawing.Point(189, 24);
            this.lciNombreUsuario.Name = "lciNombreUsuario";
            this.lciNombreUsuario.Size = new System.Drawing.Size(347, 24);
            this.lciNombreUsuario.Text = "Nombre de usuario:";
            this.lciNombreUsuario.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciHoraEntrada
            // 
            this.lciHoraEntrada.Control = this.tmeHoraEntrada;
            this.lciHoraEntrada.Location = new System.Drawing.Point(0, 48);
            this.lciHoraEntrada.Name = "lciHoraEntrada";
            this.lciHoraEntrada.Size = new System.Drawing.Size(275, 24);
            this.lciHoraEntrada.Text = "Hora de entrada:";
            this.lciHoraEntrada.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciHoraSalida
            // 
            this.lciHoraSalida.Control = this.tmeHoraSalida;
            this.lciHoraSalida.Location = new System.Drawing.Point(275, 48);
            this.lciHoraSalida.Name = "lciHoraSalida";
            this.lciHoraSalida.Size = new System.Drawing.Size(261, 24);
            this.lciHoraSalida.Text = "Hora de salida:";
            this.lciHoraSalida.TextSize = new System.Drawing.Size(94, 13);
            // 
            // lciMotivo
            // 
            this.lciMotivo.Control = this.memoMotivo;
            this.lciMotivo.Location = new System.Drawing.Point(0, 72);
            this.lciMotivo.Name = "lciMotivo";
            this.lciMotivo.Size = new System.Drawing.Size(536, 55);
            this.lciMotivo.Text = "Motivo:";
            this.lciMotivo.TextSize = new System.Drawing.Size(94, 13);
            // 
            // xfrmChecador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 311);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmChecador";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checador";
            this.Load += new System.EventHandler(this.xfrmChecador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeHoraSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNumUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup prgAcciones;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TimeEdit tmeHoraEntrada;
        private DevExpress.XtraEditors.TimeEdit tmeHoraSalida;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.ButtonEdit btnNumUsuario;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgGrupo;
        private DevExpress.XtraLayout.LayoutControlItem lciDia;
        private DevExpress.XtraLayout.LayoutControlItem lciNumUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciHoraEntrada;
        private DevExpress.XtraLayout.LayoutControlItem lciHoraSalida;
        private DevExpress.XtraEditors.MemoEdit memoMotivo;
        private DevExpress.XtraLayout.LayoutControlItem lciMotivo;
    }
}