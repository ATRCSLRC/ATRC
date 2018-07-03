using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIDADES.BL;

namespace LLANTERA.BL
{
    [Persistent("Llan_BitacoraLlantasParchadas")]
    public class BitacoraLlantasParchadas : ATRCBase
    {
        public BitacoraLlantasParchadas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private string mPosicionDeLlanta;
        public string PosicionDeLlanta
        {
            get { return mPosicionDeLlanta; }
            set { SetPropertyValue<string>("PosicionDeLlanta", ref mPosicionDeLlanta, value); }
        }

        private string mDescripcion;
        [Size(SizeAttribute.Unlimited)]
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("FacturaLlantaAnterior", ref mDescripcion, value); }
        }

        static public void CrearRegistro(UnidadDeTrabajo UnidadTrabajo, Unidad Unidad, string PosicionLlanta, string Descripcion)
        {
            BitacoraLlantasParchadas LlantaParchada = new BitacoraLlantasParchadas(UnidadTrabajo);
            LlantaParchada.Unidad = Unidad;
            LlantaParchada.PosicionDeLlanta = PosicionLlanta;
            LlantaParchada.Descripcion = Descripcion;
            LlantaParchada.Save();
        }
    }
}
