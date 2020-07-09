using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmPlantillasRutasFijasGRD : xfrmBase
    {
        public xfrmPlantillasRutasFijasGRD()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public List<Int32> PlantillaRutas;
        public Empresas Empresa;
        public bool AsignarPlantilla;
        private void xfrmPlantillasRutasExtrasGRD_Load(object sender, EventArgs e)
        {
            bbiAgregar.Visibility = Utilerias.VisibilidadPermiso("NuevaPlantilla");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarPlantilla");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarPlantilla");
            bbiClonar.Visibility = Utilerias.VisibilidadPermiso("ClonarPlantilla");

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Rutas = new XPView(Unidad, typeof(PlantillaRutas), "Oid;Nombre;Empresa.Nombre", null);
            
            if(AsignarPlantilla)
            {
                bbiAgregar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiModificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiEliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                Rutas.Criteria = new BinaryOperator("Empresa.Oid", Empresa.Oid);
                grvPlantillas.OptionsSelection.MultiSelect = true;
                grvPlantillas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            }
            else
            {
                bbiAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            grdPlantillas.DataSource = Rutas;
        }

        private void bbiAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmPlantillaRutasFijas xfrm = new xfrmPlantillaRutasFijas())
            {
                UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = NuevaUnidad; 
                xfrm.EsNuevo = true;
                xfrm.Plantilla = new PlantillaRutas(NuevaUnidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdPlantillas.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPlantilla = grvPlantillas.GetFocusedRow() as ViewRecord;
            if (ViewPlantilla != null)
                using (xfrmPlantillaRutasFijas xfrm = new xfrmPlantillaRutasFijas())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Plantilla = (PlantillaRutas)ViewPlantilla.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdPlantillas.DataSource).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPlantilla = grvPlantillas.GetFocusedRow() as ViewRecord;
            if (ViewPlantilla != null)
            {
                PlantillaRutas Plantilla = (PlantillaRutas)ViewPlantilla.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la plantilla " + Plantilla.Empresa.Nombre + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Plantilla.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdPlantillas.DataSource).Reload();
                }
            }
        }

        private void bbiAsignar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(grvPlantillas.GetSelectedRows().Count() > 0)
            {
                if (XtraMessageBox.Show("¿Está seguro de querer asignar la(s) plantilla(s) seleccionada(s)?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PlantillaRutas = new List<Int32>();
                    Int32[] selectedRowHandles = grvPlantillas.GetSelectedRows();
                    for (int i = 0; i < selectedRowHandles.Length; i++)
                    {
                        int selectedRowHandle = selectedRowHandles[i];
                        if (selectedRowHandle >= 0)
                            PlantillaRutas.Add(Convert.ToInt32(((ViewRecord)grvPlantillas.GetRow(selectedRowHandle))["Oid"]));
                    }
                    this.Close();
                }
            }else
            {
                XtraMessageBox.Show("Debe seleccionar una plantilla.");
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiClonar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewPlantilla = grvPlantillas.GetFocusedRow() as ViewRecord;
            if (ViewPlantilla != null)
            {
                PlantillaRutas Plantilla = (PlantillaRutas)ViewPlantilla.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer clonar la plantilla " + Plantilla.Empresa.Nombre + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PlantillaRutas PlantillaClonada = new PlantillaRutas(Unidad);
                    PlantillaClonada.Nombre = Plantilla.Nombre + " - " +Guid.NewGuid().ToString().Substring(0,8);
                    PlantillaClonada.Empresa = Plantilla.Empresa;
                    PlantillaClonada.EsExterno = Plantilla.EsExterno;
                    foreach(PlantillaRutaFija PlantillaRuta in Plantilla.PlantillasRutasFijas)
                    {
                        PlantillaRutaFija PlantillaRutaClon = new PlantillaRutaFija(PlantillaRuta.Session);
                        PlantillaRutaClon.TipoRuta = PlantillaRuta.TipoRuta;
                        PlantillaRutaClon.Ruta = PlantillaRuta.Ruta;
                        PlantillaRutaClon.Servicio = PlantillaRuta.Servicio;
                        PlantillaRutaClon.Turno = PlantillaRuta.Turno;
                        PlantillaRutaClon.EsRutaExtra = PlantillaRuta.EsRutaExtra;
                        PlantillaRutaClon.HoraEntrada = PlantillaRuta.HoraEntrada;
                        PlantillaRutaClon.HoraSalida = PlantillaRuta.HoraSalida;
                        PlantillaRutaClon.RutaCompleta = PlantillaRuta.RutaCompleta;
                        PlantillaRutaClon.ChoferEntrada = PlantillaRuta.ChoferEntrada;
                        PlantillaRutaClon.PagarChoferEntrada = PlantillaRuta.PagarChoferEntrada;
                        PlantillaRutaClon.ChoferSalida = PlantillaRuta.ChoferSalida;
                        PlantillaRutaClon.PagarChoferSalida = PlantillaRuta.PagarChoferSalida;
                        PlantillaRutaClon.Comentarios = PlantillaRuta.Comentarios;
                        PlantillaRutaClon.ComentariosFacturacion = PlantillaRuta.ComentariosFacturacion;
                        PlantillaClonada.PlantillasRutasFijas.Add(PlantillaRutaClon);
                        PlantillaRutaClon.Save();
                    }
                    PlantillaClonada.Save();
                    Unidad.CommitChanges();
                    ((XPView)grdPlantillas.DataSource).Reload();
                }
            }
        }
    }
}
