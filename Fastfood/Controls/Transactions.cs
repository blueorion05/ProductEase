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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fastfood
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            int i = dataGridView1.Rows.Count - 1;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(i);
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
                dataGridView1.Rows.Add(Date, Id, Products, AmountDue, Discount, CashTendered, Change, null);
            }
            conn.Close();
        }

        private void controlRecords_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
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
                    if (dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString() == reader["Id"].ToString())
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
                return;
            }
        }

        private void dataGridView1_RowHeightInfoNeeded(object sender, DataGridViewRowHeightInfoNeededEventArgs e)
        {

        }
    }
}
