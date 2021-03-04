using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmHistorialAccesos : xfrmBase
    {
        public xfrmHistorialAccesos()
        {
            InitializeComponent();
        }

        private void xfrmHistorialAccesos_Load(object sender, EventArgs e)
        {
            dteDe.DateTime = dteA.DateTime = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Accesos = new XPView(Unidad, typeof(RegistroAccesos));
            Accesos.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("TipoAcceso", SortDirection.None, "[TipoAcceso]", false, true),
                  new ViewProperty("IDCard", SortDirection.None, "[IDCard]", false, true),
                  new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "Concat(ToStr([Usuario.NumEmpleado]), ' - ', [Usuario.Nombre])", false, true)
                 });
            Accesos.Sorting.Add(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Descending));
            Accesos.Criteria = new BetweenOperator("FechaAlta", dteDe.DateTime.Date, dteA.DateTime.Date.AddDays(1));
            grdAccesos.DataSource = Accesos;

        }
    }
}
