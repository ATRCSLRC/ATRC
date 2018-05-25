using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [NonPersistent]
     public class Enums
    {
       
        public enum TipoIdentificacion
        {
            Ninguno = 0,
            Gafete = 1,
            Manual = 2
        }

        public enum TipoAplicacion
        {
            Ninguno = 0,
            Windows = 1,
            Web = 2
        }

        public enum TipoArticulo
        {
            General = 0,
            Baterias = 1,
            Llantas = 2,
            Herramienta = 3
        }

        public enum TipoMedida
        {
            Pzs = 0,
            Kg = 1,
            Gr = 2,
            Lts = 3,
            Pies = 4,
            Pulgadas = 5,
            Metros = 6,
            Cm = 7,
            Lbs = 8
        }
        public enum Destino
        {
            Unidad = 0,
            Otro = 1
        }

        public enum Recibo
        {
            Usuario = 0,
            Otro = 1
        }

        public enum EstadoSalida
        {
            Entregado = 0,
            Devuelto = 1
        }

        public enum Combustible
        {
            Ninguno = 0,
            Gasolina = 1,
            Disel = 2,
            Gas = 3,
            Electricidad = 4
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

        public enum Suspencion
        {
            Ninguno = 0,
            Muelles = 1,
            Aire = 2, 
            Amortiguador = 3
        }

        public enum Puerta
        {
            Ninguna = 0,
            Manual = 1,
            Hidraulica = 2,
            Aire = 3
        }

        public enum ServiciosUnidad
        {
            Compostura = 0,
            [Description("Cambio de aceite")]
            CambioAceite = 1,
            Lavado = 2,
            Otro = 3
        }

        public enum TipoDestino
        {
            Unidad = 0,
            Empleado = 1
        }

        public enum TipoUnidad
        {
            Camion = 0,
            Automovil = 1,
            Maquinaria = 2
        }
    }
}
