using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;

namespace REPORTES.Combustible
{
    public partial class RecargaDiesel : DevExpress.XtraReports.UI.XtraReport
    {
        public RecargaDiesel(DateTime De, DateTime Al, Type Clase, Enums.Combustible Combustible)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaAlta", De.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaAlta", Al.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Combustible));
            XPView RecargasDiesel = new XPView(Unidad, Clase, "Oid;FechaAlta;Tanque.Descripcion;Cantidad;PrecioLitro;Factura;Proveedor;Lectura", go);
            this.DataSource = RecargasDiesel;
        }

    }
}
