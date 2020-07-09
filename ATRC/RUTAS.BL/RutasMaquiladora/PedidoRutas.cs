﻿using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATRCBASE.BL.Enums;

namespace RUTAS.BL
{
    [Persistent("rut_PedidoRutas")]
    public class PedidoRutas : ATRCBase
    {
        public PedidoRutas(Session session) : base(session) { }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private EstadoPedidoRutas mEstado;
        public EstadoPedidoRutas Estado
        {
            get { return mEstado; }
            set { SetPropertyValue<EstadoPedidoRutas>("Estado", ref mEstado, value); }
        }

        [Association("Rutas-PedidoRutas")]
        public XPCollection<RutasDePedido> Rutas
        {

            get
            {
                return GetCollection<RutasDePedido>(nameof(Rutas));
            }
        }

        [Association("Historial-PedidoRutas")]
        public XPCollection<HistorialPedidoRutas> Historial
        {
            get
            {
                return GetCollection<HistorialPedidoRutas>(nameof(Historial));
            }
        }

        protected override void OnSaving()
        {
            HistorialPedidoRutas Historial = new HistorialPedidoRutas(this.Session);
            Historial.Nombre = this.Nombre;
            Historial.Fecha = this.Fecha;
            Historial.Empresa = this.Empresa;
            Historial.Estado = this.Estado;
            Historial.Usuario = Utilerias.ObtenerUsuarioActual(this.Session as UnidadDeTrabajo); ;
            Historial.HorarioModificacion = DateTime.Now;
            Historial.Save();
            this.Historial.Add(Historial);
            base.OnSaving();
        }
    }
}
