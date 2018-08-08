using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_Coordenadas")]
    public class Coordenadas : ATRCBase
    {
        public Coordenadas(Session session) : base(session) { }

        double mLatitud;
        public double Latitud
        {
            get { return mLatitud; }
            set { SetPropertyValue<double>("Latitud", ref mLatitud, value); }
        }

        double mLongitud;
        public double Longitud
        {
            get { return mLongitud; }
            set { SetPropertyValue<double>("Longitud", ref mLongitud, value); }
        }

        int mIndice;
        public int Indice
        {
            get { return mIndice; }
            set { SetPropertyValue<int>("Longitud", ref mIndice, value); }
        }

        string mCalle;
        public string Calle
        {
            get { return mCalle; }
            set { SetPropertyValue<string>("Calle", ref mCalle, value); }
        }

        private Rutas mRuta;
        [Association("Rutas-Coordenadas")]
        public Rutas Ruta
        {
            get { return mRuta; }
            set { SetPropertyValue<Rutas>("Ruta", ref mRuta, value); }
        }
    }
}
