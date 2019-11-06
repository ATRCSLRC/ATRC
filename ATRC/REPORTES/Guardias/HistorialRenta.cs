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
        public HistorialRenta(DateTime FechaDel, DateTime FechaAl, string Representante)
        {
            InitializeComponent();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("DiaSalidaOriginal", FechaDel.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("DiaSalidaOriginal", FechaAl.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Unidad.Dueño", Representante));
            //GroupOperator goEstados = new GroupOperator(GroupOperatorType.Or);
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Terminado));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Apartado));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnViaje));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.can));
            XPView Rentas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(GUARDIAS.BL.ContratoRenta), "Oid;NumContrato;Unidad.Nombre;ADondeSeDirige;DiaSalidaOriginal;DiaRegresoOriginal;Recargos;Total;Iva;Costo;DiasRenta;Comentarios;HoraSalidaOriginal;HoraRegresoOriginal;EstadoContrato;Unidad.Dueño", go);
            Rentas.Sorting.Add(new SortingCollection(new SortProperty("NumContrato", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Rentas;
            lblDetalles.Text = "Del: " + FechaDel.ToLongDateString() + " Al: " + FechaAl.ToLongDateString();
            lblRepresentante.Text = Representante;
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime TimeSalida = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraSalidaOriginal")).Ticks);
            DateTime TimeRegreso = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraRegresoOriginal")).Ticks);
            Enums.EstadoContrato Estado = ((Enums.EstadoContrato)GetCurrentColumnValue("EstadoContrato"));
            lblComentarios.Text = GetCurrentColumnValue("Comentarios") + " Hora de salida: " + TimeSalida.ToShortTimeString() + (Estado == Enums.EstadoContrato.Terminado ? " hora de regreso: " + TimeRegreso.ToShortTimeString() :"");
            
        }
    }
}
