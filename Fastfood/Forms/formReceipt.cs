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
using System.Xml.Linq;
using System.Security.Cryptography.Pkcs;

namespace Fastfood
{
    public partial class formReceipt : Form
    {
        Receipt receipt = new Receipt();
        formPOS formPOS = new formPOS();
        string products = "";
        public formReceipt(Receipt r, formPOS f)
        {
            InitializeComponent();
            panel1.Controls.Add(r);
            receipt = r;
            formPOS = f;
        }

        private void formReceipt_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < receipt.dataGridView1.Rows.Count; i++)
            {
                products += (receipt.dataGridView1.Rows[i].Cells["Quantity"].Value).ToString();
                products += "x ";
                products += (receipt.dataGridView1.Rows[i].Cells["Product_Name"].Value).ToString();
                products += "(";
                products += (receipt.dataGridView1.Rows[i].Cells["Amount"].Value).ToString();
                products += ")\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(receipt.Width, receipt.Height);
            receipt.DrawToBitmap(bmp, new Rectangle(0, 0, receipt.Width, receipt.Height));
            byte[] imageData;
            using (MemoryStream stream = new MemoryStream())
            {
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = stream.ToArray();
            }

            string addProduct = "INSERT INTO Transactions VALUES (@DateTime, @Id, @Products, @AmountDue, @Discount, @CashTendered, @Change, @Receipt)";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(addProduct, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
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
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
                this.Close();
                formPOS.ClearPOS();
            }
        }
    }
}
