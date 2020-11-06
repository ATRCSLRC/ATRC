using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
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
    public partial class xfrmandados : xfrmBase
    {
        public xfrmandados()
        {
            InitializeComponent();
        }

        public int UnidadTransporte;
        public bool EsListaProblemas = false;

        private void xfrmandados_Load(object sender, EventArgs e)
        {
            if (EsListaProblemas)
            {
                this.ControlBox = true;
                lciComentario.Text = "Debe explicar el problema:";
            }
        }

        private void memoObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(memoObservacion.Text))
            {
                if (XtraMessageBox.Show("¿Desea guardar el detalle del problema?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    if (!EsListaProblemas)
                    {

                        DetallesCandados Candado = new DetallesCandados(Unidad);
                        Candado.Empleado = Utilerias.ObtenerUsuarioActual(Unidad);
                        Candado.Unidad = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(UnidadTransporte);
                        Candado.Problema = memoObservacion.Text;
                        Candado.Verificado = true;
                        Candado.Save();
                    }
                    else
                    {
                        DetallesCandados Candado = Unidad.GetObjectByKey<DetallesCandados>(UnidadTransporte);
                        Candado.Problema = memoObservacion.Text;
                        Candado.Verificado = true;
                        Candado.Save();
                    }
                    Unidad.CommitChanges();
                    this.Close();
                }
            }
        }
    }
}
