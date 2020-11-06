using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.XtraReports.UI;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.PedidoRutas
{
    public partial class xfrmRevisionPedido : xfrmBase
    {
        public xfrmRevisionPedido()
        {
            InitializeComponent();
        }

        public int Oid = 0;
        BL.PedidoRutas Pedido;
        private void xfrmRevisionPedido_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Pedido = Unidad.GetObjectByKey<BL.PedidoRutas>(Oid); 
            if(Pedido != null)
            {
                grdRevision.DataSource = Pedido.Rutas;
            }
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Pedido != null)
            {
                REPORTES.Rutas.RutasDePedido Rutas = new REPORTES.Rutas.RutasDePedido(Pedido);
                ReportPrintTool repRutas = new ReportPrintTool(Rutas);
                repRutas.ShowPreview();
            }
        }

        private void ribeDocumento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RutasDePedido Ruta = grvRevision.GetRow(grvRevision.FocusedRowHandle) as RutasDePedido;
            if (Ruta != null)
            {
                xtraSaveFileDialog.Title = "Ruta extra";
                xtraSaveFileDialog.FileName = Ruta.NombreDocumento;

                if (xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                File.WriteAllBytes(xtraSaveFileDialog.FileName, Ruta.Documento);
            }
        }


        private void grvRevision_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            BL.RutasDePedido Ruta = grvRevision.GetRow(e.RowHandle) as BL.RutasDePedido;
            if (Ruta != null)
            {
                if (e.Column.Caption == "Documento")
                {
                    if (Ruta.EsRutaExtra & Ruta.Documento != null)
                        e.RepositoryItem = ribeDocumento;

                }

            }
        }
    }
}
