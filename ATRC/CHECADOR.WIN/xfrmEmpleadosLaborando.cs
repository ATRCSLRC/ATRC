using ATRCBASE.WIN;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHECADOR.WIN
{
    public partial class xfrmEmpleadosLaborando : xfrmBase
    {
        public xfrmEmpleadosLaborando()
        {
            InitializeComponent();
        }

        int seg = 0;
        private void xfrmEmpleadosLaborando_Load(object sender, EventArgs e)
        {
            grdEmpleados.DataSource = sqlDataSource1.Result[0];
            sqlDataSource1.Fill();
            timer.Start();
            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage((Bitmap)global::CHECADOR.WIN.Properties.Resources.icons8_arriba_en_círculo_2_16);
            images.AddImage((Bitmap)global::CHECADOR.WIN.Properties.Resources.icons8_abajo_en_círculo_2_16);
            //Configuracion columna de estado

            RepositoryItemImageComboBox imageCombo_Estado = grdEmpleados.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            imageCombo_Estado.SmallImages = images;
            imageCombo_Estado.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            imageCombo_Estado.Buttons[0].Appearance.BackColor = Color.White;
            imageCombo_Estado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            imageCombo_Estado.LookAndFeel.UseDefaultLookAndFeel = false;
            imageCombo_Estado.LookAndFeel.SkinName = "Office 2016 Colorful";
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Entrada", "Entrada", 0));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Salida", "Salida", 1));

            imageCombo_Estado.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            grvEmpleados.Columns["Estado"].ColumnEdit = imageCombo_Estado;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 90)
            {
                sqlDataSource1.Fill();
                seg = 0;
            }
        }


        private void grvEmpleados_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //GridView view = sender as GridView;
            //int row = view.GetRowHandle(e.ListSourceRowIndex);
            //ITable Hora = (ITable)view.GetRow(row);
            if (e.Column.FieldName == "HoraT")
            {
                string d = (((ResultRow)e.Row).ToList()[3]).ToString();
                if (e.IsGetData)
                    e.Value = TimeSpan.FromSeconds(Convert.ToDouble(d));
            }
        }
    }
}
