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

namespace UNIDADES.WIN.Baterias
{
    public partial class xfrmInventarioBaterias : xfrmBase
    {
        public xfrmInventarioBaterias()
        {
            InitializeComponent();
        }

        private void xfrmInventarioBaterias_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView xpUnidades = new XPView(Unidad, typeof(Unidad));
            xpUnidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Revisado", SortDirection.None, "iif(GETMONTH([FechaInventarioBaterias]) == GETMONTH(NOW()), True, False)", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true),
                  new ViewProperty("Baterias", SortDirection.None, "[Baterias]", false, true),
                  new ViewProperty("ComentarioBateria", SortDirection.None, "[ComentarioBateria]", false, true),
                 });
            xpUnidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            xpUnidades.Criteria = go;
            grdBaterias.DataSource = xpUnidades;
        }

        private void bbiRevisar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewBaterias = (ViewRecord)grvBaterias.GetRow(grvBaterias.FocusedRowHandle);
            if (ViewBaterias != null)
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Unidad " + ViewBaterias["Nombre"];
                args.Prompt = "Baterias:";
                TokenEdit editor = new TokenEdit();
                editor.Properties.EditMode = TokenEditMode.Manual;
                editor.Properties.Separators.Add(",");
                editor.Properties.Separators.Add(";");
                editor.Properties.Separators.Add(" ");
                editor.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tknBaterias_ValidateToken);
                args.Editor = editor;
                args.DefaultResponse = ViewBaterias["Baterias"];
                var result = XtraInputBox.Show(args);
                if (result != null)
                {
                    Unidad UnidadCamion = (Unidad)ViewBaterias.GetObject();
                    UnidadCamion.FechaInventarioBaterias = DateTime.Now;
                    UnidadCamion.Baterias = result.ToString();
                    UnidadCamion.ComentarioBateria = string.Empty;
                    UnidadCamion.GenerarHistorialBaterias(result.ToString(), DateTime.Now, string.Empty);
                    UnidadCamion.Save();
                    UnidadCamion.Session.CommitTransaction();
                    (grdBaterias.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tknBaterias_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = true;
        }

        private void bbiExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdBaterias.ShowRibbonPrintPreview();
        }
    }
}
