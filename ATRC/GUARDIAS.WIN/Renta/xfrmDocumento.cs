using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.XtraEditors;
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
        DocumentosClientes Doc;
        string ArchivoText;
        string Descripcion;
        private void xfrmDocumento_Load(object sender, EventArgs e)
        {
            if (!EsContrato)
            {
                if (!EsNuevo)
                {
                    Doc = Cliente.Session.GetObjectByKey<DocumentosClientes>(IDDoc);
                    txtNombre.Text = Doc.Nombre;
                    dteVigencia.DateTime = Doc.FechaVigencia;
                    btnArchivo.Text = string.IsNullOrEmpty(Doc.Archivo) ? "No hay documentos" : "Existe un documento";
                }
            }else
            {
                if (!EsNuevo)
                {
                    Doc = Contrato.Session.GetObjectByKey<DocumentosClientes>(IDDoc);
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
    }
}
