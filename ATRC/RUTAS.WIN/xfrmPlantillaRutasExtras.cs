using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmPlantillaRutasExtras : xfrmBase
    {
        public xfrmPlantillaRutasExtras()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public PlantillaRutas Plantilla;
        public bool EsNuevo;

        private void xfrmPlantillaRutasExtras_Load(object sender, EventArgs e)
        {
            Loading.ShowWaitForm();
            XPView Maquiladoras = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
            lueMaquiladora.Properties.DataSource = Maquiladoras;
            if (!EsNuevo)
            {
                LigarControles();
            }
            flpAcciones.ShowPopup();
            Loading.CloseWaitForm();
        }
        private void LigarControles()
        {
            txtNombre.Text = Plantilla.Nombre;
            lueMaquiladora.EditValue = Plantilla.Empresa == null ? -1 : Plantilla.Empresa.Oid;
            grdRutasExtras.DataSource = Plantilla.PlantillasRutasFijas;
               
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (Plantilla != null)
                {
                    Plantilla.Nombre = txtNombre.Text;
                    Plantilla.Empresa = Unidad.GetObjectByKey<Empresas>(lueMaquiladora.EditValue);
                    Plantilla.Save();
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se han guardado los cambios correctamente.");
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void flpAcciones_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {

            switch (e.Button.Caption)
            {
                case "Agregar ruta":
                    
                    xfrmRutasExtras xfrmAgregar = new xfrmRutasExtras();
                    xfrmAgregar.EsPlantilla = true;
                    xfrmAgregar.PlantillaRuta = Plantilla;
                    xfrmAgregar.ShowDialog();
                    if(grdRutasExtras.DataSource == null)
                        grdRutasExtras.DataSource = Plantilla.PlantillasRutasFijas;
                    break;

                case "Modificar ruta":
                    PlantillaRutaFija PlantillaRutaExtraModificar = grvRutasExtras.GetFocusedRow() as PlantillaRutaFija;
                    if (PlantillaRutaExtraModificar != null)
                    {
                        xfrmRutasExtras xfrmModificar = new xfrmRutasExtras();
                        xfrmModificar.EsPlantilla = true;
                        xfrmModificar.EsModificacion = true;
                        xfrmModificar.PlantillaRutaExtraEditar = PlantillaRutaExtraModificar;
                        xfrmModificar.ShowDialog();
                    }
                    break;

                case "Eliminar ruta":
                    PlantillaRutaFija PlantillaRutaExtra = grvRutasExtras.GetFocusedRow() as PlantillaRutaFija;
                    if (PlantillaRutaExtra != null)
                    {
                        if (XtraMessageBox.Show("¿Está seguro de querer eliminar la plantilla la ruta seleccionada ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            PlantillaRutaExtra.Delete();
                        }
                    }
                    break;
            }
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe agregar un nombre a la plantilla.");
                txtNombre.Focus();
                return false;
            }

            if(lueMaquiladora.EditValue == null)
            {
                XtraMessageBox.Show("Debe selecionar una maquiladora.");
                lueMaquiladora.Focus();
                return false;
            }

            return true;
        }
    }
}
