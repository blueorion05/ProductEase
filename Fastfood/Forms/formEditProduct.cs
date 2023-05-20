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
    public partial class formEditProduct : Form
    {
        public formEditProduct()
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

        public void EditProduct()
        {
            string addProduct = "UPDATE Products SET Category = @Category, Product_Name = @Product_Name, Price = @Price, Image = @Image, Available = @Available WHERE Id = @Id";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(addProduct, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = tbId.Text;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.VarChar).Value = cbCategory.Text;
                cmd.Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = tbName.Text;
                cmd.Parameters.AddWithValue("@Price", SqlDbType.VarChar).Value = tbPrice.Text;
                cmd.Parameters.AddWithValue("@Image", SqlDbType.VarChar).Value = tbImage.Text;
                cmd.Parameters.AddWithValue("@Available", SqlDbType.VarChar).Value = cbAvailable.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException x)
            {
                MessageBox.Show("Product not Updated. \n" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbCategory.Text == "" || tbName.Text == "" || tbPrice.Text == "" || cbAvailable.Text == "")
            {
                MessageBox.Show("Make sure to fill all with *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float valid;
                if (float.TryParse(tbPrice.Text, out valid))
                {
                    EditProduct();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Input a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbImage.Text = "";
            pbImage.Image = null;
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
                    tbImage.Text = image.FileName.ToString();
                    pbImage.Image = System.Drawing.Image.FromFile(tbImage.Text);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void formEditProduct_Load(object sender, EventArgs e)
        {
            if (File.Exists(tbImage.Text))
            {
                pbImage.Image = System.Drawing.Image.FromFile(tbImage.Text);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
