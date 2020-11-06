using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace REPORTES.Rutas
{
    public partial class HistorialRutasGeneradas : DevExpress.XtraReports.UI.XtraReport
    {
        public HistorialRutasGeneradas(DateTime De, DateTime Al)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator();
            goMain.Operands.Add(new BetweenOperator("HorarioModificacion", De.Date, Al.Date));
            XPView Rutas = new XPView(Unidad, typeof(RUTAS.BL.HistorialRutaGenerada), "Oid;EsRutaExtra;FechaRuta;Ruta;Servicio.Descripcion;TipoRuta;Turno.Descripcion;" +
                "HoraEntrada;HoraSalida;RutaCompleta;ChoferEntrada.Nombre;PagarChoferEntrada;ChoferSalida.Nombre;PagarChoferSalida;Comentarios;ComentariosFacturacion;" +
                "RutaGenerada.Empresa.Nombre;UsuarioModificacionClase.Nombre;HorarioModificacion", goMain);
            SortingCollection sc = new SortingCollection();
            sc.Add(new SortProperty("RutaGenerada.Empresa.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending));
            sc.Add(new SortProperty("Ruta", DevExpress.Xpo.DB.SortingDirection.Ascending));
            sc.Add(new SortProperty("HorarioModificacion", DevExpress.Xpo.DB.SortingDirection.Ascending));
            Rutas.Sorting = sc;
            this.DataSource = Rutas;
            lblDetalles.Text = "Del: " + De.ToLongDateString() + " a " + Al.ToLongDateString();
        }

    }
}
