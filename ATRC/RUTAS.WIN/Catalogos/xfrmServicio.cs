using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
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

namespace RUTAS.WIN.Catalogos
{
    public partial class xfrmServicio : xfrmBase
    {
        public xfrmServicio()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Servicio Servicio;
        public bool EsNuevo;

        private void xfrmServicio_Load(object sender, EventArgs e)
        {
            cmbTipoUnidad.Properties.Items.AddRange(typeof(Enums.TipoUnidad).GetEnumValues());
            if(!EsNuevo)
            {
                txtClave.Text = Servicio.Clave;
                chkMediaVuelta.Checked = Servicio.EsMediaVuelta;
                txtDescripcion.Text = Servicio.Descripcion;
                cmbTipoUnidad.EditValue = Servicio.TipoUnidad;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validar())
            {
                if (!Existe())
                {
                    if (EsNuevo)
                    {
                        Servicio Servicio = new Servicio(Unidad);
                        Servicio.Clave = txtClave.Text;
                        Servicio.Descripcion = txtDescripcion.Text;
                        Servicio.EsMediaVuelta = chkMediaVuelta.Checked;
                        Servicio.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
                        Servicio.Save();
                        Unidad.CommitChanges();
                    }
                    else
                    {
                        Servicio.EsMediaVuelta = chkMediaVuelta.Checked;
                        Servicio.Clave = txtClave.Text;
                        Servicio.Descripcion = txtDescripcion.Text;
                        Servicio.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
                        Servicio.Save();
                        Unidad.CommitChanges();
                    }
                    XtraMessageBox.Show("Se ha guardado la información correctamente.");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Este servicio ya existe.");
                }
                
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            if(string.IsNullOrEmpty(txtClave.Text))
            {
                XtraMessageBox.Show("Debe agregar una clave.");
                txtClave.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                XtraMessageBox.Show("Debe agregar una descripción.");
                txtDescripcion.Focus();
                return false;
            }

            if (cmbTipoUnidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un tipo de unidad.");
                cmbTipoUnidad.Focus();
                return false;
            }
            return true;
        }

        private bool Existe()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Servicios = new XPView(UnidadConsulta, typeof(Servicio), "Oid;Clave", new BinaryOperator("Clave", txtClave.Text));
            if (Servicios.Count > 0)
            {
                if (Servicio != null)
                {
                    if (Convert.ToInt32(Servicios[0]["Oid"]) == Servicio.Oid)
                    {
                        return false;
                    }
                }
                else
                {
                    return true;

                }
            }
            return false;
        }
    }
}
