using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATRCBASE.BL
{
    [Persistent("gen_Modulos")]
    public class Modulos : ATRCBase
    {
        public Modulos(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mModulo;
        [Size(300)]
        public string Modulo
        {
            get { return mModulo; }
            set { SetPropertyValue<string>("Modulo", ref mModulo, value); }
        }

        [Association("gen_Modulos-Usuario")]
        public XPCollection<Usuario> Usuarios
        {
            get { return GetCollection<Usuario>("Usuarios"); }
        }
    }
}
