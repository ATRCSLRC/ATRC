using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using System.IO;

namespace ATRCBASE.WIN.Reportes
{
    public partial class GafeteFrente : DevExpress.XtraReports.UI.XtraReport
    {
        public GafeteFrente(Usuario Usuario)
        {
            InitializeComponent();
            if (Usuario.Nombre != "admin")
            {
                string[] Usuarios = Usuario.Nombre.Split(' ');
                lblApellido.Text = Usuarios[0] + " " + Usuarios[1];
                string Nombre = "";
                int num = 1;
                foreach (string nombre in Usuarios)
                {
                    if (num > 2)
                        Nombre += " " + nombre;
                    num++;
                }
                lblNombre.Text = Nombre;
            }
            lblNumEmpleado.Text = Usuario.NumEmpleado.ToString();
            lblPuesto.Text = Usuario.Puesto == null ? "" : Usuario.Puesto.Descripcion;
            xrPictureBox1.Image = Base64ToImage(Usuario.Imagen == null ? "" : Usuario.Imagen.Archivo);
        }

        public Image Base64ToImage(string img)
        {
            if (!string.IsNullOrEmpty(img))
            {
                byte[] image = Convert.FromBase64String(img);
                MemoryStream stream = new MemoryStream(image);
                return Image.FromStream(stream);
            }
            return null;
        }
    }
}
