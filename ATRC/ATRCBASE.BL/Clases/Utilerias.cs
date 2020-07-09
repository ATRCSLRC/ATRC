using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ATRCBASE.BL.Enums;

namespace ATRCBASE.BL
{
    [NonPersistent]
    public static partial class Utilerias
    {
        public static DateTime ObtenerFechaHora()
        {
            return DateTime.Now;
        }


        private static UnidadDeTrabajo _Unidad;
        public static UnidadDeTrabajo Unidad
        {
            get { if (_Unidad == null) _Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(); return _Unidad; }
            set { _Unidad = value; }
        }

        public static TipoAplicacion TipoAplicacion;
        public static string sessionID = "";
        //private static Session _Sesion;
        //public static Session Sesion
        //{
        //    get { if (_Sesion == null) _Sesion = UtileriasXPO.ObtenerNuevaSession(); return _Sesion; }
        //    set { _Sesion = value; }
        //}

        public static Usuario ObtenerUsuarioActual(UnidadDeTrabajo mUnidad)
        {
            Usuario _usuarioActual = null;
            switch (TipoAplicacion)
            {
                case TipoAplicacion.Web:
                    try
                    {
                        int valor = Convert.ToInt32(System.Web.HttpContext.Current.Session["OidAdministrador"]);
                        _usuarioActual = (Usuario)mUnidad.GetObjectByKey<Usuario>(valor);
                    }
                    catch { _usuarioActual = new Usuario(mUnidad); }
                    
                    if (_usuarioActual == null) _usuarioActual = new Usuario(mUnidad);
                    break;
                case TipoAplicacion.Windows:
                    _usuarioActual = mUsuarioActual != null ? mUnidad.GetObjectByKey<Usuario>(mUsuarioActual.Oid) : null;
                    break;
            }
            return _usuarioActual;
        }
        private static Usuario mUsuarioActual;
        public static Usuario UsuarioActual
        {
            get
            {
                return ObtenerUsuarioActual(Unidad);
            }
            set
            {
                if (TipoAplicacion == TipoAplicacion.Web)
                {
                    System.Web.HttpContext.Current.Session["USERNAME" + sessionID] = value.Nombre;
                }
                mUsuarioActual = value;
            }
        }

