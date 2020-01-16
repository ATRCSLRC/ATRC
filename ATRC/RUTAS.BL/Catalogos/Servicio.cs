using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace RUTAS.BL
{
    [Persistent("rut_Servicio")]
    public class Servicio : ATRCBase
    {
        public Servicio(Session session) : base(session) { }

        private string mDescripcion;
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        [Association("rut_Servicios-Precios")]
        public XPCollection<PreciosServicios> Precios
        {
            get
            {
                return GetCollection<PreciosServicios>(nameof(Precios));
            }
        }

        private TipoUnidad mTipoUnidad;
        public TipoUnidad TipoUnidad
        {
            get { return mTipoUnidad; }
            set { SetPropertyValue<TipoUnidad>("TipoUnidad", ref mTipoUnidad, value); }
        }
    }
}
