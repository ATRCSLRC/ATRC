using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADES.BL
{
    [Persistent("Uni_HistorialBaterias")]
    public class HistorialBaterias : ATRCBase
    {
        public HistorialBaterias(Session session) : base(session) { }

        private Unidad mUnidad;
        public Unidad Unidad
        {
            get { return mUnidad; }
            set { SetPropertyValue<Unidad>("Unidad", ref mUnidad, value); }
        }

        private string mBaterias;
        public string Baterias
        {
            get { return mBaterias; }
            set { SetPropertyValue<string>("Baterias", ref mBaterias, value); }
        }

        private DateTime mFechaInventarioBaterias;
        public DateTime FechaInventarioBaterias
        {
            get { return mFechaInventarioBaterias; }
            set { SetPropertyValue<DateTime>("FechaInventarioBaterias", ref mFechaInventarioBaterias, value); }
        }

    }
    
}
