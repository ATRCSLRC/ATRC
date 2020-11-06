using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmDetalleRecarga : xfrmBase
    {
        public xfrmDetalleRecarga()
        {
            InitializeComponent();
        }
        public RecargaDiesel Recarga;
        private void xfrmDetalleRecarga_Load(object sender, EventArgs e)
        {
            if(Recarga != null)
            {
                txtProveedor.Text = Recarga.Proveedor;
                spnCantidad.Value = Recarga.Cantidad;
                spnPrecio.Value = Convert.ToDecimal(Recarga.PrecioLitro);
                txtInicial.Text = Recarga.Lectura;
                txtFinal.Text = Recarga.LecturaFinal;
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validar())
            {
                Recarga.Proveedor = txtProveedor.Text;
                Recarga.Cantidad = spnCantidad.Value;
                Recarga.PrecioLitro = Convert.ToDouble(spnPrecio.Value);
                Recarga.Lectura = txtInicial.Text;
                if (!string.IsNullOrEmpty(txtFinal.Text))
                {
                    Recarga.LecturaFinal = txtFinal.Text;
                    Recarga.Total = Convert.ToDouble(Recarga.LecturaFinal) - Convert.ToDouble(Recarga.Lectura);
                }

                Recarga.Save();
                Recarga.Session.CommitTransaction();
                XtraMessageBox.Show("Se han guardado los cambios correctamente.");
                this.Close();
            }

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtProveedor.Text))
            {
                txtProveedor.Focus();
                XtraMessageBox.Show("Debe de asignar un proveedor.");
                return false;
            }

            if (spnCantidad.Value == 0)
            {
                spnPrecio.Focus();
                XtraMessageBox.Show("Debe agregar la cantidad.");
                return false;
            }

            if (spnPrecio.Value == 0)
            {
                spnPrecio.Focus();
                XtraMessageBox.Show("Debe agregar el precio.");
                return false;
            }

            if (string.IsNullOrEmpty(txtInicial.Text))
            {
                txtInicial.Focus();
                XtraMessageBox.Show("Debe agregar la lectura inicial.");
                return false;
            }

            //if (string.IsNullOrEmpty(txtFinal.Text))
            //{
            //    txtFinal.Focus();
            //    XtraMessageBox.Show("Debe agregar la lectura inicial.");
            //    return false;
            //}


            return true;
        }
    }
}
