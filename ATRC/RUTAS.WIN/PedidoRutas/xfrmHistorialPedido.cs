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
    public partial class xfrmHistorialPedido : xfrmBase
    {
        public xfrmHistorialPedido()
        {
            InitializeComponent();
        }
        public int OID; 
        private void xfrmHistorialPedido_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView HistorialPedidos = new XPView(Unidad, typeof(RUTAS.BL.HistorialPedidoRutas));
            HistorialPedidos.AddProperty("Oid", "Oid", true);
            HistorialPedidos.AddProperty("Detalle", "Detalle", true);
            HistorialPedidos.AddProperty("Estado", "Estado", true);
            HistorialPedidos.AddProperty("HorarioModificacion", "HorarioModificacion", true);
            HistorialPedidos.AddProperty("Usuario", "Usuario.Nombre", true);
            HistorialPedidos.Criteria = new BinaryOperator("PedidoRutas", OID);
            grdHistorial.DataSource = HistorialPedidos;
        }
    }
}
