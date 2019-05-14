using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using ATRCBASE.BL;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;

namespace REPORTES.Combustible
{
    public partial class UnidadesConDiesel : DevExpress.XtraReports.UI.XtraReport
    {
        public UnidadesConDiesel(DateTime De, DateTime Al, Type Clase)
        {
            InitializeComponent();
            this.lblMes.Text = "Del: " + De.ToLongDateString() + " Al: " + Al.ToLongDateString();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Fecha", De.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", Al.Date, BinaryOperatorType.LessOrEqual));
            XPView Diesel = new XPView(Unidad, Clase, "Oid;Fecha;Litros;CandadoActual;Empleado.Nombre", go);
            Diesel.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Unidad.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Diesel;
        }

    }
}
