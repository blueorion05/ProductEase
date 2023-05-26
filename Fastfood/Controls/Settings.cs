using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class Settings : UserControl
    {
        formMain main = new formMain();
        public Settings(formMain f)
        {
            InitializeComponent();
            main = f;
            Information();
        }

        private void Information()
        {
            Information i = new Information();
            i.GetSettingsInfo(this);
        }

        private void controlAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HideEditPassword(formInformation f)
        {
            f.label2.Visible = false;
            f.label3.Visible = false;
            f.textBox2.Visible = false;
            f.textBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblNameTag.Text;
            f.textBox1.Text = lblName.Text;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblAddressTag.Text;
            f.textBox1.Text = lblAddress.Text;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblLandlineTag.Text;
            f.textBox1.Text = lblLandline.Text;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblCpNumTag.Text;
            f.textBox1.Text = lblCpNum.Text;
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblEmailTag.Text;
            f.textBox1.Text = lblEmail.Text;
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.label1.Text = lblStoreHoursTag.Text;
            f.textBox1.Text = lblStoreHours.Text;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            f.textBox1.UseSystemPasswordChar = true;
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formInformation f = new formInformation(main);
            HideEditPassword(f);
            f.username = lblUser.Text;
            f.label1.Text = lblUserTag.Text;
            f.textBox1.Text = lblUser.Text;
            f.Show();
        }
    }
}
