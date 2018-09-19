using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace RUTAS.BL
{
    [Persistent("rut_PlantillaRutaExtra")]
    public class PlantillaRutaExtra : ATRCBase
    {
        public PlantillaRutaExtra(Session session) : base(session) { }

        private TipoRuta mTipoRuta;
        public TipoRuta TipoRuta
        {
            get { return mTipoRuta; }
            set { SetPropertyValue<TipoRuta>("TipoRuta", ref mTipoRuta, value); }
        }

        private TipoUnidad mTipoUnidad;
        public TipoUnidad TipoUnidad
        {
            get { return mTipoUnidad; }
            set { SetPropertyValue<TipoUnidad>("TipoUnidad", ref mTipoUnidad, value); }
        }

        private PlantillaRutas mPlantillaRutas;
        [Association("rut_PlantillaRutas-PlantillaRutaExtra")]
        public PlantillaRutas PlantillaRutas
        {
            get { return mPlantillaRutas; }
            set { SetPropertyValue<PlantillaRutas>("PlantillaRutas", ref mPlantillaRutas, value); }
        }

        [Custom("EditMaskType", "DateTime")]
        [Custom("EditMask", @"hh:mm tt")]
        [Custom("DisplayFormat", "{0:hh\\:mm tt}")]
        private Nullable<TimeSpan> mHoraEntrada;
        public Nullable<TimeSpan> HoraEntrada
        {
            get { return mHoraEntrada; }
            set { SetPropertyValue<Nullable<TimeSpan>>("HoraEntrada", ref mHoraEntrada, value); }
        }

        [Custom("EditMaskType", "DateTime")]
        [Custom("EditMask", @"hh:mm tt")]
        [Custom("DisplayFormat", "{0:hh\\:mm tt}")]
        private Nullable<TimeSpan> mHoraSalida;
        public Nullable<TimeSpan> HoraSalida
        {
            get { return mHoraSalida; }
            set { SetPropertyValue<Nullable<TimeSpan>>("HoraSalida", ref mHoraSalida, value); }
        }

        private Usuario mChoferEntrada;
        public Usuario ChoferEntrada
        {
            get { return mChoferEntrada; }
            set { SetPropertyValue<Usuario>("ChoferEntrada", ref mChoferEntrada, value); }
        }

        private Usuario mChoferSalida;
        public Usuario ChoferSalida
        {
            get { return mChoferSalida; }
            set { SetPropertyValue<Usuario>("ChoferSalida", ref mChoferSalida, value); }
        }

        private bool mRutaCompleta;
        public bool RutaCompleta
        {
            get { return mRutaCompleta; }
            set { SetPropertyValue<bool>("RutaCompleta", ref mRutaCompleta, value); }
        }

        private bool mPagarChoferEntrada;
        public bool PagarChoferEntrada
        {
            get { return mPagarChoferEntrada; }
            set { SetPropertyValue<bool>("PagarChoferEntrada", ref mPagarChoferEntrada, value); }
        }

        private bool mPagarChoferSalida;
        public bool PagarChoferSalida
        {
            get { return mPagarChoferSalida; }
            set { SetPropertyValue<bool>("PagarChoferSalida", ref mPagarChoferSalida, value); }
        }

        private string mComentarios;
        [Size(SizeAttribute.Unlimited)]
        public string Comentarios
        {
            get { return mComentarios; }
            set { SetPropertyValue<string>("Comentarios", ref mComentarios, value); }
        }

        [NonPersistent]
        public string ChoferEntradaDetalle
        {
            get
            {
                if (ChoferEntrada != null)
                {
                    return ChoferEntrada.NumEmpleado + " - " + ChoferEntrada.Nombre;
                }
                return string.Empty;
            }
        }

        [NonPersistent]
        public string ChoferSalidaDetalle
        {
            get
            {
                if(RutaCompleta)
                {
                    if(TipoRuta != TipoRuta.Salida & TipoRuta != TipoRuta.Entrada)
                        return ChoferEntradaDetalle;
                }

                if (ChoferSalida != null)
                {
                    return ChoferSalida.NumEmpleado + " - " + ChoferSalida.Nombre;
                }

                return string.Empty;
            }
        }
    }
}
