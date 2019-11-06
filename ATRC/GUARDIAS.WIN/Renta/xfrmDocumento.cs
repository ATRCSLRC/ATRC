using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using GUARDIAS.BL;
using Saraff.Tiff;
using Saraff.Tiff.Core;
using Saraff.Twain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN
{
    public partial class xfrmDocumento : xfrmBase
    {
        public xfrmDocumento()
        {
            InitializeComponent();
            
        }

        public bool EsContrato = false;
        public bool EsNuevo;
        public ClientesRenta Cliente;
        public ContratoRenta Contrato;
        public int IDDoc;
        public DocumentosClientes Doc;
        string ArchivoText;
        string Descripcion;

        Twain32 twain;
        private void xfrmDocumento_Load(object sender, EventArgs e)
        {
            twain = new Twain32();
            twain.ShowUI = false;
            twain.DisableAfterAcquire = true;
            twain.IsTwain2Enable = false;
            twain.Language = TwLanguage.SPANISH_MEXICAN;
            twain.AcquireCompleted += new System.EventHandler(twain_AcquireCompleted);
            twain.AcquireError += new System.EventHandler<Saraff.Twain.Twain32.AcquireErrorEventArgs>(twain_AcquireError);

            try
            {
                twain.OpenDSM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\n\n{1}", ex.Message, ex.StackTrace), "SAMPLE1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!EsContrato)
            {
                if (!EsNuevo)
                {
                    //Doc = Cliente.Session.GetObjectByKey<DocumentosClientes>(IDDoc);
                    txtNombre.Text = Doc.Nombre;
                    dteVigencia.DateTime = Doc.FechaVigencia;
                    btnArchivo.Text = string.IsNullOrEmpty(Doc.Archivo) ? "No hay documentos" : "Existe un documento";
                }
            }else
            {
                if (!EsNuevo)
                {
                    //Doc = Contrato.Session.GetObjectByKey<DocumentosClientes>(IDDoc);
                    txtNombre.Text = Doc.Nombre;
                    dteVigencia.DateTime = Doc.FechaVigencia;
                    btnArchivo.Text = string.IsNullOrEmpty(Doc.Archivo) ? "No hay documentos" : "Existe un documento";
                }
            }

            
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!EsNuevo)
            {
                if (!string.IsNullOrEmpty(ArchivoText))
                {
                    Doc.Archivo = ArchivoText;
                    Doc.Descripcion = Descripcion;
                    if (EsContrato)
                        Doc.Contratos.Add(Contrato);
                    else
                        Doc.Cliente = Cliente;
                }
            }
            else
            {
                Doc = new DocumentosClientes(EsContrato ? Contrato.Session : Cliente.Session);
                if(!string.IsNullOrEmpty(ArchivoText))
                {
                    Doc.Archivo = ArchivoText;
                    Doc.Descripcion = Descripcion;
                    if (EsContrato)
                        Doc.Contratos.Add(Contrato);
                    else
                        Doc.Cliente = Cliente;
                }
            }
            Doc.Nombre = txtNombre.Text;
            Doc.FechaVigencia = dteVigencia.DateTime.Date;
            Doc.Save();
            this.Close();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Escanear documento")
            {
                try
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Usuario Usuario = Utilerias.ObtenerUsuarioActual(Unidad);
                    ATRCBASE.BL.Configuraciones Configuracion = null;
                    switch (Usuario.Departamento.Descripcion)
                    {
                        case "Administración":
                            Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "EscanerOficina"));
                            break;
                        case "Seguridad":
                            Configuracion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "EscanerGuardias"));
                            break;
                    }
                    if (Configuracion != null)
                    {
                        this.twain.CloseDataSource();
                        twain.SourceIndex = Convert.ToInt32(Configuracion.Accion);
                        this.twain.OpenDataSource();
                        #region Examples of the capabilities

                        // Duplex & Feeder
                        if (this.twain.Capabilities.Duplex.IsSupported(TwQC.GetCurrent) && this.twain.Capabilities.Duplex.GetCurrent() != TwDX.None)
                        {
                            if (this.twain.Capabilities.FeederEnabled.IsSupported(TwQC.Set))
                            {
                                this.twain.Capabilities.FeederEnabled.Set(true);

                                if (this.twain.Capabilities.DuplexEnabled.IsSupported(TwQC.Set))
                                {
                                    this.twain.Capabilities.DuplexEnabled.Set(true);
                                }
                                this.twain.Capabilities.XferCount.Set(-1);
                            }
                        }


                        //Brightness
                        if (this.twain.Capabilities.Brightness.IsSupported(TwQC.Set))
                        {
                            this.twain.Capabilities.Brightness.Set(0f); //Allowed Values: -1000f to +1000f; Default Value: 0f;
                        }

                        //Contrast
                        if ((this.twain.Capabilities.Contrast.IsSupported() & TwQC.Set) != 0)
                        {
                            this.twain.Capabilities.Contrast.Set(0f); //Allowed Values: -1000f to +1000f; Default Value: 0f;
                        }

                        #endregion

                        this.twain.Acquire();
                    }
                }
                catch (Exception ex)
                {
                    //this._ToLog(ex);

                }
            }
            else
            {
                if (ofdDocumento.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream Archivo = new System.IO.FileStream(ofdDocumento.FileName, FileMode.Open, FileAccess.Read);
                        MemoryStream streampdf = new MemoryStream();
                        Archivo.CopyTo(streampdf);
                        Archivo.Dispose();
                        ArchivoText = Convert.ToBase64String(streampdf.ToArray());
                        Descripcion = ofdDocumento.FileName;
                        btnArchivo.Text = "Un documento";
                        //Doc.Cliente = Cliente;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }


            //var Impresora = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            //try
            //{

            //    twain.CloseDataSource();
            //    twain.OpenDataSource();
            //    twain.Acquire();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "SAMPLE1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Scanner(SelectScan());

            //}
        }

        private void twain_AcquireError(object sender, Twain32.AcquireErrorEventArgs e)
        {
            XtraMessageBox.Show("Favor de revisar que el dispositivo este encendido.");
        }



        private void twain_AcquireCompleted(object sender, EventArgs e)
        {
            try
            {
                string base64String;
                if (twain.ImageCount > 0)
                {
                    using (Image image = twain.GetImage(0))
                    {
                        using (MemoryStream m = new MemoryStream())
                        {
                            image.Save(m, image.RawFormat);
                            byte[] imageBytes = m.ToArray();

                            // Convert byte[] to Base64 String
                            base64String = Convert.ToBase64String(imageBytes);
                            //return base64String;
                        }
                        //twain.GetImage(0).
                        // this.pictureBox1.Image = this._twain.GetImage(0);
                    }
                    ArchivoText = base64String;
                    btnArchivo.Text = "Un documento";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SAMPLE1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xfrmDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            twain.CloseDataSource();
            twain.CloseDSM();
        }


        //public string SelectScan()
        //{
        //    string deviceid;
        //    try
        //    {
        //        CommonDialogClass class1 = new CommonDialogClass();
        //        Device d = class1.ShowSelectDevice(WIA.WiaDeviceType.UnspecifiedDeviceType, false, false);


        //        if (d != null)
        //        {
        //            deviceid = d.DeviceID;
        //            return deviceid;
        //        }
        //        else
        //        {
        //            return "";
        //        }
        //    }
        //    catch (System.Runtime.InteropServices.COMException ex)
        //    {
        //        if ((uint)ex.ErrorCode == 0x80210015)
        //            XtraMessageBox.Show("No se detectaron disposivos conectados. ");
        //        return "";
        //    }

        //}

        //private void GetScanersList()
        //{
        //    //List<Scaner> ls = new List<Scaner>();
        //    //Scaner s;
        //    try
        //    {
        //        //fs = new FormSelect();
        //        Twain _twain = new Twain(new WinFormsWindowMessageHook(new xfrmDocumento()));
        //        if (_twain.SourceNames.Count != 0)
        //        {
        //            //_twain.SelectSource();
        //            //s = new Scaner(_twain.DefaultSourceName, EnumScanerType.Twain, _wh);
        //            //ls.Add(s);
        //        }
        //    }
        //    catch (TwainException) { }
        //    //List<string> devices = WIAScanner.GetDevices();
        //    //foreach (string device in devices)
        //    //{
        //    //    s = new Scaner(device, EnumScanerType.WIA, _wh);
        //    //    ls.Add(s);

        //    //}
        //}

        //public List<Image> Scanner(string deviceid)
        //{
        //    WIA.CommonDialog WiaCommonDialog = new CommonDialogClass();
        //    bool hasMorePages = true;
        //    DeviceManager manager = new DeviceManagerClass();
        //    Device WiaDev = null;
        //    foreach (DeviceInfo info in manager.DeviceInfos)
        //    {
        //        if (info.DeviceID == deviceid)
        //        {
        //            WIA.Properties infoprop = null;
        //            infoprop = info.Properties;
        //            WiaDev = info.Connect();
        //            break;
        //        }
        //    }

        //    WIA.ImageFile img = null;
        //    WIA.IItems it = WiaCommonDialog.ShowSelectItems(WiaDev);
        //    List<Image> ret = new List<Image>();
        //    if (it == null) return new List<Image>();
        //    foreach (WIA.Item item in it)
        //    {
        //        while (hasMorePages)
        //        {
        //            try
        //            {
        //                img = (ImageFile)WiaCommonDialog.ShowTransfer(item);
        //                if (img != null && img.FileData != null)
        //                {
        //                    var imageBytes = (byte[])img.FileData.get_BinaryData();
        //                    var ms = new MemoryStream(imageBytes);
        //                    Image img2 = null;
        //                    img2 = Image.FromStream(ms);

        //                    ret.Add(img2);
        //                }
        //                if (Convert.ToUInt32(WiaDev.Properties["3088"].get_Value()) == 2)
        //                {
        //                    return ret;
        //                }
        //            }
        //            catch (System.Runtime.InteropServices.COMException ex)
        //            {
        //                if ((uint)ex.ErrorCode == 0x80210067)
        //                    return ret;
        //                if ((uint)ex.ErrorCode == 0x80210003)
        //                {
        //                    return ret;
        //                }
        //            }
        //        }
        //    }

        //    return ret;
        //}
    }
}
