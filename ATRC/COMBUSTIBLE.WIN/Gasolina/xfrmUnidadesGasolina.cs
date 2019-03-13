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
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmUnidadesGasolina : xfrmBase
    {
        public xfrmUnidadesGasolina()
        {
            InitializeComponent();
        }

        private void xfrmUnidadesGasolina_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Unidades = new XPView(Unidad, typeof(UNIDADES.BL.Unidad), "Oid;Nombre", new BinaryOperator("Combustible", Enums.Combustible.Gasolina));
            Unidades.Sorting.Add(new SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdUnidades.DataSource = Unidades;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<ViewRecord> Unidades = new List<ViewRecord>();
            Int32[] selectedRowHandles = grvUnidades.GetSelectedRows();
            if (selectedRowHandles.Length > 0)
            {
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                    {

                        ViewRecord viewUnidad = (ViewRecord)grvUnidades.GetRow(selectedRowHandle);
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Unidad.Oid", viewUnidad["Oid"]));
                        go.Operands.Add(new BinaryOperator("Fecha", DateTime.Now.Date));
                        XPView UnidadesConDiesel = new XPView(Unidad, typeof(Gasolina), "Oid", go);
                        if (UnidadesConDiesel.Count <= 0)
                        {
                            Gasolina Gasolina = new Gasolina(Unidad);
                            Gasolina.Empleado = Utilerias.ObtenerUsuarioActual(Unidad);
                            Gasolina.Unidad = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(Convert.ToInt32(viewUnidad["Oid"]));
                            Gasolina.Fecha = DateTime.Now.Date;
                            Gasolina.Save();
                        }
                    }
                }
                Unidad.CommitChanges();
                XtraMessageBox.Show("Las unidades se ha se registrado correctamente.");
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar al menos una unidad.");
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
