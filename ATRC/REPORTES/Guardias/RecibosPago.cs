using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using GUARDIAS.BL;

namespace REPORTES.Guardias
{
    public partial class RecibosPago : DevExpress.XtraReports.UI.XtraReport
    {
        public RecibosPago(int ID)
        {
            InitializeComponent();

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView ViewRecibo = new XPView(Unidad, typeof(Recibos),"Oid;Emisor;Precio;PrecioEscrito;Concepto;Fecha;Folio", new BinaryOperator("Oid", ID));
            this.DataSource = ViewRecibo;
            string Concepto = ViewRecibo[0]["Concepto"].ToString();
            if (Concepto.Length <= 82)
            {
                lblConceptoUno.Text = lblConceptoUnoCopia.Text = Concepto;
            }else if(Concepto.Length <= 182)
            {
                lblConceptoUno.Text = lblConceptoUnoCopia.Text = Concepto.Substring(0,82);
                lblConceptoDos.Text = lblConceptoDosCopia.Text = Concepto.Substring(82);
            }
            else
            {
                lblConceptoUno.Text = lblConceptoUnoCopia.Text = Concepto.Substring(0, 82);
                lblConceptoDos.Text = lblConceptoDosCopia.Text = Concepto.Substring(82, 102).TrimStart(new char[] {' '});
                lblConceptoTresCopia.Text = lblConceptoTres.Text = Concepto.Substring(181).TrimStart(new char[] { ' ' });
            }
        }

    }
}
