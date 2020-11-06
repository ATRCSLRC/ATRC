using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.PedidoRutas
{
    public partial class xfrmPedidos : xfrmBase
    {
        public xfrmPedidos()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmPedidos_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteDe.DateTime = dteA.DateTime = DateTime.Now;
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator Go = new GroupOperator();
            Go.Operands.Add(new BetweenOperator("Fecha", dteDe.DateTime.Date, dteA.DateTime.Date));
            Go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresa.EditValue));
            Go.Operands.Add(new NotOperator(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Creado)));
            Go.Operands.Add(new NotOperator(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Pendiente)));
            Go.Operands.Add(new NotOperator(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Cancelado)));

            XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
            Pedidos.AddProperty("Oid", "Oid", true);
            Pedidos.AddProperty("Nombre", "Nombre", true);
            Pedidos.AddProperty("Estado", "Estado", true);
            Pedidos.AddProperty("FechaPedido", "Fecha", true);
            Pedidos.AddProperty("Fecha", "FechaAlta", true);
            Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
            Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
            Pedidos.Criteria = Go;
            grdPedidos.DataSource = Pedidos;
        }

        private void ribeRutas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidos.GetRow(grvPedidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmRevisionPedido xfrm = new xfrmRevisionPedido();
                xfrm.Oid = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void ribeHistorial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidos.GetRow(grvPedidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmHistorialPedido xfrm = new xfrmHistorialPedido();
                xfrm.OID = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void grvPedidos_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            ViewRecord viewPedido = grvPedidos.GetRow(e.RowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                if (e.Column.Caption == "Rutas")
                {
                    if ((Enums.EstadoPedidoRutas)viewPedido["Estado"] != Enums.EstadoPedidoRutas.Enviado)
                        e.RepositoryItem = ribeRutas;

                }

            }
        }
    }
}
