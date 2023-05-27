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
        public string username = "";
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
                this.Close();
            }
            else if (label1.Text == "Address:")
            {
                i.UpdateAddress(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "Landline:")
            {
                i.UpdateLandline(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "Cellphone No.:")
            {
                i.UpdateCpNum(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "Email:")
            {
                i.UpdateEmail(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "Store Hours:")
            {
                i.UpdateStoreHours(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "About:")
            {
                i.UpdateAbout(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text == "Username:")
            {
                textBox1.Text = textBox1.Text.Trim();
                if (textBox1.Text.Length > 0)
                {
                    if (textBox1.Text.Length >= 5 && textBox1.Text.Length <= 12)
                    {
                        i.UpdateUsername(this);
                        main.btnAccount_Click(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username must be 5 - 12 characters long.");
                    }
                }
                else
                {
                    MessageBox.Show("Username cannot be empty.");
                }
            }
            else if (label1.Text == "Current Password:")
            {
                textBox1.Text = textBox1.Text.Trim();
                textBox2.Text = textBox2.Text.Trim();
                textBox3.Text = textBox3.Text.Trim();
                if (textBox1.Text.Length >  0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                    if (textBox1.Text == i.GetPassword())
                    {
                        if (textBox3.Text.Length >= 5 && textBox3.Text.Length <= 12)
                        {
                            if (textBox2.Text == textBox3.Text)
                            {
                                i.UpdatePassword(this);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Confirm your new password.");
                                textBox3.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("New password must be 5 - 12 characters long.");
                            textBox2.Text = "";
                            textBox3.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorect.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Password cannot be empty.");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void formInformation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
