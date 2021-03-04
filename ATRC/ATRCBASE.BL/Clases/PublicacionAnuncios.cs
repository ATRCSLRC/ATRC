using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_PublicacionAnuncios"), DeferredDeletion(false)]
    public class PublicacionAnuncios : ATRCBase
    {
        public PublicacionAnuncios(Session session) : base(session) { }

        private string mFechaPublicacion;
        public string FechaPublicacion
        {
            get { return mFechaPublicacion; }
            set { SetPropertyValue<string>("FechaPublicacion", ref mFechaPublicacion, value); }
        }

        [Association("Publicacion-Anuncio"), Aggregated]
        public XPCollection<AnuncioUsuario> Anuncios
        {
            get
            {
                return GetCollection<AnuncioUsuario>(nameof(Anuncios));
            }
        }
    }
}
