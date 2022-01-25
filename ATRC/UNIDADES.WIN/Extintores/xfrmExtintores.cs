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
using UNIDADES.BL.Clases;

namespace UNIDADES.WIN
{
    public partial class xfrmExtintores : xfrmBase
    {
        public xfrmExtintores()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Extintores Extintor;
        public bool EsNuevo = false;
        public bool EsInventario = false;
        #region Eventos
        private void xfrmRadios_Load(object sender, EventArgs e)
        {
            IniciarControles();
        }

        private void rgDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            if (rg != null)
            {
                Enums.UbicacionExtintor UbicacionExtintor = (Enums.UbicacionExtintor)rg.EditValue;
                
                
                switch (UbicacionExtintor)
                {
                    case Enums.UbicacionExtintor.Unidad:
                        lciOficina.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        txtOficina.EditValue = null;
                        break;
                    case Enums.UbicacionExtintor.Oficina:
                        lciOficina.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lueUnidad.EditValue = null;
                        break;
                }
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Guardar();
                    Extintor.Save();
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se han guardado correctamente.");
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        #endregion

        #region Metodos

        private void Guardar()
        {
            if (Extintor == null)
                Extintor = new Extintores(Unidad);
            Extintor.NumExtintor = Convert.ToInt32(txtExtintor.Text);
            Extintor.FechaRecarga = dteFechaRecarga.DateTime;
            Extintor.FechaVencimiento = dteVencimiento.DateTime;
            Extintor.EstadoExtintor = (Enums.EstadoExtintor)rgEstado.EditValue;

            if(EsInventario)
            {
                Extintor.FechaInventario = DateTime.Now;
                Extintor.UltimoComentario = memoComentarios.Text;
            }
            else
            {
                Extintor.UbicacionExtintor = (Enums.UbicacionExtintor)rgUbicacion.EditValue;
                Extintor.Peso = Convert.ToDecimal(txtPeso.Text);
                Extintor.Tipo = rgTipo.Text;
                switch (Extintor.UbicacionExtintor)
                {
                    case Enums.UbicacionExtintor.Unidad:
                        Extintor.Unidad = Unidad.GetObjectByKey<Unidad>(lueUnidad.EditValue);
                        Extintor.Oficina = string.Empty;
                        break;
                    case Enums.UbicacionExtintor.Oficina:
                        Extintor.Oficina = txtOficina.Text;
                        Extintor.Unidad = null;
                        break;
                }
            }
            GuardarHistorial(Extintor);

        }

        private void GuardarHistorial(Extintores ExtintorOriginal)
        {
            HistorialExtintores Extintor = new HistorialExtintores(Unidad);
            Extintor.NumExtintor = ExtintorOriginal.NumExtintor;
            Extintor.FechaRecarga = ExtintorOriginal.FechaRecarga;
            Extintor.FechaVencimiento = ExtintorOriginal.FechaVencimiento;
            Extintor.UbicacionExtintor = ExtintorOriginal.UbicacionExtintor;
            Extintor.Peso = ExtintorOriginal.Peso;
            Extintor.Tipo = ExtintorOriginal.Tipo;
            Extintor.EstadoExtintor = ExtintorOriginal.EstadoExtintor;
            switch (Extintor.UbicacionExtintor)
            {
                case Enums.UbicacionExtintor.Unidad:
                    Extintor.Unidad = ExtintorOriginal.Unidad;
                    Extintor.Oficina = string.Empty;
                    break;
                case Enums.UbicacionExtintor.Oficina:
                    Extintor.Oficina = ExtintorOriginal.Oficina;
                    Extintor.Unidad = null;
                    break;
            }
            Extintor.FechaInventario = DateTime.Now;
            Extintor.UltimoComentario = memoComentarios.Text;
        }

        private void IniciarControles()
        {
            rgUbicacion.Properties.Items.AddEnum(typeof(Enums.UbicacionExtintor));
            rgEstado.Properties.Items.AddEnum(typeof(Enums.EstadoExtintor));
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));

            GroupOperator goSeccion = new GroupOperator(GroupOperatorType.Or);
            goSeccion.Operands.Add(new BinaryOperator("EsSeccion", false));
            goSeccion.Operands.Add(new NullOperator("EsSeccion"));

            goMain.Operands.Add(go);
            goMain.Operands.Add(goSeccion);
            XPView xpc = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", goMain);
            lueUnidad.Properties.DataSource = xpc;
            dteFechaRecarga.DateTime = dteVencimiento.DateTime = DateTime.Now;

            if (!EsNuevo)
            {
                txtExtintor.Text = Extintor.NumExtintor.ToString();
                dteFechaRecarga.DateTime = Extintor.FechaRecarga;
                dteVencimiento.DateTime = Extintor.FechaVencimiento;
                rgUbicacion.EditValue = Extintor.UbicacionExtintor;
                txtPeso.Text = Extintor.Peso.ToString();
                rgEstado.EditValue = Extintor.EstadoExtintor;

                switch (Extintor.UbicacionExtintor)
                {
                    case Enums.UbicacionExtintor.Unidad:
                        lueUnidad.EditValue = Extintor.Unidad.Oid;
                        break;
                    case Enums.UbicacionExtintor.Oficina:
                        txtOficina.Text = Extintor.Oficina;
                        break;
                }
            }else
            {
                rgUbicacion.SelectedIndex = 0;
                rgEstado.SelectedIndex = 0;
            }
            if (EsInventario)
            {
                lciComentarios.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciOficina.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciTipoUbicacion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private bool ValidarCampos()
        {
            int n;
            if (string.IsNullOrEmpty(txtExtintor.Text) & int.TryParse(txtExtintor.Text, out n))
            {
                XtraMessageBox.Show("Debe agregar el número de extintor.");
                txtExtintor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                XtraMessageBox.Show("Debe agregar el peso del extintor.");
                txtPeso.Focus();
                return false;
            }

            return true;
        }

        #endregion

        private void xfrmExtintores_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
