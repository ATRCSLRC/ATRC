using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECADOR.BL
{
    [Persistent("Ch_HistoricoChecadas")]
    public class HistoricoChecadas : ATRCBase
    {
        public HistoricoChecadas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private DateTime mFechaChecada;
        public DateTime FechaChecada
        {
            get { return mFechaChecada; }
            set { SetPropertyValue<DateTime>("FechaChecada", ref mFechaChecada, value); }
        }

        private TimeSpan mHoraChecadaEntrada;
        public TimeSpan HoraChecadaEntrada
        {
            get { return mHoraChecadaEntrada; }
            set { SetPropertyValue<TimeSpan>("HoraChecadaEntrada", ref mHoraChecadaEntrada, value); }
        }

        private Nullable<TimeSpan> mHoraChecadaSalida;
        public Nullable<TimeSpan> HoraChecadaSalida
        {
            get { return mHoraChecadaSalida; }
            set { SetPropertyValue<Nullable<TimeSpan>>("HoraChecadaSalida", ref mHoraChecadaSalida, value); }
        }

        private string mMotivo;
        [Size(300)]
        public string Motivo
        {

            get { return mMotivo; }
            set { SetPropertyValue<string>("Motivo", ref mMotivo, value); }
        }

        private Enums.TipoIdentificacion mTipoIdentificacionEntrada;
        public Enums.TipoIdentificacion TipoIdentificacionEntrada
        {
            get { return mTipoIdentificacionEntrada; }
            set { SetPropertyValue<Enums.TipoIdentificacion>("TipoIdentificacionEntrada", ref mTipoIdentificacionEntrada, value); }
        }

        private Enums.TipoIdentificacion mTipoIdentificacionSalida;
        public Enums.TipoIdentificacion TipoIdentificacionSalida
        {
            get { return mTipoIdentificacionSalida; }
            set { SetPropertyValue<Enums.TipoIdentificacion>("TipoIdentificacionSalida", ref mTipoIdentificacionSalida, value); }
        }

        private UsuarioChecador mUsuario;
        [Association("Usuario-HistoricoChecadas")]
        public UsuarioChecador Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue("Usuario", ref mUsuario, value); }
        }

        [NonPersistent]
        public decimal HoraChecadaCalculadaEntrada
        {
            get
            {
                return CHECADOR.BL.Utilerias.CalcularHora(this.HoraChecadaEntrada);
            }

        }

        [NonPersistent]
        public decimal HoraChecadaCalculadaSalida
        {
            get
            {
                if (this.HoraChecadaSalida != null)
                    return CHECADOR.BL.Utilerias.CalcularHora((this.HoraChecadaSalida).Value);
                else
                    return 0;
            }

        }

        [NonPersistent]
        public decimal TotalHoras
        {
            get
            {
                return this.HoraChecadaCalculadaSalida > 0 & this.HoraChecadaCalculadaEntrada > 0 ? (this.HoraChecadaCalculadaSalida - this.HoraChecadaCalculadaEntrada) : 0;
            }

        }

    }
}
