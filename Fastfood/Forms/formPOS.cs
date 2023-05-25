using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class formPOS : Form
    {
        Dictionary<string, int> Products = new Dictionary<string, int>();
        public formPOS()
        {
            InitializeComponent();
            ProductControl("ALL");
        }

        private DataTable GetData()
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

        public void controlProduct_Click(Product c)
        {
            if (Products.ContainsKey(c.lblId.Text))
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Id"].Value.ToString() == c.lblId.Text)
                    {
                        int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                        quantity++;
                        double price = Convert.ToDouble(c.lblPrice.Text) * quantity;
                        dataGridView1.Rows[i].Cells["Quantity"].Value = quantity;
                        dataGridView1.Rows[i].Cells["Price"].Value = price.ToString("0.00");
                    }
                }
            }
            else
            {
                Products.Add(c.lblId.Text, 1);
                AddNew(c);
            }
            AmountDue();
            ClearCashTendered();
        }

        private void ClearCashTendered()
        {
            tbCash.Text = "";
            lblChange.Text = "";
        }

        private void AddNew(Product c)
        {
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["Id"].Value = c.lblId.Text;
            dataGridView1.Rows[rowIndex].Cells["Product_Name"].Value = c.lblName.Text;
            dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = 1;
            dataGridView1.Rows[rowIndex].Cells["Price"].Value = c.lblPrice.Text;
            dataGridView1.Rows[rowIndex].Cells["OgPrice"].Value = c.lblPrice.Text;
        }

        private void AmountDue()
        {
            try
            {
                double totalAmount = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    double price = double.Parse(dataGridView1.Rows[i].Cells["Price"].Value.ToString()!);
                    totalAmount += price;
                }
                UpdateAmountDue(totalAmount);
            }
            catch
            {
                MessageBox.Show("Invalid discount.");
                tbDiscount.Text = "0";
                AmountDue();
            }
        }

        private void UpdateAmountDue(double totalAmount)
        {
            double discount, amountDue;

            if (tbDiscount.Text.EndsWith("%"))
            {
                discount = totalAmount * Convert.ToDouble(tbDiscount.Text.Replace("%", "")) / 100;
            }
            else
            {
                discount = double.Parse(tbDiscount.Text);
            }
            amountDue = totalAmount - discount;
            if (amountDue >= 0)
            {
                lbl7amount.Text = amountDue.ToString("0.00");
            }
            else
            {
                lbl7amount.Text = "0.00";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPOS_Load(object sender, EventArgs e)
        {
            ClearPOS();
        }

        public void ClearPOS()
        {
            string transId = "SELECT TOP 1 [Id] FROM [Transactions] ORDER BY [Id] DESC";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(transId, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblTransactionId.Text = (Convert.ToInt32(reader["Id"]) + 1).ToString();
            }
            else
            {
                lblTransactionId.Text = "1";
            }
            conn.Close();

            Products.Clear();
            int i = dataGridView1.Rows.Count - 1;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(i);
                i--;
            }
            AmountDue();
            tbDiscount.Text = "0";
            ClearCashTendered();
        }

        private void ProductControl(string category)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable data = GetData();
            foreach (DataRow row in data.Rows)
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
                if (category == "FOOD")
                {
                    if (row["Category"].ToString() != "Food")
                    {
                        continue;
                    }
                    Product(c, row);
                }
                else if (category == "DRINKS")
                {
                    if (row["Category"].ToString() != "Drinks")
                    {
                        continue;
                    }
                    Product(c, row);
                }
                else if (category == "DESSERT")
                {
                    if (row["Category"].ToString() != "Dessert")
                    {
                        continue;
                    }
                    Product(c, row);
                }
                else
                {
                    Product(c, row);
                }
            }
        }

        private void Product(Product c, DataRow row)
        {
            c.lblName.Text = row["Product_Name"].ToString();
            c.lblPrice.Text = row["Price"].ToString();
            c.lblPrice.Text = row["Price"].ToString();
            c.lblId.Text = row["Id"].ToString();
            flowLayoutPanel1.Controls.Add(c);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row, quantity;
            double price;
            if (e.ColumnIndex == 3)
            {
                row = dataGridView1.SelectedCells[0].RowIndex;
                quantity = Convert.ToInt32(dataGridView1.Rows[row].Cells["Quantity"].Value);
                quantity++;
                price = Convert.ToDouble(dataGridView1.Rows[row].Cells["OgPrice"].Value) * quantity;
                dataGridView1.Rows[row].Cells["Quantity"].Value = quantity;
                dataGridView1.Rows[row].Cells["Price"].Value = price.ToString("0.00");
                AmountDue();
                ClearCashTendered();
            }
            if (e.ColumnIndex == 4)
            {
                row = dataGridView1.SelectedCells[0].RowIndex;
                quantity = Convert.ToInt32(dataGridView1.Rows[row].Cells["Quantity"].Value);
                quantity--;
                price = Convert.ToDouble(dataGridView1.Rows[row].Cells["OgPrice"].Value) * quantity;
                dataGridView1.Rows[row].Cells["Quantity"].Value = quantity;
                dataGridView1.Rows[row].Cells["Price"].Value = price.ToString("0.00");
                if (Convert.ToInt32(dataGridView1.Rows[row].Cells["Quantity"].Value) == 0)
                {
                    row = dataGridView1.SelectedCells[0].RowIndex;
                    Products.Remove(dataGridView1.Rows[row].Cells["Id"].Value.ToString()!);
                    dataGridView1.Rows.RemoveAt(row);
                }
                AmountDue();
                ClearCashTendered();
            }
            if (e.ColumnIndex == 5)
            {
                row = dataGridView1.SelectedCells[0].RowIndex;
                Products.Remove(dataGridView1.Rows[row].Cells["Id"].Value.ToString()!);
                dataGridView1.Rows.RemoveAt(row);
                AmountDue();
                ClearCashTendered();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this transaction?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ClearPOS();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelClear();
            ProductControl("ALL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelClear();
            ProductControl("FOOD");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelClear();
            ProductControl("DRINKS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelClear();
            ProductControl("DESSERT");
        }

        private void FlowLayoutPanelClear()
        {
            textBox1.Text = "";
            flowLayoutPanel1.Controls.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (textBox1.Text != "")
            {
                string data = "SELECT * FROM Products WHERE Product_Name LIKE'" + textBox1.Text + "%'";
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
                    flowLayoutPanel1.Controls.Add(c);
                }
                conn.Close();
            }
            else
            {
                ProductControl("ALL");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerifyCashTendered();
            }
        }

        private void VerifyCashTendered()
        {
            try
            {
                tbCash.Text = tbCash.Text.Replace(" ", "");
                if (Convert.ToDouble(tbCash.Text) >= Convert.ToDouble(lbl7amount.Text))
                {
                    Change();
                }
                else
                {
                    MessageBox.Show("Cash received is less than the amount due.");
                    ClearCashTendered();
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid cash amount.");
                ClearCashTendered();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change()
        {
            lblChange.Text = Convert.ToDouble((Convert.ToDouble(tbCash.Text) - Convert.ToDouble(lbl7amount.Text))).ToString("0.00");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerifyDiscount();
            }
        }

        private void VerifyDiscount()
        {
            try
            {
                tbDiscount.Text = tbDiscount.Text.Replace(" ", "");

                if (tbDiscount.Text == "")
                {
                    tbDiscount.Text = "0";
                }
                if (tbDiscount.Text.EndsWith("%"))
                {
                    if (Convert.ToDouble(tbDiscount.Text.Replace("%", "")) >= 0)
                    {
                        AmountDue();
                        if (lblChange.Text != "" && tbCash.Text != "")
                        {
                            Change();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid discount.");
                        tbDiscount.Text = "0";
                        AmountDue();
                    }
                }
                else if (Convert.ToDouble(tbDiscount.Text) >= 0)
                {
                    AmountDue();
                    if (lblChange.Text != "" && tbCash.Text != "")
                    {
                        Change();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid discount.");
                    tbDiscount.Text = "0";
                    AmountDue();
                }
            }
            catch
            {
                MessageBox.Show("Invalid discount.");
                tbDiscount.Text = "0";
                AmountDue();
            }
        }

        private void btn1pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCash.Text != "")
                {
                    Receipt r = new Receipt();
                    r.lblDate.Text = lblDateTime.Text;
                    r.lblId.Text = lblTransactionId.Text;
                    r.lblAmountDue.Text = Convert.ToDouble(lbl7amount.Text).ToString("0.00");
                    if (tbDiscount.Text.ToString().Contains("%"))
                    {
                        r.label3.Text = "  :Discount";
                        r.lblDiscount.Text = tbDiscount.Text;
                    }
                    else
                    {
                        r.lblDiscount.Text = Convert.ToDouble(tbDiscount.Text).ToString("0.00");
                    }
                    r.lblCash.Text = Convert.ToDouble(tbCash.Text).ToString("0.00");
                    r.lblChange.Text = Convert.ToDouble(lblChange.Text).ToString("0.00");
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        r.dataGridView1.Rows.Add();
                        r.dataGridView1.Rows[i].Cells["Empty"].Value = "";
                        r.dataGridView1.Rows[i].Cells["Product_Name"].Value = dataGridView1.Rows[i].Cells["Product_Name"].Value;
                        r.dataGridView1.Rows[i].Cells["Quantity"].Value = dataGridView1.Rows[i].Cells["Quantity"].Value;
                        r.dataGridView1.Rows[i].Cells["Price"].Value = "₱ " + dataGridView1.Rows[i].Cells["OgPrice"].Value;
                        r.dataGridView1.Rows[i].Cells["Amount"].Value = "₱ " + dataGridView1.Rows[i].Cells["Price"].Value;
                        r.dataGridView1.Height += r.dataGridView1.Rows[i].Height;
                        r.Height += r.dataGridView1.Rows[i].Height;
                    }
                    r.dataGridView1.Rows[0].Cells[0].Selected = false;
                    formReceipt f = new formReceipt(r, this);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Cash Tendered is Empty.");
                }
            }
            catch
            {
                MessageBox.Show("Transaction is Invalid.");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            VerifyCashTendered();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            VerifyDiscount();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
