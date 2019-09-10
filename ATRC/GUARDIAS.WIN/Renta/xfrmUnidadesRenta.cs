using ATRCBASE.BL;
using ATRCBASE.WIN;
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
using UNIDADES.BL;

namespace GUARDIAS.WIN
{
    public partial class xfrmUnidadesRenta : xfrmBase
    {
        public xfrmUnidadesRenta()
        {
            InitializeComponent();
        }

        private void xfrmUnidadesRenta_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView UnidadesRenta = new XPView(Unidad, typeof(Unidad), "Oid;Nombre;PrecioRenta", new BinaryOperator("EsRenta", true));
            grdUnidades.DataSource = UnidadesRenta;
        }

        private void bbiModificarPrecio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (viewUnidad != null)
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Costo de renta de la unidad '" + viewUnidad["Nombre"] + "'";
                args.Prompt = "Cantidad:";
                SpinEdit editor = new SpinEdit();
                editor.Properties.DisplayFormat.FormatString = "c";
                editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                editor.Properties.EditFormat.FormatString = "c";
                editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                editor.Properties.EditMask = "c";
                args.Editor = editor;
                args.DefaultResponse = viewUnidad["PrecioRenta"];
                var result = XtraInputBox.Show(args);
                if (result != null)
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Unidad UnidadRenta = UnidadModificar.GetObjectByKey<Unidad>(viewUnidad["Oid"]);
                    //UnidadRenta.PrecioRenta = Convert.ToDecimal(result);

                    UnidadRenta.Save();
                    UnidadModificar.CommitChanges();
                    (grdUnidades.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
