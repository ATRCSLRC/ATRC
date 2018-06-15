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

        public enum Transmision
        {
            Ninguna = 0,
            Estandar = 1,
            Automatico = 2
        }

        public enum Frenos
        {
            Ninguno = 0,
            Hidraulicos = 1,
            Aire = 2,
            Otro = 3

        }

        public enum TipoUnidad
        {
            Camion = 0,
            Micro = 1,
            Automovil = 2,
            Panel = 3,
            Maquinaria = 4
        }

        public enum Estado
        {
            Translado = 0,
            Detallado = 1,
            Preparado = 2,
            Vendido = 3
        }

        public enum TipoTransaccion
        {
            Gasto = 0,
            Pago = 1
        }
    }
}
