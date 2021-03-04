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
    [Persistent("rut_RutasDePedido")]
    public class RutasDePedido : ATRCBase
    {
        public RutasDePedido(Session session) : base(session) { }

        private Servicio mServicio;
        public Servicio Servicio
        {
            get { return mServicio; }
            set { SetPropertyValue<Servicio>("Servicio", ref mServicio, value); }
        }

        private DateTime mFechaRuta;
        public DateTime FechaRuta
        {
            get { return mFechaRuta; }
            set { SetPropertyValue<DateTime>("FechaRuta", ref mFechaRuta, value); }
        }

        private TipoRuta mTipoRuta;
        public TipoRuta TipoRuta
        {
            get { return mTipoRuta; }
            set { SetPropertyValue<TipoRuta>("TipoRuta", ref mTipoRuta, value); }
        }

        private Turno mTurno;
        public Turno Turno
        {
            get { return mTurno; }
            set { SetPropertyValue<Turno>("Turno", ref mTurno, value); }
        }

        private Nullable<DateTime> mHoraEntrada;
        public Nullable<DateTime> HoraEntrada
        {
            get { return mHoraEntrada; }
            set { SetPropertyValue<Nullable<DateTime>>("HoraEntrada", ref mHoraEntrada, value); }
        }

        private Nullable<DateTime> mHoraSalida;
        public Nullable<DateTime> HoraSalida
        {
            get { return mHoraSalida; }
            set { SetPropertyValue<Nullable<DateTime>>("HoraSalida", ref mHoraSalida, value); }
        }

        private bool mEsRutaExtra;
        public bool EsRutaExtra
        {
            get { return mEsRutaExtra; }
            set { SetPropertyValue<bool>("EsRutaExtra", ref mEsRutaExtra, value); }
        }

        private bool mPorActualizar;
        public bool PorActualizar
        {
            get { return mPorActualizar; }
            set { SetPropertyValue<bool>("PorActualizar", ref mPorActualizar, value); }
        }

        private bool mRutaCompleta;
        public bool RutaCompleta
        {
            get { return mRutaCompleta; }
            set { SetPropertyValue<bool>("RutaCompleta", ref mRutaCompleta, value); }
        }

        private string mComentarios;
        [Size(SizeAttribute.Unlimited)]
        public string Comentarios
        {
            get { return mComentarios; }
            set { SetPropertyValue<string>("Comentarios", ref mComentarios, value); }
        }

        private string mRuta;
        [Size(SizeAttribute.Unlimited)]
        public string Ruta
        {
            get { return mRuta; }
            set { SetPropertyValue<string>("Ruta", ref mRuta, value); }
        }

        [Association("Historial-RutasDePedido")]
        public XPCollection<HistorialRutasDePedido> Historial
        {
            get
            {
                return GetCollection<HistorialRutasDePedido>(nameof(Historial));
            }
        }

        private PedidoRutas mPedidoRutas;
        [Association("Rutas-PedidoRutas")]
        public PedidoRutas PedidoRutas
        {
            get { return mPedidoRutas; }
            set { SetPropertyValue<PedidoRutas>("PedidoRutas", ref mPedidoRutas, value); }
        }

        private bool mEsApoyo;
        public bool EsApoyo
        {
            get { return mEsApoyo; }
            set { SetPropertyValue<bool>("EsApoyo", ref mEsApoyo, value); }
        }

        private RutasGeneradas mRutaGenerada;
        public RutasGeneradas RutaGenerada
        {
            get { return mRutaGenerada; }
            set { SetPropertyValue<RutasGeneradas>("RutaGenerada", ref mRutaGenerada, value); }
        }

        private Usuario mChoferEntrada;
        public Usuario ChoferEntrada
        {
            get { return mChoferEntrada; }
            set { SetPropertyValue<Usuario>("ChoferEntrada", ref mChoferEntrada, value); }
        }

        private Usuario mChoferSalida;
        public Usuario ChoferSalida
        {
            get { return mChoferSalida; }
            set { SetPropertyValue<Usuario>("ChoferSalida", ref mChoferSalida, value); }
        }

        private bool mPagarChoferEntrada;
        public bool PagarChoferEntrada
        {
            get { return mPagarChoferEntrada; }
            set { SetPropertyValue<bool>("PagarChoferEntrada", ref mPagarChoferEntrada, value); }
        }

        private bool mPagarChoferSalida;
        public bool PagarChoferSalida
        {
            get { return mPagarChoferSalida; }
            set { SetPropertyValue<bool>("PagarChoferSalida", ref mPagarChoferSalida, value); }
        }

        [Delayed]
        public Byte[] Documento
        {
            get { return GetDelayedPropertyValue<Byte[]>("Documento"); }
            set { SetDelayedPropertyValue<Byte[]>("Documento", value); }
        }

        private string mNombreDocumento;
        public string NombreDocumento
        {
            get { return mNombreDocumento; }
            set { SetPropertyValue<string>("NombreDocumento", ref mNombreDocumento, value); }
        }

        private string mComentariosFacturacion;
        [Size(SizeAttribute.Unlimited)]
        public string ComentariosFacturacion
        {
            get { return mComentariosFacturacion; }
            set { SetPropertyValue<string>("ComentariosFacturacion", ref mComentariosFacturacion, value); }
        }

        private bool mCrearHistorial = true;
        [NonPersistent]
        public bool CrearHistorial
        {
            get { return mCrearHistorial; }
            set { SetPropertyValue<bool>("CrearHistorial", ref mCrearHistorial, value); }
        }

        protected override void OnSaving()
        {
            if (this.CrearHistorial)
            {
                if (this.PedidoRutas.Estado == EstadoPedidoRutas.Aprobado)
                    this.PorActualizar = true;
                HistorialRutasDePedido Historial = new HistorialRutasDePedido(this.Session);

                if (this.PedidoRutas.AclaracionActual != null)
                    Historial.Aclaracion = PedidoRutas.AclaracionActual;
                Historial.ComentariosFacturacion = this.ComentariosFacturacion;
                Historial.Comentarios = this.Comentarios;
                Historial.EsRutaExtra = this.EsRutaExtra;
                Historial.FechaRuta = this.FechaRuta;
                Historial.HoraEntrada = this.HoraEntrada;
                Historial.HorarioModificacion = DateTime.Now;
                Historial.HoraSalida = this.HoraSalida;
                Historial.Ruta = this.Ruta;
                Historial.RutaCompleta = this.RutaCompleta;
                Historial.RutasDePedido = this;
                Historial.Servicio = this.Servicio;
                Historial.TipoRuta = this.TipoRuta;
                Historial.Turno = this.Turno;
                Historial.EsApoyo = this.EsApoyo;
                Historial.Documento = this.Documento;
                Historial.EstadoPedido = this.PedidoRutas.Estado;
                Historial.NombreDocumento = this.NombreDocumento;
                Historial.Usuario = ATRCBASE.BL.Utilerias.ObtenerUsuarioActual(this.Session as UnidadDeTrabajo);
                Historial.Save();
                this.Historial.Add(Historial);
                base.OnSaving();
            }
        }

        }
}
