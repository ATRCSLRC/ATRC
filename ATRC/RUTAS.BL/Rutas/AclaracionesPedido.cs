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
    [Persistent("rut_AclaracionesPedido")]
    public class AclaracionesPedido : ATRCBase
    {
        public AclaracionesPedido(Session session) : base(session) { }

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

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private PedidoRutas mPedido;
        [Association("PedidoRutas-Aclaraciones")]
        public PedidoRutas Pedido
        {
            get { return mPedido; }
            set { SetPropertyValue<PedidoRutas>("Pedido", ref mPedido, value); }
        }

        [Association("Historial-AclaracionesPedido")]
        public XPCollection<HistorialAclaracionesPedido> Historial
        {
            get
            {
                return GetCollection<HistorialAclaracionesPedido>(nameof(Historial));
            }
        }

        private string mMotivo;
        [NonPersistent]
        public string Motivo
        {
            get { return mMotivo; }
            set { SetPropertyValue<string>("Motivo", ref mMotivo, value); }
        }

        protected override void OnSaving()
        {
            HistorialAclaracionesPedido Historial = new HistorialAclaracionesPedido(this.Session);
            Historial.Descripcion = this.Motivo;
            Historial.Estado = this.Estado;
            //Historial.EnviadoPorMaquiladora = this.EnviadoPorMaquiladora;
            Historial.Save();
            this.Historial.Add(Historial);
            base.OnSaving();
        }
    }
}
