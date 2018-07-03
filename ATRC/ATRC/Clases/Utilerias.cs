using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
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
            Type typeSalida = System.Reflection.Assembly.Load("ALMACEN.BL").GetType("ALMACEN.BL.SalidaArticulo");
            Type typeArticulo = System.Reflection.Assembly.Load("ALMACEN.BL").GetType("ALMACEN.BL.Articulo");
            Type typeUnidad = System.Reflection.Assembly.Load("UNIDADES.BL").GetType("UNIDADES.BL.Unidad");
            XPClassInfo Almacen = XpoDefault.Session.GetClassInfo(typeSalida);
            XPClassInfo Unidad = XpoDefault.Session.GetClassInfo(typeUnidad);
            XPMemberInfo salidas = Almacen.CreateMember("Unidad", typeUnidad, new AssociationAttribute("Uni_Unidades-Salidas"));
            XPMemberInfo unidades = Unidad.CreateMember("Salidas", typeof(XPCollection), true, new AssociationAttribute("Uni_Unidades-Salidas", typeSalida));
            XPMemberInfo LlantaFrontalIzquierdaChofer = Unidad.CreateMember("LlantaFrontalIzquierdaChofer", typeArticulo);
            XPMemberInfo LlantaFrontalDerechaEstribo = Unidad.CreateMember("LlantaFrontalDerechaEstribo", typeArticulo);
            XPMemberInfo LlantaTraseraInteriorChofer = Unidad.CreateMember("LlantaTraseraInteriorChofer", typeArticulo);
            XPMemberInfo LlantaTraseraInteriorEstribo = Unidad.CreateMember("LlantaTraseraInteriorEstribo", typeArticulo);
            XPMemberInfo LlantaTraseraExteriorChofer = Unidad.CreateMember("LlantaTraseraExteriorChofer", typeArticulo);
            XPMemberInfo LlantaTraseraExteriorEstribo = Unidad.CreateMember("LlantaTraseraExteriorEstribo", typeArticulo);

            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("ATRCBASE.BL"));
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("CHECADOR.BL"));
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("ALMACEN.BL"));
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("UNIDADES.BL"));
            XpoDefault.Session.UpdateSchema(System.Reflection.Assembly.Load("LLANTERA.BL"));
            XpoDefault.Session.UpdateSchema(typeof(XPObject).Assembly);
        }
    }
}
