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
            formLogin form = new formLogin();
            form.Close();

            InitializeComponent();

            panelMain.Controls.Clear();
            controlHome c = new controlHome();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void lbl3manage_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            controlManage c = new controlManage();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void lbl4order_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            controlOrder c = new controlOrder();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void lbl5records_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            controlRecords c = new controlRecords();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void lbl7logout_Click(object sender, EventArgs e)
        {
            formLogin form1 = new formLogin();
            this.Close();
        }

        private void lbl2home_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            controlHome c = new controlHome();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void lbl6account_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            controlAccount c = new controlAccount();
            c.Dock = DockStyle.Fill;
            panelMain.Controls.Add(c);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
