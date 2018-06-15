using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static Unidad.BL.Enums;

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

        private TipoUnidad mTipoUnidad;
        public TipoUnidad TipoUnidad
        {
            get { return mTipoUnidad; }
            set { SetPropertyValue<TipoUnidad>("TipoUnidad", ref mTipoUnidad, value); }
        }

        private string mMotor;
        [Size(60)]
        public string Motor
        {
            get { return mMotor; }
            set { SetPropertyValue<string>("Motor", ref mMotor, value); }
        }

        private int mCilindros;
        public int Cilindros
        {
            get { return mCilindros; }
            set { SetPropertyValue<int>("Cilindros", ref mCilindros, value); }
        }

        private Transmision mTransmision;
        public Transmision Transmision
        {
            get { return mTransmision; }
            set { SetPropertyValue<Transmision>("Transmision", ref mTransmision, value); }
        }

        private Frenos mFrenos;
        public Frenos Frenos
        {
            get { return mFrenos; }
            set { SetPropertyValue<Frenos>("Frenos", ref mFrenos, value); }
        }

        private bool mAireAcondicionado;
        public bool AireAcondicionado
        {
            get { return mAireAcondicionado; }
            set { SetPropertyValue<bool>("AireAcondicionado", ref mAireAcondicionado, value); }
        }

        private Estado mEstado;
        public Estado Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<Estado>("Estado", ref mEstado, value); }
        }

        private DetalleVenta mDetalleVenta;
        public DetalleVenta DetalleVenta
        {
            get { return mDetalleVenta; }
            set { SetPropertyValue<DetalleVenta>("DetalleVenta", ref mDetalleVenta, value); }
        }

        [NonPersistent]
        public decimal TotalPesos
        {
            get
            {
                XPView Unidad = new XPView(this.Session, typeof(Unidad));
                Unidad.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("TotalPesos", SortDirection.None, "iif([Estado] == 3, [Gastos].Sum(iif([TipoTransaccion] == 1,iif([TipoMoneda] == 0,[Cantidad], [Cantidad] * [TipoCambio] ), 0)), " +
                  "[Gastos].Sum(iif([TipoTransaccion] == 0,iif([TipoMoneda] == 0,[Cantidad], [Cantidad] * [TipoCambio] ), 0)))", false, true)
                 });
                Unidad.Criteria = new BinaryOperator("Oid", this.Oid);
                return Convert.ToDecimal(Unidad[0]["TotalPesos"]);
            }
        }

        [NonPersistent]
        public decimal TotalDolar
        {
            get
            {
                XPView Unidad = new XPView(this.Session, typeof(Unidad));
                Unidad.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("TotalDolar", SortDirection.None, "iif([Estado] == 3, [Gastos].Sum(iif([TipoTransaccion] == 1,iif([TipoMoneda] == 1,[Cantidad], [Cantidad] / [TipoCambio] ), 0)), " +
                  "[Gastos].Sum(iif([TipoTransaccion] == 0,iif([TipoMoneda] == 1,[Cantidad], [Cantidad] / [TipoCambio] ), 0)))", false, true)
                 });
                Unidad.Criteria = new BinaryOperator("Oid", this.Oid);
                return Convert.ToDecimal(Unidad[0]["TotalDolar"]);
            }
        }


        [NonPersistent]
        public decimal TotalPesosGastos
        {
            get
            {
                XPView Unidad = new XPView(this.Session, typeof(Unidad));
                Unidad.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("TotalPesos", SortDirection.None, "[Gastos].Sum(iif([TipoTransaccion] == 0,iif([TipoMoneda] == 0,[Cantidad], [Cantidad] * [TipoCambio] ), 0))", false, true)
                 });
                Unidad.Criteria = new BinaryOperator("Oid", this.Oid);
                return Convert.ToDecimal(Unidad[0]["TotalPesos"]);
            }
        }

        [NonPersistent]
        public decimal TotalDolarGastos
        {
            get
            {
                XPView Unidad = new XPView(this.Session, typeof(Unidad));
                Unidad.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("TotalDolar", SortDirection.None, "[Gastos].Sum(iif([TipoTransaccion] == 0,iif([TipoMoneda] == 1,[Cantidad], [Cantidad] / [TipoCambio] ), 0))", false, true)
                 });
                Unidad.Criteria = new BinaryOperator("Oid", this.Oid);
                return Convert.ToDecimal(Unidad[0]["TotalDolar"]);
            }
        }

        [NonPersistent]
        public string UnidadDescripcion
        {
            get
            {
                //return "<br><b><size=9> " + this.Nombre + " </b><br><br>" + "<size=7> <b>Marca: </b>" + this.Marca + "   <b>Modelo: </b>" + this.Modelo + "<br><br>";
                return "<br><b><size=9> " + this.Nombre + " </b><br><br>" + "<size=8><i>" + this.Marca + " " + this.Modelo + ", " + this.VIN + "</i><br><br>";
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
