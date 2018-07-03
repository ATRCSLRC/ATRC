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
    public partial class xfrmDetallesCambioDeLlanta : xfrmBase
    {
        public xfrmDetallesCambioDeLlanta()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadTrabajo;
        private void xfrmDetallesCambioDeLlanta_Load(object sender, EventArgs e)
        {
            UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            XPView Unidades = new XPView(UnidadTrabajo, typeof(UNIDADES.BL.Unidad), "Oid;Nombre", null);
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
                XPView CambiosLlanta = new XPView(UnidadTrabajo, typeof(BitacoraCambiosDeLlanta));
                CambiosLlanta.Properties.AddRange(new ViewProperty[] {
                new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                new ViewProperty("Fecha", SortDirection.None, "[FechaAlta]", false, true),
                new ViewProperty("Unidad.Oid", SortDirection.None, "[Unidad.Oid]", false, true),
                new ViewProperty("Unidad", SortDirection.None, "[Unidad.Nombre]", false, true),
                new ViewProperty("PosicionLlanta", SortDirection.None, "[PosicionDeLlanta]", false, true),
                new ViewProperty("LlantaNueva", SortDirection.None, "[FacturaLlantaNueva.Marca.Nombre] + ' ' + [FacturaLlantaNueva.Serie] + ' ' + [FacturaLlantaNueva.Medida]", false, true),
                new ViewProperty("LlantaAnterior", SortDirection.None, "[FacturaLlantaAnterior.Marca.Nombre] + ' ' + [FacturaLlantaAnterior.Serie] + ' ' + [FacturaLlantaAnterior.Medida]", false, true),
                new ViewProperty("EstadoLlantaAnterior", SortDirection.None, "[EstadoLlantaAnterior]", false, true),
                });

                GroupOperator go = new GroupOperator(GroupOperatorType.And);
                go.Operands.Add(new BinaryOperator("FechaAlta", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                go.Operands.Add(new BinaryOperator("FechaAlta", dteAl.DateTime.Date.AddDays(1), BinaryOperatorType.LessOrEqual));
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Convert.ToInt32(((ViewRecord)lueUnidad.EditValue)["Oid"])));

                CambiosLlanta.Criteria = go;
                grdCambios.DataSource = CambiosLlanta;
            }else
            {
                XtraMessageBox.Show("Debe seleccionar una unidad.");
            }
        }

        private void Limpiar()
        {
            grdCambios.DataSource = null;
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
