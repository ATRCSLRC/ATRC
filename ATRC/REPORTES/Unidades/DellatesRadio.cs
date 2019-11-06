using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace REPORTES.Unidades
{
    public partial class DellatesRadio : DevExpress.XtraReports.UI.XtraReport
    {
        public DellatesRadio(UNIDADES.BL.Radios Radio)
        {
            InitializeComponent();
            lblNo.Text = "No. " + Radio.Radio;
            string x = Radio.Unidad == null ? Radio.Usuario.Nombre : "Unidad: " + Radio.Unidad.Nombre;
            BarCode.Text = Environment.NewLine + "Radio " + Radio.Radio + Environment.NewLine + x + Environment.NewLine + "Modelo: " + Radio.Modelo + Environment.NewLine + "Serie: " + Radio.Serie + Environment.NewLine + "Marca: " + Radio.Marca;
        }

    }
}
