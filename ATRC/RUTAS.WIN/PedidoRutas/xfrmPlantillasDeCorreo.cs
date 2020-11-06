using ATRCBASE.BL;
using ATRCBASE.BL.Clases;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.PedidoRutas
{
    public partial class xfrmPlantillasDeCorreo : xfrmBase
    {
        public xfrmPlantillasDeCorreo()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        PlantillaDeCorreo Plantilla;

        private void xfrmPlantillasDeCorreo_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbPlantilla_SelectedValueChanged(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Plantilla = (PlantillaDeCorreo)Unidad.FindObject(typeof(PlantillaDeCorreo), new BinaryOperator("Nombre", cmbPlantilla.EditValue));
            if(Plantilla == null)
            {
                Plantilla = new PlantillaDeCorreo(Unidad);
                Plantilla.Nombre = cmbPlantilla.EditValue.ToString();
                Plantilla.Save();
                Unidad.CommitChanges();
            }

            List<string> Variables = new List<string>();
            tlVariables.ClearNodes();

            txtAsunto.Text = Plantilla.Asunto;
            richEditor.HtmlText = Plantilla.Contenido;
            rpAcciones.Visible = true;
            switch (cmbPlantilla.EditValue)
            {
                case "Cambio de estado (Pedido de rutas)":
                    Variables.Add("Nombre");
                    Variables.Add("Estado");
                    Variables.Add("Fecha");
                    foreach (string Var in Variables)
                    {
                        TreeListNode node = tlVariables.AppendNode(Var, null);
                        node.SetValue(0, Var);
                        node.Tag = Var;
                    }
                    
                    break;
                case "Rechazar pedido rutas":
                    Variables.Add("Nombre");
                    Variables.Add("Estado");
                    Variables.Add("Fecha");
                    Variables.Add("Motivo");
                    foreach (string Var in Variables)
                    {
                        TreeListNode node = tlVariables.AppendNode(Var, null);
                        node.SetValue(0, Var);
                        node.Tag = Var;
                    }

                    break;
                case "Activación de usuario":
                    Variables.Add("Nombre");
                    Variables.Add("Correo");
                    Variables.Add("LinkActivacion");
                    foreach (string Var in Variables)
                    {
                        TreeListNode node = tlVariables.AppendNode(Var, null);
                        node.SetValue(0, Var);
                        node.Tag = Var;
                    }

                    break;
            }
        }

        private void richEditor_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeListNode)))
            {
                TreeListNode data = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                richEditor.Document.InsertText(richEditor.Document.CaretPosition, "[" + data.GetValue(0).ToString() + "]");
            }
        }

        private void richEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeListNode)))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtAsunto_DragDrop(object sender, DragEventArgs e)
        {
            DevExpress.XtraEditors.TextEdit txt = sender as DevExpress.XtraEditors.TextEdit;
            if (e.Data.GetDataPresent(typeof(TreeListNode)))
            {
                TreeListNode data = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                txt.SelectedText = "[" + data.GetValue(0).ToString() + "]";
            }
        }

        private void txtAsunto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeListNode)))
            {
                TreeListNode data = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;

                if (data != null) { e.Effect = DragDropEffects.All; }
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Plantilla != null)
            {
                Plantilla.Contenido = richEditor.HtmlText;
                Plantilla.Asunto = txtAsunto.Text;
                Plantilla.Save();
                Plantilla.Session.CommitTransaction();
            }
        }
    }
}
