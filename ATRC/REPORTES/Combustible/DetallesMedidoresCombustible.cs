using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using COMBUSTIBLE.BL;

namespace REPORTES.Combustible
{
    public partial class DetallesMedidoresCombustible : DevExpress.XtraReports.UI.XtraReport
    {
        public DetallesMedidoresCombustible(DateTime De, DateTime Al, Enums.Combustible Combustible)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaAlta", De.Date.AddDays(-1), BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaAlta", Al.Date.AddDays(1), BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Combustible));
            XPView RecargasDiesel = new XPView(Unidad, typeof(MedidorDiesel), "Oid;FechaAlta;Tanque.Descripcion;Tanque.TipoCombustible;LitrosCapturados;LitrosEnTanque", go);
            this.DataSource = RecargasDiesel;
        }

    }
}
