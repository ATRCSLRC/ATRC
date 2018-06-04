﻿using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmUsuario : RibbonForm
    {
        public xfrmUsuario()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Unidad.BL.Usuario Usuario;
        public bool esModificacion = false;

        private void xfrmUnidad_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Usuario = new Unidad.BL.Usuario(Unidad);
            }
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text))
            {
                Usuario.Save();
                Unidad.CommitChanges();
                if (esModificacion)
                    XtraMessageBox.Show("Se ha realizado la modificación correctamente.");
                else
                    XtraMessageBox.Show("Se ha guardado la unidad correctamente.");
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void LigarControles()
        {
            txtNombre.DataBindings.Add("EditValue", Usuario, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMarca.DataBindings.Add("EditValue", Usuario, "Marca", true, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("EditValue", Usuario, "Modelo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVIN.DataBindings.Add("EditValue", Usuario, "VIN", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
