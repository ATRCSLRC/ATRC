
using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.BL
{
    [Persistent("Uni_Unidad")]
    public class Unidad : ATRCBase
    {
        public Unidad(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mNombre;
        [Size(100)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private TipoUnidad mTipoUnidad;
        public TipoUnidad TipoUnidad
        {
            get { return mTipoUnidad; }
            set { SetPropertyValue<TipoUnidad>("TipoUnidad", ref mTipoUnidad, value); }
        }

        private string mMillas;
        [Size(60)]
        public string Millas
        {
            get { return mMillas; }
            set { SetPropertyValue<string>("Millas", ref mMillas, value); }
        }

        private Combustible mCombustible;
        public Combustible Combustible
        {
            get { return mCombustible; }
            set { SetPropertyValue<Combustible>("Combustible", ref mCombustible, value); }
        }

        private string mMotor;
        [Size(60)]
        public string Motor
        {
            get { return mMotor; }
            set { SetPropertyValue<string>("Motor", ref mMotor, value); }
        }

        private int mCilindros;
        public int Cilindros
        {
            get { return mCilindros; }
            set { SetPropertyValue<int>("Cilindros", ref mCilindros, value); }
        }

        private Transmision mTransmision;
        public Transmision Transmision
        {
            get { return mTransmision; }
            set { SetPropertyValue<Transmision>("Transmision", ref mTransmision, value); }
        }

        private Frenos mFrenos;
        public Frenos Frenos
        {
            get { return mFrenos; }
            set { SetPropertyValue<Frenos>("Frenos", ref mFrenos, value); }
        }

        private bool mAireAcondicionado;
        public bool AireAcondicionado
        {
            get { return mAireAcondicionado; }
            set { SetPropertyValue<bool>("AireAcondicionado", ref mAireAcondicionado, value); }
        }

        private Suspencion mSuspencion;
        public Suspencion Suspencion
        {
            get { return mSuspencion; }
            set { SetPropertyValue<Suspencion>("Suspencion", ref mSuspencion, value); }
        }

        private bool mTieneRadio;
        public bool TieneRadio
        {
            get { return mTieneRadio; }
            set { SetPropertyValue<bool>("TieneRadio", ref mTieneRadio, value); }
        }

        private string mColor;
        [Size(60)]
        public string Color
        {
            get { return mColor; }
            set { SetPropertyValue<string>("Color", ref mColor, value); }
        }

        private string mMarca;
        [Size(80)]
        public string Marca
        {
            get { return mMarca; }
            set { SetPropertyValue<string>("Marca", ref mMarca, value); }
        }

        private string mPlacas;
        [Size(60)]
        public string Placas
        {
            get { return mPlacas; }
            set { SetPropertyValue<string>("Placas", ref mPlacas, value); }
        }

        private string mModelo;
        [Size(60)]
        public string Modelo
        {
            get { return mModelo; }
            set { SetPropertyValue<string>("Modelo", ref mModelo, value); }
        }

        private string mVIN;
        [Size(60)]
        public string VIN
        {
            get { return mVIN; }
            set { SetPropertyValue<string>("VIN", ref mVIN, value); }
        }

        private string mBaterias;
        [Size(80)]
        public string Baterias
        {
            get { return mBaterias; }
            set { SetPropertyValue<string>("Baterias", ref mBaterias, value); }
        }

        private DateTime mFechaInventarioBaterias;
        public DateTime FechaInventarioBaterias
        {
            get { return mFechaInventarioBaterias; }
            set { SetPropertyValue<DateTime>("FechaInventarioBaterias", ref mFechaInventarioBaterias, value); }
        }

        private string mComentarioBateria;
        [Size(SizeAttribute.Unlimited)]
        public string ComentarioBateria
        {
            get { return mComentarioBateria; }
            set { SetPropertyValue<string>("ComentarioBateria", ref mComentarioBateria, value); }
        }

        private int mAsientos;
        public int Asientos
        {
            get { return mAsientos; }
            set { SetPropertyValue<int>("Asientos", ref mAsientos, value); }
        }

        private int mPasajeros;
        public int Pasajeros
        {
            get { return mPasajeros; }
            set { SetPropertyValue<int>("Pasajeros", ref mPasajeros, value); }
        }

        private int mAbanicos;
        public int Abanicos
        {
            get { return mAbanicos; }
            set { SetPropertyValue<int>("Abanicos", ref mAbanicos, value); }
        }

        private int mVentanasLaterales;
        public int VentanasLaterales
        {
            get { return mVentanasLaterales; }
            set { SetPropertyValue<int>("VentanasLaterales", ref mVentanasLaterales, value); }
        }

        private bool mTieneEstereo;
        public bool TieneEstereo
        {
            get { return mTieneEstereo; }
            set { SetPropertyValue<bool>("TieneEstereo", ref mTieneEstereo, value); }
        }

        private bool mTieneBocinas;
        public bool TieneBocinas
        {
            get { return mTieneBocinas; }
            set { SetPropertyValue<bool>("TieneBocinas", ref mTieneBocinas, value); }
        }

        private bool mTieneCamaras;
        public bool TieneCamaras
        {
            get { return mTieneCamaras; }
            set { SetPropertyValue<bool>("TieneCamaras", ref mTieneCamaras, value); }
        }

        private Puerta mPuerta;
        public Puerta Puerta
        {
            get { return mPuerta; }
            set { SetPropertyValue<Puerta>("Puerta", ref mPuerta, value); }
        }

        private bool mTieneExtinguidor;
        public bool TieneExtinguidor
        {
            get { return mTieneExtinguidor; }
            set { SetPropertyValue<bool>("TieneExtinguidor", ref mTieneExtinguidor, value); }
        }

        Extintores mExtintor = null;
        public Extintores Extintor
        {
            get { return mExtintor; }
            set
            {
                if (mExtintor == value)
                    return;

                // Store a reference to the former owner. 
                Extintores extintor = mExtintor;
                mExtintor = value;

                if (IsLoading) return;

                // Remove an owner's reference to this building, if exists. 
                if (extintor != null && extintor.Unidad == this)
                    extintor.Unidad = null;

                // Specify that the building is a new owner's house. 
                if (mExtintor != null)
                    mExtintor.Unidad = this;
                OnChanged("Extintor");
            }
        }

        private bool mTieneTrancas;
        public bool TieneTrancas
        {
            get { return mTieneTrancas; }
            set { SetPropertyValue<bool>("TieneTrancas", ref mTieneTrancas, value); }
        }

        private string mFiltroAceiteMotor;
        [Size(30)]
        public string FiltroAceiteMotor
        {
            get { return mFiltroAceiteMotor; }
            set { SetPropertyValue<string>("FiltroAceiteMotor", ref mFiltroAceiteMotor, value); }
        }

        private string mFiltroCombustible;
        [Size(30)]
        public string FiltroCombustible
        {
            get { return mFiltroCombustible; }
            set { SetPropertyValue<string>("FiltroCombustible", ref mFiltroCombustible, value); }
        }

        private string mFiltroAceiteTransmision;
        [Size(30)]
        public string FiltroAceiteTransmision
        {
            get { return mFiltroAceiteTransmision; }
            set { SetPropertyValue<string>("FiltroAceiteTransmision", ref mFiltroAceiteTransmision, value); }
        }

        private string mFiltroAire;
        [Size(30)]
        public string FiltroAire
        {
            get { return mFiltroAire; }
            set { SetPropertyValue<string>("FiltroAire", ref mFiltroAire, value); }
        }

        private string mFiltroAgua;
        [Size(30)]
        public string FiltroAgua
        {
            get { return mFiltroAgua; }
            set { SetPropertyValue<string>("FiltroAgua", ref mFiltroAgua, value); }
        }

        private Imagen mImagen;
        public Imagen Imagen
        {
            get { return mImagen; }
            set { SetPropertyValue<Imagen>("Imagen", ref mImagen, value); }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private DateTime mUltimoCambioAceite;
        public DateTime UltimoCambioAceite
        {
            get { return mUltimoCambioAceite; }
            set { SetPropertyValue<DateTime>("Usuario", ref mUltimoCambioAceite, value); }
        }

        private EstadoUnidad mEstadoUnidad;
        public EstadoUnidad EstadoUnidad
        {
            get { return mEstadoUnidad; }
            set { SetPropertyValue<EstadoUnidad>("EstadoUnidad", ref mEstadoUnidad, value); }
        }

        private DateTime mUltimoEstado;
        public DateTime UltimoEstado
        {
            get { return mUltimoEstado; }
            set { SetPropertyValue<DateTime>("UltimoEstado", ref mUltimoEstado, value); }
        }

        private bool mEsRenta;
        public bool EsRenta
        {
            get { return mEsRenta; }
            set { SetPropertyValue<bool>("EsRenta", ref mEsRenta, value); }
        }

        private string mDueño;
        [Size(150)]
        public string Dueño
        {
            get { return mDueño; }
            set { SetPropertyValue<string>("Dueño", ref mDueño, value); }
        }
        //private decimal mPrecioRenta;
        //public decimal PrecioRenta
        //{
        //    get { return mPrecioRenta; }
        //    set { SetPropertyValue<decimal>("PrecioRenta", ref mPrecioRenta, value); }
        //}

        [NonPersistent]
        public object LlantaFrontalIzquierda
        {
            get { return this.GetMemberValue("LlantaFrontalIzquierdaChofer"); }
        }

        [NonPersistent]
        public object LlantaFrontalDerecha
        {
            get { return this.GetMemberValue("LlantaFrontalDerechaEstribo"); }
        }

        [NonPersistent]
        public object LlantaTraseraIntChofer
        {
            get { return this.GetMemberValue("LlantaTraseraInteriorChofer"); }
        }

        [NonPersistent]
        public object LlantaTraseraIntEstribo
        {
            get { return this.GetMemberValue("LlantaTraseraInteriorEstribo"); }
        }

        [NonPersistent]
        public object LlantaTraseraExtChofer
        {
            get { return this.GetMemberValue("LlantaTraseraExteriorChofer"); }
        }

        [NonPersistent]
        public object LlantaTraseraExtEstribo
        {
            get { return this.GetMemberValue("LlantaTraseraExteriorEstribo"); }
        }

        public void GenerarHistorialBaterias(string Baterias, DateTime Fecha, string Comentario)
        {
            HistorialBaterias Historial = new HistorialBaterias(this.Session);
            Historial.Unidad = this;
            Historial.Baterias = Baterias;
            Historial.Comentarios = Comentario;
            Historial.FechaInventarioBaterias = Fecha;
            Historial.Save();
        }
    }
}
