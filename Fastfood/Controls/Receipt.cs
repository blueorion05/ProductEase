using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fastfood
{
    public partial class Receipt : UserControl
    {
        public Receipt()
        {
            InitializeComponent();
        }

        public Image ConvertToImage()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            return bitmap;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Receipt_Resize(object sender, EventArgs e)
        {

        }
    }
}
