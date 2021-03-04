using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmAclaracionesRechazadas : xfrmBase
    {
        public xfrmAclaracionesRechazadas()
        {
            InitializeComponent();
        }

        private void xfrmAclaracionesRechazadas_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Aclaraciones = new XPView(Unidad, typeof(AclaracionesPedido));
            Aclaraciones.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Oid", SortDirection.None, "[Oid]", true, true),
            new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", true, true),
            new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", true, true),
            new ViewProperty("UsuarioAlta", SortDirection.None, "[UsuarioAlta]", true, true),
            new ViewProperty("Pedido", SortDirection.None, "[Pedido]", true, true),
            new ViewProperty("Pedido.Oid", SortDirection.None, "[Pedido.Oid]", true, true),
            new ViewProperty("PedidoNombre", SortDirection.None, "[Pedido.Nombre]", true, true),
            new ViewProperty("EmpresaNombre", SortDirection.None, "[Pedido.Empresa.Nombre]", true, true),
            new ViewProperty("Estado", SortDirection.Ascending, "[Estado]", true, true)});
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoAclaraciones.Rechazada_Maquiladora));
            go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoAclaraciones.Rechazada_Rutas));
            Aclaraciones.Criteria = go;
            Aclaraciones.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdAclaraciones.DataSource = Aclaraciones;
        }

        private void grvAclaraciones_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Empresas" & e.ListSourceRowIndex >= 0)
            {
                object Pedido = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "Pedido");
                if (Pedido != null)
                {
                    e.DisplayText = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "EmpresaNombre").ToString();
                }
                else
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Usuario Usuario = Unidad.GetObjectByKey<Usuario>(grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "UsuarioAlta"));
                    e.DisplayText = Usuario == null ? "" : Usuario.Empresa == null ? "" : Usuario.Empresa.Nombre;
                }

            }

            if (e.Column.FieldName == "Pedidos" & e.ListSourceRowIndex >= 0)
            {
                object Pedido = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "Pedido");
                if (Pedido != null)
                {
                    e.DisplayText = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "PedidoNombre").ToString();
                }
            }
        }

        private void ribeDescarga_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvAclaraciones.GetRow(grvAclaraciones.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                REPORTES.Rutas.AclaracionesPedido Rutas = new REPORTES.Rutas.AclaracionesPedido(Convert.ToInt32(viewPedido["Pedido.Oid"]), Convert.ToInt32(viewPedido["Oid"]));
                ReportPrintTool repRutas = new ReportPrintTool(Rutas);
                repRutas.ShowPreview();
            }
        }

        private void ribeHistorial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                xfrmHistorialAclaraciones xfrm = new xfrmHistorialAclaraciones();
                xfrm.IDAclaracion = Convert.ToInt32(ViewAclaracion["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void grvAclaraciones_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            ViewRecord viewPedido = grvAclaraciones.GetRow(e.RowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                if (e.Column.Caption == "Descarga")
                {
                    if (viewPedido["Pedido"] != null)
                        e.RepositoryItem = ribeDescarga;

                }

            }
        }
    }
}
