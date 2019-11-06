namespace GUARDIAS.WIN.Renta
{
    partial class xfrmSeguimientoContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSeguimientoContrato));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiRegreso = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.memoComentario = new DevExpress.XtraEditors.MemoEdit();
            this.tmeRegreso = new DevExpress.XtraEditors.TimeEdit();
            this.txtDestino = new DevExpress.XtraEditors.TextEdit();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtNumContrato = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFolio = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciComentarios = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDestino = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTotal = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciHoraEntrega = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblDetalleEntrega = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeRegreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiRegreso,
            this.bbiCancelar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(727, 122);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiRegreso
            // 
            this.bbiRegreso.Caption = "Registrar regreso";
            this.bbiRegreso.Id = 1;
            this.bbiRegreso.ImageOptions.LargeImage = global::GUARDIAS.WIN.Properties.Resources.icons8_comprobado_32;
            this.bbiRegreso.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiRegreso.Name = "bbiRegreso";
            this.bbiRegreso.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRegreso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRegreso_ItemClick);
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
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRegreso);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtUnidad);
            this.lcMain.Controls.Add(this.memoComentario);
            this.lcMain.Controls.Add(this.tmeRegreso);
            this.lcMain.Controls.Add(this.txtDestino);
            this.lcMain.Controls.Add(this.txtCliente);
            this.lcMain.Controls.Add(this.txtNumContrato);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1024, 509, 650, 400);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(727, 213);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(73, 90);
            this.txtUnidad.MenuManager = this.ribbonControl1;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(155, 20);
            this.txtUnidad.StyleController = this.lcMain;
            this.txtUnidad.TabIndex = 11;
            // 
            // memoComentario
            // 
            this.memoComentario.Location = new System.Drawing.Point(106, 134);
            this.memoComentario.MenuManager = this.ribbonControl1;
            this.memoComentario.Name = "memoComentario";
            this.memoComentario.Size = new System.Drawing.Size(383, 55);
            this.memoComentario.StyleController = this.lcMain;
            this.memoComentario.TabIndex = 10;
            // 
            // tmeRegreso
            // 
            this.tmeRegreso.EditValue = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.tmeRegreso.Enabled = false;
            this.tmeRegreso.Location = new System.Drawing.Point(609, 90);
            this.tmeRegreso.MenuManager = this.ribbonControl1;
            this.tmeRegreso.Name = "tmeRegreso";
            this.tmeRegreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeRegreso.Size = new System.Drawing.Size(94, 20);
            this.tmeRegreso.StyleController = this.lcMain;
            this.tmeRegreso.TabIndex = 9;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(284, 90);
            this.txtDestino.MenuManager = this.ribbonControl1;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(218, 20);
            this.txtDestino.StyleController = this.lcMain;
            this.txtDestino.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(73, 66);
            this.txtCliente.MenuManager = this.ribbonControl1;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(630, 20);
            this.txtCliente.StyleController = this.lcMain;
            this.txtCliente.TabIndex = 5;
            // 
            // txtNumContrato
            // 
            this.txtNumContrato.Location = new System.Drawing.Point(136, 12);
            this.txtNumContrato.MenuManager = this.ribbonControl1;
            this.txtNumContrato.Name = "txtNumContrato";
            this.txtNumContrato.Size = new System.Drawing.Size(579, 20);
            this.txtNumContrato.StyleController = this.lcMain;
            this.txtNumContrato.TabIndex = 4;
            this.txtNumContrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumContrato_KeyDown);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFolio,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(727, 213);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciFolio
            // 
            this.lciFolio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciFolio.AppearanceItemCaption.Options.UseFont = true;
            this.lciFolio.Control = this.txtNumContrato;
            this.lciFolio.Location = new System.Drawing.Point(0, 0);
            this.lciFolio.Name = "lciFolio";
            this.lciFolio.Size = new System.Drawing.Size(707, 24);
            this.lciFolio.Text = "Número de contrato:";
            this.lciFolio.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciFolio.TextSize = new System.Drawing.Size(119, 16);
            this.lciFolio.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCliente,
            this.lciUnidad,
            this.lciComentarios,
            this.lciDestino,
            this.layoutControlGroup2,
            this.lciHoraEntrega,
            this.lblDetalleEntrega});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(707, 169);
            this.layoutControlGroup3.Text = "Detalles de la renta";
            // 
            // lciCliente
            // 
            this.lciCliente.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciCliente.AppearanceItemCaption.Options.UseFont = true;
            this.lciCliente.Control = this.txtCliente;
            this.lciCliente.Location = new System.Drawing.Point(0, 0);
            this.lciCliente.Name = "lciCliente";
            this.lciCliente.Size = new System.Drawing.Size(683, 24);
            this.lciCliente.Text = "Cliente:";
            this.lciCliente.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciCliente.TextSize = new System.Drawing.Size(44, 16);
            this.lciCliente.TextToControlDistance = 5;
            // 
            // lciUnidad
            // 
            this.lciUnidad.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciUnidad.AppearanceItemCaption.Options.UseFont = true;
            this.lciUnidad.Control = this.txtUnidad;
            this.lciUnidad.Location = new System.Drawing.Point(0, 24);
            this.lciUnidad.Name = "lciUnidad";
            this.lciUnidad.Size = new System.Drawing.Size(208, 24);
            this.lciUnidad.Text = "Unidad:";
            this.lciUnidad.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciUnidad.TextSize = new System.Drawing.Size(44, 16);
            this.lciUnidad.TextToControlDistance = 5;
            // 
            // lciComentarios
            // 
            this.lciComentarios.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciComentarios.AppearanceItemCaption.Options.UseFont = true;
            this.lciComentarios.Control = this.memoComentario;
            this.lciComentarios.Location = new System.Drawing.Point(0, 68);
            this.lciComentarios.MinSize = new System.Drawing.Size(117, 20);
            this.lciComentarios.Name = "lciComentarios";
            this.lciComentarios.Size = new System.Drawing.Size(469, 59);
            this.lciComentarios.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciComentarios.Text = "Comentarios:";
            this.lciComentarios.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciComentarios.TextSize = new System.Drawing.Size(77, 16);
            this.lciComentarios.TextToControlDistance = 5;
            // 
            // lciDestino
            // 
            this.lciDestino.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciDestino.AppearanceItemCaption.Options.UseFont = true;
            this.lciDestino.Control = this.txtDestino;
            this.lciDestino.Location = new System.Drawing.Point(208, 24);
            this.lciDestino.Name = "lciDestino";
            this.lciDestino.Size = new System.Drawing.Size(274, 24);
            this.lciDestino.Text = "Destino:";
            this.lciDestino.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDestino.TextSize = new System.Drawing.Size(47, 16);
            this.lciDestino.TextToControlDistance = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotal});
            this.layoutControlGroup2.Location = new System.Drawing.Point(469, 48);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(214, 79);
            this.layoutControlGroup2.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AllowHotTrack = false;
            this.lblTotal.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.AppearanceItemCaption.Options.UseFont = true;
            this.lblTotal.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblTotal.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotal.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(190, 34);
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextSize = new System.Drawing.Size(59, 25);
            // 
            // lciHoraEntrega
            // 
            this.lciHoraEntrega.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciHoraEntrega.AppearanceItemCaption.Options.UseFont = true;
            this.lciHoraEntrega.Control = this.tmeRegreso;
            this.lciHoraEntrega.Location = new System.Drawing.Point(482, 24);
            this.lciHoraEntrega.Name = "lciHoraEntrega";
            this.lciHoraEntrega.Size = new System.Drawing.Size(201, 24);
            this.lciHoraEntrega.Text = "Hora de entrega:";
            this.lciHoraEntrega.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciHoraEntrega.TextSize = new System.Drawing.Size(98, 16);
            this.lciHoraEntrega.TextToControlDistance = 5;
            // 
            // lblDetalleEntrega
            // 
            this.lblDetalleEntrega.AllowHotTrack = false;
            this.lblDetalleEntrega.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleEntrega.AppearanceItemCaption.Options.UseFont = true;
            this.lblDetalleEntrega.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblDetalleEntrega.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDetalleEntrega.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDetalleEntrega.Location = new System.Drawing.Point(0, 48);
            this.lblDetalleEntrega.Name = "lblDetalleEntrega";
            this.lblDetalleEntrega.Size = new System.Drawing.Size(469, 20);
            this.lblDetalleEntrega.Text = " ";
            this.lblDetalleEntrega.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lblDetalleEntrega.TextSize = new System.Drawing.Size(4, 16);
            // 
            // xfrmSeguimientoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 335);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "xfrmSeguimientoContrato";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Registro de regreso ";
            this.Load += new System.EventHandler(this.xfrmSeguimientoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeRegreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoraEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetalleEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.MemoEdit memoComentario;
        private DevExpress.XtraEditors.TimeEdit tmeRegreso;
        private DevExpress.XtraEditors.TextEdit txtDestino;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.TextEdit txtNumContrato;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciFolio;
        private DevExpress.XtraLayout.LayoutControlItem lciCliente;
        private DevExpress.XtraLayout.LayoutControlItem lciDestino;
        private DevExpress.XtraLayout.LayoutControlItem lciHoraEntrega;
        private DevExpress.XtraLayout.LayoutControlItem lciComentarios;
        private DevExpress.XtraLayout.LayoutControlItem lciUnidad;
        private DevExpress.XtraBars.BarButtonItem bbiRegreso;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.SimpleLabelItem lblTotal;
        private DevExpress.XtraLayout.SimpleLabelItem lblDetalleEntrega;
    }
}