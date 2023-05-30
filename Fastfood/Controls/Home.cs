using System;
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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void controlHome_Load(object sender, EventArgs e)
        {
            formMain f = new formMain();
            this.Height = f.panelMain.Height;
            this.Width = f.panelMain.Width;
        }

        private void controlHome_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
