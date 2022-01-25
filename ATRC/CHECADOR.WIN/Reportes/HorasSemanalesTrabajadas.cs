using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;
using System.Collections.Generic;
using CHECADOR.BL;
using DevExpress.Utils.Filtering.Internal;
using System.Data;

namespace CHECADOR.WIN.Reportes
{
    public partial class HorasSemanalesTrabajadas : DevExpress.XtraReports.UI.XtraReport
    {
        //GroupOperator go;
        DateTime FechaInicial;
        DateTime FechaFinal;
        UnidadDeTrabajo Unidad;
        DataTable TablaChecadas;
        DataTable Tabla;
        public HorasSemanalesTrabajadas(int NumEmpleado, DateTime Inicial, DateTime Final)
        {
            InitializeComponent();

            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            this.FechaInicial = Inicial;
            this.FechaFinal = Final;
            
            lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            GroupOperator goFiltro = new GroupOperator();
            goFiltro.Operands.Add(new NotOperator(new NullOperator("Usuario")));
            goFiltro.Operands.Add(new BinaryOperator("Usuario.Activo", true, BinaryOperatorType.Equal));
            if (NumEmpleado > 0) goFiltro.Operands.Add(new BinaryOperator("Usuario.NumEmpleado", NumEmpleado));
            //XPCollection Usuarios = new XPCollection(Unidad, typeof(CHECADOR.BL.UsuarioChecador), goFiltro);
            XPView Usuarios = new XPView(Unidad, typeof(CHECADOR.BL.UsuarioChecador), "Oid;Usuario.Nombre;Usuario.Patron;Usuario.NumEmpleado", goFiltro);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Usuarios;

            #region Semana
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            //go.Operands.Add(new BetweenOperator("FechaChecada", FechaInicial.Date, FechaFinal.Date));
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaFinal.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(CriteriaOperator.Parse("GetDayOfWeek([FechaChecada]) != 0"));
            XPView Checadas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.HistoricoChecadas), "Oid;FechaChecada;Usuario;HoraChecadaSalida;HoraChecadaEntrada", go);
            Checadas.Sorting.Add(new SortingCollection(new SortProperty("HoraChecadaEntrada", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            TablaChecadas = CreateDataTableFromXPView(Checadas);
            
            #endregion

            #region Fin de Semana
            GroupOperator goFin = new GroupOperator(GroupOperatorType.And);
            //go.Operands.Add(new BetweenOperator("FechaChecada", FechaInicial.Date, FechaFinal.Date));
            goFin.Operands.Add(new BinaryOperator("FechaChecada", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            goFin.Operands.Add(new BinaryOperator("FechaChecada", FechaFinal.Date, BinaryOperatorType.LessOrEqual));
            goFin.Operands.Add(CriteriaOperator.Parse("GetDayOfWeek([FechaChecada]) == 0"));
            XPView FinChecadas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.HistoricoChecadas), "Oid;FechaChecada;Usuario;HoraChecadaSalida;HoraChecadaEntrada", goFin);
            FinChecadas.Sorting.Add(new SortingCollection(new SortProperty("HoraChecadaEntrada", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Tabla = CreateDataTableFromXPView(FinChecadas);

            #endregion
            DetailReport.DataSource = TablaChecadas;
            DetailReport1.DataSource = Tabla;
        }

        private DataTable CreateDataTableFromXPView(XPView view)
        {
            DataTable result = new DataTable();
            result.Columns.Add("Oid", typeof(int));
            result.Columns.Add("FechaChecada", typeof(DateTime));
            result.Columns.Add("Usuario", typeof(int));
            result.Columns.Add("HoraChecadaSalida", typeof(TimeSpan));
            result.Columns.Add("HoraChecadaEntrada", typeof(TimeSpan));
            result.Columns.Add("TotalHoras", typeof(decimal));

            //foreach (property in view.Properties)
            //    result.Columns.Add(property.Name, view.ObjectClassInfo.GetMember(property.Name).MemberType);
            foreach (ViewRecord record in view)
                result.Rows.Add(GetRecordValues(record));
            return result;
        }

        private object[] GetRecordValues(ViewRecord record)
        {
            ArrayList result = new ArrayList();
            foreach (ViewProperty property in record.View.Properties)
                result.Add(record[property.Property]);
            result.Add(result[3] == null ? 0: TotalHoras((TimeSpan)result[4], (TimeSpan)result[3]));
            return result.ToArray();
        }

        private decimal TotalHoras(TimeSpan Entrada, TimeSpan Salida)
        {
            decimal EntradaHora = CHECADOR.BL.Utilerias.CalcularHora(Entrada);
            decimal SalidaHora = CHECADOR.BL.Utilerias.CalcularHora(Salida);
            return SalidaHora < EntradaHora ? (SalidaHora - EntradaHora) + 24 : (SalidaHora - EntradaHora);
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            DateTime mFechaInicial = FechaInicial;
            DateTime mFechaFinal = FechaFinal;
            TablaChecadas.DefaultView.Sort = "FechaChecada asc";
            ViewRecord ViewUsuario = (ViewRecord)this.GetCurrentRow();
            while (mFechaFinal >= mFechaInicial)
            {
                if (mFechaInicial.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    mFechaInicial = mFechaInicial.AddDays(1);
                    continue;
                }
                else
                {
                    TablaChecadas.DefaultView.RowFilter = "Usuario = " + Convert.ToInt32(ViewUsuario["Oid"]) + " AND " + String.Format(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat,
                         "FechaChecada = #{0}#", mFechaInicial.Date); //new DateTime(mFechaInicial.Date.Year, mFechaInicial.Date.Month, mFechaInicial.Date.Day, 0, 0, 0));
                    if (TablaChecadas.DefaultView.Count <= 0)
                    {
                        DataRow data = TablaChecadas.NewRow();
                        data[1] = mFechaInicial.Date;
                        data[2] = Convert.ToInt32(ViewUsuario["Oid"]);
                        data[3] = new TimeSpan(0, 0, 0);
                        data[4] = new TimeSpan(0, 0, 0);
                        data[5] = 0;
                        TablaChecadas.Rows.Add(data);
                    }
                }


                mFechaInicial = mFechaInicial.AddDays(1);
            }

            TablaChecadas.DefaultView.RowFilter = "Usuario = " + Convert.ToInt32(ViewUsuario["Oid"]) + "";
        }

        private void DetailReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime mFechaInicial = FechaInicial;
            DateTime mFechaFinal = FechaFinal;
            Tabla.DefaultView.Sort = "FechaChecada asc";
            ViewRecord ViewUsuario = (ViewRecord)this.GetCurrentRow();
            while (mFechaFinal >= mFechaInicial)
            {
                if (mFechaInicial.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Tabla.DefaultView.RowFilter = "Usuario = " + Convert.ToInt32(ViewUsuario["Oid"]) + " AND " + String.Format(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat,
                         "FechaChecada = #{0}#", mFechaInicial.Date); //new DateTime(mFechaInicial.Date.Year, mFechaInicial.Date.Month, mFechaInicial.Date.Day, 0, 0, 0));
                    if (Tabla.DefaultView.Count <= 0)
                    {
                        DataRow data = Tabla.NewRow();
                        data[1] = mFechaInicial.Date;
                        data[2] = Convert.ToInt32(ViewUsuario["Oid"]);
                        data[3] = new TimeSpan(0, 0, 0);
                        data[4] = new TimeSpan(0, 0, 0);
                        data[5] = 0;
                        Tabla.Rows.Add(data);
                    }
                }


                mFechaInicial = mFechaInicial.AddDays(1);
            }

            Tabla.DefaultView.RowFilter = "Usuario = " + Convert.ToInt32(ViewUsuario["Oid"]) + "";
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           // xrTableCell22.Text = (Convert.ToDouble(lblSubtotalSemana.Summary.GetResult()) + Convert.ToDouble(lblSubtotalSemana.Summary.GetResult())).ToString();
            //if (!string.IsNullOrEmpty(lblSubtotalDomingo.Text) & !string.IsNullOrEmpty(lblSubtotalSemana.Text))
            //    xrTableCell22.Text = (Convert.ToDouble(lblSubtotalDomingo.Text) + Convert.ToDouble(lblSubtotalSemana.Text)).ToString();
        }

        private void xrTableCell22_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //xrTableCell22.Text = (Convert.ToDouble(lblSubtotalSemana.Summary.GetResult()) + Convert.ToDouble(lblSubtotalSemana.Summary.GetResult())).ToString();
        }

        private void lblSubtotalSemana_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell22.Text = lblSubtotalSemana.Summary.GetResult().ToString();
        }

        private void lblSubtotalDomingo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell22.Text))
                if(xrTableCell22.Text != "0")
                    xrTableCell22.Text = (Convert.ToDouble(xrTableCell22.Text) +  Convert.ToDouble(lblSubtotalDomingo.Summary.GetResult() == null ? "0" : lblSubtotalDomingo.Summary.GetResult().ToString())).ToString();
        }
    }
}
