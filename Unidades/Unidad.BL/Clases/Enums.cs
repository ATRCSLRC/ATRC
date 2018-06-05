using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad.BL
{
    [NonPersistent]
     public class Enums
    {
       
        public enum TipoMoneda
        {
            Pesos = 0,
            Dolares = 1
        }

        public enum ConceptoGasto
        {
            [Description("Compra de unidad")]
            CompraUnidad = 0,
            Translado = 1,
            Importación = 2,
            Detallado = 3,
            Otros = 4
        }

        public enum FormaPago
        {
            Efectivo = 0,
            Cheque = 1,
            Transferencia = 2,
            Tarjeta = 3,
            Otros = 4
        }
    }
}
