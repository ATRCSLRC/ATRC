using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;

namespace REPORTES.Guardias
{
    public partial class ListadoContratos : DevExpress.XtraReports.UI.XtraReport
    {
        public ListadoContratos(CriteriaOperator filtro)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Contratos = new XPView(Unidad, typeof(GUARDIAS.BL.ContratoRenta), "Oid;NumContrato;Cliente;Cliente.Nombre;Responsable;DiaSalida;HoraSalida;DiaRegreso;HoraRegreso;ADondeSeDirige;Unidad.Nombre", filtro);
            this.DataSource = Contratos;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime TimeSalida = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraSalida")).Ticks);
            DateTime TimeRegreso = new DateTime(((TimeSpan)GetCurrentColumnValue("HoraRegreso")).Ticks);
            lblHoraSalida.Text = TimeSalida.ToShortTimeString();
            lblHoraRegreso.Text = TimeRegreso.ToShortTimeString();
        }
    }
}
