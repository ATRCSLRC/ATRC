using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_Factura")]
    public class Factura : ATRCBase
    {
        public Factura(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private decimal mPrecio;
        public decimal Precio
        {
            get { return mPrecio; }
            set { SetPropertyValue<decimal>("Precio", ref mPrecio, value); }
        }

        private Proveedor mProveedor;
        public Proveedor Proveedor
        {
            get { return mProveedor; }
            set { SetPropertyValue<Proveedor>("Proveedor", ref mProveedor, value); }
        }

        private int mAlmacen;
        public int Almacen
        {
            get { return mAlmacen; }
            set { SetPropertyValue<int>("Almacen", ref mAlmacen, value); }
        }

        private string mNumFactura;
        [Size(80)]
        public string NumFactura
        {
            get { return mNumFactura; }
            set { SetPropertyValue<string>("NumFactura", ref mNumFactura, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        [Association("al_Articulo-Factura")]
        public XPCollection<Articulo> Articulos
        {
            get { return GetCollection<Articulo>("Articulos"); }
        }
    }
}
