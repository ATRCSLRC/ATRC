using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;
using REPORTES.Combustible;
using DevExpress.Xpo.DB;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmFiltrosCombustible : xfrmBase
    {
        public xfrmFiltrosCombustible()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadControles;
        public ReporteCombustible ReporteCombustible;

        private void xfrmFiltrosCombustible_Load(object sender, EventArgs e)
        {
            dteDe.EditValue = dteA.EditValue = DateTime.Now;
            UnidadControles = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BinaryOperator bo = new BinaryOperator("Combustible", Combustible.Diesel);
           

            switch (ReporteCombustible)
            {
                case ReporteCombustible.Consumo:
                    XPView Unidades = new XPView(UnidadControles, typeof(Unidad));
                    Unidades.Properties.AddRange(new ViewProperty[] {
                      new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                      new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                     });
                    Unidades.Sorting.Add(new SortProperty("Nombre", SortingDirection.Ascending));
                    Unidades.Criteria = bo;
                    lueUnidad.Properties.DataSource = Unidades;
                    this.Text = "Consumo de unidad";
                    break;
                case ReporteCombustible.PedidoDiesel:
                    lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    this.Text = "Recargas de diesel";
                    break;
                case ReporteCombustible.UnidadDiesel:
                    lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    this.Text = "Unidades con diesel";
                    break;
            }
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (ReporteCombustible)
            {
                case ReporteCombustible.Consumo:
                    ReportPrintTool repConsumo = new ReportPrintTool(new ConsumoDieselUnidad(dteDe.DateTime, dteA.DateTime, Convert.ToInt32(lueUnidad.EditValue)));
                    repConsumo.ShowPreview();
                    break;
                case ReporteCombustible.PedidoDiesel:
                    ReportPrintTool repPedidoDiesel = new ReportPrintTool(new RecargaDiesel(dteDe.DateTime, dteA.DateTime));
                    repPedidoDiesel.ShowPreview();
                    break;
                case ReporteCombustible.UnidadDiesel:
                    ReportPrintTool repUnidadDiesel = new ReportPrintTool(new UnidadesConDiesel(dteDe.DateTime, dteA.DateTime));
                    repUnidadDiesel.ShowPreview();
                    break;
            }


        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
