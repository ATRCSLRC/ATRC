using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using ATRCBASE.BL;
using System.Collections.Generic;
using CHECADOR.BL;

namespace CHECADOR.WIN.Reportes
{
    public partial class HorasSemanalesTrabajadas : DevExpress.XtraReports.UI.XtraReport
    {
        GroupOperator go;
        public HorasSemanalesTrabajadas(int NumEmpleado, DateTime Inicial, DateTime Final)
        {
            InitializeComponent();

            go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", Inicial, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", Final, BinaryOperatorType.LessOrEqual));
            lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            GroupOperator goFiltro = new GroupOperator();
            goFiltro.Operands.Add(new NotOperator(new NullOperator("Usuario")));
            if(NumEmpleado > 0) goFiltro.Operands.Add(new BinaryOperator("Usuario.NumEmpleado", NumEmpleado));
            XPCollection Usuarios = new XPCollection(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(CHECADOR.BL.UsuarioChecador), goFiltro);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource =Usuarios;
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            CHECADOR.BL.UsuarioChecador Usuario = (UsuarioChecador)this.GetCurrentRow();
            Usuario.HistoricoChecadas.Filter = go;
        }
    }
}
