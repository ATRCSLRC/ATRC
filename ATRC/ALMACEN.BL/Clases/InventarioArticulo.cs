using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_InventarioArticulo")]
    public class InventarioArticulo : ATRCBase
    {
        public InventarioArticulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [Association("al_Articulo-InventarioArticulo")]
        public XPCollection<Articulo> Articulos
        {
            get { return GetCollection<Articulo>("Articulos"); }
        }
    }
}
