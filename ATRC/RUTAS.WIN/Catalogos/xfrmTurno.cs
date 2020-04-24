using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN.Catalogos
{
    public partial class xfrmTurno : xfrmBase
    {
        public xfrmTurno()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Turno Turno;
        public bool EsNuevo;

        private void xfrmTurno_Load(object sender, EventArgs e)
        {
            if (!EsNuevo)
            {
                txtDescripcion.Text = Turno.Descripcion;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validar())
            {
                if (!Existe())
                {
                    if (EsNuevo)
                    {
                        Turno Turno = new Turno(Unidad);
                        Turno.Descripcion = txtDescripcion.Text;
                        Turno.Save();
                    }
                    else
                    {
                        Turno.Descripcion = txtDescripcion.Text;
                        Turno.Save();
                    }
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se ha guardado la información correctamente.");
                    this.Close();
                }else
                {
                    XtraMessageBox.Show("Este turno ya existe.");
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool Existe()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Turnos = new XPView(UnidadConsulta, typeof(Turno), "Oid;Descripcion", new BinaryOperator("Descripcion", txtDescripcion.Text));
            if (Turnos.Count > 0)
            {
                if (Turno != null)
                {
                    if (Convert.ToInt32(Turnos[0]["Oid"]) == Turno.Oid)
                    {
                        return false;
                    }
                } else
                {
                    return true;

                }
            }

            return false;
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                XtraMessageBox.Show("Debe agregar una descripción.");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }
    }
}
