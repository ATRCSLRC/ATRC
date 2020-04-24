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

namespace RUTAS.WIN
{
    public partial class xfrmPrecioServicio : xfrmBase
    {
        public xfrmPrecioServicio()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public PreciosServicios PrecioServicio;
        public bool EsNuevo;
        public Empresas Empresa;
        private void xfrmPrecioServicio_Load(object sender, EventArgs e)
        {
            //Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Servicios = new XPView(Unidad, typeof(Servicio), "Oid;Clave;Descripcion", null);
            lueServicios.Properties.DataSource = Servicios;
            if (!EsNuevo)
            {
                lueServicios.EditValue = PrecioServicio.Servicio.Oid;
                spnPrecio.EditValue = PrecioServicio.Precio;
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
                        PreciosServicios PrecioServicio = new PreciosServicios(Unidad);
                        PrecioServicio.Servicio = PrecioServicio.Session.GetObjectByKey<Servicio>(lueServicios.EditValue);
                        PrecioServicio.Precio = Convert.ToDecimal(spnPrecio.EditValue);
                        PrecioServicio.Empresa = Empresa;
                        PrecioServicio.Save();
                        Unidad.CommitChanges();
                    }
                    else
                    {
                        PrecioServicio.Servicio = PrecioServicio.Session.GetObjectByKey<Servicio>(lueServicios.EditValue);
                        PrecioServicio.Precio = Convert.ToDecimal(spnPrecio.EditValue);
                        PrecioServicio.Save();
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
            if (lueServicios.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un servicio.");
                lueServicios.Focus();
                return false;
            }

            if (Convert.ToDecimal(spnPrecio.EditValue) <= 0)
            {
                XtraMessageBox.Show("Debe ingresar un precio del servicio.");
                spnPrecio.Focus();
                return false;
            }

            return true;
        }

        private bool Existe()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Servicio.Oid", lueServicios.EditValue));
            go.Operands.Add(new BinaryOperator("Empresa.Oid", Empresa.Oid));
            XPView PreciosServicios = new XPView(UnidadConsulta, typeof(PreciosServicios), "Oid", go);
            if (PreciosServicios.Count > 0)
            {
                if (PrecioServicio != null)
                {
                    if (Convert.ToInt32(PreciosServicios[0]["Oid"]) == PrecioServicio.Oid)
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
