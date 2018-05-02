using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_PrestamoArticulo")]
    public class PrestamoArticulo : ATRCBase
    {
        public PrestamoArticulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private Articulo mArticulo;
        public Articulo Articulo
        {
            get { return mArticulo; }
            set { SetPropertyValue<Articulo>("Articulo", ref mArticulo, value); }
        }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        private DateTime mFechaPrestamo;
        public DateTime FechaPrestamo
        {
            get { return mFechaPrestamo; }
            set { SetPropertyValue<DateTime>("FechaPrestamo", ref mFechaPrestamo, value); }
        }

        private DateTime mFechaEntrega;
        public DateTime FechaEntrega
        {
            get { return mFechaEntrega; }
            set { SetPropertyValue<DateTime>("FechaEntrega", ref mFechaEntrega, value); }
        }

        private bool mEntregado;
        public bool Entregado
        {
            get { return mEntregado; }
            set { SetPropertyValue<bool>("Entregado", ref mEntregado, value); }
        }
    }
}
