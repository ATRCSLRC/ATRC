﻿using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using RUTAS.BL;
using System;

namespace REPORTES.Rutas
{
    public partial class ReporteRutasExtras : DevExpress.XtraReports.UI.XtraReport
    {

        public ReporteRutasExtras(DateTime Fecha)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("FechaRuta", Fecha));
            go.Operands.Add(new BinaryOperator("EsRutaExtra", true));

            XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;Empresa.Nombre;Empresa.Oid;OrdenRutas;Ruta;TipoRuta;Servicio.TipoUnidad;ChoferEntrada.Nombre;ChoferSalida.Nombre;HoraEntrada;HoraSalida;Turno.Oid;Turno.Descripcion;Comentarios", go);
            if (Fecha >= new DateTime(2020, 07, 16))
                Rutas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
            this.DataSource = Rutas;
            lblDetalles.Text = Fecha.ToLongDateString();
        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
