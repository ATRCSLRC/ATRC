using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmConfiguracionesRutas : xfrmBase
    {
        public xfrmConfiguracionesRutas()
        {
            InitializeComponent();
        }

        static Regex MailRegex = new Regex(@"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$",
        RegexOptions.Compiled);

        private void xfrmConfiguracionesRutas_Load(object sender, EventArgs e)
        {
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            ATRCBASE.BL.Configuraciones ConfiguracionRecibir = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "RecibirCorreoSeguridad"));
            if (ConfiguracionRecibir != null)
                tknRecibir.EditValue = ConfiguracionRecibir.Accion;

            ATRCBASE.BL.Configuraciones ConfiguracionCodigoDesbloqueo = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "CodigoDesbloqueo"));
            if (ConfiguracionCodigoDesbloqueo != null)
                txtCodigo.EditValue = ConfiguracionCodigoDesbloqueo.Accion;

            ATRCBASE.BL.Configuraciones ConfiguracionActivarSeguridadModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ActivarSeguridadModificacion"));
            if (ConfiguracionActivarSeguridadModificacion != null)
                chkActivarSeguridad.EditValue = Convert.ToBoolean(ConfiguracionActivarSeguridadModificacion.Accion);

            ATRCBASE.BL.Configuraciones ConfiguracionDiasModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "DiasModificacion"));
            if (ConfiguracionDiasModificacion != null)
                spnDiasHabiles.EditValue = ConfiguracionDiasModificacion.Accion;

            ATRCBASE.BL.Configuraciones ConfiguracionEncargadosRutas = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "CorreosEncargadosRutas"));
            if (ConfiguracionEncargadosRutas != null)
                tknCorreosEncargados.EditValue = ConfiguracionEncargadosRutas.Accion;
        }

        private void tknRecibir_ValidateToken(object sender, DevExpress.XtraEditors.TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = MailRegex.IsMatch(e.Description);
        }

        private void tknRecibir_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TokenEdit editor = sender as DevExpress.XtraEditors.TokenEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "RecibirCorreoSeguridad"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "RecibirCorreoSeguridad";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit editor = sender as DevExpress.XtraEditors.TextEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "CodigoDesbloqueo"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "CodigoDesbloqueo";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void spnDiasHabiles_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SpinEdit editor = sender as DevExpress.XtraEditors.SpinEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "DiasModificacion"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "DiasModificacion";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void chkActivarSeguridad_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "ActivarSeguridadModificacion"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "ActivarSeguridadModificacion";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void tknCorreosEncargados_ValidateToken(object sender, DevExpress.XtraEditors.TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = MailRegex.IsMatch(e.Description);
        }

        private void tknCorreosEncargados_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TokenEdit editor = sender as DevExpress.XtraEditors.TokenEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "CorreosEncargadosRutas"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "CorreosEncargadosRutas";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }
    }
}
