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
    public partial class formReceipt : Form
    {
        public formReceipt(Receipt r)
        {
            InitializeComponent();
            /*Image image = r.ConvertToImage();
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Image = image;
            panel1.Controls.Add(pb);*/
            panel1.Controls.Add(r);
        }

        private void formReceipt_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
