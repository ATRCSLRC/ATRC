using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using RUTAS.BL;
using System;

namespace REPORTES.Rutas
{
    public partial class ReporteRutasPublicar : DevExpress.XtraReports.UI.XtraReport
    {

        public ReporteRutasPublicar(DateTime Fecha, bool EsExtra)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("FechaRuta", Fecha));
            go.Operands.Add(new BinaryOperator("EsRutaExtra", EsExtra));
            if (EsExtra)
                lblEmpleado.Text = "Listado de rutas extras";

            XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;Empresa.Nombre;OrdenRutas;Empresa.Oid;Ruta;TipoRuta;Servicio.TipoUnidad;ChoferEntrada.Nombre;ChoferSalida.Nombre;HoraEntrada;HoraSalida;Turno.Oid;Turno.Descripcion;Comentarios", go);
            if (Fecha >= new DateTime(2020, 07, 16))
                Rutas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
            this.DataSource = Rutas;
            lblDetalles.Text = Fecha.ToLongDateString();
        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
