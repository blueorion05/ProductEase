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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            UserControl1 home = new UserControl1();
            panelMain.Controls.Add(home);
        }

        public static void AddControl(UserControl f)
        {

        }

        private void lbl3manage_Click(object sender, EventArgs e)
        {
            UserControl2 manage = new UserControl2();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(manage);
        }

        private void lbl4order_Click(object sender, EventArgs e)
        {
            UserControl3 order = new UserControl3();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(order);
        }

        private void lbl5records_Click(object sender, EventArgs e)
        {
            UserControl4 records = new UserControl4();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(records);
        }

        private void lbl7logout_Click(object sender, EventArgs e)
        {
            formLogin form1 = new formLogin();
            this.Hide();
            form1.ShowDialog();
        }

        private void lbl2home_Click(object sender, EventArgs e)
        {
            UserControl1 home = new UserControl1();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(home);
        }

        private void lbl6account_Click(object sender, EventArgs e)
        {
            UserControl5 account = new UserControl5();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(account);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
