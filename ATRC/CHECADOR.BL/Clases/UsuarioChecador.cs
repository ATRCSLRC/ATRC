using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECADOR.BL
{
    [Persistent("ch_UsuarioChecador")]
    public class UsuarioChecador : ATRCBase
    {
        public UsuarioChecador(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [Association("Usuario-HistoricoChecadas")]
        public XPCollection<HistoricoChecadas> HistoricoChecadas
        {
            get
            {
                return GetCollection<HistoricoChecadas>("HistoricoChecadas");
            }
        }

        [Association("Usuario-Notificaciones")]
        public XPCollection<Notificaciones> Notificaciones
        {
            get
            {
                return GetCollection<Notificaciones>("Notificaciones");
            }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }
    }
}
