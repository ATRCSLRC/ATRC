using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
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
                    go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnProceso));
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
                        int Horas = (Entrega - f).Hours;
                        int Dias = (Entrega - f).Days;
                        decimal HoraDias = (Horas / 24) + (Dias);

                        decimal ExtraDia = 0;
                        decimal DiasTardes = 0;
                        int HorasTardes = 0;
                        int MediosDiasTarde = 0;
                        if (HoraDias > Contrato.DiasRenta)
                        {
                            DiasTardes = (Dias - Contrato.DiasRenta);
                           ExtraDia = Contrato.Costo * DiasTardes;
                           
                           if(Horas >= 12)
                            {
                                MediosDiasTarde = 1;
                                ExtraDia += Contrato.Costo / 2;
                                HorasTardes = Horas - 12;
                                ExtraDia += HorasTardes * 100;
                            }else
                            {
                                if (Horas > Contrato.TiempoTolerancia)
                                {
                                    ExtraDia += Horas * 100;
                                    HorasTardes = Horas;
                                }
                            }

                            string EntregaTarde = string.Empty;
                            if (DiasTardes >= 0)
                                EntregaTarde += Convert.ToInt32(DiasTardes) + " días";
                            if (MediosDiasTarde >= 0)
                                EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? " medio día " : " y medio";
                            if(HorasTardes >= 0)
                                EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? HorasTardes + " horas " : " con " + HorasTardes + " horas ";


                            memoComentario.Text = "La unidad se entrego " + EntregaTarde + "tarde."; 
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
            if (XtraMessageBox.Show("¿La unidad se encuantra en buen estado y se cubrieron los gatos de ser necesarios?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(Contrato != null)
                {
                    Contrato.EstadoContrato = Enums.EstadoContrato.Terminado;
                    Contrato.Recargos = Convert.ToDecimal(lblTotal.Text.TrimStart('$')) - Contrato.Subtotal;
                    Contrato.Subtotal = 0;
                    Contrato.Comentarios = memoComentario.Text;
                    Contrato.Save();
                    Contrato.Session.CommitTransaction();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
