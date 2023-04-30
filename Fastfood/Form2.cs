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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UserControl1 home = new UserControl1();
            panel1.Controls.Add(home);
            pictureBox1.SendToBack();
        }

        private void lbl3manage_Click(object sender, EventArgs e)
        {
            UserControl2 manage = new UserControl2();
            panel1.Controls.Clear();
            panel1.Controls.Add(manage);
        }

        private void lbl4order_Click(object sender, EventArgs e)
        {
            UserControl3 order = new UserControl3();
            panel1.Controls.Clear();
            panel1.Controls.Add(order);
        }

        private void lbl5records_Click(object sender, EventArgs e)
        {
            UserControl4 records = new UserControl4();
            panel1.Controls.Clear();
            panel1.Controls.Add(records);
        }

        private void lbl7logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl2home_Click(object sender, EventArgs e)
        {
            UserControl1 home = new UserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(home);
        }

        private void lbl6account_Click(object sender, EventArgs e)
        {
            UserControl5 account = new UserControl5();
            panel1.Controls.Clear();
            panel1.Controls.Add(account);
        }
    }
}
