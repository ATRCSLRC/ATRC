using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Unidad.BL
{
    [Persistent("Uni_Unidad")]
    public class Unidad : ATRCBase
    {
        public Unidad(Session session) : base(session) { }

        private string mNombre;
        [Size(150)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private string mMarca;
        [Size(150)]
        public string Marca
        {
            get { return mMarca; }
            set { SetPropertyValue<string>("Marca", ref mMarca, value); }
        }

        private string mModelo;
        [Size(150)]
        public string Modelo
        {
            get { return mModelo; }
            set { SetPropertyValue<string>("Modelo", ref mModelo, value); }
        }

        private string mVIN;
        [Size(50)]
        public string VIN
        {
            get { return mVIN; }
            set { SetPropertyValue<string>("VIN", ref mVIN, value); }
        }

        private decimal mTotalPesos;
        public decimal TotalPesos
        {
            get { return mTotalPesos; }
            set { SetPropertyValue<decimal>("TotalPesos", ref mTotalPesos, value); }
        }

        private decimal mTotalDolar;
        public decimal TotalDolar
        {
            get { return mTotalDolar; }
            set { SetPropertyValue<decimal>("TotalDolar", ref mTotalDolar, value); }
        }

        [NonPersistent]
        public decimal TotalPesosConCosto
        {
            get
            {
                return this.Gastos[0].TipoMoneda == Enums.TipoMoneda.Pesos ? this.TotalPesos + this.Gastos[0].Cantidad : this.TotalPesos;
            }
        }

        [NonPersistent]
        public decimal TotalDolarConCosto
        {
            get
            {
                return this.Gastos[0].TipoMoneda == Enums.TipoMoneda.Dolares ? this.TotalDolar + this.Gastos[0].Cantidad : this.TotalDolar;
            }
        }

        [NonPersistent]
        public string UnidadDescripcion
        {
            get
            {
                return "<br><b><size=9> " + this.Nombre + " </b><br><br>" + "<size=7> <b>Marca: </b>" + this.Marca + "   <b>Modelo: </b>" + this.Modelo + "<br><br>";
            }
        }

        [Association("Unidad-Gastos")]
        public XPCollection<GastosUnidad> Gastos
        {
            get
            {
                return GetCollection<GastosUnidad>("Gastos");
            }
        }
    }
}
