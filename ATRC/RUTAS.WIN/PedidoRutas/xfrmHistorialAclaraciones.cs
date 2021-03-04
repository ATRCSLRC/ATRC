using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ATRCBASE.BL.Enums;

namespace RUTAS.WIN
{
    public partial class xfrmHistorialAclaraciones : xfrmBase
    {
        public xfrmHistorialAclaraciones()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        public int IDAclaracion;
        private void xfrmHistorialAclaraciones_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Historial = new XPView(Unidad, typeof(RUTAS.BL.HistorialAclaracionesPedido));
            Historial.AddProperty("Oid", "Oid", true);
            Historial.AddProperty("Descripcion", "Descripcion", true);
            Historial.AddProperty("Estado", "Estado", true);
            Historial.AddProperty("FechaAlta", "FechaAlta", true);
            Historial.AddProperty("UsuarioAlta", "UsuarioAlta", true);
            //Historial.AddProperty("EnviadoPorMaquiladora", "EnviadoPorMaquiladora", true);
            Historial.Criteria = new BinaryOperator("AclaracionPedido", IDAclaracion);
            Historial.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdHistorial.DataSource = Historial;
        }

        private void grvHistorial_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "UsuarioAlta" & e.ListSourceRowIndex >= 0)
            {
                Usuario Usuario = Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(e.Value));
                e.DisplayText = Usuario != null ? Usuario.Nombre : "";
            }
        }

    }
}
