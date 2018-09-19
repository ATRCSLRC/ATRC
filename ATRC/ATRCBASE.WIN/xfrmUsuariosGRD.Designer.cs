namespace ATRCBASE.WIN
{
    partial class xfrmUsuariosGRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmUsuariosGRD));
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.rbnUsuarios = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModificarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalirUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAsignar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGafete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDesactivarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGafete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSalir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdUsuarios = new DevExpress.XtraGrid.GridControl();
            this.grvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbnUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "barButtonItem1";
            this.bbiSalir.Id = 4;
            this.bbiSalir.Name = "bbiSalir";
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "barButtonItem1";
            this.bbiEliminar.Id = 3;
            this.bbiEliminar.Name = "bbiEliminar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // rbnUsuarios
            // 
            this.rbnUsuarios.ExpandCollapseItem.Id = 0;
            this.rbnUsuarios.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnUsuarios.ExpandCollapseItem,
            this.bbiNuevos,
            this.bbiModificarUsuario,
            this.bbiEliminarUsuario,
            this.bbiSalirUsuario,
            this.bbiAsignar,
            this.bbiGafete,
            this.bbiDesactivarEmpleado});
            this.rbnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.rbnUsuarios.MaxItemId = 8;
            this.rbnUsuarios.Name = "rbnUsuarios";
            this.rbnUsuarios.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rbnUsuarios.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rbnUsuarios.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.rbnUsuarios.ShowToolbarCustomizeItem = false;
            this.rbnUsuarios.Size = new System.Drawing.Size(554, 122);
            this.rbnUsuarios.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevos
            // 
            this.bbiNuevos.Caption = "Nuevo";
            this.bbiNuevos.Id = 1;
            this.bbiNuevos.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.AgregarUsuario;
            this.bbiNuevos.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiNuevos.Name = "bbiNuevos";
            this.bbiNuevos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiNuevos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevos_ItemClick);
            // 
            // bbiModificarUsuario
            // 
            this.bbiModificarUsuario.Caption = "Modificar";
            this.bbiModificarUsuario.Id = 2;
            this.bbiModificarUsuario.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.ModificarUsuario;
            this.bbiModificarUsuario.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.bbiModificarUsuario.Name = "bbiModificarUsuario";
            this.bbiModificarUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiModificarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarUsuario_ItemClick);
            // 
            // bbiEliminarUsuario
            // 
            this.bbiEliminarUsuario.Caption = "Eliminar";
            this.bbiEliminarUsuario.Id = 3;
            this.bbiEliminarUsuario.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.EliminarUsuario;
            this.bbiEliminarUsuario.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.bbiEliminarUsuario.Name = "bbiEliminarUsuario";
            this.bbiEliminarUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiEliminarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarUsuario_ItemClick);
            // 
            // bbiSalirUsuario
            // 
            this.bbiSalirUsuario.Caption = "Salir";
            this.bbiSalirUsuario.Id = 4;
            this.bbiSalirUsuario.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.Salir;
            this.bbiSalirUsuario.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bbiSalirUsuario.Name = "bbiSalirUsuario";
            this.bbiSalirUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSalirUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalirUsuario_ItemClick);
            // 
            // bbiAsignar
            // 
            this.bbiAsignar.Caption = "Asignar";
            this.bbiAsignar.Id = 5;
            this.bbiAsignar.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.AsignarUsuario;
            this.bbiAsignar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.bbiAsignar.Name = "bbiAsignar";
            this.bbiAsignar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAsignar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAsignar_ItemClick);
            // 
            // bbiGafete
            // 
            this.bbiGafete.Caption = "Imprimir Gafete";
            this.bbiGafete.Id = 6;
            this.bbiGafete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGafete.ImageOptions.Image")));
            this.bbiGafete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGafete.ImageOptions.LargeImage")));
            this.bbiGafete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10);
            this.bbiGafete.Name = "bbiGafete";
            this.bbiGafete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiGafete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGafete_ItemClick);
            // 
            // bbiDesactivarEmpleado
            // 
            this.bbiDesactivarEmpleado.Caption = "Activar/Desactivar empleado";
            this.bbiDesactivarEmpleado.Id = 7;
            this.bbiDesactivarEmpleado.ImageOptions.LargeImage = global::ATRCBASE.WIN.Properties.Resources.icons8_usuario_32;
            this.bbiDesactivarEmpleado.Name = "bbiDesactivarEmpleado";
            this.bbiDesactivarEmpleado.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDesactivarEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDesactivarEmpleado_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAcciones,
            this.rpgGafete,
            this.rpgSalir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgAcciones
            // 
            this.rpgAcciones.AllowTextClipping = false;
            this.rpgAcciones.ItemLinks.Add(this.bbiAsignar);
            this.rpgAcciones.ItemLinks.Add(this.bbiNuevos);
            this.rpgAcciones.ItemLinks.Add(this.bbiModificarUsuario);
            this.rpgAcciones.ItemLinks.Add(this.bbiEliminarUsuario);
            this.rpgAcciones.Name = "rpgAcciones";
            this.rpgAcciones.ShowCaptionButton = false;
            // 
            // rpgGafete
            // 
            this.rpgGafete.AllowTextClipping = false;
            this.rpgGafete.ItemLinks.Add(this.bbiDesactivarEmpleado);
            this.rpgGafete.ItemLinks.Add(this.bbiGafete);
            this.rpgGafete.Name = "rpgGafete";
            this.rpgGafete.ShowCaptionButton = false;
            // 
            // rpgSalir
            // 
            this.rpgSalir.AllowTextClipping = false;
            this.rpgSalir.ItemLinks.Add(this.bbiSalirUsuario);
            this.rpgSalir.Name = "rpgSalir";
            this.rpgSalir.ShowCaptionButton = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdUsuarios);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 122);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(554, 350);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grdUsuarios.MainView = this.grvUsuarios;
            this.grdUsuarios.MenuManager = this.rbnUsuarios;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.Size = new System.Drawing.Size(530, 326);
            this.grdUsuarios.TabIndex = 4;
            this.grdUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUsuarios});
            // 
            // grvUsuarios
            // 
            this.grvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumUsuario,
            this.colNombre,
            this.colActivo});
            this.grvUsuarios.GridControl = this.grdUsuarios;
            this.grvUsuarios.Name = "grvUsuarios";
            this.grvUsuarios.OptionsBehavior.Editable = false;
            this.grvUsuarios.OptionsBehavior.ReadOnly = true;
            this.grvUsuarios.OptionsFind.AlwaysVisible = true;
            this.grvUsuarios.OptionsView.AllowHtmlDrawGroups = false;
            this.grvUsuarios.OptionsView.ShowDetailButtons = false;
            this.grvUsuarios.OptionsView.ShowGroupPanel = false;
            // 
            // colNumUsuario
            // 
            this.colNumUsuario.Caption = "Número empleado";
            this.colNumUsuario.FieldName = "NumEmpleado";
            this.colNumUsuario.Name = "colNumUsuario";
            this.colNumUsuario.OptionsColumn.AllowFocus = false;
            this.colNumUsuario.Visible = true;
            this.colNumUsuario.VisibleIndex = 0;
            this.colNumUsuario.Width = 119;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 339;
            // 
            // colActivo
            // 
            this.colActivo.Caption = "Activo";
            this.colActivo.FieldName = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.OptionsColumn.AllowEdit = false;
            this.colActivo.OptionsColumn.AllowFocus = false;
            this.colActivo.Visible = true;
            this.colActivo.VisibleIndex = 2;
            this.colActivo.Width = 54;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(554, 350);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUsuarios;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(534, 330);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfrmUsuariosGRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 472);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.rbnUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfrmUsuariosGRD";
            this.Ribbon = this.rbnUsuarios;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.xfrmUsuariosGRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbnUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSalir;
        private DevExpress.XtraBars.BarButtonItem bbiEliminar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbnUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAcciones;
        private DevExpress.XtraBars.BarButtonItem bbiNuevos;
        private DevExpress.XtraBars.BarButtonItem bbiModificarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiSalirUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSalir;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl grdUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUsuarios;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraBars.BarButtonItem bbiAsignar;
        private DevExpress.XtraBars.BarButtonItem bbiGafete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGafete;
        private DevExpress.XtraBars.BarButtonItem bbiDesactivarEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
    }
}