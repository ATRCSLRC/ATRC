namespace ATRCBASE.WIN
{
    partial class xfrmSolicitudHorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSolicitudHorasExtras));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lue = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDias = new DevExpress.XtraEditors.TextEdit();
            this.txtOtro = new DevExpress.XtraEditors.TextEdit();
            this.clbEmpleado = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.dteA = new DevExpress.XtraEditors.DateEdit();
            this.dteDe = new DevExpress.XtraEditors.DateEdit();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOtro = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDias = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Guardar;
            this.bbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = global::ATRCBASE.WIN.Properties.Resources.Cancelar;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lue);
            this.lcMain.Controls.Add(this.txtDias);
            this.lcMain.Controls.Add(this.txtOtro);
            this.lcMain.Controls.Add(this.clbEmpleado);
            this.lcMain.Controls.Add(this.dteA);
            this.lcMain.Controls.Add(this.dteDe);
            this.lcMain.Controls.Add(this.dteFecha);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 83, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(800, 219);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // lue
            // 
            this.lue.EnterMoveNextControl = true;
            this.lue.Location = new System.Drawing.Point(67, 60);
            this.lue.MenuManager = this.ribbonControl1;
            this.lue.Name = "lue";
            this.lue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lue.Properties.DisplayMember = "Nombre";
            this.lue.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lue.Properties.ValueMember = "Oid";
            this.lue.Size = new System.Drawing.Size(721, 20);
            this.lue.StyleController = this.lcMain;
            this.lue.TabIndex = 13;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(41, 187);
            this.txtDias.MenuManager = this.ribbonControl1;
            this.txtDias.Name = "txtDias";
            this.txtDias.Properties.MaxLength = 24;
            this.txtDias.Size = new System.Drawing.Size(747, 20);
            this.txtDias.StyleController = this.lcMain;
            this.txtDias.TabIndex = 10;
            // 
            // txtOtro
            // 
            this.txtOtro.EnterMoveNextControl = true;
            this.txtOtro.Location = new System.Drawing.Point(43, 163);
            this.txtOtro.MenuManager = this.ribbonControl1;
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Properties.MaxLength = 24;
            this.txtOtro.Size = new System.Drawing.Size(745, 20);
            this.txtOtro.StyleController = this.lcMain;
            this.txtOtro.TabIndex = 9;
            // 
            // clbEmpleado
            // 
            this.clbEmpleado.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Ruta especial"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Maquiladora solicita tiempo extra"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Maquiladora trabaja 6 días a la semana"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Maquiladora trabaja 7 días a la semana"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Cambio de horario de maquiladora"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Cubrir falta de chofer"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Ruta extra"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Termino de jornada"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Otro")});
            this.clbEmpleado.Location = new System.Drawing.Point(12, 101);
            this.clbEmpleado.MultiColumn = true;
            this.clbEmpleado.Name = "clbEmpleado";
            this.clbEmpleado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.clbEmpleado.Size = new System.Drawing.Size(776, 58);
            this.clbEmpleado.StyleController = this.lcMain;
            this.clbEmpleado.TabIndex = 8;
            this.clbEmpleado.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbEmpleado_ItemCheck);
            // 
            // dteA
            // 
            this.dteA.EditValue = null;
            this.dteA.EnterMoveNextControl = true;
            this.dteA.Location = new System.Drawing.Point(418, 36);
            this.dteA.MenuManager = this.ribbonControl1;
            this.dteA.Name = "dteA";
            this.dteA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteA.Properties.DisplayFormat.FormatString = "D";
            this.dteA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.EditFormat.FormatString = "D";
            this.dteA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteA.Properties.MaskSettings.Set("mask", "D");
            this.dteA.Size = new System.Drawing.Size(370, 20);
            this.dteA.StyleController = this.lcMain;
            this.dteA.TabIndex = 6;
            // 
            // dteDe
            // 
            this.dteDe.EditValue = null;
            this.dteDe.EnterMoveNextControl = true;
            this.dteDe.Location = new System.Drawing.Point(34, 36);
            this.dteDe.MenuManager = this.ribbonControl1;
            this.dteDe.Name = "dteDe";
            this.dteDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDe.Properties.DisplayFormat.FormatString = "D";
            this.dteDe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.EditFormat.FormatString = "D";
            this.dteDe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDe.Properties.MaskSettings.Set("mask", "D");
            this.dteDe.Size = new System.Drawing.Size(364, 20);
            this.dteDe.StyleController = this.lcMain;
            this.dteDe.TabIndex = 5;
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.EnterMoveNextControl = true;
            this.dteFecha.Location = new System.Drawing.Point(50, 12);
            this.dteFecha.MenuManager = this.ribbonControl1;
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.DisplayFormat.FormatString = "D";
            this.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.EditFormat.FormatString = "D";
            this.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteFecha.Properties.MaskSettings.Set("mask", "D");
            this.dteFecha.Size = new System.Drawing.Size(738, 20);
            this.dteFecha.StyleController = this.lcMain;
            this.dteFecha.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFecha,
            this.lciDe,
            this.lciA,
            this.layoutControlItem5,
            this.lciOtro,
            this.lciDias,
            this.simpleLabelItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 219);
            this.Root.TextVisible = false;
            // 
            // lciFecha
            // 
            this.lciFecha.Control = this.dteFecha;
            this.lciFecha.Location = new System.Drawing.Point(0, 0);
            this.lciFecha.Name = "lciFecha";
            this.lciFecha.Size = new System.Drawing.Size(780, 24);
            this.lciFecha.Text = "Fecha:";
            this.lciFecha.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciFecha.TextSize = new System.Drawing.Size(33, 13);
            this.lciFecha.TextToControlDistance = 5;
            // 
            // lciDe
            // 
            this.lciDe.Control = this.dteDe;
            this.lciDe.Location = new System.Drawing.Point(0, 24);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(390, 24);
            this.lciDe.Text = "De:";
            this.lciDe.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDe.TextSize = new System.Drawing.Size(17, 13);
            this.lciDe.TextToControlDistance = 5;
            // 
            // lciA
            // 
            this.lciA.Control = this.dteA;
            this.lciA.Location = new System.Drawing.Point(390, 24);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(390, 24);
            this.lciA.Text = "A:";
            this.lciA.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciA.TextSize = new System.Drawing.Size(11, 13);
            this.lciA.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.clbEmpleado;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 62);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lciOtro
            // 
            this.lciOtro.Control = this.txtOtro;
            this.lciOtro.Location = new System.Drawing.Point(0, 151);
            this.lciOtro.Name = "lciOtro";
            this.lciOtro.Size = new System.Drawing.Size(780, 24);
            this.lciOtro.Text = "Otro:";
            this.lciOtro.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciOtro.TextSize = new System.Drawing.Size(26, 13);
            this.lciOtro.TextToControlDistance = 5;
            this.lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciDias
            // 
            this.lciDias.Control = this.txtDias;
            this.lciDias.Location = new System.Drawing.Point(0, 175);
            this.lciDias.Name = "lciDias";
            this.lciDias.Size = new System.Drawing.Size(780, 24);
            this.lciDias.Text = "Días:";
            this.lciDias.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDias.TextSize = new System.Drawing.Size(24, 13);
            this.lciDias.TextToControlDistance = 5;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 72);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(780, 17);
            this.simpleLabelItem1.Text = "Motivo de las horas extras:";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lue;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem2.Text = "Empleado:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // xfrmSolicitudHorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmSolicitudHorasExtras.IconOptions.Icon")));
            this.Name = "xfrmSolicitudHorasExtras";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Solicitud de horas extras";
            this.Load += new System.EventHandler(this.xfrmSolicitudHorasExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOtro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.CheckedListBoxControl clbEmpleado;
        private DevExpress.XtraEditors.DateEdit dteA;
        private DevExpress.XtraEditors.DateEdit dteDe;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciFecha;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtDias;
        private DevExpress.XtraEditors.TextEdit txtOtro;
        private DevExpress.XtraLayout.LayoutControlItem lciOtro;
        private DevExpress.XtraLayout.LayoutControlItem lciDias;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.LookUpEdit lue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}