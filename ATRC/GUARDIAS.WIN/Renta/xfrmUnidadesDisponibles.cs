using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUARDIAS.WIN.Renta
{
    public partial class xfrmUnidadesDisponibles : xfrmBase
    {
        public xfrmUnidadesDisponibles()
        {
            InitializeComponent();
        }

        private void xfrmUnidadesDisponibles_Load(object sender, EventArgs e)
        {
            dteFecha.DateTime = DateTime.Now;
        }

        private void dteFecha_EditValueChanged(object sender, EventArgs e)
        {
            ValidarDisponibilidad();
        }

        private void ValidarDisponibilidad()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("DiaRegreso", dteFecha.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("DiaSalida", dteFecha.DateTime.Date, BinaryOperatorType.LessOrEqual));
            //go.Operands.Add(new BinaryOperator("Unidad", lueUnidad.EditValue));
            GroupOperator goEstado = new GroupOperator(GroupOperatorType.Or);
            goEstado.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Creado));
            goEstado.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.EnViaje));
            goEstado.Operands.Add(new BinaryOperator("EstadoContrato", Enums.EstadoContrato.Apartado));
            go.Operands.Add(goEstado);
            XPView Contratos = new XPView(UnidadConsulta, typeof(ContratoRenta), "Oid;Unidad.Nombre;Unidad.Oid", go);
            var newlist = Contratos.Cast<ViewRecord>().Select(x => x["Unidad.Oid"]).ToArray();

            GroupOperator goUnidades = new GroupOperator(GroupOperatorType.And);
            goUnidades.Operands.Add(new BinaryOperator("EsRenta", true));
            goUnidades.Operands.Add(new NotOperator(new InOperator("Oid", newlist)));
            XPView Unidades = new XPView(UnidadConsulta, typeof(UNIDADES.BL.Unidad), "Oid;Nombre;Cilindros;Transmision;TipoUnidad;Marca", goUnidades);

            grdUnidades.DataSource = Unidades;

        }
    }
}
