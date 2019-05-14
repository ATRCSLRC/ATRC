using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using TALLER.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace REPORTES.Taller
{
    public partial class BitacoraActividadesTallerDiario : DevExpress.XtraReports.UI.XtraReport
    {
        public BitacoraActividadesTallerDiario(DateTime Dia)
        {
            InitializeComponent();

            this.lblMes.Text = "Día: " + Dia.ToLongDateString();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            SortingCollection sc = new SortingCollection();
            sc.Add(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending));
            sc.Add(new SortProperty("HoraInicial", DevExpress.Xpo.DB.SortingDirection.Ascending));
            XPView Actividades = new XPView(Unidad, typeof(Actividades), "Oid;Fecha;Actividad;HoraInicial;HoraFinal;Usuario.Nombre;Usuario.NumEmpleado", new BinaryOperator("Fecha", Dia));
            Actividades.Sorting = sc;
            this.DataSource = Actividades;
        }

    }
}
