using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATRCBASE.BL
{
    [Persistent("gen_Empresas")]
    public class Empresas : ATRCBase
    {
        public Empresas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mClave;
        [Size(60)]
        public string Clave
        {
            get { return mClave; }
            set { SetPropertyValue<string>("Clave", ref mClave, value); }
        }

        private string mNombre;
        [Size(200)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mNombreOficial;
        [Size(200)]
        public string NombreOficial
        {
            get { return mNombreOficial; }
            set { SetPropertyValue<string>("NombreOficial", ref mNombreOficial, value); }
        }

        private string mRFC;
        [Size(20)]
        public string RFC
        {
            get { return mRFC; }
            set { SetPropertyValue<string>("RFC", ref mRFC, value); }
        }

        private string mDireccion;
        [Size(250)]
        public string Direccion
        {
            get { return mDireccion; }
            set { SetPropertyValue<string>("Direccion", ref mDireccion, value); }
        }

        private string mLocacion;
        [Size(120)]
        public string Locacion
        {
            get { return mLocacion; }
            set { SetPropertyValue<string>("Locacion", ref mLocacion, value); }
        }

        private string mTel;
        [Size(20)]
        public string Tel
        {
            get { return mTel; }
            set { SetPropertyValue<string>("Tel", ref mTel, value); }
        }

        private decimal mIVA;
        public decimal IVA
        {
            get { return mIVA; }
            set { SetPropertyValue<decimal>("IVA", ref mIVA, value); }
        }
    }
}
