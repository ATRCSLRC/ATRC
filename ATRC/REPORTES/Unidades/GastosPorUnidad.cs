using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using UNIDADES.BL;
using DevExpress.Data.Filtering;

namespace REPORTES.Unidades
{
    public partial class GastosPorUnidad : DevExpress.XtraReports.UI.XtraReport
    {
        decimal Total = 0;
        public GastosPorUnidad(int ID)
        {
            InitializeComponent();
            XPCollection Unidades = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(Unidad), new BinaryOperator("Oid", ID));
            this.DataSource = Unidades;
            this.drAlmacen.DataSource = ((Unidad)Unidades[0]).GetMemberValue("Salidas");
        }

        private void xrTableCell17_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            if (e.Value != null)
                Total += Convert.ToDecimal(e.Value);
        }

        private void lblTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            lblTotal.Text = Total.ToString("c");
        }
    }
}
