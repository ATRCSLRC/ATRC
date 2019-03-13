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
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmPedidoDiesel : xfrmBase
    {
        public xfrmPedidoDiesel()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo UnidadControles;
        public bool Captura = false;
        private void xfrmPedidoDiesel_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); }));
        }

        private void IniciarControles()
        {
            dteFecha.DateTime = DateTime.Now;
            UnidadControles = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BinaryOperator bo = new BinaryOperator("Combustible", Combustible.Diesel);

            XPView Unidades = new XPView(UnidadControles, typeof(Unidad));
            Unidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            Unidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Unidades.Criteria = bo;
            lueUnidad.Properties.DataSource = Unidades;
            txtEmpleado.Focus();
            lueUnidad.ItemIndex = 0;
        }
        private void LimipiarControles()
        {
            txtEmpleado.Focus();
            lueUnidad.ItemIndex = 0;
            txtEmpleado.EditValue = null;
            lblEmpleado.Text = string.Empty;
        }

        private void txtEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtEmpleado.Text))
            {
                Usuario Usuario = UnidadControles.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                if (Usuario != null)
                {
                    lblEmpleado.Text = Usuario.Nombre;
                    lueUnidad.Focus();
                }
                else
                {
                    XtraMessageBox.Show("No existe usuario con este número de empleado.");
                    lblEmpleado.Text = string.Empty;
                    txtEmpleado.EditValue = null;
                }
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de guardar el pedido a la unidad '" + lueUnidad.Text + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Unidad UnidadDiesel = Unidad.GetObjectByKey<Unidad>(lueUnidad.EditValue);

                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Unidad", UnidadDiesel));
                go.Operands.Add(new BinaryOperator("Fecha", dteFecha.DateTime.Date));
                XPView UnidadesConDiesel = new XPView(Unidad, typeof(Diesel), "Oid", go);
                if (UnidadesConDiesel.Count > 0)
                {
                    XtraMessageBox.Show("La unidad ya se encuentra registrada.");
                    LimipiarControles();
                }
                else
                {
                    Usuario Usuario = UnidadControles.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                    if (Usuario == null)
                    {
                        XtraMessageBox.Show("No existe usuario con este número de empleado.");
                        lblEmpleado.Text = string.Empty;
                        txtEmpleado.EditValue = null;
                    }
                    else
                    {
                        Diesel Diesel = new Diesel(Unidad);
                        Diesel.Empleado = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                        Diesel.Unidad = UnidadDiesel;
                        Diesel.Fecha = dteFecha.DateTime.Date;
                        Diesel.Save();
                        Unidad.CommitChanges();
                        XtraMessageBox.Show("La unidad se ha se registrado correctamente.");
                        LimipiarControles();
                    }
                }
                if (Captura)
                    this.Close();
            }

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lueUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & lueUnidad != null)
            {
                bbiGuardar.PerformClick();
            }
        }
    }
}
