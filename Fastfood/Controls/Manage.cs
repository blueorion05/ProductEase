using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fastfood
{
    public partial class Manage : UserControl
    {
        Information info = new Information();
        public Manage()
        {
            InitializeComponent();
            info.ManageTable(this);
        }

        private void controlManage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAddProduct f = new formAddProduct();
            f.ShowDialog();
            info.ManageTable(this);
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                info.AccessEditProduct(this, e);
                return;
            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    info.DeleteProduct(tableProduct.Rows[e.RowIndex].Cells[0].Value.ToString()!);
                }
                info.ManageTable(this);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            info.ManageSearch(this);
        }

        private void Manage_Click(object sender, EventArgs e)
        {

        }
    }
}
