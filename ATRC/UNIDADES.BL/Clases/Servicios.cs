using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.BL
{
    [Persistent("Uni_Servicios")]
    public class Servicios : ATRCBase
    {
        public Servicios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private ServiciosUnidad mServicio;
        public ServiciosUnidad Servicio
        {
            get { return mServicio; }
            set { SetPropertyValue<ServiciosUnidad>("Servicio", ref mServicio, value); }
        }

        private string mDetalles;
        [Size(SizeAttribute.Unlimited)]
        public string Detalles
        {
            get { return mDetalles; }
            set { SetPropertyValue<string>("Detalles", ref mDetalles, value); }
        }

        private string mMillas;
        [Size(60)]
        public string Millas
        {
            get { return mMillas; }
            set { SetPropertyValue<string>("Millas", ref mMillas, value); }
        }
    }
}
