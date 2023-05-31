using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fastfood
{
    internal class Information
    {
        public void CheckLogin(formLogin login)
        {
            String username, password;
            username = login.tbUser.Text;
            password = login.tbPass.Text;
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            try
            {
                String match = "SELECT * FROM Login";
                SqlCommand cmd = new SqlCommand(match, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string user = reader["Username"].ToString()!;
                string pass = reader["Password"].ToString()!;

                if (user == username && pass == password)
                {
                    formMain f = new formMain();
                    f.Show();
                    login.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username/password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login.tbUser.Text = "";
                    login.tbPass.Text = "";
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

        public void GetSettingsInfo(Settings s)
        {
            string data = "SELECT Name, Address, ContactNum, Email, StoreHours, About FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            s.lblName.Text = reader["Name"].ToString();
            s.lblAddress.Text = reader["Address"].ToString();
            s.lblContactNum.Text = reader["ContactNum"].ToString();
            s.lblEmail.Text = reader["Email"].ToString();
            s.lblStoreHours.Text = reader["StoreHours"].ToString();
            s.label1.Text = reader["About"].ToString();
            conn.Close();

            data = "SELECT username FROM Login";
            conn = sql.GetConnection();
            cmd = new SqlCommand(data, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            s.lblUser.Text = reader["username"].ToString();
            conn.Close();
        }

        public string GetName()
        {
            string data = "SELECT Name FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader["Name"].ToString()!;
            conn.Close();
            return name;
        }

        public string GetAbout()
        {
            string data = "SELECT About FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string about = reader["About"].ToString()!;
            conn.Close();
            return about;
        }

        public string GetPassword()
        {
            string data = "SELECT password FROM Login";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string password = reader["password"].ToString()!;
            conn.Close();
            return password;
        }

        public int GetTransacNum()
        {
            string data = "SELECT TransacNum FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int num = Convert.ToInt32(reader["TransacNum"]);
            conn.Close();
            return num;
        }

        public DataTable GetProductData()
        {
            string data = "SELECT * FROM Products";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public Image GetRecentProductImage()
        {
            string data = "SELECT Image FROM Products ORDER BY Timestamp DESC";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Image Image = null!;
            if (reader.HasRows)
            {
                reader.Read();
                if (reader["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image = Image.FromStream(ms);
                    }
                }
            }
            conn.Close();
            return Image;
        }

        public Image GetRecentTransaction()
        {
            string data = "SELECT Receipt FROM Transactions ORDER BY Id DESC";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Image Image = null!;
            if (reader.HasRows)
            {
                reader.Read();
                if (reader["Receipt"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["Receipt"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image = Image.FromStream(ms);
                    }
                }
            }
            conn.Close();
            return Image;
        }

        public string GetTotalTransaction(DateTime start, DateTime end)
        {
            string data = "SELECT AmountDue, Date FROM Transactions";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            double total = 0;
            while (reader.Read())
            {
                if (reader["AmountDue"] != DBNull.Value)
                {
                    DateTime DDay = Convert.ToDateTime(reader["Date"]);
                    if (DDay >= start && DDay <= end)
                    {
                        total += Convert.ToDouble(reader["AmountDue"]);
                    }
                }
            }
            conn.Close();
            return total.ToString("0.00");
        }

        public void UpdateName(formInformation f)
        {
            string data = "UPDATE Information SET Name = @Name WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateAddress(formInformation f)
        {
            string data = "UPDATE Information SET Address = @Address WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateContactNum(formInformation f)
        {
            string data = "UPDATE Information SET Landline = @Landline WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            int valid;
            if (int.TryParse(f.textBox1.Text, out valid))
            {
                cmd.Parameters.AddWithValue("@ContactNum", SqlDbType.Int).Value = Convert.ToInt32(f.textBox1.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.Parameters.AddWithValue("@Landline", SqlDbType.Int).Value = DBNull.Value;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void UpdateEmail(formInformation f)
        {
            string data = "UPDATE Information SET Email = @Email WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateStoreHours(formInformation f)
        {
            string data = "UPDATE Information SET StoreHours = @StoreHours WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@StoreHours", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateAbout(formInformation f)
        {
            string data = "UPDATE Information SET About = @About WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@About", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateUsername(formInformation f)
        {
            string data = "UPDATE Login SET username = @username WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdatePassword(formInformation f)
        {
            string data = "UPDATE Login SET password = @password WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = f.textBox3.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateTransacNum(Receipt r)
        {
            string data = "UPDATE Information SET TransacNum = @TransacNum WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@TransacNum", SqlDbType.VarChar).Value = r.lblId.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ManageTable(Manage manage)
        {
            manage.textBox1.Text = "";
            int i = manage.tableProduct.Rows.Count - 1;
            while (manage.tableProduct.Rows.Count > 0)
            {
                manage.tableProduct.Rows.RemoveAt(i);
                i--;
            }
            string data = "SELECT Id, Category, Product_Name, Price, Image, Available FROM Products";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
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
                        manage.tableProduct.Rows.Add(Id, Category, Product_Name, Price, Image, Available);
                    }
                }
                else
                {
                    Image blank = new Bitmap(1, 1);
                    using (Graphics g = Graphics.FromImage(blank))
                    {
                        g.Clear(Color.White);
                    }
                    manage.tableProduct.Rows.Add(Id, Category, Product_Name, Price, blank, Available);
                }
            }
            conn.Close();
            manage.tableProduct.Sort(manage.tableProduct.Columns["tableProductC5"], ListSortDirection.Descending);
        }

        public void TransactionTable(Transactions transactions)
        {
            int i = transactions.dataGridView1.Rows.Count - 1;
            while (transactions.dataGridView1.Rows.Count > 0)
            {
                transactions.dataGridView1.Rows.RemoveAt(i);
                i--;
            }
            string data = "SELECT Date, Id, Products, AmountDue, Discount, CashTendered, Change FROM Transactions";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Date = (string)reader["Date"];
                string Id = reader["Id"].ToString()!;
                string Products = (string)reader["Products"];
                string AmountDue = (string)reader["AmountDue"];
                string Discount = (string)reader["Discount"];
                string CashTendered = (string)reader["CashTendered"];
                string Change = (string)reader["Change"];
                transactions.dataGridView1.Rows.Add(Date, Id, Products, AmountDue, Discount, CashTendered, Change);
            }
            conn.Close();
        }

        public void AddProduct(formAddProduct add)
        {
            string addProduct = "INSERT INTO Products (Id, Category, Product_Name, Price, Image, Available, Timestamp) VALUES (@Id, @Category, @Product_Name, @Price, @Image, @Available, DEFAULT)";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(addProduct, conn);
            cmd.CommandType = CommandType.Text;
            byte[]? imageData = CompressImage(add.tbImage.Text, 800, 600, 80, add);

            try
            {
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = add.lblIdNum.Text;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = add.cbCategory.Text;
                cmd.Parameters.Add("@Product_Name", SqlDbType.VarChar).Value = add.tbName.Text;
                cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = add.tbPrice.Text;
                cmd.Parameters.Add("@Available", SqlDbType.VarChar).Value = add.cbAvailable.Text;
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

        public void EditProduct(formEditProduct edit)
        {
            string editProduct = "UPDATE Products SET Category = @Category, Product_Name = @Product_Name, Price = @Price, Available = @Available";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            byte[]? imageData = CompressEditImage(edit.tbImage.Text, 800, 600, 80, edit);

            if (imageData != null)
            {
                editProduct += ", Image = @Image";
            }
            if (imageData == null && edit.pbImage.Image == null && edit.tbImage.Text == "")
            {
                editProduct += ", Image = NULL";
            }
            editProduct += " WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(editProduct, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = edit.lblIdNum.Text;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.VarChar).Value = edit.cbCategory.Text;
                cmd.Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = edit.tbName.Text;
                cmd.Parameters.AddWithValue("@Price", SqlDbType.VarChar).Value = edit.tbPrice.Text;
                cmd.Parameters.AddWithValue("@Available", SqlDbType.VarChar).Value = edit.cbAvailable.Text;
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

        public void DeleteProduct(string Id)
        {
            string del = "DELETE FROM Products WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
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

        public void AddTransaction(Receipt receipt, formReceipt form, string products, byte[] imageData)
        {
            string addProduct = "INSERT INTO Transactions VALUES (@DateTime, @Id, @Products, @AmountDue, @Discount, @CashTendered, @Change, @Receipt)";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(addProduct, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DateTime", SqlDbType.VarChar).Value = receipt.lblDate.Text;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(receipt.lblId.Text);
            cmd.Parameters.Add("@Products", SqlDbType.VarChar).Value = products;
            cmd.Parameters.Add("@AmountDue", SqlDbType.VarChar).Value = receipt.lblAmountDue.Text;
            cmd.Parameters.Add("@Discount", SqlDbType.VarChar).Value = receipt.lblDiscount.Text;
            cmd.Parameters.Add("@CashTendered", SqlDbType.VarChar).Value = receipt.lblCash.Text;
            cmd.Parameters.Add("@Change", SqlDbType.VarChar).Value = receipt.lblChange.Text;
            cmd.Parameters.Add("@Receipt", SqlDbType.VarBinary).Value = imageData;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction Success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        public void DeleteTransaction(Transactions transactions, DataGridViewCellEventArgs e)
        {
            string del = "DELETE FROM Transactions WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(transactions.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException x)
            {
                MessageBox.Show("Transaction not Deleted. \n" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public ImageList AvailableProducts(Home home)
        {
            ImageList? list = new ImageList();
            string data = "SELECT Image, Available FROM Products";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Available"].ToString() == "Yes" && reader["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        Image newImage = image.GetThumbnailImage(150, 150, null, IntPtr.Zero);
                        list.Images.Add(newImage);
                    }
                }
            }
            if (list.Images.Count == 0)
            {
                list = null;
            }
            conn.Close();
            return list!;
        }

        public void AccessEditProduct(Manage manage, DataGridViewCellEventArgs e)
        {
            formEditProduct f = new formEditProduct();
            string data = "SELECT Id, Category, Product_Name, Price, Image, Available FROM Products";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manage.tableProduct.Rows[e.RowIndex].Cells[0].Value.ToString() == reader["Id"].ToString())
                {
                    f.lblIdNum.Text = (string)reader["Id"];
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
                    f.tbName.Select(0, 0);
                    break;
                }
            }
            conn.Close();
            f.ShowDialog();
            ManageTable(manage);
            f.Close();
        }

        public void ManageSearch(Manage manage)
        {
            int i = manage.tableProduct.Rows.Count - 1;
            while (manage.tableProduct.Rows.Count > 0)
            {
                manage.tableProduct.Rows.RemoveAt(i);
                i--;
            }
            string data = "SELECT * FROM Products WHERE Product_Name LIKE'" +  manage.textBox1.Text + "%'";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
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
                        manage.tableProduct.Rows.Add(Id, Category, Product_Name, Price, Image, Available);
                    }
                }
                else
                {
                    manage.tableProduct.Rows.Add(Id, Category, Product_Name, Price, null, Available);
                }
            }
            conn.Close();
        }

        public void POSSearch(formPOS pos)
        {
            string data = "SELECT * FROM Products WHERE Product_Name LIKE'" + pos.textBox1.Text + "%'";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                Product c = new Product();
                if (row["Available"].ToString() != "Yes")
                {
                    continue;
                }
                if (row["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["Image"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image Image = Image.FromStream(ms);
                        c.pbProduct.Image = Image;
                    }
                }
                c.lblName.Text = row["Product_Name"].ToString();
                c.lblPrice.Text = row["Price"].ToString();
                c.lblPrice.Text = row["Price"].ToString();
                c.lblId.Text = row["Id"].ToString();
                pos.flowLayoutPanel1.Controls.Add(c);
            }
            conn.Close();
        }

        public void ViewReceipt(Transactions transactions, DataGridViewCellEventArgs e)
        {
            formReceipt f = new formReceipt(null, null);
            f.btnCancel.Text = "Close";
            f.btnConfirm.Text = "";
            f.btnConfirm.Enabled = false;
            string data = "SELECT Id, Receipt FROM Transactions";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (transactions.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString() == reader["Id"].ToString())
                {
                    byte[] imageData = (byte[])reader["Receipt"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image Image = Image.FromStream(ms);
                        PictureBox pb = new PictureBox();
                        pb.Image = Image;
                        pb.SizeMode = PictureBoxSizeMode.AutoSize;
                        f.panel1.Controls.Add(pb);
                        f.Show();
                    }
                }
            }
            conn.Close();
        }

        public byte[]? CompressImage(string imagePath, int maxWidth, int maxHeight, long quality, formAddProduct add)
        {
            if (add.tbImage.Text != "")
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

        public byte[]? CompressEditImage(string imagePath, int maxWidth, int maxHeight, long quality, formEditProduct edit)
        {
            if (edit.tbImage.Text != "")
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
    }
}
