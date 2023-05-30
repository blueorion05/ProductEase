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
using System.Drawing.Imaging;

namespace Fastfood
{
    public partial class formAddProduct : Form
    {
        Information info = new Information();
        public formAddProduct()
        {
            InitializeComponent();
        }

        private void formAddProduct_Load(object sender, EventArgs e)
        {
            lblIdNum.Text = IdCheck();
        }

        private string IdCheck()
        {
        Rand:
            Random rand = new Random();
            int Id = rand.Next(10000, 99999);
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
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
            tbPrice.Text = tbPrice.Text.Replace(" ", "");
            if (cbCategory.Text == "" || tbName.Text == "" || tbPrice.Text == "" || cbAvailable.Text == "")
            {
                MessageBox.Show("Make sure to fill all with *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valid;
                if (double.TryParse(tbPrice.Text, out valid))
                {
                    if (Convert.ToDouble(tbPrice.Text) >= 0)
                    {
                        tbPrice.Text = Convert.ToDouble(tbPrice.Text).ToString("0.00");
                        info.AddProduct(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Input a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    pbImage.Image = System.Drawing.Image.FromFile(tbImage.Text);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbImage.Text = "";
            pbImage.Image = null;
        }

        private void tbImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAddProduct_Click(object sender, EventArgs e)
        {
            lblId.Focus();
        }
    }
}
