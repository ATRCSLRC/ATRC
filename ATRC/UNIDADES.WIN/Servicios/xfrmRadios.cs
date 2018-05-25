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

namespace UNIDADES.WIN
{
    public partial class xfrmRadios : xfrmBase
    {
        public xfrmRadios()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Radios Radio;

        #region Eventos
        private void xfrmRadios_Load(object sender, EventArgs e)
        {
            IniciarControles();
            LigarControles();
        }

        private void rgDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            if (rg != null)
            {
                Enums.TipoDestino Destino = (Enums.TipoDestino)rg.EditValue;
                
                
                switch (Destino)
                {
                    case Enums.TipoDestino.Unidad:
                        lciUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lueUsuario.EditValue = null;
                        break;
                    case Enums.TipoDestino.Empleado:
                        lciUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
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
                    if ((Enums.TipoDestino)rgDestino.EditValue == Enums.TipoDestino.Unidad)
                    {
                        Radio.Unidad = ((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject());
                        Radio.Usuario = null;
                    }
                    else
                    {
                        Radio.Unidad = null;
                        Radio.Usuario = ((Usuario)((ViewRecord)lueUsuario.EditValue).GetObject());
                    }
                    Radio.Save();
                    Unidad.CommitChanges();
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();

        }

        #endregion

        #region Metodos
        private void IniciarControles()
        {
            rgDestino.Properties.Items.AddEnum(typeof(Enums.TipoDestino));
            XPView xpc = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", null);
            lueUnidad.Properties.DataSource = xpc;
            lueUnidad.Properties.DisplayMember = "Nombre";
            lueUnidad.Properties.BestFit();

            XPView xpUsuarios = new XPView(Unidad, typeof(Usuario));
            xpUsuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            lueUsuario.Properties.DataSource = xpUsuarios;
            lueUsuario.Properties.DisplayMember = "Nombre";
            lueUsuario.Properties.BestFit();
            if (Radio.Destino == Enums.TipoDestino.Unidad)
                lueUnidad.EditValue = lueUnidad.Properties.GetKeyValueByDisplayText(Radio.Unidad.Nombre);
            else
                lueUsuario.EditValue = lueUsuario.Properties.GetKeyValueByDisplayText(Radio.Usuario.NumEmpleado.ToString() + " - " + Radio.Usuario.Nombre); //Radio.Usuario;
        }

        private void LigarControles()
        {
            txtMarca.DataBindings.Add("EditValue", Radio, "Marca", true, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("EditValue", Radio, "Modelo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSerie.DataBindings.Add("EditValue", Radio, "Serie", true, DataSourceUpdateMode.OnPropertyChanged);
            rgDestino.DataBindings.Add("EditValue", Radio, "Destino", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                XtraMessageBox.Show("Debe agregar la marca.");
                txtMarca.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                XtraMessageBox.Show("Debe agregar el modelo.");
                txtMarca.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSerie.Text))
            {
                XtraMessageBox.Show("Debe agregar la serie.");
                txtMarca.Focus();
                return false;
            }
            return true;
        }

        #endregion
    }
}
