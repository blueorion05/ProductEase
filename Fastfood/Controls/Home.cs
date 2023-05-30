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
        Information info = new Information();
        ImageList list = new ImageList();
        int listIndex = 0;
        public Home()
        {
            InitializeComponent();
            lblAbout.Text = info.GetAbout();
            pbRecentProduct.Image = info.GetRecentProductImage();
            pbRecentProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            GetAvailableProducts();
        }

        private void GetAvailableProducts()
        {
            list = info.AvailableProducts(this);
            if (list != null)
            {
                list.ImageSize = new Size(pbAvailable1.Width, pbAvailable1.Height);
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable1.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable2.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable3.Image = list.Images[listIndex];
                listIndex++;
            }
        }

        private void controlHome_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (list != null)
            {
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable1.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable2.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable3.Image = list.Images[listIndex];
                listIndex++;
            }
        }

        
    }
}
