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

        private Enums.TipoArticulo mTipoArticulo;
        public Enums.TipoArticulo TipoArticulo
        {
            get { return mTipoArticulo; }
            set { SetPropertyValue<Enums.TipoArticulo>("TipoArticulo", ref mTipoArticulo, value); }
        }

        [Association("al_Articulo-InventarioArticulo")]
        public XPCollection<InventarioArticulo> Inventarios
        {
            get { return GetCollection<InventarioArticulo>("Inventarios"); }
        }

        [Association("al_Articulo-Factura")]
        public XPCollection<Factura> Facturas
        {
            get { return GetCollection<Factura>("Facturas"); }
        }

    }
}
