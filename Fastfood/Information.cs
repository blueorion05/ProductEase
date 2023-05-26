using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood
{
    internal class Information
    {
        public void GetSettingsInfo(Settings s)
        {
            string data = "SELECT Name, Address, Landline, CpNum, Email, StoreHours FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            s.lblName.Text = reader["Name"].ToString();
            s.lblAddress.Text = reader["Address"].ToString();
            s.lblLandline.Text = reader["Landline"].ToString();
            s.lblCpNum.Text = reader["CpNum"].ToString();
            s.lblEmail.Text = reader["Email"].ToString();
            s.lblStoreHours.Text = reader["StoreHours"].ToString();
            conn.Close();
        }

        public string GetName()
        {
            string data = "SELECT Name FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader["Name"].ToString()!;
            conn.Close();
            return name;
        }

        public void UpdateName(formInformation f)
        {
            string data = "UPDATE Information SET Name = @Name WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateAddress(formInformation f)
        {
            string data = "UPDATE Information SET Address = @Address WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateLandline(formInformation f)
        {
            string data = "UPDATE Information SET Landline = @Landline WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Landline", SqlDbType.Int).Value = Convert.ToInt32(f.textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateCpNum(formInformation f)
        {
            string data = "UPDATE Information SET CpNum = @CpNum WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@CpNum", SqlDbType.Int).Value = Convert.ToInt32(f.textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateEmail(formInformation f)
        {
            string data = "UPDATE Information SET Email = @Email WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateStoreHours(formInformation f)
        {
            string data = "UPDATE Information SET StoreHours = @StoreHours WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@StoreHours", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
