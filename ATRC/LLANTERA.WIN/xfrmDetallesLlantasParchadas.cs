using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LLANTERA.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LLANTERA.WIN
{
    public partial class xfrmDetallesLlantasParchadas : xfrmBase
    {
        public xfrmDetallesLlantasParchadas()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadTrabajo;
        private void xfrmDetallesCambioDeLlanta_Load(object sender, EventArgs e)
        {
            UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView Unidades = new XPView(UnidadTrabajo, typeof(UNIDADES.BL.Unidad), "Oid;Nombre", go);
            lueUnidad.Properties.DataSource = Unidades;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar()
        {
            if (lueUnidad.EditValue != null)
            {
                XPView LlantasParchadas = new XPView(UnidadTrabajo, typeof(BitacoraLlantasParchadas));
                LlantasParchadas.Properties.AddRange(new ViewProperty[] {
                new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                new ViewProperty("Fecha", SortDirection.None, "[FechaAlta]", false, true),
                new ViewProperty("Unidad.Oid", SortDirection.None, "[Unidad.Oid]", false, true),
                new ViewProperty("Unidad", SortDirection.None, "[Unidad.Nombre]", false, true),
                new ViewProperty("PosicionLlanta", SortDirection.None, "[PosicionDeLlanta]", false, true),
                });

                GroupOperator go = new GroupOperator(GroupOperatorType.And);
                go.Operands.Add(new BinaryOperator("FechaAlta", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                go.Operands.Add(new BinaryOperator("FechaAlta", dteAl.DateTime.Date.AddDays(1), BinaryOperatorType.LessOrEqual));
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Convert.ToInt32(((ViewRecord)lueUnidad.EditValue)["Oid"])));

                LlantasParchadas.Criteria = go;
                grdParches.DataSource = LlantasParchadas;
            }else
            {
                XtraMessageBox.Show("Debe seleccionar una unidad.");
            }
        }

        private void Limpiar()
        {
            grdParches.DataSource = null;
            lueUnidad.EditValue = null;
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                Buscar();
                return true;
            }
            if (keyData == Keys.F12)
            {
                Limpiar();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
