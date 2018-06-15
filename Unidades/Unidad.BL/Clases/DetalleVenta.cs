using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unidad.BL
{
    [Persistent("Uni_DetalleVenta")]
    public class DetalleVenta : ATRCBase
    {
        public DetalleVenta(Session session) : base(session) { }

        private DateTime mFechaVenta;
        public DateTime FechaVenta
        {
            get { return mFechaVenta; }
            set { SetPropertyValue<DateTime>("FechaVenta", ref mFechaVenta, value); }
        }

        private bool mPagado;
        public bool Pagado
        {
            get { return mPagado; }
            set { SetPropertyValue<bool>("Pagado", ref mPagado, value); }
        }

        private decimal mPrecioUnidad;
        public decimal PrecioUnidad
        {
            get { return mPrecioUnidad; }
            set { SetPropertyValue<decimal>("PrecioUnidad", ref mPrecioUnidad, value); }
        }

        private Enums.TipoMoneda mTipoMoneda;
        public Enums.TipoMoneda TipoMoneda
        {
            get { return mTipoMoneda; }
            set { SetPropertyValue<Enums.TipoMoneda>("TipoMoneda", ref mTipoMoneda, value); }
        }

        private Enums.FormaPago mFormaDePago;
        public Enums.FormaPago FormaDePago
        {
            get { return mFormaDePago; }
            set { SetPropertyValue<Enums.FormaPago>("FormaDePago", ref mFormaDePago, value); }
        }

        private string mComprador;
        [Size(300)]
        public string Comprador
        {
            get { return mComprador; }
            set { SetPropertyValue<string>("Comprador", ref mComprador, value); }
        }

        private string mDestino;
        [Size(300)]
        public string Destino
        {
            get { return mDestino; }
            set { SetPropertyValue<string>("Destino", ref mDestino, value); }
        }

        private string mDireccion;
        [Size(350)]
        public string Direccion
        {
            get { return mDireccion; }
            set { SetPropertyValue<string>("Direccion", ref mDireccion, value); }
        }

        private string mTel;
        [Size(35)]
        public string Tel
        {
            get { return mTel; }
            set { SetPropertyValue<string>("Tel", ref mTel, value); }
        }

        private string mCorreoElectronico;
        [Size(100)]
        public string CorreoElectronico
        {
            get { return mCorreoElectronico; }
            set { SetPropertyValue<string>("CorreoElectronico", ref mCorreoElectronico, value); }

        }

        private bool mEsCredito;
        public bool EsCredito
        {
            get { return mEsCredito; }
            set { SetPropertyValue<bool>("EsCredito", ref mEsCredito, value); }
        }
    }
}
