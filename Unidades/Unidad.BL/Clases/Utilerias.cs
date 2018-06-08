using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad.BL
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
        
        public static string sessionID = "";

        public static Usuario ObtenerUsuarioActual(UnidadDeTrabajo mUnidad)
        {
            return mUsuarioActual != null ? mUnidad.GetObjectByKey<Usuario>(mUsuarioActual.Oid) : null;
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

        public static string NombreUnidad(UnidadDeTrabajo Unidad, Enums.TipoUnidad TipoUnidad)
        {
            XPView Usuarios = new XPView(Unidad, typeof(Unidad));
            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Nombre", SortDirection.Descending, "[Nombre]", true, true)});
            Usuarios.SelectDeleted = true;

            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            if (Enums.TipoUnidad.Micro == TipoUnidad || Enums.TipoUnidad.Automovil == TipoUnidad)
            {
                go.Operands.Add(new BinaryOperator("TipoUnidad", Enums.TipoUnidad.Micro));
                go.Operands.Add(new BinaryOperator("TipoUnidad", Enums.TipoUnidad.Automovil));
            }
            else
                go.Operands.Add(new BinaryOperator("TipoUnidad", TipoUnidad));

            Usuarios.Criteria = go;
            switch(TipoUnidad)
            {
                case Enums.TipoUnidad.Automovil:
                case Enums.TipoUnidad.Micro:
                    if (Usuarios.Count <= 0)
                        return "M-28";
                    else
                        return "M-" + (Convert.ToInt32(Regex.Match((Usuarios[0]["Nombre"]).ToString(), @"\d+").Value.ToString()) + 1).ToString();
                case Enums.TipoUnidad.Camion:
                    if (Usuarios.Count <= 0)
                        return "C-329";
                    else
                        return "C-"+(Convert.ToInt32(Regex.Match((Usuarios[0]["Nombre"]).ToString(), @"\d+").Value.ToString()) + 1).ToString();
                case Enums.TipoUnidad.Panel:
                    if (Usuarios.Count <= 0)
                        return "P-121";
                    else
                        return "P-" + (Convert.ToInt32(Regex.Match((Usuarios[0]["Nombre"]).ToString(), @"\d+").Value.ToString()) + 1).ToString();
                case Enums.TipoUnidad.Maquinaria:
                    if (Usuarios.Count <= 0)
                        return "SP-21";
                    else
                        return "SP-" + (Convert.ToInt32(Regex.Match((Usuarios[0]["Nombre"]).ToString(), @"\d+").Value.ToString()) + 1).ToString();
            }
            return "";
        }
    }
}
