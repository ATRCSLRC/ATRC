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
                    case Enums.UbicacionExtintor.Almacen:
                        lciOficina.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lueUnidad.EditValue = txtOficina.EditValue = null;
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
            Extintor.UbicacionExtintor = (Enums.UbicacionExtintor)rgUbicacion.EditValue;
            Extintor.Peso = Convert.ToDecimal(txtPeso.Text);
            Extintor.Tipo = rgTipo.Text;
            Extintor.EstadoExtintor = (Enums.EstadoExtintor)rgEstado.EditValue;
            switch(Extintor.UbicacionExtintor)
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

            if(EsInventario)
            {
                Extintor.FechaInventario = DateTime.Now;
                Extintor.UltimoComentario = memoComentarios.Text;
                GuardarHistorial();
            }
            
        }

        private void GuardarHistorial()
        {
            HistorialExtintores Extintor = new HistorialExtintores(Unidad);
            Extintor.NumExtintor = Convert.ToInt32(txtExtintor.Text);
            Extintor.FechaRecarga = dteFechaRecarga.DateTime;
            Extintor.FechaVencimiento = dteVencimiento.DateTime;
            Extintor.UbicacionExtintor = (Enums.UbicacionExtintor)rgUbicacion.EditValue;
            Extintor.Peso = Convert.ToDecimal(txtPeso.Text);
            Extintor.Tipo = rgTipo.Text;
            Extintor.EstadoExtintor = (Enums.EstadoExtintor)rgEstado.EditValue;
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
            Extintor.FechaInventario = DateTime.Now;
            Extintor.UltimoComentario = memoComentarios.Text;
        }

        private void IniciarControles()
        {
            rgUbicacion.Properties.Items.AddEnum(typeof(Enums.UbicacionExtintor));
            rgEstado.Properties.Items.AddEnum(typeof(Enums.EstadoExtintor));
            XPView xpc = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", null);
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
                lciComentarios.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
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
