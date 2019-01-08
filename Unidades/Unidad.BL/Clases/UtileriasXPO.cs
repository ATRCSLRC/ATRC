using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Exceptions;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Unidad.BL
{
    [NonPersistent]
    public class UtileriasXPO
    {
        //public static string CadenaDeConexion = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("192.168.0.140", "administrador", "", "atrcpuebas");
        public static string CadenaDeConexion = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(@"192.168.0.123\ATRCSERVER", "sa", "@TRCSistemas", "ATRCUnidades");
        [Description("Regresa la unidad instanciada, este metodo es para validar que no este vacia la unidad.")]
        public static UnidadDeTrabajo CargarUnidadDeTrabajo(ref UnidadDeTrabajo uow)
        {
            if (uow == null) uow = new UnidadDeTrabajo(DataLayer);
            uow.LockingOption = LockingOption.None;
            return uow;
        }
        [Description("Regresa una nueva sesion.")]
        public static Session ObtenerNuevaSession()
        {
            Session sesion = new Session(DataLayer);
            sesion.LockingOption = LockingOption.None;
            return sesion;
        }
        [Description("Regresa una nueva unidad de trabajo.")]
        public static UnidadDeTrabajo ObtenerNuevaUnidadDeTrabajo()
        {
            UnidadDeTrabajo Unidad = new UnidadDeTrabajo(DataLayer);
            Unidad.LockingOption = LockingOption.None;
            return Unidad;
        }

        private readonly static object lockObject = new object();

        static volatile IDataLayer fDataLayer;
        static IDataLayer DataLayer
        {
            get
            {
                if (fDataLayer == null)
                {
                    lock (lockObject)
                    {
                        if (fDataLayer == null) fDataLayer = GetDataLayer();
                    }
                }
                return fDataLayer;
            }
        }

        private static IDataLayer GetDataLayer()
        {
            if (string.IsNullOrEmpty(CadenaDeConexion)) throw new Exception("Ocurrio un problema con la conexión.");

            DevExpress.Xpo.DB.IDataStore store = XpoDefault.GetConnectionProvider(CadenaDeConexion, AutoCreateOption.SchemaAlreadyExists);
            DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            dict.GetDataStoreSchema(AppDomain.CurrentDomain.GetAssemblies());
            IDataLayer dl = new SimpleDataLayer(dict, store);
            return dl;
            
        }

        public static bool BaseNueva(UnidadDeTrabajo Unidad)
        {
            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid", null);
            try
            {
                if (Usuarios.Count == 0)
                {
                    Usuario Usuario = new Usuario(Unidad);
                    Usuario.Nombre = "Gil Enrique Salgado";
                    Usuario.NombreUsuario = "Gil";
                    Usuario.Constraseña = "Gil";
                    Usuario.Save();
                    Unidad.CommitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(DevExpress.Xpo.DB.Exceptions.SchemaCorrectionNeededException))
                {
                    return true;
                }
            }
            return false;
        }

        public static void ActualizarEsquema()
        {
            XpoDefault.Session.Disconnect();
            XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema;
            XpoDefault.Session.Connect();
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("Unidad.BL"));
            XpoDefault.Session.UpdateSchema(typeof(XPObject).Assembly);
        }
    }
}
