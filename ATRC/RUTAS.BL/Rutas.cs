using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_Rutas")]
    public class Rutas : ATRCBase
    {
        public Rutas(Session session) : base(session) { }

        private string mNombre;
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mColorRuta;
        public string ColorRuta
        {
            get { return mColorRuta; }
            set { SetPropertyValue<string>("ColorRuta", ref mColorRuta, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        [Association("Rutas-Coordenadas")]
        public XPCollection<Coordenadas> Coordenadas
        {
            get
            {
                return GetCollection<Coordenadas>("Coordenadas");
            }
        }
    }
}
