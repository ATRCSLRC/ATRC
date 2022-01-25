using ATRCBASE.BL;
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

namespace ATRCBASE.WIN
{
    public partial class xfrmAccesos : xfrmBase
    {
        public xfrmAccesos()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmAccesos_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;NumEmpleado;Nombre;AccesoDormitorio;AccesoComedor", null);
            XPCollection Usuarios = new XPCollection(Unidad, typeof(Usuario), new BinaryOperator("Activo", true));
            Usuarios.Sorting.Add(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdAccesos.DataSource = Usuarios;
        }

        private void repchk_CheckedChanged(object sender, EventArgs e)
        {
            
            //Usuario Usuario = grvAccesos.GetFocusedRow() as Usuario;
            //if(Usuario != null)
            //{
            //    //Usuario.AccesoDormitorio = repchkDormitorio;
            //}
        }

        private void repchkComedor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void grvAccesos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Unidad.CommitChanges();
        }

        private void grvAccesos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void repchkDormitorio_CheckStateChanged(object sender, EventArgs e)
        {
            //CheckEdit chk = sender as CheckEdit;
            //if (chk.Checked)
            //{
            //    colHoraDe.Visible = true;
            //    colHoraA.Visible = true;
            //}
            //else
            //{
            //    colHoraDe.Visible = false;
            //    colHoraA.Visible = false;
            //}
        }

        private void grvAccesos_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if (e.Column.FieldName == colHoraDe.Name)
            //{
            //    Usuario Usuario = e.Row as Usuario;
            //    if (e.IsGetData)
            //    {
            //        //Usuario Usuario= e.Row as DataRowView;
            //        e.Value = Usuario.HoraDormitorioDe;
            //    }
            //    if (e.IsSetData)
            //    {
            //        Usuario.HoraDormitorioDe = ((DateTime)e.Value).TimeOfDay;
            //       // DataRowView row = e.Row as DataRowView;
            //       //row["WORK_TIME"] = Convert.ToDateTime(e.Value).Ticks;
            //    }
            //}

            //if (e.Column.Name == colHoraA.Name)
            //{
            //    if (e.IsGetData)
            //    {
            //        DataRowView row = e.Row as DataRowView;
            //        e.Value = new DateTime(((TimeSpan)row["WORK_TIME"]).Ticks);
            //    }
            //    if (e.IsSetData)
            //    {
            //        DataRowView row = e.Row as DataRowView;
            //        row["WORK_TIME"] = Convert.ToDateTime(e.Value).Ticks;
            //    }
            //}
        }
    }
}
