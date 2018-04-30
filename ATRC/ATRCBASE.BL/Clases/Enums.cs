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

    }
}
