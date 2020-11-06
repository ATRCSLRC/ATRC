using ATRCBASE.BL;
using ATRCBASE.BL.Clases;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUTAS.BL
{
    [NonPersistent]
    public class Utilerias
    {
        public static void EnviarCorreo(PedidoRutas Pedido)
        {
            PlantillaDeCorreo Plantilla;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            string Mensaje = string.Empty;
            string Asunto = string.Empty;
            string Destinatario = string.Empty;
            ArrayList cc = new ArrayList();
            if (Pedido.Estado != ATRCBASE.BL.Enums.EstadoPedidoRutas.Rechazado)
            {
                Plantilla = (PlantillaDeCorreo)Unidad.FindObject(typeof(PlantillaDeCorreo), new BinaryOperator("Nombre", "Cambio de estado (Pedido de rutas)"));
                Mensaje = Plantilla.Contenido.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]" , Pedido.Fecha.ToLongDateString());
                Asunto = Plantilla.Asunto.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString());
            }
            else
            {
                Plantilla = (PlantillaDeCorreo)Unidad.FindObject(typeof(PlantillaDeCorreo), new BinaryOperator("Nombre", "Rechazar pedido rutas"));
                Mensaje = Plantilla.Contenido.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString()).Replace("[Motivo]", Pedido.Detalle);
                Asunto = Plantilla.Asunto.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString()).Replace("[Motivo]", Pedido.Detalle);
            }


            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;Nombre;Activo;Correo", null);
            Usuarios.Criteria = new BinaryOperator("EsExterno", true);
            Usuarios.Criteria = new BinaryOperator("Activo", true);
            Usuarios.Criteria = new BinaryOperator("Empresa.Oid", Pedido.Empresa.Oid);

            int cont = 0;
            foreach(ViewRecord viewUsuario in Usuarios)
            {
                if (cont == 0)
                {
                    Destinatario = viewUsuario["Correo"].ToString();
                }else
                {
                    cc.Add(viewUsuario["Correo"].ToString());
                }
                cont++;
            }

            ATRCBASE.BL.Utilerias.EnviarCorreo(Destinatario,Mensaje,Asunto,cc,null);
        }

        public static void EnviarCorreoMaquiladora(PedidoRutas Pedido)
        {
            PlantillaDeCorreo Plantilla;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            string Mensaje = string.Empty;
            string Asunto = string.Empty;
            string Destinatario = string.Empty;
            ArrayList cc = new ArrayList();
            if (Pedido.Estado != ATRCBASE.BL.Enums.EstadoPedidoRutas.Rechazado)
            {
                Plantilla = (PlantillaDeCorreo)Unidad.FindObject(typeof(PlantillaDeCorreo), new BinaryOperator("Nombre", "Cambio de estado (Pedido de rutas)"));
                Mensaje = Plantilla.Contenido.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString());
                Asunto = Plantilla.Asunto.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString());
            }
            else
            {
                Plantilla = (PlantillaDeCorreo)Unidad.FindObject(typeof(PlantillaDeCorreo), new BinaryOperator("Nombre", "Rechazar pedido rutas"));
                Mensaje = Plantilla.Contenido.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString()).Replace("[Motivo]", Pedido.Detalle);
                Asunto = Plantilla.Asunto.Replace("[Nombre]", Pedido.Nombre).Replace("[Estado]", Pedido.Estado.ToString()).Replace("[Fecha]", Pedido.Fecha.ToLongDateString()).Replace("[Motivo]", Pedido.Detalle);
            }


            ATRCBASE.BL.Configuraciones ConfiguracionEncargadosRutas = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "CorreosEncargadosRutas"));
            string[] Correos = ConfiguracionEncargadosRutas.Accion.Split(',');


            int cont = 0;
            foreach (string viewUsuario in Correos)
            {
                if (cont == 0)
                {
                    Destinatario = viewUsuario;
                }
                else
                {
                    cc.Add(viewUsuario);
                }
                cont++;
            }

            ATRCBASE.BL.Utilerias.EnviarCorreo(Destinatario, Mensaje, Asunto, cc, null);
        }

    }
}
