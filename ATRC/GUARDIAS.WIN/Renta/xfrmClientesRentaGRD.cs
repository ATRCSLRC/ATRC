using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
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
    public partial class xfrmClientesRentaGRD : xfrmBase
    {
        public xfrmClientesRentaGRD()
        {
            InitializeComponent();
        }
        public int IDCliente;
        public bool Asignar;
        private void xfrmClientesRentaGRD_Load(object sender, EventArgs e)
        {
            if (!Asignar)
            {
                bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevoClienteRenta");
                bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarClienteRenta");
            } else
            {
                bbiNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiModificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Clientes = new XPView(Unidad, typeof(ClientesRenta), "Oid;Nombre;Domicilio;Tel", null);
            grdClientes.DataSource = Clientes;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmClienteRenta xfrm = new xfrmClienteRenta())
            {
                xfrm.EsNuevo = true;
                xfrm.ShowDialog();
                xfrm.Dispose();
                ((XPView)grdClientes.DataSource).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewCliente = grvClientes.GetFocusedRow() as ViewRecord;
            if (viewCliente != null)
                using (xfrmClienteRenta xfrm = new xfrmClienteRenta())
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

                    xfrm.EsNuevo = false;
                    xfrm.Cliente = UnidadModificar.GetObjectByKey<ClientesRenta>(viewCliente["Oid"]);
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdClientes.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiAsignar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewCliente = grvClientes.GetFocusedRow() as ViewRecord;
            if (viewCliente != null)
            {
                IDCliente = Convert.ToInt32(viewCliente["Oid"]);
                this.Close();
            }
        }
    }
}
