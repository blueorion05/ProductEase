using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood
{
    internal class Connection
    {
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
    }
}
