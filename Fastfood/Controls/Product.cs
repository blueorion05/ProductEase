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
using System;

namespace Fastfood
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void controlProduct_Click(object sender, EventArgs e)
        {
            Product c = (Product)sender;
            formPOS f = Application.OpenForms.OfType<formPOS>().FirstOrDefault()!;
            f.controlProduct_Click(c);
        }

        public DataTable GetData()
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

        private void pbProduct_Click(object sender, EventArgs e)
        {
            OnClick(EventArgs.Empty);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            OnClick(EventArgs.Empty);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            OnClick(EventArgs.Empty);
        }
    }
}
