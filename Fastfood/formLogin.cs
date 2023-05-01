namespace Fastfood
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            formMain form2 = new formMain();
            form2.Close();
        }

        private void btn1login_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain form2 = new formMain();
            form2.ShowDialog();
            this.Close();
        }

        private void txb1username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}