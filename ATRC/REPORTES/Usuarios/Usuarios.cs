using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;
using CHECADOR.BL;

namespace REPORTES.Usuarios
{
    public partial class Usuarios : DevExpress.XtraReports.UI.XtraReport
    {
        public Usuarios()
        {
            InitializeComponent();

            XPView Usuarios = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(ATRCBASE.BL.Usuario), "Nombre;NumEmpleado;RFC;Puesto.Descripcion;Departamento.Descripcion;IMSS", new BinaryOperator("Activo", true));
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Usuarios;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ViewRecord view = this.GetCurrentRow() as ViewRecord;
            UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            tlHoras.Text = HorasTrabajadas(Unidad, Convert.ToInt32(view["NumEmpleado"]), new DateTime(2019,7,8), new DateTime(2019,7,14)).ToString();
        }

        public static decimal HorasTrabajadas(UnidadDeTrabajo Unidad, int usuario, DateTime FechaInicial, DateTime FechaFinal)
        {
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaFinal.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Usuario", CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, usuario)));
            XPView Checadas = new XPView(Unidad, typeof(HistoricoChecadas), "Oid;FechaChecada;HoraChecadaEntrada;HoraChecadaSalida;Usuario", go);
            decimal Horas = 0;
            foreach (ViewRecord ViewHistorico in Checadas)
            {
                decimal HoraEntrada = ViewHistorico["HoraChecadaEntrada"] == null ? 0 : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)ViewHistorico["HoraChecadaEntrada"]);
                decimal HoraSalida = ViewHistorico["HoraChecadaSalida"] == null ? HoraEntrada : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)ViewHistorico["HoraChecadaSalida"]);

                //if (HoraSalida > 0 & HoraEntrada > 0)
                if ((HoraSalida > HoraEntrada))
                    Horas += (HoraSalida - HoraEntrada);
                else
                    Horas += (HoraSalida - HoraEntrada) == 0 ? 0 : ((HoraSalida - HoraEntrada) + 24);
            }
            return Horas;
        }
    }
}
