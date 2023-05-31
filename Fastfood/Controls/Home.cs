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
            PictureBox pb = new PictureBox();
            pbRecentTransac.Image = info.GetRecentTransaction();
            pbRecentTransac.SizeMode = PictureBoxSizeMode.StretchImage;
            list = info.AvailableProducts(this);
            GetAvailableProducts();
            DateTime month = new(DateTime.Today.Year, DateTime.Today.Month, 1);
            lblEarnings.Text = (info.GetTotalTransaction(month, DateTime.Today));
        }

        private void GetAvailableProducts()
        {
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
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable4.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable5.Image = list.Images[listIndex];
                listIndex++;
                if (listIndex >= list.Images.Count)
                {
                    listIndex = 0;
                }
                pbAvailable6.Image = list.Images[listIndex];
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
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.FromArgb(25, 26, 62);
            panel7.BackColor = Color.White;
            panel8.BackColor = Color.White;
            lblEarnings.Text = (info.GetTotalTransaction(DateTime.Today.AddDays(-30), DateTime.Today));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (list != null)
            {
                GetAvailableProducts();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel8.BackColor = Color.FromArgb(25, 26, 62);
            Transactions t = new Transactions();
            t.dtStart.Value = DateTime.Today;
            t.dtEnd.Value = DateTime.Today;
            int order = t.dataGridView1.RowCount;
            double earnings = 0;
            foreach (DataGridViewRow row in t.dataGridView1.Rows)
            {
                earnings += Convert.ToDouble(row.Cells["AmountDue"].Value);
            }
            lblOrder.Text = order.ToString();
            lblEarnings.Text = earnings.ToString("0.00");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel7.BackColor = Color.FromArgb(25, 26, 62);
            panel8.BackColor = Color.White;
            Transactions t = new Transactions();
            t.dtStart.Value = DateTime.Today.AddDays(-7);
            t.dtEnd.Value = DateTime.Today;
            int order = t.dataGridView1.RowCount;
            double earnings = 0;
            foreach (DataGridViewRow row in t.dataGridView1.Rows)
            {
                earnings += Convert.ToDouble(row.Cells["AmountDue"].Value);
            }
            lblOrder.Text = order.ToString();
            lblEarnings.Text = earnings.ToString("0.00");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(25, 26, 62);
            panel6.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel8.BackColor = Color.White;
            Transactions t = new Transactions();
            t.dtStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            t.dtEnd.Value = DateTime.Today;
            int order = t.dataGridView1.RowCount;
            double earnings = 0;
            foreach (DataGridViewRow row in t.dataGridView1.Rows)
            {
                earnings += Convert.ToDouble(row.Cells["AmountDue"].Value);
            }
            lblOrder.Text = order.ToString();
            lblEarnings.Text = earnings.ToString("0.00");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbRecentTransac_Click(object sender, EventArgs e)
        {

        }

        private void pbRecentProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
