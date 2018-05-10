using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace ALMACEN.WIN
{
    public partial class Inventario : DevExpress.XtraReports.UI.XtraReport
    {
        public Inventario(int ID)
        {
            InitializeComponent();
            XPCollection Inventario = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(ALMACEN.BL.InventarioArticulo), new BinaryOperator("Oid", ID));
            this.DataSource = Inventario;
        }

    }
}
