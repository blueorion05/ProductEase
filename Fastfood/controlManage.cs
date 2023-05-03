using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Fastfood
{
    public partial class controlManage : UserControl
    {
        String db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\blueorion05\Fastfood\Fastfood\Database\Login.accdb";
        String addData = "INSERT INTO FoodAndDrinks (Category, Item, Price) VALUES (?,?,?)";
        public OleDbConnection conn = new OleDbConnection();
        string FoodAndDrinks = "SELECT * FROM FoodAndDrinks";
        public controlManage()
        {
            conn = new OleDbConnection(db);

            InitializeComponent();
        }

        private void controlManage_Load(object sender, EventArgs e)
        {
            TableData();
        }

        private void TableData()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(FoodAndDrinks, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            tableItems.Rows.Clear();
            while (reader.Read())
            {
                tableItems.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            OleDbCommand addDataCommand;
            addDataCommand = new OleDbCommand(addData, conn);
            addDataCommand.Parameters.AddWithValue("Category", OleDbType.VarChar).Value = tbCategory.Text;
            addDataCommand.Parameters.AddWithValue("Item", OleDbType.VarChar).Value = tbItem.Text;
            addDataCommand.Parameters.AddWithValue("Price", OleDbType.VarChar).Value = tbPrice.Text;
         
            conn.Open();
            int dataInserted = addDataCommand.ExecuteNonQuery();

            if (dataInserted > 0)
            {
                MessageBox.Show("Added");
                conn.Close();
                TableData();
            }
            conn.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgDialog = new OpenFileDialog();
            DialogResult imgResult = imgDialog.ShowDialog();
            if (imgResult == DialogResult.OK)
            {
                string fileName = imgDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
            }
        }
    }
}
