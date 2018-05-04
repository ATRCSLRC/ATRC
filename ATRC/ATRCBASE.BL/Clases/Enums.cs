using DevExpress.Xpo;
using System;
using System.Collections.Generic;
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

    }
}
