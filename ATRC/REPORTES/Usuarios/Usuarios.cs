using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;
using CHECADOR.BL;
using System.Collections.Generic;
using System.Data;

namespace REPORTES.Usuarios
{
    public partial class Usuarios : DevExpress.XtraReports.UI.XtraReport
    {
        public UnidadDeTrabajo Unidad;
        DateTime DeInicio;
        DateTime AlFinal;
        public Usuarios(DateTime De, DateTime Al, bool Todos, bool OrdenEmpleado)
        {
            InitializeComponent();

            DeInicio = De;
            AlFinal = Al;

            lblFecha.Text = "Del: " + De.ToLongDateString() + " al: " + Al.ToLongDateString();
            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Activo", true));
            if (!Todos)
                go.Operands.Add(new BinaryOperator("EsAdministrativo", false));
            XPView Usuarios = new XPView(Unidad, typeof(ATRCBASE.BL.Usuario), "NumEmpleado;Nombre", go);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));

            DataTable Tabla = CreateDataTableFromXPView(Usuarios);
            Tabla.DefaultView.Sort = OrdenEmpleado ? "NumEmpleado asc" : "HorasTrabajadas desc";

            this.DataSource = Tabla;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //ViewRecord view = this.GetCurrentRow() as ViewRecord;
            //UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //tlHoras.Text = HorasTrabajadas(Unidad, Convert.ToInt32(view["NumEmpleado"]), new DateTime(2019, 7, 8), new DateTime(2019, 7, 14)).ToString();
           //Detail.SortFields.Add(new GroupField("Horas", XRColumnSortOrder.Ascending));
            //GroupField sortField = new GroupField("Horas");
            //sortField.SortOrder = XRColumnSortOrder.Descending;
            //this.Detail.SortFields.Add(sortField);
        }

        private DataTable CreateDataTableFromXPView(XPView view)
        {
            DataTable result = new DataTable();
            result.Columns.Add("NumEmpleado", typeof(Int32));
            result.Columns.Add("Nombre", typeof(string));
            result.Columns.Add("HorasTrabajadas", typeof(decimal));

            //foreach (property in view.Properties)
            //    result.Columns.Add(property.Name, view.ObjectClassInfo.GetMember(property.Name).MemberType);
            foreach (ViewRecord record in view)
                result.Rows.Add(GetRecordValues(record));
            return result;
        }

        private object[] GetRecordValues(ViewRecord record)
        {
            ArrayList result = new ArrayList();
            foreach (ViewProperty property in record.View.Properties)
                result.Add(record[property.Property]);
            result.Add(HorasTrabajadas(Unidad, Convert.ToInt32(record["NumEmpleado"]), DeInicio, AlFinal));
            return result.ToArray();
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
