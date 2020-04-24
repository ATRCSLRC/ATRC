using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmVisorPDF : xfrmBase
    {
        public xfrmVisorPDF()
        {
            InitializeComponent();
        }
        public MemoryStream PDF;

        private void xfrmVisorPDF_Load(object sender, EventArgs e)
        {
            pdfViewer.LoadDocument(PDF);
        }
    }
}
