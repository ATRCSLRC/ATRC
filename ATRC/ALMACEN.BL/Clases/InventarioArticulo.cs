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

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        [Association("al_Articulo-InventarioArticulo")]
        public XPCollection<Articulo> Articulos
        {
            get { return GetCollection<Articulo>("Articulos"); }
        }
    }
}
