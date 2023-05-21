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
        Home home = new Home();
        Manage manage = new Manage();
        Transactions records = new Transactions();
        Account account = new Account();
        formPOS pos = new formPOS();
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
                panelMain.Controls.Add(manage);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            pos.ShowDialog();
            this.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnTransactions.Image)
            {
                ButtonColor();
                btnTransactions.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnTransactions.Image;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(records);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (pbActive.BackgroundImage != btnAccount.Image)
            {
                ButtonColor();
                btnAccount.BackColor = Color.FromArgb(0, 150, 136);
                pbActive.BackgroundImage = btnAccount.Image;
                panelMain.Controls.Clear();
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
            btnAccount.BackColor = panelMenu.BackColor;
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
    }
}
