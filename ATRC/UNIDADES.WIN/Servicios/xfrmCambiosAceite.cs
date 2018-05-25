using ATRCBASE.BL;
using UNIDADES.BL;
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

namespace UNIDADES.WIN
{
    public partial class xfrmCambiosAceite : xfrmBase
    {
        public xfrmCambiosAceite()
        {
            InitializeComponent();
        }

        private void xfrmCambiosAceite_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Unidades = new XPView(Unidad, typeof(Unidad));
            Unidades.AddProperty("Oid", "Oid", true);
            Unidades.AddProperty("Nombre", "Nombre", true);
            Unidades.AddProperty("Combustible", "Combustible", true);
            Unidades.AddProperty("UltimoCambioAceite", "UltimoCambioAceite", true);
            Unidades.AddProperty("TipoUnidad", "TipoUnidad", true);
            Unidades.AddProperty("ProximoCambioAceite", "iif([TipoUnidad] == 1, AddMonths([UltimoCambioAceite],3), AddMonths([UltimoCambioAceite],6)) ", false, true, SortDirection.Ascending);
            grdUnidades.DataSource = Unidades;
        }

        private void grvUnidades_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                DateTime Fecha = (DateTime)grvUnidades.GetRowCellValue(e.RowHandle, grvUnidades.Columns["ProximoCambioAceite"]);
                if (DateTime.Now.Date >= Fecha.Date)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                   
                }
                else
                {
                    e.Appearance.BackColor = Color.LimeGreen;
                    e.Appearance.BackColor2 = Color.LimeGreen;
                }
                e.HighPriority = true;
            }
            
        }
    }
}
