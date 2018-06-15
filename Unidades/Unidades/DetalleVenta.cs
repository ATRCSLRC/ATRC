using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using Unidad.BL;

namespace Unidades
{
    public partial class DetalleVenta : DevExpress.XtraReports.UI.XtraReport
    {
        public DetalleVenta(int ID)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Unidad.BL.Unidad> UnidadesCamion = new XPCollection<Unidad.BL.Unidad>(Unidad, new BinaryOperator("Oid", ID));
            this.DataSource = UnidadesCamion;

            if (UnidadesCamion[0].DetalleVenta != null)
            {
                if (UnidadesCamion[0].DetalleVenta.EsCredito)
                {
                    if (UnidadesCamion[0].DetalleVenta.TipoMoneda == Enums.TipoMoneda.Dolares)
                    {
                        if (UnidadesCamion[0].DetalleVenta.PrecioUnidad <= UnidadesCamion[0].TotalDolar)
                        {
                            this.Watermark.Image = Unidades.Properties.Resources.Vendido;
                            this.Watermark.ImageTransparency = 200;
                            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom;
                        }
                    }
                    else
                    {
                        if (UnidadesCamion[0].DetalleVenta.PrecioUnidad <= UnidadesCamion[0].TotalPesos)
                        {
                            this.Watermark.Image = Unidades.Properties.Resources.Vendido;
                            this.Watermark.ImageTransparency = 200;
                            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom;
                        }
                    }
                }else

                {
                    this.Watermark.Image = Unidades.Properties.Resources.Vendido;
                    this.Watermark.ImageTransparency = 200;
                    this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom;
                }
            }
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Unidad.BL.Unidad Unidad = (Unidad.BL.Unidad)this.GetCurrentRow();
            if (Unidad != null)
            {
                Unidad.Gastos.Criteria = new BinaryOperator("TipoTransaccion", Enums.TipoTransaccion.Pago);
                if (Unidad.Gastos.Count <= 0)
                {
                    DetailReportGastos.Visible = false;
                    Detail1.Visible = false;
                    GroupFooter1.Visible = false;
                }
            }
        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
