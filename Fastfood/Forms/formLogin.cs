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
            username = tbUser.Text;
            password = tbPass.Text;
            try
            {
                conn.Open();
                String match = "SELECT * FROM Login WHERE username = '" + tbUser.Text + "' AND password = '" + tbPass.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(match, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    username = tbUser.Text;
                    password = tbPass.Text;

                    this.Hide();
                    formMain f = new formMain();
                    f.ShowDialog();
                    this.Show();
                }
                else
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
    }
}