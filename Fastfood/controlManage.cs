﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class controlManage : UserControl
    {
        public controlManage()
        {
            InitializeComponent();
        }

        private void controlManage_Load(object sender, EventArgs e)
        {
            formMain f = new formMain();
            this.Height = f.panelMain.Height;
            this.Width = f.panelMain.Width;
        }
    }
}
