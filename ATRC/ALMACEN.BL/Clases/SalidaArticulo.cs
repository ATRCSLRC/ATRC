﻿using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALMACEN.BL
{
    [Persistent("al_SalidaArticulo")]
    public class SalidaArticulo : ATRCBase
    {
        public SalidaArticulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Articulo mArticulo;
        public Articulo Articulo
        {
            get { return mArticulo; }
            set { SetPropertyValue<Articulo>("Articulo", ref mArticulo, value); }
        }

        private Factura mFactura;
        public Factura Factura
        {
            get { return mFactura; }
            set { SetPropertyValue<Factura>("Factura", ref mFactura, value); }
        }

        private int mCantidad;
        public int Cantidad
        {
            get { return mCantidad; }
            set { SetPropertyValue<int>("Cantidad", ref mCantidad, value); }
        }

        private Enums.Destino mTipoDestino;
        public Enums.Destino TipoDestino
        {
            get { return mTipoDestino; }
            set { SetPropertyValue<Enums.Destino>("TipoDestino", ref mTipoDestino, value); }
        }

        

        private string mOtroDestino;
        public string OtroDestino
        {
            get { return mOtroDestino; }
            set { SetPropertyValue<string>("OtroDestino", ref mOtroDestino, value); }
        }

        private Enums.Recibo mTipoRecibo;
        public Enums.Recibo TipoRecibo
        {
            get { return mTipoRecibo; }
            set { SetPropertyValue<Enums.Recibo>("TipoRecibo", ref mTipoRecibo, value); }
        }

        private Usuario mUsuarioRecibo;
        public Usuario UsuarioRecibo
        {
            get { return mUsuarioRecibo; }
            set { SetPropertyValue<Usuario>("UsuarioRecibo", ref mUsuarioRecibo, value); }
        }

        private string mOtroRecibo;
        public string OtroRecibo
        {
            get { return mOtroRecibo; }
            set { SetPropertyValue<string>("OtroRecibo", ref mOtroRecibo, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Enums.EstadoSalida mEstado;
        public Enums.EstadoSalida Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<Enums.EstadoSalida>("Estado", ref mEstado, value); }
        }
    }
}
