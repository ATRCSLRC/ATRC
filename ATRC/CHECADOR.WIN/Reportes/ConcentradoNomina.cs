using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using CHECADOR.BL;
using DevExpress.Xpo;

namespace CHECADOR.WIN.Reportes
{
    public partial class ConcentradoNomina : DevExpress.XtraReports.UI.XtraReport
    {
        GroupOperator go;
        public ConcentradoNomina(DateTime Inicial, DateTime Final)
        {
            InitializeComponent();
            
            lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", Inicial, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", Final, BinaryOperatorType.LessOrEqual));
            XPCollection Usuarios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.UsuarioChecador));
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            if (Usuarios.Count > 0)
                this.DataSource = Usuarios;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            UsuarioChecador Usuario = (UsuarioChecador)this.GetCurrentRow();
            decimal TotalLunes = 0, TotalMartes = 0, TotalMiercoles = 0, TotalJueves = 0, TotalViernes = 0, TotalSabado = 0, TotalDomingo = 0;
            if (Usuario != null)
            {
                Usuario.HistoricoChecadas.Filter = go;
                foreach (HistoricoChecadas Historico in Usuario.HistoricoChecadas)
                {
                    switch (Historico.FechaChecada.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            TotalLunes += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Tuesday:
                            TotalMartes += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Wednesday:
                            TotalMiercoles += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Thursday:
                            TotalJueves += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Friday:
                            TotalViernes += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Saturday:
                            TotalSabado += Historico.TotalHoras;
                            break;
                        case DayOfWeek.Sunday:
                            TotalDomingo += Historico.TotalHoras;
                            break;
                    }
                }
            }
            cellLunes.Text = TotalLunes.ToString();
            cellMartes.Text = TotalMartes.ToString();
            cellMiercoles.Text = TotalMiercoles.ToString();
            cellJueves.Text = TotalJueves.ToString();
            cellViernes.Text = TotalViernes.ToString();
            cellSabado.Text = TotalSabado.ToString();
            cellDomingo.Text = TotalDomingo.ToString();
            cellTotal.Text = (TotalLunes + TotalMartes + TotalMiercoles + TotalJueves + TotalViernes + TotalSabado + TotalDomingo).ToString();

        }

        private void objectDataSource1_BeforeFill(object sender, DevExpress.DataAccess.ObjectBinding.BeforeFillEventArgs args)
        {

        }
    }
}
