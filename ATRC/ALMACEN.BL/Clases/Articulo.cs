using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMACEN.BL
{
    [Persistent("al_Articulo")]
    public class Articulo : ATRCBase
    {
        public Articulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mCodigo;
        [Size(80)]
        public string Codigo
        {
            get { return mCodigo; }
            set { SetPropertyValue<string>("Codigo", ref mCodigo, value); }
        }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private Enums.TipoMedida mTipoMedida;
        public Enums.TipoMedida TipoMedida
        {
            get { return mTipoMedida; }
            set { SetPropertyValue<Enums.TipoMedida>("TipoMedida", ref mTipoMedida, value); }
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

        private Enums.TipoArticulo mTipoArticulo;
        public Enums.TipoArticulo TipoArticulo
        {
            get { return mTipoArticulo; }
            set { SetPropertyValue<Enums.TipoArticulo>("TipoArticulo", ref mTipoArticulo, value); }
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

        [Association("al_Articulo-InventarioArticulo")]
        public XPCollection<InventarioArticulo> Inventarios
        {
            get { return GetCollection<InventarioArticulo>("Inventarios"); }
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
    }
}
