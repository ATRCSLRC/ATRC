using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATRCBASE.BL
{
    [Persistent("gen_Permiso")]
    public class Permiso : ATRCBase
    {
        public Permiso(Session session) : base(session) { }

        private string mNombre; 
        [Size(100)]
        public string Nombre
        {
            get { return this.mNombre; }
            set { SetPropertyValue<string>("Nombre", ref this.mNombre, value); }
        }

        private string mLlave;
        [Size(100)]
        public string Llave
        {
            get { return this.mLlave; }
            set { SetPropertyValue<string>("Llave", ref this.mLlave, value); }
        }

        private Permiso mPermisoPadre;
        public Permiso PermisoPadre
        {
            get { return this.mPermisoPadre; }
            set { SetPropertyValue<Permiso>("PermisoPadre", ref this.mPermisoPadre, value); }
        }


        [Association("Usuarios-Permisos", UseAssociationNameAsIntermediateTableName = true)]
        public XPCollection<Usuario> Usuarios { get { return GetCollection<Usuario>("Usuarios"); } }
    }
}
