using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL.Clases
{
    [Persistent("gen_PlantillaDeCorreo")]
    public class PlantillaDeCorreo : ATRCBase
    {
        public PlantillaDeCorreo(Session session) : base(session) { }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mAsunto;
        [Size(300)]
        public string Asunto
        {
            get { return mAsunto; }
            set { SetPropertyValue<string>("Asunto", ref mAsunto, value); }
        }

        private string mContenido;
        [Size(SizeAttribute.Unlimited)]
        public string Contenido
        {
            get { return mContenido; }
            set { SetPropertyValue<string>("Contenido", ref mContenido, value); }
        }

        
    }
}
