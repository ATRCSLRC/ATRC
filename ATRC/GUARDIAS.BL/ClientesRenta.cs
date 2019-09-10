using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUARDIAS.BL
{
    [Persistent("Gua_Clientes")]
    public class ClientesRenta : ATRCBase
    {
        public ClientesRenta(Session session) : base(session) { }

        private string mNombre;
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mDomicilio;
        public string Domicilio
        {
            get { return mDomicilio; }
            set { SetPropertyValue<string>("Domicilio", ref mDomicilio, value); }
        }

        private string mCP;
        public string CP
        {
            get { return mCP; }
            set { SetPropertyValue<string>("CP", ref mCP, value); }
        }

        private string mCiudad;
        public string Ciudad
        {
            get { return mCiudad; }
            set { SetPropertyValue<string>("Ciudad", ref mCiudad, value); }
        }

        private string mColonia;
        public string Colonia
        {
            get { return mColonia; }
            set { SetPropertyValue<string>("Colonia", ref mColonia, value); }
        }

        private string mEstado;
        public string Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<string>("Estado", ref mEstado, value); }
        }

        private string mTel;
        public string Tel
        {
            get { return mTel; }
            set { SetPropertyValue<string>("Tel", ref mTel, value); }
        }

        private string mNombreReferencia;
        public string NombreReferencia
        {
            get { return mNombreReferencia; }
            set { SetPropertyValue<string>("NombreReferencia", ref mNombreReferencia, value); }
        }

        private string mDomicilioReferencia;
        public string DomicilioReferencia
        {
            get { return mDomicilioReferencia; }
            set { SetPropertyValue<string>("DomicilioReferencia", ref mDomicilioReferencia, value); }
        }

        private string mTelReferencia;
        public string TelReferencia
        {
            get { return mTelReferencia; }
            set { SetPropertyValue<string>("TelReferencia", ref mTelReferencia, value); }
        }

        [Association("Documentos-Clientes")]
        public XPCollection<DocumentosClientes> Documentos
        {
            get
            {
                return GetCollection<DocumentosClientes>("Documentos");
            }
        }
    }
}
