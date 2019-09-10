using ATRCBASE.BL;
using ATRCBASE.WIN;
using UNIDADES.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using GUARDIAS.BL;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace GUARDIAS.WIN
{
    public partial class xfrmContrato : xfrmBase
    {
        public xfrmContrato()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        ContratoRenta Contrato;
        ClientesRenta Cliente;
        public int IDContrato;
        private void xfrmContrato_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //GroupOperator go = new GroupOperator();
            //go.Operands.Add( new BinaryOperator("EstadoRenta", Enums.EstadoRenta.Disponible));
            //go.Operands.Add();
            XPView Unidades = new XPView(Unidad, typeof(Unidad), "Oid;Nombre", new BinaryOperator("EsRenta", true));
            lueUnidad.Properties.DataSource = Unidades;
            if (IDContrato <= 0)
            {
                Contrato = new ContratoRenta(Unidad);
                //grdDocumentos.DataSource = Contrato.Documentos;
                dteSalida.DateTime = DateTime.Now;
                BeginInvoke(new MethodInvoker(delegate { txtResponsable.Focus(); }));
            }
            else
            {
                Contrato = Unidad.GetObjectByKey<ContratoRenta>(IDContrato);
                Modificar();
            }
        }

        #region Eventos
        private void rgCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgCliente.SelectedIndex == 0)
            {
                lcgCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciUsuario.Visibility = espacio.Visibility = lblInstrucciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lblCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                this.Size= new Size(840, 710);
                Contrato.Session.Delete(Contrato.Documentos);
            }
            else
            {
                lcgCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciUsuario.Visibility = espacio.Visibility = lblInstrucciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lblCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                this.Size = new Size(840, 570);
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarDisponibilidad())
                {
                    if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        loading.ShowWaitForm();
                        UNIDADES.BL.Unidad UnidadCamion = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(lueUnidad.EditValue);
                        //ViewRecord viewUnidad = lueUnidad.EditValue as ViewRecord;
                        if (rgCliente.SelectedIndex == 0)
                        {
                            Contrato.Responsable = txtResponsable.Text;
                            Contrato.Domicilio = txtDomicilio.Text;
                            Contrato.Colonia = txtColonia.Text;
                            Contrato.CP = txtCP.Text;
                            Contrato.Ciudad = txtCiudad.Text;
                            Contrato.Estado = txtEstado.Text;
                            Contrato.Tel = txtTel.Text;

                            if (IDContrato <= 0)
                            {
                                if (XtraMessageBox.Show("¿Desea guardar la información de un cliente?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    if (!Existe(Contrato.Responsable))
                                    {
                                        ClientesRenta ClienteNuevo = new ClientesRenta(Contrato.Session);
                                        ClienteNuevo.Nombre = txtResponsable.Text;
                                        ClienteNuevo.Domicilio = txtDomicilio.Text;
                                        ClienteNuevo.Colonia = txtColonia.Text;
                                        ClienteNuevo.CP = txtCP.Text;
                                        ClienteNuevo.Ciudad = txtCiudad.Text;
                                        ClienteNuevo.Estado = txtEstado.Text;
                                        ClienteNuevo.Tel = txtTel.Text;
                                        ClienteNuevo.Documentos.AddRange(Contrato.Documentos);
                                        ClienteNuevo.Save();
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Ya se encuentra registrado el cliente.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Contrato.Cliente = Cliente;
                            Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
                            Contrato.Documentos.AddRange(Cliente.Documentos);
                        }
                        Contrato.EsApartado = rgAccion.SelectedIndex == 1 ? true : false;
                        if(IDContrato <= 0 )
                            Contrato.NumContrato =  NumContrato(Unidad);
                        Contrato.ADondeSeDirige = txtDestino.Text;
                        Contrato.LugarOrigenLugarDestino = txtRecepcionEntrega.Text;
                        Contrato.DiaSalida = dteSalida.DateTime.Date;
                        Contrato.DiaRegreso = dteRegreso.DateTime.Date;
                        Contrato.DiasRenta = spnDiasRenta.Value;
                        Contrato.HoraSalida = timeSalida.Time.TimeOfDay;
                        Contrato.HoraRegreso = timeRegreso.Time.TimeOfDay;
                        Contrato.Costo = Convert.ToDecimal(spnCosto.EditValue);
                        Contrato.TiempoTolerancia = Convert.ToInt32(spnTiempoTolerancia.EditValue);
                        Contrato.CostoTolerancia = Convert.ToDecimal(spnCostoInfraccion.EditValue);
                        Contrato.Iva = Convert.ToDecimal(spnIVA.EditValue);
                        Contrato.Descuento = Convert.ToDecimal(spnDescuento.EditValue);
                        Contrato.Anticipo = Convert.ToDecimal(spnAnticipo.EditValue);
                        Contrato.Subtotal = Convert.ToDecimal(lblTotal.Text.TrimStart('$'));
                        Contrato.Total = Contrato.Subtotal + Contrato.Anticipo;
                        Contrato.Unidad = UnidadCamion;
                        Contrato.EstadoContrato = Contrato.EsApartado ? Enums.EstadoContrato.Apartado: Enums.EstadoContrato.Creado;
                        Contrato.Save();
                        Unidad.CommitChanges();
                       
                        if(IDContrato <= 0)
                        {
                            XtraMessageBox.Show(Contrato.EsApartado ? "Se aparto a unidad correctamente." : "Se creo el contrato correctamente.");
                        }
                        else
                        {
                            XtraMessageBox.Show("Se modifico el contato corretamente.");
                        }

                        if (!Contrato.EsApartado)
                        {
                            REPORTES.Guardias.ContratoRenta RepContrato = new REPORTES.Guardias.ContratoRenta(Contrato.Oid);
                            RepContrato.CreateDocument();

                            REPORTES.Guardias.ClausulasRenta RepClausulas = new REPORTES.Guardias.ClausulasRenta();
                            RepClausulas.CreateDocument();
                            RepContrato.Pages.AddRange(RepClausulas.Pages);

                            REPORTES.Guardias.Pagare RepPagare = new REPORTES.Guardias.Pagare();
                            RepPagare.CreateDocument();
                            RepContrato.Pages.AddRange(RepPagare.Pages);


                            ReportPrintTool repContrato = new ReportPrintTool(RepContrato);
                            repContrato.ShowPreview();
                        }
                        else
                        {
                            string PrecioEscrito = string.Empty;
                            PrecioEscrito = Utilerias.Convertir(Contrato.Anticipo.ToString(), true, "PESOS");
                            int ID = 0;
                            Recibos.GenerarRecibo(Unidad, Contrato.Anticipo, Contrato.Cliente == null ? Contrato.Responsable : Contrato.Cliente.Nombre, "Apartado de renta de la unidad " + Contrato.Unidad.Nombre + ", "  , DateTime.Now, "Pesos", PrecioEscrito, out ID);
                            this.Close();
                            ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(ID));
                            reprecibo.ShowPreview();
                        }
                        loading.CloseWaitForm();
                        LimpiarCampos();
                        this.Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("La unidad se encuentra rentada o apartada en este rango de fechas.");
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.ContratoRenta(7));
            reprecibo.ShowPreview();
            LimpiarCampos();
            
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lueUnidad_EditValueChanged(object sender, EventArgs e)
        {
            //if(lueUnidad.EditValue != null)
            //{
            //    spnCosto.EditValue = lueUnidad.GetColumnValue("PrecioRenta");
            //}
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                using (xfrmClientesRentaGRD xfrm = new xfrmClientesRentaGRD())
                {
                    xfrm.Asignar = false;
                    xfrm.ShowDialog();
                    txtCliente.Text = xfrm.IDCliente.ToString();
                    if(!string.IsNullOrEmpty(txtCliente.Text))
                    {
                       Cliente = Unidad.GetObjectByKey<ClientesRenta>(Convert.ToInt32(txtCliente.Text));
                        if(Cliente != null)
                        {
                            lblCliente.Text = Cliente.Nombre;
                            Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
                            grdDocumentos.DataSource = Cliente.Documentos;
                            //Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
                            //Contrato.Documentos.AddRange(Cliente.Documentos);
                        }
                    }
                }
            }else if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    Cliente = Unidad.GetObjectByKey<ClientesRenta>(Convert.ToInt32(txtCliente.Text));
                    if (Cliente != null)
                    {
                        lblCliente.Text = Cliente.Nombre;
                        Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
                        grdDocumentos.DataSource = Cliente.Documentos;
                        //Cliente.Documentos.Criteria = new BinaryOperator("FechaVigencia", DateTime.Now.Date, BinaryOperatorType.Greater);
                        //Contrato.Documentos.AddRange(Cliente.Documentos);
                        lueUnidad.Focus();
                    }
                }else
                {
                    XtraMessageBox.Show("Debe agregar un número de cliente.");
                }
                
            }
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

        private void spnDiasRenta_Leave(object sender, EventArgs e)
        {
            //if (lueUnidad.EditValue != null)
            //{
            //    spnCosto.EditValue = Convert.ToDecimal(lueUnidad.GetColumnValue("PrecioRenta")) * Convert.ToDecimal(spnDiasRenta.EditValue);
            //}
            //lblTotal.Text = ((Convert.ToDecimal(spnCosto.EditValue) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");

            if (Convert.ToDecimal(spnDiasRenta.EditValue) > 0)
            {
                decimal dias = Math.Floor(Convert.ToDecimal(spnDiasRenta.EditValue));
                DateTime Salida = dteSalida.DateTime.Date;
                dteRegreso.DateTime = timeRegreso.Time = Salida.Date.AddDays(Convert.ToInt32(dias));
            }

            decimal d = Convert.ToInt32(spnDiasRenta.EditValue) - Convert.ToDecimal(spnDiasRenta.EditValue);

            int TotalHoras = timeSalida.Time.Hour + 12;
            if (d > 0)
            {
                int restante = TotalHoras - 24;
                timeRegreso.Time = timeRegreso.Time.AddHours(restante);
                dteRegreso.DateTime = dteRegreso.DateTime.AddDays(1);
            }
            else
            {
                DateTime dt = timeSalida.Time;
                timeRegreso.Time = dt.AddHours(24);
                decimal dias = Math.Floor(Convert.ToDecimal(spnDiasRenta.EditValue));
                DateTime Salida = dteSalida.DateTime.Date;
                dteRegreso.DateTime = Salida.Date.AddDays(Convert.ToInt32(dias));
            }
        }

        private void dteSalida_Leave(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(spnDiasRenta.EditValue)  > 0 )
            {
                decimal dias = Math.Floor(Convert.ToDecimal(spnDiasRenta.EditValue));
                DateTime Salida = dteSalida.DateTime.Date;
                dteRegreso.DateTime = timeRegreso.Time = Salida.Date.AddDays(Convert.ToInt32(dias));
            }
        }

        private void timeSalida_Leave(object sender, EventArgs e)
        {
            decimal d = Convert.ToInt32(spnDiasRenta.EditValue) - Convert.ToDecimal(spnDiasRenta.EditValue);

            int TotalHoras = timeSalida.Time.Hour + 12;
            if (d > 0)
            {
                int restante = TotalHoras - 24;
                timeRegreso.Time = timeRegreso.Time.AddHours(restante);
                dteRegreso.DateTime = dteRegreso.DateTime.AddDays(1);
            }
            else
            {
                DateTime dt = timeSalida.Time;
                timeRegreso.Time = dt.AddHours(24);
                decimal dias = Math.Floor(Convert.ToDecimal(spnDiasRenta.EditValue));
                DateTime Salida = dteSalida.DateTime.Date;
                dteRegreso.DateTime = Salida.Date.AddDays(Convert.ToInt32(dias));
            }
        }

        private void chkFactura_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFactura.Checked)
            {
                lciIVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                spnIVA.EditValue = Convert.ToDouble(lblTotal.Text.TrimStart('$')) * 0.08;                
            }
            else
            {
                lciIVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                spnIVA.EditValue = 0;
            }
            lblTotal.Text = (((Convert.ToDecimal(spnCosto.EditValue) * Convert.ToDecimal(spnDiasRenta.EditValue)) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");
        }

        private void spnAnticipo_EditValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (((Convert.ToDecimal(spnCosto.EditValue) * Convert.ToDecimal(spnDiasRenta.EditValue)) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");
        }

        private void spnDescuento_EditValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (((Convert.ToDecimal(spnCosto.EditValue) * Convert.ToDecimal(spnDiasRenta.EditValue)) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");
        }

        private void spnCosto_EditValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (((Convert.ToDecimal(spnCosto.EditValue) * Convert.ToDecimal(spnDiasRenta.EditValue)) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");
        }

        private void spnIVA_EditValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (((Convert.ToDecimal(spnCosto.EditValue) * Convert.ToDecimal(spnDiasRenta.EditValue)) + Convert.ToDecimal(spnIVA.EditValue)) - (Convert.ToDecimal(spnAnticipo.EditValue) + Convert.ToDecimal(spnDescuento.EditValue))).ToString("C");
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            if (rgCliente.SelectedIndex == 0) {
                fypEdicion.ShowPopup();
            }
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Nuevo documento":
                    xfrmDocumento xfrmNuevo = new xfrmDocumento();
                    xfrmNuevo.EsNuevo = true;
                    xfrmNuevo.EsContrato = true;
                    xfrmNuevo.Contrato = Contrato;
                    xfrmNuevo.ShowDialog();
                    break;
                case "Modificar documento":
                    DocumentosClientes Doc = grvDocumentos.GetFocusedRow() as DocumentosClientes;
                    xfrmDocumento xfrmModificar = new xfrmDocumento();
                    xfrmModificar.EsNuevo = false;
                    xfrmModificar.EsContrato = true;
                    xfrmModificar.Contrato = Contrato;
                    xfrmModificar.IDDoc = Doc.Oid;
                    xfrmModificar.ShowDialog();
                    break;
            }
            grdDocumentos.DataSource = Contrato.Documentos;
        }

        #endregion

        #region Metodos

        private void Modificar()
        {
            if(Contrato.Cliente != null)
            {
                rgCliente.SelectedIndex = 1;
                txtCliente.Text = Contrato.Cliente.Oid.ToString();
                lblCliente.Text = Contrato.Cliente.Nombre;
                Cliente = Contrato.Cliente;
            }else
            {
                txtResponsable.Text = Contrato.Responsable;
                txtDomicilio.Text = Contrato.Domicilio;
                txtColonia.Text = Contrato.Colonia;
                txtCP.Text = Contrato.CP;
                txtCiudad.Text = Contrato.Ciudad;
                txtEstado.Text = Contrato.Estado;
                txtTel.Text = Contrato.Tel;
            }

            rgAccion.SelectedIndex = Contrato.EsApartado ? 1 : 0;
            txtDestino.Text = Contrato.ADondeSeDirige;
            lueUnidad.EditValue = Contrato.Unidad.Oid;
            spnCosto.EditValue = Contrato.Costo;
            spnDiasRenta.Value = Contrato.DiasRenta;
            txtRecepcionEntrega.Text = Contrato.LugarOrigenLugarDestino;
            dteSalida.DateTime = Contrato.DiaSalida;
            dteRegreso.DateTime = Contrato.DiaRegreso;
            timeSalida.EditValue = Contrato.HoraSalida;
            timeRegreso.EditValue = Contrato.HoraRegreso;
            spnTiempoTolerancia.EditValue = Contrato.TiempoTolerancia;
            spnCostoInfraccion.EditValue = Contrato.CostoTolerancia;
            spnAnticipo.EditValue = Contrato.Anticipo;
            spnDescuento.EditValue = Contrato.Descuento;
            chkFactura.Checked = Contrato.Iva > 0 ? true : false;
            spnIVA.EditValue = Contrato.Iva;
            grdDocumentos.DataSource = Contrato.Documentos;

        }

        private bool Existe(string Nombre)
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Clientes = new XPView(UnidadConsulta, typeof(ClientesRenta), "Oid;Nombre", new BinaryOperator("Nombre", Nombre));
            if (Clientes.Count > 0)
                return true;
            return false;
        }
        private bool ValidarDisponibilidad()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("DiaRegreso", dteSalida.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("DiaSalida", dteSalida.DateTime.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Unidad", lueUnidad.EditValue ));
            GroupOperator goEstado = new GroupOperator(GroupOperatorType.Or);
            goEstado.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Creado));
            goEstado.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnProceso));
            go.Operands.Add(goEstado);
            XPView Contratos = new XPView(UnidadConsulta, typeof(ContratoRenta), "Oid;DiaRegreso;DiaSalida", go);
            if (Contratos.Count > 0)
                if (Convert.ToInt32(Contratos[0]["Oid"]) == Contrato.Oid)
                {
                    return true;
                }
                else
                {
                   return false;
                }
            else
                return true;
        }

        public int NumContrato(UnidadDeTrabajo Unidad)
        {
            XPView Usuarios = new XPView(Unidad, typeof(ContratoRenta));

            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("NumContrato", SortDirection.Descending, "[NumContrato]", true, true)});
            Usuarios.SelectDeleted = true;
            if (Usuarios.Count <= 0)
                return 123;
            else
            {
                if (Convert.ToInt32(Usuarios[0]["NumContrato"]) == 0)
                    return 123;
                return (Convert.ToInt32(Usuarios[0]["NumContrato"]) + 1);
            }
        }

        private bool ValidarCampos()
        {
            #region Usuario
            if (rgCliente.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtResponsable.Text))
                {
                    XtraMessageBox.Show("Falta el nombre del responsable.");
                    txtResponsable.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtDomicilio.Text))
                {
                    XtraMessageBox.Show("Falta el domicilio del responsable.");
                    txtDomicilio.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtColonia.Text))
                {
                    XtraMessageBox.Show("Falta la colonia del responsable.");
                    txtColonia.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtCP.Text))
                {
                    XtraMessageBox.Show("Falta el C.P. del responsable.");
                    txtCP.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtCiudad.Text))
                {
                    XtraMessageBox.Show("Falta la ciudad del responsable.");
                    txtCiudad.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtEstado.Text))
                {
                    XtraMessageBox.Show("Falta el estado del responsable.");
                    txtEstado.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtTel.Text))
                {
                    XtraMessageBox.Show("Falta el tel del responsable.");
                    txtTel.Focus();
                    return false;
                }

                if (Contrato.Documentos.Count() <= 0)
                {
                    XtraMessageBox.Show("Debe agregar la documentación necesaria.");
                    txtRecepcionEntrega.Focus();
                    return false;
                }

            }
            else
            {
                if (Cliente == null || string.IsNullOrEmpty(txtCliente.Text))
                {
                    XtraMessageBox.Show("Falta el número de cliente.");
                    txtCliente.Focus();
                    return false;
                }

                if (((XPCollection<DocumentosClientes>)grdDocumentos.DataSource).Count <= 0)
                {
                    XtraMessageBox.Show("Debe agregar la documentación necesaria.");
                    txtRecepcionEntrega.Focus();
                    return false;
                }
            }
            #endregion

            if (lueUnidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe selecccionar una unidad.");
                lueUnidad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                XtraMessageBox.Show("Debe agregar un destino.");
                txtDestino.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtRecepcionEntrega.Text))
            {
                XtraMessageBox.Show("Debe agregar la recepción y la entrega de la unidad.");
                txtRecepcionEntrega.Focus();
                return false;
            }

            if (Convert.ToDecimal(spnCosto.EditValue) <= 0)
            {
                XtraMessageBox.Show("Debe agregar el precio de renta de la unidad.");
                spnCosto.Focus();
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Contrato = new ContratoRenta(Unidad);
            grdDocumentos.DataSource = Contrato.Documentos;
            rgCliente.SelectedIndex = 0;
            txtResponsable.Focus();
            txtCliente.Text = string.Empty;
            txtResponsable.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtTel.Text = string.Empty;
            lueUnidad.EditValue = null;
            txtDestino.Text = string.Empty;
            spnDiasRenta.EditValue = 0;
            txtRecepcionEntrega.Text = string.Empty;
            dteSalida.EditValue = DateTime.Now;
            timeSalida.EditValue = new TimeSpan();
            dteRegreso.EditValue = null;
            timeRegreso.EditValue = null;
            spnCosto.EditValue = 0;
            chkFactura.Checked = false;
            spnIVA.EditValue = 0;
            spnAnticipo.EditValue = 0;
            spnDescuento.EditValue = 0;
            spnTiempoTolerancia.EditValue = 1;
            spnCostoInfraccion.EditValue = 100;
            lblTotal.Text = "$0.00";
        }

        #endregion

        
    }
}
