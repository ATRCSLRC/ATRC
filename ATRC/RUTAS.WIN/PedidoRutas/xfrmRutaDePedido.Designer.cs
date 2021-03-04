namespace RUTAS.WIN.PedidoRutas
{
    partial class xfrmRutaDePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRutaDePedido));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.chkApoyo = new DevExpress.XtraEditors.CheckEdit();
            this.chkEsRutaExtra = new DevExpress.XtraEditors.CheckEdit();
            this.timeA = new DevExpress.XtraEditors.TimeEdit();
            this.timeDe = new DevExpress.XtraEditors.TimeEdit();
            this.lueTurno = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTipoRuta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lueServicio = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRuta = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTipoRuta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTurno = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRuta = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciServicio = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciA = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkApoyo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsRutaExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(634, 132);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGuardar.ImageOptions.Image")));
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.Image = global::RUTAS.WIN.Properties.Resources.icons8_cancelar_32;
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
            this.lcMain.Controls.Add(this.chkApoyo);
            this.lcMain.Controls.Add(this.chkEsRutaExtra);
            this.lcMain.Controls.Add(this.timeA);
            this.lcMain.Controls.Add(this.timeDe);
            this.lcMain.Controls.Add(this.lueTurno);
            this.lcMain.Controls.Add(this.cmbTipoRuta);
            this.lcMain.Controls.Add(this.lueServicio);
            this.lcMain.Controls.Add(this.txtRuta);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 132);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(682, 39, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(634, 210);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // chkApoyo
            // 
            this.chkApoyo.Location = new System.Drawing.Point(453, 45);
            this.chkApoyo.MenuManager = this.ribbonControl1;
            this.chkApoyo.Name = "chkApoyo";
            this.chkApoyo.Properties.Caption = "Es apoyo";
            this.chkApoyo.Size = new System.Drawing.Size(67, 20);
            this.chkApoyo.StyleController = this.lcMain;
            this.chkApoyo.TabIndex = 11;
            // 
            // chkEsRutaExtra
            // 
            this.chkEsRutaExtra.Location = new System.Drawing.Point(524, 45);
            this.chkEsRutaExtra.MenuManager = this.ribbonControl1;
            this.chkEsRutaExtra.Name = "chkEsRutaExtra";
            this.chkEsRutaExtra.Properties.Caption = "Es ruta extra";
            this.chkEsRutaExtra.Size = new System.Drawing.Size(86, 20);
            this.chkEsRutaExtra.StyleController = this.lcMain;
            this.chkEsRutaExtra.TabIndex = 10;
            // 
            // timeA
            // 
            this.timeA.EditValue = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            this.timeA.Location = new System.Drawing.Point(334, 162);
            this.timeA.MenuManager = this.ribbonControl1;
            this.timeA.Name = "timeA";
            this.timeA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeA.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeA.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeA.Properties.MaskSettings.Set("mask", "hh:mm tt");
            this.timeA.Size = new System.Drawing.Size(276, 20);
            this.timeA.StyleController = this.lcMain;
            this.timeA.TabIndex = 9;
            // 
            // timeDe
            // 
            this.timeDe.EditValue = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            this.timeDe.Location = new System.Drawing.Point(46, 162);
            this.timeDe.MenuManager = this.ribbonControl1;
            this.timeDe.Name = "timeDe";
            this.timeDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeDe.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeDe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeDe.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeDe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeDe.Properties.MaskSettings.Set("mask", "hh:mm tt");
            this.timeDe.Size = new System.Drawing.Size(268, 20);
            this.timeDe.StyleController = this.lcMain;
            this.timeDe.TabIndex = 8;
            // 
            // lueTurno
            // 
            this.lueTurno.Location = new System.Drawing.Point(383, 93);
            this.lueTurno.MenuManager = this.ribbonControl1;
            this.lueTurno.Name = "lueTurno";
            this.lueTurno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTurno.Properties.DisplayMember = "Descripcion";
            this.lueTurno.Properties.NullText = "[Seleccione]";
            this.lueTurno.Properties.ValueMember = "Oid";
            this.lueTurno.Size = new System.Drawing.Size(227, 20);
            this.lueTurno.StyleController = this.lcMain;
            this.lueTurno.TabIndex = 7;
            // 
            // cmbTipoRuta
            // 
            this.cmbTipoRuta.Location = new System.Drawing.Point(98, 93);
            this.cmbTipoRuta.MenuManager = this.ribbonControl1;
            this.cmbTipoRuta.Name = "cmbTipoRuta";
            this.cmbTipoRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoRuta.Size = new System.Drawing.Size(207, 20);
            this.cmbTipoRuta.StyleController = this.lcMain;
            this.cmbTipoRuta.TabIndex = 6;
            this.cmbTipoRuta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRuta_SelectedIndexChanged);
            // 
            // lueServicio
            // 
            this.lueServicio.Location = new System.Drawing.Point(292, 69);
            this.lueServicio.MenuManager = this.ribbonControl1;
            this.lueServicio.Name = "lueServicio";
            this.lueServicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueServicio.Properties.DisplayMember = "Descripcion";
            this.lueServicio.Properties.NullText = "[Seleccione]";
            this.lueServicio.Properties.ValueMember = "Oid";
            this.lueServicio.Properties.PopupFilter += new DevExpress.XtraEditors.Controls.PopupFilterEventHandler(this.lueServicio_Properties_PopupFilter);
            this.lueServicio.Size = new System.Drawing.Size(318, 20);
            this.lueServicio.StyleController = this.lcMain;
            this.lueServicio.TabIndex = 5;
            this.lueServicio.EditValueChanged += new System.EventHandler(this.lueServicio_EditValueChanged);
            this.lueServicio.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lueServicio_CustomDisplayText);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(98, 69);
            this.txtRuta.MenuManager = this.ribbonControl1;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(116, 20);
            this.txtRuta.StyleController = this.lcMain;
            this.txtRuta.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(634, 210);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTipoRuta,
            this.lciTurno,
            this.lciRuta,
            this.emptySpaceItem1,
            this.lciServicio,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(614, 117);
            this.layoutControlGroup1.Text = "Detalle de ruta";
            // 
            // lciTipoRuta
            // 
            this.lciTipoRuta.Control = this.cmbTipoRuta;
            this.lciTipoRuta.Location = new System.Drawing.Point(0, 48);
            this.lciTipoRuta.Name = "lciTipoRuta";
            this.lciTipoRuta.Size = new System.Drawing.Size(285, 24);
            this.lciTipoRuta.Text = "Tipo de ruta:";
            this.lciTipoRuta.TextSize = new System.Drawing.Size(62, 13);
            // 
            // lciTurno
            // 
            this.lciTurno.Control = this.lueTurno;
            this.lciTurno.Location = new System.Drawing.Point(285, 48);
            this.lciTurno.Name = "lciTurno";
            this.lciTurno.Size = new System.Drawing.Size(305, 24);
            this.lciTurno.Text = "Turno:";
            this.lciTurno.TextSize = new System.Drawing.Size(62, 13);
            // 
            // lciRuta
            // 
            this.lciRuta.Control = this.txtRuta;
            this.lciRuta.Location = new System.Drawing.Point(0, 24);
            this.lciRuta.Name = "lciRuta";
            this.lciRuta.Size = new System.Drawing.Size(194, 24);
            this.lciRuta.Text = "Ruta:";
            this.lciRuta.TextSize = new System.Drawing.Size(62, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(429, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciServicio
            // 
            this.lciServicio.Control = this.lueServicio;
            this.lciServicio.Location = new System.Drawing.Point(194, 24);
            this.lciServicio.Name = "lciServicio";
            this.lciServicio.Size = new System.Drawing.Size(396, 24);
            this.lciServicio.Text = "Servicio:";
            this.lciServicio.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkEsRutaExtra;
            this.layoutControlItem1.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkApoyo;
            this.layoutControlItem2.Location = new System.Drawing.Point(429, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(71, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDe,
            this.lciA});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 117);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(614, 73);
            this.layoutControlGroup2.Text = "Horario de servicio";
            // 
            // lciDe
            // 
            this.lciDe.Control = this.timeDe;
            this.lciDe.Location = new System.Drawing.Point(0, 0);
            this.lciDe.Name = "lciDe";
            this.lciDe.Size = new System.Drawing.Size(294, 28);
            this.lciDe.Text = "De:";
            this.lciDe.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDe.TextSize = new System.Drawing.Size(17, 13);
            this.lciDe.TextToControlDistance = 5;
            // 
            // lciA
            // 
            this.lciA.Control = this.timeA;
            this.lciA.Location = new System.Drawing.Point(294, 0);
            this.lciA.Name = "lciA";
            this.lciA.Size = new System.Drawing.Size(296, 28);
            this.lciA.Text = "A:";
            this.lciA.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciA.TextSize = new System.Drawing.Size(11, 13);
            this.lciA.TextToControlDistance = 5;
            // 
            // xfrmRutaDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmRutaDePedido.IconOptions.Icon")));
            this.Name = "xfrmRutaDePedido";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Ruta de pedido";
            this.Load += new System.EventHandler(this.xfrmRutaDePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkApoyo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEsRutaExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTipoRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit lueTurno;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoRuta;
        private DevExpress.XtraEditors.LookUpEdit lueServicio;
        private DevExpress.XtraEditors.TextEdit txtRuta;
        private DevExpress.XtraLayout.LayoutControlItem lciRuta;
        private DevExpress.XtraLayout.LayoutControlItem lciServicio;
        private DevExpress.XtraLayout.LayoutControlItem lciTipoRuta;
        private DevExpress.XtraLayout.LayoutControlItem lciTurno;
        private DevExpress.XtraEditors.TimeEdit timeA;
        private DevExpress.XtraEditors.TimeEdit timeDe;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciDe;
        private DevExpress.XtraLayout.LayoutControlItem lciA;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.CheckEdit chkApoyo;
        private DevExpress.XtraEditors.CheckEdit chkEsRutaExtra;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}