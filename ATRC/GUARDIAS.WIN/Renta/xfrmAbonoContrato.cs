using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
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

namespace GUARDIAS.WIN.Renta
{
    public partial class xfrmAbonoContrato : xfrmBase
    {
        public xfrmAbonoContrato()
        {
            InitializeComponent();
        }
        ContratoRenta Contrato;
        UnidadDeTrabajo Unidad;
        private void xfrmAbonoContrato_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        }

        private void bbiAbonar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarControles();
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtContrato.Text))
                {
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("NumContrato", Convert.ToInt32(txtContrato.Text)));
                    //go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Creado));
                    go.Operands.Add(new BinaryOperator("Cancelado", false));
                    Contrato = Unidad.FindObject<ContratoRenta>(go);
                    if (Contrato != null)
                    {
                        txtCliente.Text = Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre;
                        txtDestino.Text = Contrato.ADondeSeDirige;
                        txtUnidad.Text = Contrato.Unidad == null ? "" : Contrato.Unidad.Nombre;
                        lblTotal.Text = Contrato.Subtotal == 0 ? 0.ToString("C") : (Contrato.Subtotal - Contrato.Abono).ToString("c");
                        //lcgTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lciDetallesRenta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    }
                    else
                    {
                        XtraMessageBox.Show("Este contrato no existe.");
                        txtCliente.Text = string.Empty;
                        txtDestino.Text = string.Empty;
                        txtUnidad.Text = string.Empty;
                        lblTotal.Text = "$0.00";
                        //lcgTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciDetallesRenta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Debe ingresar el número de contrato.");
                    txtContrato.Focus();
                }
            }
        }

        private void LimpiarControles()
        {
            txtContrato.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtDestino.Text = string.Empty;
            txtUnidad.Text = string.Empty;
            lblTotal.Text = "$0.00";
            txtContrato.Focus();
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Contrato = null;
            //lcgTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciDetallesRenta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private bool Validar()
        {
            if(Contrato is null)
            {
                XtraMessageBox.Show("Debe agregar un contrato.");
                txtContrato.Focus();
                return false;
            }

            if(spnCantidad.Value < 0)
            {
                XtraMessageBox.Show("Debe de agregar una importe abonar.");
                return false;
            }

            decimal Abonos = Contrato.Abono + Convert.ToDecimal(spnCantidad.Value); 
            if(Abonos > Contrato.Subtotal)
            {
                XtraMessageBox.Show("El importe que desea abonar es mayor a la cantidad que se debe.");
                return false;
            }

            return true;
        }


        private void Guardar()
        {
            if (Validar())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Contrato.Abono += spnCantidad.Value;
                    Contrato.Subtotal -= Contrato.Abono;
                    Contrato.Save();
                    Contrato.Session.CommitTransaction();
                    string PrecioEscrito = string.Empty;
                    PrecioEscrito = Utilerias.Convertir(spnCantidad.Value.ToString()/*spnCantidad.Text.Remove(0, 1).Replace(",", "")*/, true, "PESOS");
                    int ID = 0;
                    string textoAbono = "Abono a renta de unidad " + Contrato.Unidad.Nombre + " para el día " + Contrato.DiaSalida.ToLongDateString() + " a las " + new DateTime(Contrato.HoraSalida.Ticks).ToShortTimeString() + " por " + Contrato.DiasRenta.ToString("n1") + " días con destino a ";
                    textoAbono += Contrato.ADondeSeDirige + "Contrato: " + Contrato.NumContrato;
                    string textoPagado = "Se saldo la renta de la unidad " + Contrato.Unidad.Nombre + " para el día " + Contrato.DiaSalida.ToLongDateString() + " a las " + new DateTime(Contrato.HoraSalida.Ticks).ToShortTimeString() + " por " + Contrato.DiasRenta.ToString("n1") + " días con destino a ";
                    textoPagado += Contrato.ADondeSeDirige + "Contrato: " + Contrato.NumContrato;
                    Recibos.GenerarRecibo(Unidad, spnCantidad.Value, Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre, Contrato.Subtotal <= 0 ? textoPagado : textoAbono , DateTime.Now, "Pesos", PrecioEscrito, out ID);
                    this.Close();
                    ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(ID));
                    reprecibo.ShowPreview();
                }
            }
        }
        private void spnCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guardar();
            }
        }
    }
}
