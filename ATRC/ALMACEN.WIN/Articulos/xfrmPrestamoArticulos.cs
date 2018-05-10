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
using System.Windows.Forms;

namespace ALMACEN.WIN
{
    public partial class xfrmPrestamoArticulos : xfrmBase
    {
        public xfrmPrestamoArticulos()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        public Usuario usuarioG;
        public Articulo ArticuloG;
        Usuario Usuario;

        public PrestamoArticulo prestamo;

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Usuario Usuarios = (Usuario)Unidad.FindObject(typeof(Usuario), new BinaryOperator("NumEmpleado", txtEmpleado.Text));
                usuarioG = Usuarios;
                if (Usuarios != null)
                {
                    xtPrestamos.Enabled = true;
                    txtCodigo1.Focus();
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Prestamo.Usuario.NumEmpleado", txtEmpleado.Text));
                    go.Operands.Add(new BinaryOperator("Entregado", false));
                    lblNombre.Text = Usuarios.Nombre;
                    XPCollection detallesP = new XPCollection(Unidad, typeof(DetallePrestamo), go);
                    grdEntregas.DataSource = detallesP;
                }
                else
                    XtraMessageBox.Show("Usuario no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (prestamo == null)
                {
                    prestamo = new PrestamoArticulo(Unidad);
                }
                DetallePrestamo Detalles = new DetallePrestamo(Unidad);
                Detalles.Articulo = ArticuloG;
                Detalles.Cantidad = int.Parse(txtCantidad.Text);
                Detalles.Fecha = DateTime.Now;
                prestamo.Usuario = usuarioG;

                Detalles.Save();
                prestamo.Detalles.Add(Detalles);
                prestamo.Save();

                grdPrestamos.DataSource = prestamo.Detalles;

                txtCantidad.ResetText();
                txtCodigo1.Focus();
                txtCodigo1.SelectAll();
            }


            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < txtCantidad.Text.Length; i++)
            {
                if (txtCantidad.Text[i] == '.')
                    IsDec = true;
                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
       

        private void xfrmPrestamoArticulos_Load_1(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            xtPrestamos.Enabled = false;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea regresar la herramineta seleccionada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int[] Detalles = gridView2.GetSelectedRows();

                foreach (int det in Detalles)
                {
                    DetallePrestamo DetaP = (DetallePrestamo)gridView2.GetRow(det);
                    DetaP.Entregado = true;
                    DetaP.Save();

                }
                Unidad.CommitChanges();
                ((XPCollection)grdEntregas.DataSource).Reload();
            }
        
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea guardar la lista de herramienta prestada?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Unidad.CommitChanges();
                xtPrestamos.Enabled = false;

                lblArticulo.ResetText();
                lblNombre.ResetText();
                txtCodigo1.ResetText();
                txtCantidad.ResetText();
                grdPrestamos.DataSource = null;
                txtEmpleado.Focus();
                xtPrestamos.Enabled = false;
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtCodigo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Articulo Articulos = (Articulo)Unidad.FindObject(typeof(Articulo), new BinaryOperator("Codigo", txtCodigo1.Text));
                ArticuloG = Articulos;
                if (Articulos != null)
                {
                    lblArticulo.Text = Articulos.Nombre;
                    txtCantidad.Focus();
                }
                else
                    XtraMessageBox.Show("Articulo no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (e.KeyChar == 27)
            {
                lblArticulo.ResetText();
                lblNombre.ResetText();
                txtCodigo1.ResetText();
                txtCantidad.ResetText();
                grdPrestamos.DataSource = null;
                txtEmpleado.Focus();
                xtPrestamos.Enabled = false;
            }

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnCodigo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xfrmBusquedaArticulos xfrm = new xfrmBusquedaArticulos();
            xfrm.Show();
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(xfrm.IDUsuario)));
                if (Usuario != null)
                {
                    txtEmpleado.Text = Usuario.NumEmpleado.ToString();
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtEmpleado.Text = lblNombre.Text = string.Empty;
                }
            }
            else
            {
                Usuario = null;
                txtEmpleado.Text = lblNombre.Text = string.Empty;
            }
        }
    }
}
