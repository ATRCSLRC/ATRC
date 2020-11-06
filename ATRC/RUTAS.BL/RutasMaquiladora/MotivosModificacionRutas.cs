using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUTAS.BL
{
    [Persistent("rut_MotivosModificacionRutas")]
    public class MotivosModificacionRutas : ATRCBase
    {
        public MotivosModificacionRutas(Session session) : base(session) { }

        private string mDescripcion;
        [Size(SizeAttribute.Unlimited)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        private RutasGeneradas mRutaGenerada;
        [Association("Modificaciones-RutasGeneradas")]
        public RutasGeneradas RutaGenerada
        {
            get { return mRutaGenerada; }
            set { SetPropertyValue<RutasGeneradas>("RutaGenerada", ref mRutaGenerada, value); }
        }
    }
}
