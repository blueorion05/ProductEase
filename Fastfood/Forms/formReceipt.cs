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
using System.Drawing.Printing;

namespace Fastfood
{
    public partial class formReceipt : Form
    {
        Receipt receipt = new Receipt();
        formPOS formPOS = new formPOS();
        Bitmap receiptImage = null!;
        string products = "";
        public formReceipt(Receipt? r, formPOS? f)
        {
            InitializeComponent();
            panel1.Controls.Add(r);
            receipt = r!;
            formPOS = f!;
        }

        private void formReceipt_Load(object sender, EventArgs e)
        {
            if (receipt != null)
            {
                for (int i = 0; i < receipt.dataGridView1.Rows.Count; i++)
                {
                    products += (receipt.dataGridView1.Rows[i].Cells["Quantity"].Value).ToString();
                    products += "x ";
                    products += (receipt.dataGridView1.Rows[i].Cells["Product_Name"].Value).ToString();
                    products += "(";
                    products += (receipt.dataGridView1.Rows[i].Cells["Amount"].Value).ToString()!.Replace("₱ ", "");
                    products += ")\n";
                }
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
            receiptImage = bmp;
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
                Information info = new Information();
                info.UpdateTransacNum(receipt);
                this.Close();
                formPOS.ClearPOS();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK || result ==  DialogResult.Yes)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float aspectRatio = (float)receiptImage.Width / (float)receiptImage.Height;
            int maxImageWidth = e.MarginBounds.Width;
            int maxImageHeight = (int)(e.MarginBounds.Width / aspectRatio);
            if (maxImageHeight > e.MarginBounds.Height)
            {
                maxImageHeight = e.MarginBounds.Height;
                maxImageWidth = (int)(e.MarginBounds.Height * aspectRatio);
            }
            int positionX = e.MarginBounds.Left + (e.MarginBounds.Width - maxImageWidth) / 2;
            int positionY = e.MarginBounds.Top + (e.MarginBounds.Height - maxImageHeight) / 2;
            e.Graphics?.DrawImage(receiptImage, positionX, positionY, maxImageWidth, maxImageHeight);
        }
    }
}
