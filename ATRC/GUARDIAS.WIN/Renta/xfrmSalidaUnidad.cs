using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class xfrmSalidaUnidad : xfrmBase
    {
        public xfrmSalidaUnidad()
        {
            InitializeComponent();
        }

        ContratoRenta Contrato;
        UnidadDeTrabajo Unidad;
        private void xfrmSalidaUnidad_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        }

        private void bbiRegistrarSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Contrato != null )
            {
                if (XtraMessageBox.Show("¿Está seguro de generar la entrega de la unidad?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    Contrato.HoraSalidaOriginal = DateTime.Now.TimeOfDay;
                    Contrato.DiaSalidaOriginal = DateTime.Now.Date;
                    Contrato.EstadoContrato = Enums.EstadoContrato.EnProceso;
                    Contrato.Save();
                    Contrato.Session.CommitTransaction();
                    XtraMessageBox.Show("Se ha generado la entrega de la unidad.");
                    LimpiarControles();
                }
            }else
            {
                XtraMessageBox.Show("Debe ingresar el número de contrato.");
                txtFolio.Focus();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtFolio.Text))
                {   
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("NumContrato", Convert.ToInt32(txtFolio.Text)));
                    go.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Creado));
                    go.Operands.Add(new BinaryOperator("Cancelado", false));
                    go.Operands.Add(new BinaryOperator("EsApartado", false));
                    Contrato = Unidad.FindObject<ContratoRenta>(go);
                    if (Contrato != null)
                    {
                        txtCliente.Text = Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre;
                        txtDestino.Text = Contrato.ADondeSeDirige;
                        txtUnidad.Text = Contrato.Unidad == null ? "" : Contrato.Unidad.Nombre;
                    }else
                    {
                        XtraMessageBox.Show("Este contrato no existe.");
                        txtCliente.Text = string.Empty;
                        txtDestino.Text = string.Empty;
                        txtUnidad.Text = string.Empty;
                    }
                }else
                {
                    XtraMessageBox.Show("Debe ingresar el número de contrato.");
                    txtFolio.Focus();
                }
            }
        }

        private void LimpiarControles()
        {
            txtFolio.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtDestino.Text = string.Empty;
            txtUnidad.Text = string.Empty;
            txtFolio.Focus();
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Contrato = null;
        }

    }
}
