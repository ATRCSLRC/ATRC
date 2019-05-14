using ALMACEN.BL;
using ATRCBASE.BL;
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

namespace ALMACEN.WIN
{
    public partial class xfrmCodigoArticulos : xfrmBase
    {
        public xfrmCodigoArticulos()
        {
            InitializeComponent();
        }

        private void xfrmCodigoArticulos_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Articulos = new XPView(Unidad, typeof(Articulo));
            Articulos.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true),
                  new ViewProperty("Codigo", SortDirection.None, "[Codigo]", false, true),
                  new ViewProperty("Cantidad", SortDirection.None, "[Facturas].Sum([Cantidad])", false, true)
                 });

            grdArticulos.DataSource = Articulos;
        }
    }
}
