using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;

namespace REPORTES.Guardias
{
    public partial class HistorialRenta : DevExpress.XtraReports.UI.XtraReport
    {
        public HistorialRenta(DateTime FechaDel, DateTime FechaAl)
        {
            InitializeComponent();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("DiaSalidaOriginal", FechaDel.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("DiaSalidaOriginal", FechaAl.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Terminado));
            XPView Rentas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(GUARDIAS.BL.ContratoRenta), "Oid;NumContrato;Unidad.Nombre;ADondeSeDirige;DiaSalidaOriginal;DiaRegresoOriginal;Recargos;Total;Iva;Costo;DiasRenta;Comentarios", go);
            Rentas.Sorting.Add(new SortingCollection(new SortProperty("NumContrato", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Rentas;
            lblDetalles.Text = "Del: " + FechaDel.ToLongDateString() + " Al: " + FechaAl.ToLongDateString();
        }

    }
}