        public static string EncriptarString(string Parametro)
        {
            string EncryptionKey = "AtRC2018";
            byte[] clearBytes = Encoding.Unicode.GetBytes(Parametro);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    Parametro = Convert.ToBase64String(ms.ToArray());
                }
            }
            return Parametro;
        }

        public static string DesencriptarString(string ParametroEncriptado)
        {
            string EncryptionKey = "AtRC2018";
            ParametroEncriptado = ParametroEncriptado.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(ParametroEncriptado);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    ParametroEncriptado = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return ParametroEncriptado;
        }

        #region LookUps edits

        /// <summary>
        /// Carga los datos de un control tipo LookUpEdit
        /// </summary>
        /// <param name="lue">El control al cual asignarle la colección de objetos</param>
        /// <param name="tipo">El tipo de dato de la colección de objetos</param>
        /// <param name="sesion">La sesión a utilizar para la colección de objetos</param>
        /// <param name="DisplayMember">El campo del objeto que se mostrara como descripción en el control</param>
        /// <param name="columna">El campo del objeto que sera desplegado en la columna del control</param>
        /// <param name="AsignarValorPredeterminado">Si es verdadero, asigna automáticamente el primer valor de la colección al control</param>

        public static void CargarLookupEdit(LookUpEdit lue, Type tipo, Session sesion,
            string DisplayMember, string columna, bool AsignarValorPredeterminado)
        {
            XPCollection xpc = new XPCollection(sesion, tipo);
            lue.Properties.DataSource = xpc;
            lue.Properties.DisplayMember = DisplayMember;
            if (lue.Properties.Columns.Count < 1)
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(columna));
            }

            if (AsignarValorPredeterminado)
            {
                if (((XPCollection)lue.Properties.DataSource).Count > 0)
                {
                    lue.EditValue = ((XPCollection)lue.Properties.DataSource)[0];
                }
                else
                {
                    lue.EditValue = null;
                    lue.Properties.NullText = "[Seleccione]";
                }
            }
            lue.Properties.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            lue.Properties.BestFit();
            lue.KeyUp += new System.Windows.Forms.KeyEventHandler(LimpiarLookUpEdit);
        }


        /// <summary>
        /// Carga los datos de un control tipo LookUpEdit
        /// </summary>
        /// <param name="lue">El control al cual asignarle la colección de objetos</param>
        /// <param name="tipo">El tipo de dato de la colección de objetos</param>
        /// <param name="sesion">La sesión a utilizar para la colección de objetos</param>
        /// <param name="DisplayMember">El campo del objeto que se mostrara como descripción en el control</param>
        /// <param name="columnas">Una lista de columnas a ser desplegadas dentro del control</param>
        /// <param name="AsignarValorPredeterminado">Si es verdadero, asigna automáticamente el primer valor de la colección al control</param>
        public static void CargarLookupEdit(LookUpEdit lue, Type tipo, Session sesion,
            string DisplayMember, string[] columnas, bool AsignarValorPredeterminado)
        {
            XPCollection xpc = new XPCollection(sesion, tipo);
            lue.Properties.DataSource = xpc;
            lue.Properties.DisplayMember = DisplayMember;

            if (lue.Properties.Columns.Count < 1)
            {
                foreach (string columna in columnas)
                {
                    lue.Properties.Columns.Add(new LookUpColumnInfo(columna));
                }
            }

            if (AsignarValorPredeterminado)
            {
                if (((XPCollection)lue.Properties.DataSource).Count > 0)
                {
                    lue.EditValue = ((XPCollection)lue.Properties.DataSource)[0];
                }
                else
                {
                    lue.EditValue = null;
                    lue.Properties.NullText = "[Seleccione]";
                }
            }
            int i = 0;
            bool ordenado = false;
            foreach (LookUpColumnInfo columna in lue.Properties.Columns)
            {
                if ((columna.Caption == "Descripcion") || (columna.Caption.Contains("Nombre")))
                {
                    lue.Properties.SortColumnIndex = i;
                    lue.Properties.Columns[i].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    ordenado = true;
                }
                i++;
            }
            if (!ordenado)
            {
                lue.Properties.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            lue.Properties.BestFit();
            lue.KeyUp += new System.Windows.Forms.KeyEventHandler(LimpiarLookUpEdit);
        }

        /// <summary>
        /// Carga los datos de un control tipo LookUpEdit
        /// </summary>
        /// <param name="lue">El control al cual asignarle la colección de objetos</param>
        /// <param name="tipo">El tipo de dato de la colección de objetos</param>
        /// <param name="criteria">El filtro de la colección</param>
        /// <param name="sesion">La sesión a utilizar para la colección de objetos</param>
        /// <param name="DisplayMember">El campo del objeto que se mostrara como descripción en el control</param>
        /// <param name="columna">El campo del objeto que sera desplegado en la columna del control</param>
        /// <param name="AsignarValorPredeterminado">Si es verdadero, asigna automáticamente el primer valor de la colección al control</param>
        public static void CargarLookupEdit(LookUpEdit lue, Type tipo, CriteriaOperator criteria,
            Session sesion, string DisplayMember, string columna, bool AsignarValorPredeterminado)
        {
            XPCollection xpc = new XPCollection(sesion, tipo);
            xpc.Criteria = criteria;
            lue.Properties.DataSource = xpc;
            lue.Properties.DisplayMember = DisplayMember;

            if (lue.Properties.Columns.Count < 1)
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(columna));
            }


            if (AsignarValorPredeterminado)
            {
                if (((XPCollection)lue.Properties.DataSource).Count > 0)
                {
                    lue.EditValue = ((XPCollection)lue.Properties.DataSource)[0];
                }
                else
                {
                    lue.EditValue = null;
                    lue.Properties.NullText = "[Seleccione]";
                }
            }
            lue.Properties.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            lue.Properties.BestFit();
            lue.KeyUp += new System.Windows.Forms.KeyEventHandler(LimpiarLookUpEdit);
        }

        /// <summary>
        /// Carga los datos de un control tipo LookUpEdit
        /// </summary>
        /// <param name="lue">El control al cual asignarle la colección de objetos</param>
        /// <param name="tipo">El tipo de dato de la colección de objetos</param>
        /// <param name="criteria">El filtro de la colección</param>
        /// <param name="sesion">La sesión a utilizar para la colección de objetos</param>
        /// <param name="DisplayMember">El campo del objeto que se mostrara como descripción en el control</param>
        /// <param name="columnas">Una lista de columnas a ser desplegadas dentro del control</param>
        /// <param name="AsignarValorPredeterminado">Si es verdadero, asigna automáticamente el primer valor de la colección al control</param>
        public static void CargarLookupEdit(LookUpEdit lue, Type tipo, CriteriaOperator criteria,
            Session sesion, string DisplayMember, string[] columnas, bool AsignarValorPredeterminado)
        {
            XPCollection xpc = new XPCollection(sesion, tipo);
            xpc.Criteria = criteria;
            lue.Properties.DataSource = xpc;
            lue.Properties.DisplayMember = DisplayMember;

            if (lue.Properties.Columns.Count < 1)
            {
                foreach (string columna in columnas)
                {
                    lue.Properties.Columns.Add(new LookUpColumnInfo(columna));
                }
            }

            if (AsignarValorPredeterminado)
            {
                if (((XPCollection)lue.Properties.DataSource).Count > 0)
                {
                    lue.EditValue = ((XPCollection)lue.Properties.DataSource)[0];
                }
                else
                {
                    lue.EditValue = null;
                    lue.Properties.NullText = "[Seleccione]";
                }
            }
            int i = 0;
            bool ordenado = false;
            foreach (LookUpColumnInfo columna in lue.Properties.Columns)
            {
                if ((columna.Caption == "Descripcion") || (columna.Caption.Contains("Nombre")))
                {
                    lue.Properties.SortColumnIndex = i;
                    lue.Properties.Columns[i].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    ordenado = true;
                }
                i++;
            }
            if (!ordenado)
            {
                lue.Properties.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            lue.Properties.BestFit();
            lue.KeyUp += new System.Windows.Forms.KeyEventHandler(LimpiarLookUpEdit);
        }

        /// <summary>
        /// Asigna null al EditValue del control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void LimpiarLookUpEdit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                if (((LookUpEdit)sender).EditValue != null)
                {
                    ((LookUpEdit)sender).EditValue = null;
                }
            }

        }
        #endregion

        public static System.Drawing.Imaging.ImageFormat GetExtension(Image img)
        {
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return System.Drawing.Imaging.ImageFormat.Bmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return System.Drawing.Imaging.ImageFormat.Png;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return System.Drawing.Imaging.ImageFormat.Emf;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return System.Drawing.Imaging.ImageFormat.Exif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return System.Drawing.Imaging.ImageFormat.Gif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return System.Drawing.Imaging.ImageFormat.Icon;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return System.Drawing.Imaging.ImageFormat.MemoryBmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return System.Drawing.Imaging.ImageFormat.Tiff;
            else
                return System.Drawing.Imaging.ImageFormat.Wmf;
        }
        public static string NumEmpleado( UnidadDeTrabajo Unidad)
        {
           
            XPView Usuarios = new XPView(Unidad, typeof(Usuario));
            
            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("NumEmpleado", SortDirection.Descending, "[NumEmpleado]", true, true)});
            Usuarios.SelectDeleted = true;
            return (Convert.ToInt32(Usuarios[0]["NumEmpleado"]) + 1).ToString();
        }

        public static void Permisos()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Permiso nivel1, nivel2, nivel3;

            #region Usuarios
            nivel1 = CrearPermisos(Unidad, "Usuario", "Usuario", null);
            nivel2 = CrearPermisos(Unidad, "Usuarios", "Usuarios", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Usuario","NuevoUsuario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Usuario", "ModificarUsuario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Historial Reportes Usuario", "HistorialReportesUsuario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Activar/Desactivar Usuario", "ActivarDasactivarUsuario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Imprimir gafete", "ImprimirGafete", nivel2);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesUsuarios", nivel1);
            nivel2 = CrearPermisos(Unidad, "Anuncios", "AnunciosUsuario", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Anuncio", "NuevoAnuncio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Anuncio", "ModificarAnuncio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Anuncio", "EliminarAnuncio", nivel2);
            #endregion

            #region Checador
            nivel1 = CrearPermisos(Unidad, "Checador", "Checador", null);
            nivel2 = CrearPermisos(Unidad, "Checador", "NuevaChecada", nivel1);
            nivel2 = CrearPermisos(Unidad, "Historial de checador", "HistorialChecador", nivel1);
            nivel3 = CrearPermisos(Unidad, "Modificar Checada", "ModificarChecada", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Checada", "EliminarChecada", nivel2);
            nivel2 = CrearPermisos(Unidad, "Notificaciones", "NotificacionesChecador", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Notificacion", "NuevaNotificacion", nivel2);
            nivel3 = CrearPermisos(Unidad, "Desactivar Notificacion", "DesactivarNotificacion", nivel2);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesChecador", nivel1);
            #endregion

            #region Almacen
            nivel1 = CrearPermisos(Unidad, "Almacen", "Almacen", null);
            nivel2 = CrearPermisos(Unidad, "Nuevo Articulo", "NuevoArticulo", nivel1);
            nivel2 = CrearPermisos(Unidad, "Modificar Articulo", "ModificarArticulo", nivel1);
            nivel2 = CrearPermisos(Unidad, "Busqueda Articulos", "BusquedaArticulos", nivel1);
            nivel2 = CrearPermisos(Unidad, "Salida Articulos", "SalidaArticulos", nivel1);
            nivel2 = CrearPermisos(Unidad, "Prestamo Articulos", "PrestamoArticulos", nivel1);
            nivel2 = CrearPermisos(Unidad, "Historial Prestamo Herramienta", "HistorialPrestamoHerramienta", nivel1);
            nivel2 = CrearPermisos(Unidad, "Bitacoras Salidas", "BitacorasSalidas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Inventario", "InventarioAlmacen", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Inventario", "NuevoInventario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Inventario", "ModificarInventario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Inventario", "EliminarInventario", nivel2);
            nivel3 = CrearPermisos(Unidad, "Imprimir Inventario", "ImprimirInventario", nivel2);
            nivel2 = CrearPermisos(Unidad, "Marcas", "Marcas", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Marca", "NuevaMarca", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Marca", "ModificarMarca", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Marca", "EliminarMarca", nivel2);
            nivel2 = CrearPermisos(Unidad, "Proveedor", "Proveedor", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Proveedor", "NuevoProveedor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Proveedor", "ModificarProveedor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Proveedor", "EliminarProveedor", nivel2);
            nivel2 = CrearPermisos(Unidad, "Codigos de articulos", "CodigosArticulos", nivel1);
            nivel2 = CrearPermisos(Unidad, "Impresora ticket", "ImpresoraTicketAlmacen", nivel1);
            #endregion

            #region Unidades
            nivel1 = CrearPermisos(Unidad, "Unidades", "Unidades", null);
            nivel2 = CrearPermisos(Unidad, "Nueva Unidad", "NuevaUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Detalles de Unidad", "DetallesDeUnidad", nivel1);
            nivel3 = CrearPermisos(Unidad, "Detalle de Unidad", "DetallesUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Unidad", "ModificarUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Estado Unidad", "EstadoUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Unidad", "EliminarUnidad", nivel2);
            nivel2 = CrearPermisos(Unidad, "Unidades de Fuera Servicio", "FueraServicioUnidad", nivel1);
            nivel3 = CrearPermisos(Unidad, "Estado Unidad", "EstadoUnidadFueraServicio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Detalle de Unidad", "DetallesUnidadFueraServicio", nivel2);
            nivel2 = CrearPermisos(Unidad, "Servicios Unidad", "ServiciosUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Radios", "Radios", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Radio", "NuevaRadio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Radio", "ModificarRadio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Radio", "EliminarRadio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Imprimir Detalles", "ImprimirDetallesRadio", nivel2);
            nivel2 = CrearPermisos(Unidad, "Proximos cambios de aceite", "ProximosCambiosAceite", nivel1);
            nivel2 = CrearPermisos(Unidad, "Extintores", "Extintores", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Extintor", "NuevaExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Extintor", "ModificarExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Extintor", "EliminarExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Exportar Extintor", "ExportarExtintor", nivel2);
            nivel2 = CrearPermisos(Unidad, "Inventario de Extintores", "InventarioExtintores", nivel1);
            nivel3 = CrearPermisos(Unidad, "Revisar Extintor", "RevisarExtintor", nivel2);
            nivel2 = CrearPermisos(Unidad, "Historial de Extintores", "HistorialExtintores", nivel1);
            nivel2 = CrearPermisos(Unidad, "Inventario de", "InventarioBaterias", nivel1);
            nivel2 = CrearPermisos(Unidad, "Historial de Baterias", "HistorialBaterias", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesUnidades", nivel1);
            #endregion

            #region Llantera
            nivel1 = CrearPermisos(Unidad, "Llantera", "Llantera", null);
            nivel2 = CrearPermisos(Unidad, "Cambios de Llanta", "CambiosLlanta", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reparacion de Llanta", "ReparacionLlanta", nivel1);
            nivel2 = CrearPermisos(Unidad, "Inventarios", "InventariosLlanta", nivel1);
            #endregion

            #region Taller
            nivel1 = CrearPermisos(Unidad, "Taller", "Taller", null);
            nivel2 = CrearPermisos(Unidad, "Bitacora de Actividades", "BitacoraActividadesTaller", nivel1);
            nivel2 = CrearPermisos(Unidad, "Actividades", "ActividadesTaller", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesTaller", nivel1);
            #endregion

            #region Rutas
            nivel1 = CrearPermisos(Unidad, "Rutas", "Rutas", null);
            nivel2 = CrearPermisos(Unidad, "Mapa", "MapaRutas", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Ruta", "NuevaRutas", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Ruta", "ModificarRutas", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Ruta", "EliminarRutas", nivel2);
            nivel2 = CrearPermisos(Unidad, "Mapa por Empresa", "MapaEmpresa", nivel1);
            nivel2 = CrearPermisos(Unidad, "Checador", "ChecadorRutas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Registros de Entrada/Salida", "EntradaSalidaRutas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesRutas", nivel1);

            nivel2 = CrearPermisos(Unidad, "Generar rutas", "GenerarRutas", nivel1);
            nivel3 = CrearPermisos(Unidad, "Rutas fijas", "RutasFijasGenerar", nivel2);
            nivel3 = CrearPermisos(Unidad, "Nueva Ruta", "NuevaRutasGenerar", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Ruta", "ModificarRutasGenerar", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Ruta", "EliminarRutasGenerar", nivel2);

            nivel2 = CrearPermisos(Unidad, "Plantillas de rutas", "PlantillasRutas", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Plantilla", "NuevaPlantilla", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Plantilla", "ModificarPlantilla", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Plantilla", "EliminarPlantilla", nivel2);
            nivel3 = CrearPermisos(Unidad, "Clonar Plantilla", "ClonarPlantilla", nivel2);

            nivel2 = CrearPermisos(Unidad, "Turnos", "Turnos", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Turno", "NuevoTurno", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Turno", "ModificarTurno", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Turno", "EliminarTurno", nivel2);

            nivel2 = CrearPermisos(Unidad, "Servicios", "ServiciosRutas", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Servicio", "NuevoServicio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Servicio", "ModificarServicio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Servicio", "EliminarServicio", nivel2);

            nivel2 = CrearPermisos(Unidad, "Precios de Servicios", "PreciosServicios", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Servicio", "NuevoServicioPrecio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Servicio", "ModificarServicioPrecio", nivel2);

            nivel2 = CrearPermisos(Unidad, "Importación de rutas", "ImportacionRutas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Servicios realizados", "ServiciosRealizados", nivel1);
            nivel2 = CrearPermisos(Unidad, "Consulta reportes de servicios", "ConsultaReportesServicios", nivel1);
            #endregion

            #region Administracion
            nivel1 = CrearPermisos(Unidad, "Administracion", "Administracion", null);
            nivel2 = CrearPermisos(Unidad, "Checador", "ChecadorAdministracion", nivel1);
            nivel2 = CrearPermisos(Unidad, "Registros de Entrada/Salida", "EntradaSalidaAdministracion", nivel1);
            #endregion

            #region Combustible
            nivel1 = CrearPermisos(Unidad, "Combustible", "Combustible", null);
            nivel2 = CrearPermisos(Unidad, "Diesel", "Diesel", nivel1);
            nivel3 = CrearPermisos(Unidad, "Diesel en Unidad", "DieselUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Medidores de Tanque", "MedidoresTanqueDiesel", nivel2);
            nivel3 = CrearPermisos(Unidad, "Agregar Pedido", "AgregarPedidoDiesel", nivel2);
            nivel2 = CrearPermisos(Unidad, "Modificacion Diesel", "ModificacionDiesel", nivel1);
            nivel2 = CrearPermisos(Unidad, "Cálculo Cargos Diesel", "CalculoCargosDiesel", nivel1);
            nivel2 = CrearPermisos(Unidad, "Gasolina", "Gasolina", nivel1);
            nivel3 = CrearPermisos(Unidad, "Gasolina en Unidad", "GasolinaUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Medidores de Tanque", "MedidoresTanqueGasolina", nivel2);
            nivel3 = CrearPermisos(Unidad, "Agregar Pedido", "AgregarPedidoGasolina", nivel2);
            nivel2 = CrearPermisos(Unidad, "Modificacion Gasolina", "ModificacionGasolina", nivel1);
            nivel2 = CrearPermisos(Unidad, "Cálculo Cargos Gasolina", "CalculoCargosGasolina", nivel1);
            nivel2 = CrearPermisos(Unidad, "Medidores de Tanque", "MedidoresTanqueCombustible", nivel1);
            nivel2 = CrearPermisos(Unidad, "Recargas de Combustible", "RecargasCombustible", nivel1);
            nivel2 = CrearPermisos(Unidad, "Detalles de Candados", "DetallesCandados", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesCombustibles", nivel1);
            #endregion

            #region Guardias
            nivel1 = CrearPermisos(Unidad, "Guardias", "Guardias", null);
            nivel2 = CrearPermisos(Unidad, "Nuevo Reporte", "NuevoReporte", nivel1);
            nivel2 = CrearPermisos(Unidad, "Reportes", "ReportesIndiciplina", nivel1);
            nivel3 = CrearPermisos(Unidad, "Modificar Reporte", "ModificarReporte", nivel2);
            nivel3 = CrearPermisos(Unidad, "Imprimir Reporte", "ImprimirReporte", nivel2);
            nivel2 = CrearPermisos(Unidad, "Pedidos Diesel", "PedidosDieselGuardias", nivel1);
            nivel2 = CrearPermisos(Unidad, "Pedidos Gasolina", "PedidosGasolinaGuardias", nivel1);
            nivel2 = CrearPermisos(Unidad, "Nuevo Recibo", "NuevoRecibo", nivel1);
            nivel2 = CrearPermisos(Unidad, "Recibos", "RecibosPago", nivel1);
            nivel3 = CrearPermisos(Unidad, "Modificar Recibo", "ModificarRecibo", nivel2);
            nivel3 = CrearPermisos(Unidad, "Imprimir Recibo", "ImprimirRecibo", nivel2);
            nivel2 = CrearPermisos(Unidad, "Nuevo Contrato", "NuevoContrato", nivel1);
            nivel2 = CrearPermisos(Unidad, "Abonar Contrato", "AbonarContrato", nivel1);
            nivel2 = CrearPermisos(Unidad, "Entregar Unidad", "EntregarUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Recibir Unidad", "RecibirUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Contratos", "Contratos", nivel1);
            nivel3 = CrearPermisos(Unidad, "Cancelar Contrato", "CancelarContrato", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Contrato", "ModificarContrato", nivel2);
            nivel3 = CrearPermisos(Unidad, "Reimprimir Contrato", "ReimprimirContrato", nivel2);
            nivel3 = CrearPermisos(Unidad, "Generar Contrato", "GenerarContrato", nivel2);
            nivel2 = CrearPermisos(Unidad, "Unidades Disponibles", "UnidadesDisponibles", nivel1);
            nivel2 = CrearPermisos(Unidad, "Calendario Rentas", "CalendarioRentas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Historial Rentas", "HistorialRentas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Clientes", "Clientes", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Cliente", "NuevoClienteRenta", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Cliente", "ModificarClienteRenta", nivel2);
            nivel2 = CrearPermisos(Unidad, "Escaner Oficina", "EscanerOficina", nivel1);
            nivel2 = CrearPermisos(Unidad, "Escaner Guardias", "EscanerGuardias", nivel1);
            nivel2 = CrearPermisos(Unidad, "Unidades de Renta", "UnidadesRenta", nivel1);

            #endregion

            #region Configuracion
            nivel1 = CrearPermisos(Unidad, "Configuracion", "Configuracion", null);
            nivel2 = CrearPermisos(Unidad, "Departamento", "Departamento", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Departamento", "NuevoDepartamento", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Departamento", "ModificarDepartamento", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Departamento", "EliminarDepartamento", nivel2);
            nivel2 = CrearPermisos(Unidad, "Puesto", "Puesto", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Puesto", "NuevoPuesto", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Puesto", "ModificarPuesto", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Puesto", "EliminarPuesto", nivel2);
            nivel2 = CrearPermisos(Unidad, "Empresa", "Empresa", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Empresa", "NuevaEmpresa", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Empresa", "ModificarEmpresa", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Empresa", "EliminarEmpresa", nivel2);
            nivel2 = CrearPermisos(Unidad, "Tanques", "Tanques", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nuevo Tanque", "NuevoTanque", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Tanque", "ModificarTanque", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Tanque", "EliminarTanque", nivel2);
            nivel2 = CrearPermisos(Unidad, "Actualizar Esquemas", "ActualizarEsquemas", nivel1);
            nivel2 = CrearPermisos(Unidad, "Actualizar Permisos", "ActualizarPermisos", nivel1);
            #endregion

        }

        public static BarItemVisibility VisibilidadPermiso(string permiso)
        {
            if (ATRCBASE.BL.Utilerias.TienePermisos(permiso))
            {
                return BarItemVisibility.Always;
            }
            else
            {
                return BarItemVisibility.Never;
            }
        }

        public static bool TienePermisos(string Llave)
        {
            if (Utilerias.mUsuarioActual.NumEmpleado != 1034)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                //Revisa permiso por usuario
                //Usuario Usuario = Utilerias.ObtenerUsuarioActual(Unidad);

                DevExpress.Xpo.Metadata.XPClassInfo ClassPermiso = XpoDefault.Session.GetClassInfo(typeof(Permiso));
                DevExpress.Xpo.Metadata.XPClassInfo intermediateClass = ClassPermiso.GetMember("Usuarios").IntermediateClass;
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Usuarios.Oid", Utilerias.mUsuarioActual.Oid));
                go.Operands.Add(new BinaryOperator("Permisos.Llave", Llave));
                XPView Permisos = new XPView(Unidad, intermediateClass, "OID;Permisos.Llave;Usuarios.Oid", go);
                //Usuario.Permisos.Criteria = new BinaryOperator("Llave", Llave);
                //if (Usuario.Permisos.Count() > 0)
                //    return true;
                //else
                if (Permisos.Count > 0)
                    return true;
                else
                    return false;
            }else
            {
                return true;
            }
        }

        public static Permiso CrearPermisos(UnidadDeTrabajo Unidad, string Nombre, string Llave, Permiso Padre)
        {
            
            XPView Permisos = new XPView(Unidad, typeof(Permiso));
            Permisos.Properties.Add(new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true));
            Permisos.Criteria = CriteriaOperator.Parse("Llave = '" + Llave + "'");
            Permiso permiso;

            if (Permisos.Count > 0)
            {
                permiso = (Permiso)((ViewRecord)Permisos[0]).GetObject();
            }
            else
            {
                if (Permisos.Count == 0)
                {
                    permiso = new Permiso(Unidad);
                    permiso.Llave = Llave;
                }
                else
                {
                    throw new Exception("Llave repetida '" + ((Permiso)((ViewRecord)Permisos[0]).GetObject()).Llave + "'");
                }
            }
            permiso.Nombre = Nombre;
            permiso.PermisoPadre = Padre;
            permiso.Save();
            Unidad.CommitTransaction();
            return permiso;
        }

        private static String[] UNIDADES = { "", "un ", "dos ", "tres ", "cuatro ", "cinco ", "seis ", "siete ", "ocho ", "nueve " };
        private static String[] DECENAS = {"diez ", "once ", "doce ", "trece ", "catorce ", "quince ", "dieciseis ",
        "diecisiete ", "dieciocho ", "diecinueve", "veinte ", "treinta ", "cuarenta ",
        "cincuenta ", "sesenta ", "setenta ", "ochenta ", "noventa "};
        private static String[] CENTENAS = {"", "ciento ", "doscientos ", "trecientos ", "cuatrocientos ", "quinientos ", "seiscientos ",
        "setecientos ", "ochocientos ", "novecientos "};

        private static Regex r;

        public static String Convertir(String numero, bool mayusculas, string moneda = "PESOS")
        {

            String literal = "";
            String parte_decimal;
            //si el numero utiliza (.) en lugar de (,) -> se reemplaza
            numero = numero.Replace(".", ",");

            //si el numero no tiene parte decimal, se le agrega ,00
            if (numero.IndexOf(",") == -1)
            {
                numero = numero + ",00";
            }
            //se valida formato de entrada -> 0,00 y 999 999 999,00
            r = new Regex(@"\d{1,9},\d{1,2}");
            MatchCollection mc = r.Matches(numero);
            if (mc.Count > 0)
            {
                //se divide el numero 0000000,00 -> entero y decimal
                String[] Num = numero.Split(',');

                string MN = " M.N.";
                if (moneda != "PESOS")
                    MN = "";

                //de da formato al numero decimal
                parte_decimal = moneda + " " + Num[1] + "/100" + MN;
                //se convierte el numero a literal
                if (int.Parse(Num[0]) == 0)
                {//si el valor es cero
                    literal = "cero ";
                }
                else if (int.Parse(Num[0]) > 999999)
                {//si es millon
                    literal = getMillones(Num[0]);
                }
                else if (int.Parse(Num[0]) > 999)
                {//si es miles
                    literal = getMiles(Num[0]);
                }
                else if (int.Parse(Num[0]) > 99)
                {//si es centena
                    literal = getCentenas(Num[0]);
                }
                else if (int.Parse(Num[0]) > 9)
                {//si es decena
                    literal = getDecenas(Num[0]);
                }
                else
                {//sino unidades -> 9
                    literal = getUnidades(Num[0]);
                }
                //devuelve el resultado en mayusculas o minusculas
                if (mayusculas)
                {
                    return (literal + parte_decimal).ToUpper();
                }
                else
                {
                    return (literal + parte_decimal);
                }
            }
            else
            {//error, no se puede convertir
                return literal = null;
            }
        }

        /* funciones para convertir los numeros a literales */

        private static String getUnidades(String numero)
        {   // 1 - 9
            //si tuviera algun 0 antes se lo quita -> 09 = 9 o 009=9
            String num = numero.Substring(numero.Length - 1);
            return UNIDADES[int.Parse(num)];
        }

        private static String getDecenas(String num)
        {// 99
            int n = int.Parse(num);
            if (n < 10)
            {//para casos como -> 01 - 09
                return getUnidades(num);
            }
            else if (n > 19)
            {//para 20...99
                String u = getUnidades(num);
                if (u.Equals(""))
                { //para 20,30,40,50,60,70,80,90
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8];
                }
                else
                {
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8] + "y " + u;
                }
            }
            else
            {//numeros entre 11 y 19
                return DECENAS[n - 10];
            }
        }

        private static String getCentenas(String num)
        {// 999 o 099
            if (int.Parse(num) > 99)
            {//es centena
                if (int.Parse(num) == 100)
                {//caso especial
                    return " cien ";
                }
                else
                {
                    return CENTENAS[int.Parse(num.Substring(0, 1))] + getDecenas(num.Substring(1));
                }
            }
            else
            {//por Ej. 099
                //se quita el 0 antes de convertir a decenas
                return getDecenas(int.Parse(num) + "");
            }
        }

        private static String getMiles(String numero)
        {// 999 999
            //obtiene las centenas
            String c = numero.Substring(numero.Length - 3);
            //obtiene los miles
            String m = numero.Substring(0, numero.Length - 3);
            String n = "";
            //se comprueba que miles tenga valor entero
            if (int.Parse(m) > 0)
            {
                n = getCentenas(m);
                return n + "mil " + getCentenas(c);
            }
            else
            {
                return "" + getCentenas(c);
            }

        }

        private static String getMillones(String numero)
        { //000 000 000
            //se obtiene los miles
            String miles = numero.Substring(numero.Length - 6);
            //se obtiene los millones
            String millon = numero.Substring(0, numero.Length - 6);
            String n = "";
            if (millon.Length > 1)
            {
                n = getCentenas(millon) + "millones ";
            }
            else
            {
                n = getUnidades(millon) + "millon ";
            }
            return n + getMiles(miles);
        }

        public static void EnviarCorreo(string CorreoAutentificacion, string Host, string Contraseña, bool SSL, string Puerto, string Destinatario, string Mensaje, string Asunto)
        {
            MailMessage msg = new MailMessage();
            if (!string.IsNullOrWhiteSpace(Destinatario)) msg.To.Add(new MailAddress(Destinatario)); else throw new InvalidOperationException("El Destinatario no puede estar vacio");
            msg.Body = Mensaje;
            if (Mensaje.Replace(" ", "").Contains("<br/>") || Mensaje.Replace(" ", "").Contains("<b>") || Mensaje.Replace(" ", "").Contains("<p>") || Mensaje.Replace(" ", "").Contains("</a>") || Mensaje.Replace(" ", "").Contains("<table"))
                msg.IsBodyHtml = true;
            //}

            msg.From = new MailAddress(CorreoAutentificacion, "", System.Text.Encoding.UTF8);
            msg.Subject = Asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            // Configuración SMTP
            SmtpClient mailSmtp = new SmtpClient();
            mailSmtp.Host = Host;
            System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential(CorreoAutentificacion, Contraseña);
            mailSmtp.UseDefaultCredentials = false;
            mailSmtp.Credentials = mailAuthentication;
            mailSmtp.EnableSsl = SSL;
            mailSmtp.Port = Convert.ToInt32(Puerto);

            mailSmtp.Send(msg);
        }
        public static void EnviarCorreo(string Destinatario, string Mensaje, string Asunto, ArrayList cc, ArrayList cco)
        {
            #region Variables para configuracion
            string correoAutenticacionConfig = "";
            string correoAutenticacionPassConfig = "";
            string correoHostConfig = "";
            string correoHostPortConfig = "";
            bool habilitarSSLConfig = false;
            #endregion

            #region
            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Configuraciones = new XPView(Unidad, typeof(ATRCBASE.BL.Configuraciones), "Oid;Propiedad;Accion", null);
            Configuraciones.Criteria = new BinaryOperator("Propiedad", "CorreoAutentificacion");
            if (Configuraciones.Count > 0)
            {
                correoAutenticacionConfig = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Host");
            if (Configuraciones.Count > 0)
            {
                correoHostConfig = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Contraseña");
            if (Configuraciones.Count > 0)
            {
                correoAutenticacionPassConfig = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "SSL");
            if (Configuraciones.Count > 0)
            {
                habilitarSSLConfig = Convert.ToBoolean(Configuraciones[0]["Accion"].ToString());
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Puerto");
            if (Configuraciones.Count > 0)
            {
                correoHostPortConfig = Configuraciones[0]["Accion"].ToString();
            }
            #endregion


            MailMessage msg = new MailMessage();
            if (!string.IsNullOrWhiteSpace(Destinatario)) msg.To.Add(new MailAddress(Destinatario)); else throw new InvalidOperationException("El Destinatario no puede estar vacio");

            if (cc != null && cc.Count > 0)
            {
                foreach (string mail in cc)
                {
                    if (mail != "")
                        msg.CC.Add(new MailAddress(mail));
                }
            }

            if (cco != null && cco.Count > 0)
            {
                foreach (string mail in cco)
                {
                    if (mail != "")
                        msg.Bcc.Add(new MailAddress(mail));
                }
            }

            //if (attachments != null && attachments.Count > 0)
            //{
            //    foreach (object adjunto in attachments)
            //    {
            //        if (adjunto is byte[])
            //        {
            //            Stream documento = new MemoryStream((byte[])adjunto);
            //            System.Net.Mail.Attachment attachment;
            //            if (NombreArchivo.Contains(".zip"))
            //                attachment = new System.Net.Mail.Attachment(documento, NombreArchivo, System.Net.Mime.MediaTypeNames.Application.Zip);
            //            else
            //                attachment = new System.Net.Mail.Attachment(documento, NombreArchivo + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
            //            msg.Attachments.Add(attachment);
            //        }
            //        if (adjunto is string)
            //        {
            //            string path = Convert.ToString(adjunto);
            //            ArrayList mArray = new ArrayList(path.Split(new char[] { '&' }));
            //            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(mArray[0].ToString());
            //            if (mArray.Count > 1)
            //                attachment.Name = mArray[1].ToString() + mArray[0].ToString().Substring(mArray[0].ToString().LastIndexOf("."));
            //            msg.Attachments.Add(attachment);
            //        }
            //        if (adjunto is FileInfo)
            //        {
            //            FileInfo adj = adjunto as FileInfo;
            //            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(adj.FullName);
            //            msg.Attachments.Add(attachment);
            //        }
            //    }
            //}

            //if (config.LogoSistema != null && config.ExtensionLogo.Trim() != string.Empty)
            //{
            //    LinkedResource imagen = null;
            //    Stream stream = new MemoryStream(config.LogoSistema);
            //    if (stream != null)
            //    {
            //        imagen = new LinkedResource(stream);
            //        imagen.ContentType.Name = "Logo." + config.ExtensionLogo;
            //        imagen.ContentId = "Imagen1";
            //    }

            //    AlternateView av1 = AlternateView.CreateAlternateViewFromString("<br/>" + Mensaje + "<br/><br/>" + "<img src='cid:Imagen1'/>", null, MediaTypeNames.Text.Html);
            //    if (imagen != null)
            //        av1.LinkedResources.Add(imagen);
            //    msg.AlternateViews.Add(av1);
            //}
            //else
            //{
            msg.Body = Mensaje;
                if (Mensaje.Replace(" ", "").Contains("<br/>") || Mensaje.Replace(" ", "").Contains("<b>") || Mensaje.Replace(" ", "").Contains("<p>") || Mensaje.Replace(" ", "").Contains("</a>") || Mensaje.Replace(" ", "").Contains("<table"))
                    msg.IsBodyHtml = true;
            //}

            msg.From = new MailAddress(correoAutenticacionConfig, "", System.Text.Encoding.UTF8);
            msg.Subject = Asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            // Configuración SMTP
            SmtpClient mailSmtp = new SmtpClient();
            mailSmtp.Host = correoHostConfig;
            System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential(correoAutenticacionConfig, correoAutenticacionPassConfig);
            mailSmtp.UseDefaultCredentials = false;
            mailSmtp.Credentials = mailAuthentication;
            mailSmtp.EnableSsl = habilitarSSLConfig;
            mailSmtp.Port = Convert.ToInt32(correoHostPortConfig);

            mailSmtp.Send(msg);
        }
    }
}
