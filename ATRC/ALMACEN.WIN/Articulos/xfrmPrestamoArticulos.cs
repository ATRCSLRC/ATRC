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

        public PrestamoArticulo prestamo;

        private void xfrmPrestamoArticulos_Load(object sender, EventArgs e)
        {
            
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                    Usuario Usuarios = (Usuario)Unidad.FindObject(typeof(Usuario), new BinaryOperator("NumEmpleado", txtEmpleado.Text));
                    usuarioG = Usuarios;
                    if (Usuarios != null)
                    {
                        lblNombre.Text = Usuarios.Nombre;
                        XPCollection detallesP = new XPCollection(Unidad, typeof(DetallePrestamo), new BinaryOperator("Prestamo.Usuario.NumEmpleado", txtEmpleado.Text));
                        grdEntregas.DataSource = detallesP;
                    }
                    else
                        XtraMessageBox.Show("Usuario no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
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

                Detalles.Save();
                prestamo.Detalles.Add(Detalles);
                prestamo.Save();
                //Unidad.CommitChanges();

                grdPrestamos.DataSource = prestamo.Detalles;
            }
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Articulo Articulos = (Articulo)Unidad.FindObject(typeof(Articulo), new BinaryOperator("Codigo", txtCodigo.Text));
                ArticuloG = Articulos;
                if (Articulos != null)
                {
                    lblArticulo.Text = Articulos.Nombre;
                    txtCantidad.Focus();
                }
                else
                    XtraMessageBox.Show("Articulo no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void xfrmPrestamoArticulos_Load_1(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        }
    }
}
