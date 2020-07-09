using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    public class ActivacionUsuario : ATRCBase
    {
        public ActivacionUsuario(Session session) : base(session) { }

        private DateTime mVencimiento;
        public DateTime Vencimiento
        {
            get { return mVencimiento; }
            set
            {
                SetPropertyValue<DateTime>("Vencimiento", ref mVencimiento, value);
            }
        }

        private DateTime mActivacion;
        public DateTime Activacion
        {
            get { return mActivacion; }
            set
            {
                SetPropertyValue<DateTime>("Activacion", ref mActivacion, value);
            }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set
            {
                SetPropertyValue<Usuario>("Usuario", ref mUsuario, value);
            }
        }
    }
}
