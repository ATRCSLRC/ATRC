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
using RUTAS.BL;

namespace REPORTES.Rutas
{
    public partial class RutasFijasUsuario : DevExpress.XtraReports.UI.XtraReport
    {
        public UnidadDeTrabajo Unidad;
        DateTime DeInicio;
        DateTime AlFinal;
        public RutasFijasUsuario(DateTime De, DateTime Al, string Empresa, bool EsAdministracion)
        {
            InitializeComponent();

            DeInicio = De;
            AlFinal = Al;


            lblNombreReporte.Text = "Rutas " + (EsAdministracion ? " Administrativo" : "Operativo") + " - " + Empresa;
            lblFecha.Text = "Del: " + De.ToLongDateString() + " al: " + Al.ToLongDateString();
            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Activo", true));
            go.Operands.Add(new BinaryOperator("EsAdministrativo", EsAdministracion));
            go.Operands.Add(new BinaryOperator("Patron", Empresa));
            //if (!Todos)
            //go.Operands.Add(new BinaryOperator("EsAdministrativo", false));
            XPView Usuarios = new XPView(Unidad, typeof(ATRCBASE.BL.Usuario), "NumEmpleado;Nombre", go);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));

            DataTable Tabla = CreateDataTableFromXPView(Usuarios);
            Tabla.DefaultView.RowFilter = "RutasLaboradas > 0 OR RutasExtras > 0";
            //Tabla.DefaultView.Sort = "HorasTrabajadas desc";

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
            result.Columns.Add("RutasLaboradas", typeof(decimal));
            result.Columns.Add("Total", typeof(decimal));
            result.Columns.Add("RutasExtras", typeof(decimal));
            result.Columns.Add("TotalExtras", typeof(decimal));

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
            result.Add(HorasTrabajadas(Unidad, Convert.ToInt32(record["NumEmpleado"]), DeInicio, AlFinal, false));
            result.Add(Convert.ToInt32(result[2]) * Convert.ToDecimal(8.5));
            result.Add(HorasTrabajadas(Unidad, Convert.ToInt32(record["NumEmpleado"]), DeInicio, AlFinal, true));
            result.Add(Convert.ToInt32(result[4]) * Convert.ToDecimal(8.5));
            return result.ToArray();
        }

        public static decimal HorasTrabajadas(UnidadDeTrabajo Unidad, int usuario, DateTime FechaInicial, DateTime FechaFinal, bool EsExtra)
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaRuta", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaRuta", FechaFinal.Date, BinaryOperatorType.LessOrEqual));

            GroupOperator goChofer = new GroupOperator(GroupOperatorType.Or);

            GroupOperator goChoferEntrada = new GroupOperator(GroupOperatorType.And);
            goChoferEntrada.Operands.Add(new BinaryOperator("ChoferEntrada.NumEmpleado", usuario));
            goChoferEntrada.Operands.Add(new BinaryOperator("PagarChoferEntrada", EsExtra));
            goChofer.Operands.Add(goChoferEntrada);

            GroupOperator goChoferSalida = new GroupOperator(GroupOperatorType.And);
            goChoferSalida.Operands.Add(new BinaryOperator("ChoferSalida.NumEmpleado", usuario));
            goChoferSalida.Operands.Add(new BinaryOperator("PagarChoferSalida", EsExtra));
            goChofer.Operands.Add(goChoferSalida);


            go.Operands.Add(goChofer);
            XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;RutaCompleta;TipoRuta", go);
            decimal TotalRutas = 0;
            foreach (ViewRecord ViewRutas in Rutas)
            {
                if(Convert.ToBoolean(ViewRutas["RutaCompleta"]))
                {
                    if((Enums.TipoRuta)ViewRutas["TipoRuta"] == Enums.TipoRuta.Normal)
                        TotalRutas += 2;
                    else
                        TotalRutas++;
                }
                else
                {
                    TotalRutas++;
                }
            }
            return TotalRutas;
        }

       
    }
}
