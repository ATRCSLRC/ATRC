using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using ExcelDataReader;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmImportacionRutas : xfrmBase
    {
        public xfrmImportacionRutas()
        {
            InitializeComponent();
        }

        XPCollection Rutas;
        UnidadDeTrabajo Unidad;

        private void xfrmImportacionRutas_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection Usuarios = new XPCollection(Unidad, typeof(Usuario));
            Usuarios.Criteria = new BinaryOperator("Activo", true);
            XPCollection Turnos = new XPCollection(Unidad, typeof(Turno));
            XPCollection Servicios = new XPCollection(Unidad, typeof(Servicio));
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;
            Rutas = new XPCollection(Unidad, typeof(RutasGeneradas), 0);
            

            Rutas.DisplayableProperties = "Ruta;ChoferEntrada!Key;ChoferSalida!Key;Turno!Key";
            grdRutas.DataSource = Rutas;
            lueChoferEntrada.DataSource = Usuarios;
            lueChoferSalida.DataSource = Usuarios;
            lueTurno.DataSource = Turnos;
            lueServicios.DataSource = Servicios;
            
        }

        private void lookUpEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                e.DisplayText = row["Clave"] + " - " + row["Nombre"];
            }
        }

        private void bbiImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lueEmpresa.EditValue != null)
            {
                if (ofdDocumento.ShowDialog() == DialogResult.OK)
                {

                    using (var stream = File.Open(ofdDocumento.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var dataSet = reader.AsDataSet();
                            var dataTable = dataSet.Tables[0];
                            for (int x = 8; x < dataTable.Rows.Count; x++)
                            {
                                RutasGeneradas Ruta = new RutasGeneradas(Unidad);
                                Ruta.FechaRuta = dataTable.Rows[x].ItemArray[0].GetType() == typeof(DBNull) ? DateTime.Now : Convert.ToDateTime(dataTable.Rows[x].ItemArray[0]).Date;
                                Ruta.Ruta = dataTable.Rows[x].ItemArray[1].GetType() == typeof(DBNull) ? string.Empty : dataTable.Rows[x].ItemArray[1].ToString();
                                Ruta.TipoRuta = dataTable.Rows[x].ItemArray[2].GetType() == typeof(DBNull) ? 0 : (Enums.TipoRuta)Enum.Parse(typeof(Enums.TipoRuta), dataTable.Rows[x].ItemArray[2].ToString(), true);
                                Ruta.Servicio = dataTable.Rows[x].ItemArray[3].GetType() == typeof(DBNull) ? null : Unidad.FindObject<Servicio>(new BinaryOperator("Descripcion", dataTable.Rows[x].ItemArray[3].ToString().Split('(')[0].TrimEnd()));
                                Ruta.TipoUnidad = Ruta.Servicio == null ? 0 :Ruta.Servicio.TipoUnidad;
                                Ruta.Turno = dataTable.Rows[x].ItemArray[4].GetType() == typeof(DBNull) ? null : Unidad.FindObject<BL.Turno>(new BinaryOperator("Descripcion", dataTable.Rows[x].ItemArray[4].ToString()));
                                Ruta.HoraEntrada = dataTable.Rows[x].ItemArray[5].GetType() == typeof(DBNull) ? null : (DateTime?)dataTable.Rows[x].ItemArray[5];
                                Ruta.HoraSalida = dataTable.Rows[x].ItemArray[6].GetType() == typeof(DBNull) ? null : (DateTime?)dataTable.Rows[x].ItemArray[6];
                                Ruta.Empresa = ((ViewRecord)lueEmpresa.EditValue).GetObject() as Empresas;
                                if (chkRutasExtras.Checked)
                                    Ruta.EsRutaExtra = true;

                                Rutas.Add(Ruta);
                            }
                        }
                    }
                }
            }else
            {
                XtraMessageBox.Show("Primero debe seleccionar una empresa a la cual se le asignaran las rutas importadas.");
                lueEmpresa.Focus();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                this.Close();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Rutas.Count > 0)
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se guardaron las rutas correctamente.");
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("No hay rutas por guardar.");
            }
        }

        private void xfrmImportacionRutas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de querer salir? Podría perder sus cambios.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
