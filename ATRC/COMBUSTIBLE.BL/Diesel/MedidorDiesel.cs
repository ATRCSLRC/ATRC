using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_MedidorDiesel")]
    public class MedidorDiesel : ATRCBase
    {
        public MedidorDiesel(Session session) : base(session) { }

        private Int64 mInicial;
        public Int64 Inicial
        {
            get { return mInicial; }
            set { SetPropertyValue<Int64>("Inicial", ref mInicial, value); }
        }

        private Int64 mFinal;
        public Int64 Final
        {
            get { return mFinal; }
            set { SetPropertyValue<Int64>("Final", ref mFinal, value); }
        }

        private DieselActual mTanque;
        public DieselActual Tanque
        {
            get { return mTanque; }
            set { SetPropertyValue<DieselActual>("Tanque", ref mTanque, value); }
        }

        private Int32 mLitrosEnTanque;
        public Int32 LitrosEnTanque
        {
            get { return mLitrosEnTanque; }
            set { SetPropertyValue<Int32>("LitrosEnTanque", ref mLitrosEnTanque, value); }
        }

        private Int32 mLitrosCapturados;
        public Int32 LitrosCapturados
        {
            get { return mLitrosCapturados; }
            set { SetPropertyValue<Int32>("LitrosCapturados", ref mLitrosCapturados, value); }
        }
    }
}
