using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [Persistent("gen_Usuario")]
    public class Usuario : ATRCBase
    {
        public Usuario(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string mNombre;
        [Size(300)]
        public string Nombre
        {
            get { return mNombre; }
            set { SetPropertyValue<string>("Nombre", ref mNombre, value); }
        }

        private int mNumEmpleado;
        public int NumEmpleado
        {
            get { return mNumEmpleado; }
            set { SetPropertyValue<int>("NumEmpleado", ref mNumEmpleado, value); }
        }

        private int mIDCard;
        public int IDCard
        {
            get { return mIDCard; }
            set { SetPropertyValue<int>("IDCard", ref mIDCard, value); }
        }

        private bool mActivo = true;
        public bool Activo
        {
            get { return mActivo; }
            set { SetPropertyValue<bool>("Activo", ref mActivo, value); }
        }

        private bool mEsAdministrativo;
        public bool EsAdministrativo
        {
            get { return mEsAdministrativo; }
            set { SetPropertyValue<bool>("EsAdministrativo", ref mEsAdministrativo, value); }
        }

        private bool mAccesoSistema;
        public bool AccesoSistema
        {
            get { return mAccesoSistema; }
            set { SetPropertyValue<bool>("AccesoSistema", ref mAccesoSistema, value); }
        }

        private string mContraseña;
        [Size(500)]
        public string Constraseña
        {
            get
            { return mContraseña; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    if(value.Length < 20)
                        value = Utilerias.EncriptarString(value);

                SetPropertyValue<string>("Constraseña", ref mContraseña, value);
            }
        }

        private string mRFC;
        [Size(50)]
        public string RFC
        {
            get { return mRFC; }
            set { SetPropertyValue<string>("RFC", ref mRFC, value); }
        }

        private DateTime mFechaIngreso;
        public DateTime FechaIngreso
        {
            get { return mFechaIngreso; }
            set { SetPropertyValue<DateTime>("FechaIngreso", ref mFechaIngreso, value); }
        }

        private string mPatron;
        [Size(100)]
        public string Patron
        {
            get { return mPatron; }
            set { SetPropertyValue<string>("Patron", ref mPatron, value); }
        }

        private string mAvisarA;
        [Size(100)]
        public string AvisarA
        {
            get { return mAvisarA; }
            set { SetPropertyValue<string>("AvisarA", ref mAvisarA, value); }
        }

        private string mTelAvisarA;
        [Size(50)]
        public string TelAvisarA
        {
            get { return mTelAvisarA; }
            set { SetPropertyValue<string>("TelAvisarA", ref mTelAvisarA, value); }
        }

        private string mTipoSangre;
        [Size(10)]
        public string TipoSangre
        {
            get { return mTipoSangre; }
            set { SetPropertyValue<string>("TipoSangre", ref mTipoSangre, value); }
        }

        private Puesto mPuesto;
        public Puesto Puesto
        {
            get { return mPuesto; }
            set { SetPropertyValue<Puesto>("Puesto", ref mPuesto, value); }
        }

        private Departamento mDepartamento;
        public Departamento Departamento
        {
            get { return mDepartamento; }
            set { SetPropertyValue<Departamento>("Departamento", ref mDepartamento, value); }
        }

        private Imagen mImagen;
        public Imagen Imagen
        {
            get { return mImagen; }
            set { SetPropertyValue<Imagen>("Imagen", ref mImagen, value); }
        }

        private string mIMSS;
        public string IMSS
        {
            get { return mIMSS; }
            set { SetPropertyValue<string>("IMSS", ref mIMSS, value); }
        }

        private string mModulos;
        public string Modulos
        {
            get { return mModulos; }
            set { SetPropertyValue<string>("Modulos", ref mModulos, value); }
        }

        double mLatitud;
        public double Latitud
        {
            get { return mLatitud; }
            set { SetPropertyValue<double>("Latitud", ref mLatitud, value); }
        }

        double mLongitud;
        public double Longitud
        {
            get { return mLongitud; }
            set { SetPropertyValue<double>("Longitud", ref mLongitud, value); }
        }

        [Association("Usuarios-Permisos", UseAssociationNameAsIntermediateTableName = true)]
        public XPCollection<Permiso> Permisos { get { return GetCollection<Permiso>("Permisos"); } }

        [NonPersistent]
        public string ConstraseñaDesencriptada
        {
            get
            {
                string contraseña = this.Constraseña;
                if (!string.IsNullOrEmpty(contraseña))
                    return Utilerias.DesencriptarString(contraseña);
                return contraseña;
            }

        }

        
    }
}
