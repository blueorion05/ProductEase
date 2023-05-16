﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class formPOS : Form
    {
        public Dictionary<Product, int> Products = new Dictionary<Product, int>();
        public Product f = new Product();
        public formPOS()
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

        public DataTable GetData()
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
            f = c;
            if (Products.ContainsKey(c))
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Product_Name"].Value.ToString() == c.lblName.Text)
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
                Products.Add(c, 1);
                AddNew(c);
            }
        }

        private void AddNew(Product c)
        {
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["Product_Name"].Value = c.lblName.Text;
            dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = 1;
            dataGridView1.Rows[rowIndex].Cells["Price"].Value = c.lblPrice.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPOS_Load(object sender, EventArgs e)
        {
            DataTable data = GetData();
            foreach (DataRow row in data.Rows)
            {
                Product c = new Product();
                if (File.Exists(row["Image"].ToString()))
                {
                    c.pbProduct.BackgroundImage = System.Drawing.Image.FromFile(row["Image"].ToString()!);
                }
                c.lblName.Text = row["Product_Name"].ToString();
                c.lblPrice.Text = row["Price"].ToString();
                if (row["Available"].ToString() == "Yes")
                {
                    flowLayoutPanel1.Controls.Add(c);
                }
            }
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
                price = Convert.ToDouble(f.lblPrice.Text) * quantity;
                dataGridView1.Rows[row].Cells["Quantity"].Value = quantity;
                dataGridView1.Rows[row].Cells["Price"].Value = price;
            }
            if (e.ColumnIndex == 4)
            {
                row = dataGridView1.SelectedCells[0].RowIndex;
                quantity = Convert.ToInt32(dataGridView1.Rows[row].Cells["Quantity"].Value);
                quantity--;
                price = Convert.ToDouble(f.lblPrice.Text) * quantity;
                dataGridView1.Rows[row].Cells["Quantity"].Value = quantity;
                dataGridView1.Rows[row].Cells["Price"].Value = price;
                /*if (Convert.ToInt32(dataGridView1.Rows[row].Cells["Quantity"].Value) == 0)
                {
                    row = dataGridView1.SelectedCells[0].RowIndex;
                    Products.Remove(f);
                    dataGridView1.Rows.RemoveAt(row);
                }*/
            }
            if (e.ColumnIndex == 5)
            {
                row = dataGridView1.SelectedCells[0].RowIndex;
                //Products.Remove(f);
                dataGridView1.Rows.RemoveAt(row);
            }
        }
    }
}
