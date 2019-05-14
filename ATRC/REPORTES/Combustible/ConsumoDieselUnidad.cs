using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using COMBUSTIBLE.BL;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;

namespace REPORTES.Combustible
{
    public partial class ConsumoDieselUnidad : DevExpress.XtraReports.UI.XtraReport
    {
        public ConsumoDieselUnidad(DateTime De, DateTime Al, int Oid, Type clase)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Fecha", De.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", Al.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Unidad.Oid", Oid));
            go.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
            XPView Diesel = new XPView(Unidad, clase, "Oid;Millas;Fecha;Litros;UltimaRecarga.PrecioLitro;MillasRecorridas;Unidad.Nombre;Unidad.Oid", go );
            Diesel.Sorting.Add(new SortProperty("Fecha", SortingDirection.Ascending));
            this.DataSource = Diesel;
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
