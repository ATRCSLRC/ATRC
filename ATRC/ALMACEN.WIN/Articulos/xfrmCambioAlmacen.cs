using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace ALMACEN.WIN
{
    public partial class xfrmCambioAlmacen : xfrmBase
    {
        public xfrmCambioAlmacen()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        Articulo Articulo;
        Usuario Usuario;
        #region Eventos
        
        private void xfrmSalidaArticulo_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            ActivarCampos(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void lueArticulo_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
                        btnUsuario.Focus();
                    }
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    UnidadDeTrabajo UnidadFactura = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Factura Factura = UnidadFactura.GetObjectByKey<Factura>(((ViewRecord)lueFactura.EditValue)["Oid"]);
                    Factura.Almacen = Factura.Almacen == 1 ? 2 : 1;
                    UnidadFactura.CommitChanges();

                    if (XtraMessageBox.Show("¿Desea generar comprobante de entrega?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Usuario UsuarioNombre = UnidadFactura.GetObjectByKey<Usuario>(Usuario.Oid);
                        REPORTES.Almacen.TicketCambioAlmacen Ticket = new REPORTES.Almacen.TicketCambioAlmacen(Factura, UsuarioNombre.NumEmpleado + " - " + UsuarioNombre.Nombre);

                        ReportPrintTool printTool = new ReportPrintTool(Ticket);
                        ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ImpresoraTicketsAlmacen"));
                        if (Configuracion != null)
                        {
                            Ticket.CreateDocument();
                            Ticket.PrinterName = Configuracion.Accion;
                            printTool.Print(Configuracion.Accion);
                        }
                    }


                    ActivarCampos(false);
                }
            }
        }

        private void btnUsuario_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnUsuario.Text))
                {
                    GroupOperator goUsuario = new GroupOperator(GroupOperatorType.And);
                    goUsuario.Operands.Add(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnUsuario.Text)));
                    goUsuario.Operands.Add(new BinaryOperator("Activo", true, BinaryOperatorType.Equal));
                    Usuario = Unidad.FindObject<Usuario>(goUsuario);
                    if (Usuario != null)
                    {
                        txtNombreUsuario.Text = Usuario.Nombre;
                        btnAceptar.Focus();
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombreUsuario.Text = string.Empty;
                    }
                }
                else
                {
                    txtNombreUsuario.Text = string.Empty;
                }
            }
        }

        private void btnUsuario_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                    txtNombreUsuario.Text = Usuario.Nombre;
                    btnUsuario.Text = Usuario.NumEmpleado.ToString();
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnUsuario.Text = txtNombreUsuario.Text = string.Empty;
                }
            }
            else
            {
                Usuario = null;
                btnUsuario.Text = txtNombreUsuario.Text = string.Empty;
            }
        }

        private void btnUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnUsuario.Text))
            {
                GroupOperator goUsuario = new GroupOperator(GroupOperatorType.And);
                goUsuario.Operands.Add(new BinaryOperator("NumEmpleado", Convert.ToInt32(btnUsuario.Text)));
                goUsuario.Operands.Add(new BinaryOperator("Activo", true, BinaryOperatorType.Equal));
                Usuario = Unidad.FindObject<Usuario>(goUsuario);
                if (Usuario != null)
                {
                    txtNombreUsuario.Text = Usuario.Nombre;
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombreUsuario.Text = string.Empty;
                }
            }
            else
            {
                txtNombreUsuario.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarCampos(false);

        }

        private void btnCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void btnCodigo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                btnAceptar.PerformClick();
                return true;
            }
            if (keyData == Keys.F6)
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
                return true;
            }
            if (keyData == Keys.F12)
            {
                btnCancelar.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Metodos
        private void ActivarCampos(bool Activar)
        {
            if (!Activar)
            {
                lueFactura.ReadOnly = true;
                btnUsuario.ReadOnly = true;
                btnCodigo.ReadOnly = false;
                btnBuscar.Enabled = true;
                btnCodigo.Focus();
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                Usuario = null;
                Articulo = null;
                lueFactura.EditValue = null;
                btnUsuario.Text = txtNombreUsuario.Text = string.Empty;
                btnCodigo.Text = string.Empty;
            }
            else
            {
                lueFactura.ReadOnly = false;
                btnUsuario.ReadOnly = false;
                btnCodigo.ReadOnly = true;
                btnBuscar.Enabled = false;
                lueFactura.Focus();
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;


            }
        }
        private void Buscar()
        {
            if (!string.IsNullOrEmpty(btnCodigo.Text))
            {
                Articulo = Unidad.FindObject<Articulo>(new BinaryOperator("Codigo", btnCodigo.Text));
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));
                go.Operands.Add(new BinaryOperator("Articulo.Codigo", btnCodigo.Text));
                XPView xpc = new XPView(Unidad, typeof(Factura), "Oid;Articulo.Nombre;Cantidad;NumParte;NumFactura;Fecha;Articulo.Codigo", go);
                if (xpc.Count > 0)
                {
                    lueFactura.Properties.DataSource = xpc;
                    lueFactura.Properties.DisplayMember = "Articulo.Nombre";
                    lueFactura.Properties.BestFit();
                    ActivarCampos(true);
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

            if (Usuario == null)
            {
                XtraMessageBox.Show("Debe de seleccionar un usuario.");
                btnUsuario.Focus();
                return false;
            }
            return true;
        }
        #endregion

        
    }
}
