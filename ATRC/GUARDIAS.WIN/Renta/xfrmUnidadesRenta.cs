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
            XPView UnidadesRenta = new XPView(Unidad, typeof(Unidad), "Oid;Nombre;Dueño", new BinaryOperator("EsRenta", true));
            grdUnidades.DataSource = UnidadesRenta;
        }

        private void bbiModificarPrecio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (viewUnidad != null)
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Dueño de la unidad de renta '" + viewUnidad["Nombre"] + "'";
                args.Prompt = "Dueño:";
                ComboBoxEdit editor = new ComboBoxEdit();

                editor.Properties.Items.Add("Auto Transportes del Rio Colorado");
                editor.Properties.Items.Add("Gilda Aidee Salgado Gonzalez");
                //SpinEdit editor = new SpinEdit();
                //editor.Properties.DisplayFormat.FormatString = "c";
                //editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //editor.Properties.EditFormat.FormatString = "c";
                //editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //editor.Properties.EditMask = "c";
                args.Editor = editor;
                args.DefaultResponse = viewUnidad["Dueño"];
                var result = XtraInputBox.Show(args).ToString();
                if (result != null)
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Unidad UnidadRenta = UnidadModificar.GetObjectByKey<Unidad>(viewUnidad["Oid"]);
                    UnidadRenta.Dueño = Convert.ToString(result);

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
