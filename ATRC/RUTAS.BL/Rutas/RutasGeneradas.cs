using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace RUTAS.BL
{
    [Persistent("rut_RutasGeneradas")]
    public class RutasGeneradas : ATRCBase
    {
        public RutasGeneradas(Session session) : base(session) { }

        private Servicio mServicio;
        public Servicio Servicio
        {
            get { return mServicio; }
            set { SetPropertyValue<Servicio>("Servicio", ref mServicio, value); }
        }

        private DateTime mFechaRuta;
        public DateTime FechaRuta
        {
            get { return mFechaRuta; }
            set { SetPropertyValue<DateTime>("FechaRuta", ref mFechaRuta, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

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

        private Turno mTurno;
        public Turno Turno
        {
            get { return mTurno; }
            set { SetPropertyValue<Turno>("Turno", ref mTurno, value); }
        }

        private PlantillaRutas mPlantillaRutas;
        [Association("rut_PlantillaRutas-PlantillaRutaFija")]
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

        private bool mEsRutaExtra;
        public bool EsRutaExtra
        {
            get { return mEsRutaExtra; }
            set { SetPropertyValue<bool>("EsRutaExtra", ref mEsRutaExtra, value); }
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

        private string mComentariosFacturacion;
        [Size(SizeAttribute.Unlimited)]
        public string ComentariosFacturacion
        {
            get { return mComentariosFacturacion; }
            set { SetPropertyValue<string>("ComentariosFacturacion", ref mComentariosFacturacion, value); }
        }

        private string mRuta;
        [Size(SizeAttribute.Unlimited)]
        public string Ruta
        {
            get { return mRuta; }
            set { SetPropertyValue<string>("Ruta", ref mRuta, value); }
        }

        private decimal mTipoCambio;
        public decimal TipoCambio
        {
            get { return mTipoCambio; }
            set { SetPropertyValue<decimal>("TipoCambio", ref mTipoCambio, value); }
        }

        private decimal mPrecio;
        public decimal Precio
        {
            get { return mPrecio; }
            set { SetPropertyValue<decimal>("Precio", ref mPrecio, value); }
        }

        private int mCantidad;
        [NonPersistent]
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        private decimal mImporteDolar;
        [NonPersistent]
        public decimal ImporteDolar
        {
            get { return mImporteDolar; }
            set { SetPropertyValue<decimal>("ImporteDolar", ref mImporteDolar, value); }
        }

        private decimal mImportePesos;
        [NonPersistent]
        public decimal ImportePesos
        {
            get { return mImportePesos; }
            set { SetPropertyValue<decimal>("ImportePesos", ref mImportePesos, value); }
        }

        private int mOrden;
        [NonPersistent]
        public int Orden
        {
            get { return mOrden; }
            set { SetPropertyValue<int>("Orden", ref mOrden, value); }
        }


        [Association("Historial-RutasGeneradas")] 
        public XPCollection<HistorialRutaGenerada> Historial
        {
            get
            {
                return GetCollection<HistorialRutaGenerada>(nameof(Historial));
            }
        }
    }
}
