using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_ReportesServiciosRealizados")]
    public class ReportesServiciosRealizados : ATRCBase
    {
        public ReportesServiciosRealizados(Session session) : base(session) { }

        private DateTime mFecha;
        public DateTime Fecha
        {
            get { return mFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref mFecha, value); }
        }

        private string mDescripcion;
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }

        private Empresas mEmpresa;
        public Empresas Empresa
        {
            get { return mEmpresa; }
            set { SetPropertyValue<Empresas>("Empresa", ref mEmpresa, value); }
        }

        private string mArchivo;
        [Size(SizeAttribute.Unlimited)]
        public string Archivo
        {
            get { return mArchivo; }
            set { SetPropertyValue<string>("Archivo", ref mArchivo, value); }
        }
    }
}
