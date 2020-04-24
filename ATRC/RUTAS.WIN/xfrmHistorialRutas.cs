using ATRCBASE.WIN;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmHistorialRutas : xfrmBase
    {
        public xfrmHistorialRutas()
        {
            InitializeComponent();
        }

        public RutasGeneradas Ruta;

        private void xfrmHistorialRutas_Load(object sender, EventArgs e)
        {
            grdHistorial.DataSource = Ruta.Historial;
        }
    }
}
