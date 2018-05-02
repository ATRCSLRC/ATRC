using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_Medidas")]
    public class Medidas : ATRCBase
    {
        public Medidas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mDescripcion;
        [Size(200)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }
    }
}
