using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECADOR.WIN
{
    public partial class xfrmHistorialChecadas : xfrmBase
    {
        public xfrmHistorialChecadas()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        UnidadDeTrabajo UnidadConsulta;
        public bool esConsulta;
        #region Eventos
        private void xfrmHistorialChecadas_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteFechaInicial.DateTime = dteFechaFinal.DateTime = DateTime.Now;
            if (esConsulta)
            {
                rpAcciones.Visible = false;
                colFecha.OptionsColumn.AllowFocus = false;
                colHoraChecada.OptionsColumn.AllowFocus = false;
                colNumEmpleado.OptionsColumn.AllowFocus = false;
                colMotivo.OptionsColumn.AllowFocus = false;
                colTipoChecada.OptionsColumn.AllowFocus = false;
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                //UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, xfrm.IDUsuario);
                //if (Usuario != null)
                //{
                    //if (Usuario.Usuario != null)
                    //{
                    //    txtNombre.Text = Usuario.Usuario.Nombre;
                        btnUsuario.Text = xfrm.IDUsuario.ToString();
                        btnBusqueda.Focus();
                    //}
                //}
                //else
                //{
                //    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                //    txtNombre.Text = btnUsuario.Text = string.Empty;
                //}
            }else
            {
                txtNombre.Text = btnUsuario.Text = string.Empty;
            }
        }

        private void btnUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnUsuario.Text))
                {
                    //Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(btnUsuario.Text));
                    //if (Usuario != null)
                    //{
                    //    if (Usuario.Usuario != null)
                    //    {
                    //        txtNombre.Text = Usuario.Usuario.Nombre;
                            btnBusqueda.Focus();
                    //    }
                    //}
                    //else
                    //{
                    //    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    //    txtNombre.Text = string.Empty;
                    //}
                }
                else
                {
                    XtraMessageBox.Show("Debe de agregar el número de empleado.");
                    txtNombre.Text = string.Empty;
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator( GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", dteFechaInicial.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", dteFechaFinal.DateTime.Date, BinaryOperatorType.LessOrEqual));
            //colNumEmpleado.GroupIndex = -1;
            if (rdgFiltros.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(btnUsuario.Text))
                {
                    XtraMessageBox.Show("Debe de agregar el número de empleado.");
                    btnUsuario.Focus();
                    return;
                }
                go.Operands.Add(new BinaryOperator("Usuario.Usuario.NumEmpleado", /*CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad,*/ Convert.ToInt32(btnUsuario.Text)/*)*/));
                emptySpaceItem1.TextVisible = true;
                emptySpaceItem1.AppearanceItemCaption.BackColor = Color.Red;
            }
            else
            {
                emptySpaceItem1.AppearanceItemCaption.BackColor = DefaultBackColor;
                emptySpaceItem1.TextVisible = false;
            }
            //XPCollection<HistoricoChecadas> Checadas = new XPCollection<HistoricoChecadas>(Unidad, go);
            XPView Checadas = new XPView(Unidad, typeof(HistoricoChecadas), "Oid;FechaChecada;HoraChecadaEntrada;HoraChecadaSalida;Usuario.Usuario.NumEmpleado;Motivo;Usuario.Usuario.Imagen;Usuario.Usuario.Nombre", go);
            Checadas.Sorting.Add(new SortingCollection(new SortProperty("HoraChecadaEntrada", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            grdHistorialChecadas.DataSource = Checadas;
            DetalleChecada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            ftpDetalleChecada.HidePopup();

            if (rdgFiltros.SelectedIndex == 1)
            {
                if (Checadas.Count > 0)
                {
                    Int32 NumEmpleado = Convert.ToInt32(Checadas[0]["Usuario.Usuario.NumEmpleado"]);
                    //XPView Usuario = new XPView(UnidadConsulta, typeof(Usuario), "Oid;NumEmpleado;Nombre", new BinaryOperator("NumEmpleado", NumEmpleado));
                    //if (Usuario != null)
                    //{
                        emptySpaceItem1.Text = "Total de horas trabajadas: " + HorasTrabajadas(UnidadConsulta, NumEmpleado, dteFechaInicial.DateTime, dteFechaFinal.DateTime);
                        //txtNombre.Text = 
                    //}
                }
            }
        }

        private void grvHistorialChecadas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.IsForGroupRow)
            //{

            //    XPView Usuario = new XPView(UnidadConsulta, typeof(Usuario), "Oid;NumEmpleado;Nombre", new BinaryOperator("NumEmpleado", Convert.ToInt32(e.DisplayText)));
            //    if (Usuario != null)
            //        e.DisplayText = e.DisplayText + " - " + Usuario[0]["Nombre"] + "     Horas trabajadas: " + HorasTrabajadas(UnidadConsulta, Convert.ToInt32(e.DisplayText), dteFechaInicial.DateTime, dteFechaFinal.DateTime);
            //}
        }

        public static decimal HorasTrabajadas(UnidadDeTrabajo Unidad, int usuario, DateTime FechaInicial, DateTime FechaFinal)
        {
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaFinal.Date, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("Usuario", CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, usuario)));
            XPView Checadas = new XPView(Unidad, typeof(HistoricoChecadas), "Oid;FechaChecada;HoraChecadaEntrada;HoraChecadaSalida;Usuario", go);
            decimal Horas = 0;
            foreach (ViewRecord ViewHistorico in Checadas)
            {
                decimal HoraEntrada = ViewHistorico["HoraChecadaEntrada"] == null ? 0 : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)ViewHistorico["HoraChecadaEntrada"]);
                decimal HoraSalida = ViewHistorico["HoraChecadaSalida"] == null ? HoraEntrada : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)ViewHistorico["HoraChecadaSalida"]);
                
                //if (HoraSalida > 0 & HoraEntrada > 0)
                    if ((HoraSalida > HoraEntrada))
                        Horas += (HoraSalida - HoraEntrada);
                    else
                        Horas += (HoraSalida - HoraEntrada) == 0 ? 0 : ((HoraSalida - HoraEntrada) + 24);
            }
            return Horas;
        }

        private void grvHistorialChecadas_EndGrouping(object sender, EventArgs e)
        {
            //grvHistorialChecadas.ExpandGroupRow(-1);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewHistorico = grvHistorialChecadas.GetFocusedRow() as ViewRecord;
            if (ViewHistorico != null)
            {
                xfrmChecador xfrm = new xfrmChecador();
                xfrm.Unidad = Unidad;
                xfrm.Checada = ViewHistorico.GetObject() as HistoricoChecadas;
                xfrm.ShowDialog();
            }
            ((XPView)grdHistorialChecadas.DataSource).Reload();
            //Unidad.CommitChanges();
        }

        private void grvHistorialChecadas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewHistorico = grvHistorialChecadas.GetFocusedRow() as ViewRecord;
            if (ViewHistorico != null)
            {
                HistoricoChecadas Historico = (HistoricoChecadas)ViewHistorico.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la checada del día " + Historico.FechaChecada.ToShortDateString() + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Historico.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdHistorialChecadas.DataSource).Reload();
                }
            }
        }

        private void rdgFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdgFiltros.SelectedIndex == 0)
            {
                btnUsuario.Text = string.Empty;
                txtNombre.Text = string.Empty;
                //lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                //lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        
        private void btnUsuario_Leave(object sender, EventArgs e)
        {
            
        }
        
        #endregion

        private decimal TotalHoras(ViewRecord view)
        {
            decimal EntradaHora = view["HoraChecadaEntrada"] == null ? 0 : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)view["HoraChecadaEntrada"]);
            decimal SalidaHora = view["HoraChecadaSalida"] == null ? EntradaHora : CHECADOR.BL.Utilerias.CalcularHora((TimeSpan)view["HoraChecadaSalida"]);
            return /*SalidaHora > 0 & EntradaHora > 0 ?*/ SalidaHora < EntradaHora ? (SalidaHora - EntradaHora) + 24 :(SalidaHora - EntradaHora) /*: 0*/;
        }

        private void grvHistorialChecadas_RowClick(object sender, RowClickEventArgs e)
        {
            DetalleChecada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            ViewRecord ViewHistorico = grvHistorialChecadas.GetFocusedRow() as ViewRecord;
            //HistoricoChecadas Historico = grvHistorialChecadas.GetFocusedRow() as HistoricoChecadas;
            if (ViewHistorico != null)
            {
                Imagen Imagen = UnidadConsulta.GetObjectByKey<Imagen>(Convert.ToInt32(ViewHistorico["Usuario.Usuario.Imagen"]));
                if (Imagen != null)
                {
                    if (!string.IsNullOrEmpty(Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        peFotoUsuario.EditValue = stream.ToArray();
                    }
                    else
                        peFotoUsuario.Image = CHECADOR.WIN.Properties.Resources.usuario_desconocido;
                }
                else
                    peFotoUsuario.Image = CHECADOR.WIN.Properties.Resources.usuario_desconocido;

                lblDetalleFecha.Text = ((DateTime)ViewHistorico["FechaChecada"]).ToLongDateString();
                lblDetalleUsuario.Text = ViewHistorico["Usuario.Usuario.NumEmpleado"].ToString() + " - " + ViewHistorico["Usuario.Usuario.Nombre"].ToString();
                lblDetalleEntrada.Text = ViewHistorico["HoraChecadaEntrada"].ToString();
                lblDetalleSalida.Text = ViewHistorico["HoraChecadaSalida"] == null ? "0" : ViewHistorico["HoraChecadaSalida"].ToString();
                lblDetalleLaborado.Text = TotalHoras(ViewHistorico).ToString();
                ftpDetalleChecada.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
                ftpDetalleChecada.ShowPopup();
            }
        }
    }
}
