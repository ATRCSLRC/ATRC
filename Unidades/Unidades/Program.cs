﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB.Exceptions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Unidad.BL;

namespace Unidades
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            //UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            
            //UserLookAndFeel.Default.SetSkinStyle("Office 2013 White");
             UserLookAndFeel.Default.SetSkinMaskColors(System.Drawing.Color.Red, System.Drawing.Color.Red);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            try
            {
                XpoDefault.ConnectionString = UtileriasXPO.CadenaDeConexion;
                UnidadDeTrabajo unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

                if (UtileriasXPO.BaseNueva(unidad))
                {
                    XtraMessageBox.Show("Se va actulizar el esquema de la base de datos.");
                    UtileriasXPO.ActualizarEsquema();
                    return;
                }
                if (Login())
                Application.Run(new xfrmUnidades());
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(SchemaCorrectionNeededException) || ex.GetType() == typeof(UnableToOpenDatabaseException))
                {
                    XtraMessageBox.Show("Se va actulizar el esquema de la base de datos.");
                    UtileriasXPO.ActualizarEsquema();
                }

            }
        }


        private static bool Login()
        {
            xfrmLogin xfrm = new xfrmLogin();
            xfrm.ShowDialog();
            if (xfrm.DialogResult != DialogResult.OK) return false;
            return true;
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception.GetType() == typeof(SchemaCorrectionNeededException))
            {
                XtraMessageBox.Show("Se requiere actualizar esquema.");
                UtileriasXPO.ActualizarEsquema();
            }


        }

    }
}
