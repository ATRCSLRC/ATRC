using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LLANTERA.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace LLANTERA.WIN
{
    public partial class xfrmLlantasParchadas : xfrmBase
    {
        public xfrmLlantasParchadas()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadTrabajo;
        private void xfrmLlantasParchadas_Load(object sender, EventArgs e)
        {
            UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Unidades = new XPView(UnidadTrabajo, typeof(Unidad), "Oid;Nombre;TipoUnidad", null);
            lueUnidad.Properties.DataSource = Unidades;
        }

        private void lueUnidad_EditValueChanged(object sender, EventArgs e)
        {
            if(lueUnidad.EditValue != null)
            {
                ViewRecord vUnidad = (ViewRecord)lueUnidad.EditValue;

                switch (vUnidad["TipoUnidad"])
                {
                    case Enums.TipoUnidad.Camion:
                        cmbCambioLlanta.Properties.Items.Clear();
                        cmbCambioLlanta.Properties.Items.Add("Llanta frontal chofer");
                        cmbCambioLlanta.Properties.Items.Add("Llanta frontal estribo");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera interior chofer");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera interior estribo");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera exterior chofer");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera exterior estribo");
                        break;
                    case Enums.TipoUnidad.Automovil:
                    case Enums.TipoUnidad.Maquinaria:
                    case Enums.TipoUnidad.Panel:
                        cmbCambioLlanta.Properties.Items.Clear();
                        cmbCambioLlanta.Properties.Items.Add("Llanta frontal chofer");
                        cmbCambioLlanta.Properties.Items.Add("Llanta frontal estribo");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera exterior chofer");
                        cmbCambioLlanta.Properties.Items.Add("Llanta trasera exterior estribo");
                        break;
                }
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                BitacoraLlantasParchadas.CrearRegistro(UnidadTrabajo, (Unidad)((ViewRecord)lueUnidad.EditValue).GetObject(), cmbCambioLlanta.Text, memoDescripcion.Text);
                UnidadTrabajo.CommitChanges();
                XtraMessageBox.Show("Se guardaron los cambios correctamente.");
                LimpiarControles();
            }
        }

        private bool ValidarCampos()
        {
            if (lueUnidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar la unidad.");
                return false;
            }

            if (string.IsNullOrEmpty(cmbCambioLlanta.Text))
            {
                XtraMessageBox.Show("Debe seleccionar la llanta.");
                return false;
            }
            return true;
        }
         
        private void LimpiarControles()
        {
            lueUnidad.EditValue = null;
            cmbCambioLlanta.Properties.Items.Clear();
            cmbCambioLlanta.Text = string.Empty;
            memoDescripcion.Text = string.Empty;
            lueUnidad.Focus();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de cancelar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                LimpiarControles();
            }
        }
    }
}
