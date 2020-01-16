using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
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

        [Association("rut_PlantillaRutas-PlantillaRutaExtra")]
        public XPCollection<PlantillaRutaFija> PlantillasRutasFijas
        {
            get
            {
                XPCollection<PlantillaRutaFija> PlantillasRutasExtras = GetCollection<PlantillaRutaFija>("PlantillasRutasFijas");
                PlantillasRutasExtras.DisplayableProperties = "Oid;TipoRuta;TipoUnidad;HoraEntrada;HoraSalida;ChoferEntrada;ChoferSalida;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios";
                return PlantillasRutasFijas;
            }
        }
    }
}
