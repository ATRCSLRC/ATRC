using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class xfrmAgregarFactura : xfrmBase
    {
        public xfrmAgregarFactura()
        {
            InitializeComponent();
        }


        UnidadDeTrabajo Unidad;
        public List<Articulo> Articulos;
        private void xfrmAgregarFactura_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Articulos = new List<Articulo>();
            repMarca.DataSource = GetMarcaXP();
            repProveedor.DataSource = GetProveedorXP();
            repTipoMedida.Items.AddRange(Enum.GetValues(typeof(Enums.TipoMedida)));
            dteFecha.DateTime = DateTime.Now;
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            grdArticulos.Focus();
            switch (e.Button.Caption)
            {
                case "Nuevo":
                    Articulo arti = new Articulo();
                    Articulos.Add(arti);
                    grdArticulos.DataSource = null;
                    grdArticulos.DataSource = Articulos;
                    break;
                case "Eliminar":
                    Articulo Articulo = grvArticulos.GetFocusedRow() as Articulo;
                    if(Articulo != null)
                    {
                        Articulos.Remove(Articulo);
                        grdArticulos.DataSource = null;
                        grdArticulos.DataSource = Articulos;
                    }
                    break;
            }
            grvArticulos.FocusedRowHandle = Articulos.Count - 1;
            grvArticulos.FocusedColumn = colCodigo;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validar())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    foreach (Articulo Articulo in Articulos)
                    {
                        Factura factura = new Factura(NuevaUnidad);
                        factura.Almacen = Articulo.Almacen;
                        factura.Cantidad = Articulo.Cantidad;
                        factura.Fecha = dteFecha.DateTime;
                        factura.Marca = Articulo.Marca == null ? null : NuevaUnidad.GetObjectByKey<Marcas>(Articulo.Marca.Oid);
                        //factura.Medida = txtMedida.Text;
                        factura.NumFactura = txtFactura.Text;
                        factura.NumParte = Articulo.NumParte;
                        factura.Precio = Articulo.Precio;
                        factura.Proveedor = Articulo.Proveedor == null ? null : NuevaUnidad.GetObjectByKey<Proveedor>(Articulo.Proveedor.Oid);
                        //factura.Serie = txtSerie.Text;
                        //factura.Tipo = txtTipo.Text;
                        factura.TipoMedida = Articulo.TipoMedida;
                        factura.Save();

                        BL.Articulo ArticuloGuardar = NuevaUnidad.FindObject<BL.Articulo>(new BinaryOperator("Codigo", Articulo.Codigo));

                        if (ArticuloGuardar != null)
                        {
                            ArticuloGuardar.Facturas.Add(factura);
                        }
                        else
                        {
                            ArticuloGuardar = new BL.Articulo(NuevaUnidad);
                            ArticuloGuardar.Nombre = Articulo.Nombre;
                            ArticuloGuardar.Codigo = Articulo.Codigo;
                            ArticuloGuardar.TipoArticulo = Enums.TipoArticulo.General;
                            ArticuloGuardar.EstadoLlanta = Enums.EstadoLlanta.Nueva;
                            ArticuloGuardar.Facturas.Add(factura);
                        }
                        ArticuloGuardar.Save();
                    }
                    NuevaUnidad.CommitChanges();
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Se perderan los articulos. ¿Desea continuar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void grvArticulos_LostFocus(object sender, EventArgs e)
        {
            grvArticulos.PostEditor();
            grvArticulos.UpdateCurrentRow();
        }

        private void repCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grvArticulos.FocusedColumn = colCantidad;
            }
        }

        private void repCodigo_Leave(object sender, EventArgs e)
        {
                Articulo Articulo = grvArticulos.GetFocusedRow() as Articulo;

                BL.Articulo Arti = Unidad.FindObject<BL.Articulo>(new BinaryOperator("Codigo", Articulo.Codigo));
                if (Arti != null)
                {
                    Articulo.Nombre = Arti.Nombre;
                    Articulo.TipoMedida = Arti.Facturas[0].TipoMedida;
                    Articulo.Precio = Arti.Facturas[0].Precio;
                    Articulo.Proveedor = Arti.Facturas[0].Proveedor;
                    Articulo.Almacen = Arti.Facturas[0].Almacen;
                    Articulo.NumParte = Arti.Facturas[0].NumParte;
                    Articulo.Marca = Arti.Facturas[0].Marca;
                    
                }
        }

        #region Metodos

        private List<Proveedor> GetProveedorXP()
        {
            List<Proveedor> list = new List<Proveedor>();
            XPCollection Proveedores = new XPCollection(Unidad, typeof(Proveedor));
            foreach (Proveedor Prove in Proveedores)
                list.Add(Prove);
            return list;
        }

        private List<Marcas> GetMarcaXP()
        {
            List<Marcas> list = new List<Marcas>();
            XPCollection Marcas = new XPCollection(Unidad, typeof(Marcas));
            foreach (Marcas Marca in Marcas)
                list.Add(Marca);
            return list;
        }

        private bool Validar()
        {
            if(string.IsNullOrEmpty(txtFactura.Text))
            {
                XtraMessageBox.Show("Debe agregar una factura");
                txtFactura.Focus();
                return false;
            }

            if(Articulos.Count <= 0)
            {
                XtraMessageBox.Show("Debe agregar artículos.");
                return false;
            }

            return true;
        }
        #endregion

        #region Clase
        public class Articulo
        {
            public string Codigo { get; set; }

            public Int32 Cantidad { get; set; }

            public string Nombre { get; set; }

            public Enums.TipoMedida TipoMedida { get; set; }

            public decimal Precio { get; set; }

            public Proveedor Proveedor { get; set; }

            public int Almacen { get; set; }

            public string NumParte { get; set; }

            public Marcas Marca { get; set; }

            public bool EsApoyo { get; set; }
        }

        #endregion
    }
}
