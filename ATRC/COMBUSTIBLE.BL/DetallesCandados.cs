using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNIDADES.BL;

namespace COMBUSTIBLE.BL
{
    [Persistent("Com_DetallesCandados")]

    public class DetallesCandados : ATRCBase
    {
        public DetallesCandados(Session session) : base(session) { }

        private Usuario mEmpleado;
        public Usuario Empleado
        {
            get { return mEmpleado; }
            set { SetPropertyValue<Usuario>("Empleado", ref mEmpleado, value); }
        }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private string mProblema;
        [Size(SizeAttribute.Unlimited)]
        public string Problema
        {
            get { return mProblema; }
            set { SetPropertyValue<string>("Problema", ref mProblema, value); }
        }
    }
}
