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
    public partial class formStartup : Form
    {
        public formStartup()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Connection sql = new Connection();
            SqlConnection conn = sql.GetConnection();
            conn.Close();
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value == 80)
            {
                progressBar1.Value = 0;
                timerLoad.Stop();
                formLogin f = new formLogin();
                this.Hide();
                f.Show();
            }
        }
        private void StartUp_Load(object sender, EventArgs e)
        {
            timerLoad.Start();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
