using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Fastfood
{
    public partial class formLogin : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public formLogin()
        {
            InitializeComponent();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\blueorion05\Fastfood\Fastfood\Database\Login.accdb;
            Persist Security Info=False";
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Account where username = '" + tbuser.Text + "' and password='" + tbpass.Text + "'";

            OleDbDataReader or = cmd.ExecuteReader();

            int count = 0;
            while (or.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                conn.Close();
                this.Hide();
                formMain f = new formMain();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                conn.Close();
                MessageBox.Show("Enter valid username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbuser.Text = null;
                tbpass.Text = null;
            }


        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}