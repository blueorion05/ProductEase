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
    public partial class controlAccount : UserControl
    {
        public controlAccount()
        {
            InitializeComponent();
        }

        private void controlAccount_Load(object sender, EventArgs e)
        {
            formMain f = new formMain();
            this.Height = f.panelMain.Height;
            this.Width = f.panelMain.Width;
        }

        private void MaleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleCB.Checked)
            {
                FemaleCB.Checked = false;
                PNTSCB.Checked = false;
            }
        }

        private void FemaleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleCB.Checked)
            {
                MaleCB.Checked = false;
                PNTSCB.Checked = false;
            }
        }

        private void PNTSCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PNTSCB.Checked)
            {
                MaleCB.Checked = false;
                FemaleCB.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = TB1.Text + " " + TB2.Text + " " + TB3.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            string dateSelected = selectedDate.ToString();
            string LBcontact = TB4.Text;
            string LBemail = TB5.Text;

            label8.Text = fullName;
            LBbirthday.Text = dateSelected;
            LBContact.Text = LBcontact;
            LBEmail.Text = LBemail;

        }
    }
}
