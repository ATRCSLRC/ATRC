using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECADOR.WIN
{
    public partial class xfrmChecador : xfrmBase
    {
        public xfrmChecador()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public HistoricoChecadas Checada;
        UsuarioChecador Usuario;

        #region Eventos
        private void xfrmChecador_Load(object sender, EventArgs e)
        {
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                dteFecha.DateTime = DateTime.Now;
                BeginInvoke(new MethodInvoker(delegate { btnNumUsuario.Focus(); }));
            }
            else
            {
                dteFecha.DateTime = Checada.FechaChecada;
                btnNumUsuario.Text = Checada.Usuario.Usuario.NumEmpleado.ToString();
                txtNombreUsuario.Text = Checada.Usuario.Usuario.Nombre;
                tmeHoraEntrada.EditValue = Checada.HoraChecadaEntrada;
                tmeHoraSalida.EditValue = Checada.HoraChecadaSalida;
                Usuario = Checada.Usuario;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Usuario != null)
            {
                if(Checada != null)
                {
                    Checada.FechaChecada = dteFecha.DateTime;
                    Checada.HoraChecadaEntrada = tmeHoraEntrada.Time.TimeOfDay;
                    Checada.HoraChecadaSalida = tmeHoraSalida.EditValue == null ? null : (TimeSpan?)tmeHoraSalida.Time.TimeOfDay;
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se guardo la información correctamente.");
                    this.Close();
                }
                else
                {
                    CHECADOR.BL.Utilerias.CrearChecada(dteFecha.DateTime, tmeHoraEntrada.Time.TimeOfDay, tmeHoraSalida.Time.TimeOfDay, tmeHoraEntrada.EditValue == null ? false : true, tmeHoraSalida.EditValue == null ? false : true, memoMotivo.Text, Usuario, Unidad);
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se guardo la información correctamente.");
                    LimpiarControles();
                }
                
                //this.Close();
            }
            else
            {
                XtraMessageBox.Show("Debe de seleccionar un usuario.");
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void btnNumUsuario_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, xfrm.IDUsuario);
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                    {
                        txtNombreUsuario.Text = Usuario.Usuario.Nombre;
                        btnNumUsuario.Text = Usuario.Usuario.NumEmpleado.ToString();
                    }
                }else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
                }
            }else
            {
                Usuario = null;
                btnNumUsuario.Text = btnNumUsuario.Text = string.Empty;
            }
        }

        private void btnNumUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnNumUsuario.Text))
                {
                    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnNumUsuario.Text));
                    if (Usuario != null)
                    {
                        if (Usuario.Usuario != null)
                        {
                            txtNombreUsuario.Text = Usuario.Usuario.Nombre;
                            tmeHoraEntrada.Focus();
                        }   
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombreUsuario.Text = string.Empty;
                    }
                }else
                {
                    txtNombreUsuario.Text = string.Empty;
                }
            }
        }

        private void btnNumUsuario_Leave(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(btnNumUsuario.Text))
            //{
            //    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(btnNumUsuario.Text));
            //    if (Usuario != null)
            //    {
            //        if (Usuario.Usuario != null)
            //            txtNombreUsuario.Text = Usuario.Usuario.Nombre;
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("El usuario no se encuentra registrado.");
            //        txtNombreUsuario.Text = string.Empty;
            //    }
            //}
            //else
            //{
            //    txtNombreUsuario.Text = string.Empty;
            //}
        }

        private void xfrmChecador_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        #endregion

        private void LimpiarControles()
        {
            btnNumUsuario.Text = txtNombreUsuario.Text = string.Empty;
            Usuario = null;
            tmeHoraEntrada.EditValue = tmeHoraSalida.EditValue = null;
            memoMotivo.Text = string.Empty;
            btnNumUsuario.Focus();
        }

        private void tmeHoraSalida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                if (((TimeEdit)sender).EditValue != null)
                {
                    ((TimeEdit)sender).EditValue = null;
                }
            }
        }
    }

}
