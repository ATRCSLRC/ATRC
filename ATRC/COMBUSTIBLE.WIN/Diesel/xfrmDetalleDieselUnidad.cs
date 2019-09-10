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
    public partial class xfrmDetalleDieselUnidad : xfrmBase
    {
        public xfrmDetalleDieselUnidad()
        {
            InitializeComponent();
        }

        public Diesel Diesel;
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

                XPView DieselAnterior = new XPView(Diesel.Session, typeof(Diesel), "Oid;CandadoActual", new BinaryOperator("Unidad.Oid", Diesel.Unidad.Oid));
                DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
                if (DieselAnterior.Count > 1)
                    CandadoAnterior = DieselAnterior[1]["CandadoActual"].ToString();
            }
            else
            {
                foreach (ViewRecord vr in Tanques)
                    rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Oid"], vr["Descripcion"].ToString()));
                txtMillas.Text = Diesel.Millas.ToString();
                txtCandadoAnterior.Text = Diesel.CandadoAnterior.ToString();
                txtCandadoActual.Text = Diesel.CandadoActual.ToString();
                txtLitros.Text = Diesel.Litros.ToString();
                rgTanques.EditValue = Diesel.UltimaRecarga.Tanque.Oid;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DieselActual Tanque = Diesel.Session.GetObjectByKey<DieselActual>(rgTanques.EditValue);

            if(Tanque != null)
            {
                if (!EsModificacion)
                {
                    //if (Tanque.Cantidad >= 0)
                    //{
                        XPView UltimaRecarga = new XPView(Diesel.Session, typeof(RecargaDiesel), "Oid", new BinaryOperator("Tanque", Tanque));
                        UltimaRecarga.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                        UltimaRecarga.TopReturnedRecords = 1;
                        if (UltimaRecarga.Count > 0)
                        {
                            GroupOperator go = new GroupOperator();
                            go.Operands.Add(new BinaryOperator("Final", 0));
                            go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                            XPView Medidor = new XPView(Diesel.Session, typeof(MedidorDiesel), "Oid", go);
                            Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));

                            Diesel.Millas = Convert.ToInt64(txtMillas.Text);
                            Diesel.MillasRecorridas = Convert.ToInt64(txtMillas.Text) - Convert.ToInt64(Diesel.Unidad.Millas);
                            Diesel.Unidad.Millas = txtMillas.Text;
                            Diesel.CandadoAnterior = Convert.ToInt64(txtCandadoAnterior.Text);
                            Diesel.CandadoActual = Convert.ToInt64(txtCandadoActual.Text);
                            Diesel.Litros = Convert.ToInt32(txtLitros.Text);
                            Diesel.MedidorDiesel = (Medidor[0].GetObject()) as MedidorDiesel;
                            Diesel.Llenado = true;
                            Diesel.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                            Tanque.Cantidad -= Convert.ToInt32(txtLitros.Text);
                            Tanque.Save();
                            Diesel.Save();

                            Diesel.Session.CommitTransaction();
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("No hay diesel.");
                        }
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show("No hay diesel.");
                    //}
                }
                else
                {

                    int LitrosOriginales = Diesel.Litros;

                    Diesel.Millas = Convert.ToInt64(txtMillas.Text);
                    GroupOperator goDiesel = new GroupOperator(GroupOperatorType.And);
                    goDiesel.Operands.Add(new BinaryOperator("Unidad.Oid", Diesel.Unidad.Oid));
                    goDiesel.Operands.Add(new BinaryOperator("Oid", Diesel.Oid, BinaryOperatorType.Less));
                    goDiesel.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                    XPView UltimoDiesel = new XPView(Diesel.Session, typeof(Diesel), "Oid;Millas", goDiesel);
                    UltimoDiesel.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                    //UltimoDiesel.TopReturnedRecords = 1;
                    Diesel.MillasRecorridas = Convert.ToInt64(txtMillas.Text) - Convert.ToInt64(UltimoDiesel[0]["Millas"]);
                    if (XtraMessageBox.Show("¿Desea actualizar las millas de la unidad?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Diesel.Unidad.Millas = txtMillas.Text;
                    }
                    Diesel.CandadoAnterior = Convert.ToInt64(txtCandadoAnterior.Text);
                    Diesel.CandadoActual = Convert.ToInt64(txtCandadoActual.Text);
                    Diesel.Litros = Convert.ToInt32(txtLitros.Text);


                    int LitrosReponer = 0;
                    int LitrosDescontar = 0;
                    if (Diesel.UltimaRecarga.Tanque == Tanque)
                    {
                        if (LitrosOriginales > Convert.ToInt32(txtLitros.Text))
                        {
                            LitrosReponer = (LitrosOriginales - Diesel.Litros);
                        }
                        else if (LitrosOriginales < Diesel.Litros)
                        {
                            LitrosDescontar = (Diesel.Litros - LitrosOriginales);
                        }
                        Diesel.UltimaRecarga.Tanque.Cantidad = Diesel.UltimaRecarga.Tanque.Cantidad + LitrosReponer - LitrosDescontar;
                    }
                    else
                    {
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                        XPView Medidor = new XPView(Diesel.Session, typeof(MedidorDiesel), "Oid", go);
                        Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                        XPView UltimaRecarga = new XPView(Diesel.Session, typeof(RecargaDiesel));
                        UltimaRecarga.Properties.Add(new ViewProperty("Oid", SortDirection.Descending, "Oid", false, true));
                        UltimaRecarga.Criteria = new BinaryOperator("Tanque", Tanque);
                        UltimaRecarga.TopReturnedRecords = 1;
                        Diesel.UltimaRecarga.Tanque.Cantidad += LitrosOriginales;
                        Tanque.Cantidad -= Convert.ToInt32(txtLitros.Text);
                        Diesel.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Diesel.MedidorDiesel = (Medidor[0].GetObject()) as MedidorDiesel;
                    }
                    Tanque.Save();
                    Diesel.Save();

                    Diesel.Session.CommitTransaction();
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
                        xfrm.UnidadTransporte = Diesel.Unidad.Oid;
                        xfrm.ShowInTaskbar = false;
                        xfrm.ShowDialog();
                    }
                }
            }
        }
    }
}
