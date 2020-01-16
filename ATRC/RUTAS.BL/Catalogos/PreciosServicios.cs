using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_PreciosServicios")]
    public class PreciosServicios : ATRCBase
    {
        public PreciosServicios(Session session) : base(session) { }

        private decimal mPrecio;
        public decimal Precio
        {
            get { return mPrecio; }
            set { SetPropertyValue<decimal>("Precio", ref mPrecio, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        
        private Servicio mServicio;
        [Association("rut_Servicios-Precios")]
        public Servicio Servicio
        {
            get { return mServicio; }
            set { SetPropertyValue<Servicio>("Servicio", ref mServicio, value); }
        }
    }
}
