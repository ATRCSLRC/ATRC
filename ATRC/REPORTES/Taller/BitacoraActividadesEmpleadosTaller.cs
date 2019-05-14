using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using TALLER.BL;
using DevExpress.Xpo;

namespace REPORTES.Taller
{
    public partial class BitacoraActividadesEmpleadosTaller : DevExpress.XtraReports.UI.XtraReport
    {
        public BitacoraActividadesEmpleadosTaller(DateTime De, DateTime Al, int NumEmpledo)
        {
            InitializeComponent();

            this.lblMes.Text = "Del: " + De.ToLongDateString() + " Al: " + Al.ToLongDateString();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Fecha", De.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", Al.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Usuario.NumEmpleado", NumEmpledo));
            XPView Actividades = new XPView(Unidad, typeof(Actividades), "Oid;Fecha;Actividad;HoraInicial;HoraFinal;Usuario.Nombre;Usuario.NumEmpleado;Total", go);
            Actividades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Fecha", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Actividades;
        }

    }
}
