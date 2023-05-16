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

namespace Fastfood
{
    public partial class formPOS : Form
    {
        public Dictionary<controlProduct, int> Products = new Dictionary<controlProduct, int>();
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

        public void controlProduct_Click(controlProduct c)
        {
            if (c != null)
            {
                if (Products.ContainsKey(c))
                {
                    Products[c]++;
                    double price = Convert.ToDouble(c.lblPrice.Text) * Products[c];
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["Product_Name"].Value.ToString() == c.lblName.Text)
                        {
                            dataGridView1.Rows[i].Cells["Quantity"].Value = Products[c];
                            dataGridView1.Rows[i].Cells["Price"].Value = price.ToString();
                        }
                    }
                }
                else
                {
                    Products.Add(c, 1);
                    AddNew(c);
                }
            }
        }

        private void AddNew(controlProduct c)
        {
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["Product_Name"].Value = c.lblName.Text;
            dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = Products[c];
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
                controlProduct c = new controlProduct();
                if (File.Exists(row["Image"].ToString()))
                {
                    c.pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(row["Image"].ToString()!);
                }
                c.lblName.Text = row["Product_Name"].ToString();
                c.lblPrice.Text = row["Price"].ToString();
                if (row["Available"].ToString() == "Yes")
                {
                    flowLayoutPanel1.Controls.Add(c);
                }
            }
        }
    }
}
