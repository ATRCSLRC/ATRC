using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Unidad.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace Unidades
{
    public partial class DetallesUnidad : DevExpress.XtraReports.UI.XtraReport
    {
        public DetallesUnidad(int ID)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Unidad.BL.Unidad> Unidades = new XPCollection<Unidad.BL.Unidad>(Unidad, new BinaryOperator("Oid", ID));
            this.DataSource = Unidades;
        }

        private void DetallesUnidad_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
