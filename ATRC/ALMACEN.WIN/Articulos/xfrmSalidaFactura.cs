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
using UNIDADES.BL;

namespace ALMACEN.WIN
{
    public partial class xfrmSalidaFactura : xfrmBase
    {
        public xfrmSalidaFactura()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        public List<Articulo> Articulos;

        private void xfrmSalidaFactura_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { txtCodigo.Focus(); }));
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView Unidades = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", go);
            Unidades.Sorting.Add(new SortingCollection(new SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            lueUnidad.Properties.DataSource = Unidades;

            XPView Usuarios = new XPView(Unidad, typeof(Usuario));
            Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                 });
            Usuarios.Criteria = new BinaryOperator("Activo", true);
            lueRecibo.Properties.DataSource = Usuarios;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    // UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Cantidad", 0, BinaryOperatorType.Greater));
                    go.Operands.Add(new BinaryOperator("NumFactura", txtCodigo.Text));
                    XPView viewFacturas = new XPView(Unidad, typeof(Factura), "Oid;Articulo.Codigo;Cantidad;" +
                        "Articulo.Nombre;TipoMedida;Precio;Proveedor.Nombre;Almacen;NumParte;Marca.Nombre;Articulo.Oid", go);
                    grdArticulos.DataSource = viewFacturas;
                    if (viewFacturas.Count > 0)
                        rpAcciones.Visible = true;
                    else
                        XtraMessageBox.Show("No hay artícuos con esta factura.");
                }
            }
        }

        private void bbiSalida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                UnidadDeTrabajo UnidadSalida = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                if (rgTipoSalida.SelectedIndex == 0)
                {
                    #region Factura

                    foreach (ViewRecord viewFactura in ((XPView)grdArticulos.DataSource))
                    {
                        SalidaArticulo Salida = new SalidaArticulo(UnidadSalida);
                        Salida.Articulo = UnidadSalida.GetObjectByKey<BL.Articulo>(viewFactura["Articulo.Oid"]);
                        Salida.Factura = UnidadSalida.GetObjectByKey<Factura>(viewFactura["Oid"]);//((Factura)((ViewRecord)lueFactura.EditValue).GetObject());
                        Salida.Cantidad = Convert.ToDecimal(viewFactura["Cantidad"]);
                        if (rgDestino.SelectedIndex == 0)
                        {
                            Salida.TipoDestino = Enums.Destino.Unidad;
                            Unidad UnidadCamion = UnidadSalida.GetObjectByKey<Unidad>(lueUnidad.EditValue);
                            Salida.SetMemberValue("Unidad", UnidadCamion);
                        }
                        else
                        {
                            Salida.TipoDestino = Enums.Destino.Otro;
                            Salida.OtroDestino = txtOtro.Text;
                        }

                        if (rgRecibo.SelectedIndex == 0)
                        {
                            Salida.TipoRecibo = Enums.Recibo.Usuario;
                            Salida.UsuarioRecibo = UnidadSalida.GetObjectByKey<Usuario>(lueRecibo.EditValue);
                        }
                        else
                        {
                            Salida.TipoRecibo = Enums.Recibo.Otro;
                            Salida.OtroRecibo = txtOtroRecibo.Text;
                        }
                        Salida.Estado = Enums.EstadoSalida.Entregado;
                        Salida.Fecha = DateTime.Now.Date;
                        Salida.Factura.Cantidad -= Convert.ToDecimal(viewFactura["Cantidad"]);
                        Salida.Factura.Save();
                        Salida.Save();
                    }
                    UnidadSalida.CommitChanges();
                    #endregion
                }
                else
                {
                    #region Masiva
                    foreach (Articulo Factura in Articulos)
                    {
                        SalidaArticulo Salida = new SalidaArticulo(UnidadSalida);
                        Salida.Articulo = UnidadSalida.GetObjectByKey<BL.Articulo>(Factura.Factura.Articulo.Oid);
                        Salida.Factura = UnidadSalida.GetObjectByKey<Factura>(Factura.Factura.Oid);//((Factura)((ViewRecord)lueFactura.EditValue).GetObject());
                        Salida.Cantidad = Convert.ToDecimal(Factura.Cantidad);
                        if (rgDestino.SelectedIndex == 0)
                        {
                            Salida.TipoDestino = Enums.Destino.Unidad;
                            Unidad UnidadCamion = UnidadSalida.GetObjectByKey<Unidad>(lueUnidad.EditValue);
                            Salida.SetMemberValue("Unidad", UnidadCamion);
                        }
                        else
                        {
                            Salida.TipoDestino = Enums.Destino.Otro;
                            Salida.OtroDestino = txtOtro.Text;
                        }

                        if (rgRecibo.SelectedIndex == 0)
                        {
                            Salida.TipoRecibo = Enums.Recibo.Usuario;
                            Salida.UsuarioRecibo = UnidadSalida.GetObjectByKey<Usuario>(lueRecibo.EditValue);
                        }
                        else
                        {
                            Salida.TipoRecibo = Enums.Recibo.Otro;
                            Salida.OtroRecibo = txtOtroRecibo.Text;
                        }
                        Salida.Estado = Enums.EstadoSalida.Entregado;
                        Salida.Fecha = DateTime.Now.Date;
                        Salida.Factura.Cantidad -= Convert.ToDecimal(Factura.Cantidad);
                        Salida.Factura.Save();
                        Salida.Save();
                    }
                    UnidadSalida.CommitChanges();
                    #endregion
                }
                XtraMessageBox.Show("Se genero la salida correctamente.");
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCodigo.Text = string.Empty;
            grdArticulos.DataSource = null;
            rpAcciones.Visible = false;
            lueUnidad.EditValue = null;
            txtOtro.Text = txtOtroRecibo.Text = string.Empty;
            lueRecibo.EditValue = null;
            rgDestino.SelectedIndex = rgRecibo.SelectedIndex = rgTipoSalida.SelectedIndex = 0;
            txtCodigo.Focus();
        }

        private void rgTipoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdArticulos.DataSource = null;
            if (((RadioGroup)sender).SelectedIndex == 0)
            {
                
                lciFactura.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                flpAccionesFactura.HidePopup();
                rpAcciones.Visible = false;
                colCodigo.FieldName = "Articulo.Codigo";
                colProveedor.FieldName = "Proveedor.Nombre";
                colMarca.FieldName = "Marca.Nombre";
                //lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                //lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                Articulos = new List<Articulo>();
                colCodigo.FieldName = "Codigo";
                colProveedor.FieldName = "Proveedor";
                colMarca.FieldName = "Marca";
                lciFactura.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                flpAccionesFactura.ShowPopup();
                rpAcciones.Visible = true;
            }
        }

        private void rgDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioGroup)sender).SelectedIndex == 0)
            {
                lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciOtro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void rgRecibo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioGroup)sender).SelectedIndex == 0)
            {
                lciOtroEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciOtroEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void flpAccionesFactura_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Nuevo artículo":
                    xfrmArticuloSalida xfrm = new xfrmArticuloSalida();
                    xfrm.ShowInTaskbar = false;
                    xfrm.Unidad = Unidad;
                    xfrm.Articulos = Articulos;
                    //xfrm.MdiParent = this;
                    xfrm.ShowDialog();
                    if(xfrm.Factura != null)
                    {
                        AgregarArticulo(xfrm.Factura, xfrm.Cantidad);
                        grdArticulos.DataSource = null;
                        grdArticulos.DataSource = Articulos;
                    }
                    break;
                case "Eliminar artículo":
                    Articulo articulo =  grvArticulos.GetFocusedRow() as Articulo;
                    if(articulo != null)
                    {
                        Articulos.Remove(articulo);
                        grdArticulos.DataSource = null;
                        grdArticulos.DataSource = Articulos;
                    }
                    break;
            }
        }

        private void AgregarArticulo(Factura Factura, int Cantidad)
        {
            Articulo Articulo = new Articulo();
            Articulo.Codigo = Factura.Articulo.Codigo;
            Articulo.Cantidad = Cantidad;
            Articulo.Nombre = Factura.Articulo.Nombre;
            Articulo.TipoMedida = Factura.TipoMedida;
            Articulo.Precio = Factura.Precio;
            Articulo.Proveedor = Factura.Proveedor.Nombre;
            Articulo.Almacen = Factura.Almacen;
            Articulo.NumParte = Factura.NumParte;
            Articulo.Marca = Factura.Marca.Nombre;
            Articulo.Factura = Factura;
            Articulos.Add(Articulo);
        }

        private bool ValidarCampos()
        {
            if (rgTipoSalida.SelectedIndex == 0)
            {
                if (((XPView)grdArticulos.DataSource).Count <= 0)
                {
                    XtraMessageBox.Show("Debe de agregar una factura.");
                    txtCodigo.Focus();
                    return false;
                }
            }
            else
            {
                if (Articulos.Count <= 0)
                {
                    XtraMessageBox.Show("Debe de agregar artículos.");
                    return false;
                }
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
                if (string.IsNullOrEmpty(txtOtro.Text))
                {
                    XtraMessageBox.Show("Debe de agregar una descripción al campo de otro destino.");
                    txtOtro.Focus();
                    return false;
                }
            }

            if (rgRecibo.SelectedIndex == 0)
            {
                if (lueRecibo.EditValue == null)
                {
                    XtraMessageBox.Show("Debe de seleccionar un usuario.");
                    lueRecibo.Focus();
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

            //if (((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Cantidad <= 0)
            //{
            //    XtraMessageBox.Show("No hay en existencia el artículo seleccionado.");
            //    lueFactura.Focus();
            //    return false;
            //}

            //if (((Factura)((ViewRecord)lueFactura.EditValue).GetObject()).Cantidad < spnCantidad.Value)
            //{
            //    XtraMessageBox.Show("La cantidad seleccionada es mayor al número de artículos en existencia.");
            //    spnCantidad.Focus();
            //    return false;
            //}

            return true;
        }

        #region Clase
        public class Articulo
        {
            public string Codigo { get; set; }

            public Int32 Cantidad { get; set; }

            public string Nombre { get; set; }

            public Enums.TipoMedida TipoMedida { get; set; }

            public decimal Precio { get; set; }

            public string Proveedor { get; set; }

            public int Almacen { get; set; }

            public string NumParte { get; set; }

            public string Marca { get; set; }

            public Factura Factura { get; set; }
        }

        #endregion
    }
}
