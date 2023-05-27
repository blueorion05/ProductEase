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
            if (label1.Text.Contains("Company name"))
            {
                i.UpdateName(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Address"))
            {
                i.UpdateAddress(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Landline"))
            {
                i.UpdateLandline(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains(".Cellphone No"))
            {
                textBox1.Text = textBox1.Text.Trim();
                textBox1.Text = textBox1.Text.Replace(".", "");
                if (textBox1.Text.StartsWith("639") || textBox1.Text.Length == 0)
                {
                    if (double.TryParse(textBox1.Text, out double valid) || textBox1.Text.Length == 0)
                    {
                        if (textBox1.Text.Length == 12 || textBox1.Text.Length == 0)
                        {
                            i.UpdateCpNum(this);
                            main.btnAccount_Click(sender, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Check your inputted number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check your inputted number.");
                        textBox1.Text = "639";
                    }
                }
                else
                {
                    MessageBox.Show("Check your inputted number.");
                    textBox1.Text = "639";
                }
            }
            else if (label1.Text.Contains("Email"))
            {
                i.UpdateEmail(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Store Hours"))
            {
                i.UpdateStoreHours(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("About"))
            {
                if (textBox1.Text.Length <= 500)
                {
                    i.UpdateAbout(this);
                    main.btnAccount_Click(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You can only enter at most 500 characters.");
                }
            }
            else if (label1.Text.Contains("Username"))
            {
                textBox1.Text = textBox1.Text.Trim();
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
            else if (label1.Text.Contains("Current Password"))
            {
                textBox2.Text = textBox2.Text.TrimEnd();
                textBox3.Text = textBox3.Text.TrimEnd();
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void formInformation_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void formInformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }
    }
}
