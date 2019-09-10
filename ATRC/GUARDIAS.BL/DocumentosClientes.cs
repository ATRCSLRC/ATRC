using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUARDIAS.BL
{
    [Persistent("Gua_DocumentosClientes")]
    public class DocumentosClientes : ATRCBase
    {
        public DocumentosClientes(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mArchivo;
        [Size(SizeAttribute.Unlimited)]
        public string Archivo
        {
            get { return mArchivo; }
            set { SetPropertyValue<string>("Archivo", ref mArchivo, value); }
        }

        private string mNombre;
        [Size(80)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mDescripcion;
        [Size(150)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        private ClientesRenta mCliente;
        [Association("Documentos-Clientes")]
        public ClientesRenta Cliente
        {
            get { return mCliente; }
            set { SetPropertyValue("Cliente", ref mCliente, value); }
        }

        private DateTime mFechaVigencia;
        public DateTime FechaVigencia
        {
            get { return mFechaVigencia; }
            set { SetPropertyValue<DateTime>("FechaVigencia", ref mFechaVigencia, value); }
        }

        [Association("Documentos-Contratos")]
        public XPCollection<ContratoRenta> Contratos
        {
            get
            {
                return GetCollection<ContratoRenta>("Contratos");
            }
        }
    }
}
