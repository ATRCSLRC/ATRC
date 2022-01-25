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
        UnidadDeTrabajo Unidad;
        private void xfrmCalculosCarga_Load(object sender, EventArgs e)
        {
            this.Text = "Cálculos de carga " + Tipo.ToString();

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Inicio();
        }

        public class MedidorTanques
        {
            public Int32 ID { set; get; }
            public string Nombre { set; get; }
            public DateTime Fecha { set; get; }
            public string Inicial { set; get; }
            public string Final { set; get; }
            public string TotalMedidor { set; get; }
            public string TotalTanque { set; get; }
            public string Diferencia { set; get; }
        }

        private void bbiAvanzado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dteDe.DateTime = dteA.DateTime = DateTime.Now.Date;
            grdCalculos.DataSource = null;
            if(lcgBusqueda.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                lcgBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Inicio();
            }
            else
            {
                lcgBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            List<MedidorTanques> ListaMedidor = new List<MedidorTanques>();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Tipo));
            go.Operands.Add(new BetweenOperator("FechaAlta", dteDe.DateTime.Date, dteA.DateTime.Date));
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
            Medidores.Criteria = go;//new BinaryOperator("Tanque.TipoCombustible", Tipo);
            //int cont = 1;
            foreach (ViewRecord viewMedidor in Medidores)
            {

                XPView Diesel = new XPView(Unidad, Tipo == Enums.Combustible.Diesel ? typeof(COMBUSTIBLE.BL.Diesel) : typeof(COMBUSTIBLE.BL.Gasolina));
                if (Tipo == Enums.Combustible.Diesel)
                    Diesel.Criteria = new BinaryOperator("MedidorDiesel.Oid", viewMedidor["Oid"]);
                else
                    Diesel.Criteria = new BinaryOperator("MedidorGasolinas.Oid", viewMedidor["Oid"]);
                Diesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });

                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                MedidorTanques Medidor = new MedidorTanques();
                Medidor.Fecha = Convert.ToDateTime(viewMedidor["Fecha"]);
                Medidor.Nombre = viewMedidor["Nombre"].ToString();
                Medidor.Inicial = viewMedidor["Inicial"].ToString();
                Medidor.Final = viewMedidor["Final"].ToString();
                Medidor.TotalMedidor = viewMedidor["Total"].ToString();
                Medidor.TotalTanque = TotalTanque.ToString();
                Medidor.Diferencia = (Convert.ToInt32(viewMedidor["Total"]) - TotalTanque).ToString();
                ListaMedidor.Add(Medidor);
                //cont++;
                //if (cont == 16)
                //    break;
            }
            grdCalculos.DataSource = ListaMedidor;
        }

        private void Inicio()
        {
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
                XPView Diesel = new XPView(Unidad, Tipo == Enums.Combustible.Diesel ? typeof(COMBUSTIBLE.BL.Diesel) : typeof(COMBUSTIBLE.BL.Gasolina));
                if (Tipo == Enums.Combustible.Diesel)
                    Diesel.Criteria = new BinaryOperator("MedidorDiesel.Oid", viewMedidor["Oid"]);
                else
                    Diesel.Criteria = new BinaryOperator("MedidorGasolinas.Oid", viewMedidor["Oid"]);
                Diesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });

                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                MedidorTanques Medidor = new MedidorTanques();
                Medidor.ID = Convert.ToInt32(viewMedidor["Oid"]);
                Medidor.Fecha = Convert.ToDateTime(viewMedidor["Fecha"]);
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

        private void bbiReabrir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MedidorTanques Medidor = grvCalculos.GetFocusedRow() as MedidorTanques;
            if(Medidor != null)
            {
                if (Convert.ToInt64(Medidor.Final) > 0)
                {
                    if (XtraMessageBox.Show("¿Desea reabrir el medidor seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        COMBUSTIBLE.BL.MedidorDiesel MedidorDiesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.MedidorDiesel>(Medidor.ID);
                        MedidorDiesel.Final = 0;
                        MedidorDiesel.LitrosEnTanque = 0;
                        MedidorDiesel.LitrosCapturados = 0;
                        MedidorDiesel.Save();
                        MedidorDiesel.Session.CommitTransaction();
                        Inicio();
                    }
                }else
                {
                    XtraMessageBox.Show("No se puede reabrir porque aun no se ha cerrado.");
                }
            }
        }
    }
}
