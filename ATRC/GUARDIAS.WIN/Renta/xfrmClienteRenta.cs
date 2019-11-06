using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN
{
    public partial class xfrmClienteRenta : xfrmBase
    {
        public xfrmClienteRenta()
        {
            InitializeComponent();
        }
        public bool EsNuevo = false;
        public ClientesRenta Cliente = null;

        private void xfrmClienteRenta_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            if (!EsNuevo)
            {
                txtNombre.Text = Cliente.Nombre;
                txtCiudad.Text = Cliente.Ciudad;
                txtColonia.Text = Cliente.Colonia;
                txtCP.Text = Cliente.CP;
                txtDomicilio.Text = Cliente.Domicilio;
                txtEstado.Text = Cliente.Estado;
                txtTel.Text = Cliente.Tel;
                txtNombreReferencia.Text = Cliente.NombreReferencia;
                txtDomicilioReferencia.Text = Cliente.DomicilioReferencia;
                txtTelReferencia.Text = Cliente.TelReferencia;
                Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
            }
            else
            {
                Cliente = new ClientesRenta(Unidad);
            }
            grdDocumentos.DataSource = Cliente.Documentos;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (EsNuevo)
            {
                if (!Existe(txtNombre.Text))
                {
                    Guardar();
                }
            }else
            {
                Guardar();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            fypEdicion.ShowPopup();
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Nuevo documento":
                    xfrmDocumento xfrmNuevo = new xfrmDocumento();
                    xfrmNuevo.EsNuevo = true;
                    xfrmNuevo.Cliente = Cliente;
                    xfrmNuevo.ShowDialog();
                    break;
                case "Modificar documento":
                    DocumentosClientes Doc = grvDocumentos.GetFocusedRow() as DocumentosClientes;
                    xfrmDocumento xfrmModificar = new xfrmDocumento();
                    xfrmModificar.EsNuevo = false;
                    xfrmModificar.Cliente = Cliente;
                    xfrmModificar.Doc = Doc;
                    xfrmModificar.ShowDialog();
                    break;
            }

            //(grdDocumentos.DataSource as XPCollection<DocumentosClientes>).Reload();
        }

        private void grvDocumentos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DocumentosClientes Documento = grvDocumentos.GetFocusedRow() as DocumentosClientes;
            //HistoricoChecadas Historico = grvHistorialChecadas.GetFocusedRow() as HistoricoChecadas;
            if (Documento != null)
            {
                if (!string.IsNullOrEmpty(Documento.Archivo))
                {
                    byte[] image = Convert.FromBase64String(Documento.Archivo);
                    MemoryStream stream = new MemoryStream(image);
                    Image returnImage = Image.FromStream(stream);
                    picVistaPrevia.EditValue = stream.ToArray();
                }
                else
                    picVistaPrevia.Image = null;

            }
        }

        private bool Existe(string Nombre)
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Clientes = new XPView(UnidadConsulta, typeof(ClientesRenta), "Oid;Nombre", new BinaryOperator("Nombre", Nombre));
            if (Clientes.Count > 0)
                return true;
            return false;
        }

        private void Guardar()
        {
            Cliente.Nombre = txtNombre.Text;
            Cliente.Ciudad = txtCiudad.Text;
            Cliente.Colonia = txtColonia.Text;
            Cliente.CP = txtCP.Text;
            Cliente.Domicilio = txtDomicilio.Text;
            Cliente.Estado = txtEstado.Text;
            Cliente.Tel = txtTel.Text;
            Cliente.NombreReferencia = txtNombreReferencia.Text;
            Cliente.DomicilioReferencia = txtDomicilioReferencia.Text;
            Cliente.TelReferencia = txtTelReferencia.Text;
            Cliente.Save();
            Cliente.Session.CommitTransaction();
            this.Close();
        }
    }
}
