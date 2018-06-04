using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad.BL
{
    [Persistent("gen_Usuario")]
    public class Usuario : ATRCBase
    {
        public Usuario(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mNombreUsuario;
        [Size(300)]
        public string NombreUsuario
        {
            get { return mNombreUsuario; }
            set { SetPropertyValue<string>("NombreUsuario", ref mNombreUsuario, value); }
        }

        private string mContraseña;
        [Size(500)]
        public string Constraseña
        {
            get
            { return mContraseña; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    if(value.Length < 10)
                        value = Utilerias.EncriptarString(value);

                SetPropertyValue<string>("Constraseña", ref mContraseña, value);
            }
        }

        [NonPersistent]
        public string ConstraseñaDesencriptada
        {
            get
            {
                string contraseña = this.Constraseña;
                if (!string.IsNullOrEmpty(contraseña))
                    return Utilerias.DesencriptarString(contraseña);
                return contraseña;
            }

        }
    }
}
