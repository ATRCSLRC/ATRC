using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmPedidoDiesel : xfrmBase
    {
        public xfrmPedidoDiesel()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo UnidadControles;
        public bool Captura = false;
        public bool EsAnterior = false;
        public DateTime Fecha = DateTime.Now.Date;
        private void xfrmPedidoDiesel_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { IniciarControles(); }));
        }

        private void IniciarControles()
        {
            dteFecha.DateTime = EsAnterior ? Fecha : DateTime.Now;
            if (!EsAnterior)
                timer.Start();
            UnidadControles = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goFinal = new GroupOperator();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            goFinal.Operands.Add(new BinaryOperator("Combustible", Combustible.Diesel));
            goFinal.Operands.Add(go);
            XPView Unidades = new XPView(UnidadControles, typeof(Unidad));
            Unidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            Unidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Unidades.Criteria = goFinal;
            lueUnidad.Properties.DataSource = Unidades;
            XPView UnidadesAgregadas = new XPView(UnidadControles, typeof(Diesel), "Oid;Unidad.Nombre", EsAnterior ? new BinaryOperator("Fecha", Fecha) : new BinaryOperator("Fecha", DateTime.Now.Date ));
            UnidadesAgregadas.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdUnidades.DataSource = UnidadesAgregadas;

            txtEmpleado.Focus();
            lueUnidad.ItemIndex = 0;

        }
        private void LimipiarControles()
        {
            txtEmpleado.Focus();
            lueUnidad.ItemIndex = 0;
            txtEmpleado.EditValue = null;
            lblEmpleado.Text = " ";
            dteFecha.DateTime = EsAnterior ? Fecha : DateTime.Now;
        }

        private void txtEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtEmpleado.Text))
            {
                Usuario Usuario = UnidadControles.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                if (Usuario != null)
                {
                    lblEmpleado.Text = Usuario.Nombre;
                    lueUnidad.Focus();
                }
                else
                {
                    XtraMessageBox.Show("No existe usuario con este número de empleado.");
                    lblEmpleado.Text = " ";
                    txtEmpleado.EditValue = null;
                }
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de guardar el pedido a la unidad '" + lueUnidad.Text + "'?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Unidad UnidadDiesel = Unidad.GetObjectByKey<Unidad>(lueUnidad.EditValue);

                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Unidad", UnidadDiesel));
                if(EsAnterior)
                    go.Operands.Add(new BinaryOperator("Fecha", dteFecha.DateTime.Date));
                else
                    go.Operands.Add(new BinaryOperator("Fecha", DateTime.Now.Date));
                XPView UnidadesConDiesel = new XPView(Unidad, typeof(Diesel), "Oid", go);
                if (UnidadesConDiesel.Count > 0)
                {
                    XtraMessageBox.Show("La unidad ya se encuentra registrada.");
                    LimipiarControles();
                }
                else
                {
                    Usuario Usuario = UnidadControles.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                    if (Usuario == null)
                    {
                        XtraMessageBox.Show("No existe usuario con este número de empleado.");
                        lblEmpleado.Text = " ";
                        txtEmpleado.EditValue = null;
                    }
                    else
                    {
                        if (ValidarHorario())
                        {
                            Diesel Diesel = new Diesel(Unidad);
                            Diesel.Empleado = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(txtEmpleado.Text)));
                            Diesel.Unidad = UnidadDiesel;
                            if (EsAnterior)
                                Diesel.Fecha = dteFecha.DateTime.Date;
                            else
                                Diesel.Fecha = DateTime.Now.Date;
                            Diesel.Save();
                            Unidad.CommitChanges();
                            XtraMessageBox.Show("La unidad se ha se registrado correctamente.");
                            UnidadesAnotadas();
                            LimipiarControles();
                        }
                    }
                }
                if (Captura)
                    this.Close();
            }

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lueUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lueUnidad.IsPopupOpen)
                if (e.KeyCode == Keys.Enter & lueUnidad != null)
                {
                    bbiGuardar.PerformClick();
                }
        }

        private void lueUnidad_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
            {
                //lueUnidad.ShowPopup();
                SendKeys.Send("{DOWN}");
            }

            if (e.KeyCode == Keys.PageUp)
            {
               // lueUnidad.ShowPopup();
                SendKeys.Send("{UP}");
            }
        }

        private void lueUnidad_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {

        }

        private void lueUnidad_Move(object sender, EventArgs e)
        {

        }
        private void UnidadesAnotadas()
        {
            XPView UnidadesAgregadas = new XPView(UnidadControles, typeof(Diesel), "Oid;Unidad.Nombre", EsAnterior ? new BinaryOperator("Fecha", Fecha) : new BinaryOperator("Fecha", DateTime.Now.Date));
            UnidadesAgregadas.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            grdUnidades.DataSource = UnidadesAgregadas;
            grvUnidades.FocusedRowHandle = 0;
        }

        private bool ValidarHorario()
        {
            if (Captura)
                return true;

            TimeSpan HoraDe = new TimeSpan();
            TimeSpan HoraA = new TimeSpan(); 
            UnidadDeTrabajo UnidadValidar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            ATRCBASE.BL.Configuraciones ConfiguracionDiasDiesel = UnidadValidar.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "DiasDiesel"));
            if (ConfiguracionDiasDiesel != null)
            {
                string[] Dias = ConfiguracionDiasDiesel.Accion.Split(',');
                bool EsDia = false;
                foreach (string Dia in Dias)
                {
                    if (DateTime.Now.DayOfWeek == (DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(Convert.ToInt32(Dia)))
                        EsDia = true;
                }
                if (!EsDia)
                {
                    XtraMessageBox.Show("No es día de recargar diesel.");
                    UnidadesAnotadas();
                    LimipiarControles();
                    return false;
                }
            }

            ATRCBASE.BL.Configuraciones ConfiguracionHoraDeDiesel = UnidadValidar.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "HoraDeDiesel"));
            if (ConfiguracionHoraDeDiesel != null)
            {
                HoraDe = TimeSpan.Parse(ConfiguracionHoraDeDiesel.Accion);
            }

            ATRCBASE.BL.Configuraciones ConfiguracionHoraADiesel = UnidadValidar.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "HoraADiesel"));
            if (ConfiguracionHoraADiesel != null)
            {
                HoraA = TimeSpan.Parse(ConfiguracionHoraADiesel.Accion);
            }

            if(ConfiguracionHoraDeDiesel != null & ConfiguracionHoraADiesel != null)
            {
               if(DateTime.Now.TimeOfDay < HoraDe)
                {
                    XtraMessageBox.Show("No es el horario correcto para recargar diesel.");
                    UnidadesAnotadas();
                    LimipiarControles();
                    return false;
                }

                if (DateTime.Now.TimeOfDay > HoraA)
                {
                    XtraMessageBox.Show("No es el horario correcto para recargar diesel.");
                    UnidadesAnotadas();
                    LimipiarControles();
                    return false;
                }
            }

            
                return true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Date != dteFecha.DateTime.Date)
            {
                dteFecha.DateTime = DateTime.Now.Date;
                UnidadesAnotadas();
            }
        }
    }
}
