using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unidades
{
    public partial class xfrmTotales : RibbonForm
    {
        public xfrmTotales()
        {
            InitializeComponent();
        }

        public Unidad.BL.Unidad Unidad;
        private void xfrmTotales_Load(object sender, EventArgs e)
        {
            GraficaDolar.Series[0].Points.RemoveRange(0, GraficaDolar.Series[0].Points.Count);
            GraficaPesos.Series[0].Points.RemoveRange(0, GraficaPesos.Series[0].Points.Count);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            GraficaDolar.Series[0].Points.RemoveRange(0, GraficaDolar.Series[0].Points.Count);
            GraficaDolar.Series[0].Points.Add(new SeriesPoint("Pesos convertidos", (Unidad.TotalPesos)));
            GraficaDolar.Series[0].Points.Add(new SeriesPoint("Dolares", Unidad.TotalDolar));

            GraficaPesos.Series[0].Points.RemoveRange(0, GraficaPesos.Series[0].Points.Count);
            GraficaPesos.Series[0].Points.Add(new SeriesPoint("Dolares convertidos", (Unidad.TotalDolar)));
            GraficaPesos.Series[0].Points.Add(new SeriesPoint("Pesos", Unidad.TotalPesos));
        }
    }

}
