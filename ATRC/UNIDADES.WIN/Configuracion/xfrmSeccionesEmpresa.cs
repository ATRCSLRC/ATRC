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
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN.Configuracion
{
    public partial class xfrmSeccionesEmpresa : xfrmBase
    {
        public xfrmSeccionesEmpresa()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo unidad;

        private void SeccionesEmpresa_Load(object sender, EventArgs e)
        {
            bbiNuevaSeccion.Visibility = Utilerias.VisibilidadPermiso("NuevaSeccion");
            bbiModificarSeccion.Visibility = Utilerias.VisibilidadPermiso("ModificarSeccion");
            unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Unidades = new XPView(unidad, typeof(Unidad), "Oid;Nombre", new BinaryOperator("EsSeccion", true));
            grdSecciones.DataSource = Unidades;
        }

        private void bbiNuevaSeccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Nueva sección";
            args.Prompt = "Nombre:";
            TextEdit editor = new TextEdit();
            args.Editor = editor;
            var result = XtraInputBox.Show(args);
            if (result != null)
            {
                unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UNIDADES.BL.Unidad UnidadSeccion = new UNIDADES.BL.Unidad(unidad);
                UnidadSeccion.Nombre = result.ToString();
                UnidadSeccion.EsSeccion = true;
                UnidadSeccion.Save();
                unidad.CommitChanges();
                ((XPView)grdSecciones.DataSource).Reload();
            }
        }

        private void bbiModificarSeccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewSeccion = grvSecciones.GetFocusedRow() as ViewRecord;
            if (viewSeccion != null)
            {
                unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UNIDADES.BL.Unidad UnidadSeccion = unidad.GetObjectByKey<UNIDADES.BL.Unidad>(viewSeccion["Oid"]);
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Modificar sección";
                args.Prompt = "Nombre:";
                TextEdit editor = new TextEdit();
                args.DefaultResponse = UnidadSeccion.Nombre;
                args.Editor = editor;
                var result = XtraInputBox.Show(args);
                if (result != null)
                {
                    UnidadSeccion.Nombre = result.ToString();
                    UnidadSeccion.EsSeccion = true;
                    UnidadSeccion.Save();
                    unidad.CommitChanges();
                    ((XPView)grdSecciones.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
