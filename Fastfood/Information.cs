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
            string data = "SELECT Name, Address, Landline, CpNum, Email, StoreHours, About FROM Information";
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
            s.label1.Text = reader["About"].ToString();
            conn.Close();

            data = "SELECT username FROM Login";
            conn = sql.GetConnection();
            cmd = new SqlCommand(data, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            s.lblUser.Text = reader["username"].ToString();
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

        public string GetPassword()
        {
            string data = "SELECT password FROM Login";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string password = reader["password"].ToString()!;
            conn.Close();
            return password;
        }

        public int GetTransacNum()
        {
            string data = "SELECT TransacNum FROM Information";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int num = Convert.ToInt32(reader["TransacNum"]);
            conn.Close();
            return num;
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

        public void UpdateAbout(formInformation f)
        {
            string data = "UPDATE Information SET About = @About WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@About", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateUsername(formInformation f)
        {
            string data = "UPDATE Login SET username = @username WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = f.textBox1.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdatePassword(formInformation f)
        {
            string data = "UPDATE Login SET password = @password WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = f.textBox3.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateTransacNum(Receipt r)
        {
            string data = "UPDATE Information SET TransacNum = @TransacNum WHERE Id = @Id";
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            SqlCommand cmd = new SqlCommand(data, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", 1);
            cmd.Parameters.AddWithValue("@TransacNum", SqlDbType.VarChar).Value = r.lblId.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
