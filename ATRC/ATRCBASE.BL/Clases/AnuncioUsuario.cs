using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATRCBASE.BL
{
    [Persistent("gen_AnuncioUsuario")]
    public class AnuncioUsuario : ATRCBase
    {
        public AnuncioUsuario(Session session) : base(session) { }

        private string mNombre;
        [Size(150)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mTipoAnuncio;
        [Size(350)]
        public string TipoAnuncio
        {
            get { return mTipoAnuncio; }
            set { SetPropertyValue<string>("TipoAnuncio", ref mTipoAnuncio, value); }
        }

        [Delayed]
        public Byte[] Documento
        {
            get { return GetDelayedPropertyValue<Byte[]>("Documento"); }
            set { SetDelayedPropertyValue<Byte[]>("Documento", value); }
        }

        [Delayed]
        public Byte[] Anuncio
        {
            get { return GetDelayedPropertyValue<Byte[]>("Anuncio"); }
            set { SetDelayedPropertyValue<Byte[]>("Anuncio", value); }
        }
    }
}
