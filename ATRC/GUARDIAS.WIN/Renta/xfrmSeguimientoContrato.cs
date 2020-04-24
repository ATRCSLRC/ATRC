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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN.Renta
{
    public partial class xfrmSeguimientoContrato : xfrmBase
    {
        public xfrmSeguimientoContrato()
        {
            InitializeComponent();
        }
        ContratoRenta Contrato;
        UnidadDeTrabajo Unidad;
        private void xfrmSeguimientoContrato_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNumContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                if (!string.IsNullOrEmpty(txtNumContrato.Text))
                {
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("NumContrato", Convert.ToInt32(txtNumContrato.Text)));
                    go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnViaje));
                    go.Operands.Add(new BinaryOperator("Cancelado", false));
                    go.Operands.Add(new BinaryOperator("EsApartado", false));
                    Contrato = Unidad.FindObject<ContratoRenta>(go);
                    if (Contrato != null)
                    {
                        txtCliente.Text = Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre;
                        txtDestino.Text = Contrato.ADondeSeDirige;
                        txtUnidad.Text = Contrato.Unidad == null ? "" : Contrato.Unidad.Nombre;
                        lblTotal.Text = Contrato.Subtotal.ToString("c");//(Contrato.Subtotal - Contrato.Abono).ToString("c");
                        tmeRegreso.EditValue = DateTime.Now;
                        var dateTime = new DateTime(Contrato.HoraSalidaOriginal.Ticks);
                        lblDetalleEntrega.Text = "Se entrego la unidad el " + Contrato.DiaSalidaOriginal.ToShortDateString() + " a las " +
                            dateTime.ToString("hh:mm tt", CultureInfo.InvariantCulture);

                        DateTime Entrega = DateTime.Now;
                        Contrato.HoraRegresoOriginal = Entrega.TimeOfDay;
                        Contrato.DiaRegresoOriginal = Entrega.Date;
                        var f = Contrato.DiaSalidaOriginal.Add(Contrato.HoraSalidaOriginal);
                        decimal Horas = (Entrega - f).Hours;
                        decimal Dias = (Entrega - f).Days;
                        decimal HoraDias = (Horas / 24) + (Dias);
                        decimal DiasExtra = 0;
                        decimal ExtraDia = 0;
                        int MediosDiasTarde = 0;
                        decimal HorasTardes = 0;

                        if (HoraDias >= Contrato.DiasRenta)
                        {

                            if ((HoraDias - Contrato.DiasRenta) > 1)
                            {
                                DiasExtra = (Dias - Contrato.DiasRenta);
                                ExtraDia = Contrato.Costo * DiasExtra;
                            }
                            else if (Contrato.DiasRenta.ToString().Contains(".5"))
                            {
                                Horas -= 12;
                            }

                            if (Horas >= 19 & Horas <= 24)
                            {
                                DiasExtra += 1;
                                ExtraDia += DiasExtra * Contrato.Costo;
                                Horas -= 24;
                            }


                            if (Horas >= 7 & Horas <= 18)
                            {
                                MediosDiasTarde = 1;
                                ExtraDia += Contrato.Costo / 2;
                                Horas -= 12;
                            }

                            if (Horas >= 1 & Horas <= 6 & Horas >= Contrato.TiempoTolerancia)
                            {
                                ExtraDia += Horas * Contrato.CostoTolerancia;
                                HorasTardes = Horas;
                            }


                            string EntregaTarde = string.Empty;
                            if (DiasExtra > 0)
                                EntregaTarde += DiasExtra.ToString("n1") + " día(s)";
                            if (MediosDiasTarde > 0)
                                EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? " medio día " : " y medio";
                            if (HorasTardes > 0)
                                EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? HorasTardes + " hora(s) " : " con " + HorasTardes + " hora(s) ";

                            if (!string.IsNullOrEmpty(EntregaTarde))
                                memoComentario.Text = "La unidad se entrego " + EntregaTarde + " tarde.";
                        }
                        lblTotal.Text = (Contrato.Subtotal + ExtraDia).ToString("c");
                    }
                    else
                    {
                        XtraMessageBox.Show("Este contrato no existe.");
                        txtCliente.Text = string.Empty;
                        txtDestino.Text = string.Empty;
                        txtUnidad.Text = string.Empty;
                        lblTotal.Text = "$0.00";
                    }
                }
                else
                {
                    XtraMessageBox.Show("Debe ingresar el número de contrato.");
                    txtNumContrato.Focus();
                }
            }
        }

        private void bbiRegreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿La unidad se encuentra en buen estado y se cubrieron los gatos de ser necesarios?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(Contrato != null)
                {
                    Contrato.EstadoContrato = Enums.EstadoContrato.Terminado;
                    Contrato.Recargos = Convert.ToDecimal(lblTotal.Text.TrimStart('$')) - Contrato.Subtotal;
                    Contrato.Subtotal = 0;
                    Contrato.Comentarios = memoComentario.Text;
                    Contrato.Save();
                    Contrato.Session.CommitTransaction();
                    if (Convert.ToDecimal(lblTotal.Text.TrimStart('$')) > 0)
                    {
                        if (Contrato.Iva <= 0)
                        {
                            string PrecioEscrito = string.Empty;
                            PrecioEscrito = Utilerias.Convertir(Convert.ToDecimal(lblTotal.Text.TrimStart('$')).ToString(), true, "PESOS");
                            int ID = 0;
                            string textoPagado = "Se saldo la renta de la unidad " + Contrato.Unidad.Nombre + " con contrato " + Contrato.NumContrato + ". " + Contrato.Comentarios;
                            Recibos.GenerarRecibo(Unidad, Convert.ToDecimal(lblTotal.Text.TrimStart('$')), Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre, textoPagado, DateTime.Now, "Pesos", PrecioEscrito, out ID);
                            this.Close();
                            ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(ID));
                            reprecibo.ShowPreview();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
