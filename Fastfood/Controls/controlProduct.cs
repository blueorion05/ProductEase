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
    public partial class controlProduct : UserControl
    {
        public controlProduct()
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

        private void controlProduct_Load(object sender, EventArgs e)
        {

        }

        private void controlProduct_Click(object sender, EventArgs e)
        {
            controlProduct c = (controlProduct)sender;
            //controlProduct c = new controlProduct();
            controlOrder o = new controlOrder();
            string Name = c.lblName.ToString();
            decimal Price = Convert.ToDecimal(c.lblPrice);
            bool found = false;
            for (int i = 0; i < o.dataGridView1.Rows.Count; i++)
            {
                if (o.dataGridView1.Rows[i].Cells["Product_Name"].Value.ToString() == Name)
                {
                    int quantity = Convert.ToInt32(o.dataGridView1.Rows[i].Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(o.dataGridView1.Rows[i].Cells["Price"].Value);
                    quantity++;
                    price += Price;
                    o.dataGridView1.Rows[i].Cells["Quantity"].Value = quantity;
                    o.dataGridView1.Rows[i].Cells["Price"].Value = Price;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                int rowIndex = o.dataGridView1.Rows.Add();
                o.dataGridView1.Rows[rowIndex].Cells["Product_Name"].Value = Name;
                o.dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = 1;
                o.dataGridView1.Rows[rowIndex].Cells["Price"].Value = Price;
            }
        }
    }
}
