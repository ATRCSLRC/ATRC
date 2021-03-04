using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class xfrmAclaraciones : xfrmBase
    {
        public xfrmAclaraciones()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmAclaraciones_Load(object sender, EventArgs e)
        {
            dteA.DateTime = dteDe.DateTime = DateTime.Now;
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Pedido.Empresa.Oid", lueEmpresa.EditValue));
            go.Operands.Add(new BetweenOperator("FechaAlta", dteDe.DateTime.Date, dteA.DateTime.Date));
            XPView Aclaraciones = new XPView(Unidad, typeof(AclaracionesPedido));
            Aclaraciones.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Oid", SortDirection.None, "[Oid]", true, true),
            new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", true, true),
            new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", true, true),
            new ViewProperty("UsuarioAlta", SortDirection.None, "[UsuarioAlta]", true, true),
            //new ViewProperty("Pedido", SortDirection.None, "[Pedido]", true, true),
            //new ViewProperty("Pedido.Oid", SortDirection.None, "[Pedido.Oid]", true, true),
            new ViewProperty("PedidoNombre", SortDirection.None, "[Pedido.Nombre]", true, true),
            new ViewProperty("EmpresaNombre", SortDirection.None, "[Pedido.Empresa.Nombre]", true, true),
            new ViewProperty("Estado", SortDirection.Ascending, "[Estado]", true, true)});
            Aclaraciones.Criteria = go;
            Aclaraciones.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdAclaraciones.DataSource = Aclaraciones;
        }

        private void lueEmpresa_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                e.DisplayText = row["Clave"] + " - " + row["Nombre"];
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

        private void ribeHistoria_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                xfrmHistorialAclaraciones xfrm = new xfrmHistorialAclaraciones();
                xfrm.IDAclaracion = Convert.ToInt32(ViewAclaracion["Oid"]);
                xfrm.ShowDialog();
            }
        }
    }
}
