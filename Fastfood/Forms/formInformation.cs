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
        Information info = new Information();
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
            if (label1.Text.Contains("Company Name"))
            {
                info.UpdateName(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Address"))
            {
                info.UpdateAddress(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains(".Contact No"))
            {
                info.UpdateContactNum(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Email"))
            {
                info.UpdateEmail(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("Store Hours"))
            {
                info.UpdateStoreHours(this);
                main.btnAccount_Click(sender, e);
                this.Close();
            }
            else if (label1.Text.Contains("About"))
            {
                if (textBox1.Text.Length <= 500)
                {
                    info.UpdateAbout(this);
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
                    info.UpdateUsername(this);
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
                    if (textBox1.Text == info.GetPassword())
                    {
                        if (textBox3.Text.Length >= 5 && textBox3.Text.Length <= 12)
                        {
                            if (textBox2.Text == textBox3.Text)
                            {
                                info.UpdatePassword(this);
                                this.Close();
                                main.Close();
                                formLogin login = new formLogin();
                                login.Show();
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
