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
using DevExpress.Utils.Filtering.Internal;

namespace CHECADOR.WIN.Reportes
{
    public partial class HorasSemanalesTrabajadas : DevExpress.XtraReports.UI.XtraReport
    {
        GroupOperator go;
        DateTime FechaInicial;
        DateTime FechaFinal;
        UnidadDeTrabajo Unidad;
        public HorasSemanalesTrabajadas(int NumEmpleado, DateTime Inicial, DateTime Final)
        {
            InitializeComponent();

            Unidad = ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            this.FechaInicial = Inicial;
            this.FechaFinal = Final;
            go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaChecada", Inicial, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", Final, BinaryOperatorType.LessOrEqual));
            lblDetalle.Text = "Del: " + Inicial.ToLongDateString() + " Al: " + Final.ToLongDateString();
            GroupOperator goFiltro = new GroupOperator();
            goFiltro.Operands.Add(new NotOperator(new NullOperator("Usuario")));
            if(NumEmpleado > 0) goFiltro.Operands.Add(new BinaryOperator("Usuario.NumEmpleado", NumEmpleado));
            XPCollection Usuarios = new XPCollection(Unidad, typeof(CHECADOR.BL.UsuarioChecador), goFiltro);
            Usuarios.Sorting.Add(new SortingCollection(new SortProperty("Usuario.NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            this.DataSource =Usuarios;
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            DateTime mFechaInicial = FechaInicial;
            DateTime mFechaFinal = FechaFinal;
            CHECADOR.BL.UsuarioChecador Usuario = (UsuarioChecador)this.GetCurrentRow();
            Usuario.HistoricoChecadas.Criteria = go;
            while(mFechaFinal >= mFechaInicial)
            {
                Usuario.HistoricoChecadas.Filter = new BinaryOperator("FechaChecada", mFechaInicial);
                if(Usuario.HistoricoChecadas.Count <= 0)
                {
                    HistoricoChecadas historial = new HistoricoChecadas(Unidad);
                    historial.Usuario = Usuario;
                    historial.FechaChecada = mFechaInicial;
                    historial.HoraChecadaEntrada = new TimeSpan(0, 0, 0);
                    historial.HoraChecadaSalida = new TimeSpan(0, 0, 0);
                    Usuario.HistoricoChecadas.Add(historial);
                }
                Usuario.HistoricoChecadas.Filter = null;
                mFechaInicial = mFechaInicial.AddDays(1);
            }
        }
    }
}
