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
            tbId.Text = IdCheck();
        }

        private string IdCheck()
        {
        Rand:
            Random rand = new Random();
            int Id = rand.Next(10000, 99999);
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                conn.Close();
                goto Rand;
            }
            else
            {
                conn.Close();
                return Id.ToString();
            }
        }

        private void controlManage_DataChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFood();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog image = new OpenFileDialog())
            {
                image.InitialDirectory = "C:\\";
                image.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                image.RestoreDirectory = true;

                if (image.ShowDialog() == DialogResult.OK)
                {
                    tbImage.Text = image.FileName;
                    pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(tbImage.Text);
                }
            }
        }
    }
}
