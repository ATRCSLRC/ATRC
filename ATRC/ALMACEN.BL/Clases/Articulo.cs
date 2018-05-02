using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMACEN.BL
{
    [Persistent("Al_Articulo")]
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

        private string mTipoUnidad;
        [Size(100)]
        public string TipoUnidad
        {
            get { return mTipoUnidad; }
            set { SetPropertyValue<string>("TipoUnidad", ref mTipoUnidad, value); }
        }

        private string mNumParte;
        [Size(100)]
        public string NumParte
        {
            get { return mNumParte; }
            set { SetPropertyValue<string>("NumParte", ref mNumParte, value); }
        }

        private string mTipoArticulo;
        [Size(100)]
        public string TipoArticulo
        {
            get { return mTipoArticulo; }
            set { SetPropertyValue<string>("TipoArticulo", ref mTipoArticulo, value); }
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

        private Enums.TipoArticulo mTipo;
        public Enums.TipoArticulo Tipo
        {
            get { return mTipo; }
            set { SetPropertyValue<Enums.TipoArticulo>("Tipo", ref mTipo, value); }
        }

        [Association("Al_Articulo-Factura")]
        public XPCollection<Factura> Facturas
        {
            get { return GetCollection<Factura>("Facturas"); }
        }

        [Association("Al_Articulo-InventarioArticulo")]
        public XPCollection<InventarioArticulo> Inventarios
        {
            get { return GetCollection<InventarioArticulo>("Inventarios"); }
        }

        private Medidas mUnidaMedida;
        public Medidas UnidadMedida
        {
            get { return mUnidaMedida; }
            set { SetPropertyValue<Medidas>("UnidadMedida", ref mUnidaMedida, value); }
        }

        private Marcas mMarca;
        public Marcas Marca
        {
            get { return mMarca; }
            set { SetPropertyValue<Marcas>("Marca", ref mMarca, value); }
        }
    }
}
