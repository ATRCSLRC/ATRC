using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIDADES.BL;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_Gasolina")]
    public class Gasolina : ATRCBase
    {
        public Gasolina(Session session) : base(session) { }

        private Usuario mEmpleado;
        public Usuario Empleado
        {
            get { return mEmpleado; }
            set { SetPropertyValue<Usuario>("Empleado", ref mEmpleado, value); }
        }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Int64 mMillas;
        public Int64 Millas
        {
            get { return mMillas; }
            set { SetPropertyValue<Int64>("Millas", ref mMillas, value); }
        }

        private Int64 mMillasRecorridas;
        public Int64 MillasRecorridas
        {
            get { return mMillasRecorridas; }
            set { SetPropertyValue<Int64>("MillasRecorridas", ref mMillasRecorridas, value); }
        }

        private Int64 mCandadoActual;
        public Int64 CandadoActual
        {
            get { return mCandadoActual; }
            set { SetPropertyValue<Int64>("CandadoActual", ref mCandadoActual, value); }
        }

        private Int64 mCandadoAnterior;
        public Int64 CandadoAnterior
        {
            get { return mCandadoAnterior; }
            set { SetPropertyValue<Int64>("CandadoAnterior", ref mCandadoAnterior, value); }
        }

        private decimal mLitros;
        public decimal Litros
        {
            get { return mLitros; }
            set { SetPropertyValue<decimal>("Litros", ref mLitros, value); }
        }

        private bool mLlenado;
        public bool Llenado
        {
            get { return mLlenado; }
            set { SetPropertyValue<bool>("Llenado", ref mLlenado, value); }
        }

        private RecargaDiesel mUltimaRecarga;
        public RecargaDiesel UltimaRecarga
        {
            get { return mUltimaRecarga; }
            set { SetPropertyValue<RecargaDiesel>("UltimaRecarga", ref mUltimaRecarga, value); }
        }

        private MedidorDiesel mMedidorGasolinas;
        public MedidorDiesel MedidorGasolinas
        {
            get { return mMedidorGasolinas; }
            set { SetPropertyValue<MedidorDiesel>("MedidorGasolinas", ref mMedidorGasolinas, value); }
        }
    }
}
