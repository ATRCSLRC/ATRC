using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;

namespace REPORTES.Unidades
{
    public partial class Servicios : DevExpress.XtraReports.UI.XtraReport
    {
        public Servicios(DateTime FechaDel, DateTime FechaAl, Enums.ServiciosUnidad Servicios, bool Todos)
        {
            InitializeComponent();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Fecha", FechaDel.AddDays(-1), BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", FechaAl, BinaryOperatorType.LessOrEqual));
            if(!Todos)
                go.Operands.Add(new BinaryOperator("Servicio", Servicios));

            XPCollection XPServicios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(UNIDADES.BL.Servicios), go);
            this.DataSource = XPServicios;
            lblDetalles.Text = "Del: " + FechaDel.ToShortDateString() + " Al: " + FechaAl.ToShortDateString();
        }

    }
}
