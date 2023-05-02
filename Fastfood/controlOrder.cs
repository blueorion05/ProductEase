using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class controlOrder : UserControl
    {
        public controlOrder()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string DateToday = DateTime.Now.ToString();
                string CatSelected = comboBox1.SelectedItem.ToString();
                dataGridView1.Rows.Add(Tb1.Text, Tb2.Text, DateToday, CatSelected, Tb3.Text);
            }
            catch
            {
                MessageBox.Show("Select category");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
