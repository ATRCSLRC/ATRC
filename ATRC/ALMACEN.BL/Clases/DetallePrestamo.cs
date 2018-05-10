using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_DetallePrestamo")]
    public class DetallePrestamo : ATRCBase
    {
        public DetallePrestamo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        private Articulo mArticulo;
        public Articulo Articulo
        {
            get { return mArticulo; }
            set { SetPropertyValue<Articulo>("Articulo", ref mArticulo, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private bool mEntregado;
        public bool Entregado
        {
            get { return mEntregado; }
            set { SetPropertyValue<bool>("Entregado", ref mEntregado, value); }
        }

        private DateTime mFechaEntrega;
        public DateTime FechaEntrega
        {
            get { return mFechaEntrega; }
            set { SetPropertyValue<DateTime>("FechaEntrega", ref mFechaEntrega, value); }
        }

        private PrestamoArticulo mPrestamo;
        [Association("al_Prestamo-Detalle")]
        public PrestamoArticulo Prestamo
        {
            get { return mPrestamo; }
            set { SetPropertyValue<PrestamoArticulo>("Prestamo", ref mPrestamo, value); }
        }
    }
}
