using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Exceptions;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [NonPersistent]
    public class UtileriasXPO
    {
        //public static string CadenaDeConexion = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("192.168.0.140", "administrador", "", "atrcpuebas");
        public static string CadenaDeConexion = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(@"192.168.1.67\ATRCSERVER", "sa", "@TRCSistemas1", "ATRC");
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
            
            System.Reflection.Assembly dll = System.Reflection.Assembly.Load("CHECADOR.BL");
            dict.GetDataStoreSchema(AppDomain.CurrentDomain.GetAssemblies());
            IDataLayer dl = null;
            if (Utilerias.TipoAplicacion == Enums.TipoAplicacion.Web)
            {
                XpoDefault.Session = null;
                dl = new ThreadSafeDataLayer(dict, store);
            }
            else
            {
                dl = new SimpleDataLayer(dict, store);
            }
            return dl;
            
        }
    }
}
