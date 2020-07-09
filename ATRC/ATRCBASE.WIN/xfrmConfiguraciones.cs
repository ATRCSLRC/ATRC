using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmConfiguraciones : xfrmBase
    {
        public xfrmConfiguraciones()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;

        private void xfrmConfiguraciones_Load(object sender, EventArgs e)
        {
            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Configuraciones = new XPView(Unidad, typeof(ATRCBASE.BL.Configuraciones), "Oid;Propiedad;Accion", null);
            Configuraciones.Criteria = new BinaryOperator("Propiedad", "CorreoAutentificacion");
            if(Configuraciones.Count > 0)
            {
                txtCorreoAutentificacion.Text = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Host");
            if (Configuraciones.Count > 0)
            {
                txtHost.Text = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Contraseña");
            if (Configuraciones.Count > 0)
            {
                txtContraseñas.Text = Configuraciones[0]["Accion"].ToString();
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "SSL");
            if (Configuraciones.Count > 0)
            {
                chkSSL.Checked = Convert.ToBoolean(Configuraciones[0]["Accion"].ToString());
            }

            Configuraciones.Criteria = new BinaryOperator("Propiedad", "Puerto");
            if (Configuraciones.Count > 0)
            {
                txtPuerto.Text = Configuraciones[0]["Accion"].ToString();
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Correo autentificacion
            ATRCBASE.BL.Configuraciones ConfiguracionCorreo = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "CorreoAutentificacion"));
            if (ConfiguracionCorreo != null)
            {
                ConfiguracionCorreo.Accion = txtCorreoAutentificacion.Text;
            }
            else
            {
                ConfiguracionCorreo = new ATRCBASE.BL.Configuraciones(Unidad);
                ConfiguracionCorreo.Propiedad = "CorreoAutentificacion";
                ConfiguracionCorreo.Accion = txtCorreoAutentificacion.Text;
            }
            ConfiguracionCorreo.Save();
            #endregion

            #region Host
            ATRCBASE.BL.Configuraciones ConfiguracionHost = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "Host"));
            if (ConfiguracionHost != null)
            {
                ConfiguracionHost.Accion = txtHost.Text;
            }
            else
            {
                ConfiguracionHost = new ATRCBASE.BL.Configuraciones(Unidad);
                ConfiguracionHost.Propiedad = "Host";
                ConfiguracionHost.Accion = txtHost.Text;
            }
            ConfiguracionHost.Save();
            #endregion

            #region Contraseña
            ATRCBASE.BL.Configuraciones ConfiguracionContraseña = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "Contraseña"));
            if (ConfiguracionContraseña != null)
            {
                ConfiguracionContraseña.Accion = txtContraseñas.Text;
            }
            else
            {
                ConfiguracionContraseña = new ATRCBASE.BL.Configuraciones(Unidad);
                ConfiguracionContraseña.Propiedad = "Contraseña";
                ConfiguracionContraseña.Accion = txtContraseñas.Text;
            }
            ConfiguracionContraseña.Save();
            #endregion

            #region SSL
            ATRCBASE.BL.Configuraciones ConfiguracionSSL = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "SSL"));
            if (ConfiguracionSSL != null)
            {
                ConfiguracionSSL.Accion = chkSSL.Checked.ToString();
            }
            else
            {
                ConfiguracionSSL = new ATRCBASE.BL.Configuraciones(Unidad);
                ConfiguracionSSL.Propiedad = "SSL";
                ConfiguracionSSL.Accion = chkSSL.Checked.ToString();
            }
            ConfiguracionSSL.Save();
            #endregion

            #region Puerto
            ATRCBASE.BL.Configuraciones ConfiguracionPuerto = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "Puerto"));
            if (ConfiguracionPuerto != null)
            {
                ConfiguracionPuerto.Accion = txtPuerto.Text;
            }
            else
            {
                ConfiguracionPuerto = new ATRCBASE.BL.Configuraciones(Unidad);
                ConfiguracionPuerto.Propiedad = "Puerto";
                ConfiguracionPuerto.Accion = txtPuerto.Text;
            }
            ConfiguracionPuerto.Save();
            #endregion
            Unidad.CommitChanges();
            this.Close();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnEnvioCorreo_Click(object sender, EventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Probar envio de correo";
            args.Prompt = "Destinatario:";
            TextEdit editor = new TextEdit();
            args.Editor = editor;
            var result = XtraInputBox.Show(args);
            if (result != null)
            {
                Utilerias.EnviarCorreo(txtCorreoAutentificacion.Text, txtHost.Text, txtContraseñas.Text, chkSSL.Checked, txtPuerto.Text, result.ToString(), "Prueba de configuración de correo", "Prueba de configuración");
            }
        }
    }
}
