using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUARDIAS.BL
{
    [Persistent("Gua_Recibos")]
    public class Recibos : ATRCBase
    {
        public Recibos(Session session) : base(session) { }

        private int mFolio;
        public int Folio
        {
            get { return mFolio; }
            set { SetPropertyValue<int>("Folio", ref mFolio, value); }
        }

        private decimal mPrecio;
        public decimal Precio
        {
            get { return mPrecio; }
            set { SetPropertyValue<decimal>("Precio", ref mPrecio, value); }
        }

        private string mPrecioEscrito;
        public string PrecioEscrito
        {
            get { return mPrecioEscrito; }
            set { SetPropertyValue<string>("PrecioEscrito", ref mPrecioEscrito, value); }
        }

        private string mConcepto;
        [Size(SizeAttribute.Unlimited)]
        public string Concepto
        {
            get { return mConcepto; }
            set { SetPropertyValue<string>("Concepto", ref mConcepto, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private string mEmisor;
        [Size(250)]
        public string Emisor
        {
            get { return mEmisor; }
            set { SetPropertyValue<string>("Emisor", ref mEmisor, value); }
        }

        private string mTipoCambio;
        public string TipoCambio
        {
            get { return mTipoCambio; }
            set { SetPropertyValue<string>("TipoCambio", ref mTipoCambio, value); }
        }

        private bool mCancelado;
        public bool Cancelado
        {
            get { return mCancelado; }
            set { SetPropertyValue<bool>("Cancelado", ref mCancelado, value); }
        }

        private string mMotivoCancelacion;
        [Size(SizeAttribute.Unlimited)]
        public string MotivoCancelacion
        {
            get { return mMotivoCancelacion; }
            set { SetPropertyValue<string>("MotivoCancelacion", ref mMotivoCancelacion, value); }
        }

        static public void GenerarRecibo(UnidadDeTrabajo Unidad, decimal Precio, string Emisor, string Concepto, DateTime Fecha, string TipoCambio, string PrecioEscrito, out int ID)
        {
            Recibos Recibo = new Recibos(Unidad);
            Recibo.Folio = FolioRecibo(Unidad);
            Recibo.Precio = Precio;
            Recibo.Emisor = Emisor;
            Recibo.Concepto = Concepto;
            Recibo.Fecha = Fecha;
            Recibo.TipoCambio = TipoCambio;
            Recibo.PrecioEscrito = PrecioEscrito;
            Recibo.Save();
            Recibo.Session.CommitTransaction();
            ID = Recibo.Oid;
        }

        static public int FolioRecibo(UnidadDeTrabajo Unidad)
        {

            XPView Usuarios = new XPView(Unidad, typeof(Recibos));
            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Folio", SortDirection.Descending, "[Folio]", true, true)});
            Usuarios.SelectDeleted = true;
            if (Usuarios.Count <= 0)
                return 123;
            else
            {
                if (Convert.ToInt32(Usuarios[0]["Folio"]) == 0)
                    return 123;
                return (Convert.ToInt32(Usuarios[0]["Folio"]) + 1);
            }
        }
    }
}
