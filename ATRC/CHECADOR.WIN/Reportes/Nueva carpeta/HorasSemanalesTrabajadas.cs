using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace CHECADOR.WIN.Reportes
{
    public partial class HorasSemanalesTrabajadas : DevExpress.XtraReports.UI.XtraReport
    {
        public HorasSemanalesTrabajadas(int NumEmpleado, DateTime Inicial, DateTime Final)
        {
            InitializeComponent();

            this.Parameters["FechaDel"].Value = Inicial;
            this.Parameters["FechaAl"].Value = Final;
            lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            CHECADOR.BL.UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), NumEmpleado);
            List<CHECADOR.BL.UsuarioChecador> usuarios = new List<CHECADOR.BL.UsuarioChecador>();
            usuarios.Add(Usuario);
            this.DataSource = usuarios;
            lblNombreUsuario.Text = Usuario.Usuario.Nombre;
            lblEmpleado.Text = "Empleado: " + Usuario.Usuario.NumEmpleado + " - " + Usuario.Usuario.Nombre;
        }

    }
}
