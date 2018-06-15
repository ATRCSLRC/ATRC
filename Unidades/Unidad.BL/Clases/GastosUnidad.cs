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

        private decimal mTipoCambio;
        public decimal TipoCambio
        {
            get { return mTipoCambio; }
            set { SetPropertyValue<decimal>("TipoCambio", ref mTipoCambio, value); }
        }

        private Enums.TipoMoneda mTipoMoneda;
        public Enums.TipoMoneda TipoMoneda
        {
            get { return mTipoMoneda; }
            set { SetPropertyValue<Enums.TipoMoneda>("TipoMoneda", ref mTipoMoneda, value); }
        }

        private Enums.ConceptoGasto mConceptoDeGasto;
        public Enums.ConceptoGasto ConceptoDeGasto
        {
            get { return mConceptoDeGasto; }
            set { SetPropertyValue<Enums.ConceptoGasto>("ConceptoDeGasto", ref mConceptoDeGasto, value); }
        }

        private Enums.FormaPago mFormaDePago;
        public Enums.FormaPago FormaDePago
        {
            get { return mFormaDePago; }
            set { SetPropertyValue<Enums.FormaPago>("FormaDePago", ref mFormaDePago, value); }
        }

        private Enums.TipoTransaccion mTipoTransaccion;
        public Enums.TipoTransaccion TipoTransaccion
        {
            get { return mTipoTransaccion; }
            set { SetPropertyValue<Enums.TipoTransaccion>("TipoTransaccion", ref mTipoTransaccion, value); }
        }

        private string mLugarCompra;
        [Size(SizeAttribute.Unlimited)]
        public string LugarCompra
        {
            get { return mLugarCompra; }
            set { SetPropertyValue<string>("LugarCompra", ref mLugarCompra, value); }
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

        [NonPersistent]
        public decimal CantidadConvertida
        {
            get
            {
                if (this.TipoMoneda == Enums.TipoMoneda.Dolares)
                    return (Cantidad * TipoCambio);//Convertir a pesos
                else
                    return (Cantidad / TipoCambio);//Convertir a dolar
            }
        }

        
    }
}
