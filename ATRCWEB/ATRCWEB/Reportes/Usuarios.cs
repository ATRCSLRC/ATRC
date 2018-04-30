﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace ATRCWEB.Reportes
{
    public partial class Usuarios : DevExpress.XtraReports.UI.XtraReport
    {
        public Usuarios()
        {
            InitializeComponent();

            XPCollection Usuarios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(ATRCBASE.BL.Usuario));
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Usuarios;
        }

    }
}
