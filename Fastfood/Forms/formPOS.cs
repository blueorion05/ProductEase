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

        private SqlConnection GetConnection()
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

        private DataTable GetData()
        {
            string data = "SELECT * FROM Products";
            SqlConnection conn = GetConnection();
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
                        dataGridView1.Rows[i].Cells["Price"].Value = price;
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
            textBox2.Text = "";
            label5.Text = "";
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
                decimal totalAmount = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    decimal price = decimal.Parse(dataGridView1.Rows[i].Cells["Price"].Value.ToString()!);
                    totalAmount += price;
                }
                UpdateAmountDue(totalAmount);
            }
            catch
            {
                MessageBox.Show("Invalid discount.");
                textBox3.Text = "0";
                AmountDue();
            }
        }

        private void UpdateAmountDue(decimal totalAmount)
        {
            decimal discount, amountDue;

            textBox3.Text = textBox3.Text.Replace(" ", "");

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox3.Text.EndsWith("%"))
            {
                discount = totalAmount * Convert.ToDecimal(textBox3.Text.Replace("%", "")) / 100;
            }
            else
            {
                discount = decimal.Parse(textBox3.Text);
            }
            amountDue = totalAmount - discount;
            if (amountDue >= 0)
            {
                lbl7amount.Text = amountDue.ToString();
            }
            else
            {
                lbl7amount.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPOS_Load(object sender, EventArgs e)
        {

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
                dataGridView1.Rows[row].Cells["Price"].Value = price;
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
                dataGridView1.Rows[row].Cells["Price"].Value = price;
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
                Products.Clear();
                int i = dataGridView1.Rows.Count - 1;
                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }
                AmountDue();
                textBox3.Text = "0";
                ClearCashTendered();
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
                Product c = new Product();
                string data = "SELECT * FROM Products WHERE Product_Name LIKE'" + textBox1.Text + "%'";
                SqlConnection conn = GetConnection();
                SqlCommand cmd = new SqlCommand(data, conn);
                SqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
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
                try
                {
                    textBox2.Text = textBox2.Text.Replace(" ", "");
                    if (Convert.ToDouble(textBox2.Text) >= Convert.ToDouble(lbl7amount.Text))
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change()
        {
            label5.Text = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(lbl7amount.Text)).ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (textBox3.Text == "")
                    {
                        textBox3.Text = "0";
                    }
                    if (Convert.ToDecimal(textBox3.Text) >= 0)
                    {
                        AmountDue();
                        if (label5.Text != "" && textBox2.Text != "")
                        {
                            Change();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid discount.");
                        textBox3.Text = "0";
                        AmountDue();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid discount.");
                    textBox3.Text = "0";
                    AmountDue();
                }
            }
        }

        private void btn1pay_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt();
            r.lblAmountDue.Text = lbl7amount.Text;
            r.lblDiscount.Text = textBox3.Text;
            r.lblCash.Text = textBox2.Text;
            r.lblChange.Text = label5.Text;
            formReceipt f = new formReceipt(r);
            f.Show();
        }
    }
}
