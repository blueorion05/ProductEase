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

            btnHome.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnHome.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlHome());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnHome.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnHome.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlHome());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnManage.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnManage.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlManage());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnOrder.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnOrder.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlOrder());
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnRecords.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnRecords.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlRecords());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnAccount.BackColor = Color.FromArgb(0, 150, 136);
            pbActive.BackgroundImage = btnAccount.Image;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlAccount());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ButtonColor();
            this.Close();
        }

        private void ButtonColor()
        {
            btnHome.BackColor = panel3.BackColor;
            btnManage.BackColor = panel3.BackColor;
            btnOrder.BackColor = panel3.BackColor;
            btnRecords.BackColor = panel3.BackColor;
            btnAccount.BackColor = panel3.BackColor;
            btnLogout.BackColor = panel3.BackColor;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
