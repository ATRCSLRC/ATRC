using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
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

namespace ALMACEN.WIN
{
    public partial class xfrmArticuloSalida : xfrmBase
    {
        public xfrmArticuloSalida()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        Articulo Articulo;
        public Factura Factura;
        public int Cantidad;
        public List<xfrmSalidaFactura.Articulo> Articulos;

        private void xfrmArticuloSalida_Load(object sender, EventArgs e)
        {

        }

        private void btnCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void btnCodigo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xfrmBusquedaArticulos xfrm = new xfrmBusquedaArticulos();
            xfrm.Asignar = true;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (!string.IsNullOrEmpty(xfrm.Codigo))
            {
                btnCodigo.Text = xfrm.Codigo;
                Buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void bbiAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Factura = ((Factura)((ViewRecord)lueFactura.EditValue).GetObject());
                Cantidad = Convert.ToInt32(spnCantidad.EditValue);
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Factura = null;
            this.Close();
        }

        private void lueFactura_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (((LookUpEdit)sender).EditValue != null)
                    {
                        ((LookUpEdit)sender).EditValue = null;
                    }
                    break;
                case Keys.Down:
                    if (((LookUpEdit)sender).EditValue != null)
                    {
                        ((LookUpEdit)sender).ShowPopup();
                    }
                    break;
                case Keys.Enter:
                    if (((LookUpEdit)sender).EditValue != null)
                    {
                        spnCantidad.Focus();
                        if (lueFactura.EditValue != null)
                            lblPrecio.Text = ((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Precio.ToString("c");
                    }
                    break;
            }
        }

        private void spnCantidad_EditValueChanged(object sender, EventArgs e)
        {
            if (lueFactura.EditValue != null)
                lblTotal.Text = (((SpinEdit)sender).Value * ((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Precio).ToString("c");
        }

        private void Buscar()
        {
            if (!string.IsNullOrEmpty(btnCodigo.Text))
            {
                //Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", btnCodigo.Text));
                //bool ExisteFactura = Articulos.Any(x => x.Codigo == btnCodigo.Text);

                //var a = Articulos.FirstOrDefault(x => x.Codigo == btnCodigo.Text);//(from c in Articulos where c.Codigo == btnCodigo.Text select c).Any();
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));
                go.Operands.Add(new BinaryOperator("Articulo.Codigo", btnCodigo.Text));
                //if(a != null)
                //    go.Operands.Add(new NotOperator(new BinaryOperator("Oid",((xfrmSalidaFactura.Articulo)a).Factura.Oid)));
                foreach(xfrmSalidaFactura.Articulo Articulo in Articulos)
                {
                    if(Articulo.Codigo == btnCodigo.Text)
                        go.Operands.Add(new NotOperator(new BinaryOperator("Oid", Articulo.Factura.Oid)));
                }
                XPView xpc = new XPView(Unidad, typeof(Factura), "Oid;Articulo.Nombre;Cantidad;Almacen;NumParte;NumFactura;Fecha;Articulo.Codigo", go);
                if (xpc.Count > 0)
                {
                    lueFactura.Properties.DataSource = xpc;
                    lueFactura.Properties.DisplayMember = "Articulo.Nombre";
                    lueFactura.Properties.BestFit();
                    ActivarCampos(true);
                    lueFactura.Focus();
                }
                else
                {
                    XtraMessageBox.Show("No existe este artículo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("El campo de código no puede estar vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (lueFactura.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar una factura.");
                lueFactura.Focus();
                return false;
            }

            if (spnCantidad.Value <= 0)
            {
                XtraMessageBox.Show("Debe ingresar una cantidad.");
                spnCantidad.Focus();
                return false;
            }

            if (((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Cantidad <= 0)
            {
                XtraMessageBox.Show("No hay en existencia el artículo seleccionado.");
                lueFactura.Focus();
                return false;
            }

            if (((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Cantidad < spnCantidad.Value)
            {
                XtraMessageBox.Show("La cantidad seleccionada es mayor al número de artículos en existencia.");
                spnCantidad.Focus();
                return false;
            }
            return true;
        }

        private void ActivarCampos(bool Activar)
        {
            lueFactura.Enabled = Activar;
            spnCantidad.Enabled = Activar;
            rpControl.Visible = Activar;
            this.Size = new System.Drawing.Size(786, 285);
        }
    }
}
