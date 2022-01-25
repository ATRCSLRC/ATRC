using ATRCBASE.BL;
using COMBUSTIBLE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmModificarDiesel : xfrmBase
    {
        public xfrmModificarDiesel()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmModificarDiesel_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            go.Operands.Add(new BinaryOperator("Combustible", Combustible.Diesel));
            XPView Unidades = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", go);
            Unidades.Sorting.Add(new SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending));
            lueUnidad.Properties.DataSource = Unidades;
            dteFecha.DateTime = DateTime.Now;
        }

        private void bbiBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator();
            BinaryOperator boUnidad = new BinaryOperator("Unidad", lueUnidad.EditValue);
            BinaryOperator boFecha = new BinaryOperator("Fecha", dteFecha.DateTime.Date);
            go.Operands.Add(boUnidad);
            go.Operands.Add(boFecha);
            XPView Diesel = new XPView(Unidad, typeof(Diesel), "Oid;Fecha;Millas;CandadoActual;CandadoAnterior;Litros;UltimaRecarga.Tanque.Descripcion", go);
            grdDiesel.DataSource = Diesel;
            if (Diesel.Count > 0)
                rpMain.Visible = true;
        }

        private void bbiLimpiar_Click(object sender, EventArgs e)
        {
            lueUnidad.EditValue = null;
            dteFecha.DateTime = DateTime.Now;
            grdDiesel.DataSource = null;
            rpMain.Visible = false;
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { ViewRecord viewDiesel = grvDiesel.GetFocusedRow() as ViewRecord;
            if (viewDiesel != null)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                XPView Medidores = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion", new BinaryOperator("TipoCombustible", Enums.Combustible.Diesel));
                xfrmDetalleDieselUnidad xfrm = new xfrmDetalleDieselUnidad();
                xfrm.Diesel = Unidad.GetObjectByKey<Diesel>(viewDiesel["Oid"]);
                xfrm.Tanques = Medidores;
                xfrm.EsModificacion = true;
                xfrm.ShowDialog();
                ((XPView)grdDiesel.DataSource).Reload();
            }
        }

        private void xfrmModificarDiesel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
