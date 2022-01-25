using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_SolicitudHorasExtra")]
    public class SolicitudHorasExtra : ATRCBase
    {
        public SolicitudHorasExtra(Session session) : base(session) { }

        private DateTime mFechaSolicitud;
        public DateTime FechaSolicitud
        {
            get { return mFechaSolicitud; }
            set { SetPropertyValue<DateTime>("FechaSolicitud", ref mFechaSolicitud, value); }
        }

        private DateTime mNominaDe;
        public DateTime NominaDe
        {
            get { return mNominaDe; }
            set { SetPropertyValue<DateTime>("NominaDe", ref mNominaDe, value); }
        }

        private DateTime mNominaA;
        public DateTime NominaA
        {
            get { return mNominaA; }
            set { SetPropertyValue<DateTime>("NominaA", ref mNominaA, value); }
        }

        private Usuario mEmpleado;
        public Usuario Empleado
        {
            get { return mEmpleado; }
            set { SetPropertyValue<Usuario>("Empleado", ref mEmpleado, value); }
        }

        private string mMotivoHorasExtra;
        [Size(SizeAttribute.Unlimited)]
        public string MotivoHorasExtra
        {
            get { return mMotivoHorasExtra; }
            set { SetPropertyValue<string>("MotivoHorasExtra", ref mMotivoHorasExtra, value); }
        }

        private string mDias;
        [Size(24)]
        public string Dias
        {
            get { return mDias; }
            set { SetPropertyValue<string>("Dias", ref mDias, value); }
        }

        private string mOtro;
        [Size(24)]
        public string Otro
        {
            get { return mOtro; }
            set { SetPropertyValue<string>("Otro", ref mOtro, value); }
        }
    }
}
