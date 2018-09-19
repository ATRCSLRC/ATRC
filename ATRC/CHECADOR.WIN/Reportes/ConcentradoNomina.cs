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
            go.Operands.Add(new BinaryOperator("FechaChecada", Inicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", Final.Date, BinaryOperatorType.LessOrEqual));

            GroupOperator goUsuario = new GroupOperator(GroupOperatorType.And);
            goUsuario.Operands.Add(new NotOperator(new NullOperator("Usuario")));
            goUsuario.Operands.Add(new BinaryOperator("Usuario.Activo", true, BinaryOperatorType.Equal));
            XPView Usuarios = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.UsuarioChecador), "Oid;Usuario.Nombre;Usuario.NumEmpleado", goUsuario);
            //XPCollection Usuarios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.UsuarioChecador));
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            if (Usuarios.Count > 0)
                this.DataSource = Usuarios;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ViewRecord viewUsuario = (ViewRecord)this.GetCurrentRow();
            decimal TotalLunes = 0, TotalMartes = 0, TotalMiercoles = 0, TotalJueves = 0, TotalViernes = 0, TotalSabado = 0, TotalDomingo = 0;
            if (viewUsuario != null)
            {
                XPView Checadas = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.HistoricoChecadas), "Oid;FechaChecada;Usuario.Oid;HoraChecadaSalida;HoraChecadaEntrada", go);
                Checadas.Filter = new BinaryOperator("Usuario.Oid", Convert.ToInt32(viewUsuario["Oid"]));
                foreach (ViewRecord Historico in Checadas)
                {
                    switch (Convert.ToDateTime(Historico["FechaChecada"]).DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            if(Historico["HoraChecadaSalida"] != null)
                                TotalLunes += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Tuesday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalMartes += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Wednesday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalMiercoles += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Thursday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalJueves += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Friday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalViernes += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Saturday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalSabado += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
                            break;
                        case DayOfWeek.Sunday:
                            if (Historico["HoraChecadaSalida"] != null)
                                TotalDomingo += TotalHoras((TimeSpan)Historico["HoraChecadaEntrada"], (TimeSpan)Historico["HoraChecadaSalida"]);
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

        private decimal TotalHoras(TimeSpan Entrada, TimeSpan Salida)
        {
            decimal EntradaHora = CHECADOR.BL.Utilerias.CalcularHora(Entrada);
            decimal SalidaHora = CHECADOR.BL.Utilerias.CalcularHora(Salida);
            return SalidaHora < EntradaHora ? (SalidaHora - EntradaHora) + 24 : (SalidaHora - EntradaHora);
        }
        private void objectDataSource1_BeforeFill(object sender, DevExpress.DataAccess.ObjectBinding.BeforeFillEventArgs args)
        {

        }
    }
}
