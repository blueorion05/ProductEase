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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Fastfood
{
    public partial class formAddProduct : Form
    {
        public formAddProduct()
        {
            InitializeComponent();
        }

        public SqlConnection GetConnection()
        {
            string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.Combine(Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Database", "ProductEase.mdf") + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return conn;
        }

        public void AddFood()
        {
            string addProduct = "INSERT INTO Products VALUES (@Id, @Category, @Product_Name, @Price, @Image, @Available)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(addProduct, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                formAddProduct f = new formAddProduct();
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = tbId.Text;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = cbCategory.Text;
                cmd.Parameters.Add("@Product_Name", SqlDbType.VarChar).Value = tbName.Text;
                cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = tbPrice.Text;
                cmd.Parameters.Add("@Image", SqlDbType.VarChar).Value = tbImage.Text;
                cmd.Parameters.Add("@Available", SqlDbType.VarChar).Value = comboBox1.Text;
                cmd.ExecuteNonQuery();
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

        private void formAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFood();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
