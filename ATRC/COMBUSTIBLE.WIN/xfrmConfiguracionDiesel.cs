using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
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
    public partial class xfrmConfiguracionDiesel : xfrmBase
    {
        public xfrmConfiguracionDiesel()
        {
            InitializeComponent();
        }

        private void xfrmConfiguracionDiesel_Load(object sender, EventArgs e)
        {
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            ATRCBASE.BL.Configuraciones ConfiguracionHoraDeDiesel = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "HoraDeDiesel"));
            if (ConfiguracionHoraDeDiesel != null)
                tmeHoraDe.EditValue = ConfiguracionHoraDeDiesel.Accion;
            ATRCBASE.BL.Configuraciones ConfiguracionHoraADiesel = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "HoraADiesel"));
            if (ConfiguracionHoraADiesel != null)
                tmeHoraA.EditValue = ConfiguracionHoraADiesel.Accion;
            ATRCBASE.BL.Configuraciones ConfiguracionDiasDiesel = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "DiasDiesel"));
            if (ConfiguracionDiasDiesel != null)
            {
                string[] Dias = ConfiguracionDiasDiesel.Accion.Split(',');
                foreach(string Value in Dias)
                {
                    chkListDias.SetItemChecked(Convert.ToInt32(Value) - 1, true);
                }
            }
        }

        private void tmeHoraDe_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TimeEdit editor = sender as DevExpress.XtraEditors.TimeEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "HoraDeDiesel"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "HoraDeDiesel";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void tmeHoraA_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TimeEdit editor = sender as DevExpress.XtraEditors.TimeEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "HoraADiesel"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            if (Configuracion != null)
            {
                Configuracion.Accion = editor.EditValue.ToString();
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "HoraADiesel";
                Configuracion.Accion = editor.EditValue.ToString();
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }

        private void chkListDias_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            DevExpress.XtraEditors.TimeEdit editor = sender as DevExpress.XtraEditors.TimeEdit;
            ATRCBASE.BL.UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Accion", editor.SelectedIndex));
            go.Operands.Add(new BinaryOperator("Propiedad", "DiasDiesel"));
            ATRCBASE.BL.Configuraciones Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(go);

            string Valores = string.Empty;
            foreach(int value in chkListDias.Items.GetCheckedValues())
            {
                Valores += value.ToString() + ",";
            }


            if (Configuracion != null)
            {
                Configuracion.Accion = Valores.TrimEnd(',');
            }
            else
            {
                Configuracion = new ATRCBASE.BL.Configuraciones(Unidad);
                Configuracion.Propiedad = "DiasDiesel";
                Configuracion.Accion = Valores.TrimEnd(',');
            }
            Configuracion.Save();
            Unidad.CommitChanges();
        }
        //}
    }
}
