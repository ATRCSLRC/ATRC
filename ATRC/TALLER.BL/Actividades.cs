using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TALLER.BL
{
    [Persistent("Tal_Actividades")]
    public class Actividades : ATRCBase
    {
        public Actividades(Session session) : base(session) { }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private string mActividad;
        [Size(SizeAttribute.Unlimited)]
        public string Actividad
        {
            get { return mActividad; }
            set { SetPropertyValue<string>("Actividad", ref mActividad, value); }
        }

        private TimeSpan mHoraInicial;
        public TimeSpan HoraInicial
        {
            get { return mHoraInicial; }
            set { SetPropertyValue<TimeSpan>("HoraInicial", ref mHoraInicial, value); }
        }

        private TimeSpan mHoraFinal;
        public TimeSpan HoraFinal
        {
            get { return mHoraFinal; }
            set { SetPropertyValue<TimeSpan>("HoraFinal", ref mHoraFinal, value); }
        }

        private double mTotal;
        public double Total
        {
            get { return mTotal; }
            set { SetPropertyValue<double>("Total", ref mTotal, value); }
        }

    }
}
