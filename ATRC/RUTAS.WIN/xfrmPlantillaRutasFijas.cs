using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class xfrmPlantillaRutasFijas : xfrmBase
    {
        public xfrmPlantillaRutasFijas()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public PlantillaRutas Plantilla;
        public bool EsNuevo;

        private void xfrmPlantillaRutasExtras_Load(object sender, EventArgs e)
        {
            Loading.ShowWaitForm();
            XPView Maquiladoras = new XPView(Unidad, typeof(Empresas), "Oid;Nombre;Clave", null);
            lueMaquiladora.Properties.DataSource = Maquiladoras;
            if (!EsNuevo)
            {
                LigarControles();
            }
            flpAcciones.ShowPopup();
            Loading.CloseWaitForm();
        }
        private void LigarControles()
        {
            txtNombre.Text = Plantilla.Nombre;
            lueMaquiladora.EditValue = Plantilla.Empresa == null ? -1 : Plantilla.Empresa.Oid;
            Plantilla.PlantillasRutasFijas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
            chkEsExterno.Checked = Plantilla.EsExterno;
            grdRutasExtras.DataSource = Plantilla.PlantillasRutasFijas;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if (Plantilla != null)
                {
                    Plantilla.Nombre = txtNombre.Text;
                    Plantilla.Empresa = Unidad.GetObjectByKey<Empresas>(lueMaquiladora.EditValue);
                    Plantilla.EsExterno = chkEsExterno.Checked;
                    Plantilla.Save();
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("Se han guardado los cambios correctamente.");
                    this.Close();
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void flpAcciones_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {

            switch (e.Button.Caption)
            {
                case "Agregar ruta":
                    
                    xfrmRutasFijas xfrmAgregar = new xfrmRutasFijas();
                    xfrmAgregar.EsPlantilla = true;
                    xfrmAgregar.Orden = Plantilla.PlantillasRutasFijas.Count + 1;
                    xfrmAgregar.PlantillaRuta = Plantilla;
                    xfrmAgregar.ShowDialog();
                    if(grdRutasExtras.DataSource == null)
                        grdRutasExtras.DataSource = Plantilla.PlantillasRutasFijas;
                    break;

                case "Modificar ruta":
                    PlantillaRutaFija PlantillaRutaExtraModificar = grvRutasExtras.GetFocusedRow() as PlantillaRutaFija;
                    if (PlantillaRutaExtraModificar != null)
                    {
                        xfrmRutasFijas xfrmModificar = new xfrmRutasFijas();
                        xfrmModificar.EsPlantilla = true;
                        xfrmModificar.EsModificacion = true;
                        xfrmModificar.PlantillaRutaExtraEditar = PlantillaRutaExtraModificar;
                        xfrmModificar.ShowDialog();
                    }
                    break;

                case "Eliminar ruta":
                    PlantillaRutaFija PlantillaRutaExtra = grvRutasExtras.GetFocusedRow() as PlantillaRutaFija;
                    if (PlantillaRutaExtra != null)
                    {
                        if (XtraMessageBox.Show("¿Está seguro de querer eliminar la plantilla la ruta seleccionada ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            PlantillaRutaExtra.Delete();
                        }
                    }

                    //((XPView)grdRutasExtras.DataSource).Reload();
                    int x = 1;
                    foreach (PlantillaRutaFija ruta in (XPCollection<PlantillaRutaFija>)grdRutasExtras.DataSource)
                    {
                        //RutasGeneradas ruta = (RutasGeneradas)view.GetObject();
                        ruta.OrdenRutas = x;
                        //ruta.Save();
                        x++;
                    }
                    Plantilla.PlantillasRutasFijas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
                    break;
            }
        }

        private bool ValidarCampos()
        {

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe agregar un nombre a la plantilla.");
                txtNombre.Focus();
                return false;
            }

            if(lueMaquiladora.EditValue == null)
            {
                XtraMessageBox.Show("Debe selecionar una maquiladora.");
                lueMaquiladora.Focus();
                return false;
            }

            return true;
        }

        private void lueMaquiladora_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                //DataRow row = lue.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Clave"] + " -" + row["Nombre"];
            }
        }

        private void grdRutasExtras_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = downHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;
            MoveRow(sourceRow, targetRow);
        }

        private void grdRutasExtras_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            if (downHitInfo != null)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle)
                    e.Effect = DragDropEffects.Move;
            }
        }
        GridHitInfo downHitInfo = null;
        private void grvRutasExtras_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow)
                downHitInfo = hitInfo;
        }

        private void grvRutasExtras_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }

        private void MoveRow(int sourceRow, int targetRow)
        {
            //if (sourceRow == targetRow || sourceRow == targetRow + 1) return;

            GridView view = grvRutasExtras;
            PlantillaRutaFija row1 = (PlantillaRutaFija)view.GetRow(targetRow);
            //RutasGeneradas row2 = ((ViewRecord)view.GetRow(targetRow + 1)).GetObject() as RutasGeneradas;
            PlantillaRutaFija dragRow = (PlantillaRutaFija)view.GetRow(sourceRow);
            int val1 = row1.OrdenRutas;
            //if (row2 == null)
            //    dragRow.OrdenRutas = val1 + 1;
            //else
            //{
            //int val2 = row2.OrdenRutas;
            //dragRow.OrdenRutas = (val1 + val2) / 2;
            int val2 = dragRow.OrdenRutas;
            dragRow.OrdenRutas = val1;
            if (val2 < val1)
            {
                val1--;
                row1.OrdenRutas = val1;
                val1--;
                //row2.OrdenRutas = val1;
                //val1--;
                row1.Save();
                while (val1 >= val2)
                {
                    PlantillaRutaFija row = (PlantillaRutaFija)view.GetRow(val1);
                    if (row == dragRow)
                        row = (PlantillaRutaFija)view.GetRow(val1 + 1);
                    row.OrdenRutas = val1;
                    val1--;
                    row.Save();
                }
            }
            else
            {

                val1++;
                row1.OrdenRutas = val1;
                val1++;
                //row2.OrdenRutas = val1;
                //val1++;
                row1.Save();
                //row2.OrdenRutas = val2++;

                while (val1 <= val2)
                {
                    PlantillaRutaFija row = (PlantillaRutaFija)view.GetRow(val1 - 2);
                    if (row == dragRow)
                        row = (PlantillaRutaFija)view.GetRow(val1);
                    row.OrdenRutas = val1;
                    val1++;
                    row.Save();
                }
            }
            //}

            dragRow.Save();
            Plantilla.PlantillasRutasFijas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
            // dragRow.Session.CommitTransaction();
            // ((XPCollection<PlantillaRutaFija>)grdRutasExtras.DataSource).Reload();
            grvRutasExtras.ClearSelection();
            grvRutasExtras.FocusedRowHandle = dragRow.OrdenRutas - 1;
        }
    }
}
