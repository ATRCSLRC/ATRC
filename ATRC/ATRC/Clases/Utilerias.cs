using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRC
{
    [NonPersistent]
    public class Utilerias
    {
        public static bool BaseNueva(UnidadDeTrabajo Unidad)
        {
            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid", null);
            try
            {
                if (Usuarios.Count == 0)
                {
                    Usuario Usuario = new Usuario(Unidad);
                    Usuario.Nombre = "admin";
                    Usuario.Constraseña = "atrc1234";
                    Usuario.NumEmpleado = 1;
                    Usuario.EsAdministrativo = true;
                    Usuario.Activo = true;
                    Usuario.Imagen = new Imagen(Unidad);
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
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("ATRCBASE.BL"));
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("CHECADOR.BL"));
            XpoDefault.Session.UpdateSchema(typeof(XPObject).Assembly);
        }
    }
}
