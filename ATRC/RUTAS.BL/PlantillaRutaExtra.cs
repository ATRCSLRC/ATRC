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

        
        private Nullable<DateTime> mHoraEntrada;
        public Nullable<DateTime> HoraEntrada
        {
            get { return mHoraEntrada; }
            set { SetPropertyValue<Nullable<DateTime>>("HoraEntrada", ref mHoraEntrada, value); }
        }

        
        private Nullable<DateTime> mHoraSalida;
        public Nullable<DateTime> HoraSalida
        {
            get { return mHoraSalida; }
            set { SetPropertyValue<Nullable<DateTime>>("HoraSalida", ref mHoraSalida, value); }
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

        //[NonPersistent]
        //public string ChoferEntradaDetalle
        //{
        //    get
        //    {
        //        if (ChoferEntrada != null)
        //        {
        //            return ChoferEntrada.NumEmpleado + " - " + ChoferEntrada.Nombre;
        //        }
        //        return string.Empty;
        //    }
        //}

        //[NonPersistent]
        //public string ChoferSalidaDetalle
        //{
        //    get
        //    {
        //        if(RutaCompleta)
        //        {
        //            if(TipoRuta != TipoRuta.Salida & TipoRuta != TipoRuta.Entrada)
        //                return ChoferEntradaDetalle;
        //        }

        //        if (ChoferSalida != null)
        //        {
        //            return ChoferSalida.NumEmpleado + " - " + ChoferSalida.Nombre;
        //        }

        //        return string.Empty;
        //    }
        //}
    }
}
