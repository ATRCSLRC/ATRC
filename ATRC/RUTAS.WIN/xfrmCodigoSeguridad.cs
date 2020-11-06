using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmCodigoSeguridad : xfrmBase
    {
        public xfrmCodigoSeguridad()
        {
            InitializeComponent();
        }

        public string Accion;
        public RutasGeneradas Ruta;
        private void xfrmCodigoSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(ValidarCampo())
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    ATRCBASE.BL.Configuraciones ConfiguracionCodigoDesbloqueo = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "CodigoDesbloqueo"));
                    if (txtCodigo.Text == ConfiguracionCodigoDesbloqueo.Accion)
                    {
                        xfrmMotivoModificacion xfrm = new xfrmMotivoModificacion();
                        xfrm.Accion = Accion;
                        xfrm.Ruta = Ruta;
                        xfrm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("El código es incorrecto.");
                        txtCodigo.Focus();
                    }
                }
            }
        }

        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                XtraMessageBox.Show("Deben ingresar un motivo.");
                txtCodigo.Focus();
                return false;
            }

            return true;
        }
    }
}
