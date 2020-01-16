using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_RecargaDiesel")]
    public class RecargaDiesel : ATRCBase
    {
        public RecargaDiesel(Session session) : base(session) { }

        private DieselActual mTanque;
        public DieselActual Tanque
        {
            get { return mTanque; }
            set { SetPropertyValue<DieselActual>("Tanque", ref mTanque, value); }
        }

        private double mPrecioLitro;
        public double PrecioLitro
        {
            get { return mPrecioLitro; }
            set { SetPropertyValue<double>("PrecioLitro", ref mPrecioLitro, value); }
        }

        private decimal mCantidad;
        public decimal Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<decimal>("Cantidad", ref mCantidad, value); }
        }

        private string mFactura;
        public string Factura
        {
            get { return mFactura; }
            set { SetPropertyValue<string>("Factura", ref mFactura, value); }
        }

        private string mProveedor;
        public string Proveedor
        {
            get { return mProveedor; }
            set { SetPropertyValue<string>("Proveedor", ref mProveedor, value); }
        }

        private string mLectura;
        public string Lectura
        {
            get { return mLectura; }
            set { SetPropertyValue<string>("Lectura", ref mLectura, value); }
        }
    }
}
