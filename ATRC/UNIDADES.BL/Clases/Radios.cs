using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.BL
{
    [Persistent("Uni_Radios")]
    public class Radios : ATRCBase
    {
        public Radios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mMarca;
        [Size(100)]
        public string Marca
        {
            get { return mMarca; }
            set { SetPropertyValue<string>("Marca", ref mMarca, value); }
        }

        private string mModelo;
        [Size(100)]
        public string Modelo
        {
            get { return mModelo; }
            set { SetPropertyValue<string>("Modelo", ref mModelo, value); }
        }

        private string mSerie;
        [Size(100)]
        public string Serie
        {
            get { return mSerie; }
            set { SetPropertyValue<string>("Serie", ref mSerie, value); }
        }

        private TipoDestino mDestino;
        public TipoDestino Destino
        {
            get { return mDestino; }
            set { SetPropertyValue<TipoDestino>("Destino", ref mDestino, value); }
        }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }
    }
}
