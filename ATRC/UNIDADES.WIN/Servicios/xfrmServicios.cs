using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN
{
    public partial class xfrmServicios : xfrmBase
    {
        public xfrmServicios()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        Servicios Servicio;
        private void xfrmServicios_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Servicio = new Servicios(Unidad);
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); }));
            LigarControles();
        }

        private void IniciarControles()
        {
            XPView xpc = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", null);
            lueUnidad.Properties.DataSource = xpc;
            lueUnidad.Properties.DisplayMember = "Nombre";
            lueUnidad.Properties.BestFit();
            rgTipoServicio.Properties.Items.AddEnum(typeof(Enums.ServiciosUnidad));
            dteFecha.DateTime = DateTime.Now;
            lueUnidad.Focus();
        }

        private void LigarControles()
        {
            dteFecha.DataBindings.Add("EditValue", Servicio, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            rgTipoServicio.DataBindings.Add("EditValue", Servicio, "Servicio", true, DataSourceUpdateMode.OnPropertyChanged);
            memoDetalles.DataBindings.Add("EditValue", Servicio, "Detalles", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMillas.DataBindings.Add("EditValue", Servicio, "Millas", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool ValidarCampos()
        {

            if (lueUnidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar una unidad.");
                lueUnidad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(memoDetalles.Text))
            {
                XtraMessageBox.Show("Debe ingresar detalles.");
                memoDetalles.Focus();
                return false;
            }
            return true;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Servicio.Unidad = ((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject());
                    if ((Enums.ServiciosUnidad)rgTipoServicio.EditValue == Enums.ServiciosUnidad.CambioAceite)
                    {
                        Servicio.Unidad.Millas = txtMillas.Text;
                        Servicio.Unidad.UltimoCambioAceite = dteFecha.DateTime;
                    }
                    Servicio.Save();
                    Unidad.CommitChanges();
                    LimpiarControles();
                    LigarControles();
                    dteFecha.DateTime = DateTime.Now;
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void rgTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
           if((Enums.ServiciosUnidad)rgTipoServicio.EditValue == Enums.ServiciosUnidad.CambioAceite)
                lciMillas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciMillas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            txtMillas.Text = string.Empty;
        }

        private void LimpiarControles()
        {
            dteFecha.DataBindings.Clear();
            rgTipoServicio.DataBindings.Clear();
            memoDetalles.DataBindings.Clear();
            txtMillas.DataBindings.Clear();
            lueUnidad.EditValue = null;

            rgTipoServicio.SelectedIndex = 0;
            memoDetalles.Text = string.Empty;
            txtMillas.Text = string.Empty;
            lueUnidad.Focus();
            Servicio = new Servicios(Unidad);
        }
    }
}
