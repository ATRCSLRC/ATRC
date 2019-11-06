using ATRCBASE.WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using ATRCBASE.BL;
using DevExpress.Xpo;
using GUARDIAS.BL;
using DevExpress.Data.Filtering;

namespace GUARDIAS.WIN.Renta
{
    public partial class xfrmCalendarioREnta : xfrmBase
    {
        public xfrmCalendarioREnta()
        {
            InitializeComponent();
        }

        private void xfrmCalendarioREnta_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            goMain.Operands.Add(new BinaryOperator("Cancelado", false));
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Creado));
            go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnViaje));
            go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Apartado));
            goMain.Operands.Add(go);

            XPView Contratos = new XPView(Unidad, typeof(ContratoRenta), "Oid;ADondeSeDirige;HoraSalida;DiaSalida;HoraRegreso;DiaRegreso;Unidad.Nombre;EstadoContrato", goMain);

            foreach(ViewRecord view in Contratos)
            {
                DateTime DiaSalida = Convert.ToDateTime(view["DiaSalida"]);
                DateTime DiaRegreso = Convert.ToDateTime(view["DiaRegreso"]);
                TimeSpan HoraSalida = ((TimeSpan)view["HoraSalida"]);
                TimeSpan HoraRegreso = ((TimeSpan)view["HoraRegreso"]);
                Appointment apt = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);
                apt.Start = DiaSalida.Add(HoraSalida);
                apt.End = DiaRegreso.Add(HoraRegreso);
                //apt.Type = AppointmentType.Pattern;
                apt.LabelKey =  (Enums.EstadoContrato)view["EstadoContrato"] == Enums.EstadoContrato.Apartado ? 2 : 3;
                //apt.Duration = TimeSpan.FromHours(1);
                apt.Subject = "Unidad " + view["Unidad.Nombre"];
                apt.Description = view["Unidad.Nombre"].ToString();
                schedulerControl1.Storage.Appointments.Add(apt);

            }
            schedulerControl1.Start = DateTime.Now;

            //Appointment apt2 = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);
            //apt2.Start = DateTime.Today.AddHours(8);
            //apt2.End = DateTime.Today.AddDays(3);
            ////apt.Duration = TimeSpan.FromHours(1);
            //apt2.Subject = "Unidad M-25";
            //apt2.Description = "Description";
            //schedulerControl1.Storage.Appointments.Add(apt2);
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            //if (schedulerControl1.SelectedAppointments.Count == 0)
                e.Handled = true;
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            schedulerControl1.ActiveViewType = SchedulerViewType.Week;
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            schedulerControl1.ActiveViewType = SchedulerViewType.Month;
        }
    }
}
