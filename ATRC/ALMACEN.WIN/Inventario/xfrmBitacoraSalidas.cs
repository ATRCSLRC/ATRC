using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALMACEN.WIN
{
    public partial class xfrmBitacoraSalidas : xfrmBase
    {
        public xfrmBitacoraSalidas()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmBitacoraSalidas_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteDel.DateTime = dteAl.DateTime = DateTime.Now;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Fecha", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
            if (rgOpcion.SelectedIndex == 1)
                go.Operands.Add(new BinaryOperator("Articulo.Codigo", txtCodigo.Text));

            XPView Salidas = new XPView(Unidad, typeof(SalidaArticulo));
            Salidas.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Estado", SortDirection.None, "[Estado]", false, true),
                  new ViewProperty("Articulo.Codigo", SortDirection.None, "[Articulo.Codigo]", false, true),
                  new ViewProperty("Articulo.Nombre", SortDirection.None, "[Articulo.Nombre]", false, true),
                  new ViewProperty("Cantidad", SortDirection.None, "[Cantidad]", false, true),
                  new ViewProperty("Destino", SortDirection.None, "iif([Unidad] is null,[OtroDestino],[Unidad.Nombre])",false, true),
                  new ViewProperty("Recibio", SortDirection.None,  "iif([UsuarioRecibo] is null,[OtroRecibo],[UsuarioRecibo.Nombre])", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[Fecha]", false, true)
                 });
            Salidas.Criteria = go;

            grdSalida.DataSource = Salidas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grdSalida.DataSource = null;
            rgOpcion.SelectedIndex = 0;
            txtCodigo.Text = string.Empty;
            dteDel.Focus();
        }

        private void rgOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioGroup)sender).SelectedIndex == 0)
                lciCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void ribtnDevolver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewSalida = (ViewRecord)grvSalidas.GetRow(grvSalidas.FocusedRowHandle);
            if (ViewSalida != null)
            {
                SalidaArticulo Salida = (SalidaArticulo)ViewSalida.GetObject();

                if (Salida.Estado == Enums.EstadoSalida.Entregado)
                {
                    XtraInputBoxArgs args = new XtraInputBoxArgs();
                    args.Caption = "Devolver artículo '" + Salida.Articulo.Nombre + "'";
                    args.Prompt = "Cantidad:";
                    SpinEdit editor = new SpinEdit();
                    editor.Properties.MinValue = 1;
                    editor.Properties.MaxValue = Salida.Cantidad;
                    args.Editor = editor;
                    args.DefaultResponse = Salida.Cantidad;
                    var result = XtraInputBox.Show(args);
                    if (result != null)
                    {
                        Salida.Factura.Cantidad += Convert.ToDecimal(result);
                        if (Convert.ToDecimal(result) == Salida.Cantidad)
                            Salida.Estado = Enums.EstadoSalida.Devuelto;
                        else
                            Salida.Cantidad -= Convert.ToInt32(result);

                        Salida.Save();
                        Unidad.CommitChanges();
                        (grdSalida.DataSource as XPView).Reload();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Ya se ha devuelto este artículo.");
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                btnBusqueda.PerformClick();
                return true;
            }
            if (keyData == Keys.F12)
            {
                btnCancelar.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void grvSalidas_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //if (e.Column.Caption == "Devolver")
            //{
            //    ViewRecord ViewSalida = (ViewRecord)grvSalidas.GetRow(e.RowHandle);
            //    RepositoryItemButtonEdit emptyEditor = new RepositoryItemButtonEdit();
            //    emptyEditor.ReadOnly = true;
            //    emptyEditor.TextEditStyle = TextEditStyles.DisableTextEditor;
            //    emptyEditor.Buttons.Clear();

            //    if (((SalidaArticulo)ViewSalida.GetObject()).Estado == Enums.EstadoSalida.Devuelto)
            //        e.RepositoryItem = emptyEditor;
            //}
        }

        private void ribtnImprimir_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ViewRecord ViewSalida = (ViewRecord)grvSalidas.GetRow(grvSalidas.FocusedRowHandle);
            if (ViewSalida != null)
            {
                SalidaArticulo Salida = (SalidaArticulo)ViewSalida.GetObject();
                REPORTES.Almacen.TicketEntregaArticulo Ticket = new REPORTES.Almacen.TicketEntregaArticulo(Salida);

                ReportPrintTool printTool = new ReportPrintTool(Ticket);
                ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ImpresoraTicketsAlmacen"));
                if (Configuracion != null)
                {
                    Ticket.CreateDocument();
                    Ticket.PrinterName = Configuracion.Accion;
                    printTool.Print(Configuracion.Accion);
                }
            }
        }
    }
}
