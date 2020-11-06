using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using RUTAS.BL;

namespace REPORTES.Rutas
{
    public partial class RutasPorUsuario : DevExpress.XtraReports.UI.XtraReport
    {
        public RutasPorUsuario(DateTime De, DateTime Al, Int32 NumEmpleado)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator();
            goMain.Operands.Add(new BetweenOperator("FechaRuta", De.Date, Al.Date));
            GroupOperator goChofer = new GroupOperator(GroupOperatorType.Or);
            goChofer.Operands.Add(new BinaryOperator("ChoferEntrada.NumEmpleado", NumEmpleado));
            goChofer.Operands.Add(new BinaryOperator("ChoferSalida.NumEmpleado", NumEmpleado));
            goMain.Operands.Add(goChofer);
            XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;FechaRuta;Empresa.Nombre;Empresa.Oid;Ruta;TipoRuta;Servicio.TipoUnidad;ChoferEntrada.Nombre;ChoferSalida.Nombre;HoraEntrada;HoraSalida;Turno.Oid;Turno.Descripcion;Comentarios", goMain);
            
            this.DataSource = Rutas;
            Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", NumEmpleado));

            lblNombreReporte.Text = "Rutas del empleado: " + Usuario.NumEmpleado + " - " + Usuario.Nombre;
            lblFecha.Text = "Del: " + De.ToLongDateString() + " a " + Al.ToLongDateString();
        }

    }
}
