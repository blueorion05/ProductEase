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

            btnHome.BackColor = panel2.BackColor;
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
            btnHome.BackColor = panel2.BackColor;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlHome());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnManage.BackColor = panel2.BackColor;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlManage());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnOrder.BackColor = panel2.BackColor;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlOrder());
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnRecords.BackColor = panel2.BackColor;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlRecords());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnAccount.BackColor = panel2.BackColor;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new controlAccount());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ButtonColor();
            btnLogout.BackColor = panel2.BackColor;
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
    }
}
