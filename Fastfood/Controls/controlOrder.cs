using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Fastfood
{
    public partial class controlOrder : UserControl
    {
        public controlOrder()
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

        void controlOrder_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
