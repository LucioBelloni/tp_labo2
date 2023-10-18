using Entidades;
using Main;

namespace Primer
{
    public partial class Main : Form
    {
        private Usuario usuario;
        public Main()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Main_Load(object sender, EventArgs e)
        {
            Login ingresarUsuario = new Login();
            ingresarUsuario.ShowDialog();
            if (ingresarUsuario.DialogResult == DialogResult.OK)
            {
                this.usuario = ingresarUsuario.Usuario;

            }
            else
            {
                this.Close();
            }
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

        private void billeteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBilletera.Dock = DockStyle.Fill;
            // desearilizar

        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelBilletera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDisponibleUsd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            this.usuario.Saldo = double.Parse(txtDepositar.Text);
            this.lblTotalCuentaPesos.Text = this.usuario.Saldo.ToString();
            // serializar 
        }

        private void lblDisponibleAr_Click(object sender, EventArgs e)
        {

        }
    }
}