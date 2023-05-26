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
    public partial class formInformation : Form
    {
        formMain main = new formMain();
        public formInformation(formMain f)
        {
            InitializeComponent();
            main = f;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Information i = new Information();
            if (label1.Text == "Company name:")
            {
                i.UpdateName(this);
                main.btnAccount_Click(sender, e);
            }
            if (label1.Text == "Address:")
            {
                i.UpdateAddress(this);
                main.btnAccount_Click(sender, e);
            }
            if (label1.Text == "Landline:")
            {
                i.UpdateLandline(this);
                main.btnAccount_Click(sender, e);
            }
            if (label1.Text == "Cellphone No.:")
            {
                i.UpdateCpNum(this);
                main.btnAccount_Click(sender, e);
            }
            if (label1.Text == "Email:")
            {
                i.UpdateEmail(this);
                main.btnAccount_Click(sender, e);
            }
            if (label1.Text == "Store Hours:")
            {
                i.UpdateStoreHours(this);
                main.btnAccount_Click(sender, e);
            }
            this.Close();
        }
    }
}
