using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATRCBASE.BL.Enums;

namespace RUTAS.BL
{
    [Persistent("rut_HistorialAclaracionesPedido")]
    public class HistorialAclaracionesPedido : ATRCBase
    {
        public HistorialAclaracionesPedido(Session session) : base(session) { }

        private string mDescripcion;
        [Size(SizeAttribute.Unlimited)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        private EstadoAclaraciones mEstado;
        public EstadoAclaraciones Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<EstadoAclaraciones>("Estado", ref mEstado, value); }
        }

        //private bool mEnviadoPorMaquiladora;
        //public bool EnviadoPorMaquiladora
        //{
        //    get { return mEnviadoPorMaquiladora; }
        //    set { SetPropertyValue<bool>("EnviadoPorMaquiladora", ref mEnviadoPorMaquiladora, value); }
        //}

        private AclaracionesPedido mAclaracionPedido;
        [Association("Historial-AclaracionesPedido")]
        public AclaracionesPedido AclaracionPedido
        {
            get { return mAclaracionPedido; }
            set { SetPropertyValue<AclaracionesPedido>("AclaracionPedido", ref mAclaracionPedido, value); }
        }
    }
}
