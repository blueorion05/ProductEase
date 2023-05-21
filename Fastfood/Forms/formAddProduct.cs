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
            byte[]? imageData = CompressImage(tbImage.Text, 800, 600, 80);

            try
            {
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = tbId.Text;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = cbCategory.Text;
                cmd.Parameters.Add("@Product_Name", SqlDbType.VarChar).Value = tbName.Text;
                cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = tbPrice.Text;
                cmd.Parameters.Add("@Available", SqlDbType.VarChar).Value = cbAvailable.Text;
                if (imageData != null)
                {
                    SqlParameter imageParam = new SqlParameter("@Image", SqlDbType.VarBinary);
                    imageParam.Value = imageData;
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = imageParam.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException x)
            {
                MessageBox.Show("Product not Added. \n" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cbCategory.Text == "" || tbName.Text == "" || tbPrice.Text == "" || cbAvailable.Text == "")
            {
                MessageBox.Show("Make sure to fill all with *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float valid;
                if (float.TryParse(tbPrice.Text, out valid))
                {
                    AddFood();
                    this.Hide();
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

        private void tbImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
