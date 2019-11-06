using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_DieselActual")]
    public class DieselActual : ATRCBase
    {
        public DieselActual(Session session) : base(session) { }

        private string mDescripcion;
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        private int mCapacidad;
        public int Capacidad
        {
            get { return mCapacidad; }
            set { SetPropertyValue<int>("Capacidad", ref mCapacidad, value); }
        }

        private decimal mCantidad;
        public decimal Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<decimal>("Cantidad", ref mCantidad, value); }
        }

        private Enums.Combustible mTipoCombustible;
        public Enums.Combustible TipoCombustible
        {
            get { return mTipoCombustible; }
            set { SetPropertyValue<Enums.Combustible>("TipoCombustible", ref mTipoCombustible, value); }
        }
    }
}
