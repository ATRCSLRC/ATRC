﻿using System;
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
    public partial class xfrmBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public xfrmBase()
        {
            InitializeComponent();
        }

        private void xfrmBase_Load(object sender, EventArgs e)
        {
        }

        private void xfrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt || Control.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }
    }
}
