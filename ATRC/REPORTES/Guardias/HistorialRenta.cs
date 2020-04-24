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
            go.Operands.Add(new BinaryOperator("DiaSalida", FechaDel.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("DiaSalida", FechaAl.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Unidad.Dueño", Representante));
            //GroupOperator goEstados = new GroupOperator(GroupOperatorType.Or);
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Terminado));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Apartado));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnViaje));
            //goEstados.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.can));
            XPView Rentas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(GUARDIAS.BL.ContratoRenta));
            Rentas.Properties.AddRange(new ViewProperty[] {
                        new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                        new ViewProperty("NumContrato", SortDirection.None, "[NumContrato]", false, true),
                        new ViewProperty("Unidad.Nombre", SortDirection.None, "[Unidad.Nombre]", false, true),
                        new ViewProperty("ADondeSeDirige", SortDirection.None, "[ADondeSeDirige]", false, true),
                        new ViewProperty("DiaSalida", SortDirection.None, "[DiaSalida]", false, true),
                        new ViewProperty("DiaSalidaOriginal", SortDirection.None, "[DiaSalidaOriginal]", false, true),
                        new ViewProperty("DiaRegreso", SortDirection.None, "[DiaRegreso]", false, true),
                        new ViewProperty("DiaRegresoOriginal", SortDirection.None, "[DiaRegresoOriginal]", false, true),
                        new ViewProperty("Recargos", SortDirection.None, "[Recargos]", false, true),
                        new ViewProperty("Total", SortDirection.None, "iif([EstadoContrato] == 4, ([Anticipo] + [Abono]) - [CantidadDevuelta] ,[Total])", false, true),
                        new ViewProperty("Iva", SortDirection.None, "[Iva]", false, true),
                        new ViewProperty("Costo", SortDirection.None, "[Costo]", false, true),
                        new ViewProperty("DiasRenta", SortDirection.None, "[DiasRenta]", false, true),
                        new ViewProperty("Comentarios", SortDirection.None, "[Comentarios]", false, true),
                        new ViewProperty("HoraSalidaOriginal", SortDirection.None, "[HoraSalidaOriginal]", false, true),
                        new ViewProperty("HoraRegresoOriginal", SortDirection.None, "[HoraRegresoOriginal]", false, true),
                        new ViewProperty("EstadoContrato", SortDirection.None, "[EstadoContrato]", false, true),
                        new ViewProperty("Unidad.Dueño", SortDirection.None, "[Unidad.Dueño]", false, true),
                        });
            Rentas.Criteria = go;
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
           if(GetCurrentColumnValue("HoraSalidaOriginal") != null)
            {
                DateTime TimeSalida = DateTime.Now;
                DateTime TimeRegreso = DateTime.Now;
                if (GetCurrentColumnValue("HoraSalidaOriginal") != null)
                    TimeSalida = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraSalidaOriginal")).Ticks);
                if (GetCurrentColumnValue("HoraRegresoOriginal") != null)
                    TimeRegreso = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraRegresoOriginal")).Ticks);
                Enums.EstadoContrato Estado = ((Enums.EstadoContrato)GetCurrentColumnValue("EstadoContrato"));
                lblComentarios.Text = Estado == Enums.EstadoContrato.Creado ? "Aun no se ha ido en renta." : GetCurrentColumnValue("Comentarios") + (Estado == Enums.EstadoContrato.Cancelado ? "" : " Hora de salida: " + TimeSalida.ToShortTimeString()) + (Estado == Enums.EstadoContrato.Terminado ? " hora de regreso: " + TimeRegreso.ToShortTimeString() : "");
            }
        }
    }
}
