using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            #endregion

            #region Unidades
            nivel1 = CrearPermisos(Unidad, "Unidades", "Unidades", null);
            nivel2 = CrearPermisos(Unidad, "Nueva Unidad", "NuevaUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Detalles de Unidad", "DetallesDeUnidad", nivel1);
            nivel3 = CrearPermisos(Unidad, "Detalle de Unidad", "DetallesUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Unidad", "ModificarUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Unidad", "EliminarUnidad", nivel2);
            nivel2 = CrearPermisos(Unidad, "Servicios Unidad", "ServiciosUnidad", nivel1);
            nivel2 = CrearPermisos(Unidad, "Radios", "Radios", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Radio", "NuevaRadio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Radio", "ModificarRadio", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Radio", "EliminarRadio", nivel2);
            nivel2 = CrearPermisos(Unidad, "Proximos cambios de aceite", "ProximosCambiosAceite", nivel1);
            nivel2 = CrearPermisos(Unidad, "Extintores", "Extintores", nivel1);
            nivel3 = CrearPermisos(Unidad, "Nueva Extintor", "NuevaExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Modificar Extintor", "ModificarExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Eliminar Extintor", "EliminarExtintor", nivel2);
            nivel3 = CrearPermisos(Unidad, "Exportar Extintor", "ExportarExtintor", nivel2);
            nivel2 = CrearPermisos(Unidad, "Inventario de Extintores", "InventarioExtintores", nivel1);
            nivel3 = CrearPermisos(Unidad, "Revisar Extintor", "RevisarExtintor", nivel2);
            nivel2 = CrearPermisos(Unidad, "Historial de Extintores", "HistorialExtintores", nivel1);
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
            nivel2 = CrearPermisos(Unidad, "Gasolina", "Gasolina", nivel1);
            nivel3 = CrearPermisos(Unidad, "Gasolina en Unidad", "GasolinaUnidad", nivel2);
            nivel3 = CrearPermisos(Unidad, "Medidores de Tanque", "MedidoresTanqueGasolina", nivel2);
            nivel3 = CrearPermisos(Unidad, "Agregar Pedido", "AgregarPedidoGasolina", nivel2);
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
    }
}
