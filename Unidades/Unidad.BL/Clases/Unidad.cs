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
        public string UnidadDescripcion
        {
            get
            {
                return "<br><b><size=9> " + this.Nombre + " </b><br><br>" + "<size=7> <b>Total pesos:</b>" + this.TotalPesos.ToString("c") + "   <b>Total dolar:</b>" + this.TotalDolar.ToString("c") + "<br><br>";
            }
        }

        [NonPersistent]
        public Bitmap Editar
        {
            get
            {
                return Properties.Resources.icons8_lápiz_32__1_;
            }
        }

        [NonPersistent]
        public Bitmap Eliminar
        {
            get
            {
                return Properties.Resources.icons8_eliminar_32;
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
