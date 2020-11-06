using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
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
    public partial class xfrmPedidosCancelados : xfrmBase
    {
        public xfrmPedidosCancelados()
        {
            InitializeComponent();
        }

        private void xfrmPedidosCancelados_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator Go = new GroupOperator(GroupOperatorType.Or);
            //Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Cancelado));
            Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Rechazado));
            XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
            Pedidos.AddProperty("Oid", "Oid", true);
            Pedidos.AddProperty("Nombre", "Nombre", true);
            Pedidos.AddProperty("Estado", "Estado", true);
            Pedidos.AddProperty("FechaPedido", "Fecha", true);
            Pedidos.AddProperty("Empresa", "Empresa.Nombre", true);
            Pedidos.AddProperty("Fecha", "FechaAlta", true);
            Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
            Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
            Pedidos.Criteria = Go;
            grdPedidosCancelados.DataSource = Pedidos;
        }

        private void ribeRutas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosCancelados.GetRow(grvPedidosCancelados.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmRevisionPedido xfrm = new xfrmRevisionPedido();
                xfrm.Oid = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void ribeHistorial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosCancelados.GetRow(grvPedidosCancelados.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmHistorialPedido xfrm = new xfrmHistorialPedido();
                xfrm.OID = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }

        
    }
}
