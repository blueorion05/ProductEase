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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value == 80)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                formLogin start = new formLogin();
                this.Hide();
                start.Show();
            }
        }
        private void StartUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
