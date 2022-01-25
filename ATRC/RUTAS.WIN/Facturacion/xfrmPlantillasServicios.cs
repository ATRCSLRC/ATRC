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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.Facturacion
{
    public partial class xfrmPlantillasServicios : xfrmBase
    {
        public xfrmPlantillasServicios()
        {
            InitializeComponent();
        }

        public int IDServicio;
        public bool EsNuevo = false;
        UnidadDeTrabajo Unidad;
        PlantillaServiciosRealizados Plantilla;

        private void xfrmPlantillasServicios_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();


            if (EsNuevo)
            {
                Plantilla = new PlantillaServiciosRealizados(Unidad);
                lueCliente.Properties.DataSource = IniciarClientes();
            }
            else
            {
                Plantilla = Unidad.GetObjectByKey<PlantillaServiciosRealizados>(IDServicio);
                lueCliente.Properties.DataSource = IniciarClientes();
                CargarValoresModificar();
            }

        }

        private void chkAgruparRutas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgruparRutas.Checked)
            {
                lciAgruparApoyos.Visibility = lciSeparaServiciosValle.Visibility = lciSepararPorNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciAgruparApoyos.Visibility = lciSeparaServiciosValle.Visibility = lciSepararPorNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                chkAgruparApoyos.Checked = chkSepararServiciosValle.Checked = chkSepararPorNombre.Checked = false;
            }
        }

        private void chkMostrarTextoEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarTextoEntrada.Checked)
                lciTextoEntrada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciTextoEntrada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void chkMostrarTextoSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarTextoSalida.Checked)
                lciTextoSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciTextoSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lueCliente.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar una empresa.");
                lueCliente.Focus();
                return;
            }
                
            Plantilla.Empresa = Unidad.GetObjectByKey<Empresas>(lueCliente.EditValue);
            Plantilla.AgruparPorRutas = chkAgruparRutas.Checked;
            Plantilla.AgruparApoyos = chkAgruparApoyos.Checked;
            Plantilla.SepararServiciosValle = chkSepararServiciosValle.Checked;
            Plantilla.SepararPorNombre = chkSepararPorNombre.Checked;
            Plantilla.MostrarNombreRuta = chkMostrarNombreRuta.Checked;
            Plantilla.MostrarPorTurno = chkMostrarPorTurno.Checked;
            Plantilla.MostrarTextoEntrada = chkMostrarTextoEntrada.Checked;
            if (chkMostrarTextoEntrada.Checked)
                Plantilla.TextoEntrada = txtTextoEntrada.Text;
            else
                Plantilla.TextoEntrada = string.Empty;

            Plantilla.MostrarTextoSalida = chkMostrarTextoSalida.Checked;
            if (chkMostrarTextoSalida.Checked)
                Plantilla.TextoSalida = txtTextoSalida.Text;
            else
                Plantilla.TextoSalida = string.Empty;
            
            Plantilla.Save();
            Unidad.CommitChanges();
            XtraMessageBox.Show("La información se guardo correctamente.");
            this.Close();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CargarValoresModificar()
        {
            lueCliente.EditValue = Plantilla.Empresa.Oid;
            lueCliente.ReadOnly = true;
            lueCliente.Enabled = false;
            chkAgruparRutas.Checked = Plantilla.AgruparPorRutas;
            chkAgruparApoyos.Checked = Plantilla.AgruparApoyos;
            chkSepararServiciosValle.Checked = Plantilla.SepararServiciosValle;
            chkSepararPorNombre.Checked = Plantilla.SepararPorNombre;
            chkMostrarNombreRuta.Checked = Plantilla.MostrarNombreRuta;
            chkMostrarPorTurno.Checked = Plantilla.MostrarPorTurno;
            chkMostrarTextoEntrada.Checked = Plantilla.MostrarTextoEntrada;
            chkMostrarTextoSalida.Checked = Plantilla.MostrarTextoSalida;
            txtTextoEntrada.Text = Plantilla.TextoEntrada;
            txtTextoSalida.Text = Plantilla.TextoSalida;
        }

        private List<ClienteFiltro> IniciarClientes()
        {
            List<ClienteFiltro> ListaClienteFiltro = new List<ClienteFiltro>();
            XPView Clientes = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
            XPView PlantillaClientes = new XPView(Unidad, typeof(PlantillaServiciosRealizados), "Oid;Empresa.Oid;Empresa.Nombre", null);
            
            foreach(ViewRecord viewCliente in Clientes)
            {
                bool Agregar = true;
                if (PlantillaClientes.Count > 0)
                {
                    foreach (ViewRecord viewPlantillaClientes in PlantillaClientes)
                    {
                        if(Convert.ToInt32(viewCliente["Oid"]) == Convert.ToInt32(viewPlantillaClientes["Empresa.Oid"]))
                        {
                            if (Plantilla.Empresa != null)
                            {
                                if (Plantilla.Empresa.Oid != Convert.ToInt32(viewCliente["Oid"]))
                                {
                                    Agregar = false;
                                    continue;
                                }
                            }
                            else {
                                Agregar = false;
                                continue;
                            }
                        }
                    }
                }
                if(Agregar)
                {
                    ClienteFiltro ClienteFiltro = new ClienteFiltro();
                    ClienteFiltro.ID = Convert.ToInt32(viewCliente["Oid"]);
                    ClienteFiltro.Nombre = viewCliente["Nombre"].ToString();
                    ListaClienteFiltro.Add(ClienteFiltro);
                }
            }
            return ListaClienteFiltro;
        }

        public class ClienteFiltro
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
        }

    }
}
