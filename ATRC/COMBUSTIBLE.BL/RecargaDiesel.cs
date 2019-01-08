using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_RecargaDiesel")]
    public class RecargaDiesel : ATRCBase
    {
        public RecargaDiesel(Session session) : base(session) { }

        private DieselActual mTanque;
        public DieselActual Tanque
        {
            get { return mTanque; }
            set { SetPropertyValue<DieselActual>("Tanque", ref mTanque, value); }
        }

        private double mPrecioLitro;
        public double PrecioLitro
        {
            get { return mPrecioLitro; }
            set { SetPropertyValue<double>("PrecioLitro", ref mPrecioLitro, value); }
        }

        private Int64 mCantidad;
        public Int64 Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<Int64>("Cantidad", ref mCantidad, value); }
        }
    }
}
