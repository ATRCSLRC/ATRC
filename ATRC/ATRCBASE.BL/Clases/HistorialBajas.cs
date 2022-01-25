using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_HistorialBajas")]
    public class HistorialBajas : ATRCBase
    {
        public HistorialBajas(Session session) : base(session) { }

        private Usuario mUsuario;
        [Association("Usuario-Bajas")]
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue(nameof(Usuario), ref mUsuario, value); }
        }

        private string mComentarios;
        [Size(SizeAttribute.Unlimited)]
        public string Comentarios
        {
            get { return mComentarios; }
            set { SetPropertyValue<string>("Comentarios", ref mComentarios, value); }
        }
    } 
}
