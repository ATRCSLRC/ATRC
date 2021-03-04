using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATRCBASE.BL.Enums;

namespace ATRCBASE.BL
{
    [Persistent("gen_RegistroAccesos")]
    public class RegistroAccesos : ATRCBase
    {
        public RegistroAccesos(Session session) : base(session) { }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private TipoAcceso mTipoAcceso;
        public TipoAcceso TipoAcceso
        {
            get { return mTipoAcceso; }
            set { SetPropertyValue<TipoAcceso>("TipoAcceso", ref mTipoAcceso, value); }
        }

        private int mIDCard;
        public int IDCard
        {
            get { return mIDCard; }
            set { SetPropertyValue<int>("IDCard", ref mIDCard, value); }
        }
    }
}
