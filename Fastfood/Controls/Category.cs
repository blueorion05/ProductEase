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
    public partial class Category : UserControl
    {
        formAddProduct form = new formAddProduct();
        public Category(formAddProduct f)
        {
            InitializeComponent();
            form = f;
        }

        private void Category_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
        }

        private void tableCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                tableCategory.Rows[e.RowIndex].ReadOnly = false;
            }
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tableCategory.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
