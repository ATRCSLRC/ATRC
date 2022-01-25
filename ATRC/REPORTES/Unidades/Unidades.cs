using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;
using DevExpress.Xpo;

namespace REPORTES.Unidades
{
    public partial class Unidades : DevExpress.XtraReports.UI.XtraReport
    {
        public Unidades(string Estado)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator(("EsSeccion"), false));
            go.Operands.Add(new NullOperator("EsSeccion"));
            goMain.Operands.Add(go);
            GroupOperator goEstado = new GroupOperator(GroupOperatorType.Or);
            if (Estado == "Todas")
            {
                goEstado.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
                goEstado.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.FueraServicio));
                goEstado.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
                goEstado.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Vendido));
            }else
                goEstado.Operands.Add(new BinaryOperator("EstadoUnidad", (Enums.EstadoUnidad)Enum.Parse(typeof(Enums.EstadoUnidad),Estado)));

            goMain.Operands.Add(goEstado);

            XPView Diesel = new XPView(Unidad, typeof(UNIDADES.BL.Unidad), "Oid;Nombre;Marca;Modelo;EstadoUnidad;Combustible", goMain);
            Diesel.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource = Diesel;

        }

    }
}
