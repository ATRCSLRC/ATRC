using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmDetalleGasolinaUnidad : xfrmBase
    {
        public xfrmDetalleGasolinaUnidad()
        {
            InitializeComponent();
        }

        public Gasolina Gasolina;
        public XPView Tanques;
        private void xfrmDetalleDieselUnidad_Load(object sender, EventArgs e)
        {
            foreach (ViewRecord vr in Tanques)
                rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Tanque.Oid"], vr["Tanque.Descripcion"].ToString()));

            if(rgTanques.Properties.Items.Count == 1)
            {
                rgTanques.SelectedIndex = 0;
            }

            //XPView DieselAnterior = new XPView(Gasolina.Session, typeof(Gasolina), "Oid;CandadoActual", new BinaryOperator("Unidad.Oid", Gasolina.Unidad.Oid));
            //DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            //if (DieselAnterior.Count > 0)
            //    txtCandadoAnterior.Text = DieselAnterior[0]["CandadoActual"].ToString();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DieselActual Tanque = Gasolina.Session.GetObjectByKey<DieselActual>(rgTanques.EditValue);

            if(Tanque != null)
            {
                if (Tanque.Cantidad >= 0)
                {
                    XPView UltimaRecarga = new XPView(Gasolina.Session, typeof(RecargaDiesel), "Oid", new BinaryOperator("Tanque", Tanque));
                    UltimaRecarga.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                    UltimaRecarga.TopReturnedRecords = 1;
                    if (UltimaRecarga.Count > 0)
                    {

                        Gasolina.Millas =  Convert.ToInt64(txtMillas.Text);
                        Gasolina.MillasRecorridas = Convert.ToInt64(txtMillas.Text) - Convert.ToInt64(Gasolina.Unidad.Millas);
                        Gasolina.Unidad.Millas = txtMillas.Text;
                        Gasolina.CandadoAnterior = Convert.ToInt64(txtCandadoAnterior.Text);
                        Gasolina.CandadoActual = Convert.ToInt64(txtCandadoActual.Text);
                        Gasolina.Litros = Convert.ToInt32(txtLitros.Text);
                        Gasolina.Llenado = true;
                        Gasolina.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Tanque.Cantidad -= Convert.ToInt32(txtLitros.Text);
                        Tanque.Save();
                        Gasolina.Save();

                        Gasolina.Session.CommitTransaction();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("No hay diesel.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No hay diesel.");
                }
            }
            
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xfrmDetalleDieselUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtCandadoAnterior_Leave(object sender, EventArgs e)
        {

        }
    }
}
