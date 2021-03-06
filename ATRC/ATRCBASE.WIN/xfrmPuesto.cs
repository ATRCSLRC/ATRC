﻿using ATRCBASE.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmPuesto : xfrmBase
    {
        public xfrmPuesto()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Puesto Puesto;

        #region Eventos
        private void xfrmPuesto_Load(object sender, EventArgs e)
        {
            memoDescripcion.DataBindings.Add("EditValue", Puesto, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(memoDescripcion.Text))
            {
                Puesto.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            memoDescripcion.DataBindings.Clear();
            this.Close();
        }
        #endregion
    }
}
