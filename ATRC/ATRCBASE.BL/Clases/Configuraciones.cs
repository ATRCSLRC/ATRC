using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATRCBASE.BL
{
    [Persistent("gen_Configuraciones")]
    public class Configuraciones : ATRCBase
    {
        public Configuraciones(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mPropiedad;
        [Size(60)]
        public string Propiedad
        {
            get { return mPropiedad; }
            set { SetPropertyValue<string>("Propiedad", ref mPropiedad, value); }
        }

        private string mAccion;
        [Size(100)]
        public string Accion
        {
            get { return mAccion; }
            set { SetPropertyValue<string>("Accion", ref mAccion, value); }
        }
    }
}
