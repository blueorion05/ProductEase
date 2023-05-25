using ProductEase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Fastfood
{
    public partial class formMain : Form
    {
        Home home = new Home();
        Manage manage = new Manage();
        Settings account = new Settings();
        public formMain()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnHome.Image)
            {
                ButtonColor();
                btnHome.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnHome.Image;
                panelMain.Controls.Clear();
                home.Dock = DockStyle.Fill;
                panelMain.Controls.Add(home);
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnManage.Image)
            {
                ButtonColor();
                btnManage.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnManage.Image;
                panelMain.Controls.Clear();
                manage.Dock = DockStyle.Fill;
                panelMain.Controls.Add(manage);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            formPOS pos = new formPOS();
            this.Hide();
            pos.ShowDialog();
            this.ShowDialog();
        }

        public void btnRecords_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnTransactions.Image)
            {
                Transactions records = new Transactions();
                ButtonColor();
                btnTransactions.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnTransactions.Image;
                panelMain.Controls.Clear();
                records.Dock = DockStyle.Fill;
                panelMain.Controls.Add(records);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnSettings.Image)
            {
                ButtonColor();
                btnSettings.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnSettings.Image;
                panelMain.Controls.Clear();
                account.Dock = DockStyle.Fill;
                panelMain.Controls.Add(account);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ButtonColor();
            this.Close();
        }

        private void ButtonColor()
        {
            btnHome.BackColor = panelMenu.BackColor;
            btnManage.BackColor = panelMenu.BackColor;
            btnPOS.BackColor = panelMenu.BackColor;
            btnTransactions.BackColor = panelMenu.BackColor;
            btnSettings.BackColor = panelMenu.BackColor;
            btnLogout.BackColor = panelMenu.BackColor;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                button1.Image = Resources.restoredown;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button1.Image = Resources.maximize;
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
