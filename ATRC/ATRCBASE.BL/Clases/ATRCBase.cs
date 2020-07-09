using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [NonPersistent]
    public class ATRCBase : XPObject
    {
        public ATRCBase(Session sesion) : base(sesion){}

        private DateTime mFechaAlta;
        public DateTime FechaAlta
        {
            get { return mFechaAlta; }
            set
            {
                SetPropertyValue<DateTime>("FechaAlta", ref mFechaAlta, value);
            }
        }

        private DateTime mFechaModificacion;
        public DateTime FechaModificacion
        {
            get { return mFechaModificacion; }
            set
            {
                SetPropertyValue<DateTime>("FechaModificacion", ref mFechaModificacion, value);
            }
        }

        private DateTime mFechaBaja;
        public DateTime FechaBaja
        {
            get { return mFechaBaja; }
            set { SetPropertyValue<DateTime>("FechaBaja", ref mFechaBaja, value); }
        }

        private int mUsuarioAlta;
        public int UsuarioAlta
        {
            get { return mUsuarioAlta; }
            set
            {
                SetPropertyValue<int>("UsuarioAlta", ref mUsuarioAlta, value);
            }
        }

        private int mUsuarioModificacion;
        public int UsuarioModificacion
        {
            get { return mUsuarioModificacion; }
            set { SetPropertyValue<int>("UsuarioModificacion", ref mUsuarioModificacion, value); }
        }

        private int mUsuarioBaja;
        public int UsuarioBaja
        {
            get { return mUsuarioBaja; }
            set { SetPropertyValue<int>("UsuarioBaja", ref mUsuarioBaja, value); }
        }

        protected override void EndEdit()
        {
            this.FechaModificacion = Utilerias.ObtenerFechaHora();
            Usuario usuario = Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)this.Session);
            if (usuario != null)
                this.UsuarioModificacion = usuario.Oid;
            base.EndEdit();
    }

    protected override void OnSaving()
        {
            
            Usuario usuario = Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)this.Session);
            if (usuario != null)
            {
                if (UsuarioAlta == null || UsuarioAlta <= 0)
                {
                    this.FechaAlta = Utilerias.ObtenerFechaHora();
                    this.UsuarioAlta = usuario.Oid;
                }
                else
                {
                    this.FechaModificacion = Utilerias.ObtenerFechaHora();
                    this.UsuarioModificacion = usuario.Oid;
                }
            }
            base.OnSaving();
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            this.FechaBaja = Utilerias.ObtenerFechaHora();
            Usuario usuario = Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)this.Session);
            if (usuario != null)
                this.UsuarioBaja = usuario.Oid;

        }
    }
}
