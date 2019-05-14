using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmProblemasCandados : xfrmBase
    {
        public xfrmProblemasCandados()
        {
            InitializeComponent();
        }

        private void xfrmProblemasCandados_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void bbiDetalleProblema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Candados ViewCandados = grvProblemasCandados.GetFocusedRow() as Candados;
            if (ViewCandados != null)
            {
                xfrmandados xfrm = new xfrmandados();
                xfrm.UnidadTransporte = Convert.ToInt32(ViewCandados.Oid);
                xfrm.EsListaProblemas = true;
                xfrm.ShowInTaskbar = false;
                xfrm.ShowDialog();
                ActualizarLista();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ActualizarLista()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Candados> Candados = new List<Candados>();
            XPView Detalles = new XPView(Unidad, typeof(DetallesCandados), "Oid;FechaAlta;Unidad.Oid;Unidad.Nombre", new BinaryOperator("Verificado", false));

            foreach (ViewRecord viewCandados in Detalles)
            {
                Candados Candado = new Candados();
                Candado.Oid = Convert.ToInt32(viewCandados["Oid"]);
                Candado.FechaAlta = Convert.ToDateTime(viewCandados["FechaAlta"]).ToShortDateString();
                Candado.Nombre = viewCandados["Unidad.Nombre"].ToString();
                GroupOperator go = new GroupOperator(GroupOperatorType.And);
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Convert.ToInt32(viewCandados["Unidad.Oid"])));
                go.Operands.Add(new BinaryOperator("Fecha", Convert.ToDateTime(viewCandados["FechaAlta"]).Date, BinaryOperatorType.LessOrEqual));
                go.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                XPView DieselAnterior = new XPView(Unidad, typeof(Diesel), "Oid;CandadoActual;CandadoAnterior", go);
                DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));

                Candado.CandadoAnterior = DieselAnterior[1]["CandadoActual"].ToString();
                Candado.CandadoActual = DieselAnterior[0]["CandadoAnterior"].ToString();
                Candados.Add(Candado);

            }

            grdProblemasCandados.DataSource = Candados;
        }
        public class Candados
        {
            public int Oid { set; get; }
            public string FechaAlta { set; get; }
            public string Nombre { set; get; }
            public string CandadoAnterior { set; get; }
            public string CandadoActual { set; get; }
        }
    }
}
