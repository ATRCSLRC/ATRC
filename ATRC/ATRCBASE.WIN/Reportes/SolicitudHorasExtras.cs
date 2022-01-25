using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using GUARDIAS.BL;
using System.Collections.Generic;

namespace REPORTES
{
    public partial class SolicitudHorasExtras : DevExpress.XtraReports.UI.XtraReport
    {
        public SolicitudHorasExtras(GroupOperator Go)
        {
            InitializeComponent();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Servicios = new XPView(Unidad, typeof(SolicitudHorasExtra));
            Servicios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[FechaSolicitud]", false, true),
                  new ViewProperty("Motivo", SortDirection.None, "[MotivoHorasExtra]", false, true),
                  new ViewProperty("Otro", SortDirection.None, "[Otro]", false, true),
                  new ViewProperty("De", SortDirection.None, "[NominaDe]", false, true),
                  new ViewProperty("A", SortDirection.None, "[NominaA]", false, true),
                  new ViewProperty("Dias", SortDirection.None, "[Dias]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[Empleado.NumEmpleado]", false, true),
                  new ViewProperty("Empleado", SortDirection.None, "[Empleado.Nombre]", false, true)
                 });
            Servicios.Criteria = Go;
            this.DataSource = Servicios;
            
            //UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //SolicitudHorasExtra Solicitud = Unidad.GetObjectByKey<SolicitudHorasExtra>(ID);

            //lblFecha.Text = Solicitud.FechaSolicitud.ToString("d'.'MMMyyy ");
            //lblNumTrabajador.Text = Solicitud.Empleado.NumEmpleado.ToString();
            //lblNomina.Text = Solicitud.NominaDe.ToString("d 'de' MMM") + " al " + Solicitud.NominaA.ToString("d 'de' MMM yyy");
            //lblTrabajador.Text = Solicitud.Empleado.Nombre;
            //lblDias.Text = Solicitud.Dias;
            //string[] Motivos = Solicitud.MotivoHorasExtra.Split(',');
            //foreach(string Motivo in Motivos)
            //{
            //    switch(Motivo)
            //    {
            //        case "Ruta especial":
            //            lblRutaEspecial.Text = "X";
            //            break;
            //        case "Maquiladora solicita tiempo extra":
            //            lblTiempoExtra.Text = "X";
            //            break;
            //        case "Maquiladora trabaja 6 días a la semana":
            //            lblSeisDias.Text = "X";
            //            break;
            //        case "Maquiladora trabaja 7 días a la semana":
            //            lblSieteDias.Text = "X";
            //            break;
            //        case "Cambio de horario de maquiladora":
            //            lblHorario.Text = "X";
            //            break;
            //        case "Cubrir falta de chofer":
            //            lblFalta.Text = "X";
            //            break;
            //        case "Termino de jornada":
            //            lblJornada.Text = "X";
            //            break;
            //        case "Ruta extra":
            //            lblRutaExtra.Text = "X";
            //            break;
            //        case "Otro":
            //            lblOtro.Text = Solicitud.Otro;
            //            break;
            //    }
            //}

            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ViewRecord viewSolicitud = (ViewRecord)this.GetCurrentRow();
            lblFecha.Text = Convert.ToDateTime(viewSolicitud["Fecha"]).ToString("d'.'MMMyyy ");
            lblNumTrabajador.Text = viewSolicitud["NumEmpleado"].ToString();
            lblNomina.Text = Convert.ToDateTime(viewSolicitud["De"]).ToString("d 'de' MMM") + " al " + Convert.ToDateTime(viewSolicitud["A"]).ToString("d 'de' MMM yyy");
            lblTrabajador.Text = viewSolicitud["Empleado"].ToString();
            lblDias.Text = viewSolicitud["Dias"].ToString();
            string[] Motivos = viewSolicitud["Motivo"].ToString().Split(',');
            lblRutaEspecial.Text = string.Empty;
            lblTiempoExtra.Text = string.Empty;
            lblSeisDias.Text = string.Empty;
            lblSieteDias.Text = string.Empty;
            lblHorario.Text = string.Empty;
            lblFalta.Text = string.Empty;
            lblJornada.Text = string.Empty;
            lblRutaExtra.Text = string.Empty;
            lblOtro.Text = string.Empty;
            foreach (string Motivo in Motivos)
            {
                switch (Motivo)
                {
                    case "Ruta especial":
                        lblRutaEspecial.Text = "X";
                        break;
                    case "Maquiladora solicita tiempo extra":
                        lblTiempoExtra.Text = "X";
                        break;
                    case "Maquiladora trabaja 6 días a la semana":
                        lblSeisDias.Text = "X";
                        break;
                    case "Maquiladora trabaja 7 días a la semana":
                        lblSieteDias.Text = "X";
                        break;
                    case "Cambio de horario de maquiladora":
                        lblHorario.Text = "X";
                        break;
                    case "Cubrir falta de chofer":
                        lblFalta.Text = "X";
                        break;
                    case "Termino de jornada":
                        lblJornada.Text = "X";
                        break;
                    case "Ruta extra":
                        lblRutaExtra.Text = "X";
                        break;
                    case "Otro":
                        lblOtro.Text = viewSolicitud["Otro"].ToString();
                        break;
                }
            }
        }

        private void SolicitudHorasExtras_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
