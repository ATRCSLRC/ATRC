using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
        #region Eventos
        private void xfrmHistorialChecadas_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteFechaInicial.DateTime = dteFechaFinal.DateTime = DateTime.Now;
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, xfrm.IDUsuario);
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                    {
                        txtNombre.Text = Usuario.Usuario.Nombre;
                        btnUsuario.Text = Usuario.Usuario.NumEmpleado.ToString();
                    }
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = btnUsuario.Text = string.Empty;
                }
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
                    UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(btnUsuario.Text));
                    if (Usuario != null)
                    {
                        if (Usuario.Usuario != null)
                            txtNombre.Text = Usuario.Usuario.Nombre;
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombre.Text = string.Empty;
                    }
                }
                else
                {
                    txtNombre.Text = string.Empty;
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator( GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", dteFechaInicial.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", dteFechaFinal.DateTime.Date, BinaryOperatorType.LessOrEqual));
            if(rdgFiltros.SelectedIndex == 1)
                go.Operands.Add(new BinaryOperator("Usuario", CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnUsuario.Text))));
            XPCollection<HistoricoChecadas> Checadas = new XPCollection<HistoricoChecadas>(Unidad, go);
            grdHistorialChecadas.DataSource = Checadas;
            
        }

        private void grvHistorialChecadas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.IsForGroupRow)
            {
                UsuarioChecador Usuario = (UsuarioChecador)CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(e.DisplayText));
                e.DisplayText = e.DisplayText + " - " + Usuario.Usuario.Nombre + "     Horas trabajadas: " + CHECADOR.BL.Utilerias.HorasTrabajadas(UnidadConsulta, Usuario, dteFechaInicial.DateTime, dteFechaFinal.DateTime);
            }
        }

        private void grvHistorialChecadas_EndGrouping(object sender, EventArgs e)
        {
            grvHistorialChecadas.ExpandGroupRow(-1);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.CommitChanges();
        }

        private void grvHistorialChecadas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            HistoricoChecadas Historico = grvHistorialChecadas.GetFocusedRow() as HistoricoChecadas;
            if (Historico != null)
            {
                if (Historico.Usuario != null)
                {
                    if (Historico.Usuario.Usuario.Imagen != null)
                    {
                        if (!string.IsNullOrEmpty(Historico.Usuario.Usuario.Imagen.Archivo))
                        {
                            byte[] image = Convert.FromBase64String(Historico.Usuario.Usuario.Imagen.Archivo);
                            MemoryStream stream = new MemoryStream(image);
                            Image returnImage = Image.FromStream(stream);
                            peFotoUsuario.EditValue = stream.ToArray();
                        }
                        else
                            peFotoUsuario.Image = CHECADOR.WIN.Properties.Resources.usuario_desconocido;
                    }
                    else
                        peFotoUsuario.Image = CHECADOR.WIN.Properties.Resources.usuario_desconocido;


                    lblDetalleFecha.Text = Historico.FechaChecada.ToLongDateString();
                    lblDetalleUsuario.Text = Historico.Usuario.Usuario.NumEmpleado + " - " + Historico.Usuario.Usuario.Nombre;
                    lblDetalleEntrada.Text = Historico.HoraChecadaEntrada.ToString();
                    lblDetalleSalida.Text = Historico.HoraChecadaSalida.ToString();
                    lblDetalleLaborado.Text = Historico.HoraChecadaCalculadaSalida > 0 & Historico.HoraChecadaCalculadaEntrada > 0 ? (Historico.HoraChecadaCalculadaSalida - Historico.HoraChecadaCalculadaEntrada).ToString() : "0";
                }
                if (grvHistorialChecadas.FocusedRowHandle > 10)
                    ftpDetalleChecada.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Top;
                else
                    ftpDetalleChecada.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Bottom;
                ftpDetalleChecada.ShowPopup();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HistoricoChecadas Historico = grvHistorialChecadas.GetFocusedRow() as HistoricoChecadas;
            if (Historico != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la checada del día " + Historico.FechaChecada.ToShortDateString() + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Historico.Delete();
                    Unidad.CommitChanges();
                }
        }

        private void rdgFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdgFiltros.SelectedIndex == 0)
            {
                btnUsuario.Text = string.Empty;
                txtNombre.Text = string.Empty;
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        
        private void btnUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnUsuario.Text))
            {
                UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(btnUsuario.Text));
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                        txtNombre.Text = Usuario.Usuario.Nombre;
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = string.Empty;
                }
            }
            else
            {
                txtNombre.Text = string.Empty;
            }
        }
        #endregion

        private void grvHistorialChecadas_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            int row = view.GetRowHandle(e.ListSourceRowIndex);
            HistoricoChecadas Historico = (HistoricoChecadas)view.GetRow(row);
            if (e.Column.FieldName == "HoraChecadaEntradaT")
            {
                if (e.IsGetData)
                    e.Value = Historico.HoraChecadaEntrada;
                if (e.IsSetData)
                {
                    Historico.HoraChecadaEntrada = Convert.ToDateTime(e.Value).TimeOfDay;
                    Historico.Save();
                }
            }
            if (e.Column.FieldName == "HoraChecadaSalidaT")
            {
                if (e.IsGetData)
                    e.Value = Historico.HoraChecadaSalida;
                if (e.IsSetData)
                {
                    Historico.HoraChecadaSalida = Convert.ToDateTime(e.Value).TimeOfDay;
                    Historico.Save();
                }
            }
        }
    }
}
