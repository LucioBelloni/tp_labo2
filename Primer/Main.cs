using Main;

namespace Primer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Application.Run(new Login());
            //this.Close();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void botsDeTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip4_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.MdiParent = this;
            lg.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.MdiParent = this;
            rg.Show();
        }
    }
}