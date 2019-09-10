using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN
{
    public partial class xfrmRecibos : xfrmBase
    {
        public xfrmRecibos()
        {
            InitializeComponent();
        }
        public bool EsModificacion = false;
        public Recibos Recibo = null;
        private void xfrmRecibos_Load(object sender, EventArgs e)
        {
            dteFecha.DateTime = DateTime.Now;
            BeginInvoke(new MethodInvoker(delegate { spnPrecio.Focus(); }));
            if (EsModificacion)
            {
                bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                Modificacion();
            }
        }

        #region Eventos
        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (EsModificacion)
            {
                if (ValidarCampos())
                {
                    if (XtraMessageBox.Show("¿Desea actualizar la información proporcionada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string PrecioEscrito = string.Empty;
                        if (rgTipoCambio.SelectedIndex == 0)
                            PrecioEscrito = Utilerias.Convertir(spnPrecio.Text.Remove(0, 1).Replace(",", ""), true, "PESOS");
                        else
                            PrecioEscrito = Utilerias.Convertir(spnPrecio.Text.Remove(0, 1).Replace(",", ""), true, "dólares");
                        
                        Recibo.Precio = Convert.ToDecimal(spnPrecio.EditValue);
                        Recibo.Emisor = txtEmisor.Text;
                        Recibo.Concepto = memoConcepto.Text;
                        Recibo.Fecha = dteFecha.DateTime;
                        Recibo.TipoCambio = rgTipoCambio.SelectedIndex == 0 ? "Pesos" : "Dólares";
                        Recibo.PrecioEscrito = PrecioEscrito;
                        Recibo.Save();
                        Recibo.Session.CommitTransaction();
                        this.Close();
                        ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(Recibo.Oid));
                        reprecibo.ShowPreview();
                    }
                }
            }
            else
            {
                if (ValidarCampos())
                {
                    if (XtraMessageBox.Show("¿Desea guardar la información proporcionada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string PrecioEscrito = string.Empty;
                        if (rgTipoCambio.SelectedIndex == 0)
                            PrecioEscrito = Utilerias.Convertir(spnPrecio.Text.Remove(0, 1).Replace(",", ""), true, "PESOS");
                        else
                            PrecioEscrito = Utilerias.Convertir(spnPrecio.Text.Remove(0, 1).Replace(",", ""), true, "dólares");
                        UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                        Recibos Recibo = new Recibos(Unidad);
                        Recibo.Folio = FolioRecibo(Unidad);
                        Recibo.Precio = Convert.ToDecimal(spnPrecio.EditValue);
                        Recibo.Emisor = txtEmisor.Text;
                        Recibo.Concepto = memoConcepto.Text;
                        Recibo.Fecha = dteFecha.DateTime;
                        Recibo.TipoCambio = rgTipoCambio.SelectedIndex == 0 ? "Pesos" : "Dólares";
                        Recibo.PrecioEscrito = PrecioEscrito;
                        Recibo.Save();
                        Unidad.CommitChanges();
                        LimpiarCampos();
                        ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(Recibo.Oid));
                        reprecibo.ShowPreview();
                    }
                }
            }

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        private void memoConcepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bbiGuardar.PerformClick();
        }

        #endregion

        #region Metodos
        private void LimpiarCampos()
        {
            dteFecha.DateTime = DateTime.Now;
            rgTipoCambio.SelectedIndex = 0;
            spnPrecio.EditValue = 0.00;
            txtEmisor.Text = string.Empty;
            memoConcepto.Text = string.Empty;
            spnPrecio.Focus();
        }

        private bool ValidarCampos()
        {
            if (Convert.ToDecimal(spnPrecio.EditValue) <= 0)
            {
                XtraMessageBox.Show("Debe agregar un precio.");
                spnPrecio.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEmisor.Text))
            {
                XtraMessageBox.Show("Debe agregar un precio.");
                txtEmisor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(memoConcepto.Text))
            {
                XtraMessageBox.Show("Debe agregar un concepto.");
                memoConcepto.Focus();
                return false;
            }

            return true;
        }

        private void Modificacion()
        {
            dteFecha.DateTime = Recibo.Fecha;
            spnPrecio.EditValue = Recibo.Precio;
            txtEmisor.Text = Recibo.Emisor;
            memoConcepto.Text = Recibo.Concepto;
            rgTipoCambio.SelectedIndex = Recibo.TipoCambio == "Pesos" ? 0 : 1;
        }

        public int FolioRecibo(UnidadDeTrabajo Unidad)
        {

            XPView Usuarios = new XPView(Unidad, typeof(Recibos));

            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Folio", SortDirection.Descending, "[Folio]", true, true)});
            Usuarios.SelectDeleted = true;
            if (Usuarios.Count <= 0)
                return 123;
            else
            {
                if (Convert.ToInt32(Usuarios[0]["Folio"]) == 0)
                    return 123;
                return (Convert.ToInt32(Usuarios[0]["Folio"]) + 1);
            }

                
        }

        #endregion
    }
}
