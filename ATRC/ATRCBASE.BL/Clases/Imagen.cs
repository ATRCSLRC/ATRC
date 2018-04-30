using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_Imagenes")]
    public class Imagen : ATRCBase
    {
        public Imagen(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mArchivo;
        [Size(SizeAttribute.Unlimited)]
        public string Archivo
        {
            get { return mArchivo; }
            set { SetPropertyValue<string>("Archivo", ref mArchivo, value); }
        }

        private string mNombre;
        [Size(80)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mDescripcion;
        [Size(150)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }
    }
}
