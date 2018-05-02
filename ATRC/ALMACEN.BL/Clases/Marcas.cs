using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("Al_Marcas")]
    public class Marcas : ATRCBase
    {
        public Marcas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mNombre;
        [Size(200)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }
    }
}
