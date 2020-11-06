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
    [Persistent("rut_HistorialPedidoRutas")]
    public class HistorialPedidoRutas : ATRCBase
    {
        public HistorialPedidoRutas(Session session) : base(session) { }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private EstadoPedidoRutas mEstado;
        public EstadoPedidoRutas Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<EstadoPedidoRutas>("Estado", ref mEstado, value); }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private string mDetalle;
        [Size(SizeAttribute.Unlimited)]
        public string Detalle
        {
            get { return mDetalle; }
            set { SetPropertyValue<string>("Detalle", ref mDetalle, value); }
        }

        private DateTime mHorarioModificacion;
        public DateTime HorarioModificacion
        {
            get { return mHorarioModificacion; }
            set { SetPropertyValue<DateTime>("HorarioModificacion", ref mHorarioModificacion, value); }
        }

        private PedidoRutas mPedidoRutas;
        [Association("Historial-PedidoRutas")]
        public PedidoRutas PedidoRutas
        {
            get { return mPedidoRutas; }
            set { SetPropertyValue<PedidoRutas>("PedidoRutas", ref mPedidoRutas, value); }
        }
    }
}
