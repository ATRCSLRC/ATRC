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
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmCalculosCarga : xfrmBase
    {
        public xfrmCalculosCarga()
        {
            InitializeComponent();
        }

        public Enums.Combustible Tipo;

        private void xfrmCalculosCarga_Load(object sender, EventArgs e)
        {
            this.Text = "Cálculos de carga " + Tipo.ToString();

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<MedidorTanques> ListaMedidor = new List<MedidorTanques>();
            XPView Medidores = new XPView(Unidad, typeof(COMBUSTIBLE.BL.MedidorDiesel));
            Medidores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Tanque.Descripcion]", false, true),
                  new ViewProperty("Inicial", SortDirection.None, "[Inicial]", false, true),
                  new ViewProperty("Final", SortDirection.None, "[Final]", false, true),
                  new ViewProperty("Total", SortDirection.None, "([Final] - [Inicial])", false, true)
                 });
            Medidores.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending)));
            Medidores.Criteria = new BinaryOperator("Tanque.TipoCombustible", Tipo);
            int cont = 1;
            foreach (ViewRecord viewMedidor in Medidores)
            {

                XPView Diesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel));
                Diesel.Criteria = new BinaryOperator("MedidorDiesel.Oid", viewMedidor["Oid"]);
                Diesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });

                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                MedidorTanques Medidor = new MedidorTanques();
                Medidor.Fecha = Convert.ToDateTime(viewMedidor["Fecha"]).ToShortDateString();
                Medidor.Nombre = viewMedidor["Nombre"].ToString();
                Medidor.Inicial = viewMedidor["Inicial"].ToString();
                Medidor.Final = viewMedidor["Final"].ToString();
                Medidor.TotalMedidor = viewMedidor["Total"].ToString();
                Medidor.TotalTanque = TotalTanque.ToString();
                Medidor.Diferencia = (Convert.ToInt32(viewMedidor["Total"]) - TotalTanque).ToString();
                ListaMedidor.Add(Medidor);
                cont++;
                if (cont == 16)
                    break;
            }
            grdCalculos.DataSource = ListaMedidor;
        }

        public class MedidorTanques
        {
            public string Nombre { set; get; }
            public string Fecha { set; get; }
            public string Inicial { set; get; }
            public string Final { set; get; }
            public string TotalMedidor { set; get; }
            public string TotalTanque { set; get; }
            public string Diferencia { set; get; }
        }
    }
}
