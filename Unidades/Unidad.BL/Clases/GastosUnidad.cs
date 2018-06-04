using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unidad.BL
{
    [Persistent("Uni_Gastos")]
    public class GastosUnidad : ATRCBase
    {
        public GastosUnidad(Session session) : base(session) { }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private decimal mCantidad;
        public decimal Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<decimal>("Cantidad", ref mCantidad, value); }
        }

        private Enums.TipoMoneda mTipoMoneda;
        public Enums.TipoMoneda TipoMoneda
        {
            get { return mTipoMoneda; }
            set { SetPropertyValue<Enums.TipoMoneda>("TipoMoneda", ref mTipoMoneda, value); }
        }

        private string mComentarios;
        [Size(SizeAttribute.Unlimited)]
        public string Comentarios
        {
            get { return mComentarios; }
            set { SetPropertyValue<string>("Comentarios", ref mComentarios, value); }
        }

        private Unidad mUnidad;
        [Association("Unidad-Gastos")]
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }
    }
}
