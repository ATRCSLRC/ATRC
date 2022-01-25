using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUTAS.BL
{
    [Persistent("rut_PlantillaServiciosRealizados")]
    public class PlantillaServiciosRealizados : ATRCBase
    {
        public PlantillaServiciosRealizados(Session session) : base(session) { }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private bool mAgruparPorRutas;
        public bool AgruparPorRutas
        {
            get { return mAgruparPorRutas; }
            set { SetPropertyValue<bool>("AgruparPorRutas", ref mAgruparPorRutas, value); }
        }

        private bool mAgruparApoyos;
        public bool AgruparApoyos
        {
            get { return mAgruparApoyos; }
            set { SetPropertyValue<bool>("AgruparApoyos", ref mAgruparApoyos, value); }
        }

        private bool mSepararServiciosValle;
        public bool SepararServiciosValle
        {
            get { return mSepararServiciosValle; }
            set { SetPropertyValue<bool>("SepararServiciosValle", ref mSepararServiciosValle, value); }
        }

        private bool mSepararPorNombre;
        public bool SepararPorNombre
        {
            get { return mSepararPorNombre; }
            set { SetPropertyValue<bool>("SepararPorNombre", ref mSepararPorNombre, value); }
        }

        private bool mMostrarNombreRuta;
        public bool MostrarNombreRuta
        {
            get { return mMostrarNombreRuta; }
            set { SetPropertyValue<bool>("MostrarNombreRuta", ref mMostrarNombreRuta, value); }
        }

        private bool mMostrarPorTurno;
        public bool MostrarPorTurno
        {
            get { return mMostrarPorTurno; }
            set { SetPropertyValue<bool>("MostrarPorTurno", ref mMostrarPorTurno, value); }
        }

        private bool mMostrarTextoEntrada;
        public bool MostrarTextoEntrada
        {
            get { return mMostrarTextoEntrada; }
            set { SetPropertyValue<bool>("MostrarTextoEntrada", ref mMostrarTextoEntrada, value); }
        }

        private string mTextoEntrada;
        [Size(SizeAttribute.Unlimited)]
        public string TextoEntrada
        {
            get { return mTextoEntrada; }
            set { SetPropertyValue<string>("TextoEntrada", ref mTextoEntrada, value); }
        }

        private bool mMostrarTextoSalida;
        public bool MostrarTextoSalida
        {
            get { return mMostrarTextoSalida; }
            set { SetPropertyValue<bool>("MostrarTextoSalida", ref mMostrarTextoSalida, value); }
        }

        private string mTextoSalida;
        [Size(SizeAttribute.Unlimited)]
        public string TextoSalida
        {
            get { return mTextoSalida; }
            set { SetPropertyValue<string>("TextoSalida", ref mTextoSalida, value); }
        }

    }
}
