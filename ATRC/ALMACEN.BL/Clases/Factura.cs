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


        private string mNumFactura;
        [Size(80)]
        public string NumFactura
        {
            get { return mNumFactura; }
            set { SetPropertyValue<string>("NumFactura", ref mNumFactura, value); }
        }

        private string mNumParte;
        [Size(100)]
        public string NumParte
        {
            get { return mNumParte; }
            set { SetPropertyValue<string>("NumParte", ref mNumParte, value); }
        }

        private string mTipo;
        [Size(100)]
        public string Tipo
        {
            get { return mTipo; }
            set { SetPropertyValue<string>("Tipo", ref mTipo, value); }
        }

        private string mSerie;
        [Size(100)]
        public string Serie
        {
            get { return mSerie; }
            set { SetPropertyValue<string>("mSerie", ref mSerie, value); }
        }

        private string mMedida;
        [Size(150)]
        public string Medida
        {
            get { return mMedida; }
            set { SetPropertyValue<string>("Medida", ref mMedida, value); }
        }

        private decimal mPrecio;
        public decimal Precio
        {
            get { return mPrecio; }
            set { SetPropertyValue<decimal>("Precio", ref mPrecio, value); }
        }

        private int mAlmacen;
        public int Almacen
        {
            get { return mAlmacen; }
            set { SetPropertyValue<int>("Almacen", ref mAlmacen, value); }
        }
        
        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Enums.TipoMedida mTipoMedida;
        public Enums.TipoMedida TipoMedida
        {
            get { return mTipoMedida; }
            set { SetPropertyValue<Enums.TipoMedida>("TipoMedida", ref mTipoMedida, value); }
        }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        private Marcas mMarca;
        public Marcas Marca
        {
            get { return mMarca; }
            set { SetPropertyValue<Marcas>("Marca", ref mMarca, value); }
        }

        private Proveedor mProveedor;
        public Proveedor Proveedor
        {
            get { return mProveedor; }
            set { SetPropertyValue<Proveedor>("Proveedor", ref mProveedor, value); }
        }

        private Articulo mArticulo;
        [Association("al_Articulo-Factura")]
        public Articulo Articulo
        {
            get { return mArticulo; }
            set { SetPropertyValue<Articulo>("Articulo", ref mArticulo, value); }
        }

    }
}
