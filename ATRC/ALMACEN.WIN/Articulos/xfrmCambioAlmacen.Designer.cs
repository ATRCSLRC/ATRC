namespace ALMACEN.WIN
{
    partial class xfrmCambioAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCambioAlmacen));
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsuario = new DevExpress.XtraEditors.ButtonEdit();
            this.lueFactura = new DevExpress.XtraEditors.LookUpEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCodigo = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFactura = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmpleado = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.rcMain.SearchEditItem});
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.MaxItemId = 1;
            this.rcMain.Name = "rcMain";
            this.rcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.rcMain.ShowToolbarCustomizeItem = false;
            this.rcMain.Size = new System.Drawing.Size(623, 32);
            this.rcMain.Toolbar.ShowCustomizeItem = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtNombreUsuario);
            this.lcMain.Controls.Add(this.btnAceptar);
            this.lcMain.Controls.Add(this.btnCancelar);
            this.lcMain.Controls.Add(this.btnUsuario);
            this.lcMain.Controls.Add(this.lueFactura);
            this.lcMain.Controls.Add(this.btnBuscar);
            this.lcMain.Controls.Add(this.btnCodigo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 32);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(250, 501, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(623, 191);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.EnterMoveNextControl = true;
            this.txtNombreUsuario.Location = new System.Drawing.Point(302, 113);
            this.txtNombreUsuario.MenuManager = this.rcMain;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreUsuario.Properties.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(297, 20);
            this.txtNombreUsuario.StyleController = this.lcMain;
            this.txtNombreUsuario.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(422, 137);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 30);
            this.btnAceptar.StyleController = this.lcMain;
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar (F5)";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(512, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.StyleController = this.lcMain;
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar (F12)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(24, 113);
            this.btnUsuario.MenuManager = this.rcMain;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.btnUsuario.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnUsuario_Properties_ButtonClick);
            this.btnUsuario.Size = new System.Drawing.Size(168, 20);
            this.btnUsuario.StyleController = this.lcMain;
            this.btnUsuario.TabIndex = 15;
            this.btnUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUsuario_KeyDown);
            this.btnUsuario.Leave += new System.EventHandler(this.btnUsuario_Leave);
            // 
            // lueFactura
            // 
            this.lueFactura.Location = new System.Drawing.Point(74, 71);
            this.lueFactura.MenuManager = this.rcMain;
            this.lueFactura.Name = "lueFactura";
            this.lueFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFactura.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueFactura.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cantidad", "Cantidad", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Articulo.Nombre", "Nombre", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumParte", "Parte", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumFactura", "Factura", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fecha", "Fecha", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueFactura.Properties.NullText = "[Seleccione]";
            this.lueFactura.Size = new System.Drawing.Size(525, 20);
            this.lueFactura.StyleController = this.lcMain;
            this.lueFactura.TabIndex = 12;
            this.lueFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lueArticulo_KeyUp);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 22);
            this.btnBuscar.StyleController = this.lcMain;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(92, 12);
            this.btnCodigo.MenuManager = this.rcMain;
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.btnCodigo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnCodigo_Properties_ButtonClick);
            this.btnCodigo.Size = new System.Drawing.Size(436, 20);
            this.btnCodigo.StyleController = this.lcMain;
            this.btnCodigo.TabIndex = 4;
            this.btnCodigo.ToolTip = "Para buscar artículos presioné F6";
            this.btnCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCodigo_KeyDown);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCodigo,
            this.layoutControlItem3,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(623, 191);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciCodigo
            // 
            this.lciCodigo.Control = this.btnCodigo;
            this.lciCodigo.Location = new System.Drawing.Point(0, 0);
            this.lciCodigo.Name = "lciCodigo";
            this.lciCodigo.Size = new System.Drawing.Size(520, 26);
            this.lciCodigo.Text = "Ingresé código:";
            this.lciCodigo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciCodigo.TextSize = new System.Drawing.Size(75, 13);
            this.lciCodigo.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnBuscar;
            this.layoutControlItem3.Location = new System.Drawing.Point(520, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(83, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFactura,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.lciEmpleado,
            this.lciNombreUsuario,
            this.simpleLabelItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(603, 145);
            this.layoutControlGroup2.Text = "Detalles";
            // 
            // lciFactura
            // 
            this.lciFactura.Control = this.lueFactura;
            this.lciFactura.Location = new System.Drawing.Point(0, 0);
            this.lciFactura.Name = "lciFactura";
            this.lciFactura.Size = new System.Drawing.Size(579, 24);
            this.lciFactura.Text = "Artículos:";
            this.lciFactura.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciFactura.TextSize = new System.Drawing.Size(45, 13);
            this.lciFactura.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 32);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 32);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(398, 34);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAceptar;
            this.layoutControlItem2.Location = new System.Drawing.Point(398, 66);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 34);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancelar;
            this.layoutControlItem1.Location = new System.Drawing.Point(488, 66);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(91, 34);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciEmpleado
            // 
            this.lciEmpleado.Control = this.btnUsuario;
            this.lciEmpleado.Location = new System.Drawing.Point(0, 42);
            this.lciEmpleado.Name = "lciEmpleado";
            this.lciEmpleado.Size = new System.Drawing.Size(172, 24);
            this.lciEmpleado.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciEmpleado.TextSize = new System.Drawing.Size(0, 0);
            this.lciEmpleado.TextVisible = false;
            // 
            // lciNombreUsuario
            // 
            this.lciNombreUsuario.Control = this.txtNombreUsuario;
            this.lciNombreUsuario.Location = new System.Drawing.Point(172, 42);
            this.lciNombreUsuario.Name = "lciNombreUsuario";
            this.lciNombreUsuario.Size = new System.Drawing.Size(407, 24);
            this.lciNombreUsuario.Text = "Nombre de usuario:";
            this.lciNombreUsuario.TextSize = new System.Drawing.Size(94, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 24);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(579, 18);
            this.simpleLabelItem1.Text = "Recibio:";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(94, 14);
            // 
            // xfrmCambioAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 223);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.rcMain);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmCambioAlmacen.IconOptions.Icon")));
            this.Name = "xfrmCambioAlmacen";
            this.Ribbon = this.rcMain;
            this.Text = "Salida de artículo";
            this.Load += new System.EventHandler(this.xfrmSalidaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.ButtonEdit btnUsuario;
        private DevExpress.XtraEditors.LookUpEdit lueFactura;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.ButtonEdit btnCodigo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciCodigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciFactura;
        private DevExpress.XtraLayout.LayoutControlItem lciEmpleado;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem lciNombreUsuario;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}