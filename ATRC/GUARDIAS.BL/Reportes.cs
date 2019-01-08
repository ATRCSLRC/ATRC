using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUARDIAS.BL
{
    [Persistent("Gua_Reportes")]
    public class Reportes : ATRCBase
    {
        public Reportes(Session session) : base(session) { }


        private Usuario mEmpleado;
        public Usuario Empleado
        {
            get { return mEmpleado; }
            set { SetPropertyValue<Usuario>("Empleado", ref mEmpleado, value); }
        }

        private Usuario mJefeDepartamento;
        public Usuario JefeDepartamento
        {
            get { return mJefeDepartamento; }
            set { SetPropertyValue<Usuario>("JefeDepartamento", ref mJefeDepartamento, value); }
        }

        private Usuario mUsuario;
        public Usuario Usuario
        {
            get { return mUsuario; }
            set { SetPropertyValue<Usuario>("Usuario", ref mUsuario, value); }
        }

        private Usuario mGuardia;
        public Usuario Guardia
        {
            get { return mGuardia; }
            set { SetPropertyValue<Usuario>("Guardia", ref mGuardia, value); }
        }

        private string mDepartamento;
        public string Departamento
        {
            get { return mDepartamento; }
            set { SetPropertyValue<string>("Departamento", ref mDepartamento, value); }
        }

        private int mFolio;
        public int Folio
        {
            get { return mFolio; }
            set { SetPropertyValue<int>("Folio", ref mFolio, value); }
        }

        private string mMotivo;
        [Size(SizeAttribute.Unlimited)]
        public string Motivo
        {
            get { return mMotivo; }
            set { SetPropertyValue<string>("Motivo", ref mMotivo, value); }
        }
    }
}
