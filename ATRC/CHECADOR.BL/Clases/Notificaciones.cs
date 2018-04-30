using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECADOR.BL
{
    [Persistent("ch_Notificaciones")]
    public class Notificaciones : ATRCBase
    {
        public Notificaciones(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private UsuarioChecador mResponsable;
        public UsuarioChecador Responsable
        {
            get { return mResponsable; }
            set { SetPropertyValue<UsuarioChecador>("Responsable", ref mResponsable, value); }
        }

        private UsuarioChecador mReceptor;
        [Association("Usuario-Notificaciones")]
        public UsuarioChecador Receptor
        {
            get { return mReceptor; }
            set { SetPropertyValue<UsuarioChecador>("Receptor", ref mReceptor, value); }
        }

        private string mMotivo;
        [Size(500)]
        public string Motivo
        {
            get { return mMotivo; }
            set { SetPropertyValue<string>("Motivo", ref mMotivo, value); }
        }
    }
}
