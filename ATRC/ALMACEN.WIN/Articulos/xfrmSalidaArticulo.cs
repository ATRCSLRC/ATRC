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
using UNIDADES.BL;

namespace ALMACEN.WIN
{
    public partial class xfrmSalidaArticulo : xfrmBase
    {
        public xfrmSalidaArticulo()
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
            XPView Usuarios = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", null);
            lueUnidad.Properties.DataSource = Usuarios;
            lueUnidad.Properties.DisplayMember = "Nombre";
            lueUnidad.Properties.BestFit();
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
                        spnCantidad.Focus();
                        if (lueFactura.EditValue != null)
                            lblPrecioUnitario.Text = ((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Precio.ToString("c");
                    }
                    break;
            }
        }

        private void spnCantidad_EditValueChanged(object sender, EventArgs e)
        {
            if (lueFactura.EditValue != null)
                lblTotal.Text = (((SpinEdit)sender).Value * ((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Precio).ToString("c");
        }

        private void rgDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((RadioGroup)sender).SelectedIndex == 0)
            {
                lciOtroDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciOtroDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void rgRecibo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioGroup)sender).SelectedIndex == 0)
            {
                lciOtroRecibo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciNombreUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciOtroRecibo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNombreUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void spnCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rgDestino.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    UnidadDeTrabajo UnidadSalida = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    SalidaArticulo Salida = new SalidaArticulo(UnidadSalida);
                    Salida.Articulo = UnidadSalida.GetObjectByKey<Articulo>(Articulo.Oid);
                    Salida.Factura = UnidadSalida.GetObjectByKey<Factura>(((ViewRecord)lueFactura.EditValue)["Oid"]);//((Factura)((ViewRecord)lueFactura.EditValue).GetObject());
                    Salida.Cantidad = Convert.ToDecimal(spnCantidad.Value);
                    if (rgDestino.SelectedIndex == 0)
                    {
                        Salida.TipoDestino = Enums.Destino.Unidad;
                        Unidad UnidadCamion = UnidadSalida.GetObjectByKey<Unidad>(((ViewRecord)lueUnidad.EditValue)["Oid"]);
                        Salida.SetMemberValue("Unidad", UnidadCamion);
                        //((XPCollection)((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject()).GetMemberValue("Salidas")).Add(Salida);
                    }
                    else
                    {
                        Salida.TipoDestino = Enums.Destino.Otro;
                        Salida.OtroDestino = txtOtroDestino.Text;
                    }

                    if (rgRecibo.SelectedIndex == 0)
                    {
                        Salida.TipoRecibo = Enums.Recibo.Usuario;
                        Salida.UsuarioRecibo = UnidadSalida.GetObjectByKey<Usuario>(Usuario.Oid);
                    }
                    else
                    {
                        Salida.TipoRecibo = Enums.Recibo.Otro;
                        Salida.OtroRecibo = txtOtroRecibo.Text;
                    }
                    //Unidad unidad = Unidad.GetObjectByKey<Unidad>(1);
                    //((XPCollection)Salida.GetMemberValue("Unidades")).Add(unidad);
                    //unidad.Save();
                    Salida.Estado = Enums.EstadoSalida.Entregado;
                    Salida.Fecha = DateTime.Now.Date;
                    Salida.Factura.Cantidad -= Convert.ToDecimal(spnCantidad.Value);
                    Salida.Factura.Save();
                    Salida.Save();
                    UnidadSalida.CommitChanges();
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
                spnCantidad.ReadOnly = true;
                rgDestino.ReadOnly = true;
                rgRecibo.ReadOnly = true;
                lueUnidad.ReadOnly = true;
                txtOtroDestino.ReadOnly = true;
                txtOtroRecibo.ReadOnly = true;
                btnUsuario.ReadOnly = true;
                btnCodigo.ReadOnly = false;
                btnBuscar.Enabled = true;
                btnCodigo.Focus();
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                Usuario = null;
                Articulo = null;
                lueFactura.EditValue = lueUnidad.EditValue = null;
                spnCantidad.Value = 0;
                rgDestino.SelectedIndex = 0;
                rgRecibo.SelectedIndex = 0;
                txtOtroDestino.Text = txtOtroRecibo.Text = string.Empty;
                lblTotal.Text = lblPrecioUnitario.Text = string.Empty;
                btnUsuario.Text = txtNombreUsuario.Text = string.Empty;
                btnCodigo.Text = string.Empty;
            }
            else
            {
                lueFactura.ReadOnly = false;
                spnCantidad.ReadOnly = false;
                rgDestino.ReadOnly = false;
                rgRecibo.ReadOnly = false;
                lueUnidad.ReadOnly = false;
                txtOtroDestino.ReadOnly = false;
                txtOtroRecibo.ReadOnly = false;
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

            if (spnCantidad.Value <= 0)
            {
                XtraMessageBox.Show("Debe ingresar una cantidad.");
                spnCantidad.Focus();
                return false;
            }

            if (rgDestino.SelectedIndex == 0)
            {
                if (lueUnidad.EditValue == null)
                {
                    XtraMessageBox.Show("Debe de seleccionar una unidad de destino.");
                    lueUnidad.Focus();
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtOtroDestino.Text))
                {
                    XtraMessageBox.Show("Debe de agregar una descripción al campo de otro destino.");
                    txtOtroDestino.Focus();
                    return false;
                }
            }

            if (rgRecibo.SelectedIndex == 0)
            {
                if (Usuario == null)
                {
                    XtraMessageBox.Show("Debe de seleccionar un usuario.");
                    btnUsuario.Focus();
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtOtroRecibo.Text))
                {
                    XtraMessageBox.Show("Debe de agregar una descripción al campo de otro.");
                    txtOtroRecibo.Focus();
                    return false;
                }
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
        #endregion

        
    }
}
