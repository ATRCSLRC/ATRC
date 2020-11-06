using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.XtraEditors;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUARDIAS.WIN
{
    public partial class xfrmCambioHorario : xfrmBase
    {
        public xfrmCambioHorario()
        {
            InitializeComponent();
        }

        public int IDContrato = 0;
        public bool EsSalida = false;
        UnidadDeTrabajo Unidad;
        ContratoRenta Contrato;

        private void xfrmCambioHorario_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            if (IDContrato >= 0)
                Contrato = Unidad.GetObjectByKey<ContratoRenta>(IDContrato);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (EsSalida)
            {
                if (Contrato.EstadoContrato != Enums.EstadoContrato.Apartado & Contrato.EstadoContrato != Enums.EstadoContrato.Cancelado)
                {
                    Contrato.HoraSalidaOriginal = tmeHora.Time.TimeOfDay;
                    Contrato.DiaSalidaOriginal = dteDia.DateTime.Date;
                    Tuple<decimal, string> X = Calcular();
                    switch (Contrato.EstadoContrato)
                    {
                        case Enums.EstadoContrato.Creado:
                            Contrato.EstadoContrato = Enums.EstadoContrato.EnViaje;
                            break;

                        case Enums.EstadoContrato.Terminado:
                            Contrato.Recargos = Calcular().Item1;
                            Contrato.Comentarios = X.Item2;
                            break;
                    }
                }else
                {
                    XtraMessageBox.Show("No se puede cambiar el horario");
                    return;
                }
            }
            else
            {
                if (Contrato.EstadoContrato != Enums.EstadoContrato.Creado & Contrato.EstadoContrato != Enums.EstadoContrato.Apartado
                    & Contrato.EstadoContrato != Enums.EstadoContrato.Cancelado)
                {
                    
                    Contrato.HoraRegresoOriginal = tmeHora.Time.TimeOfDay;
                    Contrato.DiaRegresoOriginal = dteDia.DateTime.Date;
                    Tuple<decimal, string> X = Calcular();
                    Contrato.Recargos = X.Item1;
                    Contrato.Comentarios = X.Item2;
                    switch (Contrato.EstadoContrato)
                    {
                        case Enums.EstadoContrato.EnViaje:
                        case Enums.EstadoContrato.Terminado:
                            Contrato.EstadoContrato = Enums.EstadoContrato.Terminado;
                            break;
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede cambiar el horario");
                    return;
                }
            }

            Contrato.Save();
            Contrato.Session.CommitTransaction();
            XtraMessageBox.Show("Se realizaron los cambios correctamente.");
            this.Close();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private Tuple<decimal, string> Calcular()
        {
            var f = Contrato.DiaSalidaOriginal.Add(Contrato.HoraSalidaOriginal);
            var Entrega = Contrato.DiaRegresoOriginal.Add(Contrato.HoraRegresoOriginal);
            decimal Horas = (Entrega - f).Hours;
            decimal Dias = (Entrega - f).Days;
            decimal HoraDias = (Horas / 24) + (Dias);
            decimal DiasExtra = 0;
            decimal ExtraDia = 0;
            int MediosDiasTarde = 0;
            decimal HorasTardes = 0;
            string Comentarios = string.Empty;

            if (HoraDias >= Contrato.DiasRenta)
            {

                if ((HoraDias - Contrato.DiasRenta) >= 1)
                {
                    DiasExtra = (Dias - Contrato.DiasRenta);
                    ExtraDia = Contrato.Costo * DiasExtra;
                }
                else if (Contrato.DiasRenta.ToString().Contains(".5"))
                {
                    Horas -= 12;
                }

                if (Horas >= 19 & Horas <= 24)
                {
                    DiasExtra += 1;
                    ExtraDia += DiasExtra * Contrato.Costo;
                    Horas -= 24;
                }


                if (Horas >= 7 & Horas <= 18)
                {
                    MediosDiasTarde = 1;
                    ExtraDia += Contrato.Costo / 2;
                    Horas -= 12;
                }

                if (Horas >= 1 & Horas <= 6 & Horas >= Contrato.TiempoTolerancia)
                {
                    ExtraDia += Horas * Contrato.CostoTolerancia;
                    HorasTardes = Horas;
                }

                string EntregaTarde = string.Empty;
                
                if (DiasExtra > 0)
                    EntregaTarde += DiasExtra.ToString("n1") + " día(s)";
                if (MediosDiasTarde > 0)
                    EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? " medio día " : " y medio";
                if (HorasTardes > 0)
                    EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? HorasTardes + " hora(s) " : " con " + HorasTardes + " hora(s) ";

                if (!string.IsNullOrEmpty(EntregaTarde))
                    Comentarios = "La unidad se entrego " + EntregaTarde + " tarde.";
            }
           return new Tuple<decimal, string>(ExtraDia, Comentarios);
        }

    }
}
