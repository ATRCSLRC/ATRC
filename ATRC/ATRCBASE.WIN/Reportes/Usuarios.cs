using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace ATRCBASE.WIN.Reportes
{
    public partial class Usuarios : DevExpress.XtraReports.UI.XtraReport
    {
        public Usuarios()
        {
            InitializeComponent();

            XPView Usuarios = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(ATRCBASE.BL.Usuario), "Nombre;NumEmpleado;RFC;Puesto.Descripcion;Departamento.Descripcion;IMSS", null);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Usuarios;
        }

    }
}
