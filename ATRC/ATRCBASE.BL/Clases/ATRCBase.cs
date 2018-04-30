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

        private int mUsuarioBaja;
        public int UsuarioBaja
        {
            get { return mUsuarioBaja; }
            set { SetPropertyValue<int>("UsuarioBaja", ref mUsuarioBaja, value); }
        }

        protected override void EndEdit()
        {
            this.FechaAlta = Utilerias.ObtenerFechaHora();
            Usuario usuario = Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)this.Session);
            if (usuario != null)
                this.UsuarioBaja = usuario.Oid;
            base.EndEdit();
    }

    protected override void OnSaving()
        {
            this.FechaAlta = Utilerias.ObtenerFechaHora();
            Usuario usuario = Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)this.Session);
            if (usuario != null)
                this.UsuarioAlta = usuario.Oid;
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
