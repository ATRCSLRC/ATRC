using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_proveedor")]
    public class Proveedor : ATRCBase
    {
        public Proveedor(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mNombre;
        [Size(200)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mNombreFiscal;
        [Size(200)]
        public string NombreFiscal
        {
            get { return mNombreFiscal; }
            set { SetPropertyValue<string>("NombreFiscal", ref mNombreFiscal, value); }
        }
    }
}
