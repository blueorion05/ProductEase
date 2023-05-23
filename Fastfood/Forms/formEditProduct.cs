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
        public formEditProduct()
        {
            InitializeComponent();
        }

        public void EditProduct()
        {
            string editProduct = "UPDATE Products SET Category = @Category, Product_Name = @Product_Name, Price = @Price, Available = @Available";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            byte[]? imageData = CompressImage(tbImage.Text, 800, 600, 80);

            if (imageData != null)
            {
                editProduct += ", Image = @Image";
            }
            if (imageData == null && pbImage.Image == null && tbImage.Text == "")
            {
                editProduct += ", Image = NULL";
            }
            editProduct += " WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(editProduct, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = tbId.Text;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.VarChar).Value = cbCategory.Text;
                cmd.Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = tbName.Text;
                cmd.Parameters.AddWithValue("@Price", SqlDbType.VarChar).Value = tbPrice.Text;
                cmd.Parameters.AddWithValue("@Available", SqlDbType.VarChar).Value = cbAvailable.Text;
                if (imageData != null)
                {
                    SqlParameter imageParam = new SqlParameter("@Image", SqlDbType.VarBinary);
                    imageParam.Value = imageData;
                    cmd.Parameters.AddWithValue("@Image", SqlDbType.VarBinary).Value = imageParam.Value;
                }
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
            tbPrice.Text = tbPrice.Text.Replace(" ", "");
            if (cbCategory.Text == "" || tbName.Text == "" || tbPrice.Text == "" || cbAvailable.Text == "")
            {
                MessageBox.Show("Make sure to fill all with *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float valid;
                if (float.TryParse(tbPrice.Text, out valid))
                {
                    if (Convert.ToDecimal(tbPrice.Text) >= 0)
                    {
                        EditProduct();
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

        public byte[]? CompressImage(string imagePath, int maxWidth, int maxHeight, long quality)
        {
            if (tbImage.Text != "")
            {
                using (var originalImage = System.Drawing.Image.FromFile(imagePath))
                {
                    int newWidth, newHeight;
                    if (originalImage.Width > originalImage.Height)
                    {
                        newWidth = maxWidth;
                        newHeight = (int)(originalImage.Height * (float)newWidth / originalImage.Width);
                    }
                    else
                    {
                        newHeight = maxHeight;
                        newWidth = (int)(originalImage.Width * (float)newHeight / originalImage.Height);
                    }
                    using (var resizedImage = new Bitmap(newWidth, newHeight))
                    {
                        using (var graphics = Graphics.FromImage(resizedImage))
                        {
                            graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                        }
                        using (var memoryStream = new MemoryStream())
                        {
                            var encoderParam = new EncoderParameters(1);
                            encoderParam.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                            resizedImage.Save(memoryStream, GetEncoderInfo(ImageFormat.Jpeg), encoderParam);

                            return memoryStream.ToArray();
                        }
                    }
                }
            }
            byte[]? nullArray = null;
            return nullArray;
        }

        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null!;
        }

        private void formEditProduct_Click(object sender, EventArgs e)
        {
            lblId.Focus();
        }
    }
}
