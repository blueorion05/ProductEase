using System.Data;
using System.Data.SqlClient;

namespace Fastfood
{
    public partial class formLogin : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.Combine(Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Database", "ProductEase.mdf") + ";Integrated Security=True");

        public formLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username, password;
            bool valid = false;
            username = tbUser.Text;
            password = tbPass.Text;
            try
            {
                conn.Open();
                String match = "SELECT * FROM Login WHERE username = '" + tbUser.Text + "' AND password = '" + tbPass.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(match, conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string user = row["Username"].ToString()!;
                    string pass = row["Password"].ToString()!;

                    if (user == tbUser.Text && pass == tbPass.Text)
                    {
                        valid = true;
                        username = tbUser.Text;
                        password = tbPass.Text;

                        this.Hide();
                        formMain f = new formMain();
                        f.ShowDialog();
                        tbUser.Text = null;
                        tbPass.Text = null;
                        this.Show();
                        break;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                if (valid == false)
                {
                    MessageBox.Show("Invalid username/password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUser.Text = "";
                    tbPass.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
            }
        }

        private void formLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnter(EventArgs.Empty);
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
    }
}