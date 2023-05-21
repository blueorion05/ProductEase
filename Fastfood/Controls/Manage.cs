using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fastfood
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
            Table();
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

        private void controlManage_Load(object sender, EventArgs e)
        {

        }

        public void Table()
        {
            textBox1.Text = "";
            int i = tableProduct.Rows.Count - 1;
            while (tableProduct.Rows.Count > 0)
            {
                tableProduct.Rows.RemoveAt(i);
                i--;
            }
            string data = "SELECT Id, Category, Product_Name, Price, Image, Available FROM Products";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Id = (string)reader["Id"];
                string Category = (string)reader["Category"];
                string Product_Name = (string)reader["Product_Name"];
                string Price = (string)reader["Price"];
                string Available = (string)reader["Available"];
                if (reader["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image Image = Image.FromStream(ms);
                        tableProduct.Rows.Add(Id, Category, Product_Name, Price, Image, Available);
                    }
                }
                else
                {
                    tableProduct.Rows.Add(Id, Category, Product_Name, Price, null, Available);
                }
            }
            conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            formAddProduct f = new formAddProduct();
            f.ShowDialog();
            Table();
            f.Close();
        }

        public void DeleteProduct(string Id)
        {
            string del = "DELETE FROM Products WHERE Id = @Id";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException x)
            {
                MessageBox.Show("Product not Deleted. \n" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                formEditProduct f = new formEditProduct();
                string data = "SELECT Id, Category, Product_Name, Price, Image, Available FROM Products";
                SqlConnection conn = GetConnection();
                SqlCommand cmd = new SqlCommand(data, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (tableProduct.Rows[e.RowIndex].Cells[0].Value.ToString() == reader["Id"].ToString())
                    {
                        f.tbId.Text = (string)reader["Id"];
                        f.cbCategory.Text = (string)reader["Category"];
                        f.tbName.Text = (string)reader["Product_Name"];
                        f.tbPrice.Text = (string)reader["Price"];
                        f.cbAvailable.Text = (string)reader["Available"];
                        if (reader["Image"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["Image"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                f.pbImage.Image = System.Drawing.Image.FromStream(ms);
                                f.pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        break;
                    }
                }
                conn.Close();
                f.ShowDialog();
                Table();
                f.Close();
                return;
            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteProduct(tableProduct.Rows[e.RowIndex].Cells[0].Value.ToString()!);
                }
                Table();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = tableProduct.Rows.Count - 1;
            while (tableProduct.Rows.Count > 0)
            {
                tableProduct.Rows.RemoveAt(i);
                i--;
            }
            string data = "SELECT * FROM Products WHERE Product_Name LIKE'" + textBox1.Text + "%'";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Id = (string)reader["Id"];
                string Category = (string)reader["Category"];
                string Product_Name = (string)reader["Product_Name"];
                string Price = (string)reader["Price"];
                string Available = (string)reader["Available"];
                if (reader["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image Image = Image.FromStream(ms);
                        tableProduct.Rows.Add(Id, Category, Product_Name, Price, Image, Available);
                    }
                }
                else
                {
                    tableProduct.Rows.Add(Id, Category, Product_Name, Price, null, Available);
                }
            }
            conn.Close();
        }
    }
}
