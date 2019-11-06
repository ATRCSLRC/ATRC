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
        public bool EsModificacion = false;
        string CandadoAnterior;
        private void xfrmDetalleDieselUnidad_Load(object sender, EventArgs e)
        {
            if (!EsModificacion)
            {
                foreach (ViewRecord vr in Tanques)
                    rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Tanque.Oid"], vr["Tanque.Descripcion"].ToString()));

                if (rgTanques.Properties.Items.Count == 1)
                {
                    rgTanques.SelectedIndex = 0;
                }
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Gasolina.Unidad.Oid));
                XPView DieselAnterior = new XPView(Gasolina.Session, typeof(Gasolina), "Oid;CandadoActual", go);
                DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
                if (DieselAnterior.Count > 1)
                    CandadoAnterior = DieselAnterior[0]["CandadoActual"].ToString();
            }
            else
            {
                foreach (ViewRecord vr in Tanques)
                    rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Oid"], vr["Descripcion"].ToString()));
                txtMillas.Text = Gasolina.Millas.ToString();
                txtCandadoAnterior.Text = Gasolina.CandadoAnterior.ToString();
                txtCandadoActual.Text = Gasolina.CandadoActual.ToString();
                txtLitros.Text = Gasolina.Litros.ToString();
                rgTanques.EditValue = Gasolina.UltimaRecarga.Tanque.Oid;
            }

            
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DieselActual Tanque = Gasolina.Session.GetObjectByKey<DieselActual>(rgTanques.EditValue);

            if(Tanque != null)
            {
                if (!EsModificacion)
                {
                    //if (Tanque.Cantidad >= 0)
                    //{
                        XPView UltimaRecarga = new XPView(Gasolina.Session, typeof(RecargaDiesel), "Oid", new BinaryOperator("Tanque", Tanque));
                        UltimaRecarga.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                        UltimaRecarga.TopReturnedRecords = 1;
                        if (UltimaRecarga.Count > 0)
                        {

                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Final", 0));
                        go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                        XPView Medidor = new XPView(Gasolina.Session, typeof(MedidorDiesel), "Oid", go);
                        Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));

                        Gasolina.Millas = Convert.ToInt64(txtMillas.Text);
                        Gasolina.MillasRecorridas = Convert.ToInt64(txtMillas.Text) - Convert.ToInt64(Gasolina.Unidad.Millas);
                        Gasolina.Unidad.Millas = txtMillas.Text;
                        Gasolina.CandadoAnterior = Convert.ToInt64(txtCandadoAnterior.Text);
                        Gasolina.CandadoActual = Convert.ToInt64(txtCandadoActual.Text);
                        Gasolina.Litros = Convert.ToDecimal(txtLitros.Text);
                        Gasolina.MedidorGasolinas = (Medidor[0].GetObject()) as MedidorDiesel;
                        Gasolina.Llenado = true;
                        Gasolina.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Tanque.Cantidad -= Convert.ToDecimal(txtLitros.Text);
                        Tanque.Save();
                        Gasolina.Save();

                        Gasolina.Session.CommitTransaction();
                        this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("No hay gasolina.");
                        }
                }else
                {
                    decimal LitrosOriginales = Gasolina.Litros;

                    Gasolina.Millas = Convert.ToInt64(txtMillas.Text);
                    GroupOperator goGasolina = new GroupOperator(GroupOperatorType.And);
                    goGasolina.Operands.Add(new BinaryOperator("Unidad.Oid", Gasolina.Unidad.Oid));
                    //goGasolina.Operands.Add(new BinaryOperator("Oid", Gasolina.Oid, BinaryOperatorType.Less));
                    goGasolina.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                    goGasolina.Operands.Add(new BinaryOperator("Fecha", Gasolina.Fecha, BinaryOperatorType.Less));
                    XPView UltimoGasolina = new XPView(Gasolina.Session, typeof(Gasolina), "Oid;Millas;Fecha", goGasolina);
                    UltimoGasolina.Sorting.Add(new SortProperty("Fecha", SortingDirection.Descending));
                    //UltimoDiesel.TopReturnedRecords = 1;
                    Gasolina.MillasRecorridas = Convert.ToInt64(txtMillas.Text) - Convert.ToInt64(UltimoGasolina[0]["Millas"]);
                    if (XtraMessageBox.Show("¿Desea actualizar las millas de la unidad?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Gasolina.Unidad.Millas = txtMillas.Text;
                    }
                    Gasolina.CandadoAnterior = Convert.ToInt64(txtCandadoAnterior.Text);
                    Gasolina.CandadoActual = Convert.ToInt64(txtCandadoActual.Text);
                    Gasolina.Litros = Convert.ToDecimal(txtLitros.Text);


                    decimal LitrosReponer = 0;
                    decimal LitrosDescontar = 0;
                    if (Gasolina.UltimaRecarga.Tanque == Tanque)
                    {
                        if (LitrosOriginales > Convert.ToDecimal(txtLitros.Text))
                        {
                            LitrosReponer = (LitrosOriginales - Gasolina.Litros);
                        }
                        else if (LitrosOriginales < Gasolina.Litros)
                        {
                            LitrosDescontar = (Gasolina.Litros - LitrosOriginales);
                        }
                        Gasolina.UltimaRecarga.Tanque.Cantidad = Gasolina.UltimaRecarga.Tanque.Cantidad + LitrosReponer - LitrosDescontar;
                    }
                    else
                    {
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                        XPView Medidor = new XPView(Gasolina.Session, typeof(MedidorDiesel), "Oid", go);
                        Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                        XPView UltimaRecarga = new XPView(Gasolina.Session, typeof(RecargaDiesel));
                        UltimaRecarga.Properties.Add(new ViewProperty("Oid", SortDirection.Descending, "Oid", false, true));
                        UltimaRecarga.Criteria = new BinaryOperator("Tanque", Tanque);
                        UltimaRecarga.TopReturnedRecords = 1;
                        Gasolina.UltimaRecarga.Tanque.Cantidad += LitrosOriginales;
                        Tanque.Cantidad -= Convert.ToDecimal(txtLitros.Text);
                        Gasolina.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Gasolina.MedidorGasolinas = (Medidor[0].GetObject()) as MedidorDiesel;
                    }
                    Tanque.Save();
                    Gasolina.Save();

                    Gasolina.Session.CommitTransaction();
                    this.Close();
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
            if (!EsModificacion)
            {
                if (!string.IsNullOrEmpty(CandadoAnterior))
                {
                    if (txtCandadoAnterior.Text != CandadoAnterior)
                    {
                        xfrmandados xfrm = new xfrmandados();
                        xfrm.UnidadTransporte = Gasolina.Unidad.Oid;
                        xfrm.ShowInTaskbar = false;
                        xfrm.ShowDialog();
                    }
                }
            }
        }
    }
}
