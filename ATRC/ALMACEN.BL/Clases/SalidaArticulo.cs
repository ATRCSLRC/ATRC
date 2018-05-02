using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_SalidaArticulo")]
    public class SalidaArticulo : ATRCBase
    {
        public SalidaArticulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Articulo mArticulo;
        public Articulo Articulo
        {
            get { return mArticulo; }
            set { SetPropertyValue<Articulo>("Articulo", ref mArticulo, value); }
        }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }
    }
}
