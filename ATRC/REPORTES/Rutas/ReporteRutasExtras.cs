using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Xpo;
using RUTAS.BL;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.Data;
using static ATRCBASE.BL.Enums;

namespace REPORTES.Rutas
{
    public partial class ReporteRutasExtras : DevExpress.XtraReports.UI.XtraReport
    {

        XPView RutasExtras;
        public ReporteRutasExtras()
        {
            InitializeComponent();

             UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //this.FechaInicial = Inicial;
            //this.FechaFinal = Final;

            //lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            //GroupOperator goFiltro = new GroupOperator();
            //goFiltro.Operands.Add(new NotOperator(new NullOperator("Usuario")));
            //goFiltro.Operands.Add(new BinaryOperator("Usuario.Activo", true, BinaryOperatorType.Equal));
            //if (NumEmpleado > 0) goFiltro.Operands.Add(new BinaryOperator("Usuario.NumEmpleado", NumEmpleado));
            //XPCollection Usuarios = new XPCollection(Unidad, typeof(CHECADOR.BL.UsuarioChecador), goFiltro);
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
            this.DataSource = Empresas;

            RutasExtras = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(RutasFijas));
            RutasExtras.AddProperty("Empresa", "Empresa", true);
            RutasExtras.AddProperty("TipoUnidad", "TipoUnidad", true);
            RutasExtras.AddProperty("HoraEntrada", "HoraEntrada", true);
            RutasExtras.AddProperty("HoraSalida", "HoraSalida", true);
            RutasExtras.AddProperty("Total", "Count()", false);
            //RutasExtras.Criteria = new BinaryOperator("FechaRuta", DateTime.Now.Date.AddDays(-1));
            DetailReport.DataSource = RutasExtras;
        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ViewRecord ViewUsuario = (ViewRecord)this.GetCurrentRow();
            RutasExtras.Filter = new BinaryOperator("Empresa", Convert.ToInt32(ViewUsuario["Oid"]));
            //Checadas.GroupCriteria = new 
            //List<ViewRecord> Rutas = new List<ViewRecord>();
            //Rutas.Add(Checadas[0]);

            //DataTable result = new DataTable();
            //result.Columns.Add("Cantidad", typeof(int));
            //result.Columns.Add("Camiones", typeof(string));

            //foreach (ViewRecord viewPadre in Checadas)
            //{
            //    DataRow dtr = result.NewRow();
            //    //dtr["Cantidad"] = 0;
            //    dtr["Camiones"] = viewPadre["TipoUnidad"].ToString() + ' '  + viewPadre["HoraEntrada"].ToString();
            //    int veces = 0;
            //    foreach (ViewRecord viewHijo in Checadas)
            //    {
            //        if ((TipoUnidad)viewPadre["TipoUnidad"] == (TipoUnidad)viewHijo["TipoUnidad"] & (DateTime)viewPadre["HoraEntrada"] == (DateTime)viewHijo["HoraEntrada"] & (DateTime)viewPadre["HoraSalida"] == (DateTime)viewHijo["HoraSalida"])
            //        {
            //            veces++;
            //        }
            //    }
            //    dtr["Cantidad"] = veces;
            //    result.Rows.Add(dtr);
            //}
        }
    }
}
