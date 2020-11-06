using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmMotivoModificacion : xfrmBase
    {
        public xfrmMotivoModificacion()
        {
            InitializeComponent();
        }
        public string Accion;
        public RutasGeneradas Ruta;
        private bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(memoMotivo.Text))
            {
                XtraMessageBox.Show("Deben ingresar un motivo.");
                memoMotivo.Focus();
                return false;
            }

            if (memoMotivo.Text.Length < 10)
            {
                XtraMessageBox.Show("Debe ingresar un motivo mayor a 10 carácteres.");
                memoMotivo.Focus();
                return false;
            }

            return true;
        }

        private void memoMotivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidarCampo())
                {
                    if (XtraMessageBox.Show("El motivo ingresado ¿Es correcto?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        MotivosModificacionRutas Motivo = new MotivosModificacionRutas(Ruta.Session);
                        Motivo.Descripcion = memoMotivo.Text;
                        Motivo.RutaGenerada = Ruta;
                        Motivo.Save();
                        Ruta.Session.CommitTransaction();
                        ATRCBASE.BL.Configuraciones ConfiguracionRecibir = Ruta.Session.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "RecibirCorreoSeguridad"));

                        string[] Correos = ConfiguracionRecibir.Accion.Split(',');
                        ArrayList CC = new ArrayList();
                        if (Correos.Count() > 1)
                        {
                            for(int x = 1; x < Correos.Count(); x++)
                                CC.Add(Correos[x]);
                        }
                        //ConfiguracionRecibir.Accion;
                        string Mensaje = string.Format("Se realizó una acción en el apartado de " + "'" + Accion + "'" + " en las rutas generadas del día " +
                            Ruta.FechaRuta.ToLongDateString() + ", por el motivo:\n" + memoMotivo.Text);
                        ATRCBASE.BL.Utilerias.EnviarCorreo(Correos[0], Mensaje, "Modificaciones de rutas", CC , null);

                        this.Close();
                    }
                    
                }

            }
        }
    }
}
