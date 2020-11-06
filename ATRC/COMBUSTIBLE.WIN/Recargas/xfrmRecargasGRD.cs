using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmRecargasGRD : xfrmBase
    {
        public xfrmRecargasGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        public bool AgregarFinales = false;
        private void xfrmRecargasGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            if (AgregarFinales)
            {
                bbiModificar.Caption = "Agregar finales";
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new NullOperator("LecturaFinal"));
                go.Operands.Add(new BinaryOperator("FechaAlta", new DateTime(2020, 8, 18), BinaryOperatorType.GreaterOrEqual));
                XPView Recargas = new XPView(Unidad, typeof(RecargaDiesel), "Oid;FechaAlta;Tanque.Descripcion;Cantidad;Tanque.Cantidad;" +
                    "Proveedor;PrecioLitro;Lectura;LecturaFinal;Total", go);
                grdRecargas.DataSource = Recargas;
                rpAcciones.Visible = Recargas.Count > 0 ? true : false;
            }else
            {
                lcgBusqueda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                dteDe.DateTime = dteA.DateTime = DateTime.Now.Date;
                XPView Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion", null);
                foreach (ViewRecord vr in Tanques)
                    rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Oid"], vr["Descripcion"].ToString()));

                rgTanques.SelectedIndex = 0;
            }
            
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRecarga = grvRecargas.GetFocusedRow() as ViewRecord;
            if (AgregarFinales)
            {
                if (ViewRecarga != null)
                {
                    RecargaDiesel Recarga = (RecargaDiesel)ViewRecarga.GetObject();
                    XtraInputBoxArgs args = new XtraInputBoxArgs();
                    args.Caption = "Agregar finales";
                    args.Prompt = "Lectura final:";
                    SpinEdit editor = new SpinEdit();

                    editor.Properties.DisplayFormat.FormatString = "d";
                    editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;

                    editor.Properties.EditFormat.FormatString = "d";
                    editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;

                    editor.Properties.EditMask = "d";
                    editor.Properties.Buttons.RemoveAt(0);
                    args.Editor = editor;
                    var result = XtraInputBox.Show(args);
                    if (result != null)
                    {
                        Recarga.LecturaFinal = result.ToString();
                        Recarga.Total = Convert.ToDouble(result) - Convert.ToDouble(Recarga.Lectura);
                        Recarga.Save();
                        Unidad.CommitChanges();
                        (grdRecargas.DataSource as XPView).Reload();
                    }
                }
            }
            else
            {
                xfrmDetalleRecarga xfrm = new xfrmDetalleRecarga();
                xfrm.Recarga = ViewRecarga.GetObject() as RecargaDiesel;
                xfrm.Show();
                ((XPView)grdRecargas.DataSource).Reload();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BetweenOperator("FechaAlta", dteDe.DateTime.Date, dteA.DateTime.Date));
            go.Operands.Add(new BinaryOperator("Tanque.Oid", rgTanques.EditValue));
            XPView Recargas = new XPView(Unidad, typeof(RecargaDiesel), "Oid;FechaAlta;Tanque.Descripcion;Cantidad;Tanque.Cantidad;" +
                "Proveedor;PrecioLitro;Lectura;LecturaFinal;Total", go);
            grdRecargas.DataSource = Recargas;
            rpAcciones.Visible = Recargas.Count > 0 ? true : false;
        }
    }
}
