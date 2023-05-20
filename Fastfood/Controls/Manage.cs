﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fastfood
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
            Table();
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

        private void controlManage_Load(object sender, EventArgs e)
        {

        }

        public void Table()
        {
            string data = "SELECT * FROM Products";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]")!);
            foreach (DataRow row in dt.Rows)
            {
                if (File.Exists(row["Image"].ToString()))
                {
                    row["Picture"] = File.ReadAllBytes(row["Image"].ToString()!);
                }
            }
            tableProduct.DataSource = dt;
            conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            formAddProduct f = new formAddProduct();
            f.ShowDialog();
            Table();
            f.Close();
        }

        public void DeleteProduct(string Id)
        {
            string del = "DELETE FROM Products WHERE Id = @Id";
            SqlConnection conn = GetConnection();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formEditProduct f = new formEditProduct();
                f.tbId.Text = tableProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.cbCategory.Text = tableProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.tbName.Text = tableProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.tbPrice.Text = tableProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.tbImage.Text = tableProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.cbAvailable.Text = tableProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.ShowDialog();
                Table();
                f.Close();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteProduct(tableProduct.Rows[e.RowIndex].Cells[3].Value.ToString()!);
                }
                Table();
                return;
            }
        }
    }
}
