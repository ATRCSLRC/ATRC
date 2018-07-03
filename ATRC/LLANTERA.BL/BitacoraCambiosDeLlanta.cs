using ALMACEN.BL;
using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIDADES.BL;

namespace LLANTERA.BL
{
    [Persistent("Llan_BitacoraCambiosDeLlanta")]
    public class BitacoraCambiosDeLlanta : ATRCBase
    {
        public BitacoraCambiosDeLlanta(Session session) : base(session) { }
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

        private Factura mFacturaLlantaAnterior;
        public Factura FacturaLlantaAnterior
        {
            get { return mFacturaLlantaAnterior; }
            set { SetPropertyValue<Factura>("FacturaLlantaAnterior", ref mFacturaLlantaAnterior, value); }
        }

        private Factura mFacturaLlantaNueva;
        public Factura FacturaLlantaNueva
        {
            get { return mFacturaLlantaNueva; }
            set { SetPropertyValue<Factura>("FacturaLlantaNueva", ref mFacturaLlantaNueva, value); }
        }

        private string mEstadoLlantaAnterior;
        public string EstadoLlantaAnterior
        {
            get { return mEstadoLlantaAnterior; }
            set { SetPropertyValue<string>("EstadoLlantaAnterior", ref mEstadoLlantaAnterior, value); }
        }


        static public void CrearRegistro(UnidadDeTrabajo UnidadTrabajo, Unidad Unidad, string PosicionLlanta, Factura LlantaAnterior, Factura LlantaNueva, string EstadoLlantaAnterior)
        {
            BitacoraCambiosDeLlanta CambioLlanta = new BitacoraCambiosDeLlanta(UnidadTrabajo);
            CambioLlanta.Unidad = Unidad;
            CambioLlanta.PosicionDeLlanta = PosicionLlanta;
            CambioLlanta.FacturaLlantaAnterior = LlantaAnterior;
            CambioLlanta.FacturaLlantaNueva = LlantaNueva;
            CambioLlanta.EstadoLlantaAnterior = EstadoLlantaAnterior;
            CambioLlanta.Save();
        }
    }
}
