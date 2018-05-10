using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_PrestamoArticulo")]
    public class PrestamoArticulo : ATRCBase
    {
        public PrestamoArticulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        [Association("al_Prestamo-Detalle")]
        public XPCollection<DetallePrestamo> Detalles
        {
            get { return GetCollection<DetallePrestamo>("Detalles"); }
        }
    }
}
