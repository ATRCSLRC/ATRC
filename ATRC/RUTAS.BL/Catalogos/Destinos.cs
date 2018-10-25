﻿using ATRCBASE.BL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RUTAS.BL
{
    [Persistent("rut_Destinos")]
    public class Destinos : ATRCBase
    {
        public Destinos(Session session) : base(session) { }


        private string mDescripcion;
        public string Descripcion
        {
            get { return mDescripcion; }
            set { SetPropertyValue<string>("Descripcion", ref mDescripcion, value); }
        }
    }
}