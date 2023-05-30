using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;

namespace Fastfood
{
    public partial class formLogin : Form
    {
        Information info = new Information();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            info.CheckLogin(this);
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                info.CheckLogin(this);
            }
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                info.CheckLogin(this);
            }
        }

        private void formLogin_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void panelHeader_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void formLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                info.CheckLogin(this);
            }
        }
    }
}