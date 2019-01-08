using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ATRCBASE.BL.Enums;

namespace UNIDADES.BL
{
    [Persistent("Uni_Extintores")]
    public class Extintores : ATRCBase
    {
        public Extintores(Session session) : base(session) { }

        int mNumExtintor;
        public int NumExtintor
        {
            get { return mNumExtintor; }
            set { SetPropertyValue<int>("NumExtintor", ref mNumExtintor, value); }
        }

        UbicacionExtintor mUbicacionExtintor;
        public UbicacionExtintor UbicacionExtintor
        {
            get { return mUbicacionExtintor; }
            set { SetPropertyValue<UbicacionExtintor>("UbicacionExtintor", ref mUbicacionExtintor, value); }
        }

        Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        string mOficina;
        public string Oficina
        {
            get { return mOficina; }
            set { SetPropertyValue<string>("Oficina", ref mOficina, value); }
        }

        DateTime mFechaRecarga;
        public DateTime FechaRecarga
        {
            get { return mFechaRecarga; }
            set { SetPropertyValue<DateTime>("FechaRecarga", ref mFechaRecarga, value); }
        }

        DateTime mFechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return mFechaVencimiento; }
            set { SetPropertyValue<DateTime>("FechaVencimiento", ref mFechaVencimiento, value); }
        }

        string mTipo;
        public string Tipo
        {
            get { return mTipo; }
            set { SetPropertyValue<string>("Tipo", ref mTipo, value); }
        }

        decimal mPeso;
        public decimal Peso
        {
            get { return mPeso; }
            set { SetPropertyValue<decimal>("Peso", ref mPeso, value); }
        }

        EstadoExtintor mEstadoExtintor;
        public EstadoExtintor EstadoExtintor
        {
            get { return mEstadoExtintor; }
            set { SetPropertyValue<EstadoExtintor>("EstadoExtintor", ref mEstadoExtintor, value); }
        }

        DateTime mFechaInventario;
        public DateTime FechaInventario
        {
            get { return mFechaInventario; }
            set { SetPropertyValue<DateTime>("FechaInventario", ref mFechaInventario, value); }
        }

        string mUltimoComentario;
        public string UltimoComentario
        {
            get { return mUltimoComentario; }
            set { SetPropertyValue<string>("UltimoComentario", ref mUltimoComentario, value); }
        }
    }
}
