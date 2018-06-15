using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmDetalleVenta : RibbonForm
    {
        public xfrmDetalleVenta()
        {
            InitializeComponent();
        }

        public Unidad.BL.Unidad UnidadCamion;
        public UnidadDeTrabajo Unidad;
        

        private void xfrmDetalleVenta_Load(object sender, EventArgs e)
        {
            cboTipoMoneda.Properties.Items.AddRange(typeof(Enums.TipoMoneda).GetEnumValues());
            cboFormaPago.Properties.Items.AddRange(typeof(Enums.FormaPago).GetEnumValues());
            cboTipoMoneda.SelectedIndex = 0;
            cboFormaPago.SelectedIndex = 0;
            dteFechaVenta.DateTime = DateTime.Now;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿La información proporcionada es correcta?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (UnidadCamion.DetalleVenta != null)
                    GuardarVenta(UnidadCamion.DetalleVenta);
                else
                    GuardarVenta((new Unidad.BL.DetalleVenta(Unidad)));
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void GuardarVenta(Unidad.BL.DetalleVenta Detalle)
        {
            Detalle.FechaVenta = dteFechaVenta.DateTime;
            Detalle.PrecioUnidad = spnCosto.Value;
            Detalle.Comprador = txtComprador.Text;
            Detalle.Destino = txtDestino.Text;
            Detalle.Direccion = txtDireccion.Text;
            Detalle.Tel = txtTel.Text;
            Detalle.CorreoElectronico = txtCorreo.Text;
            Detalle.EsCredito = chkCredito.Checked;
            Detalle.TipoMoneda = (Enums.TipoMoneda)cboTipoMoneda.EditValue;
            Detalle.FormaDePago = (Enums.FormaPago)cboFormaPago.EditValue;
            UnidadCamion.DetalleVenta = Detalle;
            UnidadCamion.Save();
            this.DialogResult = DialogResult.OK;
            Detalle.Save();
            Unidad.CommitChanges();
            this.Dispose();
        }

        private void xfrmDetalleVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
