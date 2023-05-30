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
    public partial class formEditProduct : Form
    {
        Information info = new Information();
        public formEditProduct()
        {
            InitializeComponent();
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
                        info.EditProduct(this);
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
                    tbImage.Text = image.FileName;
                    pbImage.Image = System.Drawing.Image.FromFile(image.FileName);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void formEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void formEditProduct_Click(object sender, EventArgs e)
        {
            lblId.Focus();
        }
    }
}
