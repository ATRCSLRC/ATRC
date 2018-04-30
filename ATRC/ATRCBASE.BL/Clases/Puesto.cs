using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_Puesto")]
    public class Puesto : ATRCBase
    {
        public Puesto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mDescripcion;
        [Size(150)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }
    }
}
