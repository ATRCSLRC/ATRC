using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_PlantillaRutas")]
    public class PlantillaRutas : ATRCBase
    {
        public PlantillaRutas(Session session) : base(session) { }

        private string mNombre;
        [Size(SizeAttribute.Unlimited)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private bool mEsExterno;
        [Description("Plantilla se muestra a externos.")]
        public bool EsExterno
        {
            get { return mEsExterno; }
            set { SetPropertyValue<bool>("EsExterno", ref mEsExterno, value); }
        }

        [Association("rut_PlantillaRutas-PlantillaRutaFija")]
        public XPCollection<PlantillaRutaFija> PlantillasRutasFijas
        {
            get
            {
                return GetCollection<PlantillaRutaFija>(nameof(PlantillasRutasFijas));
            }
        }
    }
}
