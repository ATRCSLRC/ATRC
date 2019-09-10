using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;

namespace GUARDIAS.BL
{
    [Persistent("Gua_ContratosClientes")]
    public class ContratoRenta : ATRCBase
    {
        public ContratoRenta(Session session) : base(session) { }

        private string mResponsable;
        public string Responsable
        {
            get { return mResponsable; }
            set { SetPropertyValue<string>("Responsable", ref mResponsable, value); }
        }

        private string mDomicilio;
        public string Domicilio
        {
            get { return mDomicilio; }
            set { SetPropertyValue<string>("Domicilio", ref mDomicilio, value); }
        }

        private string mCP;
        public string CP
        {
            get { return mCP; }
            set { SetPropertyValue<string>("CP", ref mCP, value); }
        }

        private string mCiudad;
        public string Ciudad
        {
            get { return mCiudad; }
            set { SetPropertyValue<string>("Ciudad", ref mCiudad, value); }
        }

        private string mColonia;
        public string Colonia
        {
            get { return mColonia; }
            set { SetPropertyValue<string>("Colonia", ref mColonia, value); }
        }

        private string mEstado;
        public string Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<string>("Estado", ref mEstado, value); }
        }

        private string mTel;
        public string Tel
        {
            get { return mTel; }
            set { SetPropertyValue<string>("Tel", ref mTel, value); }
        }

        private string mADondeSeDirige;
        public string ADondeSeDirige
        {
            get { return mADondeSeDirige; }
            set { SetPropertyValue<string>("ADondeSeDirige", ref mADondeSeDirige, value); }
        }

        private string mLugarOrigenLugarDestino;
        public string LugarOrigenLugarDestino
        {
            get { return mLugarOrigenLugarDestino; }
            set { SetPropertyValue<string>("LugarOrigenLugarDestino", ref mLugarOrigenLugarDestino, value); }
        }

        private TimeSpan mHoraSalida;
        public TimeSpan HoraSalida
        {
            get { return mHoraSalida; }
            set { SetPropertyValue<TimeSpan>("HoraSalida", ref mHoraSalida, value); }
        }

        private TimeSpan mHoraSalidaOriginal;
        public TimeSpan HoraSalidaOriginal
        {
            get { return mHoraSalidaOriginal; }
            set { SetPropertyValue<TimeSpan>("HoraSalidaOriginal", ref mHoraSalidaOriginal, value); }
        }

        private DateTime mDiaSalida;
        public DateTime DiaSalida
        {
            get { return mDiaSalida; }
            set { SetPropertyValue<DateTime>("DiaSalida", ref mDiaSalida, value); }
        }

        private DateTime mDiaSalidaOriginal;
        public DateTime DiaSalidaOriginal
        {
            get { return mDiaSalidaOriginal; }
            set { SetPropertyValue<DateTime>("DiaSalidaOriginal", ref mDiaSalidaOriginal, value); }
        }

        private TimeSpan mHoraRegreso;
        public TimeSpan HoraRegreso
        {
            get { return mHoraRegreso; }
            set { SetPropertyValue<TimeSpan>("HoraRegreso", ref mHoraRegreso, value); }
        }

        private TimeSpan mHoraRegresoOriginal;
        public TimeSpan HoraRegresoOriginal
        {
            get { return mHoraRegresoOriginal; }
            set { SetPropertyValue<TimeSpan>("HoraRegresoOriginal", ref mHoraRegresoOriginal, value); }
        }

        private DateTime mDiaRegreso;
        public DateTime DiaRegreso
        {
            get { return mDiaRegreso; }
            set { SetPropertyValue<DateTime>("DiaRegreso", ref mDiaRegreso, value); }
        }

        private DateTime mDiaRegresoOriginal;
        public DateTime DiaRegresoOriginal
        {
            get { return mDiaRegresoOriginal; }
            set { SetPropertyValue<DateTime>("DiaRegresoOriginal", ref mDiaRegresoOriginal, value); }
        }

        private decimal mCosto;
        public decimal Costo
        {
            get { return mCosto; }
            set { SetPropertyValue<decimal>("Costo", ref mCosto, value); }
        }

        private decimal mIva;
        public decimal Iva
        {
            get { return mIva; }
            set { SetPropertyValue<decimal>("Iva", ref mIva, value); }
        }

        private decimal mSubtotal;
        public decimal Subtotal
        {
            get { return mSubtotal; }
            set { SetPropertyValue<decimal>("Subtotal", ref mSubtotal, value); }
        }

        private decimal mTotal;
        public decimal Total
        {
            get { return mTotal; }
            set { SetPropertyValue<decimal>("Total", ref mTotal, value); }
        }

        private decimal mAnticipo;
        public decimal Anticipo
        {
            get { return mAnticipo; }
            set { SetPropertyValue<decimal>("Anticipo", ref mAnticipo, value); }
        }

        private decimal mAbono;
        public decimal Abono
        {
            get { return mAbono; }
            set { SetPropertyValue<decimal>("Abono", ref mAbono, value); }
        }

        private string mComentarios;
        public string Comentarios
        {
            get { return mComentarios; }
            set { SetPropertyValue<string>("Comentarios", ref mComentarios, value); }
        }

        private int mTiempoTolerancia;
        public int TiempoTolerancia
        {
            get { return mTiempoTolerancia; }
            set { SetPropertyValue<int>("TiempoTolerancia", ref mTiempoTolerancia, value); }
        }

        private decimal mCostoTolerancia;
        public decimal CostoTolerancia
        {
            get { return mCostoTolerancia; }
            set { SetPropertyValue<decimal>("CostoTolerancia", ref mCostoTolerancia, value); }
        }

        private decimal mDescuento;
        public decimal Descuento
        {
            get { return mDescuento; }
            set { SetPropertyValue<decimal>("Descuento", ref mDescuento, value); }
        }

        private decimal mCantidadDevuelta;
        public decimal CantidadDevuelta
        {
            get { return mCantidadDevuelta; }
            set { SetPropertyValue<decimal>("CantidadDevuelta", ref mCantidadDevuelta, value); }
        }

        private decimal mDiasRenta;
        public decimal DiasRenta
        {
            get { return mDiasRenta; }
            set { SetPropertyValue<decimal>("DiasRenta", ref mDiasRenta, value); }
        }

        private int mNumContrato;
        public int NumContrato
        {
            get { return mNumContrato; }
            set { SetPropertyValue<int>("NumContrato", ref mNumContrato, value); }
        }

        private decimal mRecargos;
        public decimal Recargos
        {
            get { return mRecargos; }
            set { SetPropertyValue<decimal>("Recargos", ref mRecargos, value); }
        }

        private bool mCancelado;
        public bool Cancelado
        {
            get { return mCancelado; }
            set { SetPropertyValue<bool>("Cancelado", ref mCancelado, value); }
        }

        private bool mEsApartado;
        public bool EsApartado
        {
            get { return mEsApartado; }
            set { SetPropertyValue<bool>("EsApartado", ref mEsApartado, value); }
        }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private ClientesRenta mCliente;
        public ClientesRenta Cliente
        {
            get { return mCliente; }
            set { SetPropertyValue<ClientesRenta>("Cliente", ref mCliente, value); }
        }

        private EstadoContrato mEstadoContrato;
        public EstadoContrato EstadoContrato
        {
            get { return mEstadoContrato; }
            set { SetPropertyValue<EstadoContrato>("EstadoContrato", ref mEstadoContrato, value); }
        }

        [Association("Documentos-Contratos")]
        public XPCollection<DocumentosClientes> Documentos
        {
            get
            {
                return GetCollection<DocumentosClientes>("Documentos");
            }
        }
    }
}
