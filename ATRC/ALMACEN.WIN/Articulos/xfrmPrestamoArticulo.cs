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

namespace ALMACEN.WIN.Articulos
{
    public partial class xfrmPrestamoArticulo : xfrmBase
    {
        public xfrmPrestamoArticulo()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        Usuario Usuario;
        PrestamoArticulo Prestamo;
        private void xfrmPrestamoArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUsuario_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AvanzadaUsuario();
        }

        private void btnUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            if (e.KeyChar == 13)
            {
                Usuario Usuarios = (Usuario)Unidad.FindObject(typeof(Usuario), new BinaryOperator("NumEmpleado", btnUsuario.Text));
                if (Usuarios != null)
                {
                    Usuario = Usuarios;
                    lcgPrestar.Enabled = lcgEntregar.Enabled = true;
                    btnArticulo.Focus();
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Prestamo.Usuario.NumEmpleado", btnUsuario.Text));
                    go.Operands.Add(new BinaryOperator("Entregado", false));
                    lblUsuario.Text = Usuarios.Nombre;
                    XPView DetallesPrestamo = new XPView(Unidad, typeof(DetallePrestamo), "Oid;Articulo.Nombre;Fecha", go);
                    grdEntregasArticulos.DataSource = DetallesPrestamo;
                    lcgEntregar.Text = "Entregar artículos (" + DetallesPrestamo.Count + ")";
                    btnUsuario.Enabled = false;

                }
                else
                {
                    XtraMessageBox.Show("Usuario no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnUsuario.Enabled = true;
                    btnUsuario.Focus();
                }
            }
        }

        private void btnUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AvanzadaUsuario();
            }
        }

        private void btnArticulo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AvanzadaArticulo();
        }

        private void btnArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Articulo Articulo = (Articulo)Unidad.FindObject(typeof(Articulo), new BinaryOperator("Codigo", btnArticulo.Text));
                if (Articulo != null)
                {
                    if(Prestamo == null)
                        Prestamo = new PrestamoArticulo(Unidad);

                    DetallePrestamo Detalles = new DetallePrestamo(Unidad);
                    Detalles.Articulo = Articulo;
                    Detalles.Cantidad = 1;
                    Detalles.Fecha = DateTime.Now;
                    Prestamo.Usuario = Usuario;
                    Prestamo.Detalles.Add(Detalles);
                    Detalles.Save();
                    Prestamo.Save();

                    grdArticulos.DataSource = Prestamo.Detalles;
                    btnArticulo.Text = string.Empty;
                    btnArticulo.Focus();
            }
                else
                    XtraMessageBox.Show("Artículo no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AvanzadaArticulo();
            }
        }


        private void grvArticulos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            fypEdicion.ShowPopup();
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Eliminar":
                    DetallePrestamo Detalle = (DetallePrestamo)grvArticulos.GetFocusedRow();
                    if (Unidad != null)
                    {
                        if (XtraMessageBox.Show("¿Está seguro de querer eliminar el artículo '" + Detalle.Articulo.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Detalle.Delete();
                            fypEdicion.HidePopup();
                            btnArticulo.Focus();
                        }
                    }
                    break;
                case "Cerrar":
                    fypEdicion.HidePopup();
                    break;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea recibir y/o regresar herramienta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int[] Detalles = grvEntregasArticulos.GetSelectedRows();

                foreach (int det in Detalles)
                {
                    DetallePrestamo DetaP = (DetallePrestamo)((ViewRecord)grvEntregasArticulos.GetRow(det)).GetObject();
                    if (DetaP != null)
                    {
                        DetaP.Entregado = true;
                        DetaP.FechaEntrega = DateTime.Now;
                        DetaP.Save();
                    }

                }

                Unidad.CommitChanges();
                grdArticulos.DataSource = grdEntregasArticulos.DataSource = null;
                lcgPrestar.Enabled = lcgEntregar.Enabled = false;
                lcgEntregar.Text = "Entregar artículos";
                Prestamo = null;
                tabbedControlGroup1.SelectedTabPage = lcgPrestar;
                btnArticulo.Text = btnUsuario.Text = lblUsuario.Text = string.Empty;
                btnUsuario.Focus();
                btnUsuario.Enabled = true;
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUsuario.Enabled = true;
            btnUsuario.Focus();
            btnUsuario.Text = lblUsuario.Text = btnArticulo.Text = string.Empty;
            tabbedControlGroup1.SelectedTabPage = lcgPrestar;
            lcgPrestar.Enabled = lcgEntregar.Enabled = false;
            grdArticulos.DataSource = grdEntregasArticulos.DataSource = null;
            lcgEntregar.Text = "Entregar artículos";
            Prestamo = null;

        }

        private void HabilitarControles()
        {
            lcgPrestar.Enabled = lcgEntregar.Enabled = true;
            
        }

        private void AvanzadaUsuario()
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(xfrm.IDUsuario)));
                if (Usuario != null)
                {
                    btnUsuario.Text = Usuario.NumEmpleado.ToString();
                    Usuario Usuarios = (Usuario)Unidad.FindObject(typeof(Usuario), new BinaryOperator("NumEmpleado", btnUsuario.Text));
                    Usuario = Usuarios;
                    if (Usuarios != null)
                    {
                        lcgPrestar.Enabled = lcgEntregar.Enabled = true;
                        btnArticulo.Focus();
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Prestamo.Usuario.NumEmpleado", btnUsuario.Text));
                        go.Operands.Add(new BinaryOperator("Entregado", false));
                        lblUsuario.Text = Usuarios.Nombre;
                        XPView DetallesPrestamo = new XPView(Unidad, typeof(DetallePrestamo), "Oid;Articulo.Nombre;Fecha", go);
                        grdEntregasArticulos.DataSource = DetallesPrestamo;
                        lcgEntregar.Text = "Entregar artículos (" + DetallesPrestamo.Count + ")";
                        btnUsuario.Enabled = false;
                    }
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnUsuario.Text = lblUsuario.Text = string.Empty;
                    btnUsuario.Enabled = true;
                }
            }
            else
            {
                Usuario = null;
                btnUsuario.Text = lblUsuario.Text = string.Empty;
                btnUsuario.Enabled = true;
            }
        }

        private void AvanzadaArticulo()
        {
            xfrmBusquedaArticulos xfrm = new xfrmBusquedaArticulos();
            xfrm.Asignar = true;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (!string.IsNullOrEmpty(xfrm.Codigo))
            {
                Articulo Articulo = (Articulo)Unidad.FindObject(typeof(Articulo), new BinaryOperator("Codigo", xfrm.Codigo));
                if (Articulo != null)
                {
                    if (Prestamo == null)
                        Prestamo = new PrestamoArticulo(Unidad);

                    DetallePrestamo Detalles = new DetallePrestamo(Unidad);
                    Detalles.Articulo = Articulo;
                    Detalles.Cantidad = 1;
                    Detalles.Fecha = DateTime.Now;
                    Prestamo.Usuario = Usuario;
                    Prestamo.Detalles.Add(Detalles);
                    Detalles.Save();
                    Prestamo.Save();

                    grdArticulos.DataSource = Prestamo.Detalles;
                    btnArticulo.Text = string.Empty;
                    btnArticulo.Focus();
                }
            }
        }

        
    }
}
