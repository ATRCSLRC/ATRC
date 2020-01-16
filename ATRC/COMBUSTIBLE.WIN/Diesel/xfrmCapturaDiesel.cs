using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
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

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmCapturaDiesel : xfrmBase
    {
        public xfrmCapturaDiesel()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;

        private void xfrmCapturaDiesel_Load(object sender, EventArgs e)
        {
            bbiDiesel.Visibility = Utilerias.VisibilidadPermiso("DieselUnidad");
            bbiMedidor.Visibility = Utilerias.VisibilidadPermiso("MedidoresTanqueDiesel");
            bbiAgregarPedido.Visibility = Utilerias.VisibilidadPermiso("AgregarPedidoDiesel");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView PedidosDiesel = new XPView(Unidad, typeof(Diesel), "Oid;Unidad.Nombre;Empleado.Nombre;Llenado", new BinaryOperator("Fecha", DateTime.Now.Date));
            grdUnidadDiesel.DataSource = PedidosDiesel;
            Tanques();

        }

        private void bbiMedidor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xfrmMedidores xfrm = new xfrmMedidores();
            xfrm.TipoCombustible = Enums.Combustible.Diesel;
            xfrm.ShowDialog();
        }

        private void bbiDiesel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewDiesel = grvUnidadDiesel.GetFocusedRow() as ViewRecord;
            if (viewDiesel != null)
            {
                if (!Convert.ToBoolean(viewDiesel["Llenado"]))
                {
                    UnidadDeTrabajo UnidadNueva = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Final", 0));
                    go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Enums.Combustible.Diesel));
                    XPView Medidores = new XPView(UnidadNueva, typeof(MedidorDiesel), "Oid;Tanque.Oid;Tanque.Descripcion", go);
                    if (Medidores.Count > 0)
                    {
                        xfrmDetalleDieselUnidad xfrm = new xfrmDetalleDieselUnidad();
                        xfrm.Diesel = UnidadNueva.GetObjectByKey<Diesel>(viewDiesel["Oid"]);
                        xfrm.Tanques = Medidores;
                        xfrm.ShowDialog();
                        (grdUnidadDiesel.DataSource as XPView).Reload();
                        Tanques();
                    }
                    else
                    {
                        XtraMessageBox.Show("Debe agregar la medida inicial para poder iniciar.");
                    }
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiAgregarPedido_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xfrmPedidoDiesel xfrm = new xfrmPedidoDiesel();
            xfrm.Captura = true;
            xfrm.EsAnterior = lciDia.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always ? true : false;
            xfrm.Fecha = dteDia.DateTime.Date;
            xfrm.ShowDialog();
            (grdUnidadDiesel.DataSource as XPView).Reload();
        }

        private void Tanques()
        {
            XPView Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion;Cantidad;TipoCombustible", new BinaryOperator("TipoCombustible", Enums.Combustible.Diesel));
            bbiTanques.Caption = string.Empty;
            foreach (ViewRecord view in Tanques)
                bbiTanques.Caption += view["Descripcion"].ToString() + ": " + view["Cantidad"].ToString() + " lts | ";

            bbiTanques.Caption = bbiTanques.Caption.Remove(bbiTanques.Caption.Length - 2);
        }

        private void dteDia_EditValueChanged(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView PedidosDiesel = new XPView(Unidad, typeof(Diesel), "Oid;Unidad.Nombre;Empleado.Nombre;Llenado", new BinaryOperator("Fecha", lciDia.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always ? dteDia.DateTime : DateTime.Now));
            grdUnidadDiesel.DataSource = PedidosDiesel;
        }

        private void bbiDiasAnterior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lciDia.Visibility != DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                lciDia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                bbiDiasAnterior.Caption = "Desactivar días anteriores";
                dteDia.DateTime = DateTime.Now.Date;
            }
            else
            {
                bbiDiasAnterior.Caption = "Días anteriores";
                lciDia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                XPView PedidosDiesel = new XPView(Unidad, typeof(Diesel), "Oid;Unidad.Nombre;Empleado.Nombre;Llenado", new BinaryOperator("Fecha", DateTime.Now.Date));
                grdUnidadDiesel.DataSource = PedidosDiesel;
            }
        }
    }
}
